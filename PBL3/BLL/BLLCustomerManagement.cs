using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.BLL
{
    public class BLLCustomerManagement
    {
        private static BLLCustomerManagement instance;
        public static BLLCustomerManagement Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BLLCustomerManagement();
                }
                return instance;
            }
            private set { }
        }

        public List<Customer> GetAllCustomer()
        {
            List<Customer> customerList = new List<Customer>();
            foreach(Customer customer in QLSPEntities.Instance.Customers.Select(p => p).ToList())
                customerList.Add(customer);
            return customerList;
        }

        public dynamic GetAllCustomer_View()
        {
            var customerList = QLSPEntities.Instance.Customers.Select(p => new
            {
                p.CustomerID,
                p.CustomerName,
                p.PhoneNumber,
                p.Rank.RankName,
                p.TotalSpending,
            });
            return customerList.ToList();
        }
        public void AddNewCustomer(Customer r)
        {
            QLSPEntities.Instance.Customers.Add(r);
            QLSPEntities.Instance.SaveChanges();
        }
        public bool Customer_Check(string tel)
        {
            List<Customer> data = QLSPEntities.Instance.Customers.Select(p=>p).ToList();
            for (int i = 0; i<data.Count ; i++)
            {
                if (data[i].PhoneNumber.Trim() == tel)
                {
                    return true;
                }

            }
            return false;
        }
        public dynamic CalculateCustomerTotal(string id)
        {
            var customertotal = QLSPEntities.Instance.Receipts.Where(p => p.CustomerID == id).Select(p => p.Total).Sum();

            return customertotal;

        }
        public void UpdateTotalSpending(string customerphone, double totalspending)
        {
            string temp = "";
            foreach (var customer in QLSPEntities.Instance.Customers)
            {
                if (customer.PhoneNumber == customerphone)
                {
                    temp = customer.CustomerID;
                    break;
                }

            }
            var customertemp = QLSPEntities.Instance.Customers.Find(temp);
            customertemp.TotalSpending += totalspending;
            QLSPEntities.Instance.SaveChanges();

        }
        public void UpdateRankCustomer(string CustomerID, string RankID)
        {
            var customer = QLSPEntities.Instance.Customers.Find(CustomerID);
            customer.RankID = RankID;
            QLSPEntities.Instance.SaveChanges();
        }
        public void UpdateUsed(string CustomerID)
        {
            var customer = QLSPEntities.Instance.Customers.Find(CustomerID);
            customer.Used++;
            QLSPEntities.Instance.SaveChanges();
        }
        public Customer getCustomerID(string tel)
        {
            foreach (var customer in QLSPEntities.Instance.Customers)
            {
                if (customer.PhoneNumber == tel)
                {
                    return customer;
                }

            }
            return null;
        }
        public void SaveCustomer(Customer customer, double total)
        {
            BLLCustomerManagement.Instance.UpdateTotalSpending(customer.PhoneNumber, total);
            double totaltemp = (double)customer.TotalSpending;
            string rankID = BLLRankManagement.Instance.GetRankIDByReQuirement(totaltemp);
            BLLCustomerManagement.Instance.UpdateRankCustomer(customer.CustomerID, rankID);
        }
        public dynamic GetReceiptByCustomerID(string customerid)
        {
            if (customerid == "")
                 return QLSPEntities.Instance.Receipts.Select(p => p).ToList();
            else
                return QLSPEntities.Instance.Receipts.Where(p => p.CustomerID == customerid).Select(p => new {p.ReceiptID,p.Date,p.Total}).ToList();
        }
        //public dynamic GetProductByListReceipt(List<Receipt> receiptlist)
        //{
        //    List<Product> AllProduct = new List<Product>();
        //   foreach(Receipt receipt in receiptlist)
        //    {
        //        var = QLSPEntities.Instance.Receipt_Details.Where(p => p.ReceiptID == receipt.ReceiptID).Select(p =>p.Product).ToList();
        //        for(int i = 0; i < product.Count; i++)
        //        {
        //            AllProduct.Add(product[i]);
        //        }

        //    }
        //   return AllProduct.Select{p=>}
        //}
        public dynamic SearchCustomer(string searchValue)
        {
            List<Customer> data = new List<Customer>();
            foreach (Customer i in QLSPEntities.Instance.Customers.Select(p => p).ToList())
            {
                bool containID = i.CustomerID.IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0;
                bool containCustomerName = i.CustomerName.IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0;
                if (containID || containCustomerName)
                {
                    data.Add(i);
                }

            }
            var List = data.Select(p => new { p.CustomerID, p.CustomerName, p.PhoneNumber, p.Rank.RankName, p.TotalSpending });
            return List.ToList();
        }

        public dynamic FilterCustomer(string searchValue)
        {
            List<Customer> data = new List<Customer>();
            bool containRank = false;
            foreach (Customer i in QLSPEntities.Instance.Customers.Select(p => p).ToList())
            {
                containRank = i.Rank.RankName.IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0;
                if (containRank)
                {
                    data.Add(i);
                }

            }
            var List = data.Select(p => new { p.CustomerID, p.CustomerName, p.PhoneNumber, p.Rank.RankName, p.TotalSpending });
            return List.ToList();
        }

        public dynamic SortCustomer(string sortCategory, bool ascending)
        {
            QLSPEntities db = new QLSPEntities();
            List<Customer> data = new List<Customer>();
            if (sortCategory == "Customer ID")
            {
                if (ascending)
                    data = db.Customers.OrderBy(p => p.CustomerID).ToList();
                else
                    data = db.Customers.OrderByDescending(p => p.CustomerID).ToList();
            }
            if (sortCategory == "Customer Name")
            {
                if (ascending)
                    data = db.Customers.OrderBy(p => p.CustomerName).ToList();
                else
                    data = db.Customers.OrderByDescending(p => p.CustomerName).ToList();
            }
            if (sortCategory == "TotalSpending")
            {
                if (ascending)
                    data = db.Customers.OrderBy(p => p.TotalSpending).ToList();
                else
                    data = db.Customers.OrderByDescending(p => p.TotalSpending).ToList();
            }
            var newList = data.Select(p => new { p.CustomerID, p.CustomerName, p.PhoneNumber, p.Rank.RankName, p.TotalSpending }).ToList();
            return newList;
        }
        public List<string> GetAllCustomerRank()
        {
            List<string> RankList = new List<string>();
            foreach (Rank i in QLSPEntities.Instance.Ranks.Select(p=>p).ToList())
            {
                RankList.Add(i.RankName);
            }
            return RankList;
        }
        public void Refresh()
        {
            DateTime now = DateTime.Now;
            if (now.Hour==20&&now.Minute==42)
            {
                List<Customer> list = QLSPEntities.Instance.Customers.Select(p => p).ToList();
                foreach (Customer c in list)
                {
                    c.Used = 0;
                }
                QLSPEntities.Instance.SaveChanges();
            }
        }
        
    }
}
