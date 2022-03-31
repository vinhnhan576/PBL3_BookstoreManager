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

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            transition2.ShowSync(lbIntro);
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
    }
}
