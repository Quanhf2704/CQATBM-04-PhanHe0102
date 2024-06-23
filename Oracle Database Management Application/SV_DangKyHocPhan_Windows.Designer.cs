namespace Oracle_Database_Management_Application
{
    partial class SV_DangKyHocPhan_Windows
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDangkyhocphan = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.background1 = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblmasv = new System.Windows.Forms.Label();
            this.lblmagv = new System.Windows.Forms.Label();
            this.textMagv = new System.Windows.Forms.TextBox();
            this.textMaSV = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblMahp = new System.Windows.Forms.Label();
            this.textMahp = new System.Windows.Forms.TextBox();
            this.background2 = new System.Windows.Forms.DataGridView();
            this.lblThongtindangky = new System.Windows.Forms.Label();
            this.textmact = new System.Windows.Forms.TextBox();
            this.textNam = new System.Windows.Forms.TextBox();
            this.texthocky = new System.Windows.Forms.TextBox();
            this.lblmact = new System.Windows.Forms.Label();
            this.lblnam = new System.Windows.Forms.Label();
            this.lblhk = new System.Windows.Forms.Label();
            this.background3 = new System.Windows.Forms.DataGridView();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.background1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDangkyhocphan
            // 
            this.lblDangkyhocphan.AutoSize = true;
            this.lblDangkyhocphan.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangkyhocphan.Location = new System.Drawing.Point(232, 18);
            this.lblDangkyhocphan.Name = "lblDangkyhocphan";
            this.lblDangkyhocphan.Size = new System.Drawing.Size(360, 46);
            this.lblDangkyhocphan.TabIndex = 2;
            this.lblDangkyhocphan.Text = "Đăng Ký Học Phần";
            this.lblDangkyhocphan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Location = new System.Drawing.Point(688, 481);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(121, 32);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // background1
            // 
            this.background1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.background1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.background1.Location = new System.Drawing.Point(43, 75);
            this.background1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.background1.Name = "background1";
            this.background1.RowHeadersWidth = 62;
            this.background1.RowTemplate.Height = 28;
            this.background1.Size = new System.Drawing.Size(779, 130);
            this.background1.TabIndex = 13;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(481, 482);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(121, 30);
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblmasv
            // 
            this.lblmasv.AutoSize = true;
            this.lblmasv.Location = new System.Drawing.Point(83, 107);
            this.lblmasv.Name = "lblmasv";
            this.lblmasv.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblmasv.Size = new System.Drawing.Size(81, 16);
            this.lblmasv.TabIndex = 15;
            this.lblmasv.Text = "Mã sinh viên";
            // 
            // lblmagv
            // 
            this.lblmagv.AutoSize = true;
            this.lblmagv.Location = new System.Drawing.Point(81, 132);
            this.lblmagv.Name = "lblmagv";
            this.lblmagv.Size = new System.Drawing.Size(91, 16);
            this.lblmagv.TabIndex = 16;
            this.lblmagv.Text = "Mã giảng viên";
            // 
            // textMagv
            // 
            this.textMagv.Location = new System.Drawing.Point(175, 129);
            this.textMagv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textMagv.Name = "textMagv";
            this.textMagv.Size = new System.Drawing.Size(177, 22);
            this.textMagv.TabIndex = 17;
            // 
            // textMaSV
            // 
            this.textMaSV.Location = new System.Drawing.Point(175, 101);
            this.textMaSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textMaSV.Name = "textMaSV";
            this.textMaSV.ReadOnly = true;
            this.textMaSV.Size = new System.Drawing.Size(177, 22);
            this.textMaSV.TabIndex = 18;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(51, 481);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(121, 32);
            this.btnThem.TabIndex = 21;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblMahp
            // 
            this.lblMahp.AutoSize = true;
            this.lblMahp.Location = new System.Drawing.Point(81, 159);
            this.lblMahp.Name = "lblMahp";
            this.lblMahp.Size = new System.Drawing.Size(84, 16);
            this.lblMahp.TabIndex = 26;
            this.lblMahp.Text = "Mã học phần";
            // 
            // textMahp
            // 
            this.textMahp.Location = new System.Drawing.Point(175, 159);
            this.textMahp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textMahp.Name = "textMahp";
            this.textMahp.Size = new System.Drawing.Size(177, 22);
            this.textMahp.TabIndex = 29;
            // 
            // background2
            // 
            this.background2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.background2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.background2.Location = new System.Drawing.Point(53, 87);
            this.background2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.background2.Name = "background2";
            this.background2.RowHeadersWidth = 62;
            this.background2.RowTemplate.Height = 28;
            this.background2.Size = new System.Drawing.Size(760, 107);
            this.background2.TabIndex = 30;
            // 
            // lblThongtindangky
            // 
            this.lblThongtindangky.AutoSize = true;
            this.lblThongtindangky.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblThongtindangky.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblThongtindangky.Location = new System.Drawing.Point(61, 68);
            this.lblThongtindangky.Name = "lblThongtindangky";
            this.lblThongtindangky.Size = new System.Drawing.Size(113, 16);
            this.lblThongtindangky.TabIndex = 31;
            this.lblThongtindangky.Text = "Thông tin đăng ký";
            // 
            // textmact
            // 
            this.textmact.Location = new System.Drawing.Point(595, 160);
            this.textmact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textmact.Name = "textmact";
            this.textmact.Size = new System.Drawing.Size(177, 22);
            this.textmact.TabIndex = 34;
            // 
            // textNam
            // 
            this.textNam.Location = new System.Drawing.Point(595, 132);
            this.textNam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textNam.Name = "textNam";
            this.textNam.Size = new System.Drawing.Size(177, 22);
            this.textNam.TabIndex = 35;
            // 
            // texthocky
            // 
            this.texthocky.Location = new System.Drawing.Point(595, 103);
            this.texthocky.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.texthocky.Name = "texthocky";
            this.texthocky.Size = new System.Drawing.Size(177, 22);
            this.texthocky.TabIndex = 36;
            // 
            // lblmact
            // 
            this.lblmact.AutoSize = true;
            this.lblmact.Location = new System.Drawing.Point(477, 159);
            this.lblmact.Name = "lblmact";
            this.lblmact.Size = new System.Drawing.Size(100, 16);
            this.lblmact.TabIndex = 39;
            this.lblmact.Text = "Mã chương trình";
            // 
            // lblnam
            // 
            this.lblnam.AutoSize = true;
            this.lblnam.Location = new System.Drawing.Point(477, 132);
            this.lblnam.Name = "lblnam";
            this.lblnam.Size = new System.Drawing.Size(36, 16);
            this.lblnam.TabIndex = 40;
            this.lblnam.Text = "Năm";
            // 
            // lblhk
            // 
            this.lblhk.AutoSize = true;
            this.lblhk.Location = new System.Drawing.Point(477, 107);
            this.lblhk.Name = "lblhk";
            this.lblhk.Size = new System.Drawing.Size(49, 16);
            this.lblhk.TabIndex = 41;
            this.lblhk.Text = "Học kỳ";
            // 
            // background3
            // 
            this.background3.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.background3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.background3.Location = new System.Drawing.Point(43, 240);
            this.background3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.background3.Name = "background3";
            this.background3.RowHeadersWidth = 62;
            this.background3.RowTemplate.Height = 28;
            this.background3.Size = new System.Drawing.Size(779, 236);
            this.background3.TabIndex = 42;
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(53, 251);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(760, 208);
            this.dataGridView.TabIndex = 43;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(265, 482);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(121, 32);
            this.btnXoa.TabIndex = 46;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // SV_DangKyHocPhan_Windows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(869, 526);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.lblhk);
            this.Controls.Add(this.lblnam);
            this.Controls.Add(this.lblmact);
            this.Controls.Add(this.texthocky);
            this.Controls.Add(this.textNam);
            this.Controls.Add(this.textmact);
            this.Controls.Add(this.lblThongtindangky);
            this.Controls.Add(this.textMahp);
            this.Controls.Add(this.lblMahp);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.textMaSV);
            this.Controls.Add(this.textMagv);
            this.Controls.Add(this.lblmagv);
            this.Controls.Add(this.lblmasv);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblDangkyhocphan);
            this.Controls.Add(this.background2);
            this.Controls.Add(this.background1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.background3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SV_DangKyHocPhan_Windows";
            this.Text = "Đăng Ký Học Phần";
            this.Load += new System.EventHandler(this.DanhSachDangKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.background1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDangkyhocphan;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView background1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblmasv;
        private System.Windows.Forms.Label lblmagv;
        private System.Windows.Forms.TextBox textMagv;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblMahp;
        private System.Windows.Forms.TextBox textMahp;
        private System.Windows.Forms.DataGridView background2;
        private System.Windows.Forms.Label lblThongtindangky;
        private System.Windows.Forms.TextBox textmact;
        private System.Windows.Forms.TextBox textNam;
        private System.Windows.Forms.TextBox texthocky;
        private System.Windows.Forms.Label lblmact;
        private System.Windows.Forms.Label lblnam;
        private System.Windows.Forms.Label lblhk;
        private System.Windows.Forms.DataGridView background3;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox textMaSV;
    }
}