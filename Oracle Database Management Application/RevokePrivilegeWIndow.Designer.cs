namespace Oracle_Database_Management_Application
{
    partial class RevokePrivilegeWIndow
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
            this.btnRevokeRoleForUser = new System.Windows.Forms.Button();
            this.btnRevokePrivilegeForUser = new System.Windows.Forms.Button();
            this.btnRevokePrivilegeForRole = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblRevokePrivilege = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRevokeRoleForUser
            // 
            this.btnRevokeRoleForUser.Location = new System.Drawing.Point(668, 84);
            this.btnRevokeRoleForUser.Name = "btnRevokeRoleForUser";
            this.btnRevokeRoleForUser.Size = new System.Drawing.Size(229, 47);
            this.btnRevokeRoleForUser.TabIndex = 22;
            this.btnRevokeRoleForUser.Text = "Thu hồi role cho user";
            this.btnRevokeRoleForUser.UseVisualStyleBackColor = true;
            this.btnRevokeRoleForUser.Click += new System.EventHandler(this.btnRevokeRoleForUser_Click);
            // 
            // btnRevokePrivilegeForUser
            // 
            this.btnRevokePrivilegeForUser.Location = new System.Drawing.Point(372, 84);
            this.btnRevokePrivilegeForUser.Name = "btnRevokePrivilegeForUser";
            this.btnRevokePrivilegeForUser.Size = new System.Drawing.Size(229, 47);
            this.btnRevokePrivilegeForUser.TabIndex = 21;
            this.btnRevokePrivilegeForUser.Text = "Thu hồi quyền cho user";
            this.btnRevokePrivilegeForUser.UseVisualStyleBackColor = true;
            this.btnRevokePrivilegeForUser.Click += new System.EventHandler(this.btnRevokePrivilegeForUser_Click);
            // 
            // btnRevokePrivilegeForRole
            // 
            this.btnRevokePrivilegeForRole.Location = new System.Drawing.Point(72, 84);
            this.btnRevokePrivilegeForRole.Name = "btnRevokePrivilegeForRole";
            this.btnRevokePrivilegeForRole.Size = new System.Drawing.Size(229, 47);
            this.btnRevokePrivilegeForRole.TabIndex = 20;
            this.btnRevokePrivilegeForRole.Text = "Thu hồi quyền cho role";
            this.btnRevokePrivilegeForRole.UseVisualStyleBackColor = true;
            this.btnRevokePrivilegeForRole.Click += new System.EventHandler(this.btnRevokePrivilegeForRole_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(858, 492);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(108, 40);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblRevokePrivilege
            // 
            this.lblRevokePrivilege.AutoSize = true;
            this.lblRevokePrivilege.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevokePrivilege.Location = new System.Drawing.Point(328, 9);
            this.lblRevokePrivilege.Name = "lblRevokePrivilege";
            this.lblRevokePrivilege.Size = new System.Drawing.Size(329, 55);
            this.lblRevokePrivilege.TabIndex = 18;
            this.lblRevokePrivilege.Text = "Thu hồi quyền";
            this.lblRevokePrivilege.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RevokePrivilegeWIndow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 544);
            this.Controls.Add(this.btnRevokeRoleForUser);
            this.Controls.Add(this.btnRevokePrivilegeForUser);
            this.Controls.Add(this.btnRevokePrivilegeForRole);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblRevokePrivilege);
            this.Name = "RevokePrivilegeWIndow";
            this.Text = "Thu hồi quyền";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRevokeRoleForUser;
        private System.Windows.Forms.Button btnRevokePrivilegeForUser;
        private System.Windows.Forms.Button btnRevokePrivilegeForRole;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblRevokePrivilege;
    }
}