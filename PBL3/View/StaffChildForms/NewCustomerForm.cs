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
using PBL3.Model;
using PBL3.DTO;

namespace PBL3.View.StaffChildForms
{
    public partial class NewCustomerForm : Form
    {
        public delegate void Mydel(string telephone);
        public Mydel d { get; set; }

        public NewCustomerForm()
        {
            InitializeComponent();

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.CustomerName = CustomerNametxt.Text;
            customer.PhoneNumber = Teltxt.Text;
            customer.TotalSpending = 0;
            customer.RankID = "r0";
            customer.Used = 0;
            BLLCustomerManagement.Instance.AddNewCustomer(customer);
            d(Teltxt.Text);
            CustomerNametxt.Text = "";
            Teltxt.Text = "";
            this.Close();
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            int idtemp = QLNS.Instance.Customers.Count() + 1;
            CustomerNametxt.Text = "";
            Teltxt.Text = "";
        }
        private void tb_TextChanged(object sender, EventArgs e)
        {
            if (Teltxt.Text ==""|| Teltxt.Text.Length != 10 || DataCheck.IsNumber(Teltxt.Text) != true || Teltxt.Text[0] != '0') Teltxt.IconRightSize = new System.Drawing.Size(7, 7);
            else Teltxt.IconRightSize = new System.Drawing.Size(0, 0);
            if (CustomerNametxt.Text == "" || DataCheck.IsString(CustomerNametxt.Text) != true) CustomerNametxt.IconRightSize = new System.Drawing.Size(7, 7);
            else CustomerNametxt.IconRightSize = new System.Drawing.Size(0, 0);
        }
    }

}

