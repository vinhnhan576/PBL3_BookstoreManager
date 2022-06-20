using System;
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
        public string GetRandomReceiptID()
        {
            return "rpt" + (QLNS.Instance.Receipts.Count() + 1).ToString();
        }
        public List<Receipt> GetAllReceipt()
        {
            return QLNS.Instance.Receipts.Select(p => p).ToList();   
        }
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
            var product = QLNS.Instance.ReceiptDetails.Where(p => p.ReceiptID == ID_Receipt).Select(p => new { p.Product.ProductName, p.SellingQuantity,p.SellingPrice, p.Total }).ToList();
            return product;
        }
        public void CreateReceiptDetailView(Order order, Product p, int quantity)
        {
            string receiptid ="r"+Convert.ToString(QLNS.Instance.Receipts.Count() + 1)+Convert.ToString(order.Rdv_List.Count() + 1);
            order.CreateReceiptDetailView(p, quantity, receiptid);
        }
        public void AddNewReceiptDetail(Order order, string receipt_id)
        {
            for (int i = 0; i < order.Rdv_List.Count; i++)
            {
                ReceiptDetail r = new ReceiptDetail();
                r.ReceiptDetailID = order.Rdv_List[i].ReceiptDetailID;
                r.ProductID = order.Rdv_List[i].ProductID;
                r.SellingQuantity = order.Rdv_List[i].Quantity;
                r.SellingPrice = order.Rdv_List[i].SellingPrice;
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
        public List<ReceiptView> FilterReceipt(string filterValue)
        {
            List<ReceiptView> data = new List<ReceiptView>();
            foreach (ReceiptView i in GetAllReceipt_View())
            { 
                if (filterValue=="Valid")
                {
                    data = FilterReceiptStatus(true);
                }
                if (filterValue == "Invalid")
                {
                    data = FilterReceiptStatus(false);
                }
                if (i.Salesman == filterValue)
                {
                    data.Add(i);
                }
            }
            return data;
        }
        public List<ReceiptView> FilterReceiptStatus(bool filterValue)
        {
            List<ReceiptView> data = new List<ReceiptView>();
            foreach (ReceiptView i in GetAllReceipt_View())
            {
                if (i.Status == filterValue)
                {
                    data.Add(i);
                }    
            }
            return data;
        }
        public List<ReceiptView> GetAllReceipt_View()
        {
            List<ReceiptView> list = new List<ReceiptView>();
            foreach(Receipt i in GetAllReceipt())
            {
                ReceiptView r = new ReceiptView();
                r.ReceiptID = i.ReceiptID;
                r.Salesman = i.Person.PersonName;
                if (i.PhoneNumber == null)
                    r.Customer = "";
                else
                {
                    r.Customer = i.Customer.CustomerName;
                }
                r.Date = i.Date;
                r.Total = i.Total;
                r.Status = i.Status;
                list.Add(r);
            }
            return list;
        }
        public dynamic SortReceipt(string sortCategory, bool ascending)
        {
            List<ReceiptView> data = GetAllReceipt_View();
            if (sortCategory == "Receipt ID")
            {
                if (ascending)
                    data = data.OrderBy(p => p.ReceiptID).ToList();
                else
                    data.OrderByDescending(p => p.ReceiptID).ToList();
            }
            if (sortCategory == "Date")
            {
                if (ascending)
                    data = data.OrderBy(p => p.Date).ToList();
                else
                    data = data.OrderByDescending(p => p.Date).ToList();
            }
            if (sortCategory == "Total")
            {
                if (ascending)
                    data = data.OrderBy(p => p.Total).ToList();
                else
                    data = data.OrderByDescending(p => p.Total).ToList();
            }
            return data;
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
        public dynamic FilterReceiptByDate(string day, string month, string year)
        {
            int Day = 0, Month = 0, Year = 0;
            if (day != "")
                Day = Convert.ToInt32(day);
            if (month != "")
                Month = Convert.ToInt32(month);
            if (year != "")
                Year = Convert.ToInt32(year);
            List<ReceiptView> data = new List<ReceiptView>();
            foreach (ReceiptView i in GetAllReceipt_View())
            {
                if (day != "")
                {
                    if (month != "")
                    {
                        if (year != "")
                        {
                            if (i.Date.Day == Day && i.Date.Month == Month && i.Date.Year == Year)
                                data.Add(i);
                        }
                        else
                        {
                            if (i.Date.Day == Day && i.Date.Month == Month)
                                data.Add(i);
                        }
                    }
                    else
                    {
                        if (year != "")
                        {
                            if (i.Date.Day == Day && i.Date.Year == Year)
                                data.Add(i);
                        }
                        else
                        {
                            if (i.Date.Day == Day)
                                data.Add(i);
                        }
                    }
                }
                else
                {
                    if (month != "")
                    {
                        if (year != "")
                        {
                            if (i.Date.Month == Month && i.Date.Year == Year)
                                data.Add(i);
                        }
                        else
                        {
                            if (i.Date.Month == Month)
                                data.Add(i);
                        }
                    }
                    else
                    {
                        if (year != "")
                        {
                            if (i.Date.Year == Year)
                                data.Add(i);
                        }
                    }
                }
            }
            return data;
        }
        public List<string> GetAllReceiptStatus()
        {
            List<string> ReceiptStatusList = new List<string>();
            foreach (ReceiptView i in GetAllReceipt_View())
            {
                if (i.Status == true)
                    ReceiptStatusList.Add("Valid");
                else if(i.Status==false)
                {
                    ReceiptStatusList.Add("Invalid");
                }
            }
            return ReceiptStatusList;
        }
        public List<string> GetAllReceiptSalesman()
        {
            List<string> ReceiptSalesmanList = new List<string>();
            foreach (ReceiptView i in GetAllReceipt_View())
            {
                ReceiptSalesmanList.Add(i.Salesman);
            }
            return ReceiptSalesmanList;
        }
    }
}