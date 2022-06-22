using PBL3.DTO;
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
using PBL3.BLL;

namespace PBL3.View.StockkeeperChildForms
{
    public partial class AddNewProduct : Form
    {
        public delegate void My_Del(Product product, double importPrice);
        
        public My_Del MyDel { get; set; }
        bool addCategory = true;
        bool addPublisher = true;
        public AddNewProduct()
        {
            InitializeComponent();
            foreach (string i in BLLProductManagement.Instance.GetAllProductCategory().Distinct())
            {
                cbbCatogory.Items.Add(i);
            }
            foreach (string i in BLLProductManagement.Instance.GetAllProductPublisher().Distinct())
            {
                if(i != null)
                {
                    cbbPublisher.Items.Add(i);
                }
            }
            tbCategory.Visible = false;
            tbPublisher.Visible = false;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (tbPublishYear.IconRightSize == new System.Drawing.Size(7, 7) || tbQuantity.IconRightSize == new System.Drawing.Size(7, 7) || tbName.IconRightSize == new System.Drawing.Size(7, 7) 
                || tbAuthor.IconRightSize == new System.Drawing.Size(7, 7) || tbImportPrice.IconRightSize == new System.Drawing.Size(7, 7) || cbbCatogory.SelectedItem == null && tbCategory.Text == ""||cbbPublisher.SelectedItem == null && tbPublisher.Text == "")
                CustomMessageBox.MessageBox.Show("Enter missing product information", "Wrong input", MessageBoxIcon.Error);
            else
            {
                if(tbCategory.Visible) AddNewCategory(tbCategory.Text);
                if(tbPublisher.Visible) AddNewPublisher(tbPublisher.Text);
                var random = new RandomGenerator();
                Product p = new Product
                {
                    ProductID = "p" + BLL.BLLProductManagement.Instance.GenerateID().ToString(),
                    ProductName = tbName.Text,
                    Author = tbAuthor.Text,
                    Category = (tbCategory.Visible == false ? cbbCatogory.SelectedItem.ToString() : tbCategory.Text),
                    StockQuantity = Convert.ToInt32(tbQuantity.Text),
                    StoreQuantity = 0,
                    Publisher = (tbPublisher.Visible == false ? cbbPublisher.SelectedItem.ToString() : tbPublisher.Text),
                    PublishYear = Convert.ToInt32(tbPublishYear.Text),
                    Status = "Available",
                    SellingPrice = Convert.ToInt32(tbImportPrice.Text) * 1.2,
                    DiscountID = null,
                };
                MyDel(p, Convert.ToDouble(tbImportPrice.Text));
                this.Close();
            }
        }

        public void AddNewCategory(string newCategory)
        {
            bool categoryExist = false;
            List<string> listCategory = new List<string>(); 
            foreach (string i in cbbCatogory.Items)
            {
                listCategory.Add(i);
            }
            foreach (string s in listCategory)
            {
                if (newCategory == s || newCategory == "")
                {
                    categoryExist = true;
                }
            }
            if(!categoryExist)
                cbbCatogory.Items.Add(newCategory);
        }

        public void AddNewPublisher(string newPublisher)
        {
            List<string> listPublisher = new List<string>();
            bool publisherExist = true;
            foreach (string i in cbbPublisher.Items)
            {
                listPublisher.Add(i);
            }
            foreach (string s in listPublisher)
            {
                if (newPublisher == s || newPublisher == "")
                {
                    publisherExist = false;
                }
            }
            if (publisherExist) 
                cbbPublisher.Items.Add(newPublisher);
        }

        private void tb_TextChanged(object sender, EventArgs e)
        {
            if (tbPublishYear.Text == "" || tbPublishYear.Text.Length != 4 || DataCheck.IsNumber(tbPublishYear.Text) != true ) tbPublishYear.IconRightSize = new System.Drawing.Size(7, 7);
            else tbPublishYear.IconRightSize = new System.Drawing.Size(0, 0);
            if (tbQuantity.Text == "" ||DataCheck.IsNumber(tbQuantity.Text) != true) tbQuantity.IconRightSize = new System.Drawing.Size(7, 7);
            else tbQuantity.IconRightSize = new System.Drawing.Size(0, 0);
            if (tbName.Text == "" || DataCheck.IsString(tbName.Text) != true) tbName.IconRightSize = new System.Drawing.Size(7, 7);
            else tbName.IconRightSize = new System.Drawing.Size(0, 0);
            if (tbAuthor.Text == "" || DataCheck.IsString(tbAuthor.Text) != true) tbAuthor.IconRightSize = new System.Drawing.Size(7, 7);
            else tbAuthor.IconRightSize = new System.Drawing.Size(0, 0);
            if (tbImportPrice.Text == "" || DataCheck.IsNumber(tbImportPrice.Text) != true) tbImportPrice.IconRightSize = new System.Drawing.Size(7, 7);
            else tbImportPrice.IconRightSize = new System.Drawing.Size(0, 0);
            if (DataCheck.IsString(tbCategory.Text) != true) tbCategory.IconRightSize = new System.Drawing.Size(7, 7);
            else tbCategory.IconRightSize = new System.Drawing.Size(0, 0);
            if (DataCheck.IsString(tbPublisher.Text) != true) tbPublisher.IconRightSize = new System.Drawing.Size(7, 7);
            else tbPublisher.IconRightSize = new System.Drawing.Size(0, 0);
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (addCategory)
            {
                ((Guna.UI2.WinForms.Guna2Button)sender).Image = Properties.Resources.iconClose;
                tbCategory.Visible = true;
                addCategory = false;
            }
            else
            {
                ((Guna.UI2.WinForms.Guna2Button)sender).Image = Properties.Resources.icons8_plus_48;
                tbCategory.Visible = false;
                addCategory = true;
            }
        }

        private void btnAddPublisher_Click(object sender, EventArgs e)
        {
            if (addPublisher)
            {
                ((Guna.UI2.WinForms.Guna2Button)sender).Image = Properties.Resources.iconClose;
                tbPublisher.Visible = true;
                addPublisher = false;
            }
            else
            {
                ((Guna.UI2.WinForms.Guna2Button)sender).Image = Properties.Resources.icons8_plus_48;
                tbPublisher.Visible = false;
                addPublisher = true;
            }
        }
    }
}
