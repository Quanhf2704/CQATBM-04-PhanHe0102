
namespace Oracle_Database_Management_Application
{
    partial class SV_DanhSachHocPhan_Windows
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblDanhSachHocPhan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(60, 74);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(531, 242);
            this.dataGridView.TabIndex = 15;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(570, 331);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(72, 26);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Return";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblDanhSachHocPhan
            // 
            this.lblDanhSachHocPhan.AutoSize = true;
            this.lblDanhSachHocPhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhSachHocPhan.Location = new System.Drawing.Point(166, 22);
            this.lblDanhSachHocPhan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDanhSachHocPhan.Name = "lblDanhSachHocPhan";
            this.lblDanhSachHocPhan.Size = new System.Drawing.Size(326, 37);
            this.lblDanhSachHocPhan.TabIndex = 18;
            this.lblDanhSachHocPhan.Text = "Danh Sách Học Phần";
            this.lblDanhSachHocPhan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SV_DanhSachHocPhan_Windows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 366);
            this.Controls.Add(this.lblDanhSachHocPhan);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridView);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SV_DanhSachHocPhan_Windows";
            this.Text = "Danh Sách Học Phần";
            this.Load += new System.EventHandler(this.DachSachHocPhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblDanhSachHocPhan;
    }
}