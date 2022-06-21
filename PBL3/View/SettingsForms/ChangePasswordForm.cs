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

namespace PBL3.View.SettingsForms
{
    public partial class ChangePasswordForm : Form
    {
        string username;
        string currentPassword;
        

        public ChangePasswordForm(Account acc)
        {
            InitializeComponent();
            username = acc.Username.Trim();
            currentPassword = acc.Password.Trim();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbCurrentPassword.Text == currentPassword)
                {
                    if (CheckValidation(tbNewPassword.Text))
                    {
                        if (tbConfirmPassword.Text == tbNewPassword.Text)
                        {

                            DialogResult result = CustomMessageBox.MessageBox.Show("Do you want to change your password?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                BLL.BLLAccountManagement.Instance.ChangePassword(username, tbNewPassword.Text);
                                CustomMessageBox.MessageBox.Show("Password changed successfully", "Congratulations", MessageBoxIcon.Information);
                                Properties.Settings.Default.userPass = tbNewPassword.Text;
                                Properties.Settings.Default.Save();
                                ClearTextboxes();
                            }
                            else if (result == DialogResult.No)
                            {
                                ClearTextboxes();
                            }
                        }
                        else
                        {
                            throw new Exception("Wrong password confirmation!");
                        }
                    }
                    else
                    {
                        throw new Exception("New password has to be longer than 6 characters");
                    }
                }
                else
                {
                    throw new Exception("The current password you entered is wrong");
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.MessageBox.Show(ex.Message, "Error", MessageBoxIcon.Error);
                ClearTextboxes();
            }
        }
        
        private void ClearTextboxes()
        {
            tbCurrentPassword.Clear();
            tbNewPassword.Clear();
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
