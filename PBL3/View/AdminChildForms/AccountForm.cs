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
    public partial class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();
            dgvAccount.DataSource = BLLAccountManagement.Instance.GetAllAccount_View();
            cbbSortOrder.SelectedIndex = 0;
            cbbSortOrder.SelectedIndexChanged += new System.EventHandler(this.cbbSortOrder_SelectedIndexChanged);
            cbbSortCategory.SelectedIndex = 0;
            cbbSortCategory.SelectedIndexChanged += new System.EventHandler(this.cbbSortCategory_SelectedIndexChanged);
        }
        public void Reload()
        {
            dgvAccount.DataSource = BLLAccountManagement.Instance.GetAllAccount_View();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int count = QLSPEntities.Instance.Accounts.Count() + 1;
            tbID.Text = count.ToString();
            tbID.Enabled = false;
            tbUsername.Text = "";
            tbUsername.Enabled = true;
            tbPassword.Text = "";
            tbPassword.Enabled = true;
            tbName.Text = "";
            tbName.Enabled = true;
            tbTel.Text = "";
            tbTel.Enabled = true;
            tbAddress.Text = "";
            tbAddress.Enabled = true;
            cbbRole.Text = null;
            cbbRole.Enabled = true;
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
                BLLAccountManagement.Instance.DelAccount(del);
                Reload();
            }
        }
        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAccount.SelectedRows.Count == 1)
            {
                string ID = dgvAccount.SelectedRows[0].Cells[0].Value.ToString();
                PBL3.Account ac = BLLAccountManagement.Instance.GetAccountByPersonID(ID);
                string s = "";
                for (int i = 0; i < ac.Password.Length; i++)
                {
                    if (ac.Password[i] != ' ')
                    {
                        s += '*';
                    }
                }
                tbID.Text = ac.PersonID.ToString();
                tbID.Enabled = false;
                tbUsername.Text = ac.Username.ToString();
                tbUsername.Enabled = false;
                tbPassword.Text = s;
                tbPassword.Enabled = false;
                if (ac.Person.Gender == true)
                {
                    rbMale.Checked = true;
                }
                else
                {
                    rbFemale.Checked = true;
                }
                tbName.Text = ac.Person.PersonName.ToString();
                tbName.Enabled = false;
                tbTel.Text = (Convert.ToInt32(ac.Person.PhoneNumber)).ToString();
                tbTel.Enabled = false;
                tbAddress.Text = ac.Person.Address.ToString();
                tbAddress.Enabled = false;
                cbbRole.SelectedItem = ac.Person.Role.ToString();
                cbbRole.Enabled = false;
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
            cbbRole.Text = null;
        }
        private void cbbSortCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbSearch.Text = "";
            string sortCategory = cbbSortCategory.SelectedItem.ToString();
            bool sortOrder = (cbbSortOrder.SelectedItem.ToString() == "Ascending" ? true : false);
            dgvAccount.DataSource = BLLAccountManagement.Instance.SortAcount(sortCategory, sortOrder);
        }

        private void cbbSortOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbSearch.Text = "";
            string sortCategory = cbbSortCategory.SelectedItem.ToString();
            bool sortOrder = (cbbSortOrder.SelectedItem.ToString() == "Ascending" ? true : false);
            dgvAccount.DataSource = BLLAccountManagement.Instance.SortAcount(sortCategory, sortOrder);
        }

        private void cbbFilterCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbFilterValue.Text = "";
            cbbFilterValue.Items.Clear();
            string filterCategory = cbbFilterCategory.SelectedItem.ToString();
            if (filterCategory == "Role")
            {
                foreach (string i in BLLAccountManagement.Instance.GetAllRole().Distinct())
                {
                    cbbFilterValue.Items.Add(i);
                }
            }
            if (filterCategory == "Address")
            {
                foreach (string i in BLLAccountManagement.Instance.GetAllAddress().Distinct())
                {
                    cbbFilterValue.Items.Add(i);
                }
            }
        }

        private void cbbFilterValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvAccount.DataSource = BLLAccountManagement.Instance.SearchAccount(cbbFilterValue.SelectedItem.ToString());
        }

        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tbSearch != null)
            {
                dgvAccount.DataSource = BLLAccountManagement.Instance.SearchAccount(tbSearch.Text);

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvAccount.SelectedRows.Count == 1)
            {
                string ID = dgvAccount.SelectedRows[0].Cells[0].Value.ToString();
                PBL3.Account ac = BLLAccountManagement.Instance.GetAccountByPersonID(ID);
                string s = "";
                for (int i = 0; i < ac.Password.Length; i++)
                {
                    if (ac.Password[i] != ' ')
                    {
                        s += '*';
                    }
                }
                tbID.Text = ac.PersonID.ToString();
                tbID.Enabled = false;
                tbUsername.Text = ac.Username.ToString();
                tbUsername.Enabled = true;
                tbPassword.Text = s;
                tbPassword.Enabled = true;
                if (ac.Person.Gender == true)
                {
                    rbMale.Checked = true;
                }
                else
                {
                    rbFemale.Checked = true;
                }
                tbName.Text = ac.Person.PersonName.ToString();
                tbName.Enabled = false;
                tbTel.Text = (Convert.ToInt32(ac.Person.PhoneNumber)).ToString();
                tbTel.Enabled = false;
                tbAddress.Text = ac.Person.Address.ToString();
                tbAddress.Enabled = false;
                cbbRole.SelectedItem = ac.Person.Role.ToString();
                cbbRole.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            PBL3.Account a = new PBL3.Account();
            Person p = new Person();
            p.PersonName = tbName.Text;
            p.PhoneNumber = tbTel.Text;
            p.Address = tbAddress.Text;
            p.Role = cbbRole.SelectedItem.ToString();
            if (rbMale.Checked)
            {
                p.Gender = true;
            }
            else p.Gender = true;
            if (cbbRole.SelectedItem.ToString() == "Admin")
            {
                p.PersonID = a.PersonID = "ad00" + tbID.Text;
            }
            if (cbbRole.SelectedItem.ToString() == "Salesman")
            {
                p.PersonID = a.PersonID = "sm00" + tbID.Text;
            }
            if (cbbRole.SelectedItem.ToString() == "Stockkeeper")
            {
                p.PersonID = a.PersonID = "sk00" + tbID.Text;
            }
            a.Username = tbUsername.Text;
            a.Password = tbPassword.Text;
            a.Person = p;
            BLLAccountManagement.Instance.Execute(a);
            Reload();
        }
    }
}