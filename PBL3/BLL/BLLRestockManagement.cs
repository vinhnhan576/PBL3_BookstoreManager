using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.BLL
{
    internal class BLLRestockManagement
    {
        private static BLLRestockManagement instance;
        public static BLLRestockManagement Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BLLRestockManagement();
                }
                return instance;
            }
            private set { }
        }

        public BLLRestockManagement()
        {

        }

        public RestockDetail GetRestockDetailByProductID(string productID)
        {
            RestockDetail restockDetail = new RestockDetail();
            foreach (RestockDetail i in QLSPEntities.Instance.RestockDetails.Select(p => p).ToList())
            {
                if (i.ProductID == productID)
                {
                    restockDetail = i;
                    break;
                }
            }
            return restockDetail;
        }
    }
}
