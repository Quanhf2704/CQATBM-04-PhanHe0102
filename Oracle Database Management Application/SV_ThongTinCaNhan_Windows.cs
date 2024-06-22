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
    public partial class SV_ThongTinCaNhan_Windows : Form
    {
        public SV_ThongTinCaNhan_Windows()
        {
            InitializeComponent();
        }

        private void ThongTinCaNhan_Load(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = Account.connectString;

            OracleCommand cmd = new OracleCommand("SELECT * FROM USERDBA.SINHVIEN", conn);
            try
            {
                conn.Open();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdatePhone_Click(object sender, EventArgs e)
        {
            if (textSdt.Text == "")
            {
                MessageBox.Show("Bạn chưa điền số điện thoại mới để cập nhật!");
            }
            else
            {
                OracleConnection conn = new OracleConnection();
                conn.ConnectionString = Account.connectString;

                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "UPDATE USERDBA.SINHVIEN SET DT = \'" + textSdt.Text + "\'";
                cmd.Connection = conn;

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật số điện thoại mới thành công!");
                    conn.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnUpdateAddress_Click(object sender, EventArgs e)
        {
            if (textDiachi.Text == "")
            {
                MessageBox.Show("Bạn chưa điền địa chỉ mới để cập nhật!");
            }
            else
            {
                OracleConnection conn = new OracleConnection();
                conn.ConnectionString = Account.connectString;

                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "UPDATE USERDBA.SINHVIEN SET DCHI = N\'" + textDiachi.Text + "\'";
                cmd.Connection = conn;

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật địa chỉ mới thành công!");
                    conn.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = Account.connectString;

            OracleCommand cmd = new OracleCommand("SELECT * FROM USERDBA.SINHVIEN", conn);
            try
            {
                conn.Open();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SINHVIEN_Windows sINHVIEN_Windows = new SINHVIEN_Windows();
            sINHVIEN_Windows.Show();
            this.Hide();

        }
    }
}
