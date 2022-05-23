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
    public partial class ImportStore : Form
    {
        List<StoreImportDetailView> list = new List<StoreImportDetailView>();
        public ImportStore()
        {
            InitializeComponent();
            dgvProducts.DataSource = BLLProductManagement.Instance.GetAllProduct_Import_View();
            //account = acc;
            tbStoreImportID.Text = "is00" + (QLNS.Instance.StoreImports.Count() + 1).ToString();
            tbStoreImportID.Enabled = false;
            tbStockkeperID.Text = "sk001";
            tbStockkeperID.Enabled = false;
            dtpRestock.Value = DateTime.Now;
        }
        private void butAdd_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 1)
            {
                string productID = dgvProducts.SelectedRows[0].Cells["ProductID"].Value.ToString();
                int quantity = Convert.ToInt32(tbQuantity.Text.ToString());
                list = BLLStoreImportManagement.Instance.CreateStoreImportDetailView(this.list, productID, quantity);
                //this.list.Add(temp);
            }
            var Restock = this.list.Select(p => new { p.ProductID, p.ProductName, p.ImportQuantity, });
            dgvImport.DataSource = this.list.ToList();
            tbQuantity.Text = "";
            dgvProducts.DataSource = BLLProductManagement.Instance.GetAllProduct_Import_View();
        }
        private void butSave_Click(object sender, EventArgs e)
        {
            StoreImport s = new StoreImport();
            s.StoreImportID = tbStoreImportID.Text;
            //s.PersonID = tbStockkeperID.Text;
            s.ImportDate = DateTime.Now;
            BLLStoreImportManagement.Instance.AddNewStoreImport(s);
            BLLStoreImportManagement.Instance.AddNewStoreImportDetail(list, tbStoreImportID.Text);
            string productID;
            int prodQuantity;
            for (int i = 0; i < list.Count; i++)
            {
                productID = list[i].ProductID;
                prodQuantity = list[i].ImportQuantity;
                BLLProductManagement.Instance.IncreaseStoreQuantity(productID, prodQuantity);
            }
            list.Clear();
            dgvImport.DataSource = list.ToList();
            tbStoreImportID.Text = "";
            tbStockkeperID.Text = "";
            dgvProducts.DataSource = BLLProductManagement.Instance.GetAllProduct_Import_View();
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            if (dgvImport.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dgvImport.SelectedRows.Count; i++)
                {
                    list.RemoveAt(i);

                }
            }
            dgvImport.DataSource = list.ToList();
        }

        private void butClear_Click(object sender, EventArgs e)
        {
            list.Clear();
            dgvImport.DataSource = list.ToList();
        }

        private void butNewImport_Click(object sender, EventArgs e)
        {
            int count = (QLNS.Instance.Restocks.Count() + 1);
            tbStoreImportID.Text = "rs" + count.ToString();
            tbStockkeperID.Text = "sk001";//account.PersonID;
            dtpRestock.Value = DateTime.Now;
        }

        private void cbbFilterCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbFilterValue.Text = "";
            cbbFilterValue.Items.Clear();
            string filterCategory = cbbFilterCategory.SelectedItem.ToString();
            if (filterCategory == "Category")
            {
                foreach (string i in BLLProductManagement.Instance.GetAllProductCategory().Distinct())
                {
                    cbbFilterValue.Items.Add(i);
                    //MessageBox.Show("i");
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
            dgvProducts.DataSource = BLLProductManagement.Instance.SearchProduct_Restock(cbbFilterValue.SelectedItem.ToString());

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
