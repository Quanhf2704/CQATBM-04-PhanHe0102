﻿namespace Oracle_Database_Management_Application
{
    partial class ModuleWindow
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dataGridViewListModule = new System.Windows.Forms.DataGridView();
            this.lblModuleInfo = new System.Windows.Forms.Label();
            this.txtUnitCode = new System.Windows.Forms.TextBox();
            this.txtMaxNumOfStudents = new System.Windows.Forms.TextBox();
            this.txtNumOfPracticeClasses = new System.Windows.Forms.TextBox();
            this.txtNumOfTheoryClasses = new System.Windows.Forms.TextBox();
            this.txtNumOfCredits = new System.Windows.Forms.TextBox();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.lblUnitCode = new System.Windows.Forms.Label();
            this.lblMaxNumOfStudents = new System.Windows.Forms.Label();
            this.lblNumOfPracticeClasses = new System.Windows.Forms.Label();
            this.lblNumOfTheoryClasses = new System.Windows.Forms.Label();
            this.lblCredits = new System.Windows.Forms.Label();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.txtCourseCode = new System.Windows.Forms.TextBox();
            this.lblCourseCode = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListModule)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(629, 495);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 40);
            this.btnAdd.TabIndex = 27;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(743, 495);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(108, 40);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(858, 495);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(108, 40);
            this.btnBack.TabIndex = 25;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dataGridViewListModule
            // 
            this.dataGridViewListModule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListModule.Location = new System.Drawing.Point(38, 68);
            this.dataGridViewListModule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewListModule.Name = "dataGridViewListModule";
            this.dataGridViewListModule.RowHeadersWidth = 62;
            this.dataGridViewListModule.RowTemplate.Height = 28;
            this.dataGridViewListModule.Size = new System.Drawing.Size(573, 421);
            this.dataGridViewListModule.TabIndex = 24;
            // 
            // lblModuleInfo
            // 
            this.lblModuleInfo.AutoSize = true;
            this.lblModuleInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModuleInfo.Location = new System.Drawing.Point(286, 9);
            this.lblModuleInfo.Name = "lblModuleInfo";
            this.lblModuleInfo.Size = new System.Drawing.Size(444, 55);
            this.lblModuleInfo.TabIndex = 23;
            this.lblModuleInfo.Text = "Thông tin Học phần";
            this.lblModuleInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUnitCode
            // 
            this.txtUnitCode.Location = new System.Drawing.Point(795, 321);
            this.txtUnitCode.Name = "txtUnitCode";
            this.txtUnitCode.Size = new System.Drawing.Size(171, 26);
            this.txtUnitCode.TabIndex = 54;
            // 
            // txtMaxNumOfStudents
            // 
            this.txtMaxNumOfStudents.Location = new System.Drawing.Point(795, 280);
            this.txtMaxNumOfStudents.Name = "txtMaxNumOfStudents";
            this.txtMaxNumOfStudents.Size = new System.Drawing.Size(171, 26);
            this.txtMaxNumOfStudents.TabIndex = 53;
            // 
            // txtNumOfPracticeClasses
            // 
            this.txtNumOfPracticeClasses.Location = new System.Drawing.Point(795, 240);
            this.txtNumOfPracticeClasses.Name = "txtNumOfPracticeClasses";
            this.txtNumOfPracticeClasses.Size = new System.Drawing.Size(171, 26);
            this.txtNumOfPracticeClasses.TabIndex = 52;
            // 
            // txtNumOfTheoryClasses
            // 
            this.txtNumOfTheoryClasses.Location = new System.Drawing.Point(795, 198);
            this.txtNumOfTheoryClasses.Name = "txtNumOfTheoryClasses";
            this.txtNumOfTheoryClasses.Size = new System.Drawing.Size(171, 26);
            this.txtNumOfTheoryClasses.TabIndex = 51;
            // 
            // txtNumOfCredits
            // 
            this.txtNumOfCredits.Location = new System.Drawing.Point(752, 158);
            this.txtNumOfCredits.Name = "txtNumOfCredits";
            this.txtNumOfCredits.Size = new System.Drawing.Size(214, 26);
            this.txtNumOfCredits.TabIndex = 50;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(752, 118);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(214, 26);
            this.txtCourseName.TabIndex = 49;
            // 
            // lblUnitCode
            // 
            this.lblUnitCode.AutoSize = true;
            this.lblUnitCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitCode.Location = new System.Drawing.Point(626, 321);
            this.lblUnitCode.Name = "lblUnitCode";
            this.lblUnitCode.Size = new System.Drawing.Size(87, 22);
            this.lblUnitCode.TabIndex = 45;
            this.lblUnitCode.Text = "Mã đơn vị";
            this.lblUnitCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMaxNumOfStudents
            // 
            this.lblMaxNumOfStudents.AutoSize = true;
            this.lblMaxNumOfStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxNumOfStudents.Location = new System.Drawing.Point(626, 280);
            this.lblMaxNumOfStudents.Name = "lblMaxNumOfStudents";
            this.lblMaxNumOfStudents.Size = new System.Drawing.Size(157, 22);
            this.lblMaxNumOfStudents.TabIndex = 44;
            this.lblMaxNumOfStudents.Text = "Số sinh viên tối đa";
            this.lblMaxNumOfStudents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNumOfPracticeClasses
            // 
            this.lblNumOfPracticeClasses.AutoSize = true;
            this.lblNumOfPracticeClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfPracticeClasses.Location = new System.Drawing.Point(626, 240);
            this.lblNumOfPracticeClasses.Name = "lblNumOfPracticeClasses";
            this.lblNumOfPracticeClasses.Size = new System.Drawing.Size(145, 22);
            this.lblNumOfPracticeClasses.TabIndex = 43;
            this.lblNumOfPracticeClasses.Text = "Số tiết thực hành";
            this.lblNumOfPracticeClasses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNumOfTheoryClasses
            // 
            this.lblNumOfTheoryClasses.AutoSize = true;
            this.lblNumOfTheoryClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfTheoryClasses.Location = new System.Drawing.Point(626, 198);
            this.lblNumOfTheoryClasses.Name = "lblNumOfTheoryClasses";
            this.lblNumOfTheoryClasses.Size = new System.Drawing.Size(133, 22);
            this.lblNumOfTheoryClasses.TabIndex = 42;
            this.lblNumOfTheoryClasses.Text = "Số tiết lý thuyết";
            this.lblNumOfTheoryClasses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredits.Location = new System.Drawing.Point(626, 158);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(84, 22);
            this.lblCredits.TabIndex = 41;
            this.lblCredits.Text = "Số tín chỉ";
            this.lblCredits.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseName.Location = new System.Drawing.Point(626, 118);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(121, 22);
            this.lblCourseName.TabIndex = 40;
            this.lblCourseName.Text = "Tên học phần";
            this.lblCourseName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCourseCode
            // 
            this.txtCourseCode.Location = new System.Drawing.Point(752, 76);
            this.txtCourseCode.Name = "txtCourseCode";
            this.txtCourseCode.Size = new System.Drawing.Size(214, 26);
            this.txtCourseCode.TabIndex = 39;
            // 
            // lblCourseCode
            // 
            this.lblCourseCode.AutoSize = true;
            this.lblCourseCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseCode.Location = new System.Drawing.Point(626, 76);
            this.lblCourseCode.Name = "lblCourseCode";
            this.lblCourseCode.Size = new System.Drawing.Size(113, 22);
            this.lblCourseCode.TabIndex = 38;
            this.lblCourseCode.Text = "Mã học phần";
            this.lblCourseCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(516, 493);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(107, 40);
            this.btnRefresh.TabIndex = 55;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ModuleWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 544);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtUnitCode);
            this.Controls.Add(this.txtMaxNumOfStudents);
            this.Controls.Add(this.txtNumOfPracticeClasses);
            this.Controls.Add(this.txtNumOfTheoryClasses);
            this.Controls.Add(this.txtNumOfCredits);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.lblUnitCode);
            this.Controls.Add(this.lblMaxNumOfStudents);
            this.Controls.Add(this.lblNumOfPracticeClasses);
            this.Controls.Add(this.lblNumOfTheoryClasses);
            this.Controls.Add(this.lblCredits);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.txtCourseCode);
            this.Controls.Add(this.lblCourseCode);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridViewListModule);
            this.Controls.Add(this.lblModuleInfo);
            this.Name = "ModuleWindow";
            this.Text = "Thông tin Học phần";
            this.Load += new System.EventHandler(this.ModuleWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListModule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dataGridViewListModule;
        private System.Windows.Forms.Label lblModuleInfo;
        private System.Windows.Forms.TextBox txtUnitCode;
        private System.Windows.Forms.TextBox txtMaxNumOfStudents;
        private System.Windows.Forms.TextBox txtNumOfPracticeClasses;
        private System.Windows.Forms.TextBox txtNumOfTheoryClasses;
        private System.Windows.Forms.TextBox txtNumOfCredits;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.Label lblUnitCode;
        private System.Windows.Forms.Label lblMaxNumOfStudents;
        private System.Windows.Forms.Label lblNumOfPracticeClasses;
        private System.Windows.Forms.Label lblNumOfTheoryClasses;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.TextBox txtCourseCode;
        private System.Windows.Forms.Label lblCourseCode;
        private System.Windows.Forms.Button btnRefresh;
    }
}