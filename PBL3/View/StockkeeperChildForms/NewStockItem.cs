using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.BLL;
using PBL3.DTO;
using PBL3.Model;

namespace PBL3.View.StockkeeperChildForms
{
    public partial class NewStockItem : Form
    {
        private List<RestockDetailView> list = new List<RestockDetailView>();
        Account account;
        Product newProduct;
        List<Product> listnewProduct = new List<Product>();
        public NewStockItem(Account acc)
        {
            InitializeComponent();
            account = acc;
            dgvProducts.DataSource = BLLProductManagement.Instance.GetAllProduct_Import_Views();
            tbRestockID.Text = "rs00" + (QLNS.Instance.Restocks.Count()+1).ToString();
            tbRestockID.Enabled = false;
            tbStockkeperID.Text = account.PersonID;
            tbStockkeperID.Enabled = false;
            tbTotal.Enabled = false;
            dtpRestock.Value = DateTime.Now;

        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            if (tbImportPrice.Text == "" || tbQuantity.Text == "" || DataCheck.IsNumber(tbImportPrice.Text) != true || DataCheck.IsNumber(tbQuantity.Text) != true)
                CustomMessageBox.MessageBox.Show("Invalid \n   Please re-enter quantity and price", "Wrong input", MessageBoxIcon.Error);
            else if (dgvProducts.SelectedRows.Count == 1)
            {
                string productID = dgvProducts.SelectedRows[0].Cells["ProductID"].Value.ToString();
                int quantity = Convert.ToInt32(tbQuantity.Text.ToString());
                double importPrice = Convert.ToDouble(tbImportPrice.Text.ToString());
                list = BLLRestockManagement.Instance.CreateRestockDetailView(this.list, productID, quantity, importPrice);
                //this.list.Add(temp);
            }
            var Restock = this.list.Select(p => new { p.ProductID, p.ProductName, p.ImportPrice, p.ImportQuantity,p.Total });
            dgvRestock.DataSource = this.list.ToList();
            tbTotal.Text = BLLRestockManagement.Instance.CalculateRestockToTal(this.list).ToString();
            tbQuantity.Text = "";
            tbImportPrice.Text = "";
            dgvProducts.DataSource = BLLProductManagement.Instance.GetAllProduct_Import_Views();
        }
        public void AddProduct(Product p, double importPrice)
        {
            var random = new RandomGenerator();
            newProduct = p;
            RestockDetailView restockDetailView = new RestockDetailView
            {
                ProductID = p.ProductID,
                ProductName = p.ProductName,
                ImportPrice = importPrice,
                ImportQuantity = p.StockQuantity,
                Total = importPrice * p.StockQuantity,
                RestockDetailID = "rs00"+(QLNS.Instance.RestockDetails.Count()+list.Count()+1).ToString(), 
            };
            list.Add(restockDetailView);
            dgvRestock.DataSource = this.list.ToList();
            tbTotal.Text = BLLRestockManagement.Instance.CalculateRestockToTal(this.list).ToString();
            listnewProduct.Add(newProduct);

        }
        private void butSave_Click(object sender, EventArgs e)
        {
            Restock restock = new Restock();
            restock.RestockID = tbRestockID.Text;
            restock.PersonID = tbStockkeperID.Text;
            restock.ImportDate = DateTime.Now;
            restock.TotalExpense = Convert.ToInt32(tbTotal.Text);
            foreach(Product p in listnewProduct)
            {
                BLLProductManagement.Instance.AddNewProduct(p);
            }
            BLLRestockManagement.Instance.AddNewRestock(restock);
            BLLRestockManagement.Instance.AddNewRestockDetail(list, tbRestockID.Text);
            string productID;
            int prodQuantity;
            for (int i = 0; i < list.Count; i++)
            {
                productID = list[i].ProductID;
                prodQuantity = list[i].ImportQuantity;
                BLLProductManagement.Instance.IncreaseStockQuantity(productID, prodQuantity);
            }
            list.Clear();
            dgvRestock.DataSource = list.ToList();
            tbRestockID.Text = "";
            tbStockkeperID.Text = "";
            tbTotal.Text = "";
            dgvProducts.DataSource = BLLProductManagement.Instance.GetAllProduct_Import_Views();

            NewStock();
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            if (dgvRestock.SelectedRows.Count == 1)
            {
                list.RemoveAt(dgvRestock.SelectedRows.Count);
            }
            dgvRestock.DataSource = list.ToList();
            tbTotal.Text = BLLRestockManagement.Instance.CalculateRestockToTal(list).ToString();
        }

        private void butClear_Click(object sender, EventArgs e)
        {
            list.Clear();
            dgvRestock.DataSource = list.ToList();
            tbTotal.Text = BLLRestockManagement.Instance.CalculateRestockToTal(list).ToString();
        }

        private void NewStock()
        {
            int count = (QLNS.Instance.Restocks.Count() + 1);
            tbRestockID.Text = "rs"+count.ToString();
            tbStockkeperID.Text = account.PersonID;
            dtpRestock.Value = DateTime.Now;
        }

        private void butAddnewProduct_Click(object sender, EventArgs e)
        {
            AddNewProduct form = new AddNewProduct();
            //form.FormBorderStyle = FormBorderStyle.None;
            form.MyDel = AddProduct;
            form.Show();
        }
        private void cbbFilterCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbFilterValue.Text = "";
            cbbFilterValue.Items.Clear();
            string filterCategory = cbbFilterCategory.SelectedItem.ToString();
            if (filterCategory == "All")
            {
                dgvProducts.DataSource = BLLProductManagement.Instance.GetAllProduct_Restock_View();
            }
            if (filterCategory == "Category")
            {
                foreach (string i in BLLProductManagement.Instance.GetAllProductCategory().Distinct())
                {
                    cbbFilterValue.Items.Add(i);
                }
            }
            if (filterCategory == "Author")
            {
                foreach (string i in BLLProductManagement.Instance.GetAllProductAuthor().Distinct())
                {
                    cbbFilterValue.Items.Add(i);
                }
            }
        }

        private void cbbFilterValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvProducts.DataSource = BLLProductManagement.Instance.FilterProduct_Restock(cbbFilterCategory.SelectedItem.ToString(), cbbFilterValue.SelectedItem.ToString());
        }

        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                dgvProducts.DataSource = BLLProductManagement.Instance.SearchProduct_Restock(tbSearch.Text);
            }
        }
    }
}
