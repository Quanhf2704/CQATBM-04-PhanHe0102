namespace Oracle_Database_Management_Application
{
    partial class MainWindow
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnDanhsachhocphan = new System.Windows.Forms.Button();
            this.btnKHMO = new System.Windows.Forms.Button();
            this.btnThongtincanhan = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDangkyhocphan = new System.Windows.Forms.Button();
            this.btnThongbao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(157, 67);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(541, 46);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Chào mừng đến với ứng dụng";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDanhsachhocphan
            // 
            this.btnDanhsachhocphan.Location = new System.Drawing.Point(350, 169);
            this.btnDanhsachhocphan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDanhsachhocphan.Name = "btnDanhsachhocphan";
            this.btnDanhsachhocphan.Size = new System.Drawing.Size(154, 58);
            this.btnDanhsachhocphan.TabIndex = 6;
            this.btnDanhsachhocphan.Text = "Danh sách học phần";
            this.btnDanhsachhocphan.UseVisualStyleBackColor = true;
            this.btnDanhsachhocphan.Click += new System.EventHandler(this.btnDanhsachhocphan_Click);
            // 
            // btnKHMO
            // 
            this.btnKHMO.Location = new System.Drawing.Point(600, 169);
            this.btnKHMO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKHMO.Name = "btnKHMO";
            this.btnKHMO.Size = new System.Drawing.Size(154, 58);
            this.btnKHMO.TabIndex = 9;
            this.btnKHMO.Text = "Kế hoạch mở môn";
            this.btnKHMO.UseVisualStyleBackColor = true;
            this.btnKHMO.Click += new System.EventHandler(this.btnKHMO_Click);
            // 
            // btnThongtincanhan
            // 
            this.btnThongtincanhan.Location = new System.Drawing.Point(92, 169);
            this.btnThongtincanhan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThongtincanhan.Name = "btnThongtincanhan";
            this.btnThongtincanhan.Size = new System.Drawing.Size(154, 58);
            this.btnThongtincanhan.TabIndex = 10;
            this.btnThongtincanhan.Text = "Thông tin cá nhân";
            this.btnThongtincanhan.UseVisualStyleBackColor = true;
            this.btnThongtincanhan.Click += new System.EventHandler(this.btnThongtincanhan_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(600, 273);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(154, 58);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnEsc_Click);
            // 
            // btnDangkyhocphan
            // 
            this.btnDangkyhocphan.Location = new System.Drawing.Point(92, 273);
            this.btnDangkyhocphan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDangkyhocphan.Name = "btnDangkyhocphan";
            this.btnDangkyhocphan.Size = new System.Drawing.Size(154, 58);
            this.btnDangkyhocphan.TabIndex = 12;
            this.btnDangkyhocphan.Text = "Đăng ký học phần";
            this.btnDangkyhocphan.UseVisualStyleBackColor = true;
            this.btnDangkyhocphan.Click += new System.EventHandler(this.btnDangkyhocphan_Click);
            // 
            // btnThongbao
            // 
            this.btnThongbao.Location = new System.Drawing.Point(350, 273);
            this.btnThongbao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThongbao.Name = "btnThongbao";
            this.btnThongbao.Size = new System.Drawing.Size(154, 58);
            this.btnThongbao.TabIndex = 13;
            this.btnThongbao.Text = "Thông báo";
            this.btnThongbao.UseVisualStyleBackColor = true;
            this.btnThongbao.Click += new System.EventHandler(this.btnThongbao_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 435);
            this.Controls.Add(this.btnThongbao);
            this.Controls.Add(this.btnDangkyhocphan);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnThongtincanhan);
            this.Controls.Add(this.btnKHMO);
            this.Controls.Add(this.btnDanhsachhocphan);
            this.Controls.Add(this.lblWelcome);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainWindow";
            this.Text = "Màn hình chính";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnDanhsachhocphan;
        private System.Windows.Forms.Button btnKHMO;
        private System.Windows.Forms.Button btnThongtincanhan;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDangkyhocphan;
        private System.Windows.Forms.Button btnThongbao;
    }
}