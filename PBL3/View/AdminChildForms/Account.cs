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

namespace PBL3.View.AdminChildForms
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
            dgvAccount.DataSource = BLLAccountManagement.Instance.GetAllAccount();
            cbbGender.Items.Add("Nam");
            cbbGender.Items.Add("Nữ");
        }
        public void Reload()
        {
            dgvAccount.DataSource = BLLAccountManagement.Instance.GetAllAccount();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            PBL3.Account a = new PBL3.Account();
            Person p = new Person();
            p.PersonID = tbID.Text;
            p.PersonName = tbName.Text;
            p.PhoneNumber = tbTel.Text;
            p.Address = tbAddress.Text;          
            p.Role = tbRole.Text;
            BLLPersonManagement.Instance.AddNewPerson(p);
            a.PersonID = tbID.Text;
            a.Account1 = tbUsername.Text;
            a.Password = tbPassword.Text;
            BLLAccountManagement.Instance.AddNewAccount(a);
            Reload();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<string> del = new List<string>();
            if (dgvAccount.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow i in dgvAccount.SelectedRows)
                {
                    del.Add(i.Cells[0].Value.ToString());
                }
                BLLPersonManagement.Instance.DelPerson(del);
                BLLAccountManagement.Instance.DelAccount(del);
                Reload();
            }
        }

        private void tbSearch_IconRightClick(object sender, EventArgs e)
        {
            if(tbSearch != null)
            {
               dgvAccount.DataSource = BLLAccountManagement.Instance.SearchAccount(tbSearch.Text);
                
            }
        }
        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvAccount.SelectedRows.Count == 1)
            {
                string ID = dgvAccount.SelectedRows[0].Cells[0].Value.ToString();
               PBL3.Account ac = BLLAccountManagement.Instance.GetAccountByPersonID(ID);
                tbID.Text = ac.PersonID.ToString();
                tbUsername.Text = ac.Account1.ToString() ;
                tbPassword.Text = ac.Password.ToString();
                //cbbGender = ac.Person.Gender() == true ? true : false;
                tbName.Text =ac.Person.PersonName.ToString() ;
                tbTel.Text = (Convert.ToInt32(ac.Person.PhoneNumber)).ToString();
                tbAddress.Text = ac.Person.Address.ToString() ;
               tbRole.Text  = ac.Person.Role.ToString() ;
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbID.Text = "";
            tbUsername.Text = "";
            tbPassword.Text = "";
            tbName.Text = "";
            tbTel.Text = "";
            tbAddress.Text = "";
            tbRole.Text = "";
        }
    }
}
