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
    public partial class DiscountForm : Form
    {
        public DiscountForm()
        {
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData()
        {
            dgvDiscount.DataSource = BLLDiscountManagement.Instance.GetAllDiscount_View();
            cbbSortOrder.SelectedIndex = 0;
            cbbSortOrder.SelectedIndexChanged += new System.EventHandler(this.cbbSortOrder_SelectedIndexChanged);
            cbbSortCategory.SelectedIndex = 0;
            cbbSortCategory.SelectedIndexChanged += new System.EventHandler(this.cbbSortCategory_SelectedIndexChanged);
        }

        private void tbSearch_IconRightClick(object sender, EventArgs e)
        {
            string searchValue = tbSearch.Text;
            dgvDiscount.DataSource = BLLDiscountManagement.Instance.SearchDiscount(searchValue);
        }

        private void cbbSortCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbSearch.Text = "";
            string sortCategory = cbbSortCategory.SelectedItem.ToString();
            bool sortOrder = (cbbSortOrder.SelectedItem.ToString() == "Ascending" ? true : false);
            dgvDiscount.DataSource = BLLDiscountManagement.Instance.SortDiscount(sortCategory, sortOrder);
        }

        private void cbbSortOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbSearch.Text = "";
            string sortCategory = cbbSortCategory.SelectedItem.ToString();
            bool sortOrder = (cbbSortOrder.SelectedItem.ToString() == "Ascending" ? true : false);
            dgvDiscount.DataSource = BLLDiscountManagement.Instance.SortDiscount(sortCategory, sortOrder);
        }

        private void cbbFilterCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbFilterValue.Text = "";
            cbbFilterValue.Items.Clear();
            string filterCategory = cbbFilterCategory.SelectedItem.ToString();
            if (filterCategory == "DiscountType")
            {
                foreach (string i in BLLDiscountManagement.Instance.GetAllDiscountType().Distinct())
                {
                    cbbFilterValue.Items.Add(i);
                }
            }
        }

        private void cbbFilterValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvDiscount.DataSource = BLLDiscountManagement.Instance.FilterDiscount(cbbFilterValue.SelectedItem.ToString());
        }
    }
}
