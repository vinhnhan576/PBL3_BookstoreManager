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

        private DateTime startDate, endDate;
        private int noDays;
        string chartType;

        public int noCustomers { get; private set; }
        public int noProducts { get; private set; }

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

            //chartRevenue.DataSource = BLLRevenueManagement.Instance.GetAllRevenue_Chart_View();
            //chartRevenue.Series[0].YValueMembers = "Total";
            //chartRevenue.Series[0].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            //chartRevenue.Series[0].XValueMember = "Month";
            //chartRevenue.Series[0].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            
        }

        private void getNoItems()
        {
            noCustomers = QLSPEntities.Instance.Customers.Count();
            lbNoCustomer.Text = noCustomers.ToString();
            noProducts = QLSPEntities.Instance.Products.Count();
        }

        private void cbbSortCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category = cbbSortCategory.SelectedItem.ToString();
            switch (category)
            {
                case "This Week":
                    chartType = "Week";
                    break;
                case "This Month":
                    chartType = "Month";
                    break;
                case "This Year":
                    startDate = new DateTime(DateTime.Now.Year, 1, 1, 0, 0, 0);
                    endDate = DateTime.Now;
                    chartType = "Year";
                    break;
            }
            LoadChart();
        }

        private void LoadChart()
        {
            switch (chartType)
            {
                case "Day":
                    break;
                case "Week":
                    MessageBox.Show(chartType);
                    break;
                case "Month":
                    MessageBox.Show(chartType);
                    break;
                case "Year":
                    var points = BLLRevenueManagement.Instance.GetAllRevenueByDate_ChartView(startDate, endDate, chartType);
                    int[] N = new int[points.Count];
                    double[] M = new double[points.Count];
                    int i = 0;
                    foreach (var item in points)
                    {
                        N[i] = item.date.Month;
                        MessageBox.Show(item.date.Month.ToString());
                        M[i] = item.total;
                        i++;
                    }
                    chartRevenue.Series[0].Points.DataBindXY(N, M);
                    break;
            }


        }


    }
}
