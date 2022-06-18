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
        private Discount discount;
        //private List<Product_Discount_View> productlist = new List<Product_Discount_View>();
        private List<Product_Discount_View> productlist;
        public ApplyDiscountForm(Discount discount)
        {
            InitializeComponent();
            this.discount = discount;
            DiscountIDlb.Text = discount.DiscountID;
            Discountnamelb.Text = discount.DiscountName;
            productlist = new List<Product_Discount_View>();
            productlist = BLLDiscountManagement.Instance.GetAllProduct_Discount_View();
            dgvProduct.DataSource = productlist.ToList();
        }
        public void Reload()
        {
            dgvProduct.DataSource = productlist.ToList();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            Product_Discount_View obj = (Product_Discount_View)dgvProduct.CurrentRow.DataBoundItem;
            //System.Windows.Forms.MessageBox.Show(obj.ProductName);
            //obj.DiscountID = this.discount.DiscountID;
            //int index = dgvProduct.SelectedRows[0].Index;
            //dgvProduct.Rows[index].Selected = false;
            //dgvProduct.Rows[index].Selected = true;
            ProductNametxt.Text = dgvProduct.SelectedRows[0].Cells["ProductName"].Value.ToString();
            //productlist.Add(obj);
            BLLDiscountManagement.Instance.AddDiscount_ProductDiscountView(productlist,obj, this.discount.DiscountID);
            Reload();
        }

        private void ProductNametxt_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int count = BLLDiscountManagement.Instance.CountProductByDiscountID(productlist, this.discount.DiscountID);
            //System.Windows.Forms.MessageBox.Show(count.ToString());
            if (this.discount.DiscountType == "Combo")
            {
                if (count == this.discount.AmmountApply)
                {
                    BLLDiscountManagement.Instance.UpdateProductDiscountIDList(this.discount.DiscountID, productlist);
                    View.CustomMessageBox.MessageBox.Show("Discount applied Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //dgvProduct.DataSource = BLLDiscountManagement.Instance.GetAllProduct_Discount_View();
                    Reload();
                }
                else if (count < this.discount.AmmountApply)
                {
                    View.CustomMessageBox.MessageBox.Show("Not enough discounts applied", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    View.CustomMessageBox.MessageBox.Show("Too much discounts applied.\n Only " + this.discount.AmmountApply + " are allowed to be applied!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else if(this.discount.DiscountType=="Single")
            {
                if (count >=1)
                {
                    BLLDiscountManagement.Instance.UpdateProductDiscountIDList(this.discount.DiscountID, productlist);
                    View.CustomMessageBox.MessageBox.Show("Discount applied Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reload();
                }
                else if (count<1)
                {
                    View.CustomMessageBox.MessageBox.Show("Not enough discounts applied", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                dgvProduct.DataSource =BLLDiscountManagement.Instance.SearchProductDiscountView(tbSearch.Text);
            }
        }
        private void Removebtn_Click(object sender, EventArgs e)
        {
            List<Product> del = new List<Product>();
            if (dgvProduct.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow i in dgvProduct.SelectedRows)
                {
                    if (i.Cells["DiscountID"].Value != null)
                    {
                        if (i.Cells["DiscountID"].Value.ToString() == this.discount.DiscountID)
                            del.Add(QLNS.Instance.Products.Find(i.Cells[0].Value.ToString()));
                    }
                }
                BLLDiscountManagement.Instance.RemoveDiscountIDInProducts(del);
                BLLDiscountManagement.Instance.RemoveDiscount_ProductDiscountView(productlist, del);
                Reload();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProduct.SelectedRows.Count == 1)
            {
                ProductNametxt.Text = dgvProduct.SelectedRows[0].Cells["ProductName"].Value.ToString();
            }
        }
    }
}
