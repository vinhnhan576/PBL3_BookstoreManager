namespace PBL3.View.SettingsForms
{
    partial class SettingsForm
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
            this.label8 = new System.Windows.Forms.Label();
            this.lbProfile = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.pnProfile = new Guna.UI2.WinForms.Guna2Panel();
            this.pnPassword = new Guna.UI2.WinForms.Guna2Panel();
            this.pn = new Guna.UI2.WinForms.Guna2Panel();
            this.pnMenuBar = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnMenuBar.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.label8.Location = new System.Drawing.Point(13, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 32);
            this.label8.TabIndex = 48;
            this.label8.Text = "Settings";
            // 
            // lbProfile
            // 
            this.lbProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbProfile.AutoSize = true;
            this.lbProfile.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(177)))), ((int)(((byte)(182)))));
            this.lbProfile.Location = new System.Drawing.Point(42, 5);
            this.lbProfile.Name = "lbProfile";
            this.lbProfile.Size = new System.Drawing.Size(47, 16);
            this.lbProfile.TabIndex = 68;
            this.lbProfile.Text = "Profile";
            this.lbProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbProfile.Click += new System.EventHandler(this.lbProfile_Click);
            // 
            // lbPassword
            // 
            this.lbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(177)))), ((int)(((byte)(182)))));
            this.lbPassword.Location = new System.Drawing.Point(105, 5);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(62, 16);
            this.lbPassword.TabIndex = 69;
            this.lbPassword.Text = "Password";
            this.lbPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbPassword.Click += new System.EventHandler(this.lbPassword_Click);
            // 
            // pnProfile
            // 
            this.pnProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnProfile.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(216)))), ((int)(((byte)(232)))));
            this.pnProfile.Location = new System.Drawing.Point(41, 28);
            this.pnProfile.Name = "pnProfile";
            this.pnProfile.Size = new System.Drawing.Size(66, 4);
            this.pnProfile.TabIndex = 70;
            // 
            // pnPassword
            // 
            this.pnPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(216)))), ((int)(((byte)(232)))));
            this.pnPassword.Location = new System.Drawing.Point(107, 28);
            this.pnPassword.Name = "pnPassword";
            this.pnPassword.Size = new System.Drawing.Size(90, 4);
            this.pnPassword.TabIndex = 71;
            // 
            // pn
            // 
            this.pn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn.Location = new System.Drawing.Point(0, 99);
            this.pn.Name = "pn";
            this.pn.Size = new System.Drawing.Size(774, 379);
            this.pn.TabIndex = 72;
            // 
            // pnMenuBar
            // 
            this.pnMenuBar.Controls.Add(this.pnProfile);
            this.pnMenuBar.Controls.Add(this.lbProfile);
            this.pnMenuBar.Controls.Add(this.pnPassword);
            this.pnMenuBar.Controls.Add(this.lbPassword);
            this.pnMenuBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMenuBar.Location = new System.Drawing.Point(0, 60);
            this.pnMenuBar.Name = "pnMenuBar";
            this.pnMenuBar.Size = new System.Drawing.Size(774, 39);
            this.pnMenuBar.TabIndex = 73;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.label8);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(774, 60);
            this.guna2Panel1.TabIndex = 74;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(241)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(774, 478);
            this.Controls.Add(this.pn);
            this.Controls.Add(this.pnMenuBar);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.pnMenuBar.ResumeLayout(false);
            this.pnMenuBar.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbProfile;
        private System.Windows.Forms.Label lbPassword;
        private Guna.UI2.WinForms.Guna2Panel pnProfile;
        private Guna.UI2.WinForms.Guna2Panel pnPassword;
        private Guna.UI2.WinForms.Guna2Panel pn;
        private Guna.UI2.WinForms.Guna2Panel pnMenuBar;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}