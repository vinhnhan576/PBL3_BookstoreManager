﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;



namespace PBL3.BLL
{
    internal class BLLReceiptManagement
    {



        private static BLLReceiptManagement _instance;



        public static BLLReceiptManagement Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BLLReceiptManagement();
                }
                return _instance;
            }
            private set
            {
            }
        }
        public void AddNewReceipt(Receipt r)
        {
            QLSPEntities.Instance.Receipts.Add(r);
            QLSPEntities.Instance.SaveChanges();
        }
        public void AddNewReceiptDetail(Receipt_Detail r)
        {

            QLSPEntities.Instance.Receipt_Details.Add(r);
            QLSPEntities.Instance.SaveChanges();
        }
        public dynamic GetProductInReceiptByID(string ID_Receipt)
        {
            var product = QLSPEntities.Instance.Receipt_Details.Where(p => p.ReceiptID == ID_Receipt).Select(p => new { p.ProductID, p.Product.ProductName, p.SellingQuantity, p.Product.SellingPrice, p.Total }).ToList();
            return product;
        }

        public Receipt GetReceiptByReceiptDetailID(string rdID)
        {
            Receipt receipt = new Receipt();
            foreach (Receipt i in QLSPEntities.Instance.Receipts.Select(p => p).ToList())
            {
                foreach (Receipt_Detail rd in i.Receipt_Detail)
                {
                    if (rd.ReceipDetailtID == rdID)
                    {
                        receipt = i;
                        break;
                    }
                }
            }
            return receipt;
        }

        public ReceiptDetailView CreateReceiptDetailView(string productid, int quantity, int count)
        {
            var random = new RandomGenerator();
            ReceiptDetailView temp = new ReceiptDetailView();
            var Product = QLSPEntities.Instance.Products.Find(productid);
            temp.ReceiptDetailID = "rd" + random.RandomNumber(100, 99999);
            temp.ProductID = productid;
            temp.ProductName = Product.ProductName;
            temp.SellingPrice = Product.SellingPrice;
            temp.Quantity = quantity;
            temp.Total = temp.SellingPrice * quantity;
            return temp;

        }
        public void AddNewReceiptDetail(List<ReceiptDetailView> list, string receipt_id)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Receipt_Detail r = new Receipt_Detail();
                r.ReceipDetailtID = list[i].ReceiptDetailID;
                r.ProductID = list[i].ProductID;
                r.SellingQuantity = list[i].Quantity;
                r.Total = list[i].Total;
                r.ReceiptID = receipt_id;
                BLLReceiptManagement.Instance.AddNewReceiptDetail(r);
            }
        }

        public List<Receipt_Detail> getReceiptDetailByReceiptID(string ID_Receipt)
        {

            if (ID_Receipt == "")
                return QLSPEntities.Instance.Receipt_Details.Select(p => p).ToList();
            else
                return QLSPEntities.Instance.Receipt_Details.Where(p => p.ReceiptID == ID_Receipt).ToList();
        }





        public double CalculateReceiptToTal(List<ReceiptDetailView> list)
        {
            double total = 0;
            for (int i = 0; i < list.Count; i++)
            {
                total += list[i].Total;
            }
            return total;



        }
        public int ReceiptDetailView_Check(List<ReceiptDetailView> list, string product_id)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].ProductID == product_id)
                {
                    return 1;
                }

            }
            return 0;
        }
        public dynamic GetAllReceipt_View()
        {
            QLSPEntities db = new QLSPEntities();
            var product = db.Receipts.Select(p => new { p.ReceiptID, p.Person.PersonName, p.Date, p.Total});
            return product.ToList();
        }
        public dynamic SearchReceipt(string searchValue)
        {
            List<Receipt> data = new List<Receipt>();
            foreach (Receipt i in QLSPEntities.Instance.Receipts.Select(p => p).ToList())
            {
                bool containID = i.ReceiptID.IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0;
                bool containSalesmanName = i.Person.PersonName.IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0;
                //bool containCustomer = i.Customer.CustomerName.IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0;
                //bool containCustomerID = i.Customer.CustomerName.IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0;
                bool containSalemansID = i.PersonID.IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0;
                string dateTemp = i.Date.ToShortDateString();
                bool containDate = dateTemp.IndexOf(searchValue) >= 0;
                if (containID || containSalesmanName || containSalemansID || containDate)
                {
                    data.Add(i);
                }
            }
            var ReceiptList = data.Select(p => new { p.ReceiptID, p.Person.PersonName, p.Date, p.Total });
            return ReceiptList.ToList();

        }
        //public List<string> getReceiptStatus()
        //{
        //    List<string> statuslist = new List<string>();
        //    foreach (Receipt i in QLSPEntities.Instance.Receipts.Select(p => p).ToList())
        //    {
        //        statuslist.Add(i.Status);
        //    }
        //    return statuslist;
        //}
        public dynamic SortReceipt(string sortCategory, bool ascending)
        {
            QLSPEntities db = new QLSPEntities();
            List<Receipt> data = new List<Receipt>();
            if (sortCategory == "Receipt ID")
            {
                if (ascending)
                    data = db.Receipts.OrderBy(p => p.ReceiptID).ToList();
                else
                    data = db.Receipts.OrderByDescending(p => p.ReceiptID).ToList();
            }
            if (sortCategory == "Date")
            {
                if (ascending)
                    data = db.Receipts.OrderBy(p => p.Date).ToList();
                else
                    data = db.Receipts.OrderByDescending(p => p.Date).ToList();
            }
            if (sortCategory == "Total")
            {
                if (ascending)
                    data = db.Receipts.OrderBy(p => p.Total).ToList();
                else
                    data = db.Receipts.OrderByDescending(p => p.Total).ToList();
            }
            var newList = data.Select(p => new { p.ReceiptID, p.Person.PersonName, p.Date, p.Total }).ToList();
            return newList;
        }


    }
}