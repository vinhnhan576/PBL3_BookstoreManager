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
using PBL3.View;

namespace PBL3.View.StaffChildForms
{
    public partial class NewOrder : Form
    {
        private List<ReceiptDetailView> rd_list;
        private Account account;
        public NewOrder(Account acc)
        {
            InitializeComponent();
            account = acc;
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            dgvProduct.DataSource = BLLProductManagement.Instance.GetAllProduct_OrderView();
            rd_list = new List<ReceiptDetailView>();
            var random = new RandomGenerator();
            OrderIDtxt.Text = "rpt" + (QLSPEntities.Instance.Receipts.Count() + 1).ToString();
            OrderIDtxt.Enabled = false;
            SalesmanIDtxt.Text = account.PersonID;
            SalesmanIDtxt.Enabled = false;
            Totaltxt.Text = "0";
            Totaltxt.Enabled = false;
            OrderDateTimePicker.Value = DateTime.Now;
        }
        private void SaveCustomer(Customer customer,double total)
        {
            BLLCustomerManagement.Instance.UpdateTotalSpending(customer.PhoneNumber,total);
            double totaltemp = (double)customer.TotalSpending;
            string rankID = BLLRankManagement.Instance.GetRankIDByReQuirement(totaltemp);
            BLLCustomerManagement.Instance.UpdateRankCustomer(customer.CustomerID, rankID);
        }
        
        private void Save(double total)
        {
            Receipt receipt = new Receipt();
            receipt.ReceiptID = OrderIDtxt.Text;
            receipt.PersonID = SalesmanIDtxt.Text;
            receipt.Date = DateTime.Now;
            receipt.Total = total;
            if (CustomerTeltxt.Text != "")
            {
                Customer customer = BLLCustomerManagement.Instance.getCustomerID(CustomerTeltxt.Text.Trim());
                receipt.CustomerID = customer.CustomerID;
                BLLCustomerManagement.Instance.SaveCustomer(customer, total);
            }
            //receipt.CustomerID = (QLSPEntities.Instance.Customers.Count() + 1).ToString();
            BLLReceiptManagement.Instance.AddNewReceipt(receipt);
            BLLReceiptManagement.Instance.AddNewReceiptDetail(rd_list, OrderIDtxt.Text);
            for (int i = 0; i < rd_list.Count; i++)
            {
                string productID = rd_list[i].ProductID;
                int prodQuantity = rd_list[i].Quantity;
                BLLProductManagement.Instance.DecreaseStoreQuantity(productID, prodQuantity);
                double expenses = BLLRestockManagement.Instance.GetRestockDetailByProductID(productID).ImportPrice * prodQuantity;
                double grossRevenue = rd_list[i].Total;
                double profit = (grossRevenue / expenses - 1) * 100;
                profit = (double)Math.Round(profit * 100f) / 100f;
                BLLRevenueManagement.Instance.AddRevenue(rd_list[i].ReceiptDetailID, expenses, grossRevenue, profit);
            }
            //rd_list.Clear();
            //rdDataGridView.DataSource = rd_list.ToList();
            //OrderIDtxt.Text = "";
            //SalesmanIDtxt.Text = "";
            //Totaltxt.Text = "";
            //ProductDataGridView.DataSource = BLLProductManagement.Instance.GetAllProduct_Order_View();
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            Customer customer = BLLCustomerManagement.Instance.getCustomerID(CustomerTeltxt.Text.Trim());
            double total = Convert.ToDouble(Totaltxt.Text);
            if(customer != null)
            {
                total = total - customer.Rank.CustomerDiscount;
                if (total < 0) total = 0;
                if (customer.IsValidDiscount(2) == true && customer.RankID.Trim() != "r00")
                {
                    string message = "You have " + (2 - customer.Used) + " voucher " + customer.Rank.CustomerDiscount + "VND" +
                    "\nYour total after using this discount: " + total +
                    "\nDo you want to get a discount?";
                    string title = "Notification";
                    DialogResult result = CustomMessageBox.MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        Save(total);
                        BLLCustomerManagement.Instance.UpdateUsed(customer.CustomerID);
                    }
                    else if (result == DialogResult.No)
                    {
                        Save(Convert.ToDouble(Totaltxt.Text));
                    }
                }
                else if (customer.RankID.Trim() == "r00")
                {
                    Save(Convert.ToDouble(Totaltxt.Text));
                }
            }

