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
using PBL3.Model;
using PBL3.View.AdminChildForms;
using PBL3.DTO;

namespace PBL3.View.AdminChildForms.DiscountForms
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
            string idtemp = (QLNS.Instance.Discounts.Count() + 1).ToString();
            IDtxt.Text = "d" + idtemp;
            Typecbb.SelectedIndex = 1;
            Savebutton.Visible = false;
            ClearButton.Visible = false;
            IDtxt.ReadOnly = true;
            Nametxt.ReadOnly = true;
            AmountApplytxt.ReadOnly = true;
            DiscountApplytxt.ReadOnly = true;
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
        private void ApplyButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (BLLDiscountManagement.Instance.Check(IDtxt.Text) == true)
                {
                    Discount d = BLLDiscountManagement.Instance.GetDiscountByID(IDtxt.Text);
                    if (dgvFrom.Value<=DateTime.Now&&dgvTo.Value>=DateTime.Now)
                    {
                        View.CustomMessageBox.MessageBox.Show("Cannot apply products.\nThe discount is occurring now!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        ApplyDiscountForm form = new ApplyDiscountForm(d);
                        form.ShowDialog();
                    }        
                }
                else
                {
                    Discount discount = new Discount();
                    discount.DiscountID = IDtxt.Text;
                    discount.DiscountName = Nametxt.Text;
                    if (Typecbb.SelectedIndex == 1)
                    {
                        discount.AmmountApply = Convert.ToInt32(AmountApplytxt.Text);
                    }
                    discount.DiscountType = Typecbb.SelectedItem.ToString();
                    discount.StartingDate = dgvFrom.Value;
                    discount.ExpirationDate = dgvTo.Value;
                    discount.DiscountApply = Convert.ToDouble(DiscountApplytxt.Text);
                    BLLDiscountManagement.Instance.AddNewDiscount(discount);
                    dgvDiscount.DataSource = BLLDiscountManagement.Instance.GetAllDiscount_View();
                    ApplyDiscountForm form = new ApplyDiscountForm(BLLDiscountManagement.Instance.GetDiscountByDiscountID(IDtxt.Text));
                    form.ShowDialog();
                }
            }
            catch(FormatException ex)
            {
                View.CustomMessageBox.MessageBox.Show("Enter missing information \n or information is not in the right format ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch(NullReferenceException ex)
            {
                View.CustomMessageBox.MessageBox.Show("Enter missing information \n or information is not in the right format ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void ShowButton_Click(object sender, EventArgs e)
        {
            AppliedProductsForm form = new AppliedProductsForm(IDtxt.Text);
            form.ShowDialog();
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (BLLDiscountManagement.Instance.Check(IDtxt.Text))
                {
                    Discount discount = new Discount();
                    discount.DiscountID = IDtxt.Text;
                    discount.DiscountName = Nametxt.Text;
                    if (Typecbb.SelectedIndex == 1)
                    {
                        discount.AmmountApply = Convert.ToInt32(AmountApplytxt.Text);
                    }
                    discount.DiscountType = Typecbb.SelectedItem.ToString();
                    discount.StartingDate = dgvFrom.Value;
                    discount.ExpirationDate = dgvTo.Value;
                    discount.DiscountApply = Convert.ToDouble(DiscountApplytxt.Text);
                    BLLDiscountManagement.Instance.Edit(discount);
                    Savebutton.Visible = false;
                    ClearButton.Visible = false;
                    IDtxt.ReadOnly = true;
                    Nametxt.ReadOnly = true;
                    AmountApplytxt.ReadOnly = true;
                    DiscountApplytxt.ReadOnly = true;
                    dgvDiscount.DataSource = BLLDiscountManagement.Instance.GetAllDiscount_View();
                }
                else
                {
                    Discount discount = new Discount();
                    discount.DiscountID = IDtxt.Text;
                    discount.DiscountName = Nametxt.Text;
                    if (Typecbb.SelectedIndex == 1)
                    {
                        discount.AmmountApply = Convert.ToInt32(AmountApplytxt.Text);
                    }
                    discount.DiscountType = Typecbb.SelectedItem.ToString();
                    discount.StartingDate = dgvFrom.Value;
                    discount.ExpirationDate = dgvTo.Value;
                    discount.DiscountApply = Convert.ToDouble(DiscountApplytxt.Text);
                    BLLDiscountManagement.Instance.AddNewDiscount(discount);
                    Savebutton.Visible = false;
                    ClearButton.Visible = false;
                    IDtxt.ReadOnly = true;
                    Nametxt.ReadOnly = true;
                    AmountApplytxt.ReadOnly = true;
                    DiscountApplytxt.ReadOnly = true;
                    dgvDiscount.DataSource = BLLDiscountManagement.Instance.GetAllDiscount_View();
                }
            }
            catch
            {
                View.CustomMessageBox.MessageBox.Show("Enter missing information \n or information is not in the right format ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Typecbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Typecbb.SelectedIndex == 0)
            {
                AmountApplytxt.Text = "";
                AmountApplytxt.Enabled = false;
            }
            else if(Typecbb.SelectedIndex == 1)
            {
                AmountApplytxt.Text = "";
                AmountApplytxt.Enabled=true;
            }
        }

        private void dgvDiscount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDiscount.SelectedRows.Count == 1)
            {
                IDtxt.Text=dgvDiscount.SelectedRows[0].Cells["DiscountID"].Value.ToString();
                Nametxt.Text = dgvDiscount.SelectedRows[0].Cells["DiscountName"].Value.ToString();
                AmountApplytxt.Text = dgvDiscount.SelectedRows[0].Cells["AmmountApply"].Value.ToString();
                DiscountApplytxt.Text = dgvDiscount.SelectedRows[0].Cells["DiscountApply"].Value.ToString();
                dgvFrom.Value= Convert.ToDateTime(dgvDiscount.SelectedRows[0].Cells["StartingDate"].Value);
                dgvTo.Value = Convert.ToDateTime(dgvDiscount.SelectedRows[0].Cells["ExpirationDate"].Value);
                if (dgvDiscount.SelectedRows[0].Cells["DiscountType"].Value.ToString() == "Combo")
                {
                    Typecbb.SelectedIndex = 1;
                }
                else
                {
                    AmountApplytxt.Enabled = false;
                    Typecbb.SelectedIndex = 0;
                }
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Nametxt.Text = "";
            AmountApplytxt.Text = "";
            DiscountApplytxt.Text = "";
            dgvFrom.Value = DateTime.Now;
            dgvTo.Value = DateTime.Now;
            if (dgvDiscount.SelectedRows[0].Cells["DiscountType"].Value.ToString() == "Combo")
            {
                Typecbb.SelectedIndex = 1;
            }
            else
            {
                AmountApplytxt.Enabled = false;
                Typecbb.SelectedIndex = 0;
            }

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            List<string> del = new List<string>();
            if (dgvDiscount.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow i in dgvDiscount.SelectedRows)
                {
                    del.Add(i.Cells[0].Value.ToString());
                }
                BLLDiscountManagement.Instance.Delete(del);
                //cbLopSH.SelectedIndex = 0;
               dgvDiscount.DataSource = BLLDiscountManagement.Instance.GetAllDiscount_View();
            }
        }
        private void EditButton_Click(object sender, EventArgs e)
        {
            IDtxt.ReadOnly = false;
            Nametxt.ReadOnly = false;
            AmountApplytxt.ReadOnly = false;
            DiscountApplytxt.ReadOnly = false;
            if (dgvDiscount.SelectedRows.Count == 1)
            {
                IDtxt.Text = dgvDiscount.SelectedRows[0].Cells["DiscountID"].Value.ToString();
                Nametxt.Text = dgvDiscount.SelectedRows[0].Cells["DiscountName"].Value.ToString();
                Nametxt.Enabled = true;
                AmountApplytxt.Text = dgvDiscount.SelectedRows[0].Cells["AmmountApply"].Value.ToString();
                AmountApplytxt.Enabled=false;
                DiscountApplytxt.Text = dgvDiscount.SelectedRows[0].Cells["DiscountApply"].Value.ToString();
                dgvFrom.Value = Convert.ToDateTime(dgvDiscount.SelectedRows[0].Cells["StartingDate"].Value);
                dgvTo.Value = Convert.ToDateTime(dgvDiscount.SelectedRows[0].Cells["ExpirationDate"].Value);
                if (dgvDiscount.SelectedRows[0].Cells["DiscountType"].Value.ToString() == "Combo")
                {
                    Typecbb.SelectedIndex = 1;
                }
                else
                {
                    AmountApplytxt.Enabled = false;
                    Typecbb.SelectedIndex = 0;
                }
                Savebutton.Visible = true;
                ClearButton.Visible = true;
            }

        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            string idtemp = (QLNS.Instance.Discounts.Count() + 1).ToString();
            IDtxt.Text = "d" + idtemp;
            Nametxt.Text = "";
            AmountApplytxt.Text = "";
            DiscountApplytxt.Text = "";
            dgvFrom.Value = DateTime.Now;
            dgvTo.Value = DateTime.Now;
            IDtxt.ReadOnly = false;
            Nametxt.ReadOnly = false;
            AmountApplytxt.ReadOnly = false;
            DiscountApplytxt.ReadOnly = false;
            //if (dgvDiscount.SelectedRows[0].Cells["DiscountType"].Value.ToString() == "Combo")
            //{
            //    Typecbb.SelectedIndex = 1;
            //}
            //else
            //{
            //    AmountApplytxt.Enabled = false;
            //    Typecbb.SelectedIndex = 0;
            //}
            Savebutton.Visible = true;
           ClearButton.Visible = true;
        }
         private void tb_TextChanged(object sender, EventArgs e)
        {
            if (Nametxt.Text == ""|| DataCheck.IsString(Nametxt.Text) != true) Nametxt.IconRightSize = new System.Drawing.Size(7, 7);
            else Nametxt.IconRightSize = new System.Drawing.Size(0, 0);
            if (AmountApplytxt.Text == ""|| DataCheck.IsNumber(AmountApplytxt.Text)!=true) AmountApplytxt.IconRightSize = new System.Drawing.Size(7, 7);
            else AmountApplytxt.IconRightSize = new System.Drawing.Size(0, 0);
            if (DiscountApplytxt.Text == "" || DataCheck.IsNumber(DiscountApplytxt.Text) != true) DiscountApplytxt.IconRightSize = new System.Drawing.Size(7, 7);
            else DiscountApplytxt.IconRightSize = new System.Drawing.Size(0, 0);
        }

        private void cbbSortOrder_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
