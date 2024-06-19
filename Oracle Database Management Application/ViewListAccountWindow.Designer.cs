namespace Oracle_Database_Management_Application
{
    partial class ViewListAccountWindow
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
            this.lblViewListAccount = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.dataGridViewListAccount = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.textPass = new System.Windows.Forms.TextBox();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.btnDropUser = new System.Windows.Forms.Button();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.btnCheckPriv = new System.Windows.Forms.Button();
            this.btnCheckRole = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // lblViewListAccount
            // 
            this.lblViewListAccount.AutoSize = true;
            this.lblViewListAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewListAccount.Location = new System.Drawing.Point(145, 9);
            this.lblViewListAccount.Name = "lblViewListAccount";
            this.lblViewListAccount.Size = new System.Drawing.Size(715, 55);
            this.lblViewListAccount.TabIndex = 2;
            this.lblViewListAccount.Text = "Danh sách tài khoản người dùng";
            this.lblViewListAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(858, 492);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(108, 40);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Return";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dataGridViewListAccount
            // 
            this.dataGridViewListAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListAccount.Location = new System.Drawing.Point(14, 69);
            this.dataGridViewListAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewListAccount.Name = "dataGridViewListAccount";
            this.dataGridViewListAccount.RowHeadersWidth = 62;
            this.dataGridViewListAccount.RowTemplate.Height = 28;
            this.dataGridViewListAccount.Size = new System.Drawing.Size(657, 461);
            this.dataGridViewListAccount.TabIndex = 13;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(703, 68);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(261, 36);
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(703, 126);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(83, 20);
            this.lblUsername.TabIndex = 15;
            this.lblUsername.Text = "Username";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(703, 160);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(78, 20);
            this.lblPass.TabIndex = 16;
            this.lblPass.Text = "Password";
            // 
            // textUsername
            // 
            this.textUsername.Location = new System.Drawing.Point(792, 126);
            this.textUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(170, 26);
            this.textUsername.TabIndex = 17;
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(793, 161);
            this.textPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textPass.Name = "textPass";
            this.textPass.Size = new System.Drawing.Size(170, 26);
            this.textPass.TabIndex = 18;
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Location = new System.Drawing.Point(793, 211);
            this.btnCreateUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(170, 40);
            this.btnCreateUser.TabIndex = 19;
            this.btnCreateUser.Text = "Create User";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // btnDropUser
            // 
            this.btnDropUser.Location = new System.Drawing.Point(796, 259);
            this.btnDropUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDropUser.Name = "btnDropUser";
            this.btnDropUser.Size = new System.Drawing.Size(170, 40);
            this.btnDropUser.TabIndex = 20;
            this.btnDropUser.Text = "Drop User";
            this.btnDropUser.UseVisualStyleBackColor = true;
            this.btnDropUser.Click += new System.EventHandler(this.btnDropUser_Click);
            // 
            // btnChangePass
            // 
            this.btnChangePass.Location = new System.Drawing.Point(796, 306);
            this.btnChangePass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(170, 40);
            this.btnChangePass.TabIndex = 21;
            this.btnChangePass.Text = "Change Password";
            this.btnChangePass.UseVisualStyleBackColor = true;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // btnCheckPriv
            // 
            this.btnCheckPriv.Location = new System.Drawing.Point(796, 354);
            this.btnCheckPriv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCheckPriv.Name = "btnCheckPriv";
            this.btnCheckPriv.Size = new System.Drawing.Size(170, 40);
            this.btnCheckPriv.TabIndex = 22;
            this.btnCheckPriv.Text = "Check Privileges";
            this.btnCheckPriv.UseVisualStyleBackColor = true;
            this.btnCheckPriv.Click += new System.EventHandler(this.btnCheckPriv_Click);
            // 
            // btnCheckRole
            // 
            this.btnCheckRole.Location = new System.Drawing.Point(796, 401);
            this.btnCheckRole.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCheckRole.Name = "btnCheckRole";
            this.btnCheckRole.Size = new System.Drawing.Size(170, 40);
            this.btnCheckRole.TabIndex = 23;
            this.btnCheckRole.Text = "Check Role";
            this.btnCheckRole.UseVisualStyleBackColor = true;
            this.btnCheckRole.Click += new System.EventHandler(this.btnCheckRole_Click);
            // 
            // ViewListAccountWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 544);
            this.Controls.Add(this.btnCheckRole);
            this.Controls.Add(this.btnCheckPriv);
            this.Controls.Add(this.btnChangePass);
            this.Controls.Add(this.btnDropUser);
            this.Controls.Add(this.btnCreateUser);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.textUsername);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dataGridViewListAccount);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblViewListAccount);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ViewListAccountWindow";
            this.Text = "Xem danh sách tài khoản";
            this.Load += new System.EventHandler(this.User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblViewListAccount;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dataGridViewListAccount;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.Button btnDropUser;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.Button btnCheckPriv;
        private System.Windows.Forms.Button btnCheckRole;
    }
}