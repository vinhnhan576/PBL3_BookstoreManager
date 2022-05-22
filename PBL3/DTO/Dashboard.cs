using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class Dashboard
    {
        public struct RevenueByDate
        {
            public string date { get; set; }
            public double totalAmount { get; set; }
        }

        private DateTime startDate, endDate;
        private int noDays;

        public int noCustomers { get; private set; }
        public int noProducts { get; private set; }
        public double profitRate { get; private set; }
        public List<KeyValuePair<string, int>> topProductsList { get; private set; }
        public List<RevenueByDate> grossRevenueList { get; private set; }
        public int noOrders { get; set; }
        public double totalRevenue { get; set; }
        public double tatoalProfit { get; set; }

        public Dashboard()
        {

        }

        private void getNoItems()
        {
            noCustomers = QLSPEntities.Instance.Customers.Count();
            noProducts = QLSPEntities.Instance.Products.Count();
            
        }

        private void AnalizeReceipt()
        {
            grossRevenueList = new List<RevenueByDate>();

        }
    }
}
