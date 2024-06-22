using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oracle_Database_Management_Application
{
    public partial class NHANVIENCOBAN_Windows : Form
    { 
        public NHANVIENCOBAN_Windows()
        {
            InitializeComponent();
        }

        private void svbutton_Click(object sender, EventArgs e)
        {
           NV_DSSV_Windows DSSV = new NV_DSSV_Windows();
            DSSV.Show();
            this.Hide();
        }

        private void viewInforbutton_Click(object sender, EventArgs e)
        {
            NVCB_INFORMATION nVCB_INFORMATION = new NVCB_INFORMATION();
            nVCB_INFORMATION.Show();
            this.Hide();
        }

        private void NHANVIENCOBAN_Windows_Load(object sender, EventArgs e)
        {
/*            Account.username = "NV098";
            Account.password = "123";*/
            Account.connectString = @"Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = "
                + Account.host + ")(PORT = " + Account.port + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
                + Account.sid + "))); Password=" + Account.password + ";User ID=" + Account.username;
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
            this.Hide();
        }

        private void dvbutton_Click(object sender, EventArgs e)
        {
            NV_DSDV_Windows dSDV_Windows = new NV_DSDV_Windows();
            dSDV_Windows.Show();
            this.Hide();
        }

        private void hpbutton_Click(object sender, EventArgs e)
        {
            NV_DSHP_Windows dshp = new NV_DSHP_Windows();
            dshp.Show();
            this.Hide();
        }

        private void khmobutton_Click(object sender, EventArgs e)
        {
            NV_KHMO_Windows KHMO = new NV_KHMO_Windows();
            KHMO.Show();
            this.Hide();
        }
    }
}
