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
    public partial class StockkeeperForm : Form
    {
        private Form activeForm;
        private Guna.UI2.WinForms.Guna2Button currentButton;
        Account account;

        public StockkeeperForm(Account acc)
        {
            InitializeComponent();
            account = acc;
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            currentButton = btnStoreImport;
            openChildForm(new StockkeeperChildForms.NewStockItem(account), btnNewStock);

            string name = account.Person.PersonName.Split()[account.Person.PersonName.Split().Count() - 1];
            lbWelcome.Text = "Welcome, " + name;
            lbDate.Text = DateTime.Now.ToShortDateString();
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

        private void activateButton(object sender)
        {
            if (sender != null)
            {
                btnSettings.Visible = true;
                if (currentButton != (Guna.UI2.WinForms.Guna2Button)sender)
                {
                    disableButton();
                    currentButton = (Guna.UI2.WinForms.Guna2Button)sender;
                    currentButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    currentButton.FillColor = Color.FromArgb(198, 232, 229);
                    currentButton.ForeColor = Color.FromArgb(1, 79, 134);
                }
            }
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


        private void btnSettings_Click(object sender, EventArgs e)
        {
            btnSettings.Visible = false;
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

        private void disableButton()
        {
            foreach (Control prevButton in pnMenu.Controls)
            {
                if (prevButton.GetType() == typeof(Guna.UI2.WinForms.Guna2Button))
                {
                    ((Guna.UI2.WinForms.Guna2Button)prevButton).FillColor = Color.Transparent;
                    prevButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    prevButton.ForeColor = Color.White;
                }
            }
        }

        private void btnNewStockItem_Click(object sender, EventArgs e)
        {
            openChildForm(new StockkeeperChildForms.NewStockItem(account), sender);
        }

        private void btnViewStock_Click(object sender, EventArgs e)
        {
            openChildForm(new StockkeeperChildForms.ManageStock(), sender);
        }

        private void btnStoreImport_Click(object sender, EventArgs e)
        {
            openChildForm(new StockkeeperChildForms.ImportStore(account), sender);
        }

    }
}
