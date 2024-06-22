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
    public partial class TDV_Windows : Form
    {
        public TDV_Windows()
        {
            InitializeComponent();
        }

        private void dssvButton_Click(object sender, EventArgs e)
        {
            TDV_DSSV_Windows tDV_DSSV_Windows = new TDV_DSSV_Windows();
            tDV_DSSV_Windows.Show();
            this.Hide();
        }

        private void TruongKhoaWindows_Load(object sender, EventArgs e)
        {
            Account.username = "NV002";
            Account.password = "123";
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
            TDV_DSDV_Windows tDV_DSDV = new TDV_DSDV_Windows();
            tDV_DSDV.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TDV_DSHP_Windows tDV_DSHP = new TDV_DSHP_Windows();
            tDV_DSHP.Show();
            this.Hide();
        }

        private void quaylaiButton_Click(object sender, EventArgs e)
        {
            LoginWindow login = new LoginWindow();
            login.Show();
            this.Hide();
        }

        private void phancongButton_Click(object sender, EventArgs e)
        {
            TDV_PHANCONG_Windows tDV_PHANCONG = new TDV_PHANCONG_Windows();
            tDV_PHANCONG.Show();
            this.Hide();
        }

        private void khmoButton_Click(object sender, EventArgs e)
        {
            TDV_KHMO_Windows tDV_KHMO_Windows = new TDV_KHMO_Windows();
            tDV_KHMO_Windows.Show();
            this.Hide();
        }

        private void qlnsButton_Click(object sender, EventArgs e)
        {
            TDV_NS_Windows tDV_NS_Windows = new TDV_NS_Windows();
            tDV_NS_Windows.Show();
            this.Hide();
        }

        private void qldkhpButton_Click(object sender, EventArgs e)
        {
            TDV_DK_Windows tDV_DK_Windows = new TDV_DK_Windows();
            tDV_DK_Windows.Show();
            this.Hide();
        }

        private void btn_thongbao_Click(object sender, EventArgs e)
        {
            TDV_THONGBAO_Windows tDV_DK_Windows = new TDV_THONGBAO_Windows();
            tDV_DK_Windows.Show();
            this.Hide();
        }
    }
}
