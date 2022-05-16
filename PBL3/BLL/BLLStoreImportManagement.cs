using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public dynamic GetAllStoreImport()
        {
            List<Store_Import> storeImportList = new List<Store_Import>();
            foreach(Store_Import i in QLSPEntities.Instance.Store_Imports.Select(p => p).ToList())
            {
                storeImportList.Add(i);
            }
            return storeImportList;
        }

        public dynamic GetAllStoreImport_View()
        {
            var productImport = QLSPEntities.Instance.Store_Imports.Select(p => new { p.ImportDate, p.ImportQuantity, p.Product.StoreQuantity });
            return productImport.ToList();
        }

        public dynamic GetStoreImport_ViewByProductID(string productID)
        {
            List<Store_Import> data = new List<Store_Import>();
            foreach(Store_Import i in GetAllStoreImport())
            {
                if(i.ProductID == productID)
                {
                    data.Add(i);
                }
            }
            var storeImportList = data.Select(p => new { p.ImportDate, p.ImportQuantity, p.Product.StoreQuantity });
            return storeImportList.ToList();
        }

        public dynamic SortStoreImport(string sortCategory, bool ascending)
        {
            QLSPEntities db = new QLSPEntities();
            List<Store_Import> data = new List<Store_Import>();
            if (sortCategory == "ImportDate")
            {
                if (ascending)
                    data = db.Store_Imports.OrderBy(p => p.ImportDate).ToList();
                else
                    data = db.Store_Imports.OrderByDescending(p => p.ImportDate).ToList();
            }
            if (sortCategory == "ImportQuantity")
            {
                if (ascending)
                    data = db.Store_Imports.OrderBy(p => p.ImportQuantity).ToList();
                else
                    data = db.Store_Imports.OrderByDescending(p => p.ImportQuantity).ToList();
            }
            if (sortCategory == "StoreQuantity")
            {
                if (ascending)
                    data = db.Store_Imports.OrderBy(p => p.Product.StoreQuantity).ToList();
                else
                    data = db.Store_Imports.OrderByDescending(p => p.Product.StoreQuantity).ToList();
            }
            var sortedList = data.Select(p => new { p.ImportDate, p.ImportQuantity, p.Product.StoreQuantity}).ToList();
            return sortedList;
        }

        public dynamic FilterStoreImportByDate(string day, string month, string year)
        {
            int Day = 0, Month = 0, Year = 0;
            if(day != "")
                Day = Convert.ToInt32(day);
            if(month != "")
                Month = Convert.ToInt32(month);
            if(year != "")
                Year = Convert.ToInt32(year);
            List<Store_Import> data = new List<Store_Import>();
            foreach(Store_Import i in GetAllStoreImport())
            {
                if(day != "")
                {
                    if(month != "")
                    {
                        if(year != "")
                        {
                            if(i.ImportDate.Day == Day && i.ImportDate.Month == Month && i.ImportDate.Year == Year)
                                data.Add(i);
                        }
                        else
                        {
                            if(i.ImportDate.Day == Day && i.ImportDate.Month == Month)
                                data.Add(i);
                        }
                    }
                    else
                    {
                        if(year != "")
                        {
                            if(i.ImportDate.Day == Day && i.ImportDate.Year == Year)
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
            var filteredList = data.Select(p => new { p.ImportDate, p.ImportQuantity, p.Product.StoreQuantity });
            return filteredList.ToList();
        }
    }
}
