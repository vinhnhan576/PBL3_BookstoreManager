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
    public partial class RememberLogin : Form
    {
        Account account;
        public RememberLogin(Account acc)
        {
            InitializeComponent();
            account = acc;
            if (Properties.Settings.Default.rememberLogin)
            {
                btnSave.FillColor = Color.FromArgb(2, 62, 138);
                btnSave.ImageAlign = HorizontalAlignment.Right;
            }
            else
            {
                btnSave.FillColor = Color.Gray;
                btnSave.ImageAlign = HorizontalAlignment.Left;
            }

            //if(Properties.Settings.Default.stayLoggedIn)
            //{
            //    btnLoggedIn.FillColor = Color.FromArgb(2, 62, 138);
            //    btnLoggedIn.ImageAlign = HorizontalAlignment.Right;
            //}
            //else
            //{
            //    btnLoggedIn.FillColor = Color.Gray;
            //    btnLoggedIn.ImageAlign = HorizontalAlignment.Left;
            //}
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // tick
            if(Properties.Settings.Default.rememberLogin)
            {
                Properties.Settings.Default.rememberLogin = false;
                Properties.Settings.Default.username = null;
                Properties.Settings.Default.userPass = null;
                Properties.Settings.Default.Save();
                btnSave.FillColor = Color.Gray;
                btnSave.ImageAlign = HorizontalAlignment.Left;
            }
            // untick
            else
            {
                Properties.Settings.Default.rememberLogin = true;
                Properties.Settings.Default.username = account.Username;
                Properties.Settings.Default.userPass = account.Password;
                Properties.Settings.Default.Save();
                btnSave.FillColor = Color.FromArgb(2, 62, 138);
                btnSave.ImageAlign = HorizontalAlignment.Right;
            }
        }

        //private void btnLoggedIn_Click(object sender, EventArgs e)
        //{
        //    // tick
        //    if (Properties.Settings.Default.stayLoggedIn)
        //    {
        //        Properties.Settings.Default.stayLoggedIn = false;
        //        Properties.Settings.Default.Save();
        //        btnLoggedIn.FillColor = Color.Gray;
        //        btnLoggedIn.ImageAlign = HorizontalAlignment.Left;
        //    }
        //    // untick
        //    else
        //    {
        //        Properties.Settings.Default.stayLoggedIn = true;
        //        Properties.Settings.Default.Save();
        //        btnLoggedIn.FillColor = Color.FromArgb(2, 62, 138);
        //        btnLoggedIn.ImageAlign = HorizontalAlignment.Right;
        //    }
        //}
    }
}
