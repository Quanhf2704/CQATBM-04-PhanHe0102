﻿namespace Oracle_Database_Management_Application
{
    partial class AssignmentWindow
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
            this.txtCourseCode = new System.Windows.Forms.TextBox();
            this.lblCourseCode = new System.Windows.Forms.Label();
            this.txtTeacherCode = new System.Windows.Forms.TextBox();
            this.lblTeacherCode = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dataGridViewListAssignment = new System.Windows.Forms.DataGridView();
            this.lblModuleInfo = new System.Windows.Forms.Label();
            this.txtEducationProgram = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtSemester = new System.Windows.Forms.TextBox();
            this.lblEducationProgram = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblSemester = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListAssignment)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCourseCode
            // 
            this.txtCourseCode.Location = new System.Drawing.Point(657, 94);
            this.txtCourseCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCourseCode.Name = "txtCourseCode";
            this.txtCourseCode.Size = new System.Drawing.Size(191, 22);
            this.txtCourseCode.TabIndex = 68;
            // 
            // lblCourseCode
            // 
            this.lblCourseCode.AutoSize = true;
            this.lblCourseCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseCode.Location = new System.Drawing.Point(545, 94);
            this.lblCourseCode.Name = "lblCourseCode";
            this.lblCourseCode.Size = new System.Drawing.Size(94, 18);
            this.lblCourseCode.TabIndex = 62;
            this.lblCourseCode.Text = "Mã học phần";
            this.lblCourseCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTeacherCode
            // 
            this.txtTeacherCode.Location = new System.Drawing.Point(657, 61);
            this.txtTeacherCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTeacherCode.Name = "txtTeacherCode";
            this.txtTeacherCode.Size = new System.Drawing.Size(191, 22);
            this.txtTeacherCode.TabIndex = 61;
            // 
            // lblTeacherCode
            // 
            this.lblTeacherCode.AutoSize = true;
            this.lblTeacherCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacherCode.Location = new System.Drawing.Point(545, 61);
            this.lblTeacherCode.Name = "lblTeacherCode";
            this.lblTeacherCode.Size = new System.Drawing.Size(91, 18);
            this.lblTeacherCode.TabIndex = 60;
            this.lblTeacherCode.Text = "Mã giáo viên";
            this.lblTeacherCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(660, 394);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 32);
            this.btnUpdate.TabIndex = 58;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnBack
            // 
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Location = new System.Drawing.Point(763, 394);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 32);
            this.btnBack.TabIndex = 57;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dataGridViewListAssignment
            // 
            this.dataGridViewListAssignment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListAssignment.Location = new System.Drawing.Point(22, 54);
            this.dataGridViewListAssignment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewListAssignment.Name = "dataGridViewListAssignment";
            this.dataGridViewListAssignment.RowHeadersWidth = 62;
            this.dataGridViewListAssignment.RowTemplate.Height = 28;
            this.dataGridViewListAssignment.Size = new System.Drawing.Size(509, 338);
            this.dataGridViewListAssignment.TabIndex = 56;
            // 
            // lblModuleInfo
            // 
            this.lblModuleInfo.AutoSize = true;
            this.lblModuleInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModuleInfo.Location = new System.Drawing.Point(243, 7);
            this.lblModuleInfo.Name = "lblModuleInfo";
            this.lblModuleInfo.Size = new System.Drawing.Size(389, 46);
            this.lblModuleInfo.TabIndex = 55;
            this.lblModuleInfo.Text = "Thông tin Phân công";
            this.lblModuleInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEducationProgram
            // 
            this.txtEducationProgram.Location = new System.Drawing.Point(731, 198);
            this.txtEducationProgram.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEducationProgram.Name = "txtEducationProgram";
            this.txtEducationProgram.Size = new System.Drawing.Size(117, 22);
            this.txtEducationProgram.TabIndex = 74;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(657, 166);
            this.txtYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(191, 22);
            this.txtYear.TabIndex = 73;
            // 
            // txtSemester
            // 
            this.txtSemester.Location = new System.Drawing.Point(657, 131);
            this.txtSemester.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSemester.Name = "txtSemester";
            this.txtSemester.Size = new System.Drawing.Size(191, 22);
            this.txtSemester.TabIndex = 72;
            // 
            // lblEducationProgram
            // 
            this.lblEducationProgram.AutoSize = true;
            this.lblEducationProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEducationProgram.Location = new System.Drawing.Point(545, 198);
            this.lblEducationProgram.Name = "lblEducationProgram";
            this.lblEducationProgram.Size = new System.Drawing.Size(168, 18);
            this.lblEducationProgram.TabIndex = 71;
            this.lblEducationProgram.Text = "Mã chương trình đào tạo";
            this.lblEducationProgram.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(545, 166);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(40, 18);
            this.lblYear.TabIndex = 70;
            this.lblYear.Text = "Năm";
            this.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSemester
            // 
            this.lblSemester.AutoSize = true;
            this.lblSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemester.Location = new System.Drawing.Point(545, 131);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(51, 18);
            this.lblSemester.TabIndex = 69;
            this.lblSemester.Text = "Học kì";
            this.lblSemester.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(559, 394);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(96, 32);
            this.btnRefresh.TabIndex = 75;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // AssignmentWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(869, 435);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtEducationProgram);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtSemester);
            this.Controls.Add(this.lblEducationProgram);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblSemester);
            this.Controls.Add(this.txtCourseCode);
            this.Controls.Add(this.lblCourseCode);
            this.Controls.Add(this.txtTeacherCode);
            this.Controls.Add(this.lblTeacherCode);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridViewListAssignment);
            this.Controls.Add(this.lblModuleInfo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AssignmentWindow";
            this.Text = "Thông tin Phân công";
            this.Load += new System.EventHandler(this.AssignmentWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListAssignment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCourseCode;
        private System.Windows.Forms.Label lblCourseCode;
        private System.Windows.Forms.TextBox txtTeacherCode;
        private System.Windows.Forms.Label lblTeacherCode;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dataGridViewListAssignment;
        private System.Windows.Forms.Label lblModuleInfo;
        private System.Windows.Forms.TextBox txtEducationProgram;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtSemester;
        private System.Windows.Forms.Label lblEducationProgram;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblSemester;
        private System.Windows.Forms.Button btnRefresh;
    }
}