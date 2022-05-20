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

namespace PBL3.View.SettingsForms
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
            Person person = BLLPersonManagement.Instance.GetPersonByPersonID(account.PersonID);
            tbStaffID.Text = person.PersonID;
            tbStaffName.Text = person.PersonName;
            if(person.Gender)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;
            tbRole.Text = person.Role;
            tbAddress.Text = person.Address;
            tbTel.Text = person.PhoneNumber;
            tbEmail.Text = person.Email;
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
