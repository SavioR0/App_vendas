﻿using System;
using System.Windows.Forms;
using Vendas.Service.Controllers;

namespace Vendas.View
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginUser());
            //AppManager.Start<LoginController>();
        }
    }
}