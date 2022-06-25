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
            this.btnLogout = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lbWelcome = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnSettings = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnRight = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pnMenu = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.Rankbutton = new Guna.UI2.WinForms.Guna2Button();
            this.btnRevenue = new Guna.UI2.WinForms.Guna2Button();
            this.btnAccount = new Guna.UI2.WinForms.Guna2Button();
            this.btnDiscount = new Guna.UI2.WinForms.Guna2Button();
            this.btnStock = new Guna.UI2.WinForms.Guna2Button();
            this.btnBill = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.btnProduct = new Guna.UI2.WinForms.Guna2Button();
            this.btnOverview = new Guna.UI2.WinForms.Guna2Button();
            this.pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.pnMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.lbDate);
            this.pnTop.Controls.Add(this.btnLogout);
            this.pnTop.Controls.Add(this.lbWelcome);
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
            this.lbDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDate.BackColor = System.Drawing.Color.Transparent;
            this.lbDate.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(79)))), ((int)(((byte)(134)))));
            this.lbDate.Location = new System.Drawing.Point(172, 34);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(67, 22);
            this.lbDate.TabIndex = 9;
            this.lbDate.Text = "03/31/2022";
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.CheckedState.Image = global::PBL3.Properties.Resources.logout;
            this.btnLogout.HoverState.Image = global::PBL3.Properties.Resources.logout;
            this.btnLogout.HoverState.ImageSize = new System.Drawing.Size(24, 24);
            this.btnLogout.Image = global::PBL3.Properties.Resources.logout;
            this.btnLogout.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnLogout.ImageRotate = 0F;
            this.btnLogout.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLogout.Location = new System.Drawing.Point(858, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.PressedState.Image = global::PBL3.Properties.Resources.logout;
            this.btnLogout.PressedState.ImageSize = new System.Drawing.Size(18, 18);
            this.btnLogout.ShadowDecoration.BorderRadius = 0;
            this.btnLogout.ShadowDecoration.Depth = 6;
            this.btnLogout.ShadowDecoration.Enabled = true;
            this.btnLogout.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 6, 6);
            this.btnLogout.Size = new System.Drawing.Size(30, 30);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lbWelcome
            // 
            this.lbWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lbWelcome.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(79)))), ((int)(((byte)(134)))));
            this.lbWelcome.Location = new System.Drawing.Point(170, 8);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(134, 32);
            this.lbWelcome.TabIndex = 8;
            this.lbWelcome.Text = "Welcome, Y/N";
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.CheckedState.Image = global::PBL3.Properties.Resources.settingsIcon;
            this.btnSettings.CheckedState.ImageSize = new System.Drawing.Size(24, 24);
            this.btnSettings.HoverState.Image = global::PBL3.Properties.Resources.settingsIcon;
            this.btnSettings.HoverState.ImageSize = new System.Drawing.Size(24, 24);
            this.btnSettings.Image = global::PBL3.Properties.Resources.settingsIcon;
            this.btnSettings.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnSettings.ImageRotate = 0F;
            this.btnSettings.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSettings.Location = new System.Drawing.Point(806, 12);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.PressedState.Image = global::PBL3.Properties.Resources.settingsIcon;
            this.btnSettings.PressedState.ImageSize = new System.Drawing.Size(23, 23);
            this.btnSettings.ShadowDecoration.BorderRadius = 0;
            this.btnSettings.ShadowDecoration.Depth = 6;
            this.btnSettings.ShadowDecoration.Enabled = true;
            this.btnSettings.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 6, 6);
            this.btnSettings.Size = new System.Drawing.Size(30, 30);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
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
            this.pnRight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            this.pnRight.Location = new System.Drawing.Point(140, 60);
            this.pnRight.Name = "pnRight";
            this.pnRight.Size = new System.Drawing.Size(774, 471);
            this.pnRight.TabIndex = 2;
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            this.pnMenu.BorderRadius = 25;
            this.pnMenu.Controls.Add(this.Rankbutton);
            this.pnMenu.Controls.Add(this.btnRevenue);
            this.pnMenu.Controls.Add(this.btnAccount);
            this.pnMenu.Controls.Add(this.btnDiscount);
            this.pnMenu.Controls.Add(this.btnStock);
            this.pnMenu.Controls.Add(this.btnBill);
            this.pnMenu.Controls.Add(this.btnCustomer);
            this.pnMenu.Controls.Add(this.btnProduct);
            this.pnMenu.Controls.Add(this.btnOverview);
            this.pnMenu.CustomizableEdges.BottomLeft = false;
            this.pnMenu.CustomizableEdges.BottomRight = false;
            this.pnMenu.CustomizableEdges.TopLeft = false;
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(224)))), ((int)(((byte)(239)))));
            this.pnMenu.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.pnMenu.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.pnMenu.Location = new System.Drawing.Point(0, 60);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Padding = new System.Windows.Forms.Padding(10, 20, 10, 0);
            this.pnMenu.Size = new System.Drawing.Size(140, 471);
            this.pnMenu.TabIndex = 1;
            // 
            // Rankbutton
            // 
            this.Rankbutton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Rankbutton.BackColor = System.Drawing.Color.Transparent;
            this.Rankbutton.BorderRadius = 3;
            this.Rankbutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Rankbutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Rankbutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Rankbutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Rankbutton.FillColor = System.Drawing.Color.Transparent;
            this.Rankbutton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rankbutton.ForeColor = System.Drawing.Color.White;
            this.Rankbutton.Image = global::PBL3.Properties.Resources.revenue;
            this.Rankbutton.ImageOffset = new System.Drawing.Point(-11, 0);
            this.Rankbutton.Location = new System.Drawing.Point(9, 412);
            this.Rankbutton.Name = "Rankbutton";
            this.Rankbutton.PressedColor = System.Drawing.Color.White;
            this.Rankbutton.PressedDepth = 20;
            this.Rankbutton.Size = new System.Drawing.Size(120, 32);
            this.Rankbutton.TabIndex = 8;
            this.Rankbutton.Text = "Rank";
            this.Rankbutton.TextOffset = new System.Drawing.Point(-9, 0);
            this.Rankbutton.Click += new System.EventHandler(this.Rankbutton_Click);
            // 
            // btnRevenue
            // 
            this.btnRevenue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRevenue.BackColor = System.Drawing.Color.Transparent;
            this.btnRevenue.BorderRadius = 3;
            this.btnRevenue.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRevenue.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRevenue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRevenue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRevenue.FillColor = System.Drawing.Color.Transparent;
            this.btnRevenue.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevenue.ForeColor = System.Drawing.Color.White;
            this.btnRevenue.Image = global::PBL3.Properties.Resources.revenue;
            this.btnRevenue.ImageOffset = new System.Drawing.Point(-4, 0);
            this.btnRevenue.Location = new System.Drawing.Point(10, 363);
            this.btnRevenue.Name = "btnRevenue";
            this.btnRevenue.PressedColor = System.Drawing.Color.White;
            this.btnRevenue.PressedDepth = 20;
            this.btnRevenue.Size = new System.Drawing.Size(120, 32);
            this.btnRevenue.TabIndex = 7;
            this.btnRevenue.Text = "Revenue";
            this.btnRevenue.TextOffset = new System.Drawing.Point(-2, 0);
            this.btnRevenue.Click += new System.EventHandler(this.btnRevenue_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAccount.BackColor = System.Drawing.Color.Transparent;
            this.btnAccount.BorderRadius = 3;
            this.btnAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAccount.FillColor = System.Drawing.Color.Transparent;
            this.btnAccount.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.ForeColor = System.Drawing.Color.White;
            this.btnAccount.Image = global::PBL3.Properties.Resources.account;
            this.btnAccount.ImageOffset = new System.Drawing.Point(-5, 0);
            this.btnAccount.Location = new System.Drawing.Point(10, 314);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.PressedColor = System.Drawing.Color.White;
            this.btnAccount.PressedDepth = 20;
            this.btnAccount.Size = new System.Drawing.Size(120, 32);
            this.btnAccount.TabIndex = 6;
            this.btnAccount.Text = "Account";
            this.btnAccount.TextOffset = new System.Drawing.Point(-2, 0);
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnDiscount
            // 
            this.btnDiscount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDiscount.BackColor = System.Drawing.Color.Transparent;
            this.btnDiscount.BorderRadius = 3;
            this.btnDiscount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDiscount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDiscount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDiscount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDiscount.FillColor = System.Drawing.Color.Transparent;
            this.btnDiscount.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscount.ForeColor = System.Drawing.Color.White;
            this.btnDiscount.Image = global::PBL3.Properties.Resources.iconWhiteDiscount;
            this.btnDiscount.ImageOffset = new System.Drawing.Point(-5, 0);
            this.btnDiscount.Location = new System.Drawing.Point(10, 265);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.PressedColor = System.Drawing.Color.White;
            this.btnDiscount.PressedDepth = 20;
            this.btnDiscount.Size = new System.Drawing.Size(120, 32);
            this.btnDiscount.TabIndex = 5;
            this.btnDiscount.Text = "Discount";
            this.btnDiscount.TextOffset = new System.Drawing.Point(-2, 0);
            this.btnDiscount.Click += new System.EventHandler(this.btnDiscount_Click);
            // 
            // btnStock
            // 
            this.btnStock.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStock.BackColor = System.Drawing.Color.Transparent;
            this.btnStock.BorderRadius = 3;
            this.btnStock.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStock.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStock.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStock.FillColor = System.Drawing.Color.Transparent;
            this.btnStock.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.ForeColor = System.Drawing.Color.White;
            this.btnStock.Image = global::PBL3.Properties.Resources.stock;
            this.btnStock.ImageOffset = new System.Drawing.Point(-10, 0);
            this.btnStock.Location = new System.Drawing.Point(10, 216);
            this.btnStock.Name = "btnStock";
            this.btnStock.PressedColor = System.Drawing.Color.White;
            this.btnStock.PressedDepth = 20;
            this.btnStock.Size = new System.Drawing.Size(120, 32);
            this.btnStock.TabIndex = 4;
            this.btnStock.Text = "Stock";
            this.btnStock.TextOffset = new System.Drawing.Point(-8, 0);
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnBill
            // 
            this.btnBill.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBill.BackColor = System.Drawing.Color.Transparent;
            this.btnBill.BorderRadius = 3;
            this.btnBill.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBill.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBill.FillColor = System.Drawing.Color.Transparent;
            this.btnBill.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.ForeColor = System.Drawing.Color.White;
            this.btnBill.Image = global::PBL3.Properties.Resources.bill;
            this.btnBill.ImageOffset = new System.Drawing.Point(-6, 0);
            this.btnBill.Location = new System.Drawing.Point(10, 167);
            this.btnBill.Name = "btnBill";
            this.btnBill.PressedColor = System.Drawing.Color.White;
            this.btnBill.PressedDepth = 20;
            this.btnBill.Size = new System.Drawing.Size(120, 32);
            this.btnBill.TabIndex = 3;
            this.btnBill.Text = "Receipt";
            this.btnBill.TextOffset = new System.Drawing.Point(-3, 0);
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCustomer.BackColor = System.Drawing.Color.Transparent;
            this.btnCustomer.BorderRadius = 3;
            this.btnCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomer.FillColor = System.Drawing.Color.Transparent;
            this.btnCustomer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.Image = global::PBL3.Properties.Resources.iconWhiteCustomer;
            this.btnCustomer.ImageOffset = new System.Drawing.Point(-2, 0);
            this.btnCustomer.Location = new System.Drawing.Point(10, 118);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.PressedColor = System.Drawing.Color.White;
            this.btnCustomer.PressedDepth = 20;
            this.btnCustomer.Size = new System.Drawing.Size(120, 32);
            this.btnCustomer.TabIndex = 2;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnProduct.BorderRadius = 3;
            this.btnProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProduct.FillColor = System.Drawing.Color.Transparent;
            this.btnProduct.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.ForeColor = System.Drawing.Color.White;
            this.btnProduct.Image = global::PBL3.Properties.Resources.iconWhiteBook;
            this.btnProduct.ImageOffset = new System.Drawing.Point(-5, 0);
            this.btnProduct.Location = new System.Drawing.Point(10, 69);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.PressedColor = System.Drawing.Color.White;
            this.btnProduct.PressedDepth = 20;
            this.btnProduct.Size = new System.Drawing.Size(120, 32);
            this.btnProduct.TabIndex = 1;
            this.btnProduct.Text = "Product";
            this.btnProduct.TextOffset = new System.Drawing.Point(-3, 0);
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnOverview
            // 
            this.btnOverview.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOverview.BackColor = System.Drawing.Color.Transparent;
            this.btnOverview.BorderRadius = 3;
            this.btnOverview.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOverview.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOverview.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOverview.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOverview.FillColor = System.Drawing.Color.Transparent;
            this.btnOverview.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOverview.ForeColor = System.Drawing.Color.White;
            this.btnOverview.Image = global::PBL3.Properties.Resources.iconWhiteOverview;
            this.btnOverview.ImageOffset = new System.Drawing.Point(-2, 0);
            this.btnOverview.Location = new System.Drawing.Point(10, 20);
            this.btnOverview.Name = "btnOverview";
            this.btnOverview.PressedColor = System.Drawing.Color.White;
            this.btnOverview.PressedDepth = 20;
            this.btnOverview.Size = new System.Drawing.Size(120, 32);
            this.btnOverview.TabIndex = 0;
            this.btnOverview.Text = "Overview";
            this.btnOverview.Click += new System.EventHandler(this.btnOverview_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(914, 531);
            this.Controls.Add(this.pnRight);
            this.Controls.Add(this.pnMenu);
            this.Controls.Add(this.pnTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.pnMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel pnTop;
        private Guna.UI2.WinForms.Guna2GradientPanel pnRight;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2ImageButton btnSettings;
        private Guna.UI2.WinForms.Guna2ImageButton btnLogout;
        private Guna.UI2.WinForms.Guna2Button btnRevenue;
        private Guna.UI2.WinForms.Guna2Button btnAccount;
        private Guna.UI2.WinForms.Guna2Button btnDiscount;
        private Guna.UI2.WinForms.Guna2Button btnStock;
        private Guna.UI2.WinForms.Guna2Button btnBill;
        private Guna.UI2.WinForms.Guna2Button btnCustomer;
        private Guna.UI2.WinForms.Guna2Button btnOverview;
        private Guna.UI2.WinForms.Guna2Button btnProduct;
        private Guna.UI2.WinForms.Guna2GradientPanel pnMenu;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbWelcome;
        private Guna.UI2.WinForms.Guna2Button Rankbutton;
    }
}

