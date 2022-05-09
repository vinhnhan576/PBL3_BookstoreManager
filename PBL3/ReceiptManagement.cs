using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3
{
    internal class ReceiptManagement
    {
        public void AddNewReceipt(Receipt r)
        {
            QLSPEntities qLSPEntities = new QLSPEntities();
            qLSPEntities.Receipts.Add(r);
            qLSPEntities.SaveChanges();
           
        }
        public void AddNewReceiptDetail(Receipt_Detail r)
        {
            QLSPEntities qLSPEntities = new QLSPEntities();
            qLSPEntities.Receipt_Details.Add(r);
            qLSPEntities.SaveChanges();
        
        }

        public dynamic GetProductInReceiptByID(string ID_Receipt)
        {
            QLSPEntities qLSPEntities = new QLSPEntities();
            var product = qLSPEntities.Receipt_Details.Where(p => p.ReceiptID == ID_Receipt).Select(p => new {p.Receipt.ReceiptID,p.ProductID,p.SellingQuantity}).ToList();
            return product;
            

        }

       

    }
}
