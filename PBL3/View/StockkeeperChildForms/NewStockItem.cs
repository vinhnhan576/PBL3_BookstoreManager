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
using PBL3.DTO;

namespace PBL3.View.StockkeeperChildForms
{
    public partial class NewStockItem : Form
    {
        public NewStockItem()
        {
            InitializeComponent();
            dgvProducts.DataSource = BLLProductManagement.Instance.GetAllProduct_Stock_View();
            //rd_list = new List<ReceiptDetailView>();
            var random = new RandomGenerator();
            tbStockID.Text = "rs" + random.RandomNumber(100, 9999);
            tbStockID.Enabled = false;
            tbStockkeperID.Text = "sk001";
            tbStockkeperID.Enabled = false;
            tbTotal.Enabled = false;
            dtpReStock.Value = DateTime.Now;

        }
    }
}
