using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;

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
        public List<Restock> GetAllRestock()
        {
            List<Restock> restockList = new List<Restock>();
            foreach (Restock i in QLSPEntities.Instance.Restocks.Select(p => p).ToList())
                restockList.Add(i);
            return restockList;
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

        public dynamic GetAllProduct_StockView()
        {
            var products = QLSPEntities.Instance.RestockDetails.Select(p => new { p.Product.ProductName, p.ImportQuantity });
            return products.ToList();
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
        public void AddNewRestock(Restock r)
        {

            QLSPEntities.Instance.Restocks.Add(r);
            QLSPEntities.Instance.SaveChanges();
        }
        public void AddNewRestockDetail(RestockDetail r)
        {

            QLSPEntities.Instance.RestockDetails.Add(r);
            QLSPEntities.Instance.SaveChanges();
        }
        public List<RestockDetailView> CreateRestockDetailView(List<RestockDetailView> list,string productid, int quantity, double ImportPrice)
        {
            int check = Check(list, productid);
            if (check != -1)
            {
                list[check].ImportQuantity += quantity;
                list[check].Total = list[check].ImportQuantity * list[check].ImportPrice;
            }
            else
            {
                RestockDetailView temp = new RestockDetailView();
                temp.RestockDetailID = "dt00" + (QLSPEntities.Instance.RestockDetails.Count() + 1 +list.Count()).ToString();
                Product product = QLSPEntities.Instance.Products.Find(productid);
                temp.ProductID = productid;
                temp.ProductName = product.ProductName;
                temp.ImportPrice = ImportPrice;
                temp.ImportQuantity = quantity;
                temp.Total = temp.ImportPrice * quantity;
                list.Add(temp);
            }
            return list;
        }
        public int Check(List<RestockDetailView> list, string product_id)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].ProductID == product_id)
                {
                    return i;
                }

            }
            return -1;
        }
        public double CalculateRestockToTal(List<RestockDetailView> list)
        {
            double total = 0;
            for (int i = 0; i < list.Count; i++)
            {
                total += list[i].Total;
            }
            return total;
        }
        public void AddNewRestockDetail(List<RestockDetailView> list, string restock_id)
        {
            for (int i = 0; i < list.Count; i++)
            {
                RestockDetail r = new RestockDetail();
                r.RestockDetailID = list[i].RestockDetailID;
                r.ProductID = list[i].ProductID;
                r.ImportQuantity = list[i].ImportQuantity;
                r.ImportPrice = list[i].ImportPrice;
                r.Total = list[i].Total;
                r.RestockID = restock_id;
                BLLRestockManagement.Instance.AddNewRestockDetail(r);
            }
        }
    }
}
