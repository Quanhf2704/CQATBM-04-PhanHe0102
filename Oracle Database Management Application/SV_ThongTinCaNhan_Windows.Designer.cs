namespace Oracle_Database_Management_Application
{
    partial class SV_ThongTinCaNhan_Windows
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
            this.lblThongTinCaNhan = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.dataGridViewPriv = new System.Windows.Forms.DataGridView();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblObject = new System.Windows.Forms.Label();
            this.textDiachi = new System.Windows.Forms.TextBox();
            this.textSdt = new System.Windows.Forms.TextBox();
            this.btnCapnhatSdt = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCapnhatdiachi = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPriv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblThongTinCaNhan
            // 
            this.lblThongTinCaNhan.AutoSize = true;
            this.lblThongTinCaNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinCaNhan.Location = new System.Drawing.Point(179, 17);
            this.lblThongTinCaNhan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThongTinCaNhan.Name = "lblThongTinCaNhan";
            this.lblThongTinCaNhan.Size = new System.Drawing.Size(300, 37);
            this.lblThongTinCaNhan.TabIndex = 3;
            this.lblThongTinCaNhan.Text = "Thông Tin Cá Nhân";
            this.lblThongTinCaNhan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(572, 320);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(72, 26);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Return";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dataGridViewPriv
            // 
            this.dataGridViewPriv.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewPriv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPriv.Location = new System.Drawing.Point(43, 196);
            this.dataGridViewPriv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewPriv.Name = "dataGridViewPriv";
            this.dataGridViewPriv.RowHeadersWidth = 62;
            this.dataGridViewPriv.RowTemplate.Height = 28;
            this.dataGridViewPriv.Size = new System.Drawing.Size(567, 110);
            this.dataGridViewPriv.TabIndex = 17;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(58, 79);
            this.lblDiaChi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(41, 13);
            this.lblDiaChi.TabIndex = 18;
            this.lblDiaChi.Text = "Địa Chỉ";
            // 
            // lblObject
            // 
            this.lblObject.AutoSize = true;
            this.lblObject.Location = new System.Drawing.Point(58, 110);
            this.lblObject.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblObject.Name = "lblObject";
            this.lblObject.Size = new System.Drawing.Size(75, 13);
            this.lblObject.TabIndex = 19;
            this.lblObject.Text = "Số Điện Thoại";
            // 
            // textDiachi
            // 
            this.textDiachi.Location = new System.Drawing.Point(146, 79);
            this.textDiachi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textDiachi.Name = "textDiachi";
            this.textDiachi.Size = new System.Drawing.Size(384, 20);
            this.textDiachi.TabIndex = 21;
            // 
            // textSdt
            // 
            this.textSdt.Location = new System.Drawing.Point(146, 107);
            this.textSdt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textSdt.Name = "textSdt";
            this.textSdt.Size = new System.Drawing.Size(384, 20);
            this.textSdt.TabIndex = 23;
            // 
            // btnCapnhatSdt
            // 
            this.btnCapnhatSdt.Location = new System.Drawing.Point(548, 103);
            this.btnCapnhatSdt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCapnhatSdt.Name = "btnCapnhatSdt";
            this.btnCapnhatSdt.Size = new System.Drawing.Size(97, 26);
            this.btnCapnhatSdt.TabIndex = 27;
            this.btnCapnhatSdt.Text = "Cập Nhật SĐT";
            this.btnCapnhatSdt.UseVisualStyleBackColor = true;
            this.btnCapnhatSdt.Click += new System.EventHandler(this.btnUpdatePhone_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Azure;
            this.dataGridView1.Location = new System.Drawing.Point(52, 203);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(549, 93);
            this.dataGridView1.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(50, 188);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Thông tin cá nhân";
            // 
            // btnCapnhatdiachi
            // 
            this.btnCapnhatdiachi.Location = new System.Drawing.Point(548, 71);
            this.btnCapnhatdiachi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCapnhatdiachi.Name = "btnCapnhatdiachi";
            this.btnCapnhatdiachi.Size = new System.Drawing.Size(97, 26);
            this.btnCapnhatdiachi.TabIndex = 30;
            this.btnCapnhatdiachi.Text = "Cập Nhật Địa Chỉ";
            this.btnCapnhatdiachi.UseVisualStyleBackColor = true;
            this.btnCapnhatdiachi.Click += new System.EventHandler(this.btnUpdateAddress_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(492, 320);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(69, 24);
            this.btnRefresh.TabIndex = 31;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // SV_ThongTinCaNhan_Windows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 353);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnCapnhatdiachi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCapnhatSdt);
            this.Controls.Add(this.textSdt);
            this.Controls.Add(this.textDiachi);
            this.Controls.Add(this.lblObject);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.dataGridViewPriv);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblThongTinCaNhan);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SV_ThongTinCaNhan_Windows";
            this.Text = "Màn Hình Thông Tin Cá Nhân";
            this.Load += new System.EventHandler(this.ThongTinCaNhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPriv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThongTinCaNhan;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dataGridViewPriv;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblObject;
        private System.Windows.Forms.TextBox textDiachi;
        private System.Windows.Forms.TextBox textSdt;
        private System.Windows.Forms.Button btnCapnhatSdt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCapnhatdiachi;
        private System.Windows.Forms.Button btnRefresh;
    }
}