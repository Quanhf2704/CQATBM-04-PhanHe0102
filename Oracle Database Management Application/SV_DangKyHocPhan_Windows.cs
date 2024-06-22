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
    public partial class SV_DangKyHocPhan_Windows : Form
    {
        public SV_DangKyHocPhan_Windows()
        {
            InitializeComponent();
        }

        private void DanhSachDangKy_Load(object sender, EventArgs e)
        {
            textMaSV.Text = Account.username;
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

                conn.Close();

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

                conn.Close();

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
            cmd.CommandText = "INSERT INTO USERDBA.DANGKY VALUES (\'" + textMaSV.Text + "\', \'" + textMagv.Text
                + "\', \'" + textMahp.Text + "\', \'" + texthocky.Text + "\', \'" + textNam.Text + "\', \'"
                + textmact.Text + "\', NULL, NULL, NULL, NULL)";
            cmd.Connection = conn;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đăng ký học phần thành công!");
                conn.Close();

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
            cmd.CommandText = "DELETE FROM USERDBA.DANGKY WHERE MASV = \'" + textMaSV.Text + "\' AND MAGV = \'"
                + textMagv.Text + "\' AND MAHP = \'" + textMahp.Text + "\' AND HK = \'" + texthocky.Text + "\' AND NAM = \'"
                + textNam.Text + "\'";
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
        private void btnBack_Click(object sender, EventArgs e)
        {
            SINHVIEN_Windows SV = new SINHVIEN_Windows();
            SV.Show();
            this.Hide();

        }
    }
}
