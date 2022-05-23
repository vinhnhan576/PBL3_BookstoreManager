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
                    rank = i.RankID;
                   
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
    }
    
}
