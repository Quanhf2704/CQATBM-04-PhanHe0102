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
    public partial class DangKyHocPhan : Form
    {
        public DangKyHocPhan()
        {
            InitializeComponent();
        }

        private void DanhSachDangKy_Load(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = Account.connectString;

            OracleCommand cmd = new OracleCommand("SELECT * FROM USERDBA.DANGKY", conn);

            try
            {
                conn.Open();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView.DataSource = dt;

                //conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = Account.connectString;

            OracleCommand cmd = new OracleCommand("SELECT * FROM USERDBA.DANGKY", conn);

            try
            {
                conn.Open();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView.DataSource = dt;

                //conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = Account.connectString;

            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "userdba.insert_dangky";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("n_masv", OracleDbType.Varchar2);
            cmd.Parameters["n_masv"].Direction = ParameterDirection.Input;
            cmd.Parameters["n_masv"].Value = textMaSV.Text;

            cmd.Parameters.Add("n_magv", OracleDbType.Varchar2);
            cmd.Parameters["n_magv"].Direction = ParameterDirection.Input;
            cmd.Parameters["n_magv"].Value = textMagv.Text;

            cmd.Parameters.Add("n_mahp", OracleDbType.Varchar2);
            cmd.Parameters["n_mahp"].Direction = ParameterDirection.Input;
            cmd.Parameters["n_mahp"].Value = textMahp.Text;

            cmd.Parameters.Add("n_hk", OracleDbType.Varchar2);
            cmd.Parameters["n_hk"].Direction = ParameterDirection.Input;
            cmd.Parameters["n_hk"].Value = texthocky.Text;

            cmd.Parameters.Add("n_nam", OracleDbType.Varchar2);
            cmd.Parameters["n_nam"].Direction = ParameterDirection.Input;
            cmd.Parameters["n_nam"].Value = textNam.Text;

            cmd.Parameters.Add("n_mact", OracleDbType.Varchar2);
            cmd.Parameters["n_mact"].Direction = ParameterDirection.Input;
            cmd.Parameters["n_mact"].Value = textmact.Text;

            cmd.Connection = conn;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đăng ký học phần thành công!");

                //conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = Account.connectString;

            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "userdba.drop_dangky";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("n_masv", OracleDbType.Varchar2);
            cmd.Parameters["n_masv"].Direction = ParameterDirection.Input;
            cmd.Parameters["n_masv"].Value = textMaSV.Text;

            cmd.Parameters.Add("n_magv", OracleDbType.Varchar2);
            cmd.Parameters["n_magv"].Direction = ParameterDirection.Input;
            cmd.Parameters["n_magv"].Value = textMagv.Text;

            cmd.Parameters.Add("n_mahp", OracleDbType.Varchar2);
            cmd.Parameters["n_mahp"].Direction = ParameterDirection.Input;
            cmd.Parameters["n_mahp"].Value = textMahp.Text;

            cmd.Parameters.Add("n_hk", OracleDbType.Varchar2);
            cmd.Parameters["n_hk"].Direction = ParameterDirection.Input;
            cmd.Parameters["n_hk"].Value = texthocky.Text;

            cmd.Parameters.Add("n_nam", OracleDbType.Varchar2);
            cmd.Parameters["n_nam"].Direction = ParameterDirection.Input;
            cmd.Parameters["n_nam"].Value = textNam.Text;

            cmd.Parameters.Add("n_mact", OracleDbType.Varchar2);
            cmd.Parameters["n_mact"].Direction = ParameterDirection.Input;
            cmd.Parameters["n_mact"].Value = textmact.Text;

            cmd.Connection = conn;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa đăng ký học phần thành công!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = Account.connectString;

            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "userdba.update_dangky";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("n_masv", OracleDbType.Varchar2);
            cmd.Parameters["n_masv"].Direction = ParameterDirection.Input;
            cmd.Parameters["n_masv"].Value = textMaSV.Text;

            cmd.Parameters.Add("n_magv", OracleDbType.Varchar2);
            cmd.Parameters["n_magv"].Direction = ParameterDirection.Input;
            cmd.Parameters["n_magv"].Value = dataGridView.SelectedRows[0].Cells[1].Value;

            cmd.Parameters.Add("n_mahp", OracleDbType.Varchar2);
            cmd.Parameters["n_mahp"].Direction = ParameterDirection.Input;
            cmd.Parameters["n_mahp"].Value = dataGridView.SelectedRows[0].Cells[2].Value;

            cmd.Parameters.Add("n_hk", OracleDbType.Varchar2);
            cmd.Parameters["n_hk"].Direction = ParameterDirection.Input;
            cmd.Parameters["n_hk"].Value = dataGridView.SelectedRows[0].Cells[3].Value;

            cmd.Parameters.Add("n_nam", OracleDbType.Varchar2);
            cmd.Parameters["n_nam"].Direction = ParameterDirection.Input;
            cmd.Parameters["n_nam"].Value = dataGridView.SelectedRows[0].Cells[4].Value;

            cmd.Parameters.Add("n_mact", OracleDbType.Varchar2);
            cmd.Parameters["n_mact"].Direction = ParameterDirection.Input;
            cmd.Parameters["n_mact"].Value = dataGridView.SelectedRows[0].Cells[5].Value;

            cmd.Parameters.Add("n_magv_moi", OracleDbType.Varchar2);
            cmd.Parameters["n_magv_moi"].Direction = ParameterDirection.Input;
            cmd.Parameters["n_magv_moi"].Value = textMagv.Text;

            cmd.Parameters.Add("n_mahp_moi", OracleDbType.Varchar2);
            cmd.Parameters["n_mahp_moi"].Direction = ParameterDirection.Input;
            cmd.Parameters["n_mahp_moi"].Value = textMahp.Text;

            cmd.Parameters.Add("n_hk_moi", OracleDbType.Varchar2);
            cmd.Parameters["n_hk_moi"].Direction = ParameterDirection.Input;
            cmd.Parameters["n_hk_moi"].Value = texthocky.Text;

            cmd.Parameters.Add("n_nam_moi", OracleDbType.Varchar2);
            cmd.Parameters["n_nam_moi"].Direction = ParameterDirection.Input;
            cmd.Parameters["n_nam_moi"].Value = textNam.Text;

            cmd.Parameters.Add("n_mact_moi", OracleDbType.Varchar2);
            cmd.Parameters["n_mact_moi"].Direction = ParameterDirection.Input;
            cmd.Parameters["n_mact_moi"].Value = textmact.Text;

            cmd.Connection = conn;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật đăng ký học phần thành công!");
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
