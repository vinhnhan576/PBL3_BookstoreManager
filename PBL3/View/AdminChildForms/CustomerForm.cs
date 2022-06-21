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
            cbbSortCategory.Items.AddRange(BLLCustomerManagement.Instance.getAllSortCategory().ToArray());
            cbbFilterValue.Items.Add( new CBBItem { Text="",Value="All"});
            cbbFilterCategory.Items.AddRange(BLLCustomerManagement.Instance.getAllFilterCategory().ToArray());
            this.cbbSortOrder.SelectedIndexChanged += new System.EventHandler(this.cbbSortOrder_SelectedIndexChanged);
            cbbSortCategory.SelectedIndex = 0;
            //this.cbbSortCategory.SelectedIndexChanged += new System.EventHandler(this.cbbSortCategory_SelectedIndexChanged);
            CustomerNametxt.ReadOnly = true;
            Ranktxt.ReadOnly = true;
            Teltxt.ReadOnly = true;
            TotalSpendingtxt.ReadOnly = true;
        }

        private void InitializeGUI()
        {
            dgvCustomer.DataSource = BLLCustomerManagement.Instance.GetAllCustomer_View();
            dgvCustomer_CellClick(this, new DataGridViewCellEventArgs(0, 0));
        }

        //Show customer info
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
                    Ranktxt.Text = dgvCustomer.SelectedRows[0].Cells["RankName"].Value.ToString();
                }
                if (dgvCustomer.SelectedRows[0].Cells["TotalSpending"].Value != null)
                {
                    TotalSpendingtxt.Text = dgvCustomer.SelectedRows[0].Cells["TotalSpending"].Value.ToString();   
                }
                Productdgv.DataSource = BLLCustomerManagement.Instance.GetReceiptByCustomerTel(dgvCustomer.SelectedRows[0].Cells[0].Value.ToString());
            }

        }
        
        //Search customer
        private void Searchtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (string.IsNullOrWhiteSpace(Searchtxt.Text))
                {
                    dgvCustomer.DataSource = BLLCustomerManagement.Instance.GetAllCustomer_View();
                }
                else
                {
                    dgvCustomer.DataSource = BLLCustomerManagement.Instance.SearchCustomer(Searchtxt.Text);
                }
            }
        }

        private void Searchtxt_IconRightClick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Searchtxt.Text))
            {
                dgvCustomer.DataSource = BLLCustomerManagement.Instance.GetAllCustomer_View();
            }
            else
            {
                dgvCustomer.DataSource = BLLCustomerManagement.Instance.SearchCustomer(Searchtxt.Text);
            }
        }
        //Sort customer
        private void cbbSortOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            Searchtxt.Text = null;
            string sortCategory = cbbSortCategory.SelectedItem.ToString();
            bool sortOrder = (cbbSortOrder.SelectedItem.ToString() == "Ascending" ? true : false);
            List<Customer> customers = new List<Customer>();
            if (cbbFilterCategory.SelectedItem.ToString() == "All")
            {
                customers = BLLCustomerManagement.Instance.GetAllCustomerByRankID("All");
            }
            else
            {
                customers = BLLCustomerManagement.Instance.GetAllCustomerByRankID(((CBBItem)cbbFilterValue.SelectedItem).Value);
            }
            dgvCustomer.DataSource = BLLCustomerManagement.Instance.SortCustomer(customers,sortCategory,sortOrder);
        }

        //Filter customer
        private void cbbFilterCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbFilterValue.Items.Clear();
            string filterCategory = cbbFilterCategory.SelectedItem.ToString();
            switch (filterCategory)
            {
                case "All":
                    this.dgvCustomer.DataSource = BLLCustomerManagement.Instance.GetAllCustomer_View();
                    break;
                case "Rank":
                    cbbFilterValue.Items.AddRange(BLLCustomerManagement.Instance.getAllCBBRank().Distinct().ToArray());
                    break;
            }
        }
        private void cbbFilterValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            Searchtxt.Text = null;
            cbbSortCategory.SelectedItem = 0;
            cbbSortOrder.SelectedItem = 0;
            dgvCustomer.DataSource = BLLCustomerManagement.Instance.FilterCustomerByRank(((CBBItem)cbbFilterValue.SelectedItem).Value);
        }
    }
}
