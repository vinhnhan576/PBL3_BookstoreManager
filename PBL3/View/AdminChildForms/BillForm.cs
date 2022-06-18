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
using PBL3.Model;

namespace PBL3.View.AdminChildForms
{
    public partial class BillForm : Form
    {
        public BillForm(Account acc)
        {
            InitializeComponent();
            Receiptdgv.DataSource = BLLReceiptManagement.Instance.GetAllReceipt_View();

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
                Receiptdgv.DataSource = BLLReceiptManagement.Instance.GetAllReceipt_View();
            }
            else
            {
                Receiptdgv.DataSource = BLLReceiptManagement.Instance.SearchReceipt(Searchtxt.Text);
            }
        }

        //Fitler receipt
        private void cbbFilterCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbFilterValue.Text = null;
            cbbFilterValue.Items.Clear();
            string filterCategory = cbbFilterCategory.SelectedItem.ToString();
            if (filterCategory == "Status")
            {
                foreach (string i in BLLProductManagement.Instance.GetAllProductStatus().Distinct())
                {
                    cbbFilterValue.Items.Add(i);
                }
            }
        }

        private void cbbFilterValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            Receiptdgv.DataSource = BLLReceiptManagement.Instance.SearchReceipt(cbbFilterValue.SelectedItem.ToString());
        }

        //Sort receipt
        private void cbbSortOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            Searchtxt.Text = "";
            string sortCategory = cbbSortCategory.SelectedItem.ToString();
            bool sortOrder = (cbbSortOrder.SelectedItem.ToString() == "Ascending" ? true : false);
            Receiptdgv.DataSource = BLLReceiptManagement.Instance.SortReceipt(sortCategory, sortOrder);
        }

    }
}