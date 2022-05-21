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
    public partial class StockForm : Form
    {
        public StockForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            dgvStock.DataSource = BLLRestockManagement.Instance.GetAllRestockDetail_View();
            dgvProduct.DataSource = BLLRestockManagement.Instance.GetAllProduct_StockView();
        }
    }
}
