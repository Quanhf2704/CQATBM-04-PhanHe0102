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

namespace Oracle_Database_Management_Application
{
    public partial class TDV_PHANCONG_Windows : Form
    {
        private List<List<string>> phanconglist;
        public TDV_PHANCONG_Windows()
        {
            InitializeComponent();
        }

        private void TK_PHANCONG_Windows_Load(object sender, EventArgs e)
        {
            saveButton.Visible = false;
            huyButton.Visible = false;
            newmagvtextBox.Visible = false;
            newmahptextBox.Visible = false;
            newhktextBox.Visible = false;
            newnamtextBox.Visible = false;
            newmacttextBox.Visible = false;
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = Account.connectString;
            OracleCommand cmd = new OracleCommand("SELECT * FROM USERDBA.UV_TDV_MODIFY_PHANCONG", conn);
            try
            {
                conn.Open();
                OracleDataReader rd = cmd.ExecuteReader();
                if (phanconglist != null)
                {
                    phanconglist.Clear();
                }
                phanconglist = new List<List<string>>();
                while (rd.Read())
                {
                    List<string> onePhancong = new List<string>();
                    onePhancong.Add(rd["MAGV"].ToString());
                    onePhancong.Add(rd["MAHP"].ToString());
                    onePhancong.Add(rd["HK"].ToString());
                    onePhancong.Add(rd["NAM"].ToString());
                    onePhancong.Add(rd["MACT"].ToString());
                    phanconglist.Add(onePhancong);
                }
                for (int i = 0; i<phanconglist.Count; i++)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = phanconglist[i][0];
                    item.SubItems.Add(phanconglist[i][1]);
                    item.SubItems.Add(phanconglist[i][2]);
                    item.SubItems.Add(phanconglist[i][3]);
                    item.SubItems.Add(phanconglist[i][4]);
                    phanconglistView.Items.Add(item);
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

        private void addButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MAGVtextBox.Text) || string.IsNullOrWhiteSpace(MAHPtextBox.Text) || string.IsNullOrWhiteSpace(HKtextBox.Text) || string.IsNullOrWhiteSpace(NAMtextBox.Text) || string.IsNullOrWhiteSpace(MACTtextBox.Text))
            {
                MessageBox.Show("Không được bỏ trống bất kì ô nào!");
                return;
            }
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = Account.connectString;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO USERDBA.UV_TDV_MODIFY_PHANCONG VALUES (\'" + MAGVtextBox.Text + "\', \'" + MAHPtextBox.Text
                + "\', \'" + HKtextBox.Text + "\', \'" + NAMtextBox.Text + "\', \'" + MACTtextBox.Text + "\')";
            try
            {
                conn.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã thêm thành công!");
                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conn.Close();
                refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void refresh()
        {
            //phanconglistView.Items.Clear();
            newmagvtextBox.Visible = false;
            newmahptextBox.Visible = false;
            newhktextBox.Visible = false;
            newnamtextBox.Visible = false;
            newmacttextBox.Visible = false;
            saveButton.Visible = false;
            huyButton.Visible = false;
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = Account.connectString;
            OracleCommand cmd = new OracleCommand("SELECT * FROM USERDBA.UV_TDV_MODIFY_PHANCONG", conn);
            try
            {
                conn.Open();
                OracleDataReader rd = cmd.ExecuteReader();
                if (phanconglistView.Items != null)
                {
                    phanconglistView.Items.Clear();
                }
                if (phanconglist != null)
                {
                    phanconglist.Clear();
                }
                phanconglist = new List<List<string>>();
                while (rd.Read())
                {
                    List<string> onePhancong = new List<string>();
                    onePhancong.Add(rd["MAGV"].ToString());
                    onePhancong.Add(rd["MAHP"].ToString());
                    onePhancong.Add(rd["HK"].ToString());
                    onePhancong.Add(rd["NAM"].ToString());
                    onePhancong.Add(rd["MACT"].ToString());
                    phanconglist.Add(onePhancong);
                }
                if (phanconglistView.Items != null)
                {
                    phanconglistView.Items.Clear();
                }
                for (int i = 0; i < phanconglist.Count; i++)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = phanconglist[i][0];
                    item.SubItems.Add(phanconglist[i][1]);
                    item.SubItems.Add(phanconglist[i][2]);
                    item.SubItems.Add(phanconglist[i][3]);
                    item.SubItems.Add(phanconglist[i][4]);
                    phanconglistView.Items.Add(item);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MAGVtextBox.Text) || string.IsNullOrWhiteSpace(MAHPtextBox.Text) || string.IsNullOrWhiteSpace(HKtextBox.Text) || string.IsNullOrWhiteSpace(NAMtextBox.Text) || string.IsNullOrWhiteSpace(MACTtextBox.Text))
            {
                MessageBox.Show("Không được bỏ trống bất kì ô nào!");
                return;
            }
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = Account.connectString;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "DELETE FROM USERDBA.UV_TDV_MODIFY_PHANCONG WHERE MAGV = \'" + MAGVtextBox.Text + "\' AND MAHP =  \'" + MAHPtextBox.Text
                + "\' AND HK =  \'" + HKtextBox.Text + "\' AND NAM =  \'" + NAMtextBox.Text + "\' AND MACT =  \'" + MACTtextBox.Text + "\'";
            try
            {
                conn.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã xóa thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conn.Close();
                refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void phanconglistView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (phanconglistView.SelectedItems.Count > 0)
            {
                ListViewItem listViewItem = phanconglistView.SelectedItems[0];
                MAGVtextBox.Text = listViewItem.Text;
                MAHPtextBox.Text = listViewItem.SubItems[1].Text;
                HKtextBox.Text = listViewItem.SubItems[2].Text;
                NAMtextBox.Text = listViewItem.SubItems[3].Text;
                MACTtextBox.Text = listViewItem.SubItems[4].Text;
            }
        }

        private void mAGVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MAGVtextBox.Text) || string.IsNullOrWhiteSpace(MAHPtextBox.Text) || string.IsNullOrWhiteSpace(HKtextBox.Text) || string.IsNullOrWhiteSpace(NAMtextBox.Text) || string.IsNullOrWhiteSpace(MACTtextBox.Text))
            {
                MessageBox.Show("Không được bỏ trống bất kì ô nào! Điền đầy đủ các ô hoặc chọn một dòng dữ liệu.");
                return;
            }
            MAHPtextBox.Enabled = false;
            HKtextBox.Enabled = false;
            NAMtextBox .Enabled = false;
            MACTtextBox .Enabled = false;
            MAGVtextBox.Enabled = false;
            huyButton.Visible = true;
            saveButton.Visible = true;
            newmagvtextBox.Visible = true;
            newmagvtextBox.Select();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = Account.connectString;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            if (newmagvtextBox.Visible ==  true)
            {
                cmd.CommandText = "UPDATE USERDBA.UV_TDV_MODIFY_PHANCONG SET MAGV = \'" + newmagvtextBox.Text;
                newmacttextBox.Visible = false;
            } else if (newmahptextBox.Visible == true)
            {
                cmd.CommandText = "UPDATE USERDBA.UV_TDV_MODIFY_PHANCONG SET MAHP= \'" + newmahptextBox.Text;
                newmahptextBox.Visible = false;
            } else if (newhktextBox.Visible == true)
            {
                cmd.CommandText = "UPDATE USERDBA.UV_TDV_MODIFY_PHANCONG SET HK = \'" + newhktextBox.Text;
                newhktextBox.Visible = false;
            } else if (newnamtextBox.Visible == true)
            {
                cmd.CommandText = "UPDATE USERDBA.UV_TDV_MODIFY_PHANCONG SET NAM = \'" + newnamtextBox.Text;
                newnamtextBox.Visible = false;
            } else if (newmacttextBox.Visible == true)
            {
                cmd.CommandText = "UPDATE USERDBA.UV_TDV_MODIFY_PHANCONG SET MACT = \'" + newmacttextBox.Text;
                newmacttextBox.Visible = false;
            }
            cmd.CommandText += "\' WHERE MAGV = \'" + MAGVtextBox.Text + "\' AND MAHP =  \'" + MAHPtextBox.Text
                + "\' AND HK =  \'" + HKtextBox.Text + "\' AND NAM =  \'" + NAMtextBox.Text + "\' AND MACT =  \'" + MACTtextBox.Text + "\'";
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
                refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void mAHPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MAGVtextBox.Text) || string.IsNullOrWhiteSpace(MAHPtextBox.Text) || string.IsNullOrWhiteSpace(HKtextBox.Text) || string.IsNullOrWhiteSpace(NAMtextBox.Text) || string.IsNullOrWhiteSpace(MACTtextBox.Text))
            {
                MessageBox.Show("Không được bỏ trống bất kì ô nào! Điền đầy đủ các ô hoặc chọn một dòng dữ liệu.");
                return;
            }
            MAHPtextBox.Enabled = false;
            HKtextBox.Enabled = false;
            NAMtextBox.Enabled = false;
            MACTtextBox.Enabled = false;
            MAGVtextBox.Enabled = false;
            huyButton.Visible = true;
            saveButton.Visible = true;
            newmahptextBox.Visible = true;
            newmahptextBox.Select();
        }

        private void hKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MAGVtextBox.Text) || string.IsNullOrWhiteSpace(MAHPtextBox.Text) || string.IsNullOrWhiteSpace(HKtextBox.Text) || string.IsNullOrWhiteSpace(NAMtextBox.Text) || string.IsNullOrWhiteSpace(MACTtextBox.Text))
            {
                MessageBox.Show("Không được bỏ trống bất kì ô nào! Điền đầy đủ các ô hoặc chọn một dòng dữ liệu.");
                return;
            }
            MAHPtextBox.Enabled = false;
            HKtextBox.Enabled = false;
            NAMtextBox.Enabled = false;
            MACTtextBox.Enabled = false;
            MAGVtextBox.Enabled = false;
            huyButton.Visible = true;
            saveButton.Visible = true;
            newhktextBox.Visible = true;
            newhktextBox.Select();
        }

        private void nAMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MAGVtextBox.Text) || string.IsNullOrWhiteSpace(MAHPtextBox.Text) || string.IsNullOrWhiteSpace(HKtextBox.Text) || string.IsNullOrWhiteSpace(NAMtextBox.Text) || string.IsNullOrWhiteSpace(MACTtextBox.Text))
            {
                MessageBox.Show("Không được bỏ trống bất kì ô nào! Điền đầy đủ các ô hoặc chọn một dòng dữ liệu.");
                return;
            }
            MAHPtextBox.Enabled = false;
            HKtextBox.Enabled = false;
            NAMtextBox.Enabled = false;
            MACTtextBox.Enabled = false;
            MAGVtextBox.Enabled = false;
            huyButton.Visible = true;
            saveButton.Visible = true;
            newnamtextBox.Visible = true;
            newnamtextBox.Select();
        }

        private void mACTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MAGVtextBox.Text) || string.IsNullOrWhiteSpace(MAHPtextBox.Text) || string.IsNullOrWhiteSpace(HKtextBox.Text) || string.IsNullOrWhiteSpace(NAMtextBox.Text) || string.IsNullOrWhiteSpace(MACTtextBox.Text))
            {
                MessageBox.Show("Không được bỏ trống bất kì ô nào! Điền đầy đủ các ô hoặc chọn một dòng dữ liệu.");
                return;
            }
            MAHPtextBox.Enabled = false;
            HKtextBox.Enabled = false;
            NAMtextBox.Enabled = false;
            MACTtextBox.Enabled = false;
            MAGVtextBox.Enabled = false;
            huyButton.Visible = true;
            saveButton.Visible = true;
            newmacttextBox.Visible = true;
            newmacttextBox.Select();
        }

        private void huyButton_Click(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
