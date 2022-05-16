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

namespace PBL3.View.AdminChildForms.ProductForms
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
            InitializeData();
        }

        public void InitializeData()
        {
            dgvProduct.DataSource = BLLProductManagement.Instance.GetAllProduct_View();
            cbbSortOrder.SelectedIndex = 0;
            cbbSortOrder.SelectedIndexChanged += new System.EventHandler(this.cbbSortOrder_SelectedIndexChanged);
            cbbSortCategory.SelectedIndex = 0;
            cbbSortCategory.SelectedIndexChanged += new System.EventHandler(this.cbbSortCategory_SelectedIndexChanged);
        }

        private void btnUpdatePrice_Click(object sender, EventArgs e)
        {
            UpdatePrice updatePrice = new UpdatePrice();
            updatePrice.myDelegate = new UpdatePrice.MyDelegate(InitializeData);
            updatePrice.Show();
        }

        private void tbSearch_IconRightClick(object sender, EventArgs e)
        {
            if(tbSearch.Text != "")
            {
                dgvProduct.DataSource = BLLProductManagement.Instance.SearchProduct(tbSearch.Text);
            }
        }

        private void cbbSortCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbSearch.Text = "";
            string sortCategory = cbbSortCategory.SelectedItem.ToString();
            bool sortOrder = (cbbSortOrder.SelectedItem.ToString() == "Ascending" ? true : false);
            dgvProduct.DataSource = BLLProductManagement.Instance.SortProduct(sortCategory, sortOrder);
        }

        private void cbbSortOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbSearch.Text = "";
            string sortCategory = cbbSortCategory.SelectedItem.ToString();
            bool sortOrder = (cbbSortOrder.SelectedItem.ToString() == "Ascending" ? true : false);
            dgvProduct.DataSource = BLLProductManagement.Instance.SortProduct(sortCategory, sortOrder);
        }

        private void btnShowHistory_Click(object sender, EventArgs e)
        {
            string productID = dgvProduct.SelectedRows[0].Cells["ProductID"].Value.ToString();
            ImportHistory importHistory = new ImportHistory(productID);
            importHistory.Show();
        }

        private void cbbFilterCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbFilterValue.Text = "";
            cbbFilterValue.Items.Clear();
            string filterCategory = cbbFilterCategory.SelectedItem.ToString();
            if(filterCategory == "Category")
            {
                foreach(string i in BLLProductManagement.Instance.GetAllProductCategory().Distinct())
                {
                    cbbFilterValue.Items.Add(i);
                }
            }
            if(filterCategory == "Status")
            {
                foreach (string i in BLLProductManagement.Instance.GetAllProductStatus().Distinct())
                {
                    cbbFilterValue.Items.Add(i);
                }
            }
        }

        private void cbbFilterValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvProduct.DataSource = BLLProductManagement.Instance.SearchProduct(cbbFilterValue.SelectedItem.ToString());
        }

    }
}
