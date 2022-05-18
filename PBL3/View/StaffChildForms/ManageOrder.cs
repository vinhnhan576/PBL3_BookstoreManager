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

namespace PBL3.View.StaffChildForms
{
    public partial class ManageOrder : Form
    {
        public ManageOrder()
        {
            InitializeComponent();
            Receiptdgv.DataSource = BLLReceiptManagement.Instance.GetAllReceipt_View();

        }

        private void Searchtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Receiptdgv.DataSource = BLLReceiptManagement.Instance.SearchReceipt(Searchtxt.Text);
            }

        }

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

        private void cbbFilterCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbFilterValue.Text = "";
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

        private void cbbSortOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            Searchtxt.Text = "";
            string sortCategory = cbbSortCategory.SelectedItem.ToString();
            bool sortOrder = (cbbSortOrder.SelectedItem.ToString() == "Ascending" ? true : false);
            Receiptdgv.DataSource = BLLReceiptManagement.Instance.SortReceipt(sortCategory, sortOrder);
        }


    }
}
