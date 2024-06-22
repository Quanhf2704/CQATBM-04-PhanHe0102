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
    public partial class TK_XEMTB_Windows : Form
    {
        public TK_XEMTB_Windows()
        {
            InitializeComponent();
        }

        private void quaylaiButton_Click(object sender, EventArgs e)
        {
            TruongKhoaWindows truongKhoaWindows = new TruongKhoaWindows();
            truongKhoaWindows.Show();
            this.Hide();
        }

        private void TK_XEMTB_Windows_Load(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = Account.connectString;
            OracleCommand cmd = new OracleCommand("SELECT * FROM USERDBA.THONGBAO", conn);
            try
            {
                conn.Open();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                TK_THONGBAO_dataGridView.DataSource = dt;

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
