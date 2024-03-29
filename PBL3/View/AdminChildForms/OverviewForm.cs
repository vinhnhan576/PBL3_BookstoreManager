﻿using System;
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
        string chartType;

        public int noCustomers { get; private set; }
        public int noProducts { get; private set; }

        /// <summary>
        /// INITIALIZE
        /// </summary>
        /// <param name="p"></param>
        public OverviewForm(Person p)
        {
            InitializeComponent();
            person = p;
            InitializeGUI();
        }   
        private void InitializeGUI()
        {
            // Admin personal info
            lbName.Text = person.PersonName;
            lbRole.Text = person.Role;
            lbGender.Text = (person.Gender ? "Male" : "Female");
            lbTel.Text = person.PhoneNumber.Trim();
            lbAddress.Text = person.Address;
            lbEmail.Text = (person.Email != null) ? person.Email : "N/A";

            LoadTopStaffs();

            // chartRevenue
            activateButton(btnThisYear);
            startDate = BLLRevenueManagement.Instance.GetFirstDate();
            endDate = DateTime.Now;
            chartType = "Year";
            LoadChart();
            setNoItems();

            // Pie Charts
            LoadPieCharts();
        }


        /// <summary>
        /// BAR GRAPH: VIEW REVENUE BY TIME
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        // Show this week revenue
        private void btnThisWeek_Click(object sender, EventArgs e)
        {
            activateButton(sender);
            startDate = DateTime.Now.StartOfWeek(DayOfWeek.Monday);
            endDate = DateTime.Now;
            chartType = "Month";
            LoadChart();
            setNoItems();
        }

        // Show this year revenue
        private void btnThisYear_Click(object sender, EventArgs e)
        {
            activateButton(sender);
            startDate = BLLRevenueManagement.Instance.GetFirstDate();
            endDate = DateTime.Now;
            chartType = "Year";
            LoadChart();
            setNoItems();
        }

        // Show last 7 days revenue
        private void btnLast7days_Click(object sender, EventArgs e)
        {
            activateButton(sender);
            startDate = DateTime.Now.AddDays(-7);
            endDate = DateTime.Now;
            chartType = "Month";
            LoadChart();
            setNoItems();
        }

        // Show this month revenue
        private void btnThisMonth_Click(object sender, EventArgs e)
        {
            activateButton(sender);
            startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            endDate = DateTime.Now;
            chartType = "Month";
            LoadChart();
            setNoItems();
        }

        // Show last 30 days revenue
        private void btnLast30days_Click(object sender, EventArgs e)
        {
            activateButton(sender);
            startDate = DateTime.Now.AddMonths(-1);
            endDate = DateTime.Now;
            chartType = "Month";
            LoadChart();
            setNoItems();
        }

        // Activate a button
        private void activateButton(object sender)
        {
            disableButtons();
            ((Guna.UI2.WinForms.Guna2Button)sender).FillColor = Color.FromArgb(21, 134, 183);
            ((Guna.UI2.WinForms.Guna2Button)sender).ForeColor = Color.White;
        }

        // Disable other buttons
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

        // Load revenue graph according to chosen time interval
        private void LoadChart()
        {
            if (chartType == "Month")
            {
                var points = BLLRevenueManagement.Instance.GetAllRevenueByDate_ChartView(startDate, endDate, chartType);
                string[] N = new string[points.Count];
                double[] M = new double[points.Count];
                int i = 0;
                foreach (var item in points)
                {
                    N[i] = item.date.Month.ToString() + "-" + item.date.Day.ToString();
                    M[i] = item.total;
                    i++;
                }
                chartRevenue.Series[0].Points.DataBindXY(N, M);
            }
            if (chartType == "Year")
            {
                var points = BLLRevenueManagement.Instance.GetAllRevenueByDate_ChartView(startDate, endDate, chartType);
                string[] N = new string[points.Count];
                double[] M = new double[points.Count];
                int i = 0;
                foreach (var item in points)
                {
                    N[i] = item.date.ToString("MMMM");
                    M[i] = item.total;
                    i++;
                }
                chartRevenue.Series[0].Points.DataBindXY(N, M);
            }
        }

        // Set items values according to chosen time interval
        private void setNoItems()
        {
            lbNoCustomer.Text = BLLRevenueManagement.Instance.GetAllVisitors(startDate, endDate).ToString();
            lbProducts.Text = BLLRevenueManagement.Instance.GetAllNOProductsSold(startDate, endDate).ToString();
            lbGrossRevenue.Text = BLLRevenueManagement.Instance.GetTotalGrossRevenue(startDate, endDate).ToString();
        }


        /// <summary>
        /// PIE CHART: VIEW TOP AND UNDERSTOCK PRODUCTS
        /// </summary>
        private void LoadPieCharts()
        {
            //chartTopProducts
            var points = BLLRevenueManagement.Instance.GetTop5Products(true);
            string[] N = new string[points.Count];
            int[] M = new int[points.Count];
            int i = 0;
            foreach (var item in points)
            {
                N[i] = item.ProductName;
                M[i] = item.ProductQuantity;
                i++;
            }
            chartBestProducts.Series[0].Points.DataBindXY(N, M);

            //chartWorstProducts
            var points2 = BLLRevenueManagement.Instance.GetTop5Products(false);
            string[] A = new string[points.Count];
            int[] B = new int[points.Count];
            int j = 0;
            foreach (var item in points2)
            {
                A[j] = item.ProductName;
                B[j] = item.ProductQuantity;
                j++;
            }
            chartWorstProducts.Series[0].Points.DataBindXY(A, B);
        }


        /// <summary>
        /// PANEL: VIEW TOP STAFFS
        /// </summary>
        private void LoadTopStaffs()
        {
            List<DTO.Charts.TopStaffsChartView> topStaffs = new List<DTO.Charts.TopStaffsChartView>();
            topStaffs = BLLRevenueManagement.Instance.GetTop5Staffs();
            int i = 4, ranking = 1;
            foreach (var item in topStaffs)
            {
                string text = ranking.ToString() + ". " + item.StaffName + ": " + item.GrossRevenue.ToString();
                pnTopStaffs.Controls[i].Text = text;
                i--;
                ranking++;
            }

        }

    }

    
    /// <summary>
    /// TIME CALCULATION CLASS
    /// </summary>
    public static class DateTimeExtensions
    {
        public static DateTime StartOfWeek(this DateTime dt, DayOfWeek startOfWeek)
        {
            int diff = (7 + (dt.DayOfWeek - startOfWeek)) % 7;
            return dt.AddDays(-1 * diff).Date;
        }
    }
}
