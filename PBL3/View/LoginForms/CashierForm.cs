﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.View.StaffChildForms;
using PBL3.Model;
using PBL3.BLL;

namespace PBL3.View
{
    public partial class CashierForm : Form
    {
        Account account;
        private Form activeForm;
        private Guna.UI2.WinForms.Guna2Button currentButton;

        public CashierForm(Account acc)
        {
            InitializeComponent();
            account = acc;
            BLLCustomerManagement.Instance.ReNewUsedCustomer();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            currentButton = btnViewOrder;
            openChildForm(new NewOrder(account), btnNewOrder);

            string name = account.Person.PersonName.Split()[account.Person.PersonName.Split().Count() - 1];
            lbWelcome.Text = "Welcome, " + name;
            lbDate.Text = DateTime.Now.ToShortDateString();
        }

        private void openChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnRight.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void activateButton(object sender)
        {
            if (sender != null)
            {
                btnSettings.Visible = true;
                pnRight.BackColor = Color.FromArgb(198, 232, 229);
                if (currentButton != (Guna.UI2.WinForms.Guna2Button)sender)
                {
                    disableButton();
                    currentButton = (Guna.UI2.WinForms.Guna2Button)sender;
                    currentButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    currentButton.FillColor = Color.FromArgb(198, 232, 229);
                    currentButton.ForeColor = Color.FromArgb(1, 79, 134);
                }
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            btnSettings.Visible = false;
            pnRight.BackColor = Color.FromArgb(228, 241, 239);
            SettingsForms.SettingsForm childForm = new SettingsForms.SettingsForm(account);
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnRight.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
            disableButton();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            DialogResult result = CustomMessageBox.MessageBox.Show("Are you sure you want to log out", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }


        private void disableButton()
        {
            foreach (Control prevButton in pnLeft.Controls)
            {
                if (prevButton.GetType() == typeof(Guna.UI2.WinForms.Guna2Button))
                {
                    ((Guna.UI2.WinForms.Guna2Button)prevButton).FillColor = Color.Transparent;
                    prevButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    prevButton.ForeColor = Color.White;
                }
            }
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            openChildForm(new NewOrder(account), sender);
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageOrder(), sender);
        }
        /// <summary>
        /// RELOAD DISCOUNTS
        /// </summary>
        /// Check if there is any expired discount and remove it
        //private Timer timer;
        //DateTime currentDay;

        //private void startTimer(object sender, EventArgs e)
        //{
        //    timer = new Timer();
        //    timer.Interval = (1 * 1000); // 1 sec
        //    timer.Tick += new EventHandler(timer_Tick);
        //    currentDay = DateTime.Now;
        //    timer.Start();
        //}
        //private void timer_Tick(object sender, EventArgs e)
        //{
        //    if (DateTime.Now != currentDay)
        //    {
        //        List<Discount> expiredDiscounts = BLLDiscountManagement.Instance.GetExpiredDiscounts();
        //        if (expiredDiscounts != null)
        //            BLLDiscountManagement.Instance.RenewDiscounts(expiredDiscounts);
        //        currentDay = DateTime.Now.Date;
        //    }
        //}
    }
}
