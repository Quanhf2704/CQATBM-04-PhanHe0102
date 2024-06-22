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
    public partial class GVU_KHMO_Window : Form
    {
        public GVU_KHMO_Window()
        {
            InitializeComponent();
        }
        private void OpenPlanWindow_Load(object sender, EventArgs e)
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
                dataGridViewListOpenPlan.DataSource = dt;

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // If any information is empty
            if (txtCourseCode.Text == "" || txtSemester.Text == "" || txtYear.Text == "" || txtEducationProgram.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Add Open Plan to Database
            else
            {
                OracleConnection conn = new OracleConnection();
                conn.ConnectionString = Account.connectString;
                string SQLQuery = "INSERT INTO USERDBA.KHMO VALUES ('" + txtCourseCode.Text + "', '" + txtSemester.Text + "', '"
                    + txtYear.Text + "', '" + txtEducationProgram.Text + "')";
                OracleCommand cmd = new OracleCommand(SQLQuery, conn);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                MessageBox.Show("Thêm kế hoạch mở thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // If any information is empty
            if (txtCourseCode.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Mã học phần!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Update Open Plan in Database
            else
            {
                OracleConnection conn = new OracleConnection();
                conn.ConnectionString = Account.connectString;
                string SQLQuery = "UPDATE USERDBA.KHMO SET ";

                // If a textbox is not empty, then update that information
                // Semester
                if (txtSemester.Text != "")
                {
                    SQLQuery += "HK = '" + txtSemester.Text + "'";
                }

                // Year
                if (txtYear.Text != "" && txtSemester.Text != "")
                {
                    SQLQuery += ", NAM = '" + txtYear.Text + "' ";
                }
                else if (txtYear.Text != "")
                {
                    SQLQuery += "NAM = '" + txtYear.Text + "' ";
                }

                // Education program
                if (txtEducationProgram.Text != "" && (txtSemester.Text != "" || txtYear.Text != ""))
                {
                    SQLQuery += ", MACT = '" + txtEducationProgram.Text + "' ";
                }
                else if (txtEducationProgram.Text != "")
                {
                    SQLQuery += "MACT = '" + txtEducationProgram.Text + "' ";
                }

                SQLQuery += "WHERE MAHP = '" + txtCourseCode.Text + "'";

                OracleCommand cmd = new OracleCommand(SQLQuery, conn);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                MessageBox.Show("Cập nhật kế hoạch mở thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Back to Menu Window
            GIAOVU_Windows menu = new GIAOVU_Windows();
            menu.Show();
            this.Hide();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
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
                dataGridViewListOpenPlan.DataSource = dt;

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
