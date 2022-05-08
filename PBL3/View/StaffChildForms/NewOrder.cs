using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PBL3.View.StaffChildForms
{
    public partial class NewOrder : Form
    {
        ReceiptManagement bll = new ReceiptManagement();
        public NewOrder()

        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
  
            Receipt_Detail re = new Receipt_Detail() { ReceipDetailtID="re110",ProductID="r0001",SellingQuantity=2,ReceiptID="r005"};
            bll.AddNewReceiptDetail(re);
            Receipt_Detail re1 = new Receipt_Detail() { ReceipDetailtID = "re111", ProductID = "r0002", SellingQuantity = 1, ReceiptID ="r005" };
            bll.AddNewReceiptDetail(re1);
            MessageBox.Show("Add Successfully");

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            guna2DataGridView1.DataSource = bll.GetProductInReceiptByID("r005");
        }
    }
}
