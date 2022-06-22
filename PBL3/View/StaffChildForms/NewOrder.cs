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
using PBL3.Model;
namespace PBL3.View.StaffChildForms
{
    public partial class NewOrder : Form
    {
        private List<ReceiptDetailView> rd_list;
        private Order order;
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
            //rd_list = new List<ReceiptDetailView>();
            var random = new RandomGenerator();
            OrderIDtxt.ReadOnly = true;
            SalesmanIDtxt.ReadOnly = true;
            TotalOrdertxt.ReadOnly = true;
            discountxt.ReadOnly = true;
            LoadNewOrder();
        }

        
        /// <summary>
        /// CRUD
        /// </summary>
        /// <param name="total"></param>
        // Save order
        private void Save(double total)
        {
            try
            {
                Receipt receipt = new Receipt();
                receipt.ReceiptID = OrderIDtxt.Text;
                receipt.PersonID = account.PersonID;
                receipt.Date = DateTime.Now;
                receipt.Total = total;
                receipt.Status = true;
                if (CustomerTeltxt.IconRightSize == new System.Drawing.Size(7, 7))
                    throw new Exception("Invalid phone number input");
                else if(!string.IsNullOrWhiteSpace(CustomerTeltxt.Text))
                {
                    Customer customer = BLLCustomerManagement.Instance.getCustomer(CustomerTeltxt.Text.Trim());
                    receipt.PhoneNumber = customer.PhoneNumber;
                    BLLCustomerManagement.Instance.SaveCustomer(customer, total);
                }
                //receipt.CustomerID = (QLSPEntities.Instance.Customers.Count() + 1).ToString();
                BLLReceiptManagement.Instance.AddNewReceipt(receipt);
                BLLReceiptManagement.Instance.AddNewReceiptDetail(this.order, OrderIDtxt.Text);
                for (int i = 0; i < this.order.Rdv_List.Count; i++)
                {
                    string productID = this.order.Rdv_List[i].ProductID;
                    int prodQuantity = this.order.Rdv_List[i].Quantity;
                    BLLProductManagement.Instance.DecreaseStoreQuantity(productID, prodQuantity);
                    double expenses = BLLRestockManagement.Instance.GetRestockDetailByProductID(productID).ImportPrice * prodQuantity;
                    double grossRevenue = this.order.Rdv_List[i].Total;
                    double profit = (grossRevenue / expenses - 1) * 100;
                    profit = (double)Math.Round(profit * 100f) / 100f;
                    BLLRevenueManagement.Instance.AddRevenue(this.order.Rdv_List[i].ReceiptDetailID, expenses, grossRevenue, profit);
                }
            }
            catch (FormatException)
            {
                CustomMessageBox.MessageBox.Show("Please re-enter phone number", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //catch (Exception ex)
            //{
            //    CustomMessageBox.MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //rd_list.Clear();
            //rdDataGridView.DataSource = rd_list.ToList();
            //OrderIDtxt.Text = "";
            //SalesmanIDtxt.Text = "";
            //Totaltxt.Text = "";
            //ProductDataGridView.DataSource = BLLProductManagement.Instance.GetAllProduct_Order_View();
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
              try
              {
                    Customer customer = BLLCustomerManagement.Instance.getCustomer(CustomerTeltxt.Text.Trim());
                    //MessageBox.Show(customer.Rankid);
                    double total = Convert.ToDouble(TotalOrdertxt.Text);
                    if (customer != null && customer.RankID != "r0")
                    {
                    total = total - customer.Rank.CustomerDiscount;
                    if (total < 0) total = 0;
                        if (customer.IsValidDiscount(2) == true && customer.RankID.Trim() != "r0")
                        {
                            string message = "You have " + (2 - customer.Used) + " voucher " + customer.Rank.CustomerDiscount + "VND" +
                            "\nYour total after using this discount: " + total +
                            "\nDo you want to get a discount?";
                            string title = "Notification";
                            DialogResult result = CustomMessageBox.MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                Save(total);
                                BLLCustomerManagement.Instance.UpdateUsed(customer.PhoneNumber);
                            }
                            else if (result == DialogResult.No)
                            {
                                Save(Convert.ToDouble(TotalOrdertxt.Text));
                            }
                        }
                        else
                        {
                            Save(Convert.ToDouble(TotalOrdertxt.Text));
                        }
                    }

                    else
                    {
                        Save(Convert.ToDouble(TotalOrdertxt.Text));
                    }

                    this.order.Rdv_List.Clear();
                    dgvOrder.DataSource = this.order.Rdv_List.ToList();
                    OrderIDtxt.Text = "";
                    SalesmanIDtxt.Text = "";
                    TotalOrdertxt.Text = "";
                    discountxt.Text = "";
                    dgvProduct.DataSource = BLLProductManagement.Instance.GetAllProduct_OrderView();
                    LoadNewOrder();
              }
              catch (FormatException ex)
            {
                View.CustomMessageBox.MessageBox.Show("Invalid data input", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (NullReferenceException ex)
            {
                View.CustomMessageBox.MessageBox.Show("Not enough information", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void LoadNewOrder()
        {
            OrderIDtxt.Text = "rpt" + (QLNS.Instance.Receipts.Count() + 1).ToString();
            SalesmanIDtxt.Text = account.PersonID.Trim();
            CustomerTeltxt.Text = null;
            TotalOrdertxt.Text = null;
            OrderDateTimePicker.Value = DateTime.Now;
            order = new Order();
        }

        // Add product to order
        private void AddButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                Customer customer = BLLCustomerManagement.Instance.getCustomer(CustomerTeltxt.Text.Trim());
                Product product_temp;
                if (dgvProduct.SelectedRows.Count == 1)
                {
                    string productName = dgvProduct.SelectedRows[0].Cells["ProductName"].Value.ToString();
                    product_temp = BLLProductManagement.Instance.GetProductByProductName(productName);
                    if (!Quantitytxt.Text.All(c => c >= '0' && c <= '9'))
                        throw new Exception("Invalid quantity input");
                    else if (Convert.ToInt32(Quantitytxt.Text) > product_temp.StoreQuantity)
                        throw new Exception("Input quantity exceeds product's store quantity!");
                    else
                        BLLReceiptManagement.Instance.CreateReceiptDetailView(order, product_temp, Convert.ToInt32(Quantitytxt.Text));
                }
                else 
                    throw new Exception("Please choose only one product to add");
                double total = BLLReceiptManagement.Instance.CalculateReceiptToTal(order);
                dgvOrder.DataSource = this.order.Rdv_List.ToList();
                //dgvOrder.DataSource = BLLDiscountManagement.Instance.GetListAfterSingleDiscount(rd_list);
                TotalOrdertxt.Text = total.ToString();
                discountxt.Text = BLLReceiptManagement.Instance.getPromotedDiscount(order).ToString();
                Quantitytxt.Text = null;
            }
            catch (FormatException ex)
            {
                CustomMessageBox.MessageBox.Show("Please enter product selling quantity", "Add failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch(Exception ex)
            {
                CustomMessageBox.MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Quantitytxt.Text = null;
            }
        }
        // Check phone number
        private void tb_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(CustomerTeltxt.Text))
                CustomerTeltxt.IconRightSize = new System.Drawing.Size(0, 0);
            else if (CustomerTeltxt.Text.Trim().Length != 10 || DataCheck.IsNumber(CustomerTeltxt.Text.Trim()) != true || CustomerTeltxt.Text[0] != '0')
                CustomerTeltxt.IconRightSize = new System.Drawing.Size(7, 7);
            else
                CustomerTeltxt.IconRightSize = new System.Drawing.Size(0, 0);
        }
        // Add new customer
        private void NewCustomerButton_Click_1(object sender, EventArgs e)
        {
            NewCustomerForm form = new NewCustomerForm();
            form.d = new NewCustomerForm.Mydel(GetCustomerTel);
            form.ShowDialog();
        }
        private void GetCustomerTel(string telephone)
        {
            CustomerTeltxt.Text = telephone;
        }
        // Check phone number
        private void CustomerTeltxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (!BLLCustomerManagement.Instance.Customer_Check(CustomerTeltxt.Text))
                {
                    View.CustomMessageBox.MessageBox.Show("Telephone number doesn't exist", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string tel = BLLCustomerManagement.Instance.getCustomer(CustomerTeltxt.Text).CustomerName.ToString();
                    View.CustomMessageBox.MessageBox.Show(tel, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // Delete receipt details
        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (dgvOrder.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dgvOrder.SelectedRows.Count; i++)
                {
                    this.order.RemoveAt(i);
                }
            }
            dgvOrder.DataSource = this.order.Rdv_List.ToList();
            TotalOrdertxt.Text = BLLReceiptManagement.Instance.CalculateReceiptToTal(order).ToString();
            discountxt.Text = BLLReceiptManagement.Instance.getPromotedDiscount(order).ToString();
        }

        // Clear data
        private void Clearbtn_Click(object sender, EventArgs e)
        {
            this.order.Rdv_List.Clear();
            dgvOrder.DataSource = this.order.Rdv_List.ToList();
            TotalOrdertxt.Text = "";
        }


        /// <summary>
        /// SEARCH SORT FILTER
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        // Search
        private void productSearchtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if(string.IsNullOrWhiteSpace(productSearchtxt.Text))
                    dgvProduct.DataSource = BLLProductManagement.Instance.GetAllProduct_OrderView();
                else
                    dgvProduct.DataSource = BLLProductManagement.Instance.SearchProduct_Order(productSearchtxt.Text);

            }
        }
        private void productSearchtxt_IconRightClick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(productSearchtxt.Text))
                dgvProduct.DataSource = BLLProductManagement.Instance.GetAllProduct_OrderView();
            else
                dgvProduct.DataSource = BLLProductManagement.Instance.SearchProduct_Order(productSearchtxt.Text);
        }

        // Filter
        private void cbbFilterCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbFilterValue.Text = "";
            cbbFilterValue.Items.Clear();
            string filterCategory = cbbFilterCategory.SelectedItem.ToString();
            if(filterCategory == "All")
            {
                dgvProduct.DataSource = BLLProductManagement.Instance.GetAllProduct_OrderView();
            }
            if (filterCategory == "Category")
            {
                foreach (string i in BLLProductManagement.Instance.GetAllProductCategory().Distinct())
                {
                    cbbFilterValue.Items.Add(i);
                }
            }
            if (filterCategory == "Status")
            {
                foreach (string i in BLLProductManagement.Instance.GetAllProductAuthor().Distinct())
                {
                    if(i != null)
                        cbbFilterValue.Items.Add(i);
                }
            }
        }
        private void cbbFilterValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvProduct.DataSource = BLLProductManagement.Instance.FilterProduct(cbbFilterValue.SelectedItem.ToString());
        }


        //private void SaveCustomer(Customer customer,double total)
        //{
        //    BLLCustomerManagement.Instance.UpdateTotalSpending(customer.PhoneNumber,total);
        //    double totaltemp = (double)customer.TotalSpending;
        //    string rankID = BLLRankManagement.Instance.GetRankIDByReQuirement(totaltemp);
        //    BLLCustomerManagement.Instance.UpdateRankCustomer(customer.PhoneNumber, rankID);
        //}
    }
}
