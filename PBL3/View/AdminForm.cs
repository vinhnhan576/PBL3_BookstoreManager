using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.View
{
    public partial class AdminForm : Form
    {
        private Form activeForm;
        private Guna.UI2.WinForms.Guna2Button currentButton, prevButton;
        Account account;

        public AdminForm(Account acc)
        {
            InitializeComponent();
            account = acc;
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            AdminChildForms.OverviewForm overviewForm = new AdminChildForms.OverviewForm(account.Person);
            overviewForm.TopLevel = false;
            overviewForm.FormBorderStyle = FormBorderStyle.None;
            overviewForm.Dock = DockStyle.Fill;
            this.pnRight.Controls.Add(overviewForm);
            overviewForm.BringToFront();
            overviewForm.Show();

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
                if(currentButton != (Guna.UI2.WinForms.Guna2Button)sender)
                {
                    disableButton();
                    currentButton = (Guna.UI2.WinForms.Guna2Button)sender;
                    currentButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    currentButton.FillColor = Color.FromArgb(198, 232, 229);
                    currentButton.ForeColor = Color.FromArgb(1, 79, 134);
                    //currentButton.Image.Dispose();
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
                    //((Guna.UI2.WinForms.Guna2Button)prevButton).Image.Tag =
                }
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
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
            DialogResult result = CustomMessageBox.MessageBox.Show("Are you sure you want to log out", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
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
            openChildForm(new AdminChildForms.DiscountForm(), sender);
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
    }
}
