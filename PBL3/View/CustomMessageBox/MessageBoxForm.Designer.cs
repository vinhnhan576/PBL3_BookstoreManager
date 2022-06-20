namespace PBL3.View.CustomMessageBox
{
    partial class MessageBoxForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnTop = new Guna.UI2.WinForms.Guna2Panel();
            this.pnTitle = new Guna.UI2.WinForms.Guna2Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2CircleButton();
            this.pnFill = new Guna.UI2.WinForms.Guna2Panel();
            this.lbContext = new System.Windows.Forms.Label();
            this.pnBottom = new Guna.UI2.WinForms.Guna2Panel();
            this.btn2 = new Guna.UI2.WinForms.Guna2Button();
            this.btn1 = new Guna.UI2.WinForms.Guna2Button();
            this.pnLeft = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.pbSideBG = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pbIcon = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnTop.SuspendLayout();
            this.pnTitle.SuspendLayout();
            this.pnFill.SuspendLayout();
            this.pnBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSideBG)).BeginInit();
            this.pbSideBG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.Transparent;
            this.pnTop.Controls.Add(this.pnTitle);
            this.pnTop.Controls.Add(this.btnClose);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(190, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(394, 64);
            this.pnTop.TabIndex = 0;
            // 
            // pnTitle
            // 
            this.pnTitle.Controls.Add(this.lbTitle);
            this.pnTitle.Location = new System.Drawing.Point(48, 12);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(298, 52);
            this.pnTitle.TabIndex = 3;
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(176)))), ((int)(((byte)(210)))));
            this.lbTitle.Location = new System.Drawing.Point(0, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(298, 52);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Caption";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(176)))), ((int)(((byte)(210)))));
            this.btnClose.HoverState.Image = global::PBL3.Properties.Resources.icons8_close_100;
            this.btnClose.Image = global::PBL3.Properties.Resources.iconClose;
            this.btnClose.Location = new System.Drawing.Point(355, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedColor = System.Drawing.Color.White;
            this.btnClose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnFill
            // 
            this.pnFill.AutoSize = true;
            this.pnFill.Controls.Add(this.lbContext);
            this.pnFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnFill.Location = new System.Drawing.Point(190, 64);
            this.pnFill.Name = "pnFill";
            this.pnFill.Padding = new System.Windows.Forms.Padding(10, 10, 10, 15);
            this.pnFill.Size = new System.Drawing.Size(394, 62);
            this.pnFill.TabIndex = 2;
            // 
            // lbContext
            // 
            this.lbContext.AutoSize = true;
            this.lbContext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbContext.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.lbContext.Location = new System.Drawing.Point(10, 10);
            this.lbContext.Name = "lbContext";
            this.lbContext.Size = new System.Drawing.Size(73, 23);
            this.lbContext.TabIndex = 2;
            this.lbContext.Text = "Caption";
            this.lbContext.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnBottom
            // 
            this.pnBottom.Controls.Add(this.btn2);
            this.pnBottom.Controls.Add(this.btn1);
            this.pnBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnBottom.Location = new System.Drawing.Point(190, 126);
            this.pnBottom.Name = "pnBottom";
            this.pnBottom.Size = new System.Drawing.Size(394, 44);
            this.pnBottom.TabIndex = 1;
            // 
            // btn2
            // 
            this.btn2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn2.BorderRadius = 7;
            this.btn2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.White;
            this.btn2.Location = new System.Drawing.Point(136, 1);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(110, 32);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "button 2";
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn1.BorderRadius = 7;
            this.btn1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.White;
            this.btn1.Location = new System.Drawing.Point(268, 1);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(110, 32);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "button 1";
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // pnLeft
            // 
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeft.Location = new System.Drawing.Point(0, 0);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(211, 161);
            this.pnLeft.TabIndex = 3;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 15;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // pbSideBG
            // 
            this.pbSideBG.Controls.Add(this.pbIcon);
            this.pbSideBG.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbSideBG.Image = global::PBL3.Properties.Resources.side;
            this.pbSideBG.ImageRotate = 0F;
            this.pbSideBG.Location = new System.Drawing.Point(0, 0);
            this.pbSideBG.Name = "pbSideBG";
            this.pbSideBG.Size = new System.Drawing.Size(190, 170);
            this.pbSideBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSideBG.TabIndex = 0;
            this.pbSideBG.TabStop = false;
            // 
            // pbIcon
            // 
            this.pbIcon.BackColor = System.Drawing.Color.Transparent;
            this.pbIcon.Image = global::PBL3.Properties.Resources.errorVector;
            this.pbIcon.ImageRotate = 0F;
            this.pbIcon.Location = new System.Drawing.Point(12, 5);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(157, 144);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIcon.TabIndex = 1;
            this.pbIcon.TabStop = false;
            // 
            // MessageBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 170);
            this.Controls.Add(this.pnFill);
            this.Controls.Add(this.pnBottom);
            this.Controls.Add(this.pnTop);
            this.Controls.Add(this.pbSideBG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageBoxForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MessageBoxForm";
            this.pnTop.ResumeLayout(false);
            this.pnTitle.ResumeLayout(false);
            this.pnFill.ResumeLayout(false);
            this.pnFill.PerformLayout();
            this.pnBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSideBG)).EndInit();
            this.pbSideBG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnTop;
        private System.Windows.Forms.Label lbTitle;
        private Guna.UI2.WinForms.Guna2Panel pnFill;
        private Guna.UI2.WinForms.Guna2Panel pnBottom;
        private Guna.UI2.WinForms.Guna2Button btn1;
        private Guna.UI2.WinForms.Guna2PictureBox pbSideBG;
        private Guna.UI2.WinForms.Guna2CircleButton btnClose;
        private Guna.UI2.WinForms.Guna2Panel pnLeft;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2PictureBox pbIcon;
        private Guna.UI2.WinForms.Guna2Panel pnTitle;
        private System.Windows.Forms.Label lbContext;
        private Guna.UI2.WinForms.Guna2Button btn2;
    }
}