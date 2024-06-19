namespace Oracle_Database_Management_Application
{
    partial class OpenPlanWindow
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
            this.dataGridViewListOpenPlan = new System.Windows.Forms.DataGridView();
            this.lblOpenPlanInfo = new System.Windows.Forms.Label();
            this.txtEducationProgram = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtSemester = new System.Windows.Forms.TextBox();
            this.lblEducationProgram = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblSemester = new System.Windows.Forms.Label();
            this.txtCourseCode = new System.Windows.Forms.TextBox();
            this.lblCourseCode = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListOpenPlan)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(630, 495);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 40);
            this.btnAdd.TabIndex = 32;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(744, 495);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(108, 40);
            this.btnUpdate.TabIndex = 31;
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
            this.btnBack.TabIndex = 30;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dataGridViewListOpenPlan
            // 
            this.dataGridViewListOpenPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListOpenPlan.Location = new System.Drawing.Point(36, 68);
            this.dataGridViewListOpenPlan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewListOpenPlan.Name = "dataGridViewListOpenPlan";
            this.dataGridViewListOpenPlan.RowHeadersWidth = 62;
            this.dataGridViewListOpenPlan.RowTemplate.Height = 28;
            this.dataGridViewListOpenPlan.Size = new System.Drawing.Size(573, 423);
            this.dataGridViewListOpenPlan.TabIndex = 29;
            // 
            // lblOpenPlanInfo
            // 
            this.lblOpenPlanInfo.AutoSize = true;
            this.lblOpenPlanInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpenPlanInfo.Location = new System.Drawing.Point(238, 9);
            this.lblOpenPlanInfo.Name = "lblOpenPlanInfo";
            this.lblOpenPlanInfo.Size = new System.Drawing.Size(521, 55);
            this.lblOpenPlanInfo.TabIndex = 28;
            this.lblOpenPlanInfo.Text = "Thông tin Kế hoạch mở";
            this.lblOpenPlanInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEducationProgram
            // 
            this.txtEducationProgram.Location = new System.Drawing.Point(835, 204);
            this.txtEducationProgram.Name = "txtEducationProgram";
            this.txtEducationProgram.Size = new System.Drawing.Size(131, 26);
            this.txtEducationProgram.TabIndex = 59;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(752, 164);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(214, 26);
            this.txtYear.TabIndex = 58;
            // 
            // txtSemester
            // 
            this.txtSemester.Location = new System.Drawing.Point(752, 124);
            this.txtSemester.Name = "txtSemester";
            this.txtSemester.Size = new System.Drawing.Size(214, 26);
            this.txtSemester.TabIndex = 57;
            // 
            // lblEducationProgram
            // 
            this.lblEducationProgram.AutoSize = true;
            this.lblEducationProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEducationProgram.Location = new System.Drawing.Point(626, 204);
            this.lblEducationProgram.Name = "lblEducationProgram";
            this.lblEducationProgram.Size = new System.Drawing.Size(203, 22);
            this.lblEducationProgram.TabIndex = 56;
            this.lblEducationProgram.Text = "Mã chương trình đào tạo";
            this.lblEducationProgram.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(626, 164);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(47, 22);
            this.lblYear.TabIndex = 55;
            this.lblYear.Text = "Năm";
            this.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSemester
            // 
            this.lblSemester.AutoSize = true;
            this.lblSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemester.Location = new System.Drawing.Point(626, 124);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(60, 22);
            this.lblSemester.TabIndex = 54;
            this.lblSemester.Text = "Học kì";
            this.lblSemester.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCourseCode
            // 
            this.txtCourseCode.Location = new System.Drawing.Point(752, 82);
            this.txtCourseCode.Name = "txtCourseCode";
            this.txtCourseCode.Size = new System.Drawing.Size(214, 26);
            this.txtCourseCode.TabIndex = 53;
            // 
            // lblCourseCode
            // 
            this.lblCourseCode.AutoSize = true;
            this.lblCourseCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseCode.Location = new System.Drawing.Point(626, 82);
            this.lblCourseCode.Name = "lblCourseCode";
            this.lblCourseCode.Size = new System.Drawing.Size(113, 22);
            this.lblCourseCode.TabIndex = 52;
            this.lblCourseCode.Text = "Mã học phần";
            this.lblCourseCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(516, 495);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(108, 40);
            this.btnRefresh.TabIndex = 60;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // OpenPlanWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 544);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtEducationProgram);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtSemester);
            this.Controls.Add(this.lblEducationProgram);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblSemester);
            this.Controls.Add(this.txtCourseCode);
            this.Controls.Add(this.lblCourseCode);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridViewListOpenPlan);
            this.Controls.Add(this.lblOpenPlanInfo);
            this.Name = "OpenPlanWindow";
            this.Text = "Thông tin Kế hoạch mở";
            this.Load += new System.EventHandler(this.OpenPlanWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListOpenPlan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dataGridViewListOpenPlan;
        private System.Windows.Forms.Label lblOpenPlanInfo;
        private System.Windows.Forms.TextBox txtEducationProgram;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtSemester;
        private System.Windows.Forms.Label lblEducationProgram;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblSemester;
        private System.Windows.Forms.TextBox txtCourseCode;
        private System.Windows.Forms.Label lblCourseCode;
        private System.Windows.Forms.Button btnRefresh;
    }
}