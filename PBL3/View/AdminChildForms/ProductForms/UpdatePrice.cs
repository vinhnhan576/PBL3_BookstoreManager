using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.BLL;
using PBL3.DTO;

namespace PBL3.View.AdminChildForms.ProductForms
{
    public partial class UpdatePrice : Form
    {
        public delegate void MyDelegate();
        public MyDelegate myDelegate { get; set; }

        private List<string> IDList = new List<string>();
        private List<double> newPriceList = new List<double>();


        public UpdatePrice()
        {
            InitializeComponent();
            InitializeProductPrice();
        }

        public void InitializeProductPrice()
        {
            dgvProduct.DataSource = BLLProductManagement.Instance.GetAllProduct_Price_View();
            dgvProduct.Columns[0].HeaderText = "ID";
            dgvProduct.Columns[1].HeaderText = "Product name";
            dgvProduct.Columns[2].HeaderText = "Selling price";
            dgvProduct.AutoResizeColumns();
            dgvProduct.ClearSelection();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            BLLProductManagement.Instance.UpdatePrice(IDList, newPriceList);
            myDelegate();
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Product_Price_View obj = (Product_Price_View)dgvProduct.CurrentRow.DataBoundItem;
                obj.SellingPrice = Convert.ToDouble(tbNewPrice.Text);
                int index = dgvProduct.SelectedRows[0].Index;
                dgvProduct.Rows[index].Selected = false;
                dgvProduct.Rows[index].Selected = true;
                IDList.Add(dgvProduct.SelectedRows[0].Cells["ProductID"].Value.ToString());
                newPriceList.Add(Convert.ToDouble(tbNewPrice.Text));
                tbNewPrice.Text = null;
            }
            catch (Exception)
            {
                CustomMessageBox.MessageBox.Show("Please re-enter the price", "Invalid input", MessageBoxIcon.Error);
                tbNewPrice.Text = null;
            }
        }

        private void tbSearch_IconRightClick(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tbSearch.Text))
            {
                dgvProduct.DataSource = BLLProductManagement.Instance.GetAllProduct_Price_View();
            }
            else
            {
                dgvProduct.DataSource = BLLProductManagement.Instance.SearchProductPriceView(tbSearch.Text);
            }
        }

        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (string.IsNullOrWhiteSpace(tbSearch.Text))
                {
                    dgvProduct.DataSource = BLLProductManagement.Instance.GetAllProduct_Price_View();
                }
                else
                {
                    dgvProduct.DataSource = BLLProductManagement.Instance.SearchProductPriceView(tbSearch.Text);
                }
            }
        }
    }

}
