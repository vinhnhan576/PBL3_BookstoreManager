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
        public dynamic GetRankByID(string rankid)
        {
            var rank = QLSPEntities.Instance.Ranks.Find(rankid);
            return rank;
        }
    }
    
}
