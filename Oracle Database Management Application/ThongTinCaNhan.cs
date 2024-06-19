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
    public partial class ThongTinCaNhan : Form
    {
        public ThongTinCaNhan()
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

                //conn.Close();

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
                cmd.CommandText = "userdba.update_sdt";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("n_sdt", OracleDbType.Varchar2);
                cmd.Parameters["n_sdt"].Direction = ParameterDirection.Input;
                cmd.Parameters["n_sdt"].Value = textSdt.Text;
                cmd.Connection = conn;

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật số điện thoại mới thành công!");

                    //conn.Close();

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
                cmd.CommandText = "userdba.update_diachi";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("n_diachi", OracleDbType.Varchar2);
                cmd.Parameters["n_diachi"].Direction = ParameterDirection.Input;
                cmd.Parameters["n_diachi"].Value = textDiachi.Text;

                cmd.Connection = conn;

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật địa chỉ mới thành công!");

                    //conn.Close();

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

                //conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Back to MainWindow
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();

        }
    }
}
