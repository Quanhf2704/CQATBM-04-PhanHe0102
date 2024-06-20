namespace Oracle_Database_Management_Application
{
    partial class NHANVIENCOBAN_Windows
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
            this.viewInforbutton = new System.Windows.Forms.Button();
            this.svbutton = new System.Windows.Forms.Button();
            this.dvbutton = new System.Windows.Forms.Button();
            this.hpbutton = new System.Windows.Forms.Button();
            this.khmobutton = new System.Windows.Forms.Button();
            this.backbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "NHÂN VIÊN CƠ BẢN";
            // 
            // viewInforbutton
            // 
            this.viewInforbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewInforbutton.Location = new System.Drawing.Point(98, 120);
            this.viewInforbutton.Name = "viewInforbutton";
            this.viewInforbutton.Size = new System.Drawing.Size(230, 42);
            this.viewInforbutton.TabIndex = 1;
            this.viewInforbutton.Text = "Xem thông tin cá nhân";
            this.viewInforbutton.UseVisualStyleBackColor = true;
            this.viewInforbutton.Click += new System.EventHandler(this.viewInforbutton_Click);
            // 
            // svbutton
            // 
            this.svbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.svbutton.Location = new System.Drawing.Point(501, 120);
            this.svbutton.Name = "svbutton";
            this.svbutton.Size = new System.Drawing.Size(217, 42);
            this.svbutton.TabIndex = 2;
            this.svbutton.Text = "Danh sách sinh viên";
            this.svbutton.UseVisualStyleBackColor = true;
            this.svbutton.Click += new System.EventHandler(this.svbutton_Click);
            // 
            // dvbutton
            // 
            this.dvbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dvbutton.Location = new System.Drawing.Point(98, 240);
            this.dvbutton.Name = "dvbutton";
            this.dvbutton.Size = new System.Drawing.Size(230, 55);
            this.dvbutton.TabIndex = 3;
            this.dvbutton.Text = "Danh sách đơn vị";
            this.dvbutton.UseVisualStyleBackColor = true;
            this.dvbutton.Click += new System.EventHandler(this.dvbutton_Click);
            // 
            // hpbutton
            // 
            this.hpbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hpbutton.Location = new System.Drawing.Point(496, 240);
            this.hpbutton.Name = "hpbutton";
            this.hpbutton.Size = new System.Drawing.Size(222, 55);
            this.hpbutton.TabIndex = 4;
            this.hpbutton.Text = "Danh sách học phần";
            this.hpbutton.UseVisualStyleBackColor = true;
            this.hpbutton.Click += new System.EventHandler(this.hpbutton_Click);
            // 
            // khmobutton
            // 
            this.khmobutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.khmobutton.Location = new System.Drawing.Point(98, 350);
            this.khmobutton.Name = "khmobutton";
            this.khmobutton.Size = new System.Drawing.Size(230, 47);
            this.khmobutton.TabIndex = 5;
            this.khmobutton.Text = "Kế hoạch mở";
            this.khmobutton.UseVisualStyleBackColor = true;
            this.khmobutton.Click += new System.EventHandler(this.khmobutton_Click);
            // 
            // backbutton
            // 
            this.backbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbutton.Location = new System.Drawing.Point(496, 350);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(222, 49);
            this.backbutton.TabIndex = 6;
            this.backbutton.Text = "Quay lại";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // NHANVIENCOBAN_Windows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.khmobutton);
            this.Controls.Add(this.hpbutton);
            this.Controls.Add(this.dvbutton);
            this.Controls.Add(this.svbutton);
            this.Controls.Add(this.viewInforbutton);
            this.Controls.Add(this.label1);
            this.Name = "NHANVIENCOBAN_Windows";
            this.Text = "Nhân viên cơ bản";
            this.Load += new System.EventHandler(this.NHANVIENCOBAN_Windows_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button viewInforbutton;
        private System.Windows.Forms.Button svbutton;
        private System.Windows.Forms.Button dvbutton;
        private System.Windows.Forms.Button hpbutton;
        private System.Windows.Forms.Button khmobutton;
        private System.Windows.Forms.Button backbutton;
    }
}