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

namespace PBL3.View.StaffChildForms
{
    public partial class NewCustomerForm : Form
    {
        public delegate void Mydel(string telephone);
        public Mydel d { get; set; }

        public NewCustomerForm()
        {
            InitializeComponent();
            int idtemp = QLSPEntities.Instance.Customers.Count() + 1;
            CustomerIDtxt.Text = "000" + idtemp.ToString();

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.CustomerID = CustomerIDtxt.Text;
            customer.CustomerName = CustomerNametxt.Text;
            customer.PhoneNumber = Teltxt.Text;
            customer.TotalSpending = 0;
            BLLCustomerManagement.Instance.AddNewCustomer(customer);
            d(Teltxt.Text);
            int idtemp1 = QLSPEntities.Instance.Customers.Count() + 1;
            CustomerIDtxt.Text = "00" + idtemp1.ToString();
            CustomerNametxt.Text = "";
            Teltxt.Text = "";
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            int idtemp = QLSPEntities.Instance.Customers.Count() + 1;
            CustomerIDtxt.Text = "00" + idtemp.ToString();
            CustomerNametxt.Text = "";
            Teltxt.Text = "";
        }
    }

}

