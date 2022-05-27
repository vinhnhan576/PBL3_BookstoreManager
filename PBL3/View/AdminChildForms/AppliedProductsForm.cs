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
    public partial class AppliedProductsForm : Form
    {
        private string DiscountID;
        public AppliedProductsForm(string DiscountID)
        {
            InitializeComponent();
            this.DiscountID = DiscountID;
            dgvProduct.DataSource= BLLDiscountManagement.Instance.ShowAppliedProducts(DiscountID);
        }
    }
}
