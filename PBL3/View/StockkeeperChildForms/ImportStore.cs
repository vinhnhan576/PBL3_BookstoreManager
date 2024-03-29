﻿using System;
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
            dgvProducts.Columns[0].HeaderText = "ID";
            dgvProducts.Columns[1].HeaderText = "Name";
            dgvProducts.Columns[2].HeaderText = "Store quantity";
            dgvProducts.Columns[3].HeaderText = "Stock quantity";
            dgvProducts.AutoResizeColumns();
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
            s.PersonID = tbStockkeperID.Text;
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
                list.RemoveAt(dgvImport.SelectedRows.Count - 1);
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
            tbStoreImportID.Text = BLLStoreImportManagement.Instance.GenerateStoreImportID();
            tbStoreImportID.Enabled = false;
            tbStockkeperID.Text = account.PersonID;
            tbStockkeperID.Enabled = false;
            dtpRestock.Value = DateTime.Now;
        }

        private void cbbFilterValue_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            dgvProducts.DataSource = BLLProductManagement.Instance.FilterProduct_Import(cbbFilterCategory.SelectedItem.ToString(), cbbFilterValue.SelectedItem.ToString());
        }

        private void cbbFilterCategory_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cbbFilterValue.Text = "";
            cbbFilterValue.Items.Clear();
            string filterCategory = cbbFilterCategory.SelectedItem.ToString();
            if (filterCategory == "All")
            {
                dgvProducts.DataSource = BLLProductManagement.Instance.GetAllProduct_Import_View();
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

        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                dgvProducts.DataSource = BLLProductManagement.Instance.SearchProduct_Import(tbSearch.Text);
            }
        }
    }
}
