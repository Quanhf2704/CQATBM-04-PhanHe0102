namespace Oracle_Database_Management_Application
{
    partial class TDV_NS_Windows
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
            this.QLNSlistView = new System.Windows.Forms.ListView();
            this.MANV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HOTEN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PHAI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NGSINH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PHUCAP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VAITRO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MADV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.backButton = new System.Windows.Forms.Button();
            this.txt_phoneNo = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.lbl_phoneNo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(403, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ NHÂN SỰ";
            // 
            // QLNSlistView
            // 
            this.QLNSlistView.AllowColumnReorder = true;
            this.QLNSlistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MANV,
            this.HOTEN,
            this.PHAI,
            this.NGSINH,
            this.PHUCAP,
            this.DT,
            this.VAITRO,
            this.MADV});
            this.QLNSlistView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QLNSlistView.FullRowSelect = true;
            this.QLNSlistView.GridLines = true;
            this.QLNSlistView.HideSelection = false;
            this.QLNSlistView.Location = new System.Drawing.Point(12, 53);
            this.QLNSlistView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.QLNSlistView.MultiSelect = false;
            this.QLNSlistView.Name = "QLNSlistView";
            this.QLNSlistView.Size = new System.Drawing.Size(1015, 412);
            this.QLNSlistView.TabIndex = 2;
            this.QLNSlistView.UseCompatibleStateImageBehavior = false;
            this.QLNSlistView.View = System.Windows.Forms.View.Details;
            // 
            // MANV
            // 
            this.MANV.Text = "MANV";
            this.MANV.Width = 75;
            // 
            // HOTEN
            // 
            this.HOTEN.Text = "HOTEN";
            this.HOTEN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HOTEN.Width = 115;
            // 
            // PHAI
            // 
            this.PHAI.Text = "PHAI";
            this.PHAI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PHAI.Width = 75;
            // 
            // NGSINH
            // 
            this.NGSINH.Text = "NGSINH";
            this.NGSINH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NGSINH.Width = 90;
            // 
            // PHUCAP
            // 
            this.PHUCAP.Text = "PHUCAP";
            this.PHUCAP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PHUCAP.Width = 95;
            // 
            // DT
            // 
            this.DT.Text = "DT";
            this.DT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DT.Width = 95;
            // 
            // VAITRO
            // 
            this.VAITRO.Text = "VAITRO";
            this.VAITRO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.VAITRO.Width = 115;
            // 
            // MADV
            // 
            this.MADV.Text = "MADV";
            this.MADV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MADV.Width = 95;
            // 
            // backButton
            // 
            this.backButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(904, 474);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(94, 37);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // txt_phoneNo
            // 
            this.txt_phoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phoneNo.Location = new System.Drawing.Point(220, 477);
            this.txt_phoneNo.Name = "txt_phoneNo";
            this.txt_phoneNo.Size = new System.Drawing.Size(222, 30);
            this.txt_phoneNo.TabIndex = 8;
            this.txt_phoneNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(765, 474);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(102, 37);
            this.btn_Save.TabIndex = 9;
            this.btn_Save.Text = "Lưu";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // lbl_phoneNo
            // 
            this.lbl_phoneNo.AutoSize = true;
            this.lbl_phoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phoneNo.Location = new System.Drawing.Point(46, 480);
            this.lbl_phoneNo.Name = "lbl_phoneNo";
            this.lbl_phoneNo.Size = new System.Drawing.Size(168, 25);
            this.lbl_phoneNo.TabIndex = 10;
            this.lbl_phoneNo.Text = "Số điện thoại mới:";
            // 
            // TDV_NS_Windows
            // 
            this.AcceptButton = this.btn_Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.backButton;
            this.ClientSize = new System.Drawing.Size(1043, 518);
            this.Controls.Add(this.lbl_phoneNo);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_phoneNo);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.QLNSlistView);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TDV_NS_Windows";
            this.Text = "Quản lý nhân sự";
            this.Load += new System.EventHandler(this.TK_NS_Windows_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView QLNSlistView;
        private System.Windows.Forms.ColumnHeader MANV;
        private System.Windows.Forms.ColumnHeader HOTEN;
        private System.Windows.Forms.ColumnHeader PHAI;
        private System.Windows.Forms.ColumnHeader NGSINH;
        private System.Windows.Forms.ColumnHeader PHUCAP;
        private System.Windows.Forms.ColumnHeader DT;
        private System.Windows.Forms.ColumnHeader VAITRO;
        private System.Windows.Forms.ColumnHeader MADV;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox txt_phoneNo;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label lbl_phoneNo;
    }
}