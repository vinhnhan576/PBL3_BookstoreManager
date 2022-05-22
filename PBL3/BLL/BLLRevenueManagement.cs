using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;

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

        public List<RevenueChartView> GetAllRevenueByDate_ChartView(DateTime startDate, DateTime endDate, string chartType)
        {
            List<RevenueChartView> revenues = new List<RevenueChartView>();
            int noDays = (endDate - startDate).Days;
            if(noDays == 1)
            {
                chartType = "Day";
            }
            else if(noDays <= 7)
            {
                chartType = "Week";
            }
            else if(noDays <= 31)
            {
                chartType = "Month";
            }
            else if(noDays <= 365)
            {
                int noMonths = (int)(noDays / 30);
                DateTime[] months = new DateTime[noMonths];
                double[] totals = new double[noMonths];
                int currentMonth = startDate.Month;
                int receiptMonth, j =0;
                foreach (Revenue i in QLSPEntities.Instance.Revenues.Select(p => p).ToList())
                {
                    int month = i.Receipt_Detail.Receipt.Date.Month;
                    int year = i.Receipt_Detail.Receipt.Date.Year;
                    if ((month >= startDate.Month && month <= endDate.Month && (year == startDate.Year || year == endDate.Year)))
                    {
                        receiptMonth = i.Receipt_Detail.Receipt.Date.Month;
                        if (currentMonth != receiptMonth)
                        {
                            currentMonth = receiptMonth;
                            j++;
                        }
                        months[j] = i.Receipt_Detail.Receipt.Date;
                        totals[j] += (double)i.GrossRevenue;
                    }
                }
                for(int i = 0; i < noMonths; i++)
                {
                    RevenueChartView rcv = new RevenueChartView
                    {
                        date = months[i],
                        total = totals[i],
                    };
                    revenues.Add(rcv);
                }
                chartType = "Year";
            }
            return revenues;
        }


        public void AddRevenue(string recieptDetailID, double expenses, double grossrevenue, double profit)
        {
            int count = QLSPEntities.Instance.Revenues.Count() + 1;
            string revenueID = (count < 100 ? (count < 10 ? "00" + count.ToString() : "0" + count.ToString()) : count.ToString());
            Revenue revenue = new Revenue { RevenueID = count.ToString(), ReceiptDetailID = recieptDetailID, Expenses = expenses, GrossRevenue = grossrevenue, Profit = profit };
            QLSPEntities.Instance.Revenues.Add(revenue);
            QLSPEntities.Instance.SaveChanges();
        }

        public dynamic SortRevenue(string sortCategory, bool ascending)
        {
            QLSPEntities db = new QLSPEntities();
            List<Revenue> data = new List<Revenue>();
            if (sortCategory == "Date")
            {
                if (ascending)
                    data = db.Revenues.OrderBy(p => p.Receipt_Detail.Receipt.Date).ToList();
                else
                    data = db.Revenues.OrderByDescending(p => p.Receipt_Detail.Receipt.Date).ToList();
            }
            if (sortCategory == "PersonName")
            {
                if (ascending)
                    data = db.Revenues.OrderBy(p => p.Receipt_Detail.Receipt.Person.PersonName).ToList();
                else
                    data = db.Revenues.OrderByDescending(p => p.Receipt_Detail.Receipt.Person.PersonName).ToList();
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
            var sortedList = data.Select(p => new { p.Receipt_Detail.Receipt.Date, p.Receipt_Detail.Receipt.Person.PersonName, p.Expenses, p.GrossRevenue, p.Profit }).ToList();
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
                            if (i.Receipt_Detail.Receipt.Date.Day == Day && i.Receipt_Detail.Receipt.Date.Month == Month && i.Receipt_Detail.Receipt.Date.Year == Year)
                                data.Add(i);
                        }
                        else
                        {
                            if (i.Receipt_Detail.Receipt.Date.Day == Day && i.Receipt_Detail.Receipt.Date.Month == Month)
                                data.Add(i);
                        }
                    }
                    else
                    {
                        if (year != "")
                        {
                            if (i.Receipt_Detail.Receipt.Date.Day == Day && i.Receipt_Detail.Receipt.Date.Year == Year)
                                data.Add(i);
                        }
                        else
                        {
                            if (i.Receipt_Detail.Receipt.Date.Day == Day)
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
                            if (i.Receipt_Detail.Receipt.Date.Month == Month && i.Receipt_Detail.Receipt.Date.Year == Year)
                                data.Add(i);
                        }
                        else
                        {
                            if (i.Receipt_Detail.Receipt.Date.Month == Month)
                                data.Add(i);
                        }
                    }
                    else
                    {
                        if (year != "")
                        {
                            if (i.Receipt_Detail.Receipt.Date.Year == Year)
                                data.Add(i);
                        }
                    }
                }
            }
            var filteredList = data.Select(p => new { p.Receipt_Detail.Receipt.Date, p.Receipt_Detail.Receipt.Person.PersonName, p.Expenses, p.GrossRevenue, p.Profit });
            return filteredList.ToList();
        }
    }
}
