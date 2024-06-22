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
    public partial class SINHVIEN_Windows : Form
    {
        public SINHVIEN_Windows()
        {
            InitializeComponent();
        }

        private void qldkhpButton_Click(object sender, EventArgs e)
        {
            SV_DangKyHocPhan_Windows dkhp = new SV_DangKyHocPhan_Windows();
            dkhp.Show();
            this.Hide();
        }

        private void khmoButton_Click(object sender, EventArgs e)
        {
            SV_KeHoachMoMon_Windows KHM = new SV_KeHoachMoMon_Windows();
            KHM.Show();
            this.Hide();
        }

        private void quaylaiButton_Click(object sender, EventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
            this.Hide();
        }

        private void inforbutton_Click(object sender, EventArgs e)
        {
            SV_ThongTinCaNhan_Windows INFOR = new SV_ThongTinCaNhan_Windows();
            INFOR.Show();
            this.Hide();
        }

        private void SINHVIEN_Windows_Load(object sender, EventArgs e)
        {
            Account.connectString = @"Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = "
                + Account.host + ")(PORT = " + Account.port + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
                + Account.sid + "))); Password=" + Account.password + ";User ID=" + Account.username;
        }

        private void dshpbutton_Click(object sender, EventArgs e)
        {
            SV_DanhSachHocPhan_Windows DSHP = new SV_DanhSachHocPhan_Windows();
            DSHP.Show();
            this.Hide();
        }

        private void XEMTBbutton_Click(object sender, EventArgs e)
        {
            SV_ThongBao_Windows TB = new SV_ThongBao_Windows();
            TB.Show();
            this.Hide();
        }
    }
}
