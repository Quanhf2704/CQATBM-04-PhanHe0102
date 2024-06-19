using System;
using System.Data.OracleClient;
using System.Windows.Forms;

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
            if (string.IsNullOrWhiteSpace(textUsername.Text) || string.IsNullOrWhiteSpace(textPass.Text))
            {
                MessageBox.Show("Bạn chưa nhập username/password");
                return;
            }

            if (Minister.username != textUsername.Text || Minister.password != textPass.Text)
            {
                MessageBox.Show("Đăng nhập không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textUsername.Text = null;
                //testPass.Text = null;
            }
            else
            {
                Minister.connectString = @"Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = "
                 + Minister.host + ")(PORT = " + Minister.port + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
                 + Minister.sid + "))); Password=" + Minister.password + ";User ID=" + Minister.username;
                OracleConnection conn = new OracleConnection(Minister.connectString);
                
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Menu menu = new Menu();
                menu.Show();
                this.Hide();
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

        private void lblMinister_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chào mừng Giáo vụ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Go to Menu Window
            Menu menu = new Menu();
            menu.Show();
            this.Hide();

        }
    }
}
