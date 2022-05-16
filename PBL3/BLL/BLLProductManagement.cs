using System;
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
            return product;
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

        public dynamic GetAllProduct_Import_View()
        {
            QLSPEntities db = new QLSPEntities();
            var productImport = db.Store_Imports.Select(p => new { p.ImportDate, p.ImportQuantity, p.Product.StoreQuantity });
            return productImport;
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
                bool containStatus = i.Status.IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0;
                bool containCategory = i.Category.IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0;
                if (containName || containStatus || containCategory)
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
            return data;
        }
    }
}