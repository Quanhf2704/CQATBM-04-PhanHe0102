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
    public partial class HRWindow : Form
    {
        private void HRWindow_Load(object sender, EventArgs e)
        {
            // Load from Oracle database and show information in each textbox
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = Minister.connectString;

            OracleCommand cmd = new OracleCommand("SELECT * FROM USERDBA.UV_SEL_NHANVIEN", conn);
            try
            {
                conn.Open();
                OracleDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    txtEmpCode.Text = dr.GetString(0);
                    txtName.Text = dr.GetString(1);
                    txtSex.Text = dr.GetString(2);
                    txtBirthday.Text = dr.GetString(3);
                    txtSubsidy.Text = dr.GetString(4);
                    txtPhoneNumber.Text = dr.GetString(5);
                    txtRole.Text = dr.GetString(6);
                    txtUnitCode.Text = dr.GetString(7);
                }

                dr.Dispose();
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public HRWindow()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Back to Menu Window
            Menu menu = new Menu();
            menu.Show();
            this.Hide();

        }

        private void btnChangeInfo_Click(object sender, EventArgs e)
        {
            // Show pop-up to change information
            ChangeInfoHRWindow changeInfoHRWindow = new ChangeInfoHRWindow();
            changeInfoHRWindow.Show();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // Load from Oracle database and show information in each textbox
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = Minister.connectString;

            OracleCommand cmd = new OracleCommand("SELECT * FROM USERDBA.UV_SEL_NHANVIEN", conn);
            try
            {
                conn.Open();
                OracleDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    txtEmpCode.Text = dr.GetString(0);
                    txtName.Text = dr.GetString(1);
                    txtSex.Text = dr.GetString(2);
                    txtBirthday.Text = dr.GetString(3);
                    txtSubsidy.Text = dr.GetString(4);
                    txtPhoneNumber.Text = dr.GetString(5);
                    txtRole.Text = dr.GetString(6);
                    txtUnitCode.Text = dr.GetString(7);
                }

                dr.Dispose();
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
