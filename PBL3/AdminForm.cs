using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3
{
    public partial class AdminForm : Form
    {
        private Form activeForm;
        private Guna.UI2.WinForms.Guna2Button currentButton, prevButton;

        public AdminForm()
        {
            InitializeComponent();
            AdminChildForms.Overview overviewForm = new AdminChildForms.Overview();
            overviewForm.TopLevel = false;
            overviewForm.FormBorderStyle = FormBorderStyle.None;
            overviewForm.Dock = DockStyle.Fill;
            this.pnRight.Controls.Add(overviewForm);
            overviewForm.BringToFront();
            overviewForm.Show();
        }

        private void openChildForm(Form childForm, object btnSender)
        {
            if(activeForm != null)
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
            if(sender != null)
            {
                if(currentButton != (Guna.UI2.WinForms.Guna2Button)sender)
                {
                    disableButton();
                    currentButton = (Guna.UI2.WinForms.Guna2Button)sender;
                    currentButton.BackColor = Color.White;
                }
            }
        }

        private void disableButton()
        {
            foreach(Control prevButton in pnMenu.Controls)
            {
                if(prevButton.GetType() == typeof(Guna.UI2.WinForms.Guna2Button))
                {
                    prevButton.BackColor = Color.Transparent;
                    prevButton.ForeColor = Color.Gainsboro;
                }
            }
        }

        private void guna2GradientPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            openChildForm(new AdminChildForms.Product(), sender);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            openChildForm(new AdminChildForms.Customer(), sender);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            openChildForm(new AdminChildForms.Bill(), sender);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            openChildForm(new AdminChildForms.Stock(), sender);
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            openChildForm(new AdminChildForms.Discount(), sender);
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            openChildForm(new AdminChildForms.Account(), sender);
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            openChildForm(new AdminChildForms.Revenue(), sender);
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out", "Log out", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            openChildForm(new AdminChildForms.Overview(), sender);
        }
    }
}
