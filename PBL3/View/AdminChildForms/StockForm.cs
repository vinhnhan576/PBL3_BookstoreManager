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
    public partial class StockForm : Form
    {
        public StockForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            dgvStock.DataSource = BLLRestockManagement.Instance.GetAllRestock_View();
            cbbSortOrder.SelectedIndex = 0;
            cbbSortOrder.SelectedIndexChanged += new System.EventHandler(this.cbbSortOrder_SelectedIndexChanged);
            cbbSortCategory.SelectedIndex = 0;
            cbbSortCategory.SelectedIndexChanged += new System.EventHandler(this.cbbSortCategory_SelectedIndexChanged);
            dgvStock_CellClick(this, new DataGridViewCellEventArgs(0, 0));
        }

        //Show stock info
        private void dgvStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvStock.SelectedRows.Count == 1)
            {
                tbID.Text = dgvStock.SelectedRows[0].Cells[0].Value.ToString();
                tbStockkeeperID.Text = dgvStock.SelectedRows[0].Cells[1].Value.ToString();
                dtpImport.Value = Convert.ToDateTime(dgvStock.SelectedRows[0].Cells[2].Value);
                tbTotal.Text = dgvStock.SelectedRows[0].Cells[3].Value.ToString();
                dgvProduct.DataSource = BLLRestockManagement.Instance.GetProductInRestockByRestockID(tbID.Text);
            }
        }

        //Search stock
        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (string.IsNullOrWhiteSpace(tbSearch.Text))
                {
                    dgvStock.DataSource = BLLRestockManagement.Instance.GetAllRestock_View();
                }
                else
                {
                    dgvStock.DataSource = BLLRestockManagement.Instance.SearchRestock(tbSearch.Text);
                }
            }
        }

        private void tbSearch_IconRightClick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbSearch.Text))
            {
                dgvStock.DataSource = BLLRestockManagement.Instance.GetAllRestock_View();
            }
            else
            {
                dgvStock.DataSource = BLLRestockManagement.Instance.SearchRestock(tbSearch.Text);
            }
        }

        //Sort stock
        private void cbbSortCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbSearch.Text = "";
            string sortCategory = cbbSortCategory.SelectedItem.ToString();
            bool sortOrder = (cbbSortOrder.SelectedItem.ToString() == "Ascending" ? true : false);
            dgvStock.DataSource = BLLRestockManagement.Instance.SortRestock(sortCategory, sortOrder);
        }

        private void cbbSortOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbSearch.Text = "";
            string sortCategory = cbbSortCategory.SelectedItem.ToString();
            bool sortOrder = (cbbSortOrder.SelectedItem.ToString() == "Ascending" ? true : false);
            dgvStock.DataSource = BLLRestockManagement.Instance.SortRestock(sortCategory, sortOrder);
        }


        //Filter date
        private void tbYear_IconRightClick(object sender, EventArgs e)
        {
            try
            {
                if (!isTimeInputValid()) throw new Exception("Please re-enter the date");
                string day = tbDay.Text;
                string month = tbMonth.Text;
                string year = tbYear.Text;
                dgvStock.DataSource = BLLRestockManagement.Instance.FilterRestockByDate(day, month, year);
            }
            catch (Exception ex)
            {
                CustomMessageBox.MessageBox.Show(ex.Message, "Invalid time input", MessageBoxIcon.Error);
                tbDay.Text = null;
                tbMonth.Text = null;
                tbYear.Text = null;
            }
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
    }
}
