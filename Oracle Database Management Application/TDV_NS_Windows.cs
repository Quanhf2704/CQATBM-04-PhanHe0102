using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Oracle_Database_Management_Application
{ 
    public partial class TDV_NS_Windows : Form
    {
        private List<List<string>> dsns;
        public TDV_NS_Windows()
        {
            InitializeComponent();
        }

        private void TK_NS_Windows_Load(object sender, EventArgs e)
        {           
            Load_Data();
        }

        private void Load_Data()
        {
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = Account.connectString;
            OracleCommand cmd = new OracleCommand("SELECT * FROM USERDBA.UV_SEL_NHANVIEN", conn);
            try
            {
                conn.Open();
                OracleDataReader rd = cmd.ExecuteReader();
                if (dsns != null)
                {
                    dsns.Clear();
                }
                dsns = new List<List<string>>();
                while (rd.Read())
                {
                    List<string> oneNhansu = new List<string>();
                    oneNhansu.Add(rd["MANV"].ToString());
                    oneNhansu.Add(rd["HOTEN"].ToString());
                    oneNhansu.Add(rd["PHAI"].ToString());
                    oneNhansu.Add(rd["NGSINH"].ToString());
                    oneNhansu.Add(rd["PHUCAP"].ToString());
                    oneNhansu.Add(rd["DT"].ToString());
                    oneNhansu.Add(rd["VAITRO"].ToString());
                    oneNhansu.Add(rd["MADV"].ToString());
                    dsns.Add(oneNhansu);
                }
                for (int i = 0; i < dsns.Count; i++)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = dsns[i][0];
                    item.SubItems.Add(dsns[i][1]);
                    item.SubItems.Add(dsns[i][2]);
                    item.SubItems.Add(dsns[i][3]);
                    item.SubItems.Add(dsns[i][4]);
                    item.SubItems.Add(dsns[i][5]);
                    item.SubItems.Add(dsns[i][6]);
                    item.SubItems.Add(dsns[i][7]);
                    QLNSlistView.Items.Add(item);
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            TDV_Windows truongKhoaWindows = new TDV_Windows();
            truongKhoaWindows.Show();
            this.Hide();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = Account.connectString;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "UPDATE USERDBA.UV_SEL_NHANVIEN SET DT = \'" + txt_phoneNo.Text + "\' WHERE MANV = \'" + Account.username + "\'";
            try
            {
                conn.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conn.Close();
                QLNSlistView.Items.Clear();
                Load_Data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
