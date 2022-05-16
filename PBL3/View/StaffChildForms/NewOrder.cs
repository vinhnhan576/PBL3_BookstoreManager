        private void InitializeGUI()
        {
            ProductDataGridView.DataSource = BLLProductManagement.Instance.GetAllProduct_View();
            rd_list = new List<ReceiptDetailView>();
            var random = new RandomGenerator();
            OrderIDtxt.Text = "rpt" + random.RandomNumber(100, 9999);
            OrderIDtxt.Enabled = false;
            SalesmanIDtxt.Text = "sm001";
            SalesmanIDtxt.Enabled = false;
            Totaltxt.Enabled = false;
            OrderDateTimePicker.Value = DateTime.Now;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Receipt receipt = new Receipt();
            receipt.ReceiptID = OrderIDtxt.Text;
            receipt.PersonID = SalesmanIDtxt.Text;
            receipt.Date=DateTime.Now;
            receipt.Total = Convert.ToInt32(Totaltxt.Text);
            BLLReceiptManagement.Instance.AddNewReceipt(receipt);
            BLLReceiptManagement.Instance.AddNewReceiptDetail(rd_list, OrderIDtxt.Text);
            for(int i = 0; i < rd_list.Count; i++)
            {
                string productID = rd_list[i].ProductID;
                int prodQuantity = rd_list[i].Quantity;
                BLLProductManagement.Instance.DecreaseStoreQuantity(productID, prodQuantity);

                double expenses = BLLProductManagement.Instance.GetProductByID(productID).Restocks.Last().ImportPrice * prodQuantity;
                double grossRevenue = rd_list[i].Total;
                double profit = (grossRevenue / expenses - 1) * 100;
                profit = (double)Math.Round(profit * 100f) / 100f;
                BLLRevenueManagement.Instance.AddRevenue(rd_list[i].ReceiptDetailID, expenses, grossRevenue, profit);
            }

            rd_list.Clear();
            rdDataGridView.DataSource = rd_list.ToList();
            OrderIDtxt.Text = "";
            SalesmanIDtxt.Text = "";
        }

        private void AddButton_Click_1(object sender, EventArgs e)
        {
            ReceiptDetailView rd_temp = new ReceiptDetailView();
            string product_temp;
            int count = 1;

            if (ProductDataGridView.SelectedRows.Count == 1)
            {
                product_temp = ProductDataGridView.SelectedRows[0].Cells["ProductID"].Value.ToString();
                rd_temp = BLLReceiptManagement.Instance.CreateReceiptDetailView(
                    product_temp, Convert.ToInt32(Quantitytxt.Text.ToString()), count++);
                this.rd_list.Add(rd_temp);
            }
            rdDataGridView.DataSource = this.rd_list.ToList();
            Totaltxt.Text = BLLReceiptManagement.Instance.CalculateReceiptToTal(rd_list).ToString();
            Quantitytxt.Text = "";
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            //List<string> del = new List<string>();
            if (rdDataGridView.SelectedRows.Count > 0)
            {
                for (int i=0; i<rdDataGridView.SelectedRows.Count;i++)
                {
                    rd_list.RemoveAt(i);
                    
                }
            }
            rdDataGridView.DataSource = rd_list.ToList();
            Totaltxt.Text = BLLReceiptManagement.Instance.CalculateReceiptToTal(rd_list).ToString();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        private void AddButton_Click(object sender, EventArgs e)
        {
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


namespace PBL3.View.StaffChildForms
{
    public partial class NewOrder : Form
    {
        private List<ReceiptDetailView> rd_list;
        public NewOrder()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            ProductDataGridView.DataSource = BLLProductManagement.Instance.GetAllProduct_View();
            rd_list = new List<ReceiptDetailView>();
            var random = new RandomGenerator();
            OrderIDtxt.Text = "rpt" + random.RandomNumber(100, 9999);
            OrderIDtxt.Enabled = false;
            SalesmanIDtxt.Text = "sm001";
            SalesmanIDtxt.Enabled = false;
            Totaltxt.Enabled = false;
            OrderDateTimePicker.Value = DateTime.Now;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Receipt receipt = new Receipt();
            receipt.ReceiptID = OrderIDtxt.Text;
            receipt.PersonID = SalesmanIDtxt.Text;
            receipt.Date = DateTime.Now;
            receipt.Total = Convert.ToInt32(Totaltxt.Text);
            BLLReceiptManagement.Instance.AddNewReceipt(receipt);
            BLLReceiptManagement.Instance.AddNewReceiptDetail(rd_list, OrderIDtxt.Text);
            for (int i = 0; i < rd_list.Count; i++)
            {
                string productID = rd_list[i].ProductID;
                int prodQuantity = rd_list[i].Quantity;
                BLLProductManagement.Instance.DecreaseStoreQuantity(productID, prodQuantity);

                double expenses = BLLProductManagement.Instance.GetProductByID(productID).Restocks.Last().ImportPrice * prodQuantity;
                double grossRevenue = rd_list[i].Total;
                double profit = (grossRevenue / expenses - 1) * 100;
                profit = (double)Math.Round(profit * 100f) / 100f;
                BLLRevenueManagement.Instance.AddRevenue(rd_list[i].ReceiptDetailID, expenses, grossRevenue, profit);
            }

            rd_list.Clear();
            rdDataGridView.DataSource = rd_list.ToList();
            OrderIDtxt.Text = "";
            SalesmanIDtxt.Text = "";
        }

        private void AddButton_Click_1(object sender, EventArgs e)
        {
            ReceiptDetailView rd_temp = new ReceiptDetailView();
            string product_temp;
            int count = 1;

            if (ProductDataGridView.SelectedRows.Count == 1)
            {
                product_temp = ProductDataGridView.SelectedRows[0].Cells["ProductID"].Value.ToString();
                rd_temp = BLLReceiptManagement.Instance.CreateReceiptDetailView(
                    product_temp, Convert.ToInt32(Quantitytxt.Text.ToString()), count++);
                this.rd_list.Add(rd_temp);
            }
            rdDataGridView.DataSource = this.rd_list.ToList();
            Totaltxt.Text = BLLReceiptManagement.Instance.CalculateReceiptToTal(rd_list).ToString();
            Quantitytxt.Text = "";
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            //List<string> del = new List<string>();
            if (rdDataGridView.SelectedRows.Count > 0)
            {
                for (int i = 0; i < rdDataGridView.SelectedRows.Count; i++)
                {
                    rd_list.RemoveAt(i);

                }
            }
            rdDataGridView.DataSource = rd_list.ToList();
            Totaltxt.Text = BLLReceiptManagement.Instance.CalculateReceiptToTal(rd_list).ToString();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            rd_list.Clear();
            rdDataGridView.DataSource = rd_list.ToList();
            Totaltxt.Text = BLLReceiptManagement.Instance.CalculateReceiptToTal(rd_list).ToString();
        }

        private void NewOrderButton_Click(object sender, EventArgs e)
        {
            var random = new RandomGenerator();
            OrderIDtxt.Text = "rpt" + random.RandomNumber(100, 9999);
            SalesmanIDtxt.Text = "sm001";
            OrderDateTimePicker.Value = DateTime.Now;

        }

        private void productSearchtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                ProductDataGridView.DataSource = BLLProductManagement.Instance.SearchProduct_Order(productSearchtxt.Text);
            }

        }
    }
}
