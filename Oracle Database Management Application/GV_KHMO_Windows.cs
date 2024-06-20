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
    public partial class GV_KHMO_Windows : Form
    {
        public GV_KHMO_Windows()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            GIANGVIEN_Windows gIANGVIEN_Windows = new GIANGVIEN_Windows();
            gIANGVIEN_Windows.Show();
            this.Hide();
        }

        private void GV_KHMO_Windows_Load(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = Account.connectString;
            OracleCommand cmd = new OracleCommand("SELECT * FROM USERDBA.KHMO", conn);
            try
            {
                conn.Open();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                TK_KHM_dataGridView.DataSource = dt;

                //conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
