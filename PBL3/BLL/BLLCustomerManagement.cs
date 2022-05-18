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
        public int Customer_Check(string telephone)
        {
            List<Customer> data = QLSPEntities.Instance.Customers.Select(p=>p).ToList();
            for (int i = 0; i <data.Count; i++)
            {
                if (data[i].PhoneNumber == telephone)
                {
                    return i;
                }

            }
            return -1;
        }
        public dynamic CalculateCustomerTotal(string id)
        {
            var customertotal = QLSPEntities.Instance.Receipts.Where(p => p.CustomerID ==id).Select(p => p.Total).Sum();

            return customertotal;

        }
    }
}
