using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.View.AdminChildForms.SettingsForms
{
    public partial class ChangePasswordForm : Form
    {
        string username;
        string currentPassword;
        public ChangePasswordForm(Account acc)
        {
            InitializeComponent();
            username = acc.Account1.Trim();
            currentPassword = acc.Password.Trim();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(tbCurrentPassword.Text == currentPassword)
            {
                if (CheckValidation(tbNewPassword.Text))
                {
                    if(tbConfirmPassword.Text == tbNewPassword.Text)
                    {
                        
                        DialogResult result = MessageBox.Show("Do you want to change your password?", "Warning", MessageBoxButtons.YesNoCancel);
                        if (result == DialogResult.Yes)
                        {
                            BLL.BLLAccountManagement.Instance.ChangePassword(username, tbNewPassword.Text);
                            this.Close();
                        }
                        else if (result == DialogResult.No)
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Different password confirmation");
                        ClearTextboxes();
                    }
                }
                else
                {
                    MessageBox.Show("New password has to be longer than 6 characters");
                    ClearTextboxes();
                }
            }
            else
            {
                MessageBox.Show("The current password you entered is wrong");
                ClearTextboxes();   
            }
        }
        
        private void ClearTextboxes()
        {
            tbCurrentPassword.Text = "";
            tbNewPassword.Text = "";
            tbConfirmPassword.Clear();
        }

        private bool CheckValidation(string password)
        {
            if(password.Length >= 6)
            {
                return true;
            }
            else
                return false;
        }
    }
}
