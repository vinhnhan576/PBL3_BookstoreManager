namespace PBL3.View.LoginForms
{
    partial class ForgotPasswordForm
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pn = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCode = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lbCode = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tbCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnVerify = new Guna.UI2.WinForms.Guna2GradientButton();
            this.tbEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pbReturn = new System.Windows.Forms.PictureBox();
            this.lbIntro = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pbForgotPassword = new System.Windows.Forms.PictureBox();
            this.guna2Panel1.SuspendLayout();
            this.pn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbForgotPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.pn);
            this.guna2Panel1.Controls.Add(this.pbReturn);
            this.guna2Panel1.Controls.Add(this.lbIntro);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Panel1.Location = new System.Drawing.Point(565, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(349, 531);
            this.guna2Panel1.TabIndex = 11;
            // 
            // pn
            // 
            this.pn.Controls.Add(this.btnCode);
            this.pn.Controls.Add(this.lbCode);
            this.pn.Controls.Add(this.tbCode);
            this.pn.Controls.Add(this.btnVerify);
            this.pn.Controls.Add(this.tbEmail);
            this.pn.Controls.Add(this.guna2HtmlLabel1);
            this.pn.Location = new System.Drawing.Point(30, 152);
            this.pn.Name = "pn";
            this.pn.Size = new System.Drawing.Size(300, 350);
            this.pn.TabIndex = 0;
            // 
            // btnCode
            // 
            this.btnCode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCode.Animated = true;
            this.btnCode.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCode.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCode.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCode.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(168)))), ((int)(((byte)(157)))));
            this.btnCode.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(210)))), ((int)(((byte)(185)))));
            this.btnCode.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCode.ForeColor = System.Drawing.Color.White;
            this.btnCode.Location = new System.Drawing.Point(17, 250);
            this.btnCode.Name = "btnCode";
            this.btnCode.Size = new System.Drawing.Size(267, 45);
            this.btnCode.TabIndex = 3;
            this.btnCode.Text = "Enter verification code";
            this.btnCode.Click += new System.EventHandler(this.btnCode_Click);
            // 
            // lbCode
            // 
            this.lbCode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbCode.BackColor = System.Drawing.Color.Transparent;
            this.lbCode.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(194)))), ((int)(((byte)(185)))));
            this.lbCode.Location = new System.Drawing.Point(21, 167);
            this.lbCode.Name = "lbCode";
            this.lbCode.Size = new System.Drawing.Size(132, 25);
            this.lbCode.TabIndex = 12;
            this.lbCode.Text = "Verification code";
            // 
            // tbCode
            // 
            this.tbCode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbCode.BackColor = System.Drawing.Color.Transparent;
            this.tbCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(194)))), ((int)(((byte)(185)))));
            this.tbCode.BorderThickness = 2;
            this.tbCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCode.DefaultText = "";
            this.tbCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(194)))), ((int)(((byte)(185)))));
            this.tbCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCode.IconLeftOffset = new System.Drawing.Point(8, 0);
            this.tbCode.Location = new System.Drawing.Point(17, 192);
            this.tbCode.Name = "tbCode";
            this.tbCode.PasswordChar = '\0';
            this.tbCode.PlaceholderText = "";
            this.tbCode.SelectedText = "";
            this.tbCode.ShadowDecoration.BorderRadius = 0;
            this.tbCode.ShadowDecoration.Depth = 0;
            this.tbCode.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.tbCode.Size = new System.Drawing.Size(267, 41);
            this.tbCode.TabIndex = 2;
            this.tbCode.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // btnVerify
            // 
            this.btnVerify.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnVerify.Animated = true;
            this.btnVerify.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVerify.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVerify.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVerify.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVerify.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVerify.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(168)))), ((int)(((byte)(157)))));
            this.btnVerify.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(210)))), ((int)(((byte)(185)))));
            this.btnVerify.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerify.ForeColor = System.Drawing.Color.White;
            this.btnVerify.Location = new System.Drawing.Point(17, 88);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(267, 45);
            this.btnVerify.TabIndex = 1;
            this.btnVerify.Text = "Send verification code";
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbEmail.BackColor = System.Drawing.Color.Transparent;
            this.tbEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(194)))), ((int)(((byte)(185)))));
            this.tbEmail.BorderThickness = 2;
            this.tbEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEmail.DefaultText = "";
            this.tbEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(194)))), ((int)(((byte)(185)))));
            this.tbEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbEmail.IconLeftOffset = new System.Drawing.Point(8, 0);
            this.tbEmail.Location = new System.Drawing.Point(17, 31);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.PasswordChar = '\0';
            this.tbEmail.PlaceholderText = "";
            this.tbEmail.SelectedText = "";
            this.tbEmail.ShadowDecoration.BorderRadius = 0;
            this.tbEmail.ShadowDecoration.Depth = 0;
            this.tbEmail.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.tbEmail.Size = new System.Drawing.Size(267, 41);
            this.tbEmail.TabIndex = 0;
            this.tbEmail.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(194)))), ((int)(((byte)(185)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(21, 7);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(44, 25);
            this.guna2HtmlLabel1.TabIndex = 4;
            this.guna2HtmlLabel1.Text = "Email";
            // 
            // pbReturn
            // 
            this.pbReturn.Image = global::PBL3.Properties.Resources._return;
            this.pbReturn.Location = new System.Drawing.Point(304, 15);
            this.pbReturn.Name = "pbReturn";
            this.pbReturn.Size = new System.Drawing.Size(28, 26);
            this.pbReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbReturn.TabIndex = 13;
            this.pbReturn.TabStop = false;
            this.pbReturn.Click += new System.EventHandler(this.pbReturn_Click);
            // 
            // lbIntro
            // 
            this.lbIntro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbIntro.AutoSize = false;
            this.lbIntro.BackColor = System.Drawing.Color.Transparent;
            this.lbIntro.Font = new System.Drawing.Font("Franklin Gothic Heavy", 33.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIntro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(194)))), ((int)(((byte)(185)))));
            this.lbIntro.Location = new System.Drawing.Point(51, 43);
            this.lbIntro.Name = "lbIntro";
            this.lbIntro.Size = new System.Drawing.Size(145, 53);
            this.lbIntro.TabIndex = 3;
            this.lbIntro.Text = "forgot";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Franklin Gothic Heavy", 33.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(194)))), ((int)(((byte)(185)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(51, 77);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(257, 63);
            this.guna2HtmlLabel2.TabIndex = 6;
            this.guna2HtmlLabel2.Text = "password :(";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::PBL3.Properties.Resources.logo_ver_2;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(-7, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(146, 76);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 9;
            this.guna2PictureBox1.TabStop = false;
            // 
            // pbForgotPassword
            // 
            this.pbForgotPassword.Image = global::PBL3.Properties.Resources.Forgot_password;
            this.pbForgotPassword.Location = new System.Drawing.Point(12, 0);
            this.pbForgotPassword.Name = "pbForgotPassword";
            this.pbForgotPassword.Size = new System.Drawing.Size(547, 548);
            this.pbForgotPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbForgotPassword.TabIndex = 12;
            this.pbForgotPassword.TabStop = false;
            // 
            // ForgotPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(194)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(914, 531);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.pbForgotPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgotPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ForgotPasswordForm";
            this.guna2Panel1.ResumeLayout(false);
            this.pn.ResumeLayout(false);
            this.pn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbForgotPassword)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2GradientButton btnVerify;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbIntro;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox tbEmail;
        private System.Windows.Forms.PictureBox pbForgotPassword;
        private System.Windows.Forms.PictureBox pbReturn;
        private Guna.UI2.WinForms.Guna2Panel pn;
        private Guna.UI2.WinForms.Guna2TextBox tbCode;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbCode;
        private Guna.UI2.WinForms.Guna2GradientButton btnCode;
    }
}