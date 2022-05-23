﻿using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.Model;

namespace PBL3.View.StockkeeperChildForms
{
    public partial class AddNewProduct : Form
    {
        public delegate void My_Del(Product product, double importPrice);
        
        public My_Del MyDel { get; set; }
        public AddNewProduct()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var random = new RandomGenerator();
            Product p = new Product
            {
                ProductID = "r00" + BLL.BLLProductManagement.Instance.CountProduct(),
                ProductName = tbName.Text,
                Author = tbAuthor.Text,
                Category = tbCatogories.Text,
                StockQuantity = Convert.ToInt32(tbQuantity.Text),
                StoreQuantity = 0,
                Publisher = tbPublisher.Text,
                PublishYear = Convert.ToInt32(tbPublishYear.Text),
                Status = "Available",
                SellingPrice = Convert.ToInt32(tbImportPrice.Text)*1.2,
                DiscountID = null,
            };
            MyDel(p, Convert.ToDouble(tbImportPrice.Text));
            this.Close();
        }
    }
}
