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
            this.btnViewRole = new System.Windows.Forms.Button();
            this.btnViewPrivilege = new System.Windows.Forms.Button();
            this.btnViewListAccount = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(118, 54);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(440, 37);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Chào mừng đến với ứng dụng";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnViewRole
            // 
            this.btnViewRole.Location = new System.Drawing.Point(290, 154);
            this.btnViewRole.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnViewRole.Name = "btnViewRole";
            this.btnViewRole.Size = new System.Drawing.Size(104, 47);
            this.btnViewRole.TabIndex = 6;
            this.btnViewRole.Text = "Xem danh sách Role";
            this.btnViewRole.UseVisualStyleBackColor = true;
            this.btnViewRole.Click += new System.EventHandler(this.btnViewRole_Click);
            // 
            // btnViewPrivilege
            // 
            this.btnViewPrivilege.Location = new System.Drawing.Point(473, 154);
            this.btnViewPrivilege.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnViewPrivilege.Name = "btnViewPrivilege";
            this.btnViewPrivilege.Size = new System.Drawing.Size(104, 47);
            this.btnViewPrivilege.TabIndex = 9;
            this.btnViewPrivilege.Text = "Xem thông tin về quyền";
            this.btnViewPrivilege.UseVisualStyleBackColor = true;
            this.btnViewPrivilege.Click += new System.EventHandler(this.btnViewPrivilege_Click);
            // 
            // btnViewListAccount
            // 
            this.btnViewListAccount.Location = new System.Drawing.Point(86, 154);
            this.btnViewListAccount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnViewListAccount.Name = "btnViewListAccount";
            this.btnViewListAccount.Size = new System.Drawing.Size(104, 47);
            this.btnViewListAccount.TabIndex = 10;
            this.btnViewListAccount.Text = "Xem danh sách tài khoản người dùng";
            this.btnViewListAccount.UseVisualStyleBackColor = true;
            this.btnViewListAccount.Click += new System.EventHandler(this.btnViewListAccount_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(572, 320);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(72, 26);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 353);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnViewListAccount);
            this.Controls.Add(this.btnViewPrivilege);
            this.Controls.Add(this.btnViewRole);
            this.Controls.Add(this.lblWelcome);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainWindow";
            this.Text = "Màn hình chính";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnViewRole;
        private System.Windows.Forms.Button btnViewPrivilege;
        private System.Windows.Forms.Button btnViewListAccount;
        private System.Windows.Forms.Button btnBack;
    }
}