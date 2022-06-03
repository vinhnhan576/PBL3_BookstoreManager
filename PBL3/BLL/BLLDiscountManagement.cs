﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.Model;
using PBL3.DTO;
using System.Windows.Forms;
namespace PBL3.BLL
{
    public class BLLDiscountManagement
    {
        private static BLLDiscountManagement instance;
        public static BLLDiscountManagement Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BLLDiscountManagement();
                }
                return instance;
            }
            private set
            {

            }
        }

        public List<Discount> GetAllDiscount()
        {
            List<Discount> discountList = new List<Discount>();
            foreach(Discount i in QLNS.Instance.Discounts.Select(p => p).ToList())
            {
                discountList.Add(i);
            }
            return discountList;
        }

        public dynamic GetAllDiscount_View()
        {
            var discountList = QLNS.Instance.Discounts.Select(p => new {p.DiscountID, p.DiscountName, p.DiscountType, p.AmmountApply,p.DiscountApply, p.StartingDate, p.ExpirationDate });
            return discountList.ToList();
        }
        public dynamic SortDiscount(string sortCategory, bool ascending)
        {
            QLNS db = new QLNS();
            List<Discount> data = new List<Discount>();
            if (sortCategory == "DiscountName")
            {
                if (ascending)
                    data = db.Discounts.OrderBy(p => p.DiscountName).ToList();
                else
                    data = db.Discounts.OrderByDescending(p => p.DiscountName).ToList();
            }
            if (sortCategory == "DiscountType")
            {
                if (ascending)
                    data = db.Discounts.OrderBy(p => p.DiscountType).ToList();
                else
                    data = db.Discounts.OrderByDescending(p => p.DiscountType).ToList();
            }
            if (sortCategory == "StartingDate")
            {
                if (ascending)
                    data = db.Discounts.OrderBy(p => p.StartingDate).ToList();
                else
                    data = db.Discounts.OrderByDescending(p => p.StartingDate).ToList();
            }
            if (sortCategory == "ExpirationDate")
            {
                if (ascending)
                    data = db.Discounts.OrderBy(p => p.ExpirationDate).ToList();
                else
                    data = db.Discounts.OrderByDescending(p => p.ExpirationDate).ToList();
            }
            if (sortCategory == "Amount")
            {
                if (ascending)
                    data = db.Discounts.OrderBy(p => p.Amount).ToList();
                else
                    data = db.Discounts.OrderByDescending(p => p.Amount).ToList();
            }
            var sortedList = data.Select(p => new { p.DiscountName, p.DiscountType, p.Amount, p.StartingDate, p.ExpirationDate }).ToList();
            return sortedList;
        }

        public List<string> GetAllDiscountType()
        {
            List<string> discountTypeList = new List<string>();
            foreach(Discount i in GetAllDiscount())
            {
                discountTypeList.Add(i.DiscountType);
            }
            return discountTypeList;
        }

        public dynamic FilterDiscount(string filterValue)
        {
            List<Discount> data = new List<Discount>();
            foreach (Discount i in QLNS.Instance.Discounts.Select(p => p).ToList())
            {
                bool containType = i.DiscountType.IndexOf(filterValue, StringComparison.OrdinalIgnoreCase) >= 0;
                if (containType)
                {
                    data.Add(i);
                }
            }
            var prodList = data.Select(p => new { p.DiscountID, p.DiscountName, p.AmmountApply, p.DiscountApply, p.StartingDate, p.ExpirationDate });
            return prodList.ToList();
        }
        public void AddNewDiscount(Discount discount)
        {
            QLNS.Instance.Discounts.Add(discount);
            QLNS.Instance.SaveChanges();
        }
        /*public UpdateDiscountID(string productid, string discountid)
        {
            var Product = QLNS.Instance.Products.Find(productid);
            Product.DiscountID
        }*/
        public void UpdateProductDiscountIDList(string discountid, List<Product_Discount_View> productlist)
        {
            QLNS db = new QLNS();
            foreach (Product_Discount_View i in productlist.Distinct())
            {
                Product p = db.Products.Find(i.ProductID);
                p.DiscountID = i.DiscountID;
            }
            db.SaveChanges();
        }
        public List<Product_Discount_View> GetAllProduct_Discount_View()
        {
            List<Product_Discount_View> products = new List<Product_Discount_View>();
            var list = QLNS.Instance.Products.Select(p => p).ToList();
            foreach(var i in list)
            {
                Product_Discount_View temp = new Product_Discount_View();
                temp.ProductID = i.ProductID;
                temp.ProductName = i.ProductName;
                temp.DiscountID = i.DiscountID;
                products.Add(temp);
            }
            return products;
        }
        public int CountProductByDiscountID(List<Product_Discount_View> list,string discountid)
        {
            int count = 0;
            foreach(var product in list)
            {
                if(product.DiscountID == discountid)
                {
                    count += 1;
                }
            }
            return count;
        }
        public void Delete(List<string> id)
        {
            QLNS demo = new QLNS();
            foreach (string i in id)
            {
                Discount temp = demo.Discounts.Find(i);
                demo.Discounts.Remove(temp);
                demo.SaveChanges();
            }
        }
        public void Edit(Discount d)
        {
            Discount temp = QLNS.Instance.Discounts.Find(d.DiscountID);
            temp.DiscountName=d.DiscountName;
            temp.AmmountApply = d.AmmountApply;
            temp.DiscountApply = d.DiscountApply;
            temp.StartingDate = d.StartingDate;
            temp.ExpirationDate=d.ExpirationDate;
            temp.DiscountType=d.DiscountType;
            QLNS.Instance.SaveChanges();
        }
        public dynamic SearchDiscount(string searchValue)
        {
            List<Discount> data = new List<Discount>();
            foreach (Discount i in QLNS.Instance.Discounts.Select(p => p).ToList())
            {
                bool containName = i.DiscountName.IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0;
                bool containId = i.DiscountID.IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0;
                if (containName || containId)
                {
                    data.Add(i);
                }
            }
            var prodList = data.Select(p => new { p.DiscountID, p.DiscountName, p.AmmountApply, p.DiscountApply, p.StartingDate, p.ExpirationDate });
            return prodList.ToList();
        }
        public dynamic ShowAppliedProducts(string discountid)
        {
            var products = QLNS.Instance.Products.Where(p => p.DiscountID == discountid).Select(p => new { p.ProductID, p.ProductName });
            return products.ToList();
        }
        public bool Check(string discountid)
        {
            List<Discount> list = QLNS.Instance.Discounts.Select(p=>p).ToList();
            foreach(Discount i in list)
            {
                if(i.DiscountID == discountid)
                    return true;
            }
            return false;
        }
        public Discount GetDiscountByID(string ID)
        {
            var discount = QLNS.Instance.Discounts.Find(ID);
            return discount;
        }
        public List<ReceiptDetailView> GetListAfterSingleDiscount(List<ReceiptDetailView> list)
        {

            foreach (ReceiptDetailView item in list)
            {
                if (item.GetDiscount() != null)
                {
                    if (item.GetDiscount().DiscountType == "Single")
                    {
                        item.Voucher = item.GetDiscount().DiscountApply * item.Quantity;
                    }
                    item.Total = item.SellingPrice*item.Quantity-item.Voucher;
                }
            }
            return list;
        }
        public List<string> GetAllDiscountIDByTypeCombo()
        {
            List<String> list = new List<string>();
            var listDiscount = QLNS.Instance.Discounts.Select(p => p);
            foreach(var discount in listDiscount)
            {
                if (discount.DiscountType == "Combo")
                {
                    list.Add(discount.DiscountID);
                }
            }
            return list;
        }
        public Discount GetDiscountByDiscountID(string DiscountID)
        {
            return QLNS.Instance.Discounts.Find(DiscountID);
        }
        public int GetCoeficcient(IGrouping<string,ReceiptDetailView> group)
        {
            int count = group.ElementAt(0).Quantity;
            foreach(var i in group)
            {
                if (count >= i.Quantity)
                {
                    count = i.Quantity;
                }
            }
            return count;
        }
        public double GetTotalDiscount_ComboDiscount(List<ReceiptDetailView> list)
        {
            var GroupByMS = list.GroupBy(s=>s.GetDiscount().DiscountID);
            double result = 0;
            //Using Query Syntax
            //It will iterate through each groups
            foreach (var group in GroupByMS)
            {
                Discount d = GetDiscountByDiscountID(group.Key);
                if (group.Count() ==d.AmmountApply)
                {
                    int coeficient = GetCoeficcient(group);
                    //MessageBox.Show(coeficient.ToString());
                    result += coeficient * d.DiscountApply;
                    //MessageBox.Show(result.ToString());
                }
            }
            return result;
        }
        public dynamic SearchProductDiscountView(string searchValue)
        {
            List<Product_Discount_View> data = new List<Product_Discount_View>();
            foreach (Product_Discount_View i in GetAllProduct_Discount_View())
            {
                bool contains = i.ProductName.IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0;
                if (contains)
                {
                    data.Add(i);
                }
            }
            return data;
        }





    }
}
