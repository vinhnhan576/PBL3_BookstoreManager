using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.BLL;

namespace PBL3.View
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            
        }

        private void pbShowPass_Click(object sender, EventArgs e)
        {
            if(tbPassword.Text != "")
            {
                if (tbPassword.PasswordChar == '*')
                {
                    pbShowPass.Image = global::PBL3.Properties.Resources.hidePassword;
                    tbPassword.PasswordChar = '\0';
                }
                else
                {
                    pbShowPass.Image = global::PBL3.Properties.Resources.showPassword;
                    tbPassword.PasswordChar = '*';
                }
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            bool usernameExist = false;
            foreach(Account i in BLLAccountManagement.Instance.GetAllAccount())
            {
                if (tbUsername.Text == i.Account1.Trim())
                {
                    usernameExist = true;
                    if(tbPassword.Text == i.Password.Trim())
                    {
                        if(i.Person.Role.Trim() == "Admin")
                        {
                            this.Visible = false;
                            new AdminForm(i).ShowDialog();
                            ClearTextboxes();
                            this.Visible = true;
                            break;
                        }
                        if (i.Person.Role.Trim() == "Salesman")
                        {
                            this.Visible = false;
                            new CashierForm(i).ShowDialog();
                            ClearTextboxes();
                            this.Visible = true;
                            break;
                        }
                        if (i.Person.Role.Trim() == "Stockkeeper")
                        {
                            this.Visible = false;
                            new StockkeeperForm(i).ShowDialog();
                            ClearTextboxes();
                            this.Visible = true;
                            break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Wrong password");
                        tbPassword.Text = "";
                        break;
                    }
                }
            }
            if(!usernameExist)
            {
                tbPassword.Text = "";
                MessageBox.Show("Account username doesn't exist");
            }
        }

        private void ClearTextboxes()
        {
            tbUsername.Text = "";
            tbPassword.Text = "";
        }

        private void lbForgotPassword_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new ForgotPasswordForm().ShowDialog();
            this.Visible = true;
        }
    }
}
