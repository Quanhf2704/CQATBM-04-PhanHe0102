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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnThongtincanhan_Click(object sender, EventArgs e)
        {
            // Move to ViewListAccountWindow
            ThongTinCaNhan viewThongtincanhan = new ThongTinCaNhan();
            viewThongtincanhan.Show();
            this.Hide();

        }

        private void btnDanhsachhocphan_Click(object sender, EventArgs e)
        {
            // Move to ViewPrivilege
            DanhSachHocPhan viewDanhsachhocphan = new DanhSachHocPhan();
            viewDanhsachhocphan.Show();
            this.Hide();

        }

        private void btnKHMO_Click(object sender, EventArgs e)
        {
            // Move to ViewRole
            KeHoachMoMon viewKHMO = new KeHoachMoMon();
            viewKHMO.Show();
            this.Hide();

        }

       private void btnDangkyhocphan_Click(object sender, EventArgs e)
        {
            // Move to ViewRole
            DangKyHocPhan viewDangkyhocphan = new DangKyHocPhan();
            viewDangkyhocphan.Show();
            this.Hide();

        }

        private void btnThongbao_Click(object sender, EventArgs e)
        {
            // Move to ViewRole
            ThongBao viewThongbao = new ThongBao();
            viewThongbao.Show();
            this.Hide();

        }

        private void btnEsc_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
