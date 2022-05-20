using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            foreach (var i in QLSPEntities.Instance.Ranks.Select(p => p).ToList())
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
            foreach (var i in QLSPEntities.Instance.Ranks.Select(p => p).ToList())
            {
                if (total >= i.Requirement)
                {
                    discount = i.CustomerDiscount___;
                }

            }
            return discount;
        }
        public double GetTotalAfterDisount(string Rankid,double TotalBefore)
        {
            Rank rank = QLSPEntities.Instance.Ranks.Find(Rankid);
            double TotalAfter = Convert.ToDouble(rank.CustomerDiscount___)/100 * TotalBefore;
            return TotalAfter;
        }
    }
    
}
