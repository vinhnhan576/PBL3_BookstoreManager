using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;
using PBL3.Model;

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
            foreach (Restock i in QLNS.Instance.Restocks.Select(p => p).ToList())
                restockList.Add(i);
            return restockList;
        }
        public dynamic GetAllRestock_View()
        {
            List<Restock> restockList = GetAllRestock();
            var list = restockList.OrderBy(r => r.RestockID.Length).ThenBy(r => r.RestockID).Select(p => new { p.RestockID, p.Person.PersonName, p.ImportDate, p.TotalExpense });
            return list.ToList();
        }

        public List<RestockDetail> GetAllRestockDetail()
        {
            List<RestockDetail> restockDetails = new List<RestockDetail>();
            foreach (RestockDetail restockDetail in QLNS.Instance.RestockDetails.Select(p => p).ToList())
                restockDetails.Add(restockDetail);
            return restockDetails;
        }

        public dynamic GetAllRestockDetail_View()
        {
            var restockDetails = QLNS.Instance.RestockDetails.OrderBy(r => r.RestockDetailID.Length).ThenBy(r => r.RestockDetailID).Select(p => new
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
            var products = QLNS.Instance.RestockDetails.Select(p => new { p.Product.ProductName, p.ImportQuantity });
            return products.ToList();
        }
        public dynamic GetProductInRestockByRestockID(string ID)
        {
            var product = QLNS.Instance.RestockDetails.Where(p => p.RestockID == ID).Select(p => new { p.ProductID, p.Product.ProductName, p.ImportQuantity, p.ImportPrice }).ToList();
            return product;
        }
        public RestockDetail GetRestockDetailByProductID(string productID)
        {
            RestockDetail restockDetail = new RestockDetail();
            foreach (RestockDetail i in QLNS.Instance.RestockDetails.Select(p => p).ToList())
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

            QLNS.Instance.Restocks.Add(r);
            QLNS.Instance.SaveChanges();
        }
        public void AddNewRestockDetail(RestockDetail r)
        {

            QLNS.Instance.RestockDetails.Add(r);
            QLNS.Instance.SaveChanges();
        }
        public List<RestockDetailView> CreateRestockDetailView(List<RestockDetailView> list, string productid, int quantity, double ImportPrice)
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
                temp.RestockDetailID = "dt00" + (QLNS.Instance.RestockDetails.Count() + 1 + list.Count()).ToString();
                Product product = QLNS.Instance.Products.Find(productid);
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
        public dynamic SearchRestock(string value)
        {
            QLNS qLSPEntities = new QLNS();
            List<Restock> data = new List<Restock>();
            foreach (Restock s in qLSPEntities.Restocks.Select(p => p).ToList())
            {
                if (s.Person.PersonName.Contains(value) == true)
                {
                    data.Add(s);
                }
            }
            var list = data.Select(p => new { p.RestockID, p.Person.PersonName, p.ImportDate, p.TotalExpense });
            return list.ToList();
        }
        public dynamic SortRestock(string sortCategory, bool ascending)
        {
            QLNS qLSPEntities = new QLNS();
            List<Restock> data = new List<Restock>();
            if (sortCategory == "RestockID")
            {
                if (ascending)
                    data = qLSPEntities.Restocks.OrderBy(p => p.RestockID).ToList();
                else
                    data = qLSPEntities.Restocks.OrderByDescending(p => p.RestockID).ToList();
            }
            if (sortCategory == "ImportDate")
            {
                if (ascending)
                    data = qLSPEntities.Restocks.OrderBy(p => p.ImportDate).ToList();
                else
                    data = qLSPEntities.Restocks.OrderByDescending(p => p.ImportDate).ToList();
            }
            if (sortCategory == "Total")
            {
                if (ascending)
                    data = qLSPEntities.Restocks.OrderBy(p => p.TotalExpense).ToList();
                else
                    data = qLSPEntities.Restocks.OrderByDescending(p => p.TotalExpense).ToList();
            }

            var account = (data.Select(p => new { p.RestockID, p.Person.PersonName, p.ImportDate, p.TotalExpense })).ToList();
            return account;
        }
        public dynamic FilterRestockByDate(string day, string month, string year)
        {
            int Day = 0, Month = 0, Year = 0;
            if (day != "")
                Day = Convert.ToInt32(day);
            if (month != "")
                Month = Convert.ToInt32(month);
            if (year != "")
                Year = Convert.ToInt32(year);
            List<Restock> data = new List<Restock>();
            foreach (Restock i in GetAllRestock())
            {
                if (day != "")
                {
                    if (month != "")
                    {
                        if (year != "")
                        {
                            if (i.ImportDate.Day == Day && i.ImportDate.Month == Month && i.ImportDate.Year == Year)
                                data.Add(i);
                        }
                        else
                        {
                            if (i.ImportDate.Day == Day && i.ImportDate.Month == Month)
                                data.Add(i);
                        }
                    }
                    else
                    {
                        if (year != "")
                        {
                            if (i.ImportDate.Day == Day && i.ImportDate.Year == Year)
                                data.Add(i);
                        }
                        else
                        {
                            if (i.ImportDate.Day == Day)
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
                            if (i.ImportDate.Month == Month && i.ImportDate.Year == Year)
                                data.Add(i);
                        }
                        else
                        {
                            if (i.ImportDate.Month == Month)
                                data.Add(i);
                        }
                    }
                    else
                    {
                        if (year != "")
                        {
                            if (i.ImportDate.Year == Year)
                                data.Add(i);
                        }
                    }
                }
            }
            var filteredList = data.Select(p => new { p.RestockID, p.Person.PersonName, p.ImportDate, p.TotalExpense });
            return filteredList.ToList();
        }

        public string GenerateRestockID()
        {
            string ID = QLNS.Instance.Restocks.OrderByDescending(p => p.RestockID.Length).ThenByDescending(p => p.RestockID).First().RestockID;
            return "rs" + (Convert.ToInt32(ID.Remove(0, 2)) + 1).ToString();
        }

        public string GenerateRestockDetailID()
        {
            string ID = QLNS.Instance.RestockDetails.OrderByDescending(p => p.RestockDetailID.Length).ThenByDescending(p => p.RestockDetailID).First().RestockDetailID;
            return "rsdt" + (Convert.ToInt32(ID.Remove(0, 4)) + 1).ToString();
        }
    }
}
