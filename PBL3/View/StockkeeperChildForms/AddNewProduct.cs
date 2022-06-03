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
        public AddNewProduct()
        {
            InitializeComponent();
            foreach (string i in BLLProductManagement.Instance.GetAllProductCategory())
            {
                cbbCatogory.Items.Add(i);
            }
            foreach (string i in BLLProductManagement.Instance.GetAllProductPublisher())
            {
                cbbPublisher.Items.Add(i);
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (tbPublishYear.IconRightSize == new System.Drawing.Size(7, 7) || tbQuantity.IconRightSize == new System.Drawing.Size(7, 7) || tbName.IconRightSize == new System.Drawing.Size(7, 7) 
                || tbAuthor.IconRightSize == new System.Drawing.Size(7, 7) || tbImportPrice.IconRightSize == new System.Drawing.Size(7, 7) || cbbCatogory.SelectedItem == null||cbbPublisher.SelectedItem == null)
                CustomMessageBox.MessageBox.Show("Enter missing product information", "Wrong input", MessageBoxIcon.Error);
            else
            {
                var random = new RandomGenerator();
                Product p = new Product
                {
                    ProductID = "r00" + BLL.BLLProductManagement.Instance.CountProduct(),
                    ProductName = tbName.Text,
                    Author = tbAuthor.Text,
                    Category = cbbCatogory.SelectedItem.ToString(),
                    StockQuantity = Convert.ToInt32(tbQuantity.Text),
                    StoreQuantity = 0,
                    Publisher = cbbPublisher.SelectedItem.ToString(),
                    PublishYear = Convert.ToInt32(tbPublishYear.Text),
                    Status = "Available",
                    SellingPrice = Convert.ToInt32(tbImportPrice.Text) * 1.2,
                    DiscountID = null,
                };
                MyDel(p, Convert.ToDouble(tbImportPrice.Text));
                this.Close();
            }
        }
        public void AddNewItem(string NewCatogory,string NewPublisher)
        {
            bool Check_1 = true,Check_2=true;
            List<string> listCatogory = new List<string>(); 
            List<string> listPublisher = new List<string>();
            foreach (string i in cbbCatogory.Items)
            {
                listCatogory.Add(i);
            }
            foreach (string s in listCatogory)
            {
                if (NewCatogory == s || NewCatogory == "")
                {
                    Check_1 = false;
                }
            }
            if(Check_1)cbbCatogory.Items.Add(NewCatogory);
            foreach (string i in cbbPublisher.Items)
            {
                listPublisher.Add(i);
            }
            foreach (string s in listPublisher)
            {
                if (NewPublisher == s || NewPublisher == "")
                {
                    Check_2 = false;
                }
            }
            if (Check_2) cbbPublisher.Items.Add(NewPublisher);
        }
        private void tbAdd_Click(object sender, EventArgs e)
        {
            AddNewItem form = new AddNewItem();
            form.MyDel = AddNewItem;
            form.Show();
        }

        private void tb_TextChanged(object sender, EventArgs e)
        {
            if (tbPublishYear.Text == "" || tbPublishYear.Text.Length != 4 || DataCheck.IsNumber(tbPublishYear.Text) != true ) tbPublishYear.IconRightSize = new System.Drawing.Size(7, 7);
            else tbPublishYear.IconRightSize = new System.Drawing.Size(0, 0);
            if (tbQuantity.Text == "" ||DataCheck.IsNumber(tbQuantity.Text) != true) tbQuantity.IconRightSize = new System.Drawing.Size(7, 7);
            else tbQuantity.IconRightSize = new System.Drawing.Size(0, 0);
            if (tbName.Text == "" || DataCheck.IsString_1(tbName.Text) != true) tbName.IconRightSize = new System.Drawing.Size(7, 7);
            else tbName.IconRightSize = new System.Drawing.Size(0, 0);
            if (tbAuthor.Text == "" || DataCheck.IsString(tbAuthor.Text) != true) tbAuthor.IconRightSize = new System.Drawing.Size(7, 7);
            else tbAuthor.IconRightSize = new System.Drawing.Size(0, 0);
            if (tbImportPrice.Text == "" || DataCheck.IsNumber(tbImportPrice.Text) != true) tbImportPrice.IconRightSize = new System.Drawing.Size(7, 7);
            else tbImportPrice.IconRightSize = new System.Drawing.Size(0, 0);
        }
    }
}
