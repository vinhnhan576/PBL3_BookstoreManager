using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.View.CustomMessageBox
{
    public abstract class MessageBox
    {
        public static DialogResult Show(string text, MessageBoxIcon icon = MessageBoxIcon.Error)
        {
            DialogResult result;
            using(var msgForm = new MessageBoxForm(text, icon))
                result = msgForm.ShowDialog();
            return result;
        }

        public static DialogResult Show(string text, string title, MessageBoxIcon icon)
        {
            DialogResult result;
            using (var msgForm = new MessageBoxForm(text, title, icon))
                result = msgForm.ShowDialog();
            return result;
        }

        public static DialogResult Show(string text, string title, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            DialogResult result;
            using (var msgForm = new MessageBoxForm(text, title, buttons, icon))
                result = msgForm.ShowDialog();
            return result;
        }

        public static DialogResult Show(string text, string title, MessageBoxButtons buttons, MessageBoxDefaultButton defaultButton, MessageBoxIcon icon = MessageBoxIcon.Error)
        {
            DialogResult result;
            using (var msgForm = new MessageBoxForm(text, title, buttons, icon, defaultButton))
                result = msgForm.ShowDialog();
            return result;
        }
    }
}
