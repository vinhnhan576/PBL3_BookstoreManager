using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.BLL
{
    internal class BLLReceiptManagement
    {

        private static BLLReceiptManagement _instance;

        public static BLLReceiptManagement Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BLLReceiptManagement();
                }
                return _instance;
            }
            private set
            {

            }
        }

        public void AddNewReceipt(Receipt r)
        {
    
            QLSPEntities.Instance.Receipts.Add(r);
            QLSPEntities.Instance.SaveChanges();

        }
        public void AddNewReceiptDetail(Receipt_Detail r)
        {
           
            QLSPEntities.Instance.Receipt_Details.Add(r);
            QLSPEntities.Instance.SaveChanges();

        }
        public void TotalCalculate(Receipt_Detail temp)
        {
           
            temp.Total = temp.SellingQuantity * (temp.Product.SellingPrice);
            QLSPEntities.Instance.SaveChanges();


        }

        public dynamic GetProductInReceiptByID(string ID_Receipt)
        {
          
            foreach(Receipt_Detail i in QLSPEntities.Instance.Receipts.Find(ID_Receipt).Receipt_Detail)
            {
                TotalCalculate(i);
            }
            var product = QLSPEntities.Instance.Receipt_Details.Where(p => p.ReceiptID == ID_Receipt).Select(p => new { p.Product.ProductName, p.SellingQuantity,p.Product.SellingPrice,p.Total }).ToList();
            return product;
        }

        public List<Receipt_Detail> getReceiptDetailByReceiptID(string ID_Receipt)
        {
            
            if (ID_Receipt == "")
                return  QLSPEntities.Instance.Receipt_Details.Select(p => p).ToList();
            else
                return QLSPEntities.Instance.Receipt_Details.Where(p =>p.ReceiptID==ID_Receipt).ToList();
        }






    }
}
