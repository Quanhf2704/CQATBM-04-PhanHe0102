using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;


namespace Oracle_Database_Management_Application
{
    public partial class ViewPrivilegeWindow : Form
    {
        public ViewPrivilegeWindow()
        {
            InitializeComponent();
        }

        private void Priviledge_Load(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = Account.connectString;

            OracleCommand cmd = new OracleCommand("SELECT DISTINCT GRANTED_ROLE FROM DBA_ROLE_PRIVS", conn);
            try
            {
                conn.Open();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewPriv.DataSource = dt;

                //conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = Account.connectString;

            OracleCommand cmd = new OracleCommand("SELECT DISTINCT GRANTED_ROLE FROM DBA_ROLE_PRIVS", conn);
            try
            {
                conn.Open();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewPriv.DataSource = dt;

                //conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGrantforUser_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = Account.connectString;

            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "grant_permission_user";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("n_pri", OracleDbType.Varchar2);
            cmd.Parameters["n_pri"].Direction = ParameterDirection.Input;
            cmd.Parameters["n_pri"].Value = textPriv.Text;

            cmd.Parameters.Add("n_obj", OracleDbType.Varchar2);
            cmd.Parameters["n_obj"].Direction = ParameterDirection.Input;
            cmd.Parameters["n_obj"].Value = textObject.Text;

            cmd.Parameters.Add("n_user", OracleDbType.Varchar2);
            cmd.Parameters["n_user"].Direction = ParameterDirection.Input;
            cmd.Parameters["n_user"].Value = textUserRole.Text;

            cmd.Parameters.Add("n_flag", OracleDbType.Char);
            cmd.Parameters["n_flag"].Direction = ParameterDirection.Input;

            if (checkBoxGrantOption.Checked)
                cmd.Parameters["n_flag"].Value = '1';
            else cmd.Parameters["n_flag"].Value = '0';
            cmd.Connection = conn;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Success!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGrantforRole_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = Account.connectString;
            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "grant_permission_role";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("n_pri", OracleDbType.Varchar2);
            cmd.Parameters["n_pri"].Direction = ParameterDirection.Input;
            cmd.Parameters["n_pri"].Value = textPriv.Text;

            cmd.Parameters.Add("n_obj", OracleDbType.Varchar2);
            cmd.Parameters["n_obj"].Direction = ParameterDirection.Input;
            cmd.Parameters["n_obj"].Value = textObject.Text;

            cmd.Parameters.Add("n_user", OracleDbType.Varchar2);
            cmd.Parameters["n_user"].Direction = ParameterDirection.Input;
            cmd.Parameters["n_user"].Value = textUserRole.Text;

            cmd.Connection = conn;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Success!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRevoke_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = Account.connectString;

            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "revoke_permission";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("n_pri", OracleDbType.Varchar2);
            cmd.Parameters["n_pri"].Direction = ParameterDirection.Input;
            cmd.Parameters["n_pri"].Value = textPriv.Text;

            cmd.Parameters.Add("n_obj", OracleDbType.Varchar2);
            cmd.Parameters["n_obj"].Direction = ParameterDirection.Input;
            cmd.Parameters["n_obj"].Value = textObject.Text;

            cmd.Parameters.Add("n_user", OracleDbType.Varchar2);
            cmd.Parameters["n_user"].Direction = ParameterDirection.Input;
            cmd.Parameters["n_user"].Value = textUserRole.Text;

            cmd.Connection = conn;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Success!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Back to MainWindow
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();

        }

        private void dataGridViewPriv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
