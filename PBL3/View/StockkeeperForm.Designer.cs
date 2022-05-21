namespace PBL3.View
{
    partial class StockkeeperForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockkeeperForm));
            this.pnTop = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnLogout = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnSettings = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnMenu = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnStoreImport = new Guna.UI2.WinForms.Guna2Button();
            this.btnManageStock = new Guna.UI2.WinForms.Guna2Button();
            this.btnNewStock = new Guna.UI2.WinForms.Guna2Button();
            this.btnOverview = new Guna.UI2.WinForms.Guna2Button();
            this.pnRight = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lbDate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbWelcome = new Guna.UI2.WinForms.Guna2HtmlLabel();
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
            this.pnTop.TabIndex = 1;
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
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.CheckedState.Image = global::PBL3.Properties.Resources.settingsIcon;
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
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            this.pnMenu.BorderRadius = 25;
            this.pnMenu.Controls.Add(this.btnStoreImport);
            this.pnMenu.Controls.Add(this.btnManageStock);
            this.pnMenu.Controls.Add(this.btnNewStock);
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
            this.pnMenu.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.pnMenu.Size = new System.Drawing.Size(170, 471);
            this.pnMenu.TabIndex = 1;
            // 
            // btnStoreImport
            // 
            this.btnStoreImport.BackColor = System.Drawing.Color.Transparent;
            this.btnStoreImport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStoreImport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStoreImport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStoreImport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStoreImport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStoreImport.FillColor = System.Drawing.Color.Transparent;
            this.btnStoreImport.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStoreImport.ForeColor = System.Drawing.Color.White;
            this.btnStoreImport.Image = global::PBL3.Properties.Resources.iconStore;
            this.btnStoreImport.ImageOffset = new System.Drawing.Point(-8, 0);
            this.btnStoreImport.Location = new System.Drawing.Point(0, 158);
            this.btnStoreImport.Name = "btnStoreImport";
            this.btnStoreImport.PressedColor = System.Drawing.Color.White;
            this.btnStoreImport.PressedDepth = 20;
            this.btnStoreImport.Size = new System.Drawing.Size(170, 46);
            this.btnStoreImport.TabIndex = 3;
            this.btnStoreImport.Text = "Store Import";
            this.btnStoreImport.TextOffset = new System.Drawing.Point(-5, 0);
            this.btnStoreImport.Click += new System.EventHandler(this.btnStoreImport_Click);
            // 
            // btnManageStock
            // 
            this.btnManageStock.BackColor = System.Drawing.Color.Transparent;
            this.btnManageStock.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnManageStock.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnManageStock.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnManageStock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnManageStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageStock.FillColor = System.Drawing.Color.Transparent;
            this.btnManageStock.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageStock.ForeColor = System.Drawing.Color.White;
            this.btnManageStock.Image = global::PBL3.Properties.Resources.manageOrder;
            this.btnManageStock.ImageOffset = new System.Drawing.Point(-10, 0);
            this.btnManageStock.Location = new System.Drawing.Point(0, 112);
            this.btnManageStock.Name = "btnManageStock";
            this.btnManageStock.PressedColor = System.Drawing.Color.White;
            this.btnManageStock.PressedDepth = 20;
            this.btnManageStock.Size = new System.Drawing.Size(170, 46);
            this.btnManageStock.TabIndex = 2;
            this.btnManageStock.Text = "View Stock";
            this.btnManageStock.TextOffset = new System.Drawing.Point(-7, 0);
            this.btnManageStock.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // btnNewStock
            // 
            this.btnNewStock.BackColor = System.Drawing.Color.Transparent;
            this.btnNewStock.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNewStock.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNewStock.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNewStock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNewStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewStock.FillColor = System.Drawing.Color.Transparent;
            this.btnNewStock.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewStock.ForeColor = System.Drawing.Color.White;
            this.btnNewStock.Image = global::PBL3.Properties.Resources.newOrder;
            this.btnNewStock.ImageOffset = new System.Drawing.Point(-1, 0);
            this.btnNewStock.Location = new System.Drawing.Point(0, 66);
            this.btnNewStock.Name = "btnNewStock";
            this.btnNewStock.PressedColor = System.Drawing.Color.White;
            this.btnNewStock.PressedDepth = 20;
            this.btnNewStock.Size = new System.Drawing.Size(170, 46);
            this.btnNewStock.TabIndex = 1;
            this.btnNewStock.Text = "New Stock Item";
            this.btnNewStock.TextOffset = new System.Drawing.Point(1, 0);
            this.btnNewStock.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // btnOverview
            // 
            this.btnOverview.BackColor = System.Drawing.Color.Transparent;
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
            this.btnOverview.Location = new System.Drawing.Point(0, 20);
            this.btnOverview.Name = "btnOverview";
            this.btnOverview.PressedColor = System.Drawing.Color.White;
            this.btnOverview.PressedDepth = 20;
            this.btnOverview.Size = new System.Drawing.Size(170, 46);
            this.btnOverview.TabIndex = 0;
            this.btnOverview.Text = "Overview";
            this.btnOverview.TextOffset = new System.Drawing.Point(-10, 0);
            this.btnOverview.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // pnRight
            // 
            this.pnRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            this.pnRight.Location = new System.Drawing.Point(170, 62);
            this.pnRight.Name = "pnRight";
            this.pnRight.Size = new System.Drawing.Size(744, 469);
            this.pnRight.TabIndex = 4;
            // 
            // lbDate
            // 
            this.lbDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDate.BackColor = System.Drawing.Color.Transparent;
            this.lbDate.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(79)))), ((int)(((byte)(134)))));
            this.lbDate.Location = new System.Drawing.Point(182, 34);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(67, 22);
            this.lbDate.TabIndex = 9;
            this.lbDate.Text = "03/31/2022";
            // 
            // lbWelcome
            // 
            this.lbWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lbWelcome.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(79)))), ((int)(((byte)(134)))));
            this.lbWelcome.Location = new System.Drawing.Point(180, 8);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(134, 32);
            this.lbWelcome.TabIndex = 8;
            this.lbWelcome.Text = "Welcome, Y/N";
            // 
            // StockkeeperForm
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
            this.Name = "StockkeeperForm";
            this.Text = "Stockkeeper";
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.pnMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2GradientPanel pnTop;
        private Guna.UI2.WinForms.Guna2ImageButton btnLogout;
        private Guna.UI2.WinForms.Guna2ImageButton btnSettings;
        private Guna.UI2.WinForms.Guna2GradientPanel pnMenu;
        private Guna.UI2.WinForms.Guna2Button btnManageStock;
        private Guna.UI2.WinForms.Guna2Button btnNewStock;
        private Guna.UI2.WinForms.Guna2Button btnOverview;
        private Guna.UI2.WinForms.Guna2GradientPanel pnRight;
        private Guna.UI2.WinForms.Guna2Button btnStoreImport;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbWelcome;
    }
}