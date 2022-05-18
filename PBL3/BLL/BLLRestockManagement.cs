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
            private set
            {

            }
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
            var ramdom = new RandomGenerator();
            int check = Check(list, productid);
            if (check != -1)
            {
                list[check].ImportQuantity += quantity;
                list[check].Total = list[check].ImportQuantity * list[check].ImportPrice;
            }
            else
            {
                RestockDetailView temp = new RestockDetailView();
                temp.RestockDetailID = "rs00" + ramdom.RandomNumber(100,999);
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
                r.Total = list[i].Total;
                r.RestockID = restock_id;
                BLLRestockManagement.Instance.AddNewRestockDetail(r);
            }
        }
    }
}
