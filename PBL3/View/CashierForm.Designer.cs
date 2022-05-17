using System;

namespace PBL3.View
{
    partial class CashierForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierForm));
            this.pnTop = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lbDate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnLogout = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnSettings = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnRight = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2GradientPanel5 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pnMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.btnManageOrder = new Guna.UI2.WinForms.Guna2Button();
            this.btnNewOrder = new Guna.UI2.WinForms.Guna2Button();
            this.btnOverview = new Guna.UI2.WinForms.Guna2Button();
            this.pnLeft = new System.Windows.Forms.Panel();
            this.pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2GradientPanel5.SuspendLayout();
            this.pnMenu.SuspendLayout();
            this.pnLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.lbDate);
            this.pnTop.Controls.Add(this.guna2HtmlLabel1);
            this.pnTop.Controls.Add(this.btnLogout);
            this.pnTop.Controls.Add(this.btnSettings);
            this.pnTop.Controls.Add(this.guna2PictureBox1);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(914, 62);
            this.pnTop.TabIndex = 0;
            this.pnTop.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2GradientPanel1_Paint);
            // 
            // lbDate
            // 
            this.lbDate.BackColor = System.Drawing.Color.Transparent;
            this.lbDate.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(170, 28);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(67, 22);
            this.lbDate.TabIndex = 7;
            this.lbDate.Text = "03/31/2022";
            this.lbDate.Click += new System.EventHandler(this.lbDate_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(169, 7);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(153, 26);
            this.guna2HtmlLabel1.TabIndex = 6;
            this.guna2HtmlLabel1.Text = "Welcome, Y/N";
            this.guna2HtmlLabel1.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.CheckedState.Image = global::PBL3.Properties.Resources.logout;
            this.btnLogout.HoverState.Image = global::PBL3.Properties.Resources.logout;
            this.btnLogout.Image = global::PBL3.Properties.Resources.logout;
            this.btnLogout.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnLogout.ImageRotate = 0F;
            this.btnLogout.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLogout.Location = new System.Drawing.Point(858, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.PressedState.Image = global::PBL3.Properties.Resources.logout;
            this.btnLogout.ShadowDecoration.BorderRadius = 8;
            this.btnLogout.ShadowDecoration.Depth = 5;
            this.btnLogout.ShadowDecoration.Enabled = true;
            this.btnLogout.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 7, 10);
            this.btnLogout.Size = new System.Drawing.Size(30, 30);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Click += new System.EventHandler(this.guna2ImageButton2_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.CheckedState.Image = global::PBL3.Properties.Resources.settingsIcon;
            this.btnSettings.HoverState.Image = global::PBL3.Properties.Resources.settingsIcon;
            this.btnSettings.Image = global::PBL3.Properties.Resources.settingsIcon;
            this.btnSettings.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnSettings.ImageRotate = 0F;
            this.btnSettings.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSettings.Location = new System.Drawing.Point(806, 12);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.ShadowDecoration.BorderRadius = 8;
            this.btnSettings.ShadowDecoration.Depth = 5;
            this.btnSettings.ShadowDecoration.Enabled = true;
            this.btnSettings.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 7, 10);
            this.btnSettings.Size = new System.Drawing.Size(30, 30);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::PBL3.Properties.Resources.logo_ver_2;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.InitialImage")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(3, 6);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(115, 56);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // pnRight
            // 
            this.pnRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            this.pnRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnRight.Location = new System.Drawing.Point(169, 62);
            this.pnRight.Name = "pnRight";
            this.pnRight.Size = new System.Drawing.Size(745, 469);
            this.pnRight.TabIndex = 2;
            // 
            // guna2GradientPanel5
            // 
            this.guna2GradientPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            this.guna2GradientPanel5.BorderRadius = 25;
            this.guna2GradientPanel5.Controls.Add(this.pnMenu);
            this.guna2GradientPanel5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(224)))), ((int)(((byte)(239)))));
            this.guna2GradientPanel5.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.guna2GradientPanel5.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2GradientPanel5.Location = new System.Drawing.Point(-80, 0);
            this.guna2GradientPanel5.Name = "guna2GradientPanel5";
            this.guna2GradientPanel5.Size = new System.Drawing.Size(250, 532);
            this.guna2GradientPanel5.TabIndex = 1;
            this.guna2GradientPanel5.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2GradientPanel5_Paint);
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.Transparent;
            this.pnMenu.Controls.Add(this.btnManageOrder);
            this.pnMenu.Controls.Add(this.btnNewOrder);
            this.pnMenu.Controls.Add(this.btnOverview);
            this.pnMenu.Location = new System.Drawing.Point(80, 22);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(170, 447);
            this.pnMenu.TabIndex = 0;
            // 
            // btnManageOrder
            // 
            this.btnManageOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnManageOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnManageOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnManageOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnManageOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageOrder.FillColor = System.Drawing.Color.Transparent;
            this.btnManageOrder.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageOrder.ForeColor = System.Drawing.Color.White;
            this.btnManageOrder.Image = global::PBL3.Properties.Resources.manageOrder;
            this.btnManageOrder.ImageOffset = new System.Drawing.Point(-3, 0);
            this.btnManageOrder.Location = new System.Drawing.Point(0, 92);
            this.btnManageOrder.Name = "btnManageOrder";
            this.btnManageOrder.PressedColor = System.Drawing.Color.White;
            this.btnManageOrder.PressedDepth = 20;
            this.btnManageOrder.Size = new System.Drawing.Size(170, 46);
            this.btnManageOrder.TabIndex = 2;
            this.btnManageOrder.Text = "Manage Order";
            this.btnManageOrder.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNewOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNewOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNewOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNewOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewOrder.FillColor = System.Drawing.Color.Transparent;
            this.btnNewOrder.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewOrder.ForeColor = System.Drawing.Color.White;
            this.btnNewOrder.Image = global::PBL3.Properties.Resources.newOrder;
            this.btnNewOrder.ImageOffset = new System.Drawing.Point(-11, 0);
            this.btnNewOrder.Location = new System.Drawing.Point(0, 46);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.PressedColor = System.Drawing.Color.White;
            this.btnNewOrder.PressedDepth = 20;
            this.btnNewOrder.Size = new System.Drawing.Size(170, 46);
            this.btnNewOrder.TabIndex = 1;
            this.btnNewOrder.Text = "New Order";
            this.btnNewOrder.TextOffset = new System.Drawing.Point(-8, 0);
            this.btnNewOrder.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // btnOverview
            // 
            this.btnOverview.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOverview.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOverview.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOverview.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOverview.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOverview.FillColor = System.Drawing.Color.Transparent;
            this.btnOverview.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOverview.ForeColor = System.Drawing.Color.White;
            this.btnOverview.Image = global::PBL3.Properties.Resources.overview;
            this.btnOverview.ImageOffset = new System.Drawing.Point(-12, 0);
            this.btnOverview.Location = new System.Drawing.Point(0, 0);
            this.btnOverview.Name = "btnOverview";
            this.btnOverview.PressedColor = System.Drawing.Color.White;
            this.btnOverview.PressedDepth = 20;
            this.btnOverview.Size = new System.Drawing.Size(170, 46);
            this.btnOverview.TabIndex = 0;
            this.btnOverview.Text = "Overview";
            this.btnOverview.TextOffset = new System.Drawing.Point(-10, 0);
            this.btnOverview.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // pnLeft
            // 
            this.pnLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.pnLeft.Controls.Add(this.guna2GradientPanel5);
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeft.Location = new System.Drawing.Point(0, 62);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(170, 469);
            this.pnLeft.TabIndex = 2;
            this.pnLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.pnLeft_Paint);
            // 
            // CashierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(914, 531);
            this.Controls.Add(this.pnLeft);
            this.Controls.Add(this.pnRight);
            this.Controls.Add(this.pnTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CashierForm";
            this.Text = "Salesman";
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2GradientPanel5.ResumeLayout(false);
            this.pnMenu.ResumeLayout(false);
            this.pnLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel pnTop;
        private Guna.UI2.WinForms.Guna2GradientPanel pnRight;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2ImageButton btnSettings;
        private Guna.UI2.WinForms.Guna2ImageButton btnLogout;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel5;
        private Guna.UI2.WinForms.Guna2Panel pnMenu;
        private Guna.UI2.WinForms.Guna2Button btnOverview;
        private Guna.UI2.WinForms.Guna2Button btnManageOrder;
        private Guna.UI2.WinForms.Guna2Button btnNewOrder;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.Panel pnLeft;
    }
}

