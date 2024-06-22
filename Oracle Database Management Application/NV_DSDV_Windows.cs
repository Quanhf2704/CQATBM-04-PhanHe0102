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
    public partial class NV_DSDV_Windows : Form
    {
        public NV_DSDV_Windows()
        {
            InitializeComponent();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            NHANVIENCOBAN_Windows nvcb = new NHANVIENCOBAN_Windows();
            nvcb.Show();
            this.Hide();
        }

        private void NV_DSDV_Windows_Load(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = Account.connectString;
            OracleCommand cmd = new OracleCommand("SELECT * FROM USERDBA.DONVI", conn);
            try
            {
                conn.Open();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                TK_DSDV_dataGridView.DataSource = dt;

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
