using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.Model;
using PBL3.DTO.DiscountStrategy;

namespace PBL3.DTO
{
    public class ReceiptDetailView
    {
        public string ReceiptDetailID { get; set; }
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double SellingPrice { get; set; }
        public double Voucher { get; set; }
        public double Total { get; set; }

        private Discount discount;
        public void SetDiscount(Discount discount)
        {
            this.discount = discount;
        }
        public Discount GetDiscount()
        {
            return discount;  
        }
    }
}
