using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.BLL
{
    internal class BLLRestockManagement
    {
        private static BLLRestockManagement _instance;
        public static BLLRestockManagement Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BLLRestockManagement();
                }
                return _instance;
            }
            private set {}
        }

        public BLLRestockManagement()
        {

        }

        public List<RestockDetail> GetAllRestockDetail()
        {
            List<RestockDetail> restockDetails = new List<RestockDetail>();
            foreach(RestockDetail restockDetail in QLSPEntities.Instance.RestockDetails.Select(p => p).ToList())
                restockDetails.Add(restockDetail);
            return restockDetails;
        }

        public dynamic GetAllRestockDetail_View()
        {
            var restockDetails = QLSPEntities.Instance.RestockDetails.Select(p => new
            {
                p.RestockDetailID,
                p.Product.ProductName,
                p.Product.StockQuantity,
                p.ImportPrice
            });
            return restockDetails.ToList();
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
