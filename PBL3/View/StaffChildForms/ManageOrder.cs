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

namespace PBL3.View.StaffChildForms
{
    public partial class ManageOrder : Form
    {
        public ManageOrder()
        {
            InitializeComponent();
            Receiptdgv.DataSource = BLLReceiptManagement.Instance.GetAllReceipt_View();
            IDtxt.ReadOnly = true;
            customertxt.ReadOnly = true;
            salesmannametxt.ReadOnly = true;
            statustxt.ReadOnly = true;
            totaltxt.ReadOnly = true;
            cbbFilterCategory.SelectedIndex=0;
            Receiptdgv_CellClick(this, new DataGridViewCellEventArgs(0, 0));
        }
        private void Receiptdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Receiptdgv.SelectedRows.Count == 1)
            {
                IDtxt.Text = Receiptdgv.SelectedRows[0].Cells[0].Value.ToString();
                salesmannametxt.Text = Receiptdgv.SelectedRows[0].Cells[1].Value.ToString();
                if (Receiptdgv.SelectedRows[0].Cells[2].Value != null)
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
        private void statusbtn_Click(object sender, EventArgs e)
        {
            List<string> del = new List<string>();
            DialogResult result = CustomMessageBox.MessageBox.Show("Are you sure you want to delete this account(s)?", "Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (Receiptdgv.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow i in Receiptdgv.SelectedRows)
                    {
                        del.Add(i.Cells[0].Value.ToString());
                    }
                    BLLReceiptManagement.Instance.ChangeStatusReceipt(del);
                    //cbLopSH.SelectedIndex = 0;
                    Receiptdgv.DataSource = BLLReceiptManagement.Instance.GetAllReceipt_View();
                }
            }
        }
        private void cbbSortOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sortCategory = cbbSortCategory.SelectedItem.ToString();
            bool sortOrder = (cbbSortOrder.SelectedItem.ToString() == "Ascending" ? true : false);
            if (cbbFilterCategory.SelectedItem.ToString() == "All")
            {
                Receiptdgv.DataSource = BLLReceiptManagement.Instance.SortReceipt(BLLReceiptManagement.Instance.FilterReceipt("All"), sortCategory, sortOrder);
            }
            else
            {
                string filterValue = cbbFilterValue.SelectedItem.ToString();
                Receiptdgv.DataSource = BLLReceiptManagement.Instance.SortReceipt(BLLReceiptManagement.Instance.FilterReceipt(filterValue), sortCategory, sortOrder);
            }
            
        }
        private void cbbFilterCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbFilterValue.Text = "";
            cbbFilterValue.Items.Clear();
            string filterCategory = cbbFilterCategory.SelectedItem.ToString();
            if (filterCategory == "All")
            {
                Receiptdgv.DataSource = BLLReceiptManagement.Instance.GetAllReceipt_View();
            }
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

        private void cbbFilterValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            Receiptdgv.DataSource = BLLReceiptManagement.Instance.FilterReceipt(cbbFilterValue.SelectedItem.ToString());
        }
        private bool isTimeInputValid()
        {
            if (!string.IsNullOrWhiteSpace(tbDay.Text))
            {
                if (Convert.ToInt32(tbDay.Text) > 0 && Convert.ToInt32(tbDay.Text) <= 31)
                    return true;
                else return false;
            }
            if (!string.IsNullOrWhiteSpace(tbMonth.Text))
            {
                if (Convert.ToInt32(tbMonth.Text) > 0 && Convert.ToInt32(tbMonth.Text) <= 12)
                    return true;
                else return false;
            }
            if (!string.IsNullOrWhiteSpace(tbYear.Text))
            {
                if (Convert.ToInt32(tbYear.Text) > 0 && Convert.ToInt32(tbYear.Text) <= DateTime.Now.Year)
                    return true;
                else return false;
            }
            return true;
        }

        private void tbYear_IconRightClick_1(object sender, EventArgs e)
        {
            try
            {
                if (!isTimeInputValid()) throw new Exception("Please re-enter the date");
                string day = tbDay.Text;
                string month = tbMonth.Text;
                string year = tbYear.Text;
                Receiptdgv.DataSource = BLLReceiptManagement.Instance.FilterReceiptByDate(tbDay.Text, tbMonth.Text, tbYear.Text);
            }
            catch (Exception ex)
            {
                CustomMessageBox.MessageBox.Show(ex.Message, "Invalid time input", MessageBoxIcon.Error);
                tbDay.Text = null;
                tbMonth.Text = null;
                tbYear.Text = null;
            }
        }
    }
}