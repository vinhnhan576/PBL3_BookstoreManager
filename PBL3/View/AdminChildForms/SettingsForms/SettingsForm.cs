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

namespace PBL3.View.AdminChildForms.SettingsForms
{
    public partial class SettingsForm : Form
    {
        Account account;
        public SettingsForm(Account acc)
        {
            InitializeComponent();
            account = acc;
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            tbStaffID.Text = account.Person.PersonID;
            tbStaffName.Text = account.Person.PersonName;
            if(account.Person.Gender)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;
            tbRole.Text = account.Person.Role;
            tbAddress.Text = account.Person.Address;
            tbTel.Text = account.Person.PhoneNumber;
            tbPassword.Text = account.Password;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changePasswordForm = new ChangePasswordForm(account);
            changePasswordForm.ShowDialog();
            tbPassword.Text = account.Password;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Person person = BLLPersonManagement.Instance.GetPersonByPersonID(account.PersonID);
            EditProfileForm editProfileForm = new EditProfileForm(person);
            editProfileForm.myDelegate = InitializeGUI;
            editProfileForm.ShowDialog();
            
        }
    }
}
