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
    }
}
