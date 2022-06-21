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
        Account account; 
        List<StoreImportDetailView> list = new List<StoreImportDetailView>();
        public ImportStore(Account acc)
        {
            InitializeComponent();
            dgvProducts.DataSource = BLLProductManagement.Instance.GetAllProduct_Import_View();
            account = acc;
            NewImport();
        }
        private void butAdd_Click(object sender, EventArgs e)
        {
           
            if (dgvProducts.SelectedRows.Count == 1)
            { 
                if (tbQuantity.Text == "" || DataCheck.IsNumber(tbQuantity.Text) != true)
                    CustomMessageBox.MessageBox.Show("Invalid \n   Please re-enter quantity", "Wrong input", MessageBoxIcon.Error);
                else if (Convert.ToInt32(tbQuantity.Text) > Convert.ToInt32(dgvProducts.SelectedRows[0].Cells[3].Value))
                    CustomMessageBox.MessageBox.Show("The number of products is not enough \n   Please re-enter quantity", "Wrong input", MessageBoxIcon.Error);
                else
                {
                    string productID = dgvProducts.SelectedRows[0].Cells["ProductID"].Value.ToString();
                    int quantity = Convert.ToInt32(tbQuantity.Text.ToString());
                    list = BLLStoreImportManagement.Instance.CreateStoreImportDetailView(this.list, productID, quantity);

                }
                
                //this.list.Add(temp);
            }
            var Restock = this.list.Select(p => new { p.ProductID, p.ProductName, p.ImportQuantity, });
            dgvImport.DataSource = this.list.ToList();
            tbQuantity.Text = null;
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
            tbStoreImportID.Text = null;
            tbStockkeperID.Text = null;
            dgvProducts.DataSource = BLLProductManagement.Instance.GetAllProduct_Import_View();

            NewImport();
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            if (dgvImport.SelectedRows.Count == 1)
            { 
                list.RemoveAt(dgvImport.SelectedRows.Count);
            }
            dgvImport.DataSource = list.ToList();
        }

        private void butClear_Click(object sender, EventArgs e)
        {
            list.Clear();
            dgvImport.DataSource = list.ToList();
        }

        private void NewImport()
        {
            int count = (QLNS.Instance.StoreImports.Count() + 1);
            tbStoreImportID.Text = "si" + count.ToString();
            tbStoreImportID.Enabled = false;
            tbStockkeperID.Text = account.PersonID;
            tbStockkeperID.Enabled = false;
            dtpRestock.Value = DateTime.Now;
        }

        private void cbbFilterCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbbFilterValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvProducts.DataSource = BLLProductManagement.Instance.SearchProduct_Restock(cbbFilterValue.SelectedItem.ToString());

        }
    }
}
