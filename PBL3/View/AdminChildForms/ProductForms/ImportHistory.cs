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
        public ImportHistory(string productID)
        {
            InitializeComponent();
            InitializeData(productID);
        }

        public void InitializeData(string productID)
        {
            dgvProduct.DataSource = BLLStoreImportManagement.Instance.GetStoreImport_ViewByProductID(productID);
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
            dgvProduct.DataSource = BLLStoreImportManagement.Instance.SortStoreImport(sortCategory, sortOrder);
        }

        private void cbbSortOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sortCategory = cbbSortCategory.SelectedItem.ToString();
            bool sortOrder = cbbSortOrder.SelectedItem.ToString() == "Ascending" ? true : false;
            dgvProduct.DataSource = BLLStoreImportManagement.Instance.SortStoreImport(sortCategory, sortOrder);
        }

        private void tbYear_IconRightClick(object sender, EventArgs e)
        {
            string day = tbDay.Text;
            string month = tbMonth.Text;
            string year = tbYear.Text;
            dgvProduct.DataSource = BLLStoreImportManagement.Instance.FilterStoreImportByDate(day, month, year);
        }

        private void tbProduct_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
