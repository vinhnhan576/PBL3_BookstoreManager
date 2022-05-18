using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.BLL
{
    public class BLLDiscountManagement
    {
        private static BLLDiscountManagement instance;
        public static BLLDiscountManagement Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BLLDiscountManagement();
                }
                return instance;
            }
            private set
            {

            }
        }

        public List<Discount> GetAllDiscount()
        {
            List<Discount> discountList = new List<Discount>();
            foreach(Discount i in QLSPEntities.Instance.Discounts.Select(p => p).ToList())
            {
                discountList.Add(i);
            }
            return discountList;
        }

        public dynamic GetAllDiscount_View()
        {
            var discountList = QLSPEntities.Instance.Discounts.Select(p => new { p.DiscountName, p.DiscountType, p.Amount, p.StartingDate, p.ExpirationDate });
            return discountList.ToList();
        }

        public dynamic SearchDiscount(string searchValue)
        {
            List<Discount> data = new List<Discount>();
            foreach (Discount i in QLSPEntities.Instance.Discounts.Select(p => p).ToList())
            {
                bool containName = i.DiscountName.IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0;
                if (containName)
                {
                    data.Add(i);
                }
            }
            var prodList = data.Select(p => new { p.DiscountName, p.DiscountType, p.Amount, p.StartingDate, p.ExpirationDate });
            return prodList.ToList();
        }

        public dynamic SortDiscount(string sortCategory, bool ascending)
        {
            QLSPEntities db = new QLSPEntities();
            List<Discount> data = new List<Discount>();
            if (sortCategory == "DiscountName")
            {
                if (ascending)
                    data = db.Discounts.OrderBy(p => p.DiscountName).ToList();
                else
                    data = db.Discounts.OrderByDescending(p => p.DiscountName).ToList();
            }
            if (sortCategory == "DiscountType")
            {
                if (ascending)
                    data = db.Discounts.OrderBy(p => p.DiscountType).ToList();
                else
                    data = db.Discounts.OrderByDescending(p => p.DiscountType).ToList();
            }
            if (sortCategory == "StartingDate")
            {
                if (ascending)
                    data = db.Discounts.OrderBy(p => p.StartingDate).ToList();
                else
                    data = db.Discounts.OrderByDescending(p => p.StartingDate).ToList();
            }
            if (sortCategory == "ExpirationDate")
            {
                if (ascending)
                    data = db.Discounts.OrderBy(p => p.ExpirationDate).ToList();
                else
                    data = db.Discounts.OrderByDescending(p => p.ExpirationDate).ToList();
            }
            if (sortCategory == "Amount")
            {
                if (ascending)
                    data = db.Discounts.OrderBy(p => p.Amount).ToList();
                else
                    data = db.Discounts.OrderByDescending(p => p.Amount).ToList();
            }
            var sortedList = data.Select(p => new { p.DiscountName, p.DiscountType, p.Amount, p.StartingDate, p.ExpirationDate }).ToList();
            return sortedList;
        }

        public List<string> GetAllDiscountType()
        {
            List<string> discountTypeList = new List<string>();
            foreach(Discount i in GetAllDiscount())
            {
                discountTypeList.Add(i.DiscountType);
            }
            return discountTypeList;
        }

        public dynamic FilterDiscount(string filterValue)
        {
            List<Discount> data = new List<Discount>();
            foreach (Discount i in QLSPEntities.Instance.Discounts.Select(p => p).ToList())
            {
                bool containType = i.DiscountType.IndexOf(filterValue, StringComparison.OrdinalIgnoreCase) >= 0;
                if (containType)
                {
                    data.Add(i);
                }
            }
            var prodList = data.Select(p => new { p.DiscountName, p.DiscountType, p.Amount, p.StartingDate, p.ExpirationDate });
            return prodList.ToList();
        }
    }
}
