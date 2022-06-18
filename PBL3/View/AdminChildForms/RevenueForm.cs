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
    public partial class RevenueForm : Form
    {
        public RevenueForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            dgvRevenue.DataSource = BLLRevenueManagement.Instance.GetAllRevenue_View();
            cbbSortOrder.SelectedIndex = 0;
            cbbSortOrder.SelectedIndexChanged += new System.EventHandler(this.cbbSortOrder_SelectedIndexChanged);
            cbbSortCategory.SelectedIndex = 0;
            cbbSortCategory.SelectedIndexChanged += new System.EventHandler(this.cbbSortCategory_SelectedIndexChanged);
        }

        private void cbbSortCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sortCategory = cbbSortCategory.SelectedItem.ToString();
            bool sortOrder = (cbbSortOrder.SelectedItem.ToString() == "Ascending" ? true : false);
            dgvRevenue.DataSource = BLLRevenueManagement.Instance.SortRevenue(sortCategory, sortOrder);
        }

        private void cbbSortOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sortCategory = cbbSortCategory.SelectedItem.ToString();
            bool sortOrder = (cbbSortOrder.SelectedItem.ToString() == "Ascending" ? true : false);
            dgvRevenue.DataSource = BLLRevenueManagement.Instance.SortRevenue(sortCategory, sortOrder);
        }

        private void tbYear_IconRightClick(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(tbDay.Text) < 1 || Convert.ToInt32(tbDay.Text) > 31
                    || Convert.ToInt32(tbMonth.Text) < 1 || Convert.ToInt32(tbMonth.Text) > 12
                    || Convert.ToInt32(tbYear.Text) < 1 || Convert.ToInt32(tbYear.Text) > DateTime.Now.Year) throw new Exception();
                string day = tbDay.Text;
                string month = tbMonth.Text;
                string year = tbYear.Text;
                dgvRevenue.DataSource = BLLRevenueManagement.Instance.FilterRevenueByDate(day, month, year);
            }
            catch (Exception)
            {
                CustomMessageBox.MessageBox.Show("Please re-enter the date", "Invalid time input", MessageBoxIcon.Error);
                tbDay.Text = null;
                tbMonth.Text = null;
                tbYear.Text = null;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvRevenue.DataSource = BLLRevenueManagement.Instance.GetAllRevenue_View();
        }
    }
}
