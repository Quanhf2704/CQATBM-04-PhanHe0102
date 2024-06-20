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
    public partial class TK_NS_Windows : Form
    {
        private List<List<string>> dsns;
        public TK_NS_Windows()
        {
            InitializeComponent();
        }

        private void TK_NS_Windows_Load(object sender, EventArgs e)
        {
            UPDATELABEL.Visible = false;
            SAVEbutton.Visible = false;
            huybutton.Visible = false;
            UPDATEtextBox.Visible = false;
           
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = Account.connectString;
            OracleCommand cmd = new OracleCommand("SELECT * FROM USERDBA.NHANSU", conn);
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
            TruongKhoaWindows truongKhoaWindows = new TruongKhoaWindows();
            truongKhoaWindows.Show();
            this.Hide();
        }

        private void refresh()
        {
            HOTENlabel.Visible = true;
            HOTENtextBox.Visible = true;
            HOTENtextBox.Text = "";
            PHAIlabel.Visible = true;
            PHAItextBox.Visible = true;
            PHAItextBox.Text = "";
            NGSINHlabel.Visible = true;
            NGSINHtextBox.Visible = true;
            NGSINHtextBox.Text = "YYYY-MM-DD";
            DTlabel.Visible = true;
            DTtextBox.Visible = true;
            DTtextBox.Text = "";
            PHUCAPlabel.Visible = true;
            PHUCAPtextBox.Visible = true;
            PHUCAPtextBox.Text = "";
            VAITROlabel.Visible = true;
            VAITROtextBox.Visible = true;
            VAITROtextBox.Text = "";
            MADVlabel.Visible = true;
            madvtextBox.Visible = true;
            madvtextBox.Text = "";
            thembutton.Enabled = true;
            xoabutton.Enabled = true;
            UPDATELABEL.Visible = false;
            SAVEbutton.Visible = false;
            huybutton.Visible = false;
            UPDATEtextBox.Visible = false;
            UPDATEtextBox.Text = "";
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = Account.connectString;
            OracleCommand cmd = new OracleCommand("SELECT * FROM USERDBA.NHANSU", conn);
            try
            {
                conn.Open();
                OracleDataReader rd = cmd.ExecuteReader();
                if (dsns != null)
                {
                    dsns.Clear();
                }
                dsns = new List<List<string>>();
                if (QLNSlistView.Items != null)
                {
                    QLNSlistView.Items.Clear();
                }
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

        private void hOTENToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HOTENlabel.Visible = false;
            HOTENtextBox.Visible = false;
            PHAIlabel.Visible = false;
            PHAItextBox.Visible = false;
            NGSINHlabel.Visible = false;
            NGSINHtextBox.Visible = false;
            PHUCAPlabel.Visible = false;
            PHUCAPtextBox.Visible = false;
            DTlabel.Visible = false;
            DTtextBox.Visible = false;
            VAITROlabel.Visible = false;
            VAITROtextBox.Visible = false;
            MADVlabel.Visible = false;
            madvtextBox.Visible = false;
            MANVLABEL.Visible = true;
            manvtextBox.Visible = true;
            UPDATELABEL.Visible = true;
            UPDATELABEL.Text = "HOTEN";
            UPDATEtextBox.Visible = true;
            SAVEbutton.Visible = true;
            huybutton.Visible = true;
            manvtextBox.Select();
            thembutton.Enabled = false;
            xoabutton.Enabled = false;
        }

        private void pHAIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HOTENlabel.Visible = false;
            HOTENtextBox.Visible = false;
            PHAIlabel.Visible = false;
            PHAItextBox.Visible = false;
            NGSINHlabel.Visible = false;
            NGSINHtextBox.Visible = false;
            PHUCAPlabel.Visible = false;
            PHUCAPtextBox.Visible = false;
            DTlabel.Visible = false;
            DTtextBox.Visible = false;
            VAITROlabel.Visible = false;
            VAITROtextBox.Visible = false;
            MADVlabel.Visible = false;
            madvtextBox.Visible = false;
            MANVLABEL.Visible = true;
            manvtextBox.Visible = true;
            UPDATELABEL.Visible = true;
            UPDATELABEL.Text = "PHAI";
            UPDATEtextBox.Visible = true;
            SAVEbutton.Visible = true;
            huybutton.Visible = true;
            manvtextBox.Select();
            thembutton.Enabled = false;
            xoabutton.Enabled = false;
        }

        private void nGSINHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HOTENlabel.Visible = false;
            HOTENtextBox.Visible = false;
            PHAIlabel.Visible = false;
            PHAItextBox.Visible = false;
            NGSINHlabel.Visible = false;
            NGSINHtextBox.Visible = false;
            PHUCAPlabel.Visible = false;
            PHUCAPtextBox.Visible = false;
            DTlabel.Visible = false;
            DTtextBox.Visible = false;
            VAITROlabel.Visible = false;
            VAITROtextBox.Visible = false;
            MADVlabel.Visible = false;
            madvtextBox.Visible = false;
            MANVLABEL.Visible = true;
            manvtextBox.Visible = true;
            UPDATELABEL.Visible = true;
            UPDATELABEL.Text = "NGSINH";
            UPDATEtextBox.Visible = true;
            SAVEbutton.Visible = true;
            huybutton.Visible = true;
            UPDATEtextBox.Text = "YYYY-MM-DD";
            manvtextBox.Select();
            thembutton.Enabled = false;
            xoabutton.Enabled = false;
        }

        private void pHUCAPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HOTENlabel.Visible = false;
            HOTENtextBox.Visible = false;
            PHAIlabel.Visible = false;
            PHAItextBox.Visible = false;
            NGSINHlabel.Visible = false;
            NGSINHtextBox.Visible = false;
            PHUCAPlabel.Visible = false;
            PHUCAPtextBox.Visible = false;
            DTlabel.Visible = false;
            DTtextBox.Visible = false;
            VAITROlabel.Visible = false;
            VAITROtextBox.Visible = false;
            MADVlabel.Visible = false;
            madvtextBox.Visible = false;
            MANVLABEL.Visible = true;
            manvtextBox.Visible = true;
            UPDATELABEL.Visible = true;
            UPDATELABEL.Text = "PHUCAP";
            UPDATEtextBox.Visible = true;
            SAVEbutton.Visible = true;
            huybutton.Visible = true;
            manvtextBox.Select();
            thembutton.Enabled = false;
            xoabutton.Enabled = false;
        }

        private void dTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HOTENlabel.Visible = false;
            HOTENtextBox.Visible = false;
            PHAIlabel.Visible = false;
            PHAItextBox.Visible = false;
            NGSINHlabel.Visible = false;
            NGSINHtextBox.Visible = false;
            PHUCAPlabel.Visible = false;
            PHUCAPtextBox.Visible = false;
            DTlabel.Visible = false;
            DTtextBox.Visible = false;
            VAITROlabel.Visible = false;
            VAITROtextBox.Visible = false;
            MADVlabel.Visible = false;
            madvtextBox.Visible = false;
            MANVLABEL.Visible = true;
            manvtextBox.Visible = true;
            UPDATELABEL.Visible = true;
            UPDATELABEL.Text = "DT";
            UPDATEtextBox.Visible = true;
            SAVEbutton.Visible = true;
            huybutton.Visible = true;
            manvtextBox.Select();
            thembutton.Enabled = false;
            xoabutton.Enabled = false;
        }

        private void vAITROToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HOTENlabel.Visible = false;
            HOTENtextBox.Visible = false;
            PHAIlabel.Visible = false;
            PHAItextBox.Visible = false;
            NGSINHlabel.Visible = false;
            NGSINHtextBox.Visible = false;
            PHUCAPlabel.Visible = false;
            PHUCAPtextBox.Visible = false;
            DTlabel.Visible = false;
            DTtextBox.Visible = false;
            VAITROlabel.Visible = false;
            VAITROtextBox.Visible = false;
            MADVlabel.Visible = false;
            madvtextBox.Visible = false;
            MANVLABEL.Visible = true;
            manvtextBox.Visible = true;
            UPDATELABEL.Visible = true;
            UPDATELABEL.Text = "VAITRO";
            UPDATEtextBox.Visible = true;
            SAVEbutton.Visible = true;
            huybutton.Visible = true;
            manvtextBox.Select();
            thembutton.Enabled = false;
            xoabutton.Enabled = false;
        }

        private void mADVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HOTENlabel.Visible = false;
            HOTENtextBox.Visible = false;
            PHAIlabel.Visible = false;
            PHAItextBox.Visible = false;
            NGSINHlabel.Visible = false;
            NGSINHtextBox.Visible = false;
            PHUCAPlabel.Visible = false;
            PHUCAPtextBox.Visible = false;
            DTlabel.Visible = false;
            DTtextBox.Visible = false;
            VAITROlabel.Visible = false;
            VAITROtextBox.Visible = false;
            MADVlabel.Visible = false;
            madvtextBox.Visible = false;
            MANVLABEL.Visible = true;
            manvtextBox.Visible = true;
            UPDATELABEL.Visible = true;
            UPDATELABEL.Text = "MADV";
            UPDATEtextBox.Visible = true;
            SAVEbutton.Visible = true;
            huybutton.Visible = true;
            manvtextBox.Select();
            thembutton.Enabled = false;
            xoabutton.Enabled = false;
        }

        private void SAVEbutton_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = Account.connectString;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            if (UPDATELABEL.Text == "HOTEN")
            {
                cmd.CommandText = "UPDATE USERDBA.NHANSU SET HOTEN = N\'" + UPDATEtextBox.Text + "\'";
            } else if (UPDATELABEL.Text == "PHAI")
            {
                cmd.CommandText = "UPDATE USERDBA.NHANSU SET PHAI = N\'" + UPDATEtextBox.Text + "\'";
            } else if (UPDATELABEL.Text == "NGSINH")
            {
                cmd.CommandText = "UPDATE USERDBA.NHANSU SET NGSINH = TO_DATE(\'" + UPDATEtextBox.Text + "\' , \'YYYY-MM-DD\')";
            } else if (UPDATELABEL.Text == "PHUCAP")
            {
                cmd.CommandText = "UPDATE USERDBA.NHANSU SET PHUCAP = \'" + UPDATEtextBox.Text + "\'";
            } else if (UPDATELABEL.Text == "DT")
            {
                cmd.CommandText = "UPDATE USERDBA.NHANSU SET DT = \'" + UPDATEtextBox.Text + "\'";
            } else if (UPDATELABEL.Text == "VAITRO")
            {
                cmd.CommandText = "UPDATE USERDBA.NHANSU SET VAITRO = \'" + UPDATEtextBox.Text + "\'";
            } else if (UPDATELABEL.Text == "MADV")
            {
                cmd.CommandText = "UPDATE USERDBA.NHANSU SET MADV = \'" + UPDATEtextBox.Text + "\'";
            }

            cmd.CommandText += " WHERE MANV = \'" + manvtextBox.Text + "\'";
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

        private void huybutton_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void thembutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(manvtextBox.Text) || string.IsNullOrWhiteSpace(HOTENtextBox.Text)
                || string.IsNullOrWhiteSpace(PHAItextBox.Text) || string.IsNullOrWhiteSpace(NGSINHtextBox.Text)
                || string.IsNullOrWhiteSpace(PHUCAPtextBox.Text) || string.IsNullOrWhiteSpace(DTtextBox.Text) 
                || string.IsNullOrWhiteSpace(VAITROtextBox.Text) || string.IsNullOrWhiteSpace(madvtextBox.Text))
            {
                MessageBox.Show("Không được bỏ trống bất kì ô nào!");
                return;
            }
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = Account.connectString;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO USERDBA.NHANSU VALUES (\'" + manvtextBox.Text + "\', N\'" + HOTENtextBox.Text
                + "\', \'" + PHAItextBox.Text + "\', TO_DATE(\'" + NGSINHtextBox.Text + "\', \'YYYY-MM-DD\'), \'"
                + PHUCAPtextBox.Text + "\', \'" + DTtextBox.Text + "\', N\'" + VAITROtextBox.Text + "\', \'"
                + madvtextBox.Text + "\')";
            try
            {
                conn.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã thêm thành công!");
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

        private void xoabutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(manvtextBox.Text))
            {
                MessageBox.Show("MANV không được để trống!");
                return;
            }
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = Account.connectString;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "DELETE FROM USERDBA.NHANSU WHERE MANV = \'" + manvtextBox.Text + "\'";
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

        private void QLNSlistView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
