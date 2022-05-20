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
    public partial class StockkeeperForm : Form
    {
        private Form activeForm;
        private Guna.UI2.WinForms.Guna2Button currentButton, prevButton;
        Account account;

        public StockkeeperForm(Account acc)
        {
            InitializeComponent();
            account = acc;
            StockkeeperChildForms.Overview overviewForm = new StockkeeperChildForms.Overview(account.Person);
            overviewForm.TopLevel = false;
            overviewForm.FormBorderStyle = FormBorderStyle.None;
            overviewForm.Dock = DockStyle.Fill;
            this.pnRight.Controls.Add(overviewForm);
            overviewForm.BringToFront();
            overviewForm.Show();
        }
        private void openChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            openChildForm(new StockkeeperChildForms.Overview(account.Person), sender);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            openChildForm(new StockkeeperChildForms.NewStockItem(account), sender);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            openChildForm(new StockkeeperChildForms.ManageStock(), sender);
        }

        private void activateButton(object sender)
        {
            if (sender != null)
            {
                if (currentButton != (Guna.UI2.WinForms.Guna2Button)sender)
                {
                    disableButton();
                    currentButton = (Guna.UI2.WinForms.Guna2Button)sender;
                    currentButton.BackColor = Color.White;
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = CustomMessageBox.MessageBox.Show("Are you sure you want to log out", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (result == DialogResult.Yes)
            {
                this.Close();
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
        }

        private void btnStoreImport_Click(object sender, EventArgs e)
        {
            openChildForm(new StockkeeperChildForms.ImportStore(), sender);
        }

        private void disableButton()
        {
            foreach (Control prevButton in pnMenu.Controls)
            {
                if (prevButton.GetType() == typeof(Guna.UI2.WinForms.Guna2Button))
                {
                    prevButton.BackColor = Color.Transparent;
                    prevButton.ForeColor = Color.Gainsboro;
                }
            }
        }

    }
}
