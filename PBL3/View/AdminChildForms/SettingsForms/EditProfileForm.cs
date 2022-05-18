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
    public partial class EditProfileForm : Form
    {
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
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
        }
    }
}
