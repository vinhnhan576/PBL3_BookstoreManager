using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;
using PBL3.Model;

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
            QLNS db = new QLNS();
            List<Product> data = new List<Product>();
            foreach (Product i in db.Products.Select(p => p))
            {
                data.Add(i);
            }
            return data;
        }
        public dynamic GetAllProduct_Import_Views()
        {
            var product = QLNS.Instance.Products.OrderBy(p => p.ProductID.Length).ThenBy(p => p.ProductID)
                .Select(p => new { p.ProductID, p.ProductName, p.StockQuantity });
            return product.ToList();
        }

        public dynamic GetAllProduct_View()
        {
            QLNS db = new QLNS();
            var product = db.Products.OrderBy(p => p.ProductID.Length).ThenBy(p => p.ProductID)
                .Select(p => new { p.ProductID, p.ProductName, p.Category, p.StoreQuantity, p.SellingPrice, p.Status });
            return product.ToList();
        }

        public dynamic GetAllProduct_Order_View()
        {
            var product = (QLNS.Instance.Products.OrderBy(p => p.ProductID.Length).ThenBy(p => p.ProductID)
                .Select(p => new { p.ProductID, p.ProductName, p.StoreQuantity, p.SellingPrice })).ToList();
            return product;
        }
        public dynamic GetAllProduct_Restock_View()
        {
            var product = (QLNS.Instance.Products.OrderBy(p => p.ProductID.Length).ThenBy(p => p.ProductID)
                .Select(p => new { p.ProductID, p.ProductName,p.StockQuantity })).ToList();
            return product;
        }
        public dynamic GetAllProduct_Import_View()
        {
            var product = (QLNS.Instance.Products.OrderBy(p => p.ProductID.Length).ThenBy(p => p.ProductID)
                .Select(p => new { p.ProductID, p.ProductName, p.StoreQuantity, p.StockQuantity })).ToList();
            return product;
        }
        public dynamic GetAllProduct_Price_View()
        {
            QLNS db = new QLNS();
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
            return products.OrderBy(p => p.ProductID.Length).ThenBy(p => p.ProductID).ToList();
        }

        public dynamic GetAllProduct_OrderView()
        {
            var products = QLNS.Instance.Products.Select(p => new { p.ProductName, p.StoreQuantity });
            return products.ToList();
        }

        //public dynamic GetAllProduct_Import_View()
        //{
        //    QLSPEntities db = new QLSPEntities();
        //    var productImport = db.Store_Imports.Select(p => new { p.ImportDate, p.ImportQuantity, p.Product.StoreQuantity });
        //    return productImport;
        //}

        public void AddNewProduct(Product p)
        {

            QLNS.Instance.Products.Add(p);
            QLNS.Instance.SaveChanges();
        }

        public void UpdatePrice(List<string> ID, List<double> newPrice)
        {
            QLNS db = new QLNS();
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
            QLNS db = new QLNS();
            Product p = db.Products.Find(ID);
            p.SellingPrice = newPrice;
            db.SaveChanges();
        }
        public dynamic SearchProduct(string searchValue)
        {
            List<Product> data = new List<Product>();
            foreach (Product i in QLNS.Instance.Products.Select(p => p).ToList())
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
        public dynamic FilterProduct(string filterValue)
        {
            List<Product> data = new List<Product>();
            foreach (Product i in GetAllProduct())
            {
                if (i.Category == filterValue)
                {
                    data.Add(i);
                }
                if (i.Status == filterValue)
                {
                    data.Add(i);
                }
            }
            var prodList = data.Select(p => new { p.ProductName,p.StoreQuantity});
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
            QLNS db = new QLNS();
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

        public dynamic FilterProduct(string filterCategory, string filterValue)
        {
            List<Product> data = new List<Product>();
            if (filterCategory == "Status")
                data = QLNS.Instance.Products.Where(p => p.Status == filterValue).ToList();
            if(filterCategory == "Category")
                data = QLNS.Instance.Products.Where(p => p.Category == filterValue).ToList();
            var newList = data.Select(p => new { p.ProductID, p.ProductName, p.Category, p.StoreQuantity, p.SellingPrice, p.Status });
            return newList.ToList();
        }

        public dynamic FilterProduct_Restock(string filterCategory, string filterValue)
        {
            List<Product> data = new List<Product>();
            if (filterCategory == "Author")
                data = QLNS.Instance.Products.Where(p => p.Author == filterValue).ToList();
            if (filterCategory == "Category")
                data = QLNS.Instance.Products.Where(p => p.Category == filterValue).ToList();
            var newList = data.Select(p => new { p.ProductID, p.ProductName, p.StockQuantity });
            return newList.ToList();
        }
        public dynamic FilterProduct_Import(string filterCategory, string filterValue)
        {
            List<Product> data = new List<Product>();
            if (filterCategory == "Author")
                data = QLNS.Instance.Products.Where(p => p.Author == filterValue).ToList();
            if (filterCategory == "Category")
                data = QLNS.Instance.Products.Where(p => p.Category == filterValue).ToList();
            var newList = data.Select(p => new { p.ProductID, p.ProductName,p.StoreQuantity, p.StockQuantity });
            return newList.ToList();
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
            foreach (Product i in QLNS.Instance.Products.Select(p => p).ToList())
            {
                bool containID = i.ProductID.IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0;
                bool containName = i.ProductName.IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0;
                //bool containStatus = i.Status.IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0;
                //bool containCategory = i.Category.IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0;
                if (containID||containName)
                {
                    data.Add(i);
                }
            }
            var prodList = data.Select(p => new {p.ProductName,p.StoreQuantity});
            return prodList.ToList();
        }
        public dynamic SearchProduct_Restock(string searchValue)
        {
            List<Product> data = new List<Product>();
            foreach (Product i in QLNS.Instance.Products.Select(p => p).ToList())
            {
                bool containName = i.ProductName.IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0;
                if (containName )
                {
                    data.Add(i);
                }
            }
            var prodList = data.Select(p => new { p.ProductID, p.ProductName, p.StockQuantity });
            return prodList.ToList();
        }
        public dynamic SearchProduct_Import(string searchValue)
        {
            List<Product> data = new List<Product>();
            foreach (Product i in QLNS.Instance.Products.Select(p => p).ToList())
            {
                bool containName = i.ProductName.IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0;
                if (containName )
                {
                    data.Add(i);
                }
            }
            var prodList = data.Select(p => new { p.ProductID, p.ProductName,p.StoreQuantity,p.StockQuantity });
            return prodList.ToList();
        }
        public void DecreaseStoreQuantity(string productid, int num)
        {
            var product = QLNS.Instance.Products.Find(productid);
            product.StoreQuantity = (Convert.ToInt32(product.StoreQuantity) - num);
            QLNS.Instance.SaveChanges();

        }
        public void IncreaseStockQuantity(string productid, int num)
        {

            var product = QLNS.Instance.Products.Find(productid);
            product.StockQuantity = (Convert.ToInt32(product.StockQuantity) + num);
            QLNS.Instance.SaveChanges();

        }
        public void IncreaseStoreQuantity(string productid, int num)
        {

            var product = QLNS.Instance.Products.Find(productid);
            product.StoreQuantity = (Convert.ToInt32(product.StoreQuantity) + num);
            product.StockQuantity = (Convert.ToInt32(product.StockQuantity) - num);
            QLNS.Instance.SaveChanges();

        }

        public Product GetProductByID(string productID)
        {
            return QLNS.Instance.Products.Find(productID);
        }

        public Product GetProductByProductName(string productName)
        {
            Product product = new Product();
            foreach(Product prod in GetAllProduct())
            {
                if(prod.ProductName == productName)
                {
                    product = prod;
                    break;
                }
            }
            return product;
        }
        public List<string> GetAllProductPublisher()
        {
            List<string> prodPublisherList = new List<string>();
            foreach (Product i in GetAllProduct())
            {
                prodPublisherList.Add(i.Author);
            }
            return prodPublisherList;
        }

        public int CountProduct()
        {
            return GetAllProduct().Count()+1;
        }

        public Product_Price_View GetProduct_PriceViewByProductID(string productID)
        {
            Product p = QLNS.Instance.Products.Find(productID);
            Product_Price_View priceView = new Product_Price_View
            {
                ProductID = p.ProductID,
                ProductName = p.ProductName,
                SellingPrice = p.SellingPrice
            };
            return priceView;
        }
    }
}