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
    public partial class GIANGVIEN_Windows : Form
    {
        public GIANGVIEN_Windows()
        {
            InitializeComponent();
        }

        private void dvbutton_Click(object sender, EventArgs e)
        {
            GV_DSDV_Windows DSDV =  new GV_DSDV_Windows();
            DSDV.Show();
            this.Hide();
        }

        private void viewInforbutton_Click(object sender, EventArgs e)
        {
            GV_INFORMATION INFOR = new GV_INFORMATION();
            INFOR.Show();
            this.Hide();
        }

        private void khmobutton_Click(object sender, EventArgs e)
        {
            GV_KHMO_Windows KHMO = new GV_KHMO_Windows();
            KHMO.Show();
            this.Hide();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
            this.Hide();
        }

        private void svbutton_Click(object sender, EventArgs e)
        {
            GV_DSSV_Windows DSSV = new GV_DSSV_Windows();
            DSSV.Show();
            this.Hide();
        }

        private void hpbutton_Click(object sender, EventArgs e)
        {
            GV_DSHP_Windows DSHP = new GV_DSHP_Windows();
            DSHP.Show();
            this.Hide();
        }

        private void GIANGVIEN_Windows_Load(object sender, EventArgs e)
        {
/*            Account.username = "NV018";
            Account.password = "123";*/
            Account.connectString = @"Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = "
                + Account.host + ")(PORT = " + Account.port + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
                + Account.sid + "))); Password=" + Account.password + ";User ID=" + Account.username;
        }

        private void PHANCONGbutton_Click(object sender, EventArgs e)
        {
            GV_PHANCONG_Windows PC = new GV_PHANCONG_Windows();
            PC.Show();
            this.Hide();
        }

        private void SVDKbutton_Click(object sender, EventArgs e)
        {
            GV_DK_Windows SDK = new GV_DK_Windows();
            SDK.Show();
            this.Hide();
        }

        private void CAPNHATDIEMbutton_Click(object sender, EventArgs e)
        {
            GV_UPDATE_DIEM_Windows UPDATE = new GV_UPDATE_DIEM_Windows();
            UPDATE.Show();
            this.Hide();
        }
    }
}
