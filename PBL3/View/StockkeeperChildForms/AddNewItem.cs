using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.View.StockkeeperChildForms
{
    public partial class AddNewItem : Form
    {
        public delegate void My_Del(string catogory, string publisher);

        public My_Del MyDel { get; set; }
        public AddNewItem()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            MyDel(tbCatogory.Text, tbPublisher.Text);
            this.Close();
        }
    }
}
