namespace Oracle_Database_Management_Application
{
    partial class StudentWindow
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
            this.lblStudentInfo = new System.Windows.Forms.Label();
            this.dataGridViewListStudent = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblStudentCode = new System.Windows.Forms.Label();
            this.txtStudentCode = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblEducationProgram = new System.Windows.Forms.Label();
            this.lblFieldCode = new System.Windows.Forms.Label();
            this.lblNumOfCredits = new System.Windows.Forms.Label();
            this.lblGPA = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.txtBirthday = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtEducationProgram = new System.Windows.Forms.TextBox();
            this.txtFieldCode = new System.Windows.Forms.TextBox();
            this.txtNumOfCredits = new System.Windows.Forms.TextBox();
            this.txtGPA = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStudentInfo
            // 
            this.lblStudentInfo.AutoSize = true;
            this.lblStudentInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentInfo.Location = new System.Drawing.Point(281, 9);
            this.lblStudentInfo.Name = "lblStudentInfo";
            this.lblStudentInfo.Size = new System.Drawing.Size(434, 55);
            this.lblStudentInfo.TabIndex = 3;
            this.lblStudentInfo.Text = "Thông tin Sinh viên";
            this.lblStudentInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewListStudent
            // 
            this.dataGridViewListStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListStudent.Location = new System.Drawing.Point(37, 66);
            this.dataGridViewListStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewListStudent.Name = "dataGridViewListStudent";
            this.dataGridViewListStudent.RowHeadersWidth = 62;
            this.dataGridViewListStudent.RowTemplate.Height = 28;
            this.dataGridViewListStudent.Size = new System.Drawing.Size(578, 413);
            this.dataGridViewListStudent.TabIndex = 14;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(858, 493);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(108, 40);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(744, 493);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(108, 40);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(630, 493);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 40);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblStudentCode
            // 
            this.lblStudentCode.AutoSize = true;
            this.lblStudentCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentCode.Location = new System.Drawing.Point(626, 87);
            this.lblStudentCode.Name = "lblStudentCode";
            this.lblStudentCode.Size = new System.Drawing.Size(110, 22);
            this.lblStudentCode.TabIndex = 18;
            this.lblStudentCode.Text = "Mã sinh viên";
            this.lblStudentCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtStudentCode
            // 
            this.txtStudentCode.Location = new System.Drawing.Point(752, 87);
            this.txtStudentCode.Name = "txtStudentCode";
            this.txtStudentCode.Size = new System.Drawing.Size(214, 26);
            this.txtStudentCode.TabIndex = 19;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(626, 129);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(63, 22);
            this.lblName.TabIndex = 20;
            this.lblName.Text = "Họ tên";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSex.Location = new System.Drawing.Point(626, 169);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(46, 22);
            this.lblSex.TabIndex = 21;
            this.lblSex.Text = "Phái";
            this.lblSex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthday.Location = new System.Drawing.Point(626, 209);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(90, 22);
            this.lblBirthday.TabIndex = 22;
            this.lblBirthday.Text = "Ngày sinh";
            this.lblBirthday.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(626, 251);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(65, 22);
            this.lblAddress.TabIndex = 23;
            this.lblAddress.Text = "Địa chỉ";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(626, 291);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(91, 22);
            this.lblPhoneNumber.TabIndex = 24;
            this.lblPhoneNumber.Text = "Điện thoại";
            this.lblPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEducationProgram
            // 
            this.lblEducationProgram.AutoSize = true;
            this.lblEducationProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEducationProgram.Location = new System.Drawing.Point(626, 332);
            this.lblEducationProgram.Name = "lblEducationProgram";
            this.lblEducationProgram.Size = new System.Drawing.Size(178, 22);
            this.lblEducationProgram.TabIndex = 25;
            this.lblEducationProgram.Text = "Chương trình đào tạo";
            this.lblEducationProgram.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFieldCode
            // 
            this.lblFieldCode.AutoSize = true;
            this.lblFieldCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFieldCode.Location = new System.Drawing.Point(626, 374);
            this.lblFieldCode.Name = "lblFieldCode";
            this.lblFieldCode.Size = new System.Drawing.Size(89, 22);
            this.lblFieldCode.TabIndex = 26;
            this.lblFieldCode.Text = "Mã ngành";
            this.lblFieldCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNumOfCredits
            // 
            this.lblNumOfCredits.AutoSize = true;
            this.lblNumOfCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfCredits.Location = new System.Drawing.Point(626, 417);
            this.lblNumOfCredits.Name = "lblNumOfCredits";
            this.lblNumOfCredits.Size = new System.Drawing.Size(145, 22);
            this.lblNumOfCredits.TabIndex = 27;
            this.lblNumOfCredits.Text = "Số tín chỉ tích lũy";
            this.lblNumOfCredits.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGPA
            // 
            this.lblGPA.AutoSize = true;
            this.lblGPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPA.Location = new System.Drawing.Point(626, 457);
            this.lblGPA.Name = "lblGPA";
            this.lblGPA.Size = new System.Drawing.Size(197, 22);
            this.lblGPA.TabIndex = 28;
            this.lblGPA.Text = "Điểm trung bình tích lũy";
            this.lblGPA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(752, 129);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(214, 26);
            this.txtName.TabIndex = 29;
            // 
            // txtSex
            // 
            this.txtSex.Location = new System.Drawing.Point(752, 169);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(214, 26);
            this.txtSex.TabIndex = 30;
            // 
            // txtBirthday
            // 
            this.txtBirthday.Location = new System.Drawing.Point(752, 209);
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.Size = new System.Drawing.Size(214, 26);
            this.txtBirthday.TabIndex = 31;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(752, 251);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(214, 26);
            this.txtAddress.TabIndex = 32;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(752, 291);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(214, 26);
            this.txtPhoneNumber.TabIndex = 33;
            // 
            // txtEducationProgram
            // 
            this.txtEducationProgram.Location = new System.Drawing.Point(810, 332);
            this.txtEducationProgram.Name = "txtEducationProgram";
            this.txtEducationProgram.Size = new System.Drawing.Size(156, 26);
            this.txtEducationProgram.TabIndex = 34;
            // 
            // txtFieldCode
            // 
            this.txtFieldCode.Location = new System.Drawing.Point(752, 374);
            this.txtFieldCode.Name = "txtFieldCode";
            this.txtFieldCode.Size = new System.Drawing.Size(214, 26);
            this.txtFieldCode.TabIndex = 35;
            // 
            // txtNumOfCredits
            // 
            this.txtNumOfCredits.Location = new System.Drawing.Point(810, 417);
            this.txtNumOfCredits.Name = "txtNumOfCredits";
            this.txtNumOfCredits.Size = new System.Drawing.Size(156, 26);
            this.txtNumOfCredits.TabIndex = 36;
            // 
            // txtGPA
            // 
            this.txtGPA.Location = new System.Drawing.Point(844, 457);
            this.txtGPA.Name = "txtGPA";
            this.txtGPA.Size = new System.Drawing.Size(122, 26);
            this.txtGPA.TabIndex = 37;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(516, 493);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(108, 40);
            this.btnRefresh.TabIndex = 38;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // StudentWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 544);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtGPA);
            this.Controls.Add(this.txtNumOfCredits);
            this.Controls.Add(this.txtFieldCode);
            this.Controls.Add(this.txtEducationProgram);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtBirthday);
            this.Controls.Add(this.txtSex);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblGPA);
            this.Controls.Add(this.lblNumOfCredits);
            this.Controls.Add(this.lblFieldCode);
            this.Controls.Add(this.lblEducationProgram);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtStudentCode);
            this.Controls.Add(this.lblStudentCode);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridViewListStudent);
            this.Controls.Add(this.lblStudentInfo);
            this.Name = "StudentWindow";
            this.Text = "Thông tin Sinh viên";
            this.Load += new System.EventHandler(this.StudentWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentInfo;
        private System.Windows.Forms.DataGridView dataGridViewListStudent;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblStudentCode;
        private System.Windows.Forms.TextBox txtStudentCode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblEducationProgram;
        private System.Windows.Forms.Label lblFieldCode;
        private System.Windows.Forms.Label lblNumOfCredits;
        private System.Windows.Forms.Label lblGPA;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.TextBox txtBirthday;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtEducationProgram;
        private System.Windows.Forms.TextBox txtFieldCode;
        private System.Windows.Forms.TextBox txtNumOfCredits;
        private System.Windows.Forms.TextBox txtGPA;
        private System.Windows.Forms.Button btnRefresh;
    }
}