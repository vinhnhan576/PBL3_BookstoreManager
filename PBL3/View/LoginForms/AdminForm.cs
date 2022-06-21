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

namespace PBL3.View
{
    public partial class AdminForm : Form
    {
        private Form activeForm;
        private Guna.UI2.WinForms.Guna2Button currentButton;
        Account account;

        public AdminForm(Account acc)
        {
            InitializeComponent();
            account = acc;
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            currentButton = btnDiscount;
            openChildForm(new AdminChildForms.OverviewForm(account.Person), btnOverview);

            string name = account.Person.PersonName.Split()[account.Person.PersonName.Split().Count() - 1];
            lbWelcome.Text = "Welcome, " + name;
            lbDate.Text = DateTime.Now.ToShortDateString();
        }

        private void openChildForm(Form childForm, object btnSender)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnRight.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void activateButton(object sender)
        {
            if(sender != null)
            {
                btnSettings.Visible = true;
                pnMenu.BackColor = Color.FromArgb(198, 232, 229);
                if (currentButton != (Guna.UI2.WinForms.Guna2Button)sender)
                {
                    disableButton();
                    currentButton = (Guna.UI2.WinForms.Guna2Button)sender;
                    currentButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    currentButton.FillColor = Color.FromArgb(198, 232, 229);
                    currentButton.ForeColor = Color.FromArgb(1, 79, 134);
                    if (currentButton.Text == "Overview")
                        currentButton.Image = Properties.Resources.iconBlueOverview;
                    else if(currentButton.Text == "Product")
                        currentButton.Image = Properties.Resources.iconBlueBook;
                    else if (currentButton.Text == "Customer")
                        currentButton.Image = Properties.Resources.iconBlueCustomer;
                    else if (currentButton.Text == "Bill")
                        currentButton.Image = Properties.Resources.iconBlueBill;
                    else if (currentButton.Text == "Stock")
                        currentButton.Image = Properties.Resources.iconBlueStock;
                    else if (currentButton.Text == "Discount")
                        currentButton.Image = Properties.Resources.iconBlueDiscount;
                    else if (currentButton.Text == "Account")
                        currentButton.Image = Properties.Resources.iconBlueAccount;
                    else
                        currentButton.Image = Properties.Resources.iconBlueRevenue;

                }
            }
        }

        private void disableButton()
        {
            foreach(Control prevButton in pnMenu.Controls)
            {
                if(prevButton.GetType() == typeof(Guna.UI2.WinForms.Guna2Button))
                {
                    ((Guna.UI2.WinForms.Guna2Button)prevButton).FillColor = Color.Transparent;
                    prevButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    prevButton.ForeColor = Color.White;
                    if (currentButton.Text == "Overview")
                        currentButton.Image = Properties.Resources.iconWhiteOverview;
                    else if (currentButton.Text == "Product")
                        currentButton.Image = Properties.Resources.iconWhiteBook;
                    else if (currentButton.Text == "Customer")
                        currentButton.Image = Properties.Resources.customer;
                    else if (currentButton.Text == "Bill")
                        currentButton.Image = Properties.Resources.bill;
                    else if (currentButton.Text == "Stock")
                        currentButton.Image = Properties.Resources.stock;
                    else if (currentButton.Text == "Discount")
                        currentButton.Image = Properties.Resources.iconWhiteDiscount;
                    else if (currentButton.Text == "Account")
                        currentButton.Image = Properties.Resources.account;
                    else
                        currentButton.Image = Properties.Resources.revenue;
                }
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            btnSettings.Visible = false;
            pnMenu.BackColor = Color.FromArgb(228, 241, 239);
            SettingsForms.SettingsForm childForm = new SettingsForms.SettingsForm(account);
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnRight.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
            disableButton();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            DialogResult result = CustomMessageBox.MessageBox.Show("Are you sure you want to log out", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void btnOverview_Click(object sender, EventArgs e)
        {
            openChildForm(new AdminChildForms.OverviewForm(account.Person), sender);
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            openChildForm(new AdminChildForms.ProductForms.Product(), sender);
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            openChildForm(new AdminChildForms.BillForm(account), sender);
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            openChildForm(new AdminChildForms.StockForm(), sender);
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            openChildForm(new AdminChildForms.DiscountForms.DiscountForm(), sender);
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            openChildForm(new AdminChildForms.AccountForm(), sender);
        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            openChildForm(new AdminChildForms.RevenueForm(), sender);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            openChildForm(new AdminChildForms.CustomerForm(), sender);
        }

        private void Rankbutton_Click(object sender, EventArgs e)
        {
            openChildForm(new AdminChildForms.RankForm(), sender); 
        }
    }
}
