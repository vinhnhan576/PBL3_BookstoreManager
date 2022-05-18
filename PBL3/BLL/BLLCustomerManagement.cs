using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                p.Rank.RankName
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
        public void UpdateTotalSpending(string customerphone,double totalspending)
        {
            string temp="";
            foreach (var customer in QLSPEntities.Instance.Customers)
            {
                if (customer.PhoneNumber == customerphone)
                {
                    temp = customer.CustomerID;
                    break;
                }
                    
            }
            var customertemp=QLSPEntities.Instance.Customers.Find(temp);
            customertemp.TotalSpending += totalspending;
            QLSPEntities.Instance.SaveChanges();
            
        }
        public string getCustomerID(string tel)
        {

            foreach (var customer in QLSPEntities.Instance.Customers)
            {
                if (customer.PhoneNumber == tel)
                {
                    return customer.CustomerID;
                }

            }
            return null;

        }
 
    }
}
