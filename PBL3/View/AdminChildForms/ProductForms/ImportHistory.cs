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

namespace PBL3.View.AdminChildForms.ProductForms
{
    public partial class ImportHistory : Form
    {
        string productID;
        public ImportHistory(string productID)
        {
            InitializeComponent();
            this.productID = productID;
            InitializeData();
        }

        public void InitializeData()
        {
            dgvProduct.DataSource = BLLStoreImportManagement.Instance.GetStoreImportDetail_ViewByProductID(productID);
            dgvProduct.Columns[0].HeaderText = "Import date";
            dgvProduct.Columns[1].HeaderText = "Import quantity";
            dgvProduct.Columns[2].HeaderText = "Store quantity";
            dgvProduct.Columns[3].HeaderText = "Stockkeeper";
            dgvProduct.AutoResizeColumns();
            tbProduct.Text = BLLProductManagement.Instance.GetProductByID(productID).ProductName;
            cbbSortCategory.SelectedIndex = 0;
            cbbSortCategory.SelectedIndexChanged += new System.EventHandler(this.cbbSortCategory_SelectedIndexChanged);
            cbbSortOrder.SelectedIndex = 0;
            cbbSortOrder.SelectedIndexChanged += new System.EventHandler(this.cbbSortOrder_SelectedIndexChanged);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbSortCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sortCategory = cbbSortCategory.SelectedItem.ToString();
            bool sortOrder = (cbbSortOrder.SelectedItem.ToString() == "Ascending" ? true : false);
            dgvProduct.DataSource = BLLStoreImportManagement.Instance.SortStoreImportDetail(productID, sortCategory, sortOrder);
        }

        private void cbbSortOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sortCategory = cbbSortCategory.SelectedItem.ToString();
            bool sortOrder = cbbSortOrder.SelectedItem.ToString() == "Ascending" ? true : false;
            dgvProduct.DataSource = BLLStoreImportManagement.Instance.SortStoreImportDetail(productID, sortCategory, sortOrder);
        }

        private void tbYear_IconRightClick(object sender, EventArgs e)
        {
            try
            {
                if (!isTimeInputValid()) throw new Exception();
                string day = tbDay.Text;
                string month = tbMonth.Text;
                string year = tbYear.Text;
                dgvProduct.DataSource = BLLStoreImportManagement.Instance.FilterStoreImportDetailByDate(day, month, year);
            }
            catch (Exception)
            {
                CustomMessageBox.MessageBox.Show("Please re-enter the date", "Invalid time input", MessageBoxIcon.Error);
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
            if(!string.IsNullOrWhiteSpace(tbMonth.Text))
            {
                if (Convert.ToInt32(tbMonth.Text) > 0 && Convert.ToInt32(tbMonth.Text) <= 12)
                    return true;
                else return false;
            }
            if(!string.IsNullOrWhiteSpace(tbYear.Text))
            {
                if (Convert.ToInt32(tbYear.Text) > 0 && Convert.ToInt32(tbYear.Text) <= DateTime.Now.Year)
                    return true;
                else return false;
            }
            return true;
        }
    }
}
