namespace PBL3.View.AdminChildForms.Product
{
    partial class Product
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbbSortCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbbFilterValue = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgvProduct = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cbbFilterCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbbSortOrder = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnUpdatePrice = new Guna.UI2.WinForms.Guna2Button();
            this.btnShowHistory = new Guna.UI2.WinForms.Guna2Button();
            this.tbSearch = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(26, 14);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(57, 21);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Search";
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
            this.cbbSortCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbSortCategory.ItemHeight = 23;
            this.cbbSortCategory.Items.AddRange(new object[] {
            "ProductID",
            "ProductName",
            "PublishYear",
            "SellingPrice",
            "StoreQuantity",
            "StockQuantity"});
            this.cbbSortCategory.Location = new System.Drawing.Point(268, 38);
            this.cbbSortCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.cbbSortCategory.Name = "cbbSortCategory";
            this.cbbSortCategory.Size = new System.Drawing.Size(119, 29);
            this.cbbSortCategory.TabIndex = 3;
            // 
            // cbbFilterValue
            // 
            this.cbbFilterValue.BackColor = System.Drawing.Color.Transparent;
            this.cbbFilterValue.BorderRadius = 10;
            this.cbbFilterValue.BorderThickness = 0;
            this.cbbFilterValue.CustomizableEdges.BottomLeft = false;
            this.cbbFilterValue.CustomizableEdges.TopLeft = false;
            this.cbbFilterValue.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbFilterValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbFilterValue.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbFilterValue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbFilterValue.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbFilterValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbFilterValue.ItemHeight = 23;
            this.cbbFilterValue.Location = new System.Drawing.Point(624, 37);
            this.cbbFilterValue.Margin = new System.Windows.Forms.Padding(2);
            this.cbbFilterValue.Name = "cbbFilterValue";
            this.cbbFilterValue.Size = new System.Drawing.Size(129, 29);
            this.cbbFilterValue.TabIndex = 7;
            this.cbbFilterValue.SelectedIndexChanged += new System.EventHandler(this.cbbFilterValue_SelectedIndexChanged);
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dgvProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduct.BackgroundColor = System.Drawing.Color.White;
            this.dgvProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(161)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(161)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvProduct.ColumnHeadersHeight = 30;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(134)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduct.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvProduct.EnableHeadersVisualStyles = false;
            this.dgvProduct.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvProduct.Location = new System.Drawing.Point(21, 120);
            this.dgvProduct.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.RowHeadersVisible = false;
            this.dgvProduct.RowHeadersWidth = 62;
            this.dgvProduct.RowTemplate.Height = 28;
            this.dgvProduct.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(732, 315);
            this.dgvProduct.TabIndex = 10;
            this.dgvProduct.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvProduct.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvProduct.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvProduct.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvProduct.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvProduct.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvProduct.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvProduct.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvProduct.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProduct.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvProduct.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvProduct.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvProduct.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvProduct.ThemeStyle.ReadOnly = true;
            this.dgvProduct.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvProduct.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProduct.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvProduct.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvProduct.ThemeStyle.RowsStyle.Height = 28;
            this.dgvProduct.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvProduct.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // cbbFilterCategory
            // 
            this.cbbFilterCategory.BackColor = System.Drawing.Color.Transparent;
            this.cbbFilterCategory.BorderRadius = 10;
            this.cbbFilterCategory.BorderThickness = 0;
            this.cbbFilterCategory.CustomizableEdges.BottomRight = false;
            this.cbbFilterCategory.CustomizableEdges.TopRight = false;
            this.cbbFilterCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbFilterCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbFilterCategory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbFilterCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbFilterCategory.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbFilterCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbFilterCategory.ItemHeight = 23;
            this.cbbFilterCategory.Items.AddRange(new object[] {
            "Category",
            "Status"});
            this.cbbFilterCategory.Location = new System.Drawing.Point(498, 37);
            this.cbbFilterCategory.Margin = new System.Windows.Forms.Padding(2);
            this.cbbFilterCategory.Name = "cbbFilterCategory";
            this.cbbFilterCategory.Size = new System.Drawing.Size(130, 29);
            this.cbbFilterCategory.TabIndex = 6;
            this.cbbFilterCategory.SelectedIndexChanged += new System.EventHandler(this.cbbFilterCategory_SelectedIndexChanged);
            // 
            // cbbSortOrder
            // 
            this.cbbSortOrder.BackColor = System.Drawing.Color.Transparent;
            this.cbbSortOrder.BorderRadius = 10;
            this.cbbSortOrder.BorderThickness = 0;
            this.cbbSortOrder.CustomizableEdges.BottomLeft = false;
            this.cbbSortOrder.CustomizableEdges.TopLeft = false;
            this.cbbSortOrder.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbSortOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSortOrder.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbSortOrder.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbSortOrder.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSortOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbSortOrder.ItemHeight = 23;
            this.cbbSortOrder.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.cbbSortOrder.Location = new System.Drawing.Point(369, 38);
            this.cbbSortOrder.Margin = new System.Windows.Forms.Padding(2);
            this.cbbSortOrder.Name = "cbbSortOrder";
            this.cbbSortOrder.Size = new System.Drawing.Size(111, 29);
            this.cbbSortOrder.TabIndex = 2;
            this.cbbSortOrder.TextOffset = new System.Drawing.Point(15, 0);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(276, 14);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(30, 21);
            this.guna2HtmlLabel2.TabIndex = 2;
            this.guna2HtmlLabel2.Text = "Sort";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(505, 14);
            this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(2);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(38, 21);
            this.guna2HtmlLabel3.TabIndex = 5;
            this.guna2HtmlLabel3.Text = "Filter";
            // 
            // btnUpdatePrice
            // 
            this.btnUpdatePrice.BorderRadius = 9;
            this.btnUpdatePrice.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdatePrice.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdatePrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdatePrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdatePrice.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(125)))), ((int)(((byte)(160)))));
            this.btnUpdatePrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePrice.ForeColor = System.Drawing.Color.White;
            this.btnUpdatePrice.Location = new System.Drawing.Point(581, 79);
            this.btnUpdatePrice.Name = "btnUpdatePrice";
            this.btnUpdatePrice.Size = new System.Drawing.Size(172, 32);
            this.btnUpdatePrice.TabIndex = 9;
            this.btnUpdatePrice.Text = "Update Price";
            this.btnUpdatePrice.Click += new System.EventHandler(this.btnUpdatePrice_Click);
            // 
            // btnShowHistory
            // 
            this.btnShowHistory.BorderRadius = 9;
            this.btnShowHistory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShowHistory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnShowHistory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShowHistory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnShowHistory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(125)))), ((int)(((byte)(160)))));
            this.btnShowHistory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowHistory.ForeColor = System.Drawing.Color.White;
            this.btnShowHistory.Location = new System.Drawing.Point(345, 79);
            this.btnShowHistory.Name = "btnShowHistory";
            this.btnShowHistory.Size = new System.Drawing.Size(224, 32);
            this.btnShowHistory.TabIndex = 8;
            this.btnShowHistory.Text = "Show store import history";
            this.btnShowHistory.Click += new System.EventHandler(this.btnShowHistory_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.tbSearch.BorderRadius = 9;
            this.tbSearch.BorderThickness = 0;
            this.tbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearch.DefaultText = "";
            this.tbSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearch.IconLeft = global::PBL3.Properties.Resources.produtIcon;
            this.tbSearch.IconLeftSize = new System.Drawing.Size(0, 0);
            this.tbSearch.IconRight = global::PBL3.Properties.Resources.icons8_search_60;
            this.tbSearch.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.tbSearch.IconRightOffset = new System.Drawing.Point(10, 0);
            this.tbSearch.IconRightSize = new System.Drawing.Size(23, 23);
            this.tbSearch.Location = new System.Drawing.Point(18, 38);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.PasswordChar = '\0';
            this.tbSearch.PlaceholderText = "";
            this.tbSearch.SelectedText = "";
            this.tbSearch.Size = new System.Drawing.Size(230, 29);
            this.tbSearch.TabIndex = 1;
            this.tbSearch.IconRightClick += new System.EventHandler(this.tbSearch_IconRightClick);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(774, 456);
            this.Controls.Add(this.cbbSortCategory);
            this.Controls.Add(this.btnShowHistory);
            this.Controls.Add(this.btnUpdatePrice);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.cbbSortOrder);
            this.Controls.Add(this.cbbFilterCategory);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.cbbFilterValue);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Product";
            this.Text = "Product";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox tbSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cbbSortCategory;
        private Guna.UI2.WinForms.Guna2ComboBox cbbFilterValue;
        private Guna.UI2.WinForms.Guna2DataGridView dgvProduct;
        private Guna.UI2.WinForms.Guna2ComboBox cbbFilterCategory;
        private Guna.UI2.WinForms.Guna2ComboBox cbbSortOrder;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2Button btnUpdatePrice;
        private Guna.UI2.WinForms.Guna2Button btnShowHistory;
    }
}