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
using System.Text.RegularExpressions;
using PBL3.DTO;

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
            btnSave.Visible = false;
            btnClear.Visible = false;
            dgvAccount_CellClick(this, new DataGridViewCellEventArgs(0, 0));
        }
        public void Reload()
        {
            dgvAccount.DataSource = BLLAccountManagement.Instance.GetAllAccount_View();
        }
        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAccount.SelectedRows.Count == 1)
            {
                string ID = dgvAccount.SelectedRows[0].Cells[0].Value.ToString();
                Account ac = BLLAccountManagement.Instance.GetAccountByPersonID(ID);
                string s = "";
                for (int i = 0; i < ac.Password.Length; i++)
                {
                    if (ac.Password[i] != ' ')
                    {
                        s += '*';
                    }
                }
                tbID.Text = ac.PersonID.ToString();
                tbUsername.Text = ac.Username.ToString();
                tbPassword.Text = s;
                if (ac.Person.Gender == true)
                {
                    rbMale.Checked = true;
                }
                else
                {
                    rbFemale.Checked = true;
                }
                tbName.Text = ac.Person.PersonName;
                tbTel.Text = ac.Person.PhoneNumber;
                tbAddress.Text = ac.Person.Address;
                cbbRole.SelectedItem = ac.Person.Role;
                btnSave.Visible = false;
                btnClear.Visible = false;
                tbID.Enabled = true;
                tbID.ReadOnly = true;
                tbUsername.ReadOnly = true;
                tbPassword.ReadOnly = true;
                tbName.ReadOnly = true;
                tbTel.ReadOnly = true;
                tbAddress.ReadOnly = true;
                cbbRole.Enabled = true;
                tbUsername.IconRightSize = new System.Drawing.Size(0, 0);
            }
        }
        //
        //CRUD
        //
        //Add account
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int count = QLNS.Instance.Accounts.Count() + 1;
            tbID.Text = "0"+count.ToString();
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
            rbFemale.Checked = false;rbMale.Checked = false;
            cbbRole.Text = null;
            cbbRole.Enabled = true;
            btnSave.Visible = true;
            btnClear.Visible = true;
        }

        //Edit account
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAccount.SelectedRows.Count == 1)
                {
                    string ID = dgvAccount.SelectedRows[0].Cells[0].Value.ToString();
                    Account ac = BLLAccountManagement.Instance.GetAccountByPersonID(ID);
                    tbID.Text = ac.PersonID;
                    tbID.Enabled = false;
                    tbUsername.Text = ac.Username;
                    tbUsername.Enabled = true;
                    tbPassword.Text = ac.Password;
                    tbPassword.Enabled = true;
                    if (ac.Person.Gender == true)
                    {
                        rbMale.Checked = true;
                    }
                    else
                    {
                        rbFemale.Checked = true;
                    }
                    tbName.Text = ac.Person.PersonName;
                    tbName.Enabled = false;
                    tbTel.Text = ac.Person.PhoneNumber;
                    tbTel.Enabled = false;
                    tbAddress.Text = ac.Person.Address;
                    tbAddress.Enabled = false;
                    cbbRole.SelectedItem = ac.Person.Role;
                    cbbRole.Enabled = false;
                    btnSave.Visible = true;
                    btnClear.Visible = true;
                }
                else throw new Exception("Please choose only 1 account to edit");
            }
            catch (Exception ex)
            {
                CustomMessageBox.MessageBox.Show(ex.Message, "Error", MessageBoxIcon.Error);
            }
        }

        //Delete account(s)
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = CustomMessageBox.MessageBox.Show("Are you sure you want to delete this account(s)?", "Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                List<string> del = new List<string>();
                if (dgvAccount.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow i in dgvAccount.SelectedRows)
                    {
                        del.Add(i.Cells[0].Value.ToString());
                    }
                    BLLAccountManagement.Instance.DelAccount(del);
                    tbID.Text = null;
                    tbUsername.Text = null;
                    tbPassword.Text = null;
                    tbName.Text = null;
                    tbTel.Text = null;
                    tbAddress.Text = null;
                    cbbRole.Text = null;
                    Reload();
                }
            }
        }

        //Save account addition/edit
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbAddress.Text == "" || tbName.Text == "" || tbTel.Text == "" || tbPassword.Text == "" || tbUsername.Text == ""
                || rbFemale.Checked == false && rbMale.Checked == false || cbbRole.SelectedItem == null)
                    throw new Exception("Enter missing account information");
                else
                {
                    bool checkID = false;
                    Account a = new Account();
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
                    foreach (Account ac in BLLAccountManagement.Instance.GetAllAccount())
                    {
                        if (tbID.Text == ac.PersonID)
                        {
                            checkID = true;
                        }
                    }
                    if (checkID) a.PersonID = p.PersonID = tbID.Text;
                    else a.PersonID = p.PersonID = SetID(cbbRole.SelectedItem.ToString());
                    a.Username = tbUsername.Text;
                    a.Password = tbPassword.Text;
                    a.Person = p;
                    BLLAccountManagement.Instance.Execute(a);
                    CustomMessageBox.MessageBox.Show("", "Success", MessageBoxIcon.Information);
                    dgvAccount.DataSource = BLLAccountManagement.Instance.GetAllAccount_View();
                    tbID.Text = ""; tbID.Enabled = true;
                    tbUsername.Text = ""; tbUsername.Enabled = true;
                    tbPassword.Text = ""; tbPassword.Enabled = true;
                    tbName.Text = ""; tbName.Enabled = true;
                    tbTel.Text = ""; tbTel.Enabled = true;
                    tbAddress.Text = ""; tbAddress.Enabled = true;
                    cbbRole.Text = null; cbbRole.Enabled = true;
                    btnSave.Visible = false;
                    btnClear.Visible = false;
                    tbUsername.IconRightSize = new System.Drawing.Size(0, 0);
                    tbPassword.IconRightSize = new System.Drawing.Size(0, 0);
                    tbName.IconRightSize = new System.Drawing.Size(0, 0);
                    tbTel.IconRightSize = new System.Drawing.Size(0, 0);
                    tbAddress.IconRightSize = new System.Drawing.Size(0, 0);
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.MessageBox.Show(ex.Message, "Invalid input", MessageBoxIcon.Error);
            }
        }

        //Clear textboxes
        private void btnClear_Click(object sender, EventArgs e)
        {
            tbID.Text = null;
            tbUsername.Text = null;
            tbPassword.Text = null;
            tbName.Text = null;
            tbTel.Text = null;
            tbAddress.Text = null;
            rbMale.Checked = false;rbFemale.Checked = false;
            cbbRole.Text = null;
            tbUsername.IconRightSize = new System.Drawing.Size(0, 0);
            tbPassword.IconRightSize = new System.Drawing.Size(0, 0);
            tbName.IconRightSize = new System.Drawing.Size(0, 0);
            tbTel.IconRightSize = new System.Drawing.Size(0, 0);
            tbAddress.IconRightSize = new System.Drawing.Size(0, 0);
        }

        //
        //SEARCH SORT FILTER
        //
        //Search account
        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                if (string.IsNullOrWhiteSpace(tbSearch.Text))
                {
                    dgvAccount.DataSource = BLLAccountManagement.Instance.SearchAccount(tbSearch.Text);
                }
                else
                {
                    Reload();
                }
            }
        }
        private void tbSearch_IconRightClick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbSearch.Text))
            {
                dgvAccount.DataSource = BLLAccountManagement.Instance.SearchAccount(tbSearch.Text);
            }
            else
            {
                Reload();
            }
        }

        //Sort account
        private void cbbSortCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbSearch.Text = null;
            string sortCategory = cbbSortCategory.SelectedItem.ToString();
            bool sortOrder = (cbbSortOrder.SelectedItem.ToString() == "Ascending" ? true : false);
            dgvAccount.DataSource = BLLAccountManagement.Instance.SortAcount(sortCategory, sortOrder);
        }        
        private void cbbSortOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbSearch.Text = null;
            string sortCategory = cbbSortCategory.SelectedItem.ToString();
            bool sortOrder = (cbbSortOrder.SelectedItem.ToString() == "Ascending" ? true : false);
            dgvAccount.DataSource = BLLAccountManagement.Instance.SortAcount(sortCategory, sortOrder);
        }

        //Filter account
        private void cbbFilterCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbFilterValue.Text = null;
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
            dgvAccount.DataSource = BLLAccountManagement.Instance.Fitler_Account(cbbFilterValue.SelectedItem.ToString());
        }


        //
        //Components
        //
        public string SetID(string role)
        {
            if (role == "Admin") tbID.Text = "ad" + tbID.Text;
            if (role == "Stockkeeper") tbID.Text = "sk" + tbID.Text;
            if(role == "Salesman") tbID.Text = "sm" + tbID.Text;
            return tbID.Text;
        }       
        private void tb_TextChanged(object sender, EventArgs e)
        {
            if (tbTel.Text == ""||tbTel.Text.Length != 10||DataCheck.IsNumber(tbTel.Text)!= true|| tbTel.Text[0] != '0') tbTel.IconRightSize = new System.Drawing.Size(7,7);
            else tbTel.IconRightSize = new System.Drawing.Size(0,0);
            if (tbName.Text == ""|| DataCheck.IsString(tbName.Text) != true) tbName.IconRightSize = new System.Drawing.Size(7, 7);
            else tbName.IconRightSize = new System.Drawing.Size(0, 0);
            if (tbUsername.Text == ""|| DataCheck.IsString_1(tbUsername.Text) != true || BLLAccountManagement.Instance.Check_Usename(tbUsername.Text) == false) tbUsername.IconRightSize = new System.Drawing.Size(7, 7);
            else tbUsername.IconRightSize = new System.Drawing.Size(0, 0);
            if (tbAddress.Text == ""||DataCheck.IsString(tbAddress.Text) != true) tbAddress.IconRightSize = new System.Drawing.Size(7, 7);
            else tbAddress.IconRightSize = new System.Drawing.Size(0, 0);
            if (tbPassword.Text == "" || tbPassword.Text.Length < 6) tbPassword.IconRightSize = new System.Drawing.Size(7, 7);
            else tbPassword.IconRightSize = new System.Drawing.Size(0, 0);
        }
    }
}