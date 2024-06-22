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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Oracle_Database_Management_Application
{
    public partial class TDV_DK_Windows : Form
    {
        public TDV_DK_Windows()
        {
            InitializeComponent();
        }

        private void TK_DK_Windows_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void Load_Data()
        {
            txt_mssv.Text = null;
            txt_magv.Text = null;
            txt_mahp.Text = null;
            txt_hk.Text = null;
            txt_nam.Text = null;
            txt_mact.Text = null;
            txt_diemTH.Text = null;
            txt_diemQT.Text = null;
            txt_diemCK.Text = null;
            txt_diemTK.Text = null;

            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = Account.connectString;
            OracleCommand cmd = new OracleCommand("SELECT * FROM USERDBA.UV_SEL_GIANGVIEN_DANGKY", conn);
            try
            {
                conn.Open();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                TDV_DK_dataGridView.DataSource = dt;

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            
            TDV_Windows truongKhoaWindows = new TDV_Windows();
            truongKhoaWindows.Show();
            this.Hide();
        }

        private void TK_DK_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currenRow = TDV_DK_dataGridView.CurrentRow.Index;
            txt_mssv.Text = TDV_DK_dataGridView.Rows[currenRow].Cells[0].Value.ToString();
            txt_magv.Text = TDV_DK_dataGridView.Rows[currenRow].Cells[1].Value.ToString();
            txt_mahp.Text = TDV_DK_dataGridView.Rows[currenRow].Cells[2].Value.ToString();
            txt_hk.Text = TDV_DK_dataGridView.Rows[currenRow].Cells[3].Value.ToString();
            txt_nam.Text = TDV_DK_dataGridView.Rows[currenRow].Cells[4].Value.ToString();
            txt_mact.Text = TDV_DK_dataGridView.Rows[currenRow].Cells[5].Value.ToString();
            txt_diemTH.Text = TDV_DK_dataGridView.Rows[currenRow].Cells[6].Value.ToString();
            txt_diemQT.Text = TDV_DK_dataGridView.Rows[currenRow].Cells[7].Value.ToString();
            txt_diemCK.Text = TDV_DK_dataGridView.Rows[currenRow].Cells[8].Value.ToString();
            txt_diemTK.Text = TDV_DK_dataGridView.Rows[currenRow].Cells[9].Value.ToString();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = Account.connectString;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            
            cmd.CommandText = "UPDATE USERDBA.UV_SEL_GIANGVIEN_DANGKY SET DIEMTH = " + txt_diemTH.Text + ", DIEMQT = " + txt_diemQT.Text + ", DIEMCK = " + txt_diemCK.Text + ", DIEMTK = " + txt_diemTK.Text;          
            cmd.CommandText += "WHERE MASV = \'" + txt_mssv.Text + "\' AND MAGV = \'" + txt_magv.Text + "\' AND MAHP = \'" + txt_mahp.Text + "\' AND HK = " + txt_hk.Text + " AND NAM = " + txt_nam.Text + " AND MACT = \'" + txt_mact.Text + "\'";
            try
            {
                conn.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conn.Close();
                Load_Data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
