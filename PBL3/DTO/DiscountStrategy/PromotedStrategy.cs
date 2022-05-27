using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO.DiscountStrategy
{
    public interface PromotedStrategy
    { 
         bool IsFulfilled(List<ReceiptDetailView> list);
         double GetPromotedDiscount(List<ReceiptDetailView> list);
         List<ReceiptDetailView> GetAll(List<ReceiptDetailView> list);
    }
}
