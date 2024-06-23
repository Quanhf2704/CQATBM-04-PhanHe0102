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
            this.btnGrantforUser = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dataGridViewPriv = new System.Windows.Forms.DataGridView();
            this.lblPriv = new System.Windows.Forms.Label();
            this.lblObject = new System.Windows.Forms.Label();
            this.lblUserRole = new System.Windows.Forms.Label();
            this.textPriv = new System.Windows.Forms.TextBox();
            this.textUserRole = new System.Windows.Forms.TextBox();
            this.textObject = new System.Windows.Forms.TextBox();
            this.checkBoxGrantOption = new System.Windows.Forms.CheckBox();
            this.btnRevoke = new System.Windows.Forms.Button();
            this.btnGrantforRole = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPriv)).BeginInit();
            this.SuspendLayout();
            // 
            // lblViewPrivilege
            // 
            this.lblViewPrivilege.AutoSize = true;
            this.lblViewPrivilege.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewPrivilege.Location = new System.Drawing.Point(239, 7);
            this.lblViewPrivilege.Name = "lblViewPrivilege";
            this.lblViewPrivilege.Size = new System.Drawing.Size(357, 46);
            this.lblViewPrivilege.TabIndex = 3;
            this.lblViewPrivilege.Text = "Thông tin về quyền";
            this.lblViewPrivilege.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Location = new System.Drawing.Point(763, 394);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 32);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Return";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnGrantforUser
            // 
            this.btnGrantforUser.Location = new System.Drawing.Point(630, 231);
            this.btnGrantforUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGrantforUser.Name = "btnGrantforUser";
            this.btnGrantforUser.Size = new System.Drawing.Size(209, 32);
            this.btnGrantforUser.TabIndex = 14;
            this.btnGrantforUser.Text = "Grant for User";
            this.btnGrantforUser.UseVisualStyleBackColor = true;
            this.btnGrantforUser.Click += new System.EventHandler(this.btnGrantforUser_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(535, 66);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(304, 32);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dataGridViewPriv
            // 
            this.dataGridViewPriv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPriv.Location = new System.Drawing.Point(12, 66);
            this.dataGridViewPriv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewPriv.Name = "dataGridViewPriv";
            this.dataGridViewPriv.RowHeadersWidth = 62;
            this.dataGridViewPriv.RowTemplate.Height = 28;
            this.dataGridViewPriv.Size = new System.Drawing.Size(503, 358);
            this.dataGridViewPriv.TabIndex = 17;
            // 
            // lblPriv
            // 
            this.lblPriv.AutoSize = true;
            this.lblPriv.Location = new System.Drawing.Point(535, 114);
            this.lblPriv.Name = "lblPriv";
            this.lblPriv.Size = new System.Drawing.Size(60, 16);
            this.lblPriv.TabIndex = 18;
            this.lblPriv.Text = "Privilege";
            // 
            // lblObject
            // 
            this.lblObject.AutoSize = true;
            this.lblObject.Location = new System.Drawing.Point(535, 149);
            this.lblObject.Name = "lblObject";
            this.lblObject.Size = new System.Drawing.Size(46, 16);
            this.lblObject.TabIndex = 19;
            this.lblObject.Text = "Object";
            // 
            // lblUserRole
            // 
            this.lblUserRole.AutoSize = true;
            this.lblUserRole.Location = new System.Drawing.Point(535, 177);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(69, 16);
            this.lblUserRole.TabIndex = 20;
            this.lblUserRole.Text = "User/Role";
            // 
            // textPriv
            // 
            this.textPriv.Location = new System.Drawing.Point(630, 109);
            this.textPriv.Name = "textPriv";
            this.textPriv.Size = new System.Drawing.Size(209, 22);
            this.textPriv.TabIndex = 21;
            // 
            // textUserRole
            // 
            this.textUserRole.Location = new System.Drawing.Point(630, 177);
            this.textUserRole.Name = "textUserRole";
            this.textUserRole.Size = new System.Drawing.Size(209, 22);
            this.textUserRole.TabIndex = 22;
            // 
            // textObject
            // 
            this.textObject.Location = new System.Drawing.Point(630, 144);
            this.textObject.Name = "textObject";
            this.textObject.Size = new System.Drawing.Size(209, 22);
            this.textObject.TabIndex = 23;
            // 
            // checkBoxGrantOption
            // 
            this.checkBoxGrantOption.AutoSize = true;
            this.checkBoxGrantOption.Location = new System.Drawing.Point(630, 205);
            this.checkBoxGrantOption.Name = "checkBoxGrantOption";
            this.checkBoxGrantOption.Size = new System.Drawing.Size(128, 20);
            this.checkBoxGrantOption.TabIndex = 24;
            this.checkBoxGrantOption.Text = "with Grant Option";
            this.checkBoxGrantOption.UseVisualStyleBackColor = true;
            // 
            // btnRevoke
            // 
            this.btnRevoke.Location = new System.Drawing.Point(630, 303);
            this.btnRevoke.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRevoke.Name = "btnRevoke";
            this.btnRevoke.Size = new System.Drawing.Size(209, 32);
            this.btnRevoke.TabIndex = 26;
            this.btnRevoke.Text = "Revoke from User/Role";
            this.btnRevoke.UseVisualStyleBackColor = true;
            this.btnRevoke.Click += new System.EventHandler(this.btnRevoke_Click);
            // 
            // btnGrantforRole
            // 
            this.btnGrantforRole.Location = new System.Drawing.Point(630, 267);
            this.btnGrantforRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGrantforRole.Name = "btnGrantforRole";
            this.btnGrantforRole.Size = new System.Drawing.Size(209, 32);
            this.btnGrantforRole.TabIndex = 27;
            this.btnGrantforRole.Text = "Grant for Role";
            this.btnGrantforRole.UseVisualStyleBackColor = true;
            this.btnGrantforRole.Click += new System.EventHandler(this.btnGrantforRole_Click);
            // 
            // ViewPrivilegeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(869, 435);
            this.Controls.Add(this.btnGrantforRole);
            this.Controls.Add(this.btnRevoke);
            this.Controls.Add(this.checkBoxGrantOption);
            this.Controls.Add(this.textObject);
            this.Controls.Add(this.textUserRole);
            this.Controls.Add(this.textPriv);
            this.Controls.Add(this.lblUserRole);
            this.Controls.Add(this.lblObject);
            this.Controls.Add(this.lblPriv);
            this.Controls.Add(this.dataGridViewPriv);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnGrantforUser);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblViewPrivilege);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ViewPrivilegeWindow";
            this.Text = "Xem thông tin về quyền";
            this.Load += new System.EventHandler(this.Priviledge_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPriv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblViewPrivilege;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnGrantforUser;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dataGridViewPriv;
        private System.Windows.Forms.Label lblPriv;
        private System.Windows.Forms.Label lblObject;
        private System.Windows.Forms.Label lblUserRole;
        private System.Windows.Forms.TextBox textPriv;
        private System.Windows.Forms.TextBox textUserRole;
        private System.Windows.Forms.TextBox textObject;
        private System.Windows.Forms.CheckBox checkBoxGrantOption;
        private System.Windows.Forms.Button btnRevoke;
        private System.Windows.Forms.Button btnGrantforRole;
    }
}