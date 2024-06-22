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
    public partial class TruongKhoaWindows : Form
    {
        public TruongKhoaWindows()
        {
            InitializeComponent();
        }

        private void dssvButton_Click(object sender, EventArgs e)
        {
            TK_DSSV_Windows tK_DSSV_Windows = new TK_DSSV_Windows();
            tK_DSSV_Windows.Show();
            this.Hide();
        }

        private void TruongKhoaWindows_Load(object sender, EventArgs e)
        {
           /* Account.username = "NV001";
            Account.password = "123";*/
            Account.connectString = @"Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = "
                + Account.host + ")(PORT = " + Account.port + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
                + Account.sid + "))); Password=" + Account.password + ";User ID=" + Account.username;
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = Account.connectString;
            OracleCommand cmd = new OracleCommand("SELECT * FROM USERDBA.PHANCONG", conn);
            try
            {
                conn.Open();
                OracleDataReader rd = cmd.ExecuteReader();
  
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dsdvButton_Click(object sender, EventArgs e)
        {
            TK_DSDV_Windows tK_DSDV = new TK_DSDV_Windows();
            tK_DSDV.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           TK_DSHP_Windows tK_DSHP = new TK_DSHP_Windows();
           tK_DSHP.Show();
           this.Hide();
        }

        private void quaylaiButton_Click(object sender, EventArgs e)
        {
            LoginWindow login  = new LoginWindow();
            login.Show();
            this.Hide();
        }

        private void phancongButton_Click(object sender, EventArgs e)
        {
            TK_PHANCONG_Windows tK_PHANCONG = new TK_PHANCONG_Windows();
            tK_PHANCONG.Show();
            this.Hide();
        }

        private void khmoButton_Click(object sender, EventArgs e)
        {
            TK_KHMO_Windows tK_KHMO_Windows = new TK_KHMO_Windows();
            tK_KHMO_Windows.Show();
            this.Hide();
        }

        private void qlnsButton_Click(object sender, EventArgs e)
        {
            TK_NS_Windows tK_NS_Windows = new TK_NS_Windows();
            tK_NS_Windows.Show();
            this.Hide();
        }

        private void qldkhpButton_Click(object sender, EventArgs e)
        {
            TK_DK_Windows tK_DK_Windows = new TK_DK_Windows();
            tK_DK_Windows.Show();
            this.Hide();
        }

        private void inforbutton_Click(object sender, EventArgs e)
        {
            TK_INFORMATION INFOR = new TK_INFORMATION();
            INFOR.Show();
            this.Hide();
        }

        private void xemphancongbutton_Click(object sender, EventArgs e)
        {
            TK_XEMPHANCONG_Windows pc = new TK_XEMPHANCONG_Windows();
            pc.Show();
            this.Hide();
        }

        private void SVDKbutton_Click(object sender, EventArgs e)
        {
            TK_SV_DK_Windows tK_SV_DK_Windows = new TK_SV_DK_Windows();
            tK_SV_DK_Windows.Show();
            this.Hide();
        }

        private void CAPNHATDIEMbutton_Click(object sender, EventArgs e)
        {
            TK_UPDATE_DIEM_Windows update = new TK_UPDATE_DIEM_Windows();
            update.Show();
            this.Hide();
        }

        private void XEMTBbutton_Click(object sender, EventArgs e)
        {
            TK_XEMTB_Windows tK_XEMTB_Windows = new TK_XEMTB_Windows();
            tK_XEMTB_Windows.Show();
            this.Hide();
        }
    }
}
