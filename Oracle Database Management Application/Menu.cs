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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnViewInfoHR_Click(object sender, EventArgs e)
        {
            // Go to HR Window
            HRWindow hrWindow = new HRWindow();
            hrWindow.Show();
            this.Hide();

        }

        private void btnViewInfoStudent_Click(object sender, EventArgs e)
        {
            // Go to Student Window
            StudentWindow studentWindow = new StudentWindow();
            studentWindow.Show();
            this.Hide();

        }

        private void btnViewInfoUnit_Click(object sender, EventArgs e)
        {
            // Go to Unit Window
            UnitWindow unitWindow = new UnitWindow();
            unitWindow.Show();
            this.Hide();

        }

        private void btnVIewInfoModule_Click(object sender, EventArgs e)
        {
            // Go to Module Window
            ModuleWindow moduleWindow = new ModuleWindow();
            moduleWindow.Show();
            this.Hide();

        }

        private void btnViewInfoOpenPlan_Click(object sender, EventArgs e)
        {
            // Go to Open Plan Window
            OpenPlanWindow openPlanWindow = new OpenPlanWindow();
            openPlanWindow.Show();
            this.Hide();

        }

        private void btnViewInfoAssignment_Click(object sender, EventArgs e)
        {
            // Go to Assignment Window
            AssignmentWindow assignmentWindow = new AssignmentWindow();
            assignmentWindow.Show();
            this.Hide();

        }

        private void btnViewInfoRegistration_Click(object sender, EventArgs e)
        {
            // Go to Registration Window
            RegistrationWindow registrationWindow = new RegistrationWindow();
            registrationWindow.Show();
            this.Hide();

        }

        private void btnAnnounement_Click(object sender, EventArgs e)
        {
            // Go to Announcement Window
            AnnouncementWindow announcementWindow = new AnnouncementWindow();
            announcementWindow.Show();
            this.Hide();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Back to Login Window
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
            this.Hide();

        }
    }
}
