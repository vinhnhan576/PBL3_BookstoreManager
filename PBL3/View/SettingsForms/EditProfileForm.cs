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
using PBL3.Model;

namespace PBL3.View.SettingsForms
{
    public partial class EditProfileForm : Form
    {
        //public delegate void MyDelegate();
        //public MyDelegate myDelegate;
        Person person;
        public EditProfileForm(Person p)
        {
            InitializeComponent();
            person = p;
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            tbName.Text = person.PersonName;
            tbAddress.Text = person.Address;
            tbTel.Text = person.PhoneNumber;
            tbEmail.Text = person.Email;
            if(person.Gender)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;
            tbRole.Text = person.Role;
            tbRole.ReadOnly = true;
            EnableDisableComponents(false);
            btnEdit.Visible = true;
            btnOK.Visible = false;
            btnCancel.Visible = false;
        }

        private void EnableDisableComponents(bool enable)
        {
            tbName.ReadOnly = !enable;
            tbEmail.ReadOnly = !enable;
            tbAddress.ReadOnly = !enable;
            tbTel.ReadOnly = !enable;
            rbMale.Enabled = enable;
            rbFemale.Enabled = enable;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            InitializeGUI();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Person p = new Person();
            p.PersonName = tbName.Text;
            p.Address = tbAddress.Text;
            p.PhoneNumber = tbTel.Text;
            p.Email = tbEmail.Text;
            p.Gender = (rbMale.Checked ? true : false);
            BLLPersonManagement.Instance.UpdatePeronalInfo(person.PersonID, p);
            InitializeGUI();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EnableDisableComponents(true);
            btnEdit.Visible = false;
            btnOK.Visible = true;
            btnCancel.Visible = true;
        }
    }
}
