using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle_Database_Management_Application;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace Oracle_Database_Management_Application
{
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Account.username = "userdba";
            Account.password = "111";
            if (string.IsNullOrWhiteSpace(textUsername.Text) || string.IsNullOrWhiteSpace(textPass.Text))
            {
                MessageBox.Show("Bạn chưa nhập username/password");
                return;
            }

            Account.connectString = @"Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = "
                + Account.host + ")(PORT = " + Account.port + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
                + Account.sid + "))); Password=" + Account.password + ";User ID=" + Account.username;
            OracleConnection conn = new OracleConnection(Account.connectString);
            if (textUsername.Text == "userdba")
            {
                MessageBox.Show("Đăng nhập với vai trò userdba");
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Hide();
            }
            else
            {
                try
                {
                    conn.Open();
                    int result = 9;
                    using (var command = conn.CreateCommand())
                    {
                        command.CommandText =
                          @"begin
                            :prm_Result := CHECKING_USER(:USER);
                          end;";

                        command.Parameters.Add(":prm_Result", OracleDbType.Int16, ParameterDirection.Output);
                        command.Parameters.Add(":USER", OracleDbType.Varchar2).Value = textUsername.Text;

                        command.ExecuteNonQuery();
                        result = int.Parse(command.Parameters[0].Value.ToString());
                    }


                    if (result == 0)
                    {
                        MessageBox.Show("Tên đăng nhập và mật khẩu không hợp lệ!");
                        textUsername.Text = "";
                        textPass.Text = "";
                        return;
                    }
                    else if (result == 1)
                    {
                        MessageBox.Show("Đăng nhập với vai trò trưởng khoa");
                        Account.username = textUsername.Text;
                        Account.password = textPass.Text;
                        TruongKhoaWindows truongKhoaWindows = new TruongKhoaWindows();
                        truongKhoaWindows.Show();
                        this.Hide();
                    }
                    else if (result == 2)
                    {
                        MessageBox.Show("Đăng nhập với vai trò trưởng đơn vị");
                        Account.username = textUsername.Text;
                        Account.password = textPass.Text;
                    }
                    else if (result == 3)
                    {
                        MessageBox.Show("Đăng nhập với vai trò giáo vụ");
                        Account.username = textUsername.Text;
                        Account.password = textPass.Text;
                    }
                    else if (result == 4)
                    {
                        MessageBox.Show("Đăng nhập với vai trò giảng viên");
                        Account.username = textUsername.Text;
                        Account.password = textPass.Text;
                        GIANGVIEN_Windows gv = new GIANGVIEN_Windows();
                        gv.Show();
                        this.Hide();
                    }
                    else if (result == 5)
                    {
                        MessageBox.Show("Đăng nhập với vai trò nhân viên cơ bản");
                        Account.username = textUsername.Text;
                        Account.password = textPass.Text;
                        NHANVIENCOBAN_Windows nvcb = new NHANVIENCOBAN_Windows();
                        nvcb.Show();
                        this.Hide();
                    }
                    else if (result == 6)
                    {
                        MessageBox.Show("Đăng nhập với vai trò sinh viên");
                        Account.username = textUsername.Text;
                        Account.password = textPass.Text;
                        SINHVIEN_Windows sINHVIEN_Windows = new SINHVIEN_Windows();
                        sINHVIEN_Windows.Show();
                        this.Hide();
                    }


                    /*Account.username = textUsername.Text;
                    Account.password = textPass.Text;
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TruongKhoaWindows truongKhoaWindows = new TruongKhoaWindows();
                    truongKhoaWindows.Show();
                    this.Hide();*/
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
     }

        /*           MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   MainWindow mainWindow = new MainWindow();
                   mainWindow.Show();
                   this.Hide();*/


        private void btnEsc_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void LoginWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
