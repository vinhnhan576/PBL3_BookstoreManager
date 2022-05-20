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
    public partial class OverviewForm : Form
    {
        private Person person;
        public OverviewForm(Person p)
        {
            InitializeComponent();
            person = p;
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            lbName.Text = person.PersonName;
            lbRole.Text = person.Role;
            lbGender.Text = (person.Gender ? "Male" : "Female");
            lbTel.Text = person.PhoneNumber.Trim();
            lbAddress.Text = person.Address;
            lbEmail.Text = (person.Email != null) ? person.Email : "N/A";

            //chartProductSold.DataSource = BLLRevenueManagement.Instance.GetAllRevenue_Chart_View();
            //chartProductSold.Series[0].YValueMembers = "Month";
            //chartProductSold.Series[0].XValueMember = "Total";
            //chartProductSold.DataBind();
        }
    }
}
