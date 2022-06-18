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

namespace PBL3.View.AdminChildForms
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
            InitializeGUI();
            dgvCustomer.DataSource = BLLCustomerManagement.Instance.GetAllCustomer_View();
            cbbSortOrder.SelectedIndex = 0;
            this.cbbSortOrder.SelectedIndexChanged += new System.EventHandler(this.cbbSortOrder_SelectedIndexChanged);
            cbbSortCategory.SelectedIndex = 0;
            this.cbbSortCategory.SelectedIndexChanged += new System.EventHandler(this.cbbSortCategory_SelectedIndexChanged);
        }

        private void InitializeGUI()
        {
            dgvCustomer.DataSource = BLLCustomerManagement.Instance.GetAllCustomer_View();
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCustomer.SelectedRows.Count == 1)
            {
                Ranktxt.Text = "";
                TotalSpendingtxt.Text = "";
                CustomerNametxt.Text = dgvCustomer.SelectedRows[0].Cells["CustomerName"].Value.ToString();
                Teltxt.Text = dgvCustomer.SelectedRows[0].Cells["PhoneNumber"].Value.ToString();
                if (dgvCustomer.SelectedRows[0].Cells[3].Value != null)
                {
                    Ranktxt.Text = dgvCustomer.SelectedRows[0].Cells[3].Value.ToString();
                }
                if (dgvCustomer.SelectedRows[0].Cells["TotalSpending"].Value != null)
                {
                    TotalSpendingtxt.Text = dgvCustomer.SelectedRows[0].Cells["TotalSpending"].Value.ToString();   
                }
                Productdgv.DataSource = BLLCustomerManagement.Instance.GetReceiptByCustomerTel(dgvCustomer.SelectedRows[0].Cells[0].Value.ToString());
            }

        }
        private void cbbSortOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            Searchtxt.Text = "";
            string sortCategory = cbbSortCategory.SelectedItem.ToString();
            bool sortOrder = (cbbSortOrder.SelectedItem.ToString() == "Ascending" ? true : false);
            dgvCustomer.DataSource = BLLCustomerManagement.Instance.SortCustomer(sortCategory, sortOrder);
        }

        private void cbbFilterCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbFilterValue.Text = "";
            cbbFilterValue.Items.Clear();
            string filterCategory = cbbFilterCategory.SelectedItem.ToString();
            if (filterCategory == "Rank")
            {
                foreach (string i in BLLCustomerManagement.Instance.GetAllCustomerRank())
                {
                    cbbFilterValue.Items.Add(i);
                }
            }

        }

        private void cbbFilterValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvCustomer.DataSource = BLLCustomerManagement.Instance.FilterCustomer(cbbFilterValue.SelectedItem.ToString());
        }

        private void Searchtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (string.IsNullOrWhiteSpace(Searchtxt.Text))
                {
                    dgvCustomer.DataSource = BLLCustomerManagement.Instance.SearchCustomer(Searchtxt.Text);
                }
                else
                {
                    dgvCustomer.DataSource = BLLCustomerManagement.Instance.GetAllCustomer_View();
                }
            }
        }

        private void cbbSortCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            Searchtxt.Text = "";
            string sortCategory = cbbSortCategory.SelectedItem.ToString();
            bool sortOrder = (cbbSortOrder.SelectedItem.ToString() == "Ascending" ? true : false);
            dgvCustomer.DataSource = BLLCustomerManagement.Instance.SortCustomer(sortCategory, sortOrder);
        }

        private void Searchtxt_IconRightClick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Searchtxt.Text))
            {
                dgvCustomer.DataSource = BLLCustomerManagement.Instance.SearchCustomer(Searchtxt.Text);
            }
            else
            {
                dgvCustomer.DataSource = BLLCustomerManagement.Instance.GetAllCustomer_View();
            }
        }
    }
}
