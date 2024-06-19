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
    public partial class ModuleWindow : Form
    {
        public ModuleWindow()
        {
            InitializeComponent();
        }

        private void ModuleWindow_Load(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = Minister.connectString;

            OracleCommand cmd = new OracleCommand("SELECT * FROM USERDBA.HOCPHAN", conn);

            try
            {
                conn.Open();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewListModule.DataSource = dt;

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // If Module Code is empty
            if (txtCourseCode.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã học phần!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // If any information is empty
            else if (txtCourseName.Text == "" || txtNumOfCredits.Text == "" || txtNumOfTheoryClasses.Text == "" || txtNumOfPracticeClasses.Text == ""
                || txtMaxNumOfStudents.Text == "" || txtUnitCode.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Add Module to Database
            else
            {
                OracleConnection conn = new OracleConnection();
                conn.ConnectionString = Minister.connectString;
                string SQLQuery = "INSERT INTO USERDBA.HOCPHAN VALUES ('" + txtCourseCode.Text + "', '" + txtCourseName.Text + "', '"
                    + txtNumOfCredits.Text + "', '" + txtNumOfTheoryClasses.Text + "', '" + txtNumOfPracticeClasses.Text + "', '"
                    + txtMaxNumOfStudents.Text + "', '" + txtUnitCode.Text + "')";
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

                MessageBox.Show("Thêm học phần thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // If Module Code is empty
            if (txtCourseCode.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã học phần!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                // Update Module in Database
                OracleConnection conn = new OracleConnection();
                conn.ConnectionString = Minister.connectString;
                string SQLQuery = "UPDATE USERDBA.HOCPHAN SET ";

                // If a textbox is not empty, then update that information
                // Course name
                if (txtCourseName.Text != "")
                {
                    SQLQuery += "TENHP = '" + txtCourseName.Text + "'";
                }

                // Number of credits
                if (txtNumOfCredits.Text != "" && txtCourseName.Text != "")
                {
                    SQLQuery += ", SOTC = '" + txtNumOfCredits.Text + "' ";
                }
                else if (txtNumOfCredits.Text != "")
                {
                    SQLQuery += "SOTC = '" + txtNumOfCredits.Text + "' ";
                }

                // Number of theory classes
                if (txtNumOfTheoryClasses.Text != "" && (txtCourseName.Text != "" || txtNumOfCredits.Text != ""))
                {
                    SQLQuery += ", STLT = '" + txtNumOfTheoryClasses.Text + "' ";
                }
                else if (txtNumOfTheoryClasses.Text != "")
                {
                    SQLQuery += "STLT = '" + txtNumOfTheoryClasses.Text + "' ";
                }

                // Number of practice classes
                if (txtNumOfPracticeClasses.Text != "" && (txtCourseName.Text != "" || txtNumOfCredits.Text != "" || txtNumOfTheoryClasses.Text != ""))
                {
                    SQLQuery += ", STTH = '" + txtNumOfPracticeClasses.Text + "' ";
                }
                else if (txtNumOfPracticeClasses.Text != "")
                {
                    SQLQuery += "STTH = '" + txtNumOfPracticeClasses.Text + "' ";
                }

                // Max number of students
                if (txtMaxNumOfStudents.Text != "" && (txtCourseName.Text != "" || txtNumOfCredits.Text != "" || txtNumOfTheoryClasses.Text != ""
                    || txtNumOfPracticeClasses.Text != ""))
                {
                    SQLQuery += ", SOSVTD = '" + txtMaxNumOfStudents.Text + "' ";
                }
                else if (txtMaxNumOfStudents.Text != "")
                {
                    SQLQuery += "SOSVTD = '" + txtMaxNumOfStudents.Text + "' ";
                }

                // Unit Code

                if (txtUnitCode.Text != "" && (txtCourseName.Text != "" || txtNumOfCredits.Text != "" || txtNumOfTheoryClasses.Text != ""
                    || txtNumOfPracticeClasses.Text != "" || txtMaxNumOfStudents.Text != ""))
                {
                    SQLQuery += ", MADV = '" + txtUnitCode.Text + "' ";
                }
                else if (txtUnitCode.Text != "")
                {
                    SQLQuery += "MADV = '" + txtUnitCode.Text + "' ";
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

                MessageBox.Show("Cập nhật học phần thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            OracleCommand cmd = new OracleCommand("SELECT * FROM USERDBA.HOCPHAN", conn);

            try
            {
                conn.Open();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewListModule.DataSource = dt;

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
