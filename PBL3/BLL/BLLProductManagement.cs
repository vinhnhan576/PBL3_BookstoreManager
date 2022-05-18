﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;



namespace PBL3.BLL
{
    public class BLLProductManagement
    {
        private static BLLProductManagement instance;
        public static BLLProductManagement Instance
        {
            get
            {
                if (instance == null)
                    instance = new BLLProductManagement();
                return instance;
            }
            private set { }
        }

        private BLLProductManagement()
        {


            QLSPEntities.Instance.Products.Add(p);
            QLSPEntities.Instance.SaveChanges();
        }

        public List<Product> GetAllProduct()
        {
            QLSPEntities db = new QLSPEntities();
            List<Product> data = new List<Product>();
            foreach (Product i in db.Products.Select(p => p))
            {
                data.Add(i);
            }
            return data;
        }
        public dynamic GetAllProduct_Stock_View()
        {
            var product = QLSPEntities.Instance.Products.Select(p => new { p.ProductID, p.ProductName, p.StockQuantity });
            return product.ToList();
        }

        public dynamic GetAllProduct_View()
        {
            QLSPEntities db = new QLSPEntities();
            var product = db.Products.Select(p => new { p.ProductID, p.ProductName, p.Category, p.StoreQuantity, p.SellingPrice, p.Status });
            return product.ToList();
        }

        public dynamic GetAllProduct_Order_View()
        {

            var product = (QLSPEntities.Instance.Products.Select(p => new { p.ProductID, p.ProductName, p.StoreQuantity, p.SellingPrice })).ToList();
            return product;
        }

        public dynamic GetAllProduct_Price_View()
        {
            QLSPEntities db = new QLSPEntities();
            List<Product_Price_View> products = new List<Product_Price_View>();
            foreach (Product i in db.Products.Select(p => p))
            {
                products.Add(new Product_Price_View
                {
                    ProductID = i.ProductID,
                    ProductName = i.ProductName,
                    SellingPrice = i.SellingPrice,
                });
            }
            return products;
        }


        //public dynamic GetAllProduct_Import_View()
        //{
        //    QLSPEntities db = new QLSPEntities();
        //    var productImport = db.Store_Imports.Select(p => new { p.ImportDate, p.ImportQuantity, p.Product.StoreQuantity });
        //    return productImport;
        //}


        public void UpdatePrice(List<string> ID, List<double> newPrice)
        {
            QLSPEntities db = new QLSPEntities();
            foreach (string i in ID)
            {
                Product p = db.Products.Find(i);
                if (p != null)
                {
                    p.SellingPrice = newPrice[ID.IndexOf(i)];
                }
            }
            db.SaveChanges();
        }

        public void Execute(string ID, double newPrice)
        {
            QLSPEntities db = new QLSPEntities();
            Product p = db.Products.Find(ID);
            p.SellingPrice = newPrice;
            db.SaveChanges();
        }



        public dynamic SearchProduct(string searchValue)
        {
            List<Product> data = new List<Product>();
            foreach (Product i in QLSPEntities.Instance.Products.Select(p => p).ToList())
            {
                bool containName = i.ProductName.IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0;
                bool containId = i.ProductID.IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0;
                if (containName || containId)
                {
                    data.Add(i);
                }
            }
            var prodList = data.Select(p => new { p.ProductID, p.ProductName, p.Category, p.StoreQuantity, p.SellingPrice, p.Status });
            return prodList.ToList();
        }



        public dynamic SearchProductPriceView(string searchValue)
        {
            List<Product_Price_View> data = new List<Product_Price_View>();
            foreach (Product_Price_View i in GetAllProduct_Price_View())
            {
                bool contains = i.ProductName.IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0;
                if (contains)
                {
                    data.Add(i);
                }
            }
            return data;
        }


