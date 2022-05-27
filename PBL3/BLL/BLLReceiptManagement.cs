using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;
using PBL3.Model;
using PBL3.DTO.DiscountStrategy;

namespace PBL3.BLL
{
    internal class BLLReceiptManagement
    {
        private static BLLReceiptManagement instance;
        public static BLLReceiptManagement Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BLLReceiptManagement();
                }
                return instance;
            }
            private set
            {



            }
        }
        public void AddNewReceipt(Receipt r)
        {

            QLNS.Instance.Receipts.Add(r);
            QLNS.Instance.SaveChanges();

        }
        public void AddNewReceiptDetail(ReceiptDetail r)
        {

            QLNS.Instance.ReceiptDetails.Add(r);
            QLNS.Instance.SaveChanges();
        }
     
        public dynamic GetProductInReceiptByID(string ID_Receipt)
        {

            //foreach (Receipt_Detail temp in QLSPEntities.Instance.Receipts.Find(ID_Receipt).Receipt_Detail)
            //{
            //    temp.Total = temp.SellingQuantity * (temp.Product.SellingPrice);
            //    QLSPEntities.Instance.SaveChanges();
            //}
            var product = QLNS.Instance.ReceiptDetails.Where(p => p.ReceiptID == ID_Receipt).Select(p => new { p.Product.ProductName, p.SellingQuantity, p.Total }).ToList();
            return product;
        }

        public Receipt GetReceiptByReceiptDetailID(string rdID)
        {
            Receipt receipt = new Receipt();
            foreach(Receipt i in QLNS.Instance.Receipts.Select(p => p).ToList())
            {
                foreach(ReceiptDetail rd in i.ReceiptDetails)
                {
                    if(rd.ReceiptDetailID == rdID)
                    {
                        receipt = i;
                        break;
                    }
                }
            }
            return receipt;
        }

        public List<ReceiptDetailView> CreateReceiptDetailView(List<ReceiptDetailView> list, string productid, int quantity)
        {
            int check = ReceiptDetailView_Check(list, productid);
            if (check != -1)
            {
                list[check].Quantity += quantity;
                list[check].Total = list[check].Quantity * list[check].SellingPrice;
                return list;
            }
            else
            {
                ReceiptDetailView temp = new ReceiptDetailView();
                var Product = QLNS.Instance.Products.Find(productid);
                temp.ReceiptDetailID = (QLNS.Instance.ReceiptDetails.Count()+list.Count()).ToString();
                temp.ProductID = productid;
                temp.ProductName = Product.ProductName;
                temp.SellingPrice = Product.SellingPrice;
                temp.Quantity = quantity;
                temp.Total = temp.SellingPrice * quantity;
                temp.SetDiscount(Product.Discount);
                list.Add(temp);
                return list;
            }
        }
        public void AddNewReceiptDetail(List<ReceiptDetailView> list, string receipt_id)
        {
            for(int i=0;i<list.Count;i++)
            {
                ReceiptDetail r = new ReceiptDetail();
                r.ReceiptDetailID = list[i].ReceiptDetailID;
                r.ProductID= list[i].ProductID;
                r.SellingQuantity = list[i].Quantity;
                r.Total=list[i].Total;
                r.ReceiptID = receipt_id;
                AddNewReceiptDetail(r);
            }
        }
        public List<ReceiptDetail> getReceiptDetailByReceiptID(string ID_Receipt)
        {

            if (ID_Receipt == "")
                return QLNS.Instance.ReceiptDetails.Select(p => p).ToList();
            else
                return QLNS.Instance.ReceiptDetails.Where(p => p.ReceiptID == ID_Receipt).ToList();
        }

        public double CalculateReceiptToTal(List<ReceiptDetailView> list,PromotedStrategy p)
        {
            double total = 0;
            for (int i = 0; i < list.Count; i++)
            {
                total += list[i].Total;
            }
            total = total - p.GetPromotedDiscount(list);
            return total;
        }
        public int ReceiptDetailView_Check(List<ReceiptDetailView> list, string product_id)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].ProductID == product_id)
                {
                    return i;
                }

            }
            return -1;
        }

        public dynamic GetAllBill_View()
        {
            var billList = QLNS.Instance.Receipts.Select(p => new
            {
                p.ReceiptID,
                p.Person.PersonName,
                p.Date,
                p.Total
            });
            return billList.ToList();
        }
        public dynamic SearchReceipt(string searchValue)
        {
            List<Receipt> data = new List<Receipt>();
            foreach (Receipt i in QLNS.Instance.Receipts.Select(p => p).ToList())
            {
                bool containID = i.ReceiptID.IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0;
                bool containSalesmanName = i.Person.PersonName.IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0;
                //bool containCustomer = i.Customer.CustomerName.IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0;
                //bool containCustomerID = i.Customer.CustomerName.IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0;
                bool containSalemansID = i.PersonID.IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0;
                string dateTemp = i.Date.ToShortDateString();
                bool containDate = dateTemp.IndexOf(searchValue) >= 0;
                if (containID || containSalesmanName || containSalemansID || containDate)
                {
                    data.Add(i);
                }
            }
            var ReceiptList = data.Select(p => new { p.ReceiptID, p.Person.PersonName, p.Date, p.Total, p.Status });
            return ReceiptList.ToList();
        }
        public dynamic GetAllReceipt_View()
        {
            QLNS db = new QLNS();
            var product = db.Receipts.Select(p => new { p.ReceiptID, p.Person.PersonName, p.Date, p.Total, p.Status });
            return product.ToList();
        }
        public dynamic SortReceipt(string sortCategory, bool ascending)
        {
            QLNS db = new QLNS();
            List<Receipt> data = new List<Receipt>();
            if (sortCategory == "Receipt ID")
            {
                if (ascending)
                    data = db.Receipts.OrderBy(p => p.ReceiptID).ToList();
                else
                    data = db.Receipts.OrderByDescending(p => p.ReceiptID).ToList();
            }
            if (sortCategory == "Date")
            {
                if (ascending)
                    data = db.Receipts.OrderBy(p => p.Date).ToList();
                else
                    data = db.Receipts.OrderByDescending(p => p.Date).ToList();
            }
            if (sortCategory == "Total")
            {
                if (ascending)
                    data = db.Receipts.OrderBy(p => p.Total).ToList();
                else
                    data = db.Receipts.OrderByDescending(p => p.Total).ToList();
            }
            var newList = data.Select(p => new { p.ReceiptID, p.Person.PersonName, p.Date, p.Total, p.Status }).ToList();
            return newList;
        }
        public List<ReceiptDetailView> GetListAfterVoucher(List<ReceiptDetailView> list,PromotedStrategy p)
        { 
            return p.GetAll(list);
        }


    }
}