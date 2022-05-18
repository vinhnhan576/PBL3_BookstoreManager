using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.View.CustomMessageBox
{
    public partial class MessageBoxForm : Form
    {
        private int borderSize = 2;
        public MessageBoxForm(string text)
        {
            InitializeComponent();
        }

        private void InitializeGUI()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
            
        }

        private void SetFormSize()
        {

        }

        private void SetButtons()
        {

        }

        private void SetIcon()
        {

        }


    }
}
