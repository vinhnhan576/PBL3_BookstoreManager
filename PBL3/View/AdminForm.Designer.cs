using System;

namespace PBL3.View
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.pnTop = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lbDate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnLogout = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnSettings = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnRight = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2GradientPanel5 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pnMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.btnRevenue = new Guna.UI2.WinForms.Guna2Button();
            this.btnAccount = new Guna.UI2.WinForms.Guna2Button();
            this.btnDiscount = new Guna.UI2.WinForms.Guna2Button();
            this.btnStock = new Guna.UI2.WinForms.Guna2Button();
            this.btnBill = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.btnProduct = new Guna.UI2.WinForms.Guna2Button();
            this.btnOverview = new Guna.UI2.WinForms.Guna2Button();
            this.pnLeft = new Guna.UI2.WinForms.Guna2Panel();
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
            this.pnTop.Size = new System.Drawing.Size(914, 60);
            this.pnTop.TabIndex = 0;
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
            // 
            // pnRight
            // 
            this.pnRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            this.pnRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnRight.Location = new System.Drawing.Point(140, 60);
            this.pnRight.Name = "pnRight";
            this.pnRight.Size = new System.Drawing.Size(774, 471);
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
            this.guna2GradientPanel5.Size = new System.Drawing.Size(220, 532);
            this.guna2GradientPanel5.TabIndex = 1;
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.Transparent;
            this.pnMenu.Controls.Add(this.btnRevenue);
            this.pnMenu.Controls.Add(this.btnAccount);
            this.pnMenu.Controls.Add(this.btnDiscount);
            this.pnMenu.Controls.Add(this.btnStock);
            this.pnMenu.Controls.Add(this.btnBill);
            this.pnMenu.Controls.Add(this.btnCustomer);
            this.pnMenu.Controls.Add(this.btnProduct);
            this.pnMenu.Controls.Add(this.btnOverview);
            this.pnMenu.Location = new System.Drawing.Point(80, 22);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(140, 447);
            this.pnMenu.TabIndex = 0;
            // 
            // btnRevenue
            // 
            this.btnRevenue.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRevenue.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRevenue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRevenue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRevenue.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRevenue.FillColor = System.Drawing.Color.Transparent;
            this.btnRevenue.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevenue.ForeColor = System.Drawing.Color.White;
            this.btnRevenue.Image = global::PBL3.Properties.Resources.revenue;
            this.btnRevenue.ImageOffset = new System.Drawing.Point(-4, 0);
            this.btnRevenue.Location = new System.Drawing.Point(0, 322);
            this.btnRevenue.Name = "btnRevenue";
            this.btnRevenue.PressedColor = System.Drawing.Color.White;
            this.btnRevenue.PressedDepth = 20;
            this.btnRevenue.Size = new System.Drawing.Size(140, 46);
            this.btnRevenue.TabIndex = 7;
            this.btnRevenue.Text = "Revenue";
            this.btnRevenue.TextOffset = new System.Drawing.Point(-2, 0);
            this.btnRevenue.Click += new System.EventHandler(this.guna2Button8_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccount.FillColor = System.Drawing.Color.Transparent;
            this.btnAccount.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.ForeColor = System.Drawing.Color.White;
            this.btnAccount.Image = global::PBL3.Properties.Resources.account;
            this.btnAccount.ImageOffset = new System.Drawing.Point(-5, 0);
            this.btnAccount.Location = new System.Drawing.Point(0, 276);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.PressedColor = System.Drawing.Color.White;
            this.btnAccount.PressedDepth = 20;
            this.btnAccount.Size = new System.Drawing.Size(140, 46);
            this.btnAccount.TabIndex = 6;
            this.btnAccount.Text = "Account";
            this.btnAccount.TextOffset = new System.Drawing.Point(-2, 0);
            this.btnAccount.Click += new System.EventHandler(this.guna2Button7_Click);
            // 
            // btnDiscount
            // 
            this.btnDiscount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDiscount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDiscount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDiscount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDiscount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDiscount.FillColor = System.Drawing.Color.Transparent;
            this.btnDiscount.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscount.ForeColor = System.Drawing.Color.White;
            this.btnDiscount.Image = global::PBL3.Properties.Resources.discount;
            this.btnDiscount.ImageOffset = new System.Drawing.Point(-5, 0);
            this.btnDiscount.Location = new System.Drawing.Point(0, 230);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.PressedColor = System.Drawing.Color.White;
            this.btnDiscount.PressedDepth = 20;
            this.btnDiscount.Size = new System.Drawing.Size(140, 46);
            this.btnDiscount.TabIndex = 5;
            this.btnDiscount.Text = "Discount";
            this.btnDiscount.TextOffset = new System.Drawing.Point(-2, 0);
            this.btnDiscount.Click += new System.EventHandler(this.guna2Button6_Click);
            // 
            // btnStock
            // 
            this.btnStock.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStock.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStock.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStock.FillColor = System.Drawing.Color.Transparent;
            this.btnStock.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.ForeColor = System.Drawing.Color.White;
            this.btnStock.Image = global::PBL3.Properties.Resources.stock;
            this.btnStock.ImageOffset = new System.Drawing.Point(-10, 0);
            this.btnStock.Location = new System.Drawing.Point(0, 184);
            this.btnStock.Name = "btnStock";
            this.btnStock.PressedColor = System.Drawing.Color.White;
            this.btnStock.PressedDepth = 20;
            this.btnStock.Size = new System.Drawing.Size(140, 46);
            this.btnStock.TabIndex = 4;
            this.btnStock.Text = "Stock";
            this.btnStock.TextOffset = new System.Drawing.Point(-8, 0);
            this.btnStock.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // btnBill
            // 
            this.btnBill.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBill.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBill.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBill.FillColor = System.Drawing.Color.Transparent;
            this.btnBill.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.ForeColor = System.Drawing.Color.White;
            this.btnBill.Image = global::PBL3.Properties.Resources.bill;
            this.btnBill.ImageOffset = new System.Drawing.Point(-15, 0);
            this.btnBill.Location = new System.Drawing.Point(0, 138);
            this.btnBill.Name = "btnBill";
            this.btnBill.PressedColor = System.Drawing.Color.White;
            this.btnBill.PressedDepth = 20;
            this.btnBill.Size = new System.Drawing.Size(140, 46);
            this.btnBill.TabIndex = 3;
            this.btnBill.Text = "Bill";
            this.btnBill.TextOffset = new System.Drawing.Point(-12, 0);
            this.btnBill.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomer.FillColor = System.Drawing.Color.Transparent;
            this.btnCustomer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.Image = global::PBL3.Properties.Resources.customer;
            this.btnCustomer.ImageOffset = new System.Drawing.Point(-2, 0);
            this.btnCustomer.Location = new System.Drawing.Point(0, 92);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.PressedColor = System.Drawing.Color.White;
            this.btnCustomer.PressedDepth = 20;
            this.btnCustomer.Size = new System.Drawing.Size(140, 46);
            this.btnCustomer.TabIndex = 2;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProduct.FillColor = System.Drawing.Color.Transparent;
            this.btnProduct.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.ForeColor = System.Drawing.Color.White;
            this.btnProduct.Image = global::PBL3.Properties.Resources.bookIcon;
            this.btnProduct.ImageOffset = new System.Drawing.Point(-5, 0);
            this.btnProduct.Location = new System.Drawing.Point(0, 46);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.PressedColor = System.Drawing.Color.White;
            this.btnProduct.PressedDepth = 20;
            this.btnProduct.Size = new System.Drawing.Size(140, 46);
            this.btnProduct.TabIndex = 1;
            this.btnProduct.Text = "Product";
            this.btnProduct.TextOffset = new System.Drawing.Point(-3, 0);
            this.btnProduct.Click += new System.EventHandler(this.guna2Button2_Click);
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
            this.btnOverview.ImageOffset = new System.Drawing.Point(-2, 0);
            this.btnOverview.Location = new System.Drawing.Point(0, 0);
            this.btnOverview.Name = "btnOverview";
            this.btnOverview.PressedColor = System.Drawing.Color.White;
            this.btnOverview.PressedDepth = 20;
            this.btnOverview.Size = new System.Drawing.Size(140, 46);
            this.btnOverview.TabIndex = 0;
            this.btnOverview.Text = "Overview";
            this.btnOverview.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // pnLeft
            // 
            this.pnLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            this.pnLeft.Controls.Add(this.guna2GradientPanel5);
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeft.Location = new System.Drawing.Point(0, 60);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(140, 471);
            this.pnLeft.TabIndex = 3;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(914, 531);
            this.Controls.Add(this.pnRight);
            this.Controls.Add(this.pnLeft);
            this.Controls.Add(this.pnTop);
            this.Name = "AdminForm";
            this.Text = "Admin";
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
        private Guna.UI2.WinForms.Guna2HtmlLabel lbDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Panel pnLeft;
        private Guna.UI2.WinForms.Guna2Button btnRevenue;
        private Guna.UI2.WinForms.Guna2Button btnAccount;
        private Guna.UI2.WinForms.Guna2Button btnDiscount;
        private Guna.UI2.WinForms.Guna2Button btnStock;
        private Guna.UI2.WinForms.Guna2Button btnBill;
        private Guna.UI2.WinForms.Guna2Button btnCustomer;
        private Guna.UI2.WinForms.Guna2Button btnOverview;
        private Guna.UI2.WinForms.Guna2Button btnProduct;
    }
}

