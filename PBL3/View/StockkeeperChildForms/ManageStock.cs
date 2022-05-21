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

namespace PBL3.View.StockkeeperChildForms
{
    public partial class ManageStock : Form
    {
        public ManageStock()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            dgvStock.DataSource = BLLRestockManagement.Instance.GetAllRestockDetail_View();
        }
    }
}
