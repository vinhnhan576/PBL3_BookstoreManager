using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.Model;

namespace PBL3.DTO
{
    public interface IDiscountStrategy
    {
        double DoDiscount(List<ReceiptDetailView> list);
        double getPromotedDiscount(List<ReceiptDetailView> list);
    }
}
