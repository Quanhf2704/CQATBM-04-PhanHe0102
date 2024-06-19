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
    public partial class AssignmentWindow : Form
    {
        public AssignmentWindow()
        {
            InitializeComponent();
        }

        private void AssignmentWindow_Load(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = Minister.connectString;

            OracleCommand cmd = new OracleCommand("SELECT * FROM USERDBA.PHANCONG", conn);

            try
            {
                conn.Open();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewListAssignment.DataSource = dt;

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // If any information is empty
            if (txtTeacherCode.Text == "" || txtCourseCode.Text == "" || txtSemester.Text == "" || txtYear.Text == "" || txtEducationProgram.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Update Assignment in Database
            else
            {
                MessageBox.Show("Cập nhật phân công thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Back to Menu Window
            Menu menu = new Menu();
            menu.Show();
            this.Hide();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = Minister.connectString;

            OracleCommand cmd = new OracleCommand("SELECT * FROM USERDBA.PHANCONG", conn);

            try
            {
                conn.Open();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewListAssignment.DataSource = dt;

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
