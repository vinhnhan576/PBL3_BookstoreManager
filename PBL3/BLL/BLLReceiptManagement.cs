﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;
using PBL3.Model;

namespace PBL3.BLL
{
    internal class BLLReceiptManagement
    {
        private static BLLReceiptManagement instance;
        public static BLLReceiptManagement Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BLLReceiptManagement();
                }
                return instance;
            }
            private set
            {
            }
        }

        /// <summary>
        /// CRUD
        /// </summary>
        /// <param name="r"></param>
        public void AddNewReceipt(Receipt r)
        {
            QLNS.Instance.Receipts.Add(r);
            QLNS.Instance.SaveChanges();
        }

        public void AddNewReceiptDetail(ReceiptDetail r)
        {
            QLNS.Instance.ReceiptDetails.Add(r);
            QLNS.Instance.SaveChanges();
        }
        public dynamic GetProductInReceiptByID(string ID_Receipt)
        {

            //foreach (Receipt_Detail temp in QLSPEntities.Instance.Receipts.Find(ID_Receipt).Receipt_Detail)
            //{
            //    temp.Total = temp.SellingQuantity * (temp.Product.SellingPrice);
            //    QLSPEntities.Instance.SaveChanges();
            //}
            var product = QLNS.Instance.ReceiptDetails.Where(p => p.ReceiptID == ID_Receipt).Select(p => new { p.Product.ProductName, p.SellingQuantity, p.Total }).ToList();
            return product;
        }
        public Receipt GetReceiptByReceiptDetailID(string rdID)
        {
            Receipt receipt = new Receipt();
            foreach(Receipt i in QLNS.Instance.Receipts.Select(p => p).ToList())
            {
                foreach(ReceiptDetail rd in i.ReceiptDetails)
                {
                    if(rd.ReceiptDetailID == rdID)
                    {
                        receipt = i;
                        break;
                    }
                }
            }
            return receipt;
        }

        public void CreateReceiptDetailView(Order order, Product p, int quantity)
        {
            string receiptid ="r"+Convert.ToString(QLNS.Instance.Receipts.Count() + 1)+Convert.ToString(order.Rdv_List.Count() + 1);
            order.CreateReceiptDetailView(p, quantity, receiptid);
        }
        public void AddNewReceiptDetail(List<ReceiptDetailView> list, string receipt_id)
        {
            for(int i=0;i<list.Count;i++)
            {
                ReceiptDetail r = new ReceiptDetail();
                r.ReceiptDetailID = list[i].ReceiptDetailID;
                r.ProductID= list[i].ProductID;
                r.SellingQuantity = list[i].Quantity;
                r.Total=list[i].Total;
                r.ReceiptID = receipt_id;
                AddNewReceiptDetail(r);
            }
        }
        public void AddNewReceiptDetail(Order order, string receipt_id)
        {
            for (int i = 0; i < order.Rdv_List.Count; i++)
            {
                ReceiptDetail r = new ReceiptDetail();
                r.ReceiptDetailID = order.Rdv_List[i].ReceiptDetailID;
                r.ProductID = order.Rdv_List[i].ProductID;
                r.SellingQuantity = order.Rdv_List[i].Quantity;
                r.Total = order.Rdv_List[i].Total;
                r.ReceiptID = receipt_id;
                AddNewReceiptDetail(r);
            }
        }
        public List<ReceiptDetail> getReceiptDetailByReceiptID(string ID_Receipt)
        {

            if (ID_Receipt == "")
                return QLNS.Instance.ReceiptDetails.Select(p => p).ToList();
            else
                return QLNS.Instance.ReceiptDetails.Where(p => p.ReceiptID == ID_Receipt).ToList();
        }
        public double CalculateReceiptToTal(Order order)
        {
            SingleDiscount d = new SingleDiscount();
            order.SetDiscountStrategy(d);
            order.CalculateReceiptToTal();
            ComboDiscount combo = new ComboDiscount();
            order.SetDiscountStrategy(combo);
            return order.CalculateReceiptToTal();
        }
        public double getPromotedDiscount(Order order)
        {
            ComboDiscount combo = new ComboDiscount();
            order.SetDiscountStrategy(combo);
            return order.getPromotedDiscount();
        }

        public dynamic GetAllBill_View()
        {
            var billList = QLNS.Instance.Receipts.Select(p => new
            {
                p.ReceiptID,
                p.Person.PersonName,
                p.Date,
                p.Total
            });
            return billList.ToList();
        }
        public dynamic SearchReceipt(string searchValue)
        {
            List<Receipt> data = new List<Receipt>();
            foreach (Receipt i in QLNS.Instance.Receipts.Select(p => p).ToList())
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
            var ReceiptList = data.Select(p => new { p.ReceiptID, p.Person.PersonName, p.Date, p.Total, p.Status });
            return ReceiptList.ToList();
        }
        public dynamic GetAllReceipt_View()
        {
            QLNS db = new QLNS();
            var product = db.Receipts.OrderBy(r => r.ReceiptID.Length).ThenBy(r => r.ReceiptID).Select(p => new { p.ReceiptID, p.Person.PersonName, p.Date, p.Total, p.Status });
            return product.ToList();
        }
        public dynamic SortReceipt(string sortCategory, bool ascending)
        {
            QLNS db = new QLNS();
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
            var newList = data.Select(p => new { p.ReceiptID, p.Person.PersonName, p.Date, p.Total, p.Status }).ToList();
            return newList;
        }
        public void ChangeStatusReceipt(List<string> receiptids)
        {
            foreach (string receiptid in receiptids)
            {
                Receipt r = QLNS.Instance.Receipts.Find(receiptid);
                r.Status = false;
                if (r.PhoneNumber != null)
                {
                    Customer c = QLNS.Instance.Customers.Find(r.PhoneNumber);
                    c.TotalSpending = c.TotalSpending - r.Total;
                }
                foreach (ReceiptDetail i in getReceiptDetailByReceiptID(r.ReceiptID))
                {
                    Product p = QLNS.Instance.Products.Find(i.ProductID);
                    p.StoreQuantity += i.SellingQuantity;
                }
                QLNS.Instance.SaveChanges();
            }
        }
    }
}