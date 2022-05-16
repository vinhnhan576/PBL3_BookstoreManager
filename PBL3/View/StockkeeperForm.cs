using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.View
{
    public partial class StockkeeperForm : Form
    {
        private Form activeForm;
        private Guna.UI2.WinForms.Guna2Button currentButton, prevButton;

        public StockkeeperForm(Account acc)
        {
            InitializeComponent();
            StaffChildForms.Overview overviewForm = new StaffChildForms.Overview();
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            openChildForm(new StockkeeperChildForms.Overview(), sender);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            openChildForm(new StockkeeperChildForms.NewStockItem(), sender);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            openChildForm(new StockkeeperChildForms.ManageStock(), sender);
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
