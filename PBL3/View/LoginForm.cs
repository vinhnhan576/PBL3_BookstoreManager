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
            if(tbUsername.Text == "admin" && tbPassword.Text == "admin")
            {
                this.Visible = false;
                new AdminForm().ShowDialog();
                this.Visible = true;
            }
            if(tbUsername.Text == "user1" && tbPassword.Text == "user1")
            {
                this.Visible = false;
                new CashierForm().ShowDialog();
                this.Visible = true;
            }
            if (tbUsername.Text == "user2" && tbPassword.Text == "user2")
            {
                this.Visible = false;
                new StockkeeperForm().ShowDialog();
                this.Visible = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new ForgotPasswordForm().ShowDialog();
            this.Visible = true;
        }
    }
}
