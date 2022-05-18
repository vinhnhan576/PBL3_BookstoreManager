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
        public dynamic GetAllStoreImportDetail()
        {
            List<StoreImportDetail> storeImportDetailList = new List<StoreImportDetail>();
            foreach (StoreImportDetail i in QLSPEntities.Instance.StoreImportDetails.Select(p => p).ToList())
            {
                storeImportDetailList.Add(i);
            }
            return storeImportDetailList;
        }



        public dynamic GetAllStoreImportDetail_View()
        {
            var productImport = QLSPEntities.Instance.StoreImportDetails.Select(p => new { p.Store_Import.ImportDate, p.ImportQuantity, p.Product.StoreQuantity });
            return productImport.ToList();
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
            var storeImportList = data.Select(p => new { p.Store_Import.ImportDate, p.ImportQuantity, p.Product.StoreQuantity });
            return storeImportList.ToList();
        }



        public dynamic SortStoreImportDetail(string sortCategory, bool ascending)
        {
            QLSPEntities db = new QLSPEntities();
            List<StoreImportDetail> data = new List<StoreImportDetail>();
            if (sortCategory == "ImportDate")
            {
                if (ascending)
                    data = db.StoreImportDetails.OrderBy(p => p.Store_Import.ImportDate).ToList();
                else
                    data = db.StoreImportDetails.OrderByDescending(p => p.Store_Import.ImportDate).ToList();
            }
            if (sortCategory == "ImportQuantity")
            {
                if (ascending)
                    data = db.StoreImportDetails.OrderBy(p => p.ImportQuantity).ToList();
                else
                    data = db.StoreImportDetails.OrderByDescending(p => p.ImportQuantity).ToList();
            }
            if (sortCategory == "StoreQuantity")
            {
                if (ascending)
                    data = db.StoreImportDetails.OrderBy(p => p.Product.StoreQuantity).ToList();
                else
                    data = db.StoreImportDetails.OrderByDescending(p => p.Product.StoreQuantity).ToList();
            }
            var sortedList = data.Select(p => new { p.Store_Import.ImportDate, p.ImportQuantity, p.Product.StoreQuantity }).ToList();
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
                            if (i.Store_Import.ImportDate.Day == Day && i.Store_Import.ImportDate.Month == Month && i.Store_Import.ImportDate.Year == Year)
                                data.Add(i);
                        }
                        else
                        {
                            if (i.Store_Import.ImportDate.Day == Day && i.Store_Import.ImportDate.Month == Month)
                                data.Add(i);
                        }
                    }
                    else
                    {
                        if (year != "")
                        {
                            if (i.Store_Import.ImportDate.Day == Day && i.Store_Import.ImportDate.Year == Year)
                                data.Add(i);
                        }
                        else
                        {
                            if (i.Store_Import.ImportDate.Day == Day)
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
                            if (i.Store_Import.ImportDate.Month == Month && i.Store_Import.ImportDate.Year == Year)
                                data.Add(i);
                        }
                        else
                        {
                            if (i.Store_Import.ImportDate.Month == Month)
                                data.Add(i);
                        }
                    }
                    else
                    {
                        if (year != "")
                        {
                            if (i.Store_Import.ImportDate.Year == Year)
                                data.Add(i);
                        }
                    }
                }
            }
            var filteredList = data.Select(p => new { p.Store_Import.ImportDate, p.ImportQuantity, p.Product.StoreQuantity });
            return filteredList.ToList();
        }
    }
}