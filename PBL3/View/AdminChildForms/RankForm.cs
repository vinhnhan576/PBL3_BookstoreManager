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
using PBL3.DTO;
namespace PBL3.View.AdminChildForms
{
    public partial class RankForm : Form
    {
        public RankForm()
        {
            InitializeComponent();
            dgvRank.DataSource = BLLRankManagement.Instance.GetAllRank_View();
            dgvRank.Columns[0].HeaderText = "ID";
            dgvRank.Columns[1].HeaderText = "Name";
            dgvRank.Columns[3].HeaderText = "Customer discount";
            dgvRank.AutoResizeColumns();

            Savebutton.Visible = false;
            ClearButton.Visible = false;
            IDtxt.ReadOnly=true;
            Nametxt.ReadOnly=true;
            Requirementtxt.ReadOnly=true;
            applytxt.ReadOnly=true;
            dgvRank_CellClick(this, new DataGridViewCellEventArgs(0, 0));
        }

        //Show rank info
        private void dgvRank_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRank.SelectedRows.Count == 1)
            {
                IDtxt.Text = dgvRank.SelectedRows[0].Cells["RankID"].Value.ToString();
                Nametxt.Text = dgvRank.SelectedRows[0].Cells["RankName"].Value.ToString();
                Requirementtxt.Text = dgvRank.SelectedRows[0].Cells["Requirement"].Value.ToString();
                applytxt.Text = dgvRank.SelectedRows[0].Cells[3].Value.ToString();
            }
        }        

        //Add rank
        private void Addbutton_Click(object sender, EventArgs e)
        {
            string id = "r" + BLLRankManagement.Instance.GenerateID().ToString();
            IDtxt.Text = id;
            Nametxt.Text = "";
            Requirementtxt.Text = "";
            applytxt.Text = "";
            Savebutton.Visible = true;
            ClearButton.Visible = true;
            IDtxt.ReadOnly = true;
            Nametxt.ReadOnly = false;
            Requirementtxt.ReadOnly = false;
            applytxt.ReadOnly = false;

        }

        //Edit rank
        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRank.SelectedRows.Count == 1)
                {
                    IDtxt.Text = dgvRank.SelectedRows[0].Cells["RankID"].Value.ToString();
                    Nametxt.Text = dgvRank.SelectedRows[0].Cells["RankName"].Value.ToString();
                    Requirementtxt.Text = dgvRank.SelectedRows[0].Cells["Requirement"].Value.ToString();
                    applytxt.Text = dgvRank.SelectedRows[0].Cells[3].Value.ToString();
                    Savebutton.Visible = true;
                    ClearButton.Visible = true;
                    Nametxt.ReadOnly = false;
                    Requirementtxt.ReadOnly = false;
                    applytxt.ReadOnly= false;
                }
                else throw new Exception();
            }
            catch (Exception)
            {
                CustomMessageBox.MessageBox.Show("Please choose only 1 rank to edit", "Error", MessageBoxIcon.Error);
            }
        }

        //Delete rank(s)
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            List<string> del = new List<string>();
            DialogResult result = CustomMessageBox.MessageBox.Show("Are you sure you want to delete this rank(s)?", "Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (dgvRank.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow i in dgvRank.SelectedRows)
                    {
                        del.Add(i.Cells[0].Value.ToString());
                    }
                    BLLRankManagement.Instance.DelRank(del);
                    //cbLopSH.SelectedIndex = 0;
                    dgvRank.DataSource = BLLRankManagement.Instance.GetAllRank_View();
                }
                if (dgvRank.SelectedRows.Count == 1)
                {
                    IDtxt.Text = dgvRank.SelectedRows[0].Cells["RankID"].Value.ToString();
                    Nametxt.Text = dgvRank.SelectedRows[0].Cells["RankName"].Value.ToString();
                    Requirementtxt.Text = dgvRank.SelectedRows[0].Cells["Requirement"].Value.ToString();
                    applytxt.Text = dgvRank.SelectedRows[0].Cells[3].Value.ToString();
                    Savebutton.Visible = false;
                    ClearButton.Visible = false;
                    IDtxt.ReadOnly = false;
                    Nametxt.ReadOnly = false;
                    Requirementtxt.ReadOnly = false;
                    applytxt.ReadOnly = false;
                }
            }
        }

        //Save rank addition/update
        private void Savebutton_Click(object sender, EventArgs e)
        {
            try
            {
                Rank rank = new Rank();
                rank.RankID = IDtxt.Text;
                rank.RankName = Nametxt.Text;
                rank.Requirement = Convert.ToDouble(Requirementtxt.Text);
                rank.CustomerDiscount = Convert.ToDouble(applytxt.Text);
                string message = BLLRankManagement.Instance.Execute(rank);
                dgvRank.DataSource = BLLRankManagement.Instance.GetAllRank_View();
                CustomMessageBox.MessageBox.Show(message, "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Savebutton.Visible = false;
                ClearButton.Visible = false;
                dgvRank_CellClick(this, new DataGridViewCellEventArgs(0, 0));
            }
            catch
            {
                CustomMessageBox.MessageBox.Show("Enter missing information \n or information is not in the right format ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Clear textboxes
        private void ClearButton_Click(object sender, EventArgs e)
        {
            Nametxt.Text = "";
            Requirementtxt.Text = "";
            applytxt.Text = "";
        } 

        //Search rank
        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {

                if (string.IsNullOrWhiteSpace(tbSearch.Text))
                {
                    dgvRank.DataSource = BLLRankManagement.Instance.GetAllRank_View();
                }
                else
                {
                    dgvRank.DataSource = BLLRankManagement.Instance.SearchRank(tbSearch.Text);
                }
            }
        }

        private void tbSearch_IconRightClick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbSearch.Text))
            {
                dgvRank.DataSource = BLLRankManagement.Instance.GetAllRank_View();
            }
            else
            {
                dgvRank.DataSource = BLLRankManagement.Instance.SearchRank(tbSearch.Text);
            }
        }

        //Sort rank
        private void cbbSortOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbSearch.Text = "";
            string sortCategory = cbbSortCategory.SelectedItem.ToString();
            bool sortOrder = (cbbSortOrder.SelectedItem.ToString() == "Ascending" ? true : false);
            dgvRank.DataSource = BLLRankManagement.Instance.SortRank(sortCategory, sortOrder);
        }

        //
        private void tb_TextChanged(object sender, EventArgs e)
        {
            if (Nametxt.Text == "" || DataCheck.IsString(Nametxt.Text) != true) Nametxt.IconRightSize = new System.Drawing.Size(7, 7);
            else Nametxt.IconRightSize = new System.Drawing.Size(0, 0);
            if (Requirementtxt.Text == "" || DataCheck.IsNumber(Requirementtxt.Text) != true) Requirementtxt.IconRightSize = new System.Drawing.Size(7, 7);
            else Requirementtxt.IconRightSize = new System.Drawing.Size(0, 0);
            if (applytxt.Text == "" || DataCheck.IsNumber(applytxt.Text) != true) applytxt.IconRightSize = new System.Drawing.Size(7, 7);
            else applytxt.IconRightSize = new System.Drawing.Size(0, 0);
        }

    }
}