            else
            {
                Save(Convert.ToDouble(Totaltxt.Text));
            }


           
            rd_list.Clear();
            dgvOrder.DataSource = rd_list.ToList();
            OrderIDtxt.Text = "";
            SalesmanIDtxt.Text = "";
            Totaltxt.Text = "";
            dgvProduct.DataSource = BLLProductManagement.Instance.GetAllProduct_Order_View();

            LoadNewOrder();
        }

        private void AddButton_Click_1(object sender, EventArgs e)
        {
            Customer customer = BLLCustomerManagement.Instance.getCustomerID(CustomerTeltxt.Text.Trim());
            string product_temp;
            if (dgvProduct.SelectedRows.Count == 1)
            {
                string productName = dgvProduct.SelectedRows[0].Cells["ProductName"].Value.ToString();
                product_temp = BLLProductManagement.Instance.GetProductByProductName(productName).ProductID;
                rd_list = BLLReceiptManagement.Instance.CreateReceiptDetailView(rd_list, product_temp, Convert.ToInt32(Quantitytxt.Text));
            }
            dgvOrder.DataSource = this.rd_list.ToList();
            Totaltxt.Text = BLLReceiptManagement.Instance.CalculateReceiptToTal(rd_list).ToString();
            //if (CustomerTeltxt.Text != "")
            //{
            //    double totalspending = (double)customer.TotalSpending + Convert.ToDouble(Totaltxt.Text);
            //}
            Quantitytxt.Text = "";
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            //List<string> del = new List<string>();
            if (dgvOrder.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dgvOrder.SelectedRows.Count; i++)
                {
                    rd_list.RemoveAt(i);

                }
            }
            dgvOrder.DataSource = rd_list.ToList();
            Totaltxt.Text = BLLReceiptManagement.Instance.CalculateReceiptToTal(rd_list).ToString();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            rd_list.Clear();
            dgvOrder.DataSource = rd_list.ToList();
            Totaltxt.Text = BLLReceiptManagement.Instance.CalculateReceiptToTal(rd_list).ToString();
        }

        private void NewOrderButton_Click(object sender, EventArgs e)
        {
            LoadNewOrder();
        }

        private void LoadNewOrder()
        {
            OrderIDtxt.Text = "rpt" + (QLSPEntities.Instance.Receipts.Count() + 1).ToString();
            SalesmanIDtxt.Text = "sm001";
            CustomerTeltxt.Text = "";
            OrderDateTimePicker.Value = DateTime.Now;
        }

        private void productSearchtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                dgvProduct.DataSource = BLLProductManagement.Instance.SearchProduct_Order(productSearchtxt.Text);
            }
        }
        private void GetCustomerTel(string telephone)
        {
            CustomerTeltxt.Text = telephone;
        }

        private void NewCustomerButton_Click_1(object sender, EventArgs e)
        {
            NewCustomerForm form = new NewCustomerForm();
            form.d = new NewCustomerForm.Mydel(GetCustomerTel);
            form.ShowDialog();
        }


        private void cbbFilterCategory_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cbbFilterValue.Text = "";
            cbbFilterValue.Items.Clear();
            string filterCategory = cbbFilterCategory.SelectedItem.ToString();
            if (filterCategory == "Category")
            {
                foreach (string i in BLLProductManagement.Instance.GetAllProductCategory().Distinct())
                {
                    cbbFilterValue.Items.Add(i);
                    //MessageBox.Show("i");
                }
            }
            if (filterCategory == "Author")
            {
                foreach (string i in BLLProductManagement.Instance.GetAllProductAuthor().Distinct())
                {
                    cbbFilterValue.Items.Add(i);
                }
            }


        }

        private void cbbFilterValue_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            dgvProduct.DataSource = BLLProductManagement.Instance.SearchProduct(cbbFilterValue.SelectedItem.ToString());

        }

         private void CustomerTeltxt_KeyPress(object sender, KeyPressEventArgs e)
         {
            if (e.KeyChar == (char)13)
            {
                if (!BLLCustomerManagement.Instance.Customer_Check(CustomerTeltxt.Text))
                {
                    MessageBox.Show("Telephone Number doesn't exist");

                }
                else
                {
                    
                }
            }

        }
    }
}
