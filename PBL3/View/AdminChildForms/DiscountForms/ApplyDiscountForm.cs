using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.Model;
using PBL3.DTO;
using PBL3.BLL;
using PBL3.View.CustomMessageBox;

namespace PBL3.View.AdminChildForms.DiscountForms
{
    public partial class ApplyDiscountForm : Form
    {
        private string id;
        private List<Product_Discount_View> productlist=new List<Product_Discount_View>();
        public ApplyDiscountForm(string id)
        {
            InitializeComponent();
            this.id = id;
            this.dgvProduct.DataSource = BLLDiscountManagement.Instance.GetAllProduct_Discount_View();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            Product_Discount_View obj = (Product_Discount_View)dgvProduct.CurrentRow.DataBoundItem;
            obj.DiscountID = this.id;
            int index = dgvProduct.SelectedRows[0].Index;
            dgvProduct.Rows[index].Selected = false;
            dgvProduct.Rows[index].Selected = true;
            ProductNametxt.Text = dgvProduct.SelectedRows[0].Cells["ProductName"].Value.ToString();
            productlist.Add(obj);
        }

        private void ProductNametxt_TextChanged(object sender, EventArgs e)
        {
            if (dgvProduct.SelectedRows.Count == 1)
            {
                ProductNametxt.Text = dgvProduct.SelectedRows[0].Cells["ProductName"].Value.ToString();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            BLLDiscountManagement.Instance.UpdateProductDiscountIDList(this.id,productlist);
            View.CustomMessageBox.MessageBox.Show("Discount applied Successfully","",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                
            }
        }
    }
}
