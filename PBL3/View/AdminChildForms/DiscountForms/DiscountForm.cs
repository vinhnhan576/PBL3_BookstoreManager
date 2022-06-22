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
            InitializeGUI();
        }


        /// <summary>
        /// Initialize
        /// </summary>
        private void InitializeGUI()
        {
            dgvDiscount.DataSource = BLLDiscountManagement.Instance.GetAllDiscount_View();
            cbbSortOrder.SelectedIndex = 0;
            cbbSortOrder.SelectedIndexChanged += new System.EventHandler(this.cbbSortOrder_SelectedIndexChanged);
            cbbSortCategory.SelectedIndex = 0;
            cbbFilterCategory.SelectedIndex = 0;
            //cbbSortCategory.SelectedIndexChanged += new System.EventHandler(this.cbbSortCategory_SelectedIndexChanged);
            IDtxt.Text = "d" + BLLDiscountManagement.Instance.GenerateID().ToString();
            Typecbb.SelectedIndex = 1;
            Savebutton.Visible = false;
            ClearButton.Visible = false;
            IDtxt.ReadOnly = true;
            Nametxt.ReadOnly = true;
            AmountApplytxt.ReadOnly = true;
            DiscountApplytxt.ReadOnly = true;
            startTimer(this, new EventArgs());
        }


        /// <summary>
        /// SEARCH SORT FILTER
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        // Search discount
        private void tbSearch_IconRightClick(object sender, EventArgs e)
        {
            string searchValue = tbSearch.Text;
            if(string.IsNullOrWhiteSpace(searchValue))
                dgvDiscount.DataSource = BLLDiscountManagement.Instance.GetAllDiscount_View();
            else
                dgvDiscount.DataSource = BLLDiscountManagement.Instance.SearchDiscount(searchValue);
        }
        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                string searchValue = tbSearch.Text;
                if (string.IsNullOrWhiteSpace(searchValue))
                    dgvDiscount.DataSource = BLLDiscountManagement.Instance.GetAllDiscount_View();
                else
                    dgvDiscount.DataSource = BLLDiscountManagement.Instance.SearchDiscount(searchValue);
            }
        }

        // Sort discount
        private void cbbSortOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sortCategory = cbbSortCategory.SelectedItem.ToString();
            bool sortOrder = (cbbSortOrder.SelectedItem.ToString() == "Ascending" ? true : false);
            if (cbbFilterCategory.SelectedItem.ToString() == "All")
            {
                dgvDiscount.DataSource = BLLDiscountManagement.Instance.SortDiscount(BLLDiscountManagement.Instance.GetAllDiscountByDiscountType("All"), sortCategory, sortOrder);
            }
            else
            {
                string filterValue = cbbFilterValue.SelectedItem.ToString();
                dgvDiscount.DataSource = BLLDiscountManagement.Instance.SortDiscount(BLLDiscountManagement.Instance.GetAllDiscountByDiscountType(filterValue), sortCategory, sortOrder);
            }
        }

        //Filter discount
        private void cbbFilterCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbFilterValue.Text = "";
            cbbFilterValue.Items.Clear();
            string filterCategory = cbbFilterCategory.SelectedItem.ToString();
            if (filterCategory == "All")
            {
                dgvDiscount.DataSource = BLLDiscountManagement.Instance.GetAllDiscount_View();
            }
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


        /// <summary>
        /// CRUD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        // Show discount info
        private void dgvDiscount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDiscount.SelectedRows.Count == 1)
            {
                IDtxt.Text = dgvDiscount.SelectedRows[0].Cells["DiscountID"].Value.ToString();
                Nametxt.Text = dgvDiscount.SelectedRows[0].Cells["DiscountName"].Value.ToString();
                AmountApplytxt.Text = dgvDiscount.SelectedRows[0].Cells["AmmountApply"].Value.ToString();
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
            }
        }

        // Add discount
        private void Addbutton_Click(object sender, EventArgs e)
        {
            string idtemp = (QLNS.Instance.Discounts.Count() + 1).ToString();
            IDtxt.Text = "d" + idtemp;
            Nametxt.Text = "";
            AmountApplytxt.Text = "";
            DiscountApplytxt.Text = "";
            dgvFrom.Value = DateTime.Now;
            dgvTo.Value = DateTime.Now;
            //if (dgvDiscount.SelectedRows[0].Cells["DiscountType"].Value.ToString() == "Combo")
            //{
            //    Typecbb.SelectedIndex = 1;
            //}
            //else
            //{
            //    AmountApplytxt.Enabled = false;
            //    Typecbb.SelectedIndex = 0;
            //}
            IDtxt.ReadOnly = true;
            Nametxt.ReadOnly = false;
            AmountApplytxt.ReadOnly = false;
            DiscountApplytxt.ReadOnly = false;
            Savebutton.Visible = true;
            ClearButton.Visible = true;
        }

        //Edit discount
        private void EditButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvDiscount.SelectedRows.Count == 1)
                {
                    IDtxt.Text = dgvDiscount.SelectedRows[0].Cells["DiscountID"].Value.ToString();
                    Nametxt.Text = dgvDiscount.SelectedRows[0].Cells["DiscountName"].Value.ToString();
                    Nametxt.Enabled = true;
                    AmountApplytxt.Text = dgvDiscount.SelectedRows[0].Cells["AmmountApply"].Value.ToString();
                    AmountApplytxt.Enabled = false;
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
                }
                else throw new Exception("Please choose only 1 discount to edit");
                Savebutton.Visible = true;
                ClearButton.Visible = true;
                Nametxt.ReadOnly = false;
                DiscountApplytxt.ReadOnly = false;
            }
            catch (Exception ex)
            {
                CustomMessageBox.MessageBox.Show(ex.Message, "Error", MessageBoxIcon.Error);
            }
        }

        //Delete discount(s)
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

        //Save discount addition/edit
        private void Savebutton_Click(object sender, EventArgs e)
        {
            try
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
                    BLLDiscountManagement.Instance.Execute(discount);
                    Savebutton.Visible = false;
                    ClearButton.Visible = false;
                    IDtxt.ReadOnly = true;
                    Nametxt.ReadOnly = true;
                    AmountApplytxt.ReadOnly = true;
                    DiscountApplytxt.ReadOnly = true;
                    dgvDiscount.DataSource = BLLDiscountManagement.Instance.GetAllDiscount_View();
               
            }
            catch
            {
                View.CustomMessageBox.MessageBox.Show("Enter missing information \n or information is not in the right format ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Clear textboxes
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


        /// <summary>
        /// OPEN CHILD FORMS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        // Show "Apply discount to product" form
        private void ApplyButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (BLLDiscountManagement.Instance.Check(IDtxt.Text) == true)
                {
                    Discount d = BLLDiscountManagement.Instance.GetDiscountByID(IDtxt.Text);
                    if (dgvFrom.Value <= DateTime.Now && dgvTo.Value >= DateTime.Now)
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
                    IDtxt.ReadOnly = true;
                    Nametxt.ReadOnly = true;
                    AmountApplytxt.ReadOnly = true;
                    DiscountApplytxt.ReadOnly = true;
                    BLLDiscountManagement.Instance.AddNewDiscount(discount);
                    dgvDiscount.DataSource = BLLDiscountManagement.Instance.GetAllDiscount_View();
                    ApplyDiscountForm form = new ApplyDiscountForm(BLLDiscountManagement.Instance.GetDiscountByDiscountID(IDtxt.Text));
                    form.ShowDialog();
                }
            }
            catch (FormatException ex)
            {
                View.CustomMessageBox.MessageBox.Show("Enter missing information \n or information is not in the right format ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (NullReferenceException ex)
            {
                View.CustomMessageBox.MessageBox.Show("Enter missing information \n or information is not in the right format ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        // Show "Show applied products" form
        private void ShowButton_Click(object sender, EventArgs e)
        {
            AppliedProductsForm form = new AppliedProductsForm(IDtxt.Text);
            form.ShowDialog();
        }


        /// <summary>
        /// RELOAD DISCOUNTS
        /// </summary>
        /// Check if there is any expired discount and remove it
        private Timer timer;
        DateTime currentDay;

        private void startTimer(object sender, EventArgs e)
        {
            timer = new Timer();
            timer.Interval = (1 * 1000); // 1 sec
            timer.Tick += new EventHandler(timer_Tick);
            currentDay = DateTime.Now;
            timer.Start();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now != currentDay)
            {
                List<Discount> expiredDiscounts = BLLDiscountManagement.Instance.GetExpiredDiscounts();
                if(expiredDiscounts != null)
                    BLLDiscountManagement.Instance.RenewDiscounts(expiredDiscounts);
                currentDay = DateTime.Now.Date;
            }
        }


        /// <summary>
        /// OTHER COMPONENTS
        /// </summary>
        // Texboxes textchanged
        private void tb_TextChanged(object sender, EventArgs e)
        {
            if (Nametxt.Text == "" || DataCheck.IsString(Nametxt.Text) != true) Nametxt.IconRightSize = new System.Drawing.Size(7, 7);
            else Nametxt.IconRightSize = new System.Drawing.Size(0, 0);
            if (AmountApplytxt.Text == "" || DataCheck.IsNumber(AmountApplytxt.Text) != true) AmountApplytxt.IconRightSize = new System.Drawing.Size(7, 7);
            else AmountApplytxt.IconRightSize = new System.Drawing.Size(0, 0);
            if (DiscountApplytxt.Text == "" || DataCheck.IsNumber(DiscountApplytxt.Text) != true) DiscountApplytxt.IconRightSize = new System.Drawing.Size(7, 7);
            else DiscountApplytxt.IconRightSize = new System.Drawing.Size(0, 0);
        }
        //Change selected item of combobox Discount Type
        private void Typecbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Typecbb.SelectedIndex == 0)
            {
                AmountApplytxt.Text = "";
                AmountApplytxt.Enabled = false;
            }
            else if (Typecbb.SelectedIndex == 1)
            {
                AmountApplytxt.Text = "";
                AmountApplytxt.Enabled = true;
            }
        }
    }
}
