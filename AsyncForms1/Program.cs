﻿using System;
using System.Windows.Forms;

namespace Demo.AsyncForms1
{
    public class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        //to be able to run it from another project
        public string ReturnPath() => Environment.CurrentDirectory;
    }
}
