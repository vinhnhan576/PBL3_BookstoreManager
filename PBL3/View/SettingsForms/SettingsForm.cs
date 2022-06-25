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
using Guna.UI2.WinForms;

namespace PBL3.View.SettingsForms
{
    public partial class SettingsForm : Form
    {
        private Form activeForm;
        Account account;
        private Label currentLabel;
        public SettingsForm(Account acc)
        {
            InitializeComponent();
            account = acc;
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            currentLabel = lbPassword;
            openChildForm(new EditProfileForm(account.Person), lbProfile);
        }

        private void lbPassword_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changePasswordForm = new ChangePasswordForm(account);
            openChildForm(changePasswordForm, lbPassword);
        }

        private void lbProfile_Click(object sender, EventArgs e)
        {
            //Person person = BLLPersonManagement.Instance.GetPersonByPersonID(account.PersonID);
            EditProfileForm editProfileForm = new EditProfileForm(account.Person);
            openChildForm(editProfileForm, lbProfile);
        }

        private void lbRememberLogin_Click(object sender, EventArgs e)
        {
            RememberLogin rememberLoginForm = new RememberLogin(account);
            openChildForm(rememberLoginForm, lbRememberLogin);
        }

        private void openChildForm(Form childForm, object lbSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activateLabel(lbSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pn.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void activateLabel(object sender)
        {
            if (sender != null)
            {
                if (currentLabel != (Label)sender)
                {
                    disableLabel();
                    currentLabel = (Label)sender;
                    currentLabel.Font = new System.Drawing.Font("Century Gothic", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    currentLabel.ForeColor = Color.FromArgb(2, 62, 138);
                    if(currentLabel.Text == "Profile")
                        pnProfile.FillColor = Color.FromArgb(2, 62, 138);
                    else if(currentLabel.Text == "Password")
                        pnPassword.FillColor = Color.FromArgb(2, 62, 138);
                    else
                        pnRememberLogin.FillColor = Color.FromArgb(2, 62, 138);
                }
            }
        }

        private void disableLabel()
        {
            foreach (Control otherLabel in pnMenuBar.Controls)
            {
                if (otherLabel.GetType() == typeof(Label))
                {
                    otherLabel.ForeColor = Color.FromArgb(174, 177, 182);
                    otherLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    if(otherLabel.Text == "Profile")
                        pnProfile.FillColor = Color.FromArgb(223, 216, 232);
                    else if(otherLabel.Text == "Password")
                        pnPassword.FillColor = Color.FromArgb(223, 216, 232);
                    else
                        pnRememberLogin.FillColor = Color.FromArgb(223, 216, 232);
                }
            }
        }
    }
}
