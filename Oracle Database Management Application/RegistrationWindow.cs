using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Oracle.ManagedDataAccess.Client;

namespace Oracle_Database_Management_Application
{
    public partial class RegistrationWindow : Form
    {
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // If main infomation is empty, then show error message
            if (txtStudentCode.Text == "" || txtTeacherCode.Text == "" || txtCourseCode.Text == "" || txtSemester.Text == ""
                || txtYear.Text == "" || txtEducationProgram.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // If any information is empty, then show error message
            else if (txtPracticePoint.Text == "" || txtProcessPoint.Text == "" || txtFinalPoint.Text == "" || txtTotalPoint.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                // Add Registration to Database
                OracleConnection conn = new OracleConnection();
                conn.ConnectionString = Account.connectString;
                string SQLQuery = "INSERT INTO USERDBA.DANGKY VALUES ('" + txtStudentCode.Text + "', '" + txtTeacherCode.Text + "', '"
                    + txtCourseCode.Text + "', '" + txtSemester.Text + "', '" + txtYear.Text + "', '" + txtEducationProgram.Text + "', '"
                    + txtPracticePoint.Text + "', '" + txtProcessPoint.Text + "', '" + txtFinalPoint.Text + "', '" + txtTotalPoint.Text + "')";
                OracleCommand cmd = new OracleCommand(SQLQuery, conn);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Thêm đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtStudentCode.Text == "" || txtTeacherCode.Text == "" || txtCourseCode.Text == "" || txtSemester.Text == ""
                || txtYear.Text == "" || txtEducationProgram.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                // Delete Registration from Database
                OracleConnection conn = new OracleConnection();
                conn.ConnectionString = Account.connectString;
                string SQLQuery = "DELETE FROM USERDBA.DANGKY WHERE MASV = '" + txtStudentCode.Text + "' AND MAGV = '" + txtTeacherCode.Text + "' AND MAHP = '"
                    + txtCourseCode.Text + "' AND HK = '" + txtSemester.Text + "' AND NAM = '" + txtYear.Text + "' AND MACT = '" + txtEducationProgram.Text + "'";
                OracleCommand cmd = new OracleCommand(SQLQuery, conn);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Xóa đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Back to Menu Window
            GIAOVU_Windows menu = new GIAOVU_Windows();
            menu.Show();
            this.Hide();

        }

    }
}
