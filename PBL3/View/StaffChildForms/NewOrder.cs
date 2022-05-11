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


namespace PBL3.View.StaffChildForms
{
    public partial class NewOrder : Form
    {
        public NewOrder()

        {
            InitializeComponent();
            ProductDataGridView.DataSource = BLLProductManagement.Instance.GetAllProduct_Order_View();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (ProductDataGridView.SelectedRows.Count == 1)
            {
                string ProductID = ProductDataGridView.SelectedRows[0].Cells["ProductID"].Value.ToString(); 

            }
        }
    }
}
