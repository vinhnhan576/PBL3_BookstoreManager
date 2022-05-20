﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.View.StaffChildForms;
using PBL3.View.AdminChildForms;
using PBL3.View;
using PBL3.BLL;


namespace PBL3
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            BLLCustomerManagement.Instance.Refresh();
            Application.Run(new LoginForm());
        }

    }
}
