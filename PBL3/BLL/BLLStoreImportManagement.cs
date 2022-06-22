using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;
using PBL3.Model;

namespace PBL3.BLL
{
    public class BLLStoreImportManagement
    {
        private static BLLStoreImportManagement instance;
        public static BLLStoreImportManagement Instance
        {
            get
            {
                if (instance == null)
                    instance = new BLLStoreImportManagement();
                return instance;
            }
            private set { }
        }



        private BLLStoreImportManagement()
        {

        }
        public dynamic GetAllStoreImportDetail()
        {
            List<StoreImportDetail> storeImportDetailList = new List<StoreImportDetail>();
            foreach (StoreImportDetail i in QLNS.Instance.StoreImportDetails.Select(p => p).ToList())
            {
                storeImportDetailList.Add(i);
            }
            return storeImportDetailList;
        }
        public dynamic GetStoreImportDetail_ViewByProductID(string productID)
        {
            List<StoreImportDetail> data = new List<StoreImportDetail>();
            foreach (StoreImportDetail i in GetAllStoreImportDetail())
            {
                if (i.ProductID == productID)
                {
                    data.Add(i);
                }
            }
            var storeImportList = data.OrderBy(s => s.StoreImportDetailID.Length).ThenBy(s => s.StoreImportDetailID)
                                    .Select(p => new { p.StoreImport.ImportDate, p.ImportQuantity, p.Product.StoreQuantity });
            return storeImportList.ToList();
        }

        public dynamic SortStoreImportDetail(string productID, string sortCategory, bool ascending)
        {
            List<StoreImportDetail> data = QLNS.Instance.StoreImportDetails.Where(p => (p.ProductID == productID)).ToList();
            if (sortCategory == "ImportDate")
            {
                if (ascending)
                    data = data.OrderBy(p => p.StoreImport.ImportDate).ToList();
                else
                    data = data.OrderByDescending(p => p.StoreImport.ImportDate).ToList();
            }
            if (sortCategory == "ImportQuantity")
            {
                if (ascending)
                    data = data.OrderBy(p => p.ImportQuantity).ToList();
                else
                    data = data.OrderByDescending(p => p.ImportQuantity).ToList();
            }
            if (sortCategory == "StoreQuantity")
            {
                if (ascending)
                    data = data.OrderBy(p => p.Product.StoreQuantity).ToList();
                else
                    data = data.OrderByDescending(p => p.Product.StoreQuantity).ToList();
            }
            var sortedList = data.Select(p => new { p.StoreImport.ImportDate, p.ImportQuantity, p.Product.StoreQuantity }).ToList();
            return sortedList;
        }

        public dynamic FilterStoreImportDetailByDate(string day, string month, string year)
        {
            int Day = 0, Month = 0, Year = 0;
            if (day != "")
                Day = Convert.ToInt32(day);
            if (month != "")
                Month = Convert.ToInt32(month);
            if (year != "")
                Year = Convert.ToInt32(year);
            List<StoreImportDetail> data = new List<StoreImportDetail>();
            foreach (StoreImportDetail i in GetAllStoreImportDetail())
            {
                if (day != "")
                {
                    if (month != "")
                    {
                        if (year != "")
                        {
                            if (i.StoreImport.ImportDate.Day == Day && i.StoreImport.ImportDate.Month == Month && i.StoreImport.ImportDate.Year == Year)
                                data.Add(i);
                        }
                        else
                        {
                            if (i.StoreImport.ImportDate.Day == Day && i.StoreImport.ImportDate.Month == Month)
                                data.Add(i);
                        }
                    }
                    else
                    {
                        if (year != "")
                        {
                            if (i.StoreImport.ImportDate.Day == Day && i.StoreImport.ImportDate.Year == Year)
                                data.Add(i);
                        }
                        else
                        {
                            if (i.StoreImport.ImportDate.Day == Day)
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
                            if (i.StoreImport.ImportDate.Month == Month && i.StoreImport.ImportDate.Year == Year)
                                data.Add(i);
                        }
                        else
                        {
                            if (i.StoreImport.ImportDate.Month == Month)
                                data.Add(i);
                        }
                    }
                    else
                    {
                        if (year != "")
                        {
                            if (i.StoreImport.ImportDate.Year == Year)
                                data.Add(i);
                        }
                    }
                }
            }
            var filteredList = data.Select(p => new { p.StoreImport.ImportDate, p.ImportQuantity, p.Product.StoreQuantity });
            return filteredList.ToList();
        }
        public List<StoreImport> GetAllStoreImport()
        {
            List<StoreImport> List = new List<StoreImport>();
            foreach (StoreImport i in QLNS.Instance.StoreImports.Select(p => p).ToList())
                List.Add(i);
            return List;
        }

        public void AddNewStoreImport(StoreImport r)
        {
            QLNS.Instance.StoreImports.Add(r);
            QLNS.Instance.SaveChanges();
        }
        public void AddNewStoreImportDetail(StoreImportDetail r)
        {

            QLNS.Instance.StoreImportDetails.Add(r);
            QLNS.Instance.SaveChanges();
        }
        public List<StoreImportDetailView> CreateStoreImportDetailView(List<StoreImportDetailView> list, string productid, int quantity)
        {
            int check = Check(list, productid);
            if (check != -1)
            {
                list[check].ImportQuantity += quantity;
            }
            else
            {
                StoreImportDetailView temp = new StoreImportDetailView();
                temp.StoreImportDetailID = GenerateStoreImportDetailID();
                Product product = QLNS.Instance.Products.Find(productid);
                temp.ProductID = productid;
                temp.ProductName = product.ProductName;
                temp.ImportQuantity = quantity;
                list.Add(temp);
            }
            return list;
        }

        public string GenerateStoreImportID()
        {
            string ID = QLNS.Instance.StoreImports.OrderByDescending(p => p.StoreImportID.Length).ThenByDescending(p => p.StoreImportID).First().StoreImportID;
            return "si" + (Convert.ToInt32(ID.Remove(0, 2)) + 1).ToString();
        }

        public string GenerateStoreImportDetailID()
        {
            string ID = QLNS.Instance.StoreImportDetails.OrderByDescending(p => p.StoreImportDetailID.Length).ThenByDescending(p => p.StoreImportDetailID).First().StoreImportDetailID;
            return "sidt" + (Convert.ToInt32(ID.Remove(0, 4)) + 1).ToString();
        }

        public int Check(List<StoreImportDetailView> list, string product_id)
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
        public void AddNewStoreImportDetail(List<StoreImportDetailView> list, string id)
        {
            for (int i = 0; i < list.Count; i++)
            {
                StoreImportDetail s = new StoreImportDetail();
                s.StoreImportDetailID = list[i].StoreImportDetailID;
                s.ProductID = list[i].ProductID;
                s.ImportQuantity = list[i].ImportQuantity;
                s.StoreImportID = id;
                AddNewStoreImportDetail(s);
            }
        }
    }
}

