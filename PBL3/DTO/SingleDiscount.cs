using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.Model;


namespace PBL3.DTO
{
    public class SingleDiscount:IDiscountStrategy
    {
        public double DoDiscount(List<ReceiptDetailView> list)
        {
            double result = 0;
            foreach (ReceiptDetailView item in list)
            {
                if (item.GetDiscount() != null)
                {
                    if (item.GetDiscount().DiscountType == "Single")
                    {
                        item.Voucher = (item.GetDiscount().DiscountApply / 100) * item.Quantity * item.SellingPrice;
                    }
                    item.Total = item.SellingPrice * item.Quantity - item.Voucher;
                }
                result+=item.Total;
            }
            return result;
        }
        public double getPromotedDiscount(List<ReceiptDetailView> list)
        {
            return 0;   
        }
    }
}
