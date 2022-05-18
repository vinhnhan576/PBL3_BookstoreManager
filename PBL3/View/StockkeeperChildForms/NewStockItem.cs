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

namespace PBL3.View.StockkeeperChildForms
{
    public partial class NewStockItem : Form
    {
        private List<RestockDetailView> list = new List<RestockDetailView>();
        Account account;
        Product newProduct;
        public NewStockItem(Account acc)
        {
            InitializeComponent();
            account = acc;
            dgvProducts.DataSource = BLLProductManagement.Instance.GetAllProduct_Stock_View();
            var random = new RandomGenerator();
            tbRestockID.Text = "rs" + random.RandomNumber(100, 9999);
            tbRestockID.Enabled = false;
            tbStockkeperID.Text = "sk001";
            tbStockkeperID.Enabled = false;
            tbTotal.Enabled = false;
            dtpRestock.Value = DateTime.Now;

        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 1)
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
            dgvProducts.DataSource = BLLProductManagement.Instance.GetAllProduct_Stock_View();
        }
        public void AddProduct(Product p, double importPrice)
        {
            newProduct = p;
            RestockDetailView restockDetailView = new RestockDetailView
            {
                ProductID = p.ProductID,
                ProductName = p.ProductName,
                ImportPrice = importPrice,
                ImportQuantity = p.StockQuantity,
                Total = importPrice * p.StockQuantity,
                RestockDetailID = p.RestockDetails.Count().ToString()
            };
            list.Add(restockDetailView);
            dgvRestock.DataSource = this.list.ToList();
        }
        private void butSave_Click(object sender, EventArgs e)
        {
            Restock restock = new Restock();
            restock.RestockID = tbRestockID.Text;
            //restock.PersonID = SalesmanIDtxt.Text;
            restock.ImportDate = DateTime.Now;
            restock.TotalExpense = Convert.ToInt32(tbTotal.Text);
            BLLRestockManagement.Instance.AddNewRestock(restock);
            BLLRestockManagement.Instance.AddNewRestockDetail(list, tbRestockID.Text);
            for (int i = 0; i < list.Count; i++)
            {
                string productID = list[i].ProductID;
                int prodQuantity = list[i].ImportQuantity;
                BLLProductManagement.Instance.IncreaseStockQuantity(productID, prodQuantity);
            }
            list.Clear();
            dgvRestock.DataSource = list.ToList();
            tbRestockID.Text = "";
            tbStockkeperID.Text = "";
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            if (dgvRestock.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dgvRestock.SelectedRows.Count; i++)
                {
                    list.RemoveAt(i);

                }
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

        private void butNewStock_Click(object sender, EventArgs e)
        {
            int count = QLSPEntities.Instance.Restocks.Count() + 1;
            var random = new RandomGenerator();
            tbRestockID.Text = count.ToString();
            tbStockkeperID.Text = account.PersonID;
            dtpRestock.Value = DateTime.Now;
        }

        private void butAddnewProduct_Click(object sender, EventArgs e)
        {
            AddNewProduct form = new AddNewProduct();
            form.FormBorderStyle = FormBorderStyle.None;
            form.MyDel = AddProduct;
            form.ShowDialog();
        }
    }
}
