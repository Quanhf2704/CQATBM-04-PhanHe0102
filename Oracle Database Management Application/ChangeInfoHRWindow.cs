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
    public partial class ChangeInfoHRWindow : Form
    {
        public ChangeInfoHRWindow()
        {
            InitializeComponent();
        }

        private void ChangeInfoHRWindow_Load(object sender, EventArgs e)
        {
            // Load from Oracle database and show phone number in each textbox
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = Minister.connectString;

            OracleCommand cmd = new OracleCommand("SELECT DT FROM USERDBA.UV_SEL_NHANVIEN", conn);
            try
            {
                conn.Open();
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtOldPhoneNumber.Text = dr.GetString(0);
                }

                //conn.Close();
                dr.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            // If any information is empty, then show error message
            if (txtNewPhoneNumber.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập SĐT mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                // Change new phone number in database
                OracleConnection conn = new OracleConnection();
                conn.ConnectionString = Minister.connectString;
                string SQLQuery = "UPDATE USERDBA.UV_SEL_NHANVIEN SET DT = '" + txtNewPhoneNumber.Text + "'";
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


                MessageBox.Show("Thay đổi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Thoát thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
            }
        }

    }
}
