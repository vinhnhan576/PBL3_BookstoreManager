namespace PBL3.View.AdminChildForms
{
    partial class OverviewForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label9 = new System.Windows.Forms.Label();
            this.lbNoCustomer = new System.Windows.Forms.Label();
            this.pnInfo = new Guna.UI2.WinForms.Guna2Panel();
            this.lbEmail = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnProfile = new Guna.UI2.WinForms.Guna2Panel();
            this.lbRole = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pnStatistics = new Guna.UI2.WinForms.Guna2Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pbVisitors = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbGrossRevenue = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbProducts = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.pnTime = new Guna.UI2.WinForms.Guna2Panel();
            this.btnThisYear = new Guna.UI2.WinForms.Guna2Button();
            this.btnThisMonth = new Guna.UI2.WinForms.Guna2Button();
            this.btnThisWeek = new Guna.UI2.WinForms.Guna2Button();
            this.btnLast30days = new Guna.UI2.WinForms.Guna2Button();
            this.btnLast7days = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).BeginInit();
            this.pnInfo.SuspendLayout();
            this.pnProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.pnStatistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVisitors)).BeginInit();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.pnTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartRevenue
            // 
            this.chartRevenue.BackColor = System.Drawing.Color.Transparent;
            this.chartRevenue.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(148)))), ((int)(((byte)(149)))));
            chartArea1.AxisX.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI Historic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(148)))), ((int)(((byte)(149)))));
            chartArea1.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartRevenue.ChartAreas.Add(chartArea1);
            this.chartRevenue.Location = new System.Drawing.Point(3, 23);
            this.chartRevenue.Name = "chartRevenue";
            this.chartRevenue.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartRevenue.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black};
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(224)))), ((int)(((byte)(239)))));
            series1.BorderColor = System.Drawing.Color.Blue;
            series1.BorderWidth = 0;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartRevenue.Series.Add(series1);
            this.chartRevenue.Size = new System.Drawing.Size(460, 258);
            this.chartRevenue.TabIndex = 5;
            this.chartRevenue.Text = "chart1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkGray;
            this.label9.Location = new System.Drawing.Point(54, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 18);
            this.label9.TabIndex = 14;
            this.label9.Text = "Total";
            // 
            // lbNoCustomer
            // 
            this.lbNoCustomer.BackColor = System.Drawing.Color.White;
            this.lbNoCustomer.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNoCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(79)))), ((int)(((byte)(134)))));
            this.lbNoCustomer.Location = new System.Drawing.Point(7, 49);
            this.lbNoCustomer.Name = "lbNoCustomer";
            this.lbNoCustomer.Size = new System.Drawing.Size(138, 32);
            this.lbNoCustomer.TabIndex = 10;
            this.lbNoCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnInfo
            // 
            this.pnInfo.BackColor = System.Drawing.Color.Transparent;
            this.pnInfo.BorderRadius = 12;
            this.pnInfo.Controls.Add(this.lbEmail);
            this.pnInfo.Controls.Add(this.label6);
            this.pnInfo.Controls.Add(this.lbAddress);
            this.pnInfo.Controls.Add(this.label4);
            this.pnInfo.Controls.Add(this.lbTel);
            this.pnInfo.Controls.Add(this.label5);
            this.pnInfo.Controls.Add(this.lbGender);
            this.pnInfo.Controls.Add(this.label7);
            this.pnInfo.FillColor = System.Drawing.Color.White;
            this.pnInfo.Location = new System.Drawing.Point(540, 222);
            this.pnInfo.Name = "pnInfo";
            this.pnInfo.ShadowDecoration.Depth = 7;
            this.pnInfo.ShadowDecoration.Enabled = true;
            this.pnInfo.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 7, 7);
            this.pnInfo.Size = new System.Drawing.Size(216, 231);
            this.pnInfo.TabIndex = 20;
            // 
            // lbEmail
            // 
            this.lbEmail.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(79)))), ((int)(((byte)(134)))));
            this.lbEmail.Location = new System.Drawing.Point(38, 190);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(164, 23);
            this.lbEmail.TabIndex = 8;
            this.lbEmail.Text = "labelEmail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(187)))), ((int)(((byte)(208)))));
            this.label6.Location = new System.Drawing.Point(38, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Email";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbAddress
            // 
            this.lbAddress.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(79)))), ((int)(((byte)(134)))));
            this.lbAddress.Location = new System.Drawing.Point(38, 136);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(164, 23);
            this.lbAddress.TabIndex = 6;
            this.lbAddress.Text = "lableAddress";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(187)))), ((int)(((byte)(208)))));
            this.label4.Location = new System.Drawing.Point(38, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Address";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbTel
            // 
            this.lbTel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(79)))), ((int)(((byte)(134)))));
            this.lbTel.Location = new System.Drawing.Point(38, 81);
            this.lbTel.Name = "lbTel";
            this.lbTel.Size = new System.Drawing.Size(160, 23);
            this.lbTel.TabIndex = 4;
            this.lbTel.Text = "labelTel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(187)))), ((int)(((byte)(208)))));
            this.label5.Location = new System.Drawing.Point(38, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tel";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbGender
            // 
            this.lbGender.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(79)))), ((int)(((byte)(134)))));
            this.lbGender.Location = new System.Drawing.Point(38, 32);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(160, 23);
            this.lbGender.TabIndex = 3;
            this.lbGender.Text = "lableGender";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(187)))), ((int)(((byte)(208)))));
            this.label7.Location = new System.Drawing.Point(38, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Gender";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnProfile
            // 
            this.pnProfile.BackColor = System.Drawing.Color.Transparent;
            this.pnProfile.BorderRadius = 12;
            this.pnProfile.Controls.Add(this.lbRole);
            this.pnProfile.Controls.Add(this.lbName);
            this.pnProfile.Controls.Add(this.guna2CirclePictureBox1);
            this.pnProfile.FillColor = System.Drawing.Color.White;
            this.pnProfile.Location = new System.Drawing.Point(540, 20);
            this.pnProfile.Name = "pnProfile";
            this.pnProfile.ShadowDecoration.Depth = 7;
            this.pnProfile.ShadowDecoration.Enabled = true;
            this.pnProfile.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 7, 7);
            this.pnProfile.Size = new System.Drawing.Size(216, 185);
            this.pnProfile.TabIndex = 19;
            // 
            // lbRole
            // 
            this.lbRole.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(79)))), ((int)(((byte)(134)))));
            this.lbRole.Location = new System.Drawing.Point(20, 158);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(182, 18);
            this.lbRole.TabIndex = 2;
            this.lbRole.Text = "labelRole";
            this.lbRole.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbName
            // 
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(79)))), ((int)(((byte)(134)))));
            this.lbName.Location = new System.Drawing.Point(2, 136);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(212, 45);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "labelName";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::PBL3.Properties.Resources.adminVector;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(51, 10);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.BorderRadius = 5;
            this.guna2CirclePictureBox1.ShadowDecoration.Depth = 20;
            this.guna2CirclePictureBox1.ShadowDecoration.Enabled = true;
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(115, 115);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 0;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // pnStatistics
            // 
            this.pnStatistics.BackColor = System.Drawing.Color.Transparent;
            this.pnStatistics.BorderRadius = 12;
            this.pnStatistics.Controls.Add(this.label8);
            this.pnStatistics.Controls.Add(this.chartRevenue);
            this.pnStatistics.FillColor = System.Drawing.Color.White;
            this.pnStatistics.Location = new System.Drawing.Point(19, 178);
            this.pnStatistics.Name = "pnStatistics";
            this.pnStatistics.ShadowDecoration.Depth = 7;
            this.pnStatistics.ShadowDecoration.Enabled = true;
            this.pnStatistics.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 7, 7);
            this.pnStatistics.Size = new System.Drawing.Size(500, 276);
            this.pnStatistics.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(79)))), ((int)(((byte)(134)))));
            this.label8.Location = new System.Drawing.Point(397, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 23);
            this.label8.TabIndex = 10;
            this.label8.Text = "Statistics";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.White;
            this.guna2PictureBox1.Image = global::PBL3.Properties.Resources.sales;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(11, 10);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(40, 37);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 15;
            this.guna2PictureBox1.TabStop = false;
            // 
            // pbVisitors
            // 
            this.pbVisitors.BackColor = System.Drawing.Color.White;
            this.pbVisitors.Image = global::PBL3.Properties.Resources.visitorsIcon;
            this.pbVisitors.ImageRotate = 0F;
            this.pbVisitors.Location = new System.Drawing.Point(12, 12);
            this.pbVisitors.Name = "pbVisitors";
            this.pbVisitors.Size = new System.Drawing.Size(40, 37);
            this.pbVisitors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbVisitors.TabIndex = 13;
            this.pbVisitors.TabStop = false;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel3.BorderRadius = 12;
            this.guna2Panel3.Controls.Add(this.lbGrossRevenue);
            this.guna2Panel3.Controls.Add(this.label11);
            this.guna2Panel3.Controls.Add(this.label13);
            this.guna2Panel3.Controls.Add(this.guna2PictureBox3);
            this.guna2Panel3.FillColor = System.Drawing.Color.White;
            this.guna2Panel3.Location = new System.Drawing.Point(367, 72);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Depth = 7;
            this.guna2Panel3.ShadowDecoration.Enabled = true;
            this.guna2Panel3.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 7, 7);
            this.guna2Panel3.Size = new System.Drawing.Size(151, 91);
            this.guna2Panel3.TabIndex = 24;
            // 
            // lbGrossRevenue
            // 
            this.lbGrossRevenue.BackColor = System.Drawing.Color.White;
            this.lbGrossRevenue.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGrossRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(79)))), ((int)(((byte)(134)))));
            this.lbGrossRevenue.Location = new System.Drawing.Point(6, 49);
            this.lbGrossRevenue.Name = "lbGrossRevenue";
            this.lbGrossRevenue.Size = new System.Drawing.Size(138, 32);
            this.lbGrossRevenue.TabIndex = 18;
            this.lbGrossRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkGray;
            this.label11.Location = new System.Drawing.Point(51, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 18);
            this.label11.TabIndex = 18;
            this.label11.Text = "Total";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkGray;
            this.label13.Location = new System.Drawing.Point(50, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 16);
            this.label13.TabIndex = 19;
            this.label13.Text = "gross revenue";
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.BackColor = System.Drawing.Color.White;
            this.guna2PictureBox3.Image = global::PBL3.Properties.Resources.upIcon1;
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(18, 12);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(29, 28);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox3.TabIndex = 17;
            this.guna2PictureBox3.TabStop = false;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 12;
            this.guna2Panel1.Controls.Add(this.lbProducts);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.label10);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(193, 72);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Depth = 7;
            this.guna2Panel1.ShadowDecoration.Enabled = true;
            this.guna2Panel1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 7, 7);
            this.guna2Panel1.Size = new System.Drawing.Size(151, 91);
            this.guna2Panel1.TabIndex = 23;
            // 
            // lbProducts
            // 
            this.lbProducts.BackColor = System.Drawing.Color.White;
            this.lbProducts.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(79)))), ((int)(((byte)(134)))));
            this.lbProducts.Location = new System.Drawing.Point(6, 49);
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.Size = new System.Drawing.Size(138, 32);
            this.lbProducts.TabIndex = 16;
            this.lbProducts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(52, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Total";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkGray;
            this.label10.Location = new System.Drawing.Point(51, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "products sold";
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel4.BorderRadius = 12;
            this.guna2Panel4.Controls.Add(this.label9);
            this.guna2Panel4.Controls.Add(this.label12);
            this.guna2Panel4.Controls.Add(this.lbNoCustomer);
            this.guna2Panel4.Controls.Add(this.pbVisitors);
            this.guna2Panel4.FillColor = System.Drawing.Color.White;
            this.guna2Panel4.Location = new System.Drawing.Point(19, 72);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.ShadowDecoration.Depth = 7;
            this.guna2Panel4.ShadowDecoration.Enabled = true;
            this.guna2Panel4.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 7, 7);
            this.guna2Panel4.Size = new System.Drawing.Size(151, 91);
            this.guna2Panel4.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkGray;
            this.label12.Location = new System.Drawing.Point(53, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 18);
            this.label12.TabIndex = 15;
            this.label12.Text = "visitors";
            // 
            // pnTime
            // 
            this.pnTime.BackColor = System.Drawing.Color.Transparent;
            this.pnTime.BorderRadius = 12;
            this.pnTime.Controls.Add(this.btnThisYear);
            this.pnTime.Controls.Add(this.btnThisMonth);
            this.pnTime.Controls.Add(this.btnThisWeek);
            this.pnTime.Controls.Add(this.btnLast30days);
            this.pnTime.Controls.Add(this.btnLast7days);
            this.pnTime.FillColor = System.Drawing.Color.White;
            this.pnTime.Location = new System.Drawing.Point(19, 20);
            this.pnTime.Name = "pnTime";
            this.pnTime.ShadowDecoration.Depth = 7;
            this.pnTime.ShadowDecoration.Enabled = true;
            this.pnTime.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 7, 7);
            this.pnTime.Size = new System.Drawing.Size(500, 36);
            this.pnTime.TabIndex = 25;
            // 
            // btnThisYear
            // 
            this.btnThisYear.BorderRadius = 12;
            this.btnThisYear.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(134)))), ((int)(((byte)(183)))));
            this.btnThisYear.CustomBorderThickness = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnThisYear.CustomizableEdges.BottomLeft = false;
            this.btnThisYear.CustomizableEdges.TopLeft = false;
            this.btnThisYear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThisYear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThisYear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThisYear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThisYear.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnThisYear.FillColor = System.Drawing.Color.White;
            this.btnThisYear.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnThisYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(134)))), ((int)(((byte)(183)))));
            this.btnThisYear.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(134)))), ((int)(((byte)(183)))));
            this.btnThisYear.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(134)))), ((int)(((byte)(183)))));
            this.btnThisYear.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(134)))), ((int)(((byte)(183)))));
            this.btnThisYear.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnThisYear.Location = new System.Drawing.Point(414, 0);
            this.btnThisYear.Name = "btnThisYear";
            this.btnThisYear.Size = new System.Drawing.Size(86, 36);
            this.btnThisYear.TabIndex = 4;
            this.btnThisYear.Text = "This year";
            this.btnThisYear.Click += new System.EventHandler(this.btnThisYear_Click);
            // 
            // btnThisMonth
            // 
            this.btnThisMonth.BorderRadius = 12;
            this.btnThisMonth.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(134)))), ((int)(((byte)(183)))));
            this.btnThisMonth.CustomBorderThickness = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnThisMonth.CustomizableEdges.BottomLeft = false;
            this.btnThisMonth.CustomizableEdges.BottomRight = false;
            this.btnThisMonth.CustomizableEdges.TopLeft = false;
            this.btnThisMonth.CustomizableEdges.TopRight = false;
            this.btnThisMonth.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThisMonth.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThisMonth.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThisMonth.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThisMonth.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnThisMonth.FillColor = System.Drawing.Color.White;
            this.btnThisMonth.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnThisMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(134)))), ((int)(((byte)(183)))));
            this.btnThisMonth.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(134)))), ((int)(((byte)(183)))));
            this.btnThisMonth.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(134)))), ((int)(((byte)(183)))));
            this.btnThisMonth.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(134)))), ((int)(((byte)(183)))));
            this.btnThisMonth.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnThisMonth.Location = new System.Drawing.Point(306, 0);
            this.btnThisMonth.Name = "btnThisMonth";
            this.btnThisMonth.Size = new System.Drawing.Size(108, 36);
            this.btnThisMonth.TabIndex = 3;
            this.btnThisMonth.Text = "This month";
            // 
            // btnThisWeek
            // 
            this.btnThisWeek.BorderRadius = 12;
            this.btnThisWeek.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(134)))), ((int)(((byte)(183)))));
            this.btnThisWeek.CustomBorderThickness = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnThisWeek.CustomizableEdges.BottomLeft = false;
            this.btnThisWeek.CustomizableEdges.BottomRight = false;
            this.btnThisWeek.CustomizableEdges.TopLeft = false;
            this.btnThisWeek.CustomizableEdges.TopRight = false;
            this.btnThisWeek.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThisWeek.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThisWeek.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThisWeek.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThisWeek.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnThisWeek.FillColor = System.Drawing.Color.White;
            this.btnThisWeek.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnThisWeek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(134)))), ((int)(((byte)(183)))));
            this.btnThisWeek.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(134)))), ((int)(((byte)(183)))));
            this.btnThisWeek.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(134)))), ((int)(((byte)(183)))));
            this.btnThisWeek.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(134)))), ((int)(((byte)(183)))));
            this.btnThisWeek.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnThisWeek.Location = new System.Drawing.Point(213, 0);
            this.btnThisWeek.Name = "btnThisWeek";
            this.btnThisWeek.Size = new System.Drawing.Size(93, 36);
            this.btnThisWeek.TabIndex = 2;
            this.btnThisWeek.Text = "This week";
            this.btnThisWeek.Click += new System.EventHandler(this.btnThisWeek_Click);
            // 
            // btnLast30days
            // 
            this.btnLast30days.BorderRadius = 12;
            this.btnLast30days.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(134)))), ((int)(((byte)(183)))));
            this.btnLast30days.CustomBorderThickness = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnLast30days.CustomizableEdges.BottomLeft = false;
            this.btnLast30days.CustomizableEdges.BottomRight = false;
            this.btnLast30days.CustomizableEdges.TopLeft = false;
            this.btnLast30days.CustomizableEdges.TopRight = false;
            this.btnLast30days.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLast30days.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLast30days.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLast30days.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLast30days.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLast30days.FillColor = System.Drawing.Color.White;
            this.btnLast30days.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnLast30days.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(134)))), ((int)(((byte)(183)))));
            this.btnLast30days.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(134)))), ((int)(((byte)(183)))));
            this.btnLast30days.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(134)))), ((int)(((byte)(183)))));
            this.btnLast30days.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(134)))), ((int)(((byte)(183)))));
            this.btnLast30days.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnLast30days.Location = new System.Drawing.Point(102, 0);
            this.btnLast30days.Name = "btnLast30days";
            this.btnLast30days.Size = new System.Drawing.Size(111, 36);
            this.btnLast30days.TabIndex = 1;
            this.btnLast30days.Text = "Last 30 days";
            // 
            // btnLast7days
            // 
            this.btnLast7days.BorderRadius = 12;
            this.btnLast7days.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(134)))), ((int)(((byte)(183)))));
            this.btnLast7days.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.btnLast7days.CustomizableEdges.BottomRight = false;
            this.btnLast7days.CustomizableEdges.TopRight = false;
            this.btnLast7days.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLast7days.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLast7days.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLast7days.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLast7days.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLast7days.FillColor = System.Drawing.Color.White;
            this.btnLast7days.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnLast7days.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(134)))), ((int)(((byte)(183)))));
            this.btnLast7days.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(134)))), ((int)(((byte)(183)))));
            this.btnLast7days.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(134)))), ((int)(((byte)(183)))));
            this.btnLast7days.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(134)))), ((int)(((byte)(183)))));
            this.btnLast7days.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnLast7days.Location = new System.Drawing.Point(0, 0);
            this.btnLast7days.Name = "btnLast7days";
            this.btnLast7days.Size = new System.Drawing.Size(102, 36);
            this.btnLast7days.TabIndex = 0;
            this.btnLast7days.Text = "Last 7 days";
            // 
            // OverviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(774, 471);
            this.Controls.Add(this.pnTime);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.pnStatistics);
            this.Controls.Add(this.pnInfo);
            this.Controls.Add(this.pnProfile);
            this.Name = "OverviewForm";
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).EndInit();
            this.pnInfo.ResumeLayout(false);
            this.pnInfo.PerformLayout();
            this.pnProfile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.pnStatistics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVisitors)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            this.pnTime.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenue;
        private Guna.UI2.WinForms.Guna2PictureBox pbVisitors;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbNoCustomer;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Panel pnInfo;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Panel pnProfile;
        private System.Windows.Forms.Label lbRole;
        private System.Windows.Forms.Label lbName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Panel pnStatistics;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbGrossRevenue;
        private System.Windows.Forms.Label lbProducts;
        private Guna.UI2.WinForms.Guna2Panel pnTime;
        private Guna.UI2.WinForms.Guna2Button btnLast7days;
        private Guna.UI2.WinForms.Guna2Button btnLast30days;
        private Guna.UI2.WinForms.Guna2Button btnThisWeek;
        private Guna.UI2.WinForms.Guna2Button btnThisYear;
        private Guna.UI2.WinForms.Guna2Button btnThisMonth;
    }
}