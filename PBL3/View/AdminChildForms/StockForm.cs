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
        }

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
        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tbSearch != null)
            {
                dgvStock.DataSource = BLLRestockManagement.Instance.SearchRestock(tbSearch.Text);

            }
        }

        private void tbYear_IconLeftClick(object sender, EventArgs e)
        {
            string day = tbDay.Text;
            string month = tbMonth.Text;
            string year = tbYear.Text;
            dgvStock.DataSource = BLLRestockManagement.Instance.FilterRestockByDate(day, month, year);
        }

        private void tbYear_IconRightClick(object sender, EventArgs e)
        {
            string day = tbDay.Text;
            string month = tbMonth.Text;
            string year = tbYear.Text;
            dgvStock.DataSource = BLLRestockManagement.Instance.FilterRestockByDate(day, month, year);
        }
    }
}
