using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.Model;

namespace PBL3.DTO
{
    public class Order
    {
        private List<ReceiptDetailView> rdv_list;
        private IDiscountStrategy discountStrategy;

        public List<ReceiptDetailView> Rdv_List   // property
        {
            get { return this.rdv_list; }   // get method
            set { this.rdv_list = value; }  // set method
        }
        public Order(List<ReceiptDetailView> rdv_list)
        {
            this.rdv_list = rdv_list;
        }
        public Order()
        {
            this.rdv_list = new List<ReceiptDetailView>();
        }
        public Order(IDiscountStrategy discountStrategy)
        {
            this.discountStrategy = discountStrategy;
        }
        public void SetDiscountStrategy(IDiscountStrategy discountStrategy)
        {
            this.discountStrategy=discountStrategy;
        }
        public void Add(ReceiptDetailView r)
        {
            if (this.rdv_list == null)
            {
                rdv_list=new List<ReceiptDetailView>();
                rdv_list.Add(r);
            }
            else
            {
                rdv_list.Add(r);
            }
        }
        public int ReceiptDetailView_Check(string product_id)
        {
            for (int i = 0; i < this.rdv_list.Count; i++)
            {
                if (this.rdv_list[i].ProductID == product_id)
                {
                    return i;
                }
            }
            return -1;
        }
        public void CreateReceiptDetailView(Product p, int quantity, string receiptdetail_id)
        {
            int check = this.ReceiptDetailView_Check(p.ProductID);
            if (check != -1)
            {
                this.rdv_list[check].Quantity += quantity;
                this.rdv_list[check].Total = this.rdv_list[check].Quantity * this.rdv_list[check].SellingPrice;
            }
            else
            {
                ReceiptDetailView temp = new ReceiptDetailView();
                temp.ReceiptDetailID = receiptdetail_id;
                temp.ProductID = p.ProductID;
                temp.ProductName = p.ProductName;
                temp.SellingPrice = p.SellingPrice;
                temp.Quantity = quantity;
                temp.Total = temp.SellingPrice * quantity;
                temp.SetDiscount(p.Discount);
                this.Add(temp);
            }
        }
        public void RemoveAt(int i)
        {
            this.rdv_list.RemoveAt(i);
        }
        public double CalculateReceiptToTal()
        {
            return discountStrategy.DoDiscount(rdv_list);   
        }
        public double getPromotedDiscount()
        {
            return discountStrategy.getPromotedDiscount(rdv_list);
        }

    }
}
