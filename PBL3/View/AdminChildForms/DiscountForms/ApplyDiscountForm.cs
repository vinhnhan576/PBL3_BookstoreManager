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
        private List<Product_Discount_View> productlist;

        /// Initialize
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

        //Show selected product name
        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProduct.SelectedRows.Count == 1)
            {
                ProductNametxt.Text = dgvProduct.SelectedRows[0].Cells["ProductName"].Value.ToString();
            }
        }

        //Apply discount
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

        //Remove discount
        private void Removebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProduct.SelectedRows.Count > 0)
                {
                    List<Product> del = new List<Product>();
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
                else throw new Exception("Please choose at least 1 product");
            }
            catch (Exception ex)
            {
                CustomMessageBox.MessageBox.Show(ex.Message, "Error", MessageBoxIcon.Error);
            }
        }

        //OK
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                int count = BLLDiscountManagement.Instance.CountProductByDiscountID(productlist, this.discount.DiscountID);

                //COMBO DISCOUNT TYPE
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
                        throw new Exception("Not enough discounts applied");
                    else
                        throw new Exception("Too much discounts applied.\n Only " + this.discount.AmmountApply + " discounts are allowed to be applied!");
                }

                //SINGLE DISCOUNT TYPE
                else if (this.discount.DiscountType == "Single")
                {
                    if (count >= 1)
                    {
                        BLLDiscountManagement.Instance.UpdateProductDiscountIDList(this.discount.DiscountID, productlist);
                        View.CustomMessageBox.MessageBox.Show("Discount applied Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Reload();
                    }
                    else if (count < 1)
                        throw new Exception("Not enough discounts applied");
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        //Cancel
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Search product
        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                dgvProduct.DataSource = BLLDiscountManagement.Instance.SearchProductDiscountView(tbSearch.Text);
            }
        }

        //UNDONE: textchanged
        //Other components
        private void ProductNametxt_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
