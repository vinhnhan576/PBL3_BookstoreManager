using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.View.CustomMessageBox
{
    public partial class MessageBoxForm : Form
    {

        //
        // Text Only Dialog
        //
        public MessageBoxForm(string text, MessageBoxIcon icon)
        {
            InitializeComponent();
            InitializeGUI();
            this.lbContext.Text = text;
            this.lbTitle.Text = "";
            SetFormSize();
            SetButtons(MessageBoxButtons.OK, MessageBoxDefaultButton.Button1);
            SetIcon(icon);
        }

        //
        // OK Dialog
        //
        public MessageBoxForm(string text, string title, MessageBoxIcon icon)
        {
            InitializeComponent();
            InitializeGUI();
            this.lbContext.Text = text;
            this.lbTitle.Text = title;
            SetFormSize();
            SetButtons(MessageBoxButtons.OK, MessageBoxDefaultButton.Button1);
            SetIcon(icon);
        }

        //
        // Buttons Dialog
        //
        public MessageBoxForm(string text, string title, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            InitializeComponent();
            InitializeGUI();
            this.lbContext.Text = text;
            this.lbTitle.Text = title;
            SetFormSize();
            SetButtons(buttons, MessageBoxDefaultButton.Button1);
            SetIcon(icon);
        }

        //
        // Buttons Dialog w default btn
        //
        public MessageBoxForm(string text, string title, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton)
        {
            InitializeComponent();
            InitializeGUI();
            this.lbContext.Text = text;
            this.lbTitle.Text = title;
            SetFormSize();
            SetButtons(buttons, defaultButton);
            SetIcon(icon);
        }

        private void InitializeGUI()
        {
            this.btnClose.DialogResult = DialogResult.Cancel;
            this.btn1.DialogResult = DialogResult.OK;
            this.btn1.Visible = false;
            this.btn2.Visible = false;
        }

        private void SetFormSize()
        {
            int widht = this.pbSideBG.Width + this.pnFill.Width;
            int height = this.pnTop.Height + this.pnFill.Padding.Top + this.lbContext.Height + this.pnFill.Padding.Bottom + this.pnBottom.Height;
            this.Size = new Size(widht, height);
        }

        private void SetButtons(MessageBoxButtons buttons, MessageBoxDefaultButton defaultButton)
        {
            switch (buttons)
            {
                case MessageBoxButtons.OK:
                    btn1.Visible = true;
                    btn1.Text = "OK";
                    btn1.DialogResult = DialogResult.OK;
                    SetDefaultButton(defaultButton);

                    break;
                case MessageBoxButtons.OKCancel:
                    btn1.Visible = true;
                    btn1.Text = "Cancel";
                    btn1.DialogResult = DialogResult.Cancel;

                    btn2.Visible = true;
                    btn2.Text = "OK";
                    btn2.DialogResult = DialogResult.OK;

                    SetDefaultButton(defaultButton);

                    break;
                case MessageBoxButtons.YesNo:
                    btn1.Visible = true;
                    btn1.Text = "No";
                    btn1.DialogResult = DialogResult.No;

                    btn2.Visible = true;
                    btn2.Text = "Yes";
                    btn2.DialogResult = DialogResult.Yes;

                    SetDefaultButton(defaultButton);

                    break;
                //case MessageBoxButtons.YesNoCancel:
                //    btn1.Visible = true;
                //    btn1.Text = "Yes";
                //    btn1.DialogResult = DialogResult.Yes;

                //    btn2.Visible = true;
                //    btn2.Text = "No";
                //    btn2.DialogResult = DialogResult.No;

                //    break;
                default:
                    break;
            }
        }

        private void SetIcon(MessageBoxIcon icon)
        {
            switch (icon)
            {
                case MessageBoxIcon.Error:
                    this.pbIcon.Image = Properties.Resources.errorVector;
                    this.pbIcon.SizeMode = PictureBoxSizeMode.Zoom;

                    break;
                case MessageBoxIcon.Warning:
                    this.pbIcon.Image = Properties.Resources.warningVetor;
                    this.pbIcon.SizeMode = PictureBoxSizeMode.Zoom;

                    break;
                case MessageBoxIcon.Question:
                    this.pbIcon.Image = Properties.Resources.questionVector;
                    this.pbIcon.SizeMode = PictureBoxSizeMode.Zoom;

                    break;

                case MessageBoxIcon.Information:
                    this.pbIcon.Image = Properties.Resources.infoVector;
                    this.pbIcon.SizeMode = PictureBoxSizeMode.Zoom;

                    break;
            }
        }

        private void SetDefaultButton(MessageBoxDefaultButton defaultButton)
        {
            switch (defaultButton)
            {
                case MessageBoxDefaultButton.Button1://Focus button 1
                    btn1.Select();
                    btn1.ForeColor = Color.White;
                    btn1.Font = new Font(btn1.Font, FontStyle.Underline);
                    break;
                case MessageBoxDefaultButton.Button2://Focus button 2
                    btn2.Select();
                    btn2.ForeColor = Color.White;
                    btn2.Font = new Font(btn2.Font, FontStyle.Underline);
                    break;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.DialogResult = ((Guna.UI2.WinForms.Guna2Button)sender).DialogResult;
            this.Close();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            this.DialogResult = ((Guna.UI2.WinForms.Guna2Button)sender).DialogResult;
            this.Close();
        }
    }
}
