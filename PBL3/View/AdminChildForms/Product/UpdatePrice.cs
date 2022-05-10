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

namespace PBL3.View.AdminChildForms.Product
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
            if(tbNewPrice.Text != "")
            {
                Product_Price_View obj = (Product_Price_View)dgvProduct.CurrentRow.DataBoundItem;
                obj.SellingPrice = Convert.ToDouble(tbNewPrice.Text);
                int index = dgvProduct.SelectedRows[0].Index;
                dgvProduct.Rows[index].Selected = false;
                dgvProduct.Rows[index].Selected = true;
                IDList.Add(dgvProduct.SelectedRows[0].Cells["ProductID"].Value.ToString());
                newPriceList.Add(Convert.ToDouble(tbNewPrice.Text));
                tbNewPrice.Text = "";
            }
        }

        private void tbSearch_IconRightClick(object sender, EventArgs e)
        {
            if(tbSearch.Text != "")
            {
                dgvProduct.DataSource = BLLProductManagement.Instance.SearchProduct(tbSearch.Text);
            }
        }
    }

}
