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
            SetButtons(buttons, defaultButton);
            SetIcon(icon);
        }

        private void InitializeGUI()
        {
            this.btnClose.DialogResult = DialogResult.Cancel;
            this.btn1.Visible = false;
            this.btn2.Visible = false;
        }

        private void SetFormSize()
        {
            int widht = this.pbSideBG.Width + this.pnFill.Width;
            int height = this.pnTop.Height + this.pnFill.Height + this.pnBottom.Height;
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

                    break;
                case MessageBoxButtons.OKCancel:
                    btn1.Visible = true;
                    btn1.Text = "OK";
                    btn1.DialogResult = DialogResult.OK;

                    btn2.Visible = true;
                    btn2.Text = "Cancel";
                    btn2.DialogResult = DialogResult.Cancel;

                    break;
                case MessageBoxButtons.YesNo:
                    btn1.Visible = true;
                    btn1.Text = "Yes";
                    btn1.DialogResult = DialogResult.Yes;

                    btn2.Visible = true;
                    btn2.Text = "No";
                    btn2.DialogResult = DialogResult.No;

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
                default:
                    break;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
