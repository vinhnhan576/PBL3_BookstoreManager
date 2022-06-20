using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.Model;

namespace PBL3.DTO
{
    public class ComboDiscount:IDiscountStrategy
    {
        public double DoDiscount(List<ReceiptDetailView> list)
        {

            double total = 0;
            foreach (ReceiptDetailView item in list)
            {
                total += item.Total;
            }
            total -=this.getPromotedDiscount(list);
            return total;
        }
        public int GetCoeficcient(IGrouping<string, ReceiptDetailView> group)
        {
            int count = group.ElementAt(0).Quantity;
            foreach (var i in group)
            {
                if (count >= i.Quantity)
                {
                    count = i.Quantity;
                }
            }
            return count;
        }
        public double getPromotedDiscount(List<ReceiptDetailView> list)
        {
            var GroupByMS = list.Where(p => p.GetDiscount() != null).GroupBy(s => s.GetDiscount().DiscountID);
            double result = 0;
            double totalgroup = 0;
            double totalall = 0;
            //Using Query Syntax
            //It will iterate through each groups
            foreach (var group in GroupByMS)
            {
                Discount d = group.ElementAt(0).GetDiscount();
                if (group.Count() == d.AmmountApply && d.StartingDate <= DateTime.Now && d.ExpirationDate >= DateTime.Now)
                {
                    int coeficient = GetCoeficcient(group);
                    foreach (var item in group)
                    {
                        totalgroup += coeficient * item.SellingPrice;
                    }
                    result += totalgroup * (d.DiscountApply / 100);
                }
            }
            return result;
        }


    }
}
