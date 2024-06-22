namespace Oracle_Database_Management_Application
{
    partial class SINHVIEN_Windows
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
            this.label1 = new System.Windows.Forms.Label();
            this.dshpbutton = new System.Windows.Forms.Button();
            this.khmoButton = new System.Windows.Forms.Button();
            this.qldkhpButton = new System.Windows.Forms.Button();
            this.quaylaiButton = new System.Windows.Forms.Button();
            this.inforbutton = new System.Windows.Forms.Button();
            this.XEMTBbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "SINH VIÊN";
            // 
            // dshpbutton
            // 
            this.dshpbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dshpbutton.Location = new System.Drawing.Point(460, 127);
            this.dshpbutton.Margin = new System.Windows.Forms.Padding(2);
            this.dshpbutton.Name = "dshpbutton";
            this.dshpbutton.Size = new System.Drawing.Size(181, 43);
            this.dshpbutton.TabIndex = 25;
            this.dshpbutton.Text = "Danh sách học phần";
            this.dshpbutton.UseVisualStyleBackColor = true;
            this.dshpbutton.Click += new System.EventHandler(this.dshpbutton_Click);
            // 
            // khmoButton
            // 
            this.khmoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.khmoButton.Location = new System.Drawing.Point(129, 218);
            this.khmoButton.Margin = new System.Windows.Forms.Padding(2);
            this.khmoButton.Name = "khmoButton";
            this.khmoButton.Size = new System.Drawing.Size(175, 41);
            this.khmoButton.TabIndex = 23;
            this.khmoButton.Text = "Kế hoạch mở";
            this.khmoButton.UseVisualStyleBackColor = true;
            this.khmoButton.Click += new System.EventHandler(this.khmoButton_Click);
            // 
            // qldkhpButton
            // 
            this.qldkhpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qldkhpButton.Location = new System.Drawing.Point(460, 227);
            this.qldkhpButton.Margin = new System.Windows.Forms.Padding(2);
            this.qldkhpButton.Name = "qldkhpButton";
            this.qldkhpButton.Size = new System.Drawing.Size(181, 43);
            this.qldkhpButton.TabIndex = 22;
            this.qldkhpButton.Text = "Đăng ký học phần";
            this.qldkhpButton.UseVisualStyleBackColor = true;
            this.qldkhpButton.Click += new System.EventHandler(this.qldkhpButton_Click);
            // 
            // quaylaiButton
            // 
            this.quaylaiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quaylaiButton.Location = new System.Drawing.Point(704, 402);
            this.quaylaiButton.Margin = new System.Windows.Forms.Padding(2);
            this.quaylaiButton.Name = "quaylaiButton";
            this.quaylaiButton.Size = new System.Drawing.Size(85, 37);
            this.quaylaiButton.TabIndex = 31;
            this.quaylaiButton.Text = "Quay lại";
            this.quaylaiButton.UseVisualStyleBackColor = true;
            this.quaylaiButton.Click += new System.EventHandler(this.quaylaiButton_Click);
            // 
            // inforbutton
            // 
            this.inforbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inforbutton.Location = new System.Drawing.Point(129, 127);
            this.inforbutton.Name = "inforbutton";
            this.inforbutton.Size = new System.Drawing.Size(175, 43);
            this.inforbutton.TabIndex = 26;
            this.inforbutton.Text = "Xem thông tin cá nhân";
            this.inforbutton.UseVisualStyleBackColor = true;
            this.inforbutton.Click += new System.EventHandler(this.inforbutton_Click);
            // 
            // XEMTBbutton
            // 
            this.XEMTBbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XEMTBbutton.Location = new System.Drawing.Point(129, 315);
            this.XEMTBbutton.Name = "XEMTBbutton";
            this.XEMTBbutton.Size = new System.Drawing.Size(175, 45);
            this.XEMTBbutton.TabIndex = 30;
            this.XEMTBbutton.Text = "Xem thông báo";
            this.XEMTBbutton.UseVisualStyleBackColor = true;
            this.XEMTBbutton.Click += new System.EventHandler(this.XEMTBbutton_Click);
            // 
            // SINHVIEN_Windows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.quaylaiButton);
            this.Controls.Add(this.XEMTBbutton);
            this.Controls.Add(this.inforbutton);
            this.Controls.Add(this.dshpbutton);
            this.Controls.Add(this.khmoButton);
            this.Controls.Add(this.qldkhpButton);
            this.Controls.Add(this.label1);
            this.Name = "SINHVIEN_Windows";
            this.Text = "Sinh viên";
            this.Load += new System.EventHandler(this.SINHVIEN_Windows_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dshpbutton;
        private System.Windows.Forms.Button khmoButton;
        private System.Windows.Forms.Button qldkhpButton;
        private System.Windows.Forms.Button quaylaiButton;
        private System.Windows.Forms.Button inforbutton;
        private System.Windows.Forms.Button XEMTBbutton;
    }
}