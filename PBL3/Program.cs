﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.View.StaffChildForms;
using PBL3.View.StockkeeperChildForms;
using PBL3.View.StaffChildForms;
using PBL3.View;


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
            Application.Run(new PBL3.View.AdminChildForms.AccountForm());
        }

    }
}
