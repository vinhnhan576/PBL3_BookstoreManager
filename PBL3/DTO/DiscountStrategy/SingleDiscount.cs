using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO.DiscountStrategy
{
    public class SingleDiscount:PromotedStrategy
    {
        public bool IsFulfilled(List<ReceiptDetailView> list)
        {
            bool check = false;
            foreach(ReceiptDetailView item in list)
            {
                if (item.GetDiscount().DiscountType == "Single")
                {

                    check = true;
                }
            }
            return check;
        }
        public double GetPromotedDiscount(List<ReceiptDetailView> list)
        {
            double result = 0;  
            foreach(ReceiptDetailView item in list)
            {
                if (item.GetDiscount() != null)
                {
                    if (item.GetDiscount().DiscountType == "Single")
                    {
                        result = 0;
                    }
                }
            }
            return result;
        }
        public List<ReceiptDetailView> GetAll(List<ReceiptDetailView> list)
        {
            foreach(ReceiptDetailView item in list)
            {
                if (item.GetDiscount() != null)
                {
                    if (item.GetDiscount().DiscountType == "Single")
                    {
                        item.Voucher = item.GetDiscount().DiscountApply * item.Quantity;
                        item.Total = item.Total - item.Voucher;
                    }
                }
            }
            return list;
        }
    }
}
