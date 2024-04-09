
namespace Oracle_Database_Management_Application
{
    partial class ViewRoleWindow
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
            this.dataGridViewRole = new System.Windows.Forms.DataGridView();
            this.lblViewRole = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.textUser = new System.Windows.Forms.TextBox();
            this.textRole = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnCreateRole = new System.Windows.Forms.Button();
            this.btnGrantRole = new System.Windows.Forms.Button();
            this.btnCheckPriv = new System.Windows.Forms.Button();
            this.btnDropRole = new System.Windows.Forms.Button();
            this.btnRevokeRole = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRole)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRole
            // 
            this.dataGridViewRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRole.Location = new System.Drawing.Point(12, 68);
            this.dataGridViewRole.Name = "dataGridViewRole";
            this.dataGridViewRole.RowHeadersWidth = 51;
            this.dataGridViewRole.RowTemplate.Height = 24;
            this.dataGridViewRole.Size = new System.Drawing.Size(495, 355);
            this.dataGridViewRole.TabIndex = 0;
            // 
            // lblViewRole
            // 
            this.lblViewRole.AutoSize = true;
            this.lblViewRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewRole.Location = new System.Drawing.Point(207, 19);
            this.lblViewRole.Name = "lblViewRole";
            this.lblViewRole.Size = new System.Drawing.Size(316, 46);
            this.lblViewRole.TabIndex = 4;
            this.lblViewRole.Text = "Thông tin về role";
            this.lblViewRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(531, 68);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(304, 32);
            this.btnRefresh.TabIndex = 16;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // textUser
            // 
            this.textUser.Location = new System.Drawing.Point(600, 147);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(235, 22);
            this.textUser.TabIndex = 22;
            // 
            // textRole
            // 
            this.textRole.Location = new System.Drawing.Point(600, 116);
            this.textRole.Name = "textRole";
            this.textRole.Size = new System.Drawing.Size(235, 22);
            this.textRole.TabIndex = 23;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(528, 116);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(37, 17);
            this.lblRole.TabIndex = 24;
            this.lblRole.Text = "Role";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(528, 147);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(38, 17);
            this.lblUser.TabIndex = 25;
            this.lblUser.Text = "User";
            // 
            // btnCreateRole
            // 
            this.btnCreateRole.Location = new System.Drawing.Point(626, 190);
            this.btnCreateRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateRole.Name = "btnCreateRole";
            this.btnCreateRole.Size = new System.Drawing.Size(209, 32);
            this.btnCreateRole.TabIndex = 26;
            this.btnCreateRole.Text = "Create Role";
            this.btnCreateRole.UseVisualStyleBackColor = true;
            this.btnCreateRole.Click += new System.EventHandler(this.btnCreateRole_Click);
            // 
            // btnGrantRole
            // 
            this.btnGrantRole.Location = new System.Drawing.Point(626, 298);
            this.btnGrantRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGrantRole.Name = "btnGrantRole";
            this.btnGrantRole.Size = new System.Drawing.Size(209, 32);
            this.btnGrantRole.TabIndex = 27;
            this.btnGrantRole.Text = "Grant Role to User";
            this.btnGrantRole.UseVisualStyleBackColor = true;
            this.btnGrantRole.Click += new System.EventHandler(this.btnGrantRole_Click);
            // 
            // btnCheckPriv
            // 
            this.btnCheckPriv.Location = new System.Drawing.Point(626, 262);
            this.btnCheckPriv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCheckPriv.Name = "btnCheckPriv";
            this.btnCheckPriv.Size = new System.Drawing.Size(209, 32);
            this.btnCheckPriv.TabIndex = 28;
            this.btnCheckPriv.Text = "Check Priviledges";
            this.btnCheckPriv.UseVisualStyleBackColor = true;
            this.btnCheckPriv.Click += new System.EventHandler(this.btnCheckPriv_Click);
            // 
            // btnDropRole
            // 
            this.btnDropRole.Location = new System.Drawing.Point(626, 226);
            this.btnDropRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDropRole.Name = "btnDropRole";
            this.btnDropRole.Size = new System.Drawing.Size(209, 32);
            this.btnDropRole.TabIndex = 29;
            this.btnDropRole.Text = "Drop Role";
            this.btnDropRole.UseVisualStyleBackColor = true;
            this.btnDropRole.Click += new System.EventHandler(this.btnDropRole_Click);
            // 
            // btnRevokeRole
            // 
            this.btnRevokeRole.Location = new System.Drawing.Point(626, 334);
            this.btnRevokeRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRevokeRole.Name = "btnRevokeRole";
            this.btnRevokeRole.Size = new System.Drawing.Size(209, 32);
            this.btnRevokeRole.TabIndex = 30;
            this.btnRevokeRole.Text = "Revoke Role from User";
            this.btnRevokeRole.UseVisualStyleBackColor = true;
            this.btnRevokeRole.Click += new System.EventHandler(this.btnRevokeRole_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(761, 392);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 32);
            this.btnBack.TabIndex = 31;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ViewRoleWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 435);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRevokeRole);
            this.Controls.Add(this.btnDropRole);
            this.Controls.Add(this.btnCheckPriv);
            this.Controls.Add(this.btnGrantRole);
            this.Controls.Add(this.btnCreateRole);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.textRole);
            this.Controls.Add(this.textUser);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblViewRole);
            this.Controls.Add(this.dataGridViewRole);
            this.Name = "ViewRoleWindow";
            this.Text = "ViewRoleWindow";
            this.Load += new System.EventHandler(this.Role_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRole)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRole;
        private System.Windows.Forms.Label lblViewRole;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.TextBox textRole;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnCreateRole;
        private System.Windows.Forms.Button btnGrantRole;
        private System.Windows.Forms.Button btnCheckPriv;
        private System.Windows.Forms.Button btnDropRole;
        private System.Windows.Forms.Button btnRevokeRole;
        private System.Windows.Forms.Button btnBack;
    }
}