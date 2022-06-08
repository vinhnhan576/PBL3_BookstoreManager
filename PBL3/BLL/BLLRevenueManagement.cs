using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO.Charts;
using System.Windows.Forms;
using PBL3.Model;

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
            foreach(Revenue i in QLNS.Instance.Revenues.Select(p => p).ToList())
            {
                revenues.Add(i);
            }
            return revenues;
        }

        public dynamic GetAllRevenue_View()
        {
            var revenues = QLNS.Instance.Revenues.Select(p => new {
                p.ReceiptDetail.Receipt.Date, p.ReceiptDetail.Receipt.Person.PersonName, p.Expenses, p.GrossRevenue, p.Profit });
            return revenues.ToList();
        }

        public void AddRevenue(string recieptDetailID, double expenses, double grossrevenue, double profit)
        {
            int count = QLNS.Instance.Revenues.Count() + 1;
            string revenueID = (count < 100 ? (count < 10 ? "00" + count.ToString() : "0" + count.ToString()) : count.ToString());
            Revenue revenue = new Revenue { RevenueID = count.ToString(), ReceiptDetailID = recieptDetailID, Expenses = expenses, GrossRevenue = grossrevenue, Profit = profit };
            QLNS.Instance.Revenues.Add(revenue);
            QLNS.Instance.SaveChanges();
        }

        public dynamic SortRevenue(string sortCategory, bool ascending)
        {
            QLNS db = new QLNS();
            List<Revenue> data = new List<Revenue>();
            if (sortCategory == "Date")
            {
                if (ascending)
                    data = db.Revenues.OrderBy(p => p.ReceiptDetail.Receipt.Date).ToList();
                else
                    data = db.Revenues.OrderByDescending(p => p.ReceiptDetail.Receipt.Date).ToList();
            }
            if (sortCategory == "PersonName")
            {
                if (ascending)
                    data = db.Revenues.OrderBy(p => p.ReceiptDetail.Receipt.Person.PersonName).ToList();
                else
                    data = db.Revenues.OrderByDescending(p => p.ReceiptDetail.Receipt.Person.PersonName).ToList();
            }
            if (sortCategory == "Expenses")
            {
                if (ascending)
                    data = db.Revenues.OrderBy(p => p.Expenses).ToList();
                else
                    data = db.Revenues.OrderByDescending(p => p.Expenses).ToList();
            }
            if (sortCategory == "GrossRevenue")
            {
                if (ascending)
                    data = db.Revenues.OrderBy(p => p.GrossRevenue).ToList();
                else
                    data = db.Revenues.OrderByDescending(p => p.GrossRevenue).ToList();
            }
            if (sortCategory == "Profit")
            {
                if (ascending)
                    data = db.Revenues.OrderBy(p => p.Profit).ToList();
                else
                    data = db.Revenues.OrderByDescending(p => p.Profit).ToList();
            }
            var sortedList = data.Select(p => new { p.ReceiptDetail.Receipt.Date, p.ReceiptDetail.Receipt.Person.PersonName, p.Expenses, p.GrossRevenue, p.Profit }).ToList();
            return sortedList;
        }

        public dynamic FilterRevenueByDate(string day, string month, string year)
        {
            int Day = 0, Month = 0, Year = 0;
            if (day != "")
                Day = Convert.ToInt32(day);
            if (month != "")
                Month = Convert.ToInt32(month);
            if (year != "")
                Year = Convert.ToInt32(year);
            List<Revenue> data = new List<Revenue>();
            foreach (Revenue i in GetAllRevenue())
            {
                if (day != "")
                {
                    if (month != "")
                    {
                        if (year != "")
                        {
                            if (i.ReceiptDetail.Receipt.Date.Day == Day && i.ReceiptDetail.Receipt.Date.Month == Month && i.ReceiptDetail.Receipt.Date.Year == Year)
                                data.Add(i);
                        }
                        else
                        {
                            if (i.ReceiptDetail.Receipt.Date.Day == Day && i.ReceiptDetail.Receipt.Date.Month == Month)
                                data.Add(i);
                        }
                    }
                    else
                    {
                        if (year != "")
                        {
                            if (i.ReceiptDetail.Receipt.Date.Day == Day && i.ReceiptDetail.Receipt.Date.Year == Year)
                                data.Add(i);
                        }
                        else
                        {
                            if (i.ReceiptDetail.Receipt.Date.Day == Day)
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
                            if (i.ReceiptDetail.Receipt.Date.Month == Month && i.ReceiptDetail.Receipt.Date.Year == Year)
                                data.Add(i);
                        }
                        else
                        {
                            if (i.ReceiptDetail.Receipt.Date.Month == Month)
                                data.Add(i);
                        }
                    }
                    else
                    {
                        if (year != "")
                        {
                            if (i.ReceiptDetail.Receipt.Date.Year == Year)
                                data.Add(i);
                        }
                    }
                }
            }
            var filteredList = data.Select(p => new { p.ReceiptDetail.Receipt.Date, p.ReceiptDetail.Receipt.Person.PersonName, p.Expenses, p.GrossRevenue, p.Profit });
            return filteredList.ToList();
        }

        public List<RevenueChartView> GetAllRevenueByDate_ChartView(DateTime startDate, DateTime endDate, string charttype)
        {
            List<RevenueChartView> revenues = new List<RevenueChartView>();
            int noDays = (endDate - startDate).Days + 1;
            if (charttype == "Month")
            {
                DateTime[] days = new DateTime[noDays];
                double[] totals = new double[noDays];
                int temp = -1;
                int day = 0;
                foreach (Revenue i in QLNS.Instance.Revenues.OrderBy(p => p.ReceiptDetail.Receipt.Date).ToList())
                {
                    DateTime date = i.ReceiptDetail.Receipt.Date;
                    if (date >= startDate && date <= endDate)
                    {
                        if (date.Day != day)
                        {
                            day = date.Day;
                            temp++;
                        }
                        days[temp] = date;
                        totals[temp] += (double)i.GrossRevenue;
                    }
                }
                for(int i = 0; i <= temp; i++)
                {
                    RevenueChartView rcv = new RevenueChartView
                    {
                        date = days[i],
                        total = totals[i],
                    };
                    revenues.Add(rcv);
                }
            }
            else if (charttype == "Year")
            {
                DateTime[] months = new DateTime[12];
                double[] totals = new double[12];
                foreach (Revenue i in QLNS.Instance.Revenues.Select(p => p).ToList())
                {
                    DateTime date = i.ReceiptDetail.Receipt.Date;
                    int month = date.Month;
                    if (date >= startDate && date <= endDate)
                    {
                        months[month] = i.ReceiptDetail.Receipt.Date;
                        totals[month] += (double)i.GrossRevenue;
                    }
                }
                for (int i = startDate.Month; i < endDate.Month + 1; i++)
                {
                    RevenueChartView rcv = new RevenueChartView
                    {
                        date = months[i],
                        total = totals[i],
                    };
                    revenues.Add(rcv);
                }
            }
            return revenues;
        }

        public List<TopStaffsChartView> GetTop5Staffs()
        {
            List<TopStaffsChartView> topStaffs = new List<TopStaffsChartView>();
            foreach (Person i in QLNS.Instance.People.Where(p => p.Role == "Salesman").ToList())
            {
                double grossRevenue = 0;
                foreach (Receipt j in i.Receipts)
                {
                    grossRevenue += j.Total;
                }
                topStaffs.Add(new TopStaffsChartView
                {
                    StaffName = i.PersonName,
                    GrossRevenue = grossRevenue,
                });
            }
            topStaffs = topStaffs.OrderByDescending(x => x.GrossRevenue).ToList();
            int k = topStaffs.Count - 1;
            while (k > 4)
            {
                topStaffs.RemoveAt(k);
                k--;
            }
            return topStaffs;
        }

        public List<TopProductChartView> GetTop5Products(bool topDown)
        {
            List<TopProductChartView> topProducts = new List<TopProductChartView>();
            foreach (var i in QLNS.Instance.Products.ToList())
            {
                int quantity = 0;
                foreach (var j in i.Receipt_Details)
                {
                    quantity += j.SellingQuantity;
                }
                TopProductChartView topProductChartView = new TopProductChartView
                {
                    ProductName = i.ProductName,
                    ProductQuantity = quantity,
                };
                topProducts.Add(topProductChartView);
            }
            if(topDown)
                topProducts = topProducts.OrderByDescending(x => x.ProductQuantity).ToList();
            else
                topProducts = topProducts.OrderBy(x => x.ProductQuantity).ToList();
            int k = topProducts.Count - 1;
            while(k > 4)
            {
                topProducts.RemoveAt(k);
                k--;
            }
            return topProducts;
        }

        public DateTime GetFirstDate()
        {
            if (QLNS.Instance.Receipts.Count() > 0)
                return QLNS.Instance.Receipts.OrderBy(p => p.Date).First().Date;
            else return new DateTime();
        }

        public int GetAllVisitors(DateTime startDate, DateTime endDate)
        {
            int noVisitors = 0;
            foreach (ReceiptDetail i in QLNS.Instance.ReceiptDetails.Select(p => p).ToList())
            {
                DateTime date = i.Receipt.Date;
                if (date >= startDate && date <= endDate)
                {
                    noVisitors++;
                }
            }
            return noVisitors;
        }

        public int GetAllNOProductsSold(DateTime startDate, DateTime endDate)
        {
            int noProductsSold = 0;
            foreach (ReceiptDetail i in QLNS.Instance.ReceiptDetails.Select(p => p).ToList())
            {
                DateTime date = i.Receipt.Date;
                if (date >= startDate && date <= endDate)
                {
                    noProductsSold += i.SellingQuantity;
                }
            }
            return noProductsSold;
        }

        public double GetTotalGrossRevenue(DateTime startDate, DateTime endDate)
        {
            double totalGrossRevenue = 0;
            foreach (Revenue i in QLNS.Instance.Revenues.Select(p => p).ToList())
            {
                DateTime date = i.ReceiptDetail.Receipt.Date;
                if (date >= startDate && date <= endDate)
                {
                    totalGrossRevenue += (double)i.GrossRevenue;
                }
            }
            return totalGrossRevenue;
        }
    }
}
