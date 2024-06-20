using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Oracle_Database_Management_Application
{
    public partial class GV_UPDATE_DIEM_Windows : Form
    {
        private List<List<string>> dsdangky;
        public GV_UPDATE_DIEM_Windows()
        {
            InitializeComponent();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            GIANGVIEN_Windows gIANGVIEN_Windows = new GIANGVIEN_Windows();
            gIANGVIEN_Windows.Show();
            this.Hide();
        }

        private void GV_UPDATE_DIEM_Windows_Load(object sender, EventArgs e)
        {
            luubutton.Visible = false;
            huybutton.Visible = false;
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = Account.connectString;
            OracleCommand cmd = new OracleCommand("SELECT * FROM USERDBA.UV_SEL_GIANGVIEN_DANGKY", conn);
            try
            {
                conn.Open();
                OracleDataReader rd = cmd.ExecuteReader();
                if (dsdangky != null)
                {
                    dsdangky.Clear();
                }
                dsdangky = new List<List<string>>();
                while (rd.Read())
                {
                    List<string> onedangky = new List<string>();
                    onedangky.Add(rd["MASV"].ToString());
                    onedangky.Add(rd["MAGV"].ToString());
                    onedangky.Add(rd["MAHP"].ToString());
                    onedangky.Add(rd["HK"].ToString());
                    onedangky.Add(rd["NAM"].ToString());
                    onedangky.Add(rd["MACT"].ToString());
                    onedangky.Add(rd["DIEMTH"].ToString());
                    onedangky.Add(rd["DIEMQT"].ToString());
                    onedangky.Add(rd["DIEMCK"].ToString());
                    onedangky.Add(rd["DIEMTK"].ToString());
                    dsdangky.Add(onedangky);
                }
                for (int i = 0; i < dsdangky.Count; i++)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = dsdangky[i][0];
                    item.SubItems.Add(dsdangky[i][1]);
                    item.SubItems.Add(dsdangky[i][2]);
                    item.SubItems.Add(dsdangky[i][3]);
                    item.SubItems.Add(dsdangky[i][4]);
                    item.SubItems.Add(dsdangky[i][5]);
                    item.SubItems.Add(dsdangky[i][6]);
                    item.SubItems.Add(dsdangky[i][7]);
                    item.SubItems.Add(dsdangky[i][8]);
                    item.SubItems.Add(dsdangky[i][9]);
                    update_diem_listView.Items.Add(item);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void update_diem_listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (update_diem_listView.SelectedItems.Count > 0)
            {
                ListViewItem listViewItem = update_diem_listView.SelectedItems[0];
                masvtextBox.Text = listViewItem.Text;
                magvtextBox.Text = listViewItem.SubItems[1].Text;
                mahptextBox.Text = listViewItem.SubItems[2].Text;
                hktextbox.Text = listViewItem.SubItems[3].Text;
                namtextBox.Text = listViewItem.SubItems[4].Text;
                macttextBox.Text = listViewItem.SubItems[5].Text;
                diemthtextBox.Text = listViewItem.SubItems[6].Text;
                diemqttextBox.Text = listViewItem.SubItems[7].Text;
                diemcktextbox.Text = listViewItem.SubItems[8].Text;
                diemtktextBox.Text = listViewItem.SubItems[9].Text;
            }
        }

        private void refresh()
        {
            luubutton.Visible = false;
            huybutton.Visible = false;
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = Account.connectString;
            OracleCommand cmd = new OracleCommand("SELECT * FROM USERDBA.UV_SEL_GIANGVIEN_DANGKY", conn);
            try
            {
                conn.Open();
                OracleDataReader rd = cmd.ExecuteReader();
                if (dsdangky != null)
                {
                    dsdangky.Clear();
                }
                dsdangky = new List<List<string>>();
                while (rd.Read())
                {
                    List<string> onedangky = new List<string>();
                    onedangky.Add(rd["MASV"].ToString());
                    onedangky.Add(rd["MAGV"].ToString());
                    onedangky.Add(rd["MAHP"].ToString());
                    onedangky.Add(rd["HK"].ToString());
                    onedangky.Add(rd["NAM"].ToString());
                    onedangky.Add(rd["MACT"].ToString());
                    onedangky.Add(rd["DIEMTH"].ToString());
                    onedangky.Add(rd["DIEMQT"].ToString());
                    onedangky.Add(rd["DIEMCK"].ToString());
                    onedangky.Add(rd["DIEMTK"].ToString());
                    dsdangky.Add(onedangky);
                }
                if (update_diem_listView.Items != null)
                {
                    update_diem_listView.Items.Clear();
                }
                for (int i = 0; i < dsdangky.Count; i++)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = dsdangky[i][0];
                    item.SubItems.Add(dsdangky[i][1]);
                    item.SubItems.Add(dsdangky[i][2]);
                    item.SubItems.Add(dsdangky[i][3]);
                    item.SubItems.Add(dsdangky[i][4]);
                    item.SubItems.Add(dsdangky[i][5]);
                    item.SubItems.Add(dsdangky[i][6]);
                    item.SubItems.Add(dsdangky[i][7]);
                    item.SubItems.Add(dsdangky[i][8]);
                    item.SubItems.Add(dsdangky[i][9]);
                    update_diem_listView.Items.Add(item);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dIEMTHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(masvtextBox.Text) || string.IsNullOrWhiteSpace(magvtextBox.Text)
                || string.IsNullOrWhiteSpace(mahptextBox.Text) || string.IsNullOrWhiteSpace(hktextbox.Text)
                || string.IsNullOrWhiteSpace(namtextBox.Text))
            {
                MessageBox.Show("MASV, MAGV, MAHP, HK, NAM không được bỏ trống\nVui lòng chọn 1 dòng dữ liệu bất kì!");
                return;
            }
            luubutton.Visible = true; 
            huybutton.Visible = true;
            masvtextBox.Enabled = false;
            magvtextBox.Enabled = false;
            mahptextBox.Enabled = false;
            hktextbox.Enabled = false;
            namtextBox.Enabled = false;
            macttextBox.Enabled = false;
            diemqttextBox.Enabled = false;
            diemcktextbox.Enabled = false;
            diemtktextBox.Enabled = false;
        }

        private void huybutton_Click(object sender, EventArgs e)
        {
            masvtextBox.Enabled = true;
            magvtextBox.Enabled = true;
            mahptextBox.Enabled=true;
            hktextbox.Enabled = true;
            namtextBox.Enabled=true;
            macttextBox.Enabled=true;
            diemthtextBox.Enabled=true;
            diemqttextBox.Enabled=true;
            diemcktextbox.Enabled=true;
            diemtktextBox.Enabled=true;
            refresh();
        }

        private void dIEMQTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(masvtextBox.Text) || string.IsNullOrWhiteSpace(magvtextBox.Text)
                || string.IsNullOrWhiteSpace(mahptextBox.Text) || string.IsNullOrWhiteSpace(hktextbox.Text)
                || string.IsNullOrWhiteSpace(namtextBox.Text))
            {
                MessageBox.Show("MASV, MAGV, MAHP, HK, NAM không được bỏ trống\nVui lòng chọn 1 dòng dữ liệu bất kì!");
                return;
            }
            luubutton.Visible = true;
            huybutton.Visible = true;
            masvtextBox.Enabled = false;
            magvtextBox.Enabled = false;
            mahptextBox.Enabled = false;
            hktextbox.Enabled = false;
            namtextBox.Enabled = false;
            macttextBox.Enabled = false;
            diemthtextBox.Enabled = false;
            diemcktextbox.Enabled = false;
            diemtktextBox.Enabled = false;
        }

        private void dIEMCKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(masvtextBox.Text) || string.IsNullOrWhiteSpace(magvtextBox.Text)
                || string.IsNullOrWhiteSpace(mahptextBox.Text) || string.IsNullOrWhiteSpace(hktextbox.Text)
                || string.IsNullOrWhiteSpace(namtextBox.Text))
            {
                MessageBox.Show("MASV, MAGV, MAHP, HK, NAM không được bỏ trống\nVui lòng chọn 1 dòng dữ liệu bất kì!");
                return;
            }
            luubutton.Visible = true;
            huybutton.Visible = true;
            masvtextBox.Enabled = false;
            magvtextBox.Enabled = false;
            mahptextBox.Enabled = false;
            hktextbox.Enabled = false;
            namtextBox.Enabled = false;
            macttextBox.Enabled = false;
            diemqttextBox.Enabled = false;
            diemthtextBox.Enabled = false;
            diemtktextBox.Enabled = false;
        }

        private void dIEMTKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(masvtextBox.Text) || string.IsNullOrWhiteSpace(magvtextBox.Text)
                || string.IsNullOrWhiteSpace(mahptextBox.Text) || string.IsNullOrWhiteSpace(hktextbox.Text)
                || string.IsNullOrWhiteSpace(namtextBox.Text))
            {
                MessageBox.Show("MASV, MAGV, MAHP, HK, NAM không được bỏ trống\nVui lòng chọn 1 dòng dữ liệu bất kì!");
                return;
            }
            luubutton.Visible = true;
            huybutton.Visible = true;
            masvtextBox.Enabled = false;
            magvtextBox.Enabled = false;
            mahptextBox.Enabled = false;
            hktextbox.Enabled = false;
            namtextBox.Enabled = false;
            macttextBox.Enabled = false;
            diemqttextBox.Enabled = false;
            diemcktextbox.Enabled = false;
            diemthtextBox.Enabled = false;
        }

        private void luubutton_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = Account.connectString;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            if (diemthtextBox.Enabled == true)
            {
                cmd.CommandText = "UPDATE USERDBA.UV_SEL_GIANGVIEN_DANGKY SET DIEMTH = \'" + diemthtextBox.Text;
            } else if (diemqttextBox.Enabled == true)
            {
                cmd.CommandText = "UPDATE USERDBA.UV_SEL_GIANGVIEN_DANGKY SET DIEMQT = \'" + diemqttextBox.Text; 
            } else if (diemcktextbox.Enabled == true)
            {
                cmd.CommandText = "UPDATE USERDBA.UV_SEL_GIANGVIEN_DANGKY SET DIEMCK = \'" + diemcktextbox.Text;
            } else if (diemtktextBox.Enabled == true)
            {
                cmd.CommandText = "UPDATE USERDBA.UV_SEL_GIANGVIEN_DANGKY SET DIEMTK = \'" + diemtktextBox.Text;
            }
            cmd.CommandText += "\' WHERE MASV = \'" + masvtextBox.Text + "\' AND MAGV = \'" + magvtextBox.Text + "\' AND MAHP =  \'" + mahptextBox.Text
                + "\' AND HK =  \'" + hktextbox.Text + "\' AND NAM =  \'" + namtextBox.Text + "\' AND MACT =  \'" + macttextBox.Text + "\'";
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
                masvtextBox.Enabled = true;
                magvtextBox.Enabled = true;
                mahptextBox.Enabled = true;
                hktextbox.Enabled = true;
                namtextBox.Enabled = true;
                macttextBox.Enabled = true;
                diemthtextBox.Enabled = true;
                diemqttextBox.Enabled = true;
                diemcktextbox.Enabled = true;
                diemtktextBox.Enabled = true;
                refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
