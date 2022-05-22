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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbNoCustomer = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
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
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.cbbSortCategory = new Guna.UI2.WinForms.Guna2ComboBox();
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
            this.SuspendLayout();
            // 
            // chartRevenue
            // 
            this.chartRevenue.BackColor = System.Drawing.Color.Transparent;
            this.chartRevenue.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea4.AxisX.IsLabelAutoFit = false;
            chartArea4.AxisX.LabelStyle.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea4.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(148)))), ((int)(((byte)(149)))));
            chartArea4.AxisX.LineColor = System.Drawing.Color.Gainsboro;
            chartArea4.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea4.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea4.AxisY.IsLabelAutoFit = false;
            chartArea4.AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI Historic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea4.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(148)))), ((int)(((byte)(149)))));
            chartArea4.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea4.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea4.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea4.BackColor = System.Drawing.Color.Transparent;
            chartArea4.Name = "ChartArea1";
            this.chartRevenue.ChartAreas.Add(chartArea4);
            this.chartRevenue.Location = new System.Drawing.Point(3, 36);
            this.chartRevenue.Name = "chartRevenue";
            this.chartRevenue.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartRevenue.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black};
            series4.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series4.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(224)))), ((int)(((byte)(239)))));
            series4.BorderColor = System.Drawing.Color.Blue;
            series4.BorderWidth = 0;
            series4.ChartArea = "ChartArea1";
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartRevenue.Series.Add(series4);
            this.chartRevenue.Size = new System.Drawing.Size(460, 274);
            this.chartRevenue.TabIndex = 5;
            this.chartRevenue.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(79)))), ((int)(((byte)(134)))));
            this.label2.Location = new System.Drawing.Point(20, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "45,000.00$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(79)))), ((int)(((byte)(134)))));
            this.label3.Location = new System.Drawing.Point(17, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 32);
            this.label3.TabIndex = 12;
            this.label3.Text = "10%";
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
            this.lbNoCustomer.Location = new System.Drawing.Point(7, 57);
            this.lbNoCustomer.Name = "lbNoCustomer";
            this.lbNoCustomer.Size = new System.Drawing.Size(138, 32);
            this.lbNoCustomer.TabIndex = 10;
            this.lbNoCustomer.Text = "x ";
            this.lbNoCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkGray;
            this.label10.Location = new System.Drawing.Point(56, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 18);
            this.label10.TabIndex = 15;
            this.label10.Text = "Total sales";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkGray;
            this.label11.Location = new System.Drawing.Point(51, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 18);
            this.label11.TabIndex = 16;
            this.label11.Text = "Rate up";
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
            this.pnInfo.Location = new System.Drawing.Point(538, 222);
            this.pnInfo.Name = "pnInfo";
            this.pnInfo.ShadowDecoration.Depth = 7;
            this.pnInfo.ShadowDecoration.Enabled = true;
            this.pnInfo.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 7, 7);
            this.pnInfo.Size = new System.Drawing.Size(218, 231);
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
            this.pnProfile.Location = new System.Drawing.Point(538, 20);
            this.pnProfile.Name = "pnProfile";
            this.pnProfile.ShadowDecoration.Depth = 7;
            this.pnProfile.ShadowDecoration.Enabled = true;
            this.pnProfile.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 7, 7);
            this.pnProfile.Size = new System.Drawing.Size(218, 185);
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
            this.lbName.Location = new System.Drawing.Point(3, 136);
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
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(52, 10);
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
            this.pnStatistics.Controls.Add(this.cbbSortCategory);
            this.pnStatistics.Controls.Add(this.label8);
            this.pnStatistics.Controls.Add(this.chartRevenue);
            this.pnStatistics.FillColor = System.Drawing.Color.White;
            this.pnStatistics.Location = new System.Drawing.Point(19, 141);
            this.pnStatistics.Name = "pnStatistics";
            this.pnStatistics.ShadowDecoration.Depth = 7;
            this.pnStatistics.ShadowDecoration.Enabled = true;
            this.pnStatistics.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 7, 7);
            this.pnStatistics.Size = new System.Drawing.Size(500, 313);
            this.pnStatistics.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(79)))), ((int)(((byte)(134)))));
            this.label8.Location = new System.Drawing.Point(11, 10);
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
            this.guna2Panel3.Controls.Add(this.label3);
            this.guna2Panel3.Controls.Add(this.label11);
            this.guna2Panel3.Controls.Add(this.guna2PictureBox3);
            this.guna2Panel3.FillColor = System.Drawing.Color.White;
            this.guna2Panel3.Location = new System.Drawing.Point(367, 20);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Depth = 7;
            this.guna2Panel3.ShadowDecoration.Enabled = true;
            this.guna2Panel3.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 7, 7);
            this.guna2Panel3.Size = new System.Drawing.Size(151, 101);
            this.guna2Panel3.TabIndex = 24;
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
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.label10);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(193, 20);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Depth = 7;
            this.guna2Panel1.ShadowDecoration.Enabled = true;
            this.guna2Panel1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 7, 7);
            this.guna2Panel1.Size = new System.Drawing.Size(151, 101);
            this.guna2Panel1.TabIndex = 23;
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
            this.guna2Panel4.Location = new System.Drawing.Point(19, 20);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.ShadowDecoration.Depth = 7;
            this.guna2Panel4.ShadowDecoration.Enabled = true;
            this.guna2Panel4.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 7, 7);
            this.guna2Panel4.Size = new System.Drawing.Size(151, 101);
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
            this.label12.Size = new System.Drawing.Size(82, 18);
            this.label12.TabIndex = 15;
            this.label12.Text = "customers";
            // 
            // cbbSortCategory
            // 
            this.cbbSortCategory.BackColor = System.Drawing.Color.Transparent;
            this.cbbSortCategory.BorderRadius = 10;
            this.cbbSortCategory.BorderThickness = 0;
            this.cbbSortCategory.CustomizableEdges.BottomRight = false;
            this.cbbSortCategory.CustomizableEdges.TopRight = false;
            this.cbbSortCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbSortCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSortCategory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbSortCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbSortCategory.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSortCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(79)))), ((int)(((byte)(134)))));
            this.cbbSortCategory.ItemHeight = 23;
            this.cbbSortCategory.Items.AddRange(new object[] {
            "This Day",
            "This Month",
            "This Year"});
            this.cbbSortCategory.Location = new System.Drawing.Point(367, 11);
            this.cbbSortCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.cbbSortCategory.Name = "cbbSortCategory";
            this.cbbSortCategory.Size = new System.Drawing.Size(122, 29);
            this.cbbSortCategory.TabIndex = 11;
            this.cbbSortCategory.SelectedIndexChanged += new System.EventHandler(this.cbbSortCategory_SelectedIndexChanged);
            // 
            // OverviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(774, 471);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.pnStatistics);
            this.Controls.Add(this.pnInfo);
            this.Controls.Add(this.pnProfile);
            this.Name = "OverviewForm";
            this.Text = " ";
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
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2PictureBox pbVisitors;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbNoCustomer;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label11;
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
        private Guna.UI2.WinForms.Guna2ComboBox cbbSortCategory;
    }
}