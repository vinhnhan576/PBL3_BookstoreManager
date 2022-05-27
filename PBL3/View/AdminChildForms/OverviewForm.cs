using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.Model;
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

            activateButton(btnThisYear);
            startDate = BLLRevenueManagement.Instance.GetFirstDate();
            endDate = DateTime.Now;
            chartType = "Year";
            LoadChart();
            setNoItems();
        }

        private void setNoItems()
        {
            lbNoCustomer.Text = BLLRevenueManagement.Instance.GetAllVisitors(startDate, endDate).ToString();
            lbProducts.Text = BLLRevenueManagement.Instance.GetAllNOProductsSold(startDate, endDate).ToString();
            lbGrossRevenue.Text = BLLRevenueManagement.Instance.GetTotalGrossRevenue(startDate, endDate).ToString();
        }

        private void activateButton(object sender)
        {
            disableButtons();
            ((Guna.UI2.WinForms.Guna2Button)sender).FillColor = Color.FromArgb(21, 134, 183);
            ((Guna.UI2.WinForms.Guna2Button)sender).ForeColor = Color.White;
        }

        private void disableButtons()
        {
            foreach (Control otherButtons in pnTime.Controls)
            {
                if (otherButtons.GetType() == typeof(Guna.UI2.WinForms.Guna2Button))
                {
                    ((Guna.UI2.WinForms.Guna2Button)otherButtons).FillColor = Color.White;
                    otherButtons.ForeColor = Color.FromArgb(21, 134, 183);
                }
            }
        }

        private void btnThisWeek_Click(object sender, EventArgs e)
        {
            activateButton(sender);
            startDate = DateTime.Now.StartOfWeek(DayOfWeek.Monday);
            endDate = DateTime.Now;
            chartType = "Week";
            LoadChart();
            setNoItems();
        }

        private void btnThisYear_Click(object sender, EventArgs e)
        {
            activateButton(sender);
            startDate = BLLRevenueManagement.Instance.GetFirstDate();
            endDate = DateTime.Now;
            chartType = "Year";
            LoadChart();
            setNoItems();
        }

        private void LoadChart()
        {   
            if(chartType == "Week")
            {
                var points = BLLRevenueManagement.Instance.GetAllRevenueByDate_ChartView(startDate, endDate, chartType);
                int[] N = new int[points.Count];
                double[] M = new double[points.Count];
                int i = 0;
                foreach (var item in points)
                {
                    N[i] = item.date.Day;
                    M[i] = item.total;
                    i++;
                }
                chartRevenue.Series[0].Points.DataBindXY(N, M);
            }
            if(chartType == "Year")
            {
                var points = BLLRevenueManagement.Instance.GetAllRevenueByDate_ChartView(startDate, endDate, chartType);
                int[] N = new int[points.Count];
                double[] M = new double[points.Count];
                int i = 0;
                foreach (var item in points)
                {
                    N[i] = item.date.Month;
                    M[i] = item.total;
                    i++;
                }
                chartRevenue.Series[0].Points.DataBindXY(N, M);
            }
        }
    }

    public static class DateTimeExtensions
    {
        public static DateTime StartOfWeek(this DateTime dt, DayOfWeek startOfWeek)
        {
            int diff = (7 + (dt.DayOfWeek - startOfWeek)) % 7;
            return dt.AddDays(-1 * diff).Date;
        }
    }
}
