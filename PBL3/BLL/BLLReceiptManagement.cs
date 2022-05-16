using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;



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
     
        public dynamic GetProductInReceiptByID(string ID_Receipt)
        {

            //foreach (Receipt_Detail temp in QLSPEntities.Instance.Receipts.Find(ID_Receipt).Receipt_Detail)
            //{
            //    temp.Total = temp.SellingQuantity * (temp.Product.SellingPrice);
            //    QLSPEntities.Instance.SaveChanges();
            //}
            var product = QLSPEntities.Instance.Receipt_Details.Where(p => p.ReceiptID == ID_Receipt).Select(p => new { p.Product.ProductName, p.SellingQuantity, p.Product.SellingPrice, p.Total }).ToList();
            return product;
        }

        public Receipt GetReceiptByReceiptDetailID(string rdID)
        {
            Receipt receipt = new Receipt();
            foreach(Receipt i in QLSPEntities.Instance.Receipts.Select(p => p).ToList())
            {
                foreach(Receipt_Detail rd in i.Receipt_Detail)
                {
                    if(rd.ReceipDetailtID == rdID)
                    {
                        receipt = i;
                        break;
                    }
                }
            }
            return receipt;
        }

        public ReceiptDetailView CreateReceiptDetailView(string productid, int quantity, int count)
        {
            var random = new RandomGenerator();
            ReceiptDetailView temp = new ReceiptDetailView();
            var Product = QLSPEntities.Instance.Products.Find(productid);
            temp.ReceiptDetailID = "rd" + random.RandomNumber(100, 99999);
            temp.ProductID = productid;
            temp.ProductName = Product.ProductName;
            temp.SellingPrice = Product.SellingPrice;
            temp.Quantity = quantity;
            temp.Total = temp.SellingPrice * quantity;
            return temp;

        }
        public void AddNewReceiptDetail(List<ReceiptDetailView> list, string receipt_id)
        {
            for(int i=0;i<list.Count;i++)
            {
                Receipt_Detail r = new Receipt_Detail();
                r.ReceipDetailtID = list[i].ReceiptDetailID;
                r.ProductID= list[i].ProductID;
                r.SellingQuantity = list[i].Quantity;
                r.Total=list[i].Total;
                r.ReceiptID = receipt_id;
                BLLReceiptManagement.Instance.AddNewReceiptDetail(r);
            }
        }

        }
        public List<Receipt_Detail> getReceiptDetailByReceiptID(string ID_Receipt)
        {

            if (ID_Receipt == "")
                return QLSPEntities.Instance.Receipt_Details.Select(p => p).ToList();
            else
                return QLSPEntities.Instance.Receipt_Details.Where(p => p.ReceiptID == ID_Receipt).ToList();
        }

       
        


        public double CalculateReceiptToTal(List<ReceiptDetailView> list)
        {
            double total = 0;
            for (int i = 0; i < list.Count; i++)
            {
                total += list[i].Total;
            }
            return total;



        }
        public int ReceiptDetailView_Check(List<ReceiptDetailView> list, string product_id)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].ProductID == product_id)
                {
                    return 1;
                }

            }
            return 0;
        }
    }
}