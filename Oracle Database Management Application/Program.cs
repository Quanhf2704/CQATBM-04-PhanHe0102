﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oracle_Database_Management_Application
{
    public static class Account
    {
        public static string username = "userdba";
        public static string password = "111";
        public static string connectString;
        public static string host = "localhost";
        public static int port = 1521;
        public static string sid = "XEPDB1";

    }

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
            Application.Run(new LoginWindow());
            //Application.Run(new TruongKhoaWindows());
            //Application.Run(new NHANVIENCOBAN_Windows());
            //Application.Run(new GIANGVIEN_Windows());
        }
    }
}
