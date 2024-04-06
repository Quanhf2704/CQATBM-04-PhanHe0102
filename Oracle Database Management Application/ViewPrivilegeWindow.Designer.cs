namespace Oracle_Database_Management_Application
{
    partial class ViewPrivilegeWindow
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
            this.lblViewPrivilege = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRole = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewRoleUser = new System.Windows.Forms.DataGridView();
            this.dataGridViewPrivilege = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoleUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrivilege)).BeginInit();
            this.SuspendLayout();
            // 
            // lblViewPrivilege
            // 
            this.lblViewPrivilege.AutoSize = true;
            this.lblViewPrivilege.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewPrivilege.Location = new System.Drawing.Point(269, 9);
            this.lblViewPrivilege.Name = "lblViewPrivilege";
            this.lblViewPrivilege.Size = new System.Drawing.Size(433, 55);
            this.lblViewPrivilege.TabIndex = 3;
            this.lblViewPrivilege.Text = "Thông tin về quyền";
            this.lblViewPrivilege.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(858, 492);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(108, 40);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRole
            // 
            this.btnRole.Location = new System.Drawing.Point(92, 67);
            this.btnRole.Name = "btnRole";
            this.btnRole.Size = new System.Drawing.Size(108, 40);
            this.btnRole.TabIndex = 14;
            this.btnRole.Text = "Role";
            this.btnRole.UseVisualStyleBackColor = true;
            this.btnRole.Click += new System.EventHandler(this.btnRole_Click);
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(206, 67);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(108, 40);
            this.btnUser.TabIndex = 15;
            this.btnUser.Text = "User";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(513, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = "Quyền";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewRoleUser
            // 
            this.dataGridViewRoleUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoleUser.Location = new System.Drawing.Point(12, 136);
            this.dataGridViewRoleUser.Name = "dataGridViewRoleUser";
            this.dataGridViewRoleUser.RowHeadersWidth = 62;
            this.dataGridViewRoleUser.RowTemplate.Height = 28;
            this.dataGridViewRoleUser.Size = new System.Drawing.Size(476, 350);
            this.dataGridViewRoleUser.TabIndex = 17;
            // 
            // dataGridViewPrivilege
            // 
            this.dataGridViewPrivilege.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrivilege.Location = new System.Drawing.Point(494, 136);
            this.dataGridViewPrivilege.Name = "dataGridViewPrivilege";
            this.dataGridViewPrivilege.RowHeadersWidth = 62;
            this.dataGridViewPrivilege.RowTemplate.Height = 28;
            this.dataGridViewPrivilege.Size = new System.Drawing.Size(472, 350);
            this.dataGridViewPrivilege.TabIndex = 18;
            // 
            // ViewPrivilege
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 544);
            this.Controls.Add(this.dataGridViewPrivilege);
            this.Controls.Add(this.dataGridViewRoleUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnRole);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblViewPrivilege);
            this.Name = "ViewPrivilege";
            this.Text = "Xem thông tin về quyền";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoleUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrivilege)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblViewPrivilege;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRole;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewRoleUser;
        private System.Windows.Forms.DataGridView dataGridViewPrivilege;
    }
}