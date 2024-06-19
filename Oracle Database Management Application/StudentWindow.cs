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
    public partial class StudentWindow : Form
    {
        public StudentWindow()
        {
            InitializeComponent();
        }
        private void StudentWindow_Load(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = Minister.connectString;

            OracleCommand cmd = new OracleCommand("SELECT * FROM USERDBA.SINHVIEN", conn);

            try
            {
                conn.Open();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewListStudent.DataSource = dt;

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // If Student Code is empty, then show error message
            if (txtStudentCode.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // If any information is empty, then show error message
            else if (txtName.Text == "" || txtSex.Text == "" || txtBirthday.Text == "" || txtAddress.Text == "" || txtPhoneNumber.Text == ""
                || txtEducationProgram.Text == "" || txtFieldCode.Text == "" || txtNumOfCredits.Text == "" || txtGPA.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                // Add Student to Database
                OracleConnection conn = new OracleConnection();
                conn.ConnectionString = Minister.connectString;
                string SQLQuery = "INSERT INTO USERDBA.SINHVIEN VALUES ('" + txtStudentCode.Text + "', '" + txtName.Text + "', '"
                    + txtSex.Text + "', TO_DATE('" + txtBirthday.Text + "', 'YYYY-MM-DD'), '" + txtAddress.Text + "', '" + txtPhoneNumber.Text + "', '"
                    + txtEducationProgram.Text + "', '" + txtFieldCode.Text + "', '" + txtNumOfCredits.Text + "', '" + txtGPA.Text + "')";
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

                MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // If Student Code is empty, then show error message
            if (txtStudentCode.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                //  Update Student in Database
                OracleConnection conn = new OracleConnection();
                conn.ConnectionString = Minister.connectString;
                string SQLQuery = "UPDATE USERDBA.SINHVIEN SET ";

                // If a textbox is not empty, then update that information
                // Name
                if (txtName.Text != "")
                {
                    SQLQuery += "HOTEN = '" + txtName.Text + "'";
                }

                // Sex
                if (txtSex.Text != "" && txtName.Text != "")
                {
                    SQLQuery += ", PHAI = '" + txtSex.Text + "' ";
                }
                else if (txtSex.Text != "")
                {
                    SQLQuery += "PHAI = '" + txtSex.Text + "' ";
                }

                // Birthday
                if (txtBirthday.Text != "" && (txtName.Text != "" || txtSex.Text != ""))
                {
                    SQLQuery += ", NGSINH = TO_DATE('" + txtBirthday.Text + "', 'YYYY-MM-DD') ";
                }
                else if (txtBirthday.Text != "")
                {
                    SQLQuery += "NGSINH = TO_DATE('" + txtBirthday.Text + "', 'YYYY-MM-DD') ";
                }

                // Address
                if (txtAddress.Text != "" && (txtName.Text != "" || txtSex.Text != "" || txtBirthday.Text != ""))
                {
                    SQLQuery += ", DCHI = '" + txtAddress.Text + "' ";
                }    
                else if (txtAddress.Text != "")
                {
                    SQLQuery += "DCHI = '" + txtAddress.Text + "' ";
                }

                // Phone Number
                if (txtPhoneNumber.Text != "" && (txtName.Text != "" || txtSex.Text != "" || txtBirthday.Text != "" || txtAddress.Text != ""))
                {
                    SQLQuery += ", SDT = '" + txtPhoneNumber.Text + "' ";
                }
                else if (txtPhoneNumber.Text != "")
                {
                    SQLQuery += "SDT = '" + txtPhoneNumber.Text + "' ";
                }

                // Education Program

                if (txtEducationProgram.Text != "" && (txtName.Text != "" || txtSex.Text != "" || txtBirthday.Text != "" || txtAddress.Text != ""
                    || txtPhoneNumber.Text != ""))
                {
                    SQLQuery += ", MACT = '" + txtEducationProgram.Text + "' ";
                }
                else if (txtEducationProgram.Text != "")
                {
                    SQLQuery += "MACT = '" + txtEducationProgram.Text + "' ";
                }

                // Field Code
                if (txtFieldCode.Text != "" && (txtName.Text != "" || txtSex.Text != "" || txtBirthday.Text != "" || txtAddress.Text != ""
                    || txtPhoneNumber.Text != "" || txtEducationProgram.Text != ""))
                {
                    SQLQuery += ", MANGANH = '" + txtFieldCode.Text + "' ";
                }
                else if (txtFieldCode.Text != "")
                {
                    SQLQuery += "MANGANH = '" + txtFieldCode.Text + "' ";
                }

                // Number of Credits
                if (txtNumOfCredits.Text != "" && (txtName.Text != "" || txtSex.Text != "" || txtBirthday.Text != "" || txtAddress.Text != ""
                    || txtPhoneNumber.Text != "" || txtEducationProgram.Text != "" || txtFieldCode.Text != ""))
                {
                    SQLQuery += ", SOTCTL = '" + txtNumOfCredits.Text + "' ";
                }
                if (txtNumOfCredits.Text != "")
                {
                    SQLQuery += "SOTCTL = '" + txtNumOfCredits.Text + "' ";
                }

                // GPA
                if (txtGPA.Text != "" && (txtName.Text != "" || txtSex.Text != "" || txtBirthday.Text != "" || txtAddress.Text != ""
                    || txtPhoneNumber.Text != "" || txtEducationProgram.Text != "" || txtFieldCode.Text != "" || txtNumOfCredits.Text != ""))
                {
                    SQLQuery += ", DTBTL = '" + txtGPA.Text + "' ";
                }
                if (txtGPA.Text != "")
                {
                    SQLQuery += "DTBTL = '" + txtGPA.Text + "' ";
                }

                SQLQuery += "WHERE MASV = '" + txtStudentCode.Text + "'";

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

                MessageBox.Show("Cập nhật sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            OracleCommand cmd = new OracleCommand("SELECT * FROM USERDBA.SINHVIEN", conn);

            try
            {
                conn.Open();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewListStudent.DataSource = dt;

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
