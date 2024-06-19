using System;
using System.Windows.Forms;

namespace Oracle_Database_Management_Application
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnViewListAccount_Click(object sender, EventArgs e)
        {
            // Move to ViewListAccountWindow
            ViewListAccountWindow viewListAccountWindow = new ViewListAccountWindow();
            viewListAccountWindow.Show();
            this.Hide();

        }

        private void btnViewPrivilege_Click(object sender, EventArgs e)
        {
            // Move to ViewPrivilege
            ViewPrivilegeWindow viewPrivilege = new ViewPrivilegeWindow();
            viewPrivilege.Show();
            this.Hide();

        }

        private void btnViewRole_Click(object sender, EventArgs e)
        {
            // Move to ViewRole
            ViewRoleWindow viewUpdate = new ViewRoleWindow();
            viewUpdate.Show();
            this.Hide();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Back to LoginWindow
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
            this.Hide();

        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
