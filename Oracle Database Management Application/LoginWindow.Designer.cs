namespace Oracle_Database_Management_Application
{
    partial class LoginWindow
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
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblAccount = new System.Windows.Forms.Label();
            this.lblPassw = new System.Windows.Forms.Label();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.textPass = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnEsc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(250, 53);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(175, 37);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Đăng nhập";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccount.Location = new System.Drawing.Point(165, 124);
            this.lblAccount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(81, 15);
            this.lblAccount.TabIndex = 1;
            this.lblAccount.Text = "Tên tài khoản";
            this.lblAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPassw
            // 
            this.lblPassw.AutoSize = true;
            this.lblPassw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassw.Location = new System.Drawing.Point(165, 172);
            this.lblPassw.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassw.Name = "lblPassw";
            this.lblPassw.Size = new System.Drawing.Size(58, 15);
            this.lblPassw.TabIndex = 2;
            this.lblPassw.Text = "Mật khẩu";
            this.lblPassw.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textUsername
            // 
            this.textUsername.Location = new System.Drawing.Point(281, 122);
            this.textUsername.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(214, 20);
            this.textUsername.TabIndex = 3;
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(281, 169);
            this.textPass.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textPass.Name = "textPass";
            this.textPass.Size = new System.Drawing.Size(214, 20);
            this.textPass.TabIndex = 4;
            this.textPass.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(257, 248);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(72, 32);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnEsc
            // 
            this.btnEsc.Location = new System.Drawing.Point(352, 248);
            this.btnEsc.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnEsc.Name = "btnEsc";
            this.btnEsc.Size = new System.Drawing.Size(72, 32);
            this.btnEsc.TabIndex = 6;
            this.btnEsc.Text = "Thoát";
            this.btnEsc.UseVisualStyleBackColor = true;
            this.btnEsc.Click += new System.EventHandler(this.btnEsc_Click);
            // 
            // LoginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 354);
            this.Controls.Add(this.btnEsc);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.textUsername);
            this.Controls.Add(this.lblPassw);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.lblLogin);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "LoginWindow";
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.LoginWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Label lblPassw;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnEsc;
    }
}

