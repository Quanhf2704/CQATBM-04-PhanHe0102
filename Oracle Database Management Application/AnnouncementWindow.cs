using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Oracle_Database_Management_Application
{
    public partial class AnnouncementWindow : Form
    {
        public AnnouncementWindow()
        {
            InitializeComponent();
        }

        private void AnnouncementWindow_Load(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = Minister.connectString;

            OracleCommand cmd = new OracleCommand("SELECT * FROM USERDBA.THONGBAO", conn);

            try
            {
                conn.Open();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewListAnnouncement.DataSource = dt;

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Back to Menu Window
            Menu menu = new Menu();
            menu.Show();
            this.Hide();

        }
    }
}
