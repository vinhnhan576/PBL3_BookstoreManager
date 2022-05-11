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

namespace PBL3.View.AdminChildForms.Product
{
    public partial class ImportHistory : Form
    {
        public ImportHistory(string productName)
        {
            InitializeComponent();
            InitializeData(productName);
        }

        public void InitializeData(string productName)
        {
            dgvProduct.DataSource = BLLProductManagement.Instance.GetAllProduct_Import_View();
            tbProduct.Text = productName;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
