﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Oracle_Database_Management_Application;
using Oracle.ManagedDataAccess.Client;

namespace Oracle_Database_Management_Application
{
    public partial class ViewListAccountWindow : Form
    {
        public ViewListAccountWindow()
        {
            InitializeComponent();
        }

        private void User_Load(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = Account.connectString;

            OracleCommand cmd = new OracleCommand("SELECT * FROM BH_KHACHHANG", conn);
            try
            {
                conn.Open();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewListAccount.DataSource = dt;

                //conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
  
        }

        private void btnDropUser_Click(object sender, EventArgs e)
        {
 
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
 
        }

        private void btnCheckPriv_Click(object sender, EventArgs e)
        {

        }

        private void btnCheckRole_Click(object sender, EventArgs e)
        {
 
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Back to MainWindow
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();

        }
    }
}