        public dynamic SortProduct(string sortCategory, bool ascending)
        {
            QLSPEntities db = new QLSPEntities();
            List<Product> data = new List<Product>();
            if (sortCategory == "ProductID")
            {
                if (ascending)
                    data = db.Products.OrderBy(p => p.ProductID).ToList();
                else
                    data = db.Products.OrderByDescending(p => p.ProductID).ToList();
            }
            if (sortCategory == "ProductName")
            {
                if (ascending)
                    data = db.Products.OrderBy(p => p.ProductName).ToList();
                else
                    data = db.Products.OrderByDescending(p => p.ProductName).ToList();
            }
            if (sortCategory == "PublishYear")
            {
                if (ascending)
                    data = db.Products.OrderBy(p => p.PublishYear).ToList();
                else
                    data = db.Products.OrderByDescending(p => p.PublishYear).ToList();
            }
            if (sortCategory == "SellingPrice")
            {
                if (ascending)
                    data = db.Products.OrderBy(p => p.SellingPrice).ToList();
                else
                    data = db.Products.OrderByDescending(p => p.SellingPrice).ToList();
            }
            if (sortCategory == "StockQuantity")
            {
                if (ascending)
                    data = db.Products.OrderBy(p => p.StockQuantity).ToList();
                else
                    data = db.Products.OrderByDescending(p => p.StockQuantity).ToList();
            }
            if (sortCategory == "StoreQuantity")
            {
                if (ascending)
                    data = db.Products.OrderBy(p => p.StoreQuantity).ToList();
                else
                    data = db.Products.OrderByDescending(p => p.StoreQuantity).ToList();
            }
            var newList = data.Select(p => new { p.ProductID, p.ProductName, p.Category, p.StoreQuantity, p.SellingPrice, p.Status }).ToList();
            return newList;
        }

        public dynamic FilterProduct(string filterValue)
        {
            List<Product> data = new List<Product>();
            foreach (Product i in QLSPEntities.Instance.Products.Select(p => p).ToList())
            {
                bool containStatus = i.Status.IndexOf(filterValue, StringComparison.OrdinalIgnoreCase) >= 0;
                bool containCategory = i.Category.IndexOf(filterValue, StringComparison.OrdinalIgnoreCase) >= 0;
                if (containStatus || containCategory)
                {
                    data.Add(i);
                }
            }
            var prodList = data.Select(p => new { p.ProductID, p.ProductName, p.Category, p.StoreQuantity, p.SellingPrice, p.Status });
            return prodList.ToList();
            /*QLSPEntities db = new QLSPEntities();
            List<Product> data = new List<Product>();
            foreach (Product i in QLSPEntities.Instance.Products.Select(p => p).ToList())
            {
                if (filterCategory == "ProductName")
                {
                    if (i.ProductName == filterValue)
                    {
                        data.Add(i);
                    }
                }
                if (filterCategory == "Status")
                {
                    if (i.Status == filterValue)
                    {
                        data.Add(i);
                    }
                }
            }
            var prodViewList = data.Select(p => new { p.ProductID, p.ProductName, p.Category, p.StoreQuantity, p.SellingPrice, p.Status });
            return prodViewList;*/
        }



        public List<string> GetAllProductCategory()
        {
            List<string> prodCategoryList = new List<string>();
            foreach (Product i in GetAllProduct())
            {
                prodCategoryList.Add(i.Category);
            }
            return prodCategoryList;
        }
        public List<string> GetAllProductAuthor()
        {
            List<string> prodCategoryList = new List<string>();
            foreach (Product i in GetAllProduct())
            {
                prodCategoryList.Add(i.Author);
            }
            return prodCategoryList;
        }
        public List<string> GetAllProductStatus()
        {
            List<string> prodStatusList = new List<string>();
            foreach (Product i in GetAllProduct())
            {
                prodStatusList.Add(i.Status);
            }
            return prodStatusList;
        }
        public dynamic SearchProduct_Order(string searchValue)
        {
            List<Product> data = new List<Product>();
            foreach (Product i in QLSPEntities.Instance.Products.Select(p => p).ToList())
            {
                bool containID = i.ProductID.IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0;
                bool containName = i.ProductName.IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0;
                bool containStatus = i.Status.IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0;
                bool containCategory = i.Category.IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0;
                if (containID||containName || containStatus || containCategory)
                {
                    data.Add(i);
                }
            }
            var prodList = data.Select(p => new { p.ProductID, p.ProductName, p.Category, p.StoreQuantity, p.SellingPrice, p.Status });
            return prodList.ToList();



        }
        public void DecreaseStoreQuantity(string productid, int num)
        {

            var product = QLSPEntities.Instance.Products.Find(productid);
            product.StoreQuantity = (Convert.ToInt32(product.StoreQuantity) - num).ToString();
            QLSPEntities.Instance.SaveChanges();

        }
        public void IncreaseStockQuantity(string productid, int num)
        {

            var product = QLSPEntities.Instance.Products.Find(productid);
            product.StockQuantity = (Convert.ToInt32(product.StockQuantity) + num);
            QLSPEntities.Instance.SaveChanges();

        }

        public Product GetProductByID(string productID)
        {
            return QLSPEntities.Instance.Products.Find(productID);
        }
    }
}