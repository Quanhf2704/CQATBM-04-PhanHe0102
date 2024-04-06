using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void btnInsertDeleteUpdateRoleUser_Click(object sender, EventArgs e)
        {
            // Move to ViewPrivilege
            InsertDeleteUpdateRoleUserWindow viewUpdate = new InsertDeleteUpdateRoleUserWindow();
            viewUpdate.Show();
            this.Hide();
        }

        private void btnGrantPrivilege_Click(object sender, EventArgs e)
        {
            // Move to GrantPrivilegeWindow
            GrantPrivilegeWindow grantPrivilegeWindow = new GrantPrivilegeWindow();
            grantPrivilegeWindow.Show();
            this.Hide();

        }

        private void btnRevokePrivilege_Click(object sender, EventArgs e)
        {
            // Move to RevokePrivilegeWindow
            RevokePrivilegeWIndow revokePrivilegeWIndow = new RevokePrivilegeWIndow();
            revokePrivilegeWIndow.Show();
            this.Hide();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Back to LoginWindow
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
            this.Hide();

        }
    }
}
