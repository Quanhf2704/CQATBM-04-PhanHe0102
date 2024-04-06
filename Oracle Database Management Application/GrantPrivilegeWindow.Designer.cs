namespace Oracle_Database_Management_Application
{
    partial class GrantPrivilegeWindow
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
            this.lblGrantPrivilege = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnGrantPrivilegeForRole = new System.Windows.Forms.Button();
            this.btnGrantPrivilegeForUser = new System.Windows.Forms.Button();
            this.btnGrantRoleForUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGrantPrivilege
            // 
            this.lblGrantPrivilege.AutoSize = true;
            this.lblGrantPrivilege.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrantPrivilege.Location = new System.Drawing.Point(370, 9);
            this.lblGrantPrivilege.Name = "lblGrantPrivilege";
            this.lblGrantPrivilege.Size = new System.Drawing.Size(258, 55);
            this.lblGrantPrivilege.TabIndex = 1;
            this.lblGrantPrivilege.Text = "Cấp quyền";
            this.lblGrantPrivilege.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(858, 492);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(108, 40);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnGrantPrivilegeForRole
            // 
            this.btnGrantPrivilegeForRole.Location = new System.Drawing.Point(116, 82);
            this.btnGrantPrivilegeForRole.Name = "btnGrantPrivilegeForRole";
            this.btnGrantPrivilegeForRole.Size = new System.Drawing.Size(229, 47);
            this.btnGrantPrivilegeForRole.TabIndex = 15;
            this.btnGrantPrivilegeForRole.Text = "Cấp quyền cho role";
            this.btnGrantPrivilegeForRole.UseVisualStyleBackColor = true;
            this.btnGrantPrivilegeForRole.Click += new System.EventHandler(this.btnGrantPrivilegeForRole_Click);
            // 
            // btnGrantPrivilegeForUser
            // 
            this.btnGrantPrivilegeForUser.Location = new System.Drawing.Point(390, 82);
            this.btnGrantPrivilegeForUser.Name = "btnGrantPrivilegeForUser";
            this.btnGrantPrivilegeForUser.Size = new System.Drawing.Size(229, 47);
            this.btnGrantPrivilegeForUser.TabIndex = 16;
            this.btnGrantPrivilegeForUser.Text = "Cấp quyền cho user";
            this.btnGrantPrivilegeForUser.UseVisualStyleBackColor = true;
            this.btnGrantPrivilegeForUser.Click += new System.EventHandler(this.btnGrantPrivilegeForUser_Click);
            // 
            // btnGrantRoleForUser
            // 
            this.btnGrantRoleForUser.Location = new System.Drawing.Point(663, 82);
            this.btnGrantRoleForUser.Name = "btnGrantRoleForUser";
            this.btnGrantRoleForUser.Size = new System.Drawing.Size(229, 47);
            this.btnGrantRoleForUser.TabIndex = 17;
            this.btnGrantRoleForUser.Text = "Cấp role cho user";
            this.btnGrantRoleForUser.UseVisualStyleBackColor = true;
            this.btnGrantRoleForUser.Click += new System.EventHandler(this.btnGrantRoleForUser_Click);
            // 
            // GrantPrivilegeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 544);
            this.Controls.Add(this.btnGrantRoleForUser);
            this.Controls.Add(this.btnGrantPrivilegeForUser);
            this.Controls.Add(this.btnGrantPrivilegeForRole);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblGrantPrivilege);
            this.Name = "GrantPrivilegeWindow";
            this.Text = "Cấp quyền";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGrantPrivilege;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnGrantPrivilegeForRole;
        private System.Windows.Forms.Button btnGrantPrivilegeForUser;
        private System.Windows.Forms.Button btnGrantRoleForUser;
    }
}