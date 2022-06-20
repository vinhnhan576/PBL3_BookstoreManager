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
using PBL3.Model;

namespace PBL3.View.AdminChildForms
{
    public partial class BillForm : Form
    {
        public BillForm(Account acc)
        {
            InitializeComponent();
            Receiptdgv.DataSource = BLLReceiptManagement.Instance.GetAllReceipt_View();
            IDtxt.ReadOnly = true;
            customertxt.ReadOnly = true;
            salesmannametxt.ReadOnly = true;
            statustxt.ReadOnly = true;
            totaltxt.ReadOnly = true;

        }

        //View receipt info
        private void Receiptdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Receiptdgv.SelectedRows.Count == 1)
            {
                IDtxt.Text = Receiptdgv.SelectedRows[0].Cells[0].Value.ToString();
                salesmannametxt.Text = Receiptdgv.SelectedRows[0].Cells[1].Value.ToString();
                DateTimePicker.Value = Convert.ToDateTime(Receiptdgv.SelectedRows[0].Cells[2].Value);
                totaltxt.Text = Receiptdgv.SelectedRows[0].Cells[3].Value.ToString();
                Productdgv.DataSource = BLLReceiptManagement.Instance.GetProductInReceiptByID(IDtxt.Text.ToString());
            }
        }

        //Search receipt
        private void Searchtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if(Searchtxt.Text == null)
                {
                    Receiptdgv.DataSource = BLLReceiptManagement.Instance.GetAllReceipt_View();
                }
                else
                {
                    Receiptdgv.DataSource = BLLReceiptManagement.Instance.SearchReceipt(Searchtxt.Text);
                }
            }
        }

        private void Searchtxt_IconRightClick(object sender, EventArgs e)
        {
            if (Searchtxt.Text == null)
            {
                IDtxt.Text = Receiptdgv.SelectedRows[0].Cells[0].Value.ToString();
                salesmannametxt.Text = Receiptdgv.SelectedRows[0].Cells[1].Value.ToString();
                if(Receiptdgv.SelectedRows[0].Cells[2].Value!=null)
                customertxt.Text = Receiptdgv.SelectedRows[0].Cells[2].Value.ToString();
                else
                {
                    customertxt.Text = "";
                }
                DateTimePicker.Value = Convert.ToDateTime(Receiptdgv.SelectedRows[0].Cells[3].Value);
                totaltxt.Text = Receiptdgv.SelectedRows[0].Cells[4].Value.ToString();
                if ((bool)Receiptdgv.SelectedRows[0].Cells[5].Value)
                {
                    statustxt.Text = "Valid";
                }
                else
                {
                    statustxt.Text = "Invalid";
                }
                Productdgv.DataSource = BLLReceiptManagement.Instance.GetProductInReceiptByID(IDtxt.Text.ToString());
            }
        }
        private void tbYear_IconRightClick(object sender, EventArgs e)
        {  
            Receiptdgv.DataSource = BLLReceiptManagement.Instance.FilterReceiptByDate(tbMonth.Text, tbDay.Text, tbYear.Text);
        }

        //Fitler receipt
        private void cbbFilterCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbFilterValue.Text = null;
            cbbFilterValue.Items.Clear();
            string filterCategory = cbbFilterCategory.SelectedItem.ToString();
            if (filterCategory == "Status")
            {
                foreach (string i in BLLReceiptManagement.Instance.GetAllReceiptStatus().Distinct())
                {
                    cbbFilterValue.Items.Add(i);
                }
            }
            if (filterCategory == "Salesman Name")
            {
                foreach (string i in BLLReceiptManagement.Instance.GetAllReceiptSalesman().Distinct())
                {
                    cbbFilterValue.Items.Add(i);
                }
            }
        }

        private void cbbFilterValue_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Receiptdgv.DataSource = BLLReceiptManagement.Instance.FilterReceipt(cbbFilterValue.SelectedItem.ToString());
        }

        //Sort receipt
        private void cbbSortOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sortCategory = cbbSortCategory.SelectedItem.ToString();
            bool sortOrder = (cbbSortOrder.SelectedItem.ToString() == "Ascending" ? true : false);
            Receiptdgv.DataSource = BLLReceiptManagement.Instance.SortReceipt(sortCategory, sortOrder);
        }

    }
}