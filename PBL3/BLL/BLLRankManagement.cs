using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.Model;

namespace PBL3.BLL
{   public class BLLRankManagement
    {
        private static BLLRankManagement _instance;
        public static BLLRankManagement Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new BLLRankManagement();
                return _instance;
            }
            private set { }
        }
        public string GetRankIDByReQuirement(double total)
        {
            string rank ="";
            foreach (var i in QLNS.Instance.Ranks.Select(p => p).ToList())
            {
                if (total >= i.Requirement)
                {
                    rank = i.RankID.Trim();                
                }
            }
            return rank;
        }
        public double GetDiscountByReQuirement(double total)
        {
            double discount = 0;
            foreach (var i in QLNS.Instance.Ranks.Select(p => p).ToList())
            {
                if (total >= i.Requirement)
                {
                    discount = i.CustomerDiscount;
                }
            }
            return discount;
        }
        public double GetTotalAfterDisount(string Rankid,double TotalBefore)
        {
            Rank rank = QLNS.Instance.Ranks.Find(Rankid);
            double TotalAfter = Convert.ToDouble(rank.CustomerDiscount)/100 * TotalBefore;
            return TotalAfter;
        }
        public dynamic GetAllRank_View()
        {
            var discountList = QLNS.Instance.Ranks.OrderBy(r => r.RankID.Length).ThenBy(r => r.RankID).Select(p => new {p.RankID,p.RankName,p.Requirement,p.CustomerDiscount});
            return discountList.ToList();
        }
        public void AddNewRank(Rank rank)
        {
            QLNS.Instance.Ranks.Add(rank);
            BLLRankManagement.Instance.UpdateAllCustomerRank();
            QLNS.Instance.SaveChanges();
        }
        public void EditRank(Rank d)
        {
            Rank temp = QLNS.Instance.Ranks.Find(d.RankID);
            temp.RankID = d.RankID;
            temp.RankName = d.RankName;
            temp.Requirement = d.Requirement;
            temp.CustomerDiscount = d.CustomerDiscount;
            BLLRankManagement.Instance.UpdateAllCustomerRank();
            QLNS.Instance.SaveChanges();
        }
        public void DelRank(List<string> ID)
        {
            foreach (string i in ID)
            {
                Rank r = QLNS.Instance.Ranks.Find(i);
                QLNS.Instance.Ranks.Remove(r);
                QLNS.Instance.SaveChanges();
            }
            BLLRankManagement.Instance.UpdateAllCustomerRank();
        }
        public void Execute(Rank r)
        {
            if (Check(r.RankID) == true)
            {
               EditRank(r);
            }
            else
            {
              AddNewRank(r);
            }
        }
        public bool Check(string ID)
        { 
            bool Add = false;
            foreach (Rank r in QLNS.Instance.Ranks.Select(p => p).ToList())
            {
                if (r.RankID == ID)
                {
                    Add = true;
                    break;
                }
            }
            return Add;
        }
        public dynamic SearchRank(string searchValue)
        {
            List<Rank> data = new List<Rank>();
            foreach (Rank i in GetAllRank_View())
            {
                bool containName = i.RankName.IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0;
                bool containId = i.RankID.IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0;
                if (containName || containId)
                {
                    data.Add(i);
                }
            }
            return data;
        }
        public dynamic SortRank(string sortCategory, bool ascending)
        {
            QLNS db = new QLNS();
            List<Rank> data = new List<Rank>();
            if (sortCategory == "Rank ID")
            {
                if (ascending)
                {
                    data = db.Ranks.OrderBy(r => r.RankID.Length).ThenBy(r => r.RankID).ToList();
                }
                else
                {
                    data = db.Ranks.OrderByDescending(r => r.RankID.Length).ThenByDescending(r => r.RankID).ToList();
                }
            }
            if (sortCategory == "Rank Name")
            {
                if (ascending)
                    data = db.Ranks.OrderBy(p => p.RankName).ToList();
                else
                    data = db.Ranks.OrderByDescending(p => p.RankName).ToList();
            }
            if (sortCategory == "Requirement")
            {
                if (ascending)
                    data = db.Ranks.OrderBy(p => p.Requirement).ToList();
                else
                    data = db.Ranks.OrderByDescending(p => p.Requirement).ToList();
            }
            if (sortCategory == "Customer Discount")
            {
                if (ascending)
                    data = db.Ranks.OrderBy(p => p.CustomerDiscount).ToList();
                else
                    data = db.Ranks.OrderByDescending(p => p.CustomerDiscount).ToList();
            }
            var sortedList = data.ToList();
            return sortedList;
        }
        public void UpdateAllCustomerRank()
        {
            List<Customer> list = QLNS.Instance.Customers.Select(p => p).ToList();
            foreach(Customer customer in list)
            {
                string rankid = GetRankIDByReQuirement(customer.TotalSpending);
                BLLCustomerManagement.Instance.UpdateRankCustomer(customer.PhoneNumber, rankid);
            }
        }
        public void RenewCustomers(List<Customer> customers)
        {
            foreach (Customer i in customers)
            {
                i.Used = 0;
            }
        }
    }

}
