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
            this.btnInsertDeleteUpdateRoleUser = new System.Windows.Forms.Button();
            this.btnRevokePrivilege = new System.Windows.Forms.Button();
            this.btnGrantPrivilege = new System.Windows.Forms.Button();
            this.btnViewPrivilege = new System.Windows.Forms.Button();
            this.btnViewListAccount = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(173, 20);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(657, 55);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Chào mừng đến với ứng dụng";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnInsertDeleteUpdateRoleUser
            // 
            this.btnInsertDeleteUpdateRoleUser.Location = new System.Drawing.Point(435, 237);
            this.btnInsertDeleteUpdateRoleUser.Name = "btnInsertDeleteUpdateRoleUser";
            this.btnInsertDeleteUpdateRoleUser.Size = new System.Drawing.Size(156, 72);
            this.btnInsertDeleteUpdateRoleUser.TabIndex = 6;
            this.btnInsertDeleteUpdateRoleUser.Text = "Thêm/Xóa/Sửa Role/User";
            this.btnInsertDeleteUpdateRoleUser.UseVisualStyleBackColor = true;
            this.btnInsertDeleteUpdateRoleUser.Click += new System.EventHandler(this.btnInsertDeleteUpdateRoleUser_Click);
            // 
            // btnRevokePrivilege
            // 
            this.btnRevokePrivilege.Location = new System.Drawing.Point(578, 360);
            this.btnRevokePrivilege.Name = "btnRevokePrivilege";
            this.btnRevokePrivilege.Size = new System.Drawing.Size(156, 72);
            this.btnRevokePrivilege.TabIndex = 7;
            this.btnRevokePrivilege.Text = "Thu hồi quyền";
            this.btnRevokePrivilege.UseVisualStyleBackColor = true;
            this.btnRevokePrivilege.Click += new System.EventHandler(this.btnRevokePrivilege_Click);
            // 
            // btnGrantPrivilege
            // 
            this.btnGrantPrivilege.Location = new System.Drawing.Point(293, 360);
            this.btnGrantPrivilege.Name = "btnGrantPrivilege";
            this.btnGrantPrivilege.Size = new System.Drawing.Size(156, 72);
            this.btnGrantPrivilege.TabIndex = 8;
            this.btnGrantPrivilege.Text = "Cấp quyền";
            this.btnGrantPrivilege.UseVisualStyleBackColor = true;
            this.btnGrantPrivilege.Click += new System.EventHandler(this.btnGrantPrivilege_Click);
            // 
            // btnViewPrivilege
            // 
            this.btnViewPrivilege.Location = new System.Drawing.Point(578, 123);
            this.btnViewPrivilege.Name = "btnViewPrivilege";
            this.btnViewPrivilege.Size = new System.Drawing.Size(156, 72);
            this.btnViewPrivilege.TabIndex = 9;
            this.btnViewPrivilege.Text = "Xem thông tin về quyền";
            this.btnViewPrivilege.UseVisualStyleBackColor = true;
            this.btnViewPrivilege.Click += new System.EventHandler(this.btnViewPrivilege_Click);
            // 
            // btnViewListAccount
            // 
            this.btnViewListAccount.Location = new System.Drawing.Point(293, 123);
            this.btnViewListAccount.Name = "btnViewListAccount";
            this.btnViewListAccount.Size = new System.Drawing.Size(156, 72);
            this.btnViewListAccount.TabIndex = 10;
            this.btnViewListAccount.Text = "Xem danh sách tài khoản người dùng";
            this.btnViewListAccount.UseVisualStyleBackColor = true;
            this.btnViewListAccount.Click += new System.EventHandler(this.btnViewListAccount_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(858, 492);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(108, 40);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 544);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnViewListAccount);
            this.Controls.Add(this.btnViewPrivilege);
            this.Controls.Add(this.btnGrantPrivilege);
            this.Controls.Add(this.btnRevokePrivilege);
            this.Controls.Add(this.btnInsertDeleteUpdateRoleUser);
            this.Controls.Add(this.lblWelcome);
            this.Name = "MainWindow";
            this.Text = "Màn hình chính";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnInsertDeleteUpdateRoleUser;
        private System.Windows.Forms.Button btnRevokePrivilege;
        private System.Windows.Forms.Button btnGrantPrivilege;
        private System.Windows.Forms.Button btnViewPrivilege;
        private System.Windows.Forms.Button btnViewListAccount;
        private System.Windows.Forms.Button btnBack;
    }
}