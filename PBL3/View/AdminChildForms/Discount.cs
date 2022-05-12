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
    public partial class Discount : Form
    {
        public Discount()
        {
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData()
        {
            dgvDiscount.DataSource = BLLDiscountManagement.Instance.GetAllDiscount_View();
        }

        private void Discount_Load(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel11_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }
    }
}
