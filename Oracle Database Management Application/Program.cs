using System;
using System.Windows.Forms;

namespace Oracle_Database_Management_Application
{
    public static class Account
    {
        public static string username = "userdba";
        public static string password = "123";
        public static string connectString;
        public static string host = "localhost";
        public static int port = 1521;
        public static string sid = "xe";

    }

    public static class Minister
    {
        public static string username = "NV008";
        public static string password = "123";
        public static string connectString;
        public static string host = "localhost";
        public static int port = 1521;
        public static string sid = "xe";

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
        }
    }
}
