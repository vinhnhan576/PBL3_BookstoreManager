using PBL3.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.View.LoginForms
{
    public partial class ResetPassword : Form
    {
        Account account;
        public delegate void MyDelegate();
        public MyDelegate myDelegate { get; set; }
        public ResetPassword(Account acc)
        {
            InitializeComponent();
            account = acc;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if(tbNewPassword.Text != tbConfirmPassword.Text)
            {
                CustomMessageBox.MessageBox.Show("Wrong confirmation", "Error", MessageBoxIcon.Error);
            }
            else
            {
                BLL.BLLAccountManagement.Instance.ChangePassword(account.Username, tbNewPassword.Text);
                DialogResult result = CustomMessageBox.MessageBox.Show("Reset password successfully", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                myDelegate();
                //this.Close();
            }
        }
    }
}
