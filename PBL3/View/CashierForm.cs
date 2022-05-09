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

namespace PBL3.View
{
    public partial class CashierForm : Form
    {
        private Form activeForm;
        private Guna.UI2.WinForms.Guna2Button currentButton, prevButton;

        public CashierForm()
        {
            InitializeComponent();
           Overview overviewForm = new Overview();
            overviewForm.TopLevel = false;
            overviewForm.FormBorderStyle = FormBorderStyle.None;
            overviewForm.Dock = DockStyle.Fill;
            this.pnRight.Controls.Add(overviewForm);
            overviewForm.BringToFront();
            overviewForm.Show();
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
                if (currentButton != (Guna.UI2.WinForms.Guna2Button)sender)
                {
                    disableButton();
                    currentButton = (Guna.UI2.WinForms.Guna2Button)sender;
                    currentButton.BackColor = Color.White;
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            openChildForm(new Overview(), sender);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            openChildForm(new NewOrder(), sender);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageOrder(), sender);
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out", "Log out", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void pnLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lbDate_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void disableButton()
        {
            foreach (Control prevButton in pnMenu.Controls)
            {
                if (prevButton.GetType() == typeof(Guna.UI2.WinForms.Guna2Button))
                {
                    prevButton.BackColor = Color.Transparent;
                    prevButton.ForeColor = Color.Gainsboro;
                }
            }
        }
    }
}