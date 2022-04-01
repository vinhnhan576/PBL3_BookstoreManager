using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3
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
                this.Close();
                new AdminForm().ShowDialog();
            }
            if(tbUsername.Text == "user" && tbPassword.Text == "user")
            {
                this.Close();
                new StaffForm().ShowDialog();
            }
        }
    }
}
