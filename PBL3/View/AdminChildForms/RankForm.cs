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
            Savebutton.Visible = false;
            ClearButton.Visible = false;
            IDtxt.ReadOnly=true;
            Nametxt.ReadOnly=true;
            Requirementtxt.ReadOnly=true;
            applytxt.ReadOnly=true;
        }

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
        private void Addbutton_Click(object sender, EventArgs e)
        {
            string idtemp = (QLNS.Instance.Ranks.Count() + 1).ToString();
            IDtxt.Text = "r" + idtemp;
            Nametxt.Text = "";
            Requirementtxt.Text = "";
            applytxt.Text = "";
            Savebutton.Visible = true;
            ClearButton.Visible = true;
            IDtxt.ReadOnly = false;
            Nametxt.ReadOnly = false;
            Requirementtxt.ReadOnly = false;
            applytxt.ReadOnly = false;

        }
        private void EditButton_Click(object sender, EventArgs e)
        {
            if (dgvRank.SelectedRows.Count == 1)
            {
                IDtxt.Text = dgvRank.SelectedRows[0].Cells["RankID"].Value.ToString();
                Nametxt.Text = dgvRank.SelectedRows[0].Cells["RankName"].Value.ToString();
                Requirementtxt.Text = dgvRank.SelectedRows[0].Cells["Requirement"].Value.ToString();
                applytxt.Text = dgvRank.SelectedRows[0].Cells[3].Value.ToString();
                Savebutton.Visible = true;
                ClearButton.Visible = true;
                IDtxt.ReadOnly = false;
                Nametxt.ReadOnly = false;
                Requirementtxt.ReadOnly = false;
                applytxt.ReadOnly = false;
            }
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            try
            {
                Rank rank = new Rank();
                rank.RankID = IDtxt.Text;
                rank.RankName = Nametxt.Text;
                rank.Requirement = Convert.ToDouble(Requirementtxt.Text);
                rank.CustomerDiscount = Convert.ToDouble(applytxt.Text);
                BLLRankManagement.Instance.Execute(rank);
                dgvRank.DataSource = BLLRankManagement.Instance.GetAllRank_View();
                View.CustomMessageBox.MessageBox.Show("Rank is added successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                View.CustomMessageBox.MessageBox.Show("Enter missing information \n or information is not in the right format ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Nametxt.Text = "";
            Requirementtxt.Text = "";
            applytxt.Text = "";
        } 
        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                dgvRank.DataSource = BLLRankManagement.Instance.SearchRank(tbSearch.Text);
            }
        }
        private void cbbSortOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbSearch.Text = "";
            string sortCategory = cbbSortCategory.SelectedItem.ToString();
            bool sortOrder = (cbbSortOrder.SelectedItem.ToString() == "Ascending" ? true : false);
            dgvRank.DataSource = BLLRankManagement.Instance.SortRank(sortCategory, sortOrder);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            List<string> del = new List<string>();
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
        }
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
