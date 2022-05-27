using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO.DiscountStrategy
{
    public class NoDiscount:PromotedStrategy
    {
        public bool IsFulfilled(List<ReceiptDetailView> list)
        {
            bool check = false;
            foreach (ReceiptDetailView item in list)
            {
                if (item.GetDiscount().DiscountType == "")
                {

                    check = true;
                }
            }
            return check;
        }
        public double GetPromotedDiscount(List<ReceiptDetailView> list)
        {
            return 0;
        }
        public List<ReceiptDetailView> GetAll(List<ReceiptDetailView> list)
        {
           return list;
        }
    }
}
