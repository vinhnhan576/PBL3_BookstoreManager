using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.BLL
{
    public class BLLRevenueManagement
    {
        private static BLLRevenueManagement instance;
        public static BLLRevenueManagement Instance
        {
            get
            {
                if (instance == null)
                    instance = new BLLRevenueManagement();
                return instance;
            }
            private set { }
        }

        private BLLRevenueManagement()
        {

        }

        public List<Revenue> GetAllRevenue()
        {
            List<Revenue> revenues = new List<Revenue>();
            foreach(Revenue i in QLSPEntities.Instance.Revenues.Select(p => p).ToList())
            {
                revenues.Add(i);
            }
            return revenues;
        }

        public dynamic GetAllRevenue_View()
        {
            var revenues = QLSPEntities.Instance.Revenues.Select(p => new {
                p.Receipt_Detail.Receipt.Date, p.Receipt_Detail.Receipt.Person.PersonName, p.Expenses, p.GrossRevenue, p.Profit });
            return revenues.ToList();
        }

        public void AddRevenue(string recieptDetailID, double expenses, double grossrevenue, double profit)
        {
            int count = QLSPEntities.Instance.Revenues.Count() + 1;
            //string revenueID = (count < 100 ? (count < 10 ? "00" + count.ToString() : "0" + count.ToString()) : count.ToString());
            //Revenue revenue = new Revenue{RevenueID = count.ToString(), ReceiptDetailID = recieptDetailID, Expenses = expenses, GrossRevenue = grossrevenue, Profit = profit};
            //QLSPEntities.Instance.Revenues.Add(revenue);
            //QLSPEntities.Instance.SaveChanges();
        }
    }
}
