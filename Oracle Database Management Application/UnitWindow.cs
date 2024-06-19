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
    public partial class UnitWindow : Form
    {
        public UnitWindow()
        {
            InitializeComponent();
        }

        private void UnitWindow_Load(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = Minister.connectString;

            OracleCommand cmd = new OracleCommand("SELECT * FROM USERDBA.DONVI", conn);

            try
            {
                conn.Open();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewListUnit.DataSource = dt;

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // If Unit Code is empty, then show error message
            if (txtUnitCode.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã đơn vị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // If any information is empty, then show error message
            else if (txtUnitName.Text == "" || txtUnitHead.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                // Add Unit to Database
                OracleConnection conn = new OracleConnection();
                conn.ConnectionString = Minister.connectString;
                string SQLQuery = "INSERT INTO USERDBA.DONVI VALUES ('" + txtUnitCode.Text + "', '" + txtUnitName.Text + "', '" + txtUnitHead.Text + "')";
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

                MessageBox.Show("Thêm đơn vị thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // If Unit Code is empty, then show error message
            if (txtUnitCode.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã đơn vị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                // Update Unit in Database
                OracleConnection conn = new OracleConnection();
                conn.ConnectionString = Minister.connectString;
                string SQLQuery = "UPDATE USERDBA.DONVI SET ";

                // If a textbox is not empty, then update that information
                // Unit name
                if (txtUnitName.Text != "")
                {
                    SQLQuery += "TENDV = '" + txtUnitName.Text + "'";
                }

                // Unit head
                if (txtUnitHead.Text != "" && txtUnitName.Text != "")
                {
                    SQLQuery += ", TRGDV = '" + txtUnitHead.Text + "' ";
                }
                else if (txtUnitHead.Text != "")
                {
                    SQLQuery += "TRGDV = '" + txtUnitHead.Text + "' ";
                }

                SQLQuery += "WHERE MADV = '" + txtUnitCode.Text + "'";

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

                MessageBox.Show("Cập nhật đơn vị thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

            OracleCommand cmd = new OracleCommand("SELECT * FROM USERDBA.DONVI", conn);

            try
            {
                conn.Open();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewListUnit.DataSource = dt;

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
