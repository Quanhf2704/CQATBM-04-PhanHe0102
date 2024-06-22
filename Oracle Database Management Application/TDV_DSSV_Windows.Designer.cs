namespace Oracle_Database_Management_Application
{
    partial class TDV_DSSV_Windows
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
            this.TDV_DSSV_dataGridView = new System.Windows.Forms.DataGridView();
            this.lbl_dssv = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TDV_DSSV_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TDV_DSSV_dataGridView
            // 
            this.TDV_DSSV_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TDV_DSSV_dataGridView.Location = new System.Drawing.Point(11, 64);
            this.TDV_DSSV_dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TDV_DSSV_dataGridView.Name = "TDV_DSSV_dataGridView";
            this.TDV_DSSV_dataGridView.RowHeadersWidth = 62;
            this.TDV_DSSV_dataGridView.RowTemplate.Height = 28;
            this.TDV_DSSV_dataGridView.Size = new System.Drawing.Size(690, 246);
            this.TDV_DSSV_dataGridView.TabIndex = 0;
            // 
            // lbl_dssv
            // 
            this.lbl_dssv.AutoSize = true;
            this.lbl_dssv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbl_dssv.Location = new System.Drawing.Point(198, 18);
            this.lbl_dssv.Name = "lbl_dssv";
            this.lbl_dssv.Size = new System.Drawing.Size(319, 31);
            this.lbl_dssv.TabIndex = 1;
            this.lbl_dssv.Text = "DANH SÁCH SINH VIÊN";
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(616, 314);
            this.btn_back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(84, 36);
            this.btn_back.TabIndex = 2;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.quaylaiButton_Click);
            // 
            // TDV_DSSV_Windows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lbl_dssv);
            this.Controls.Add(this.TDV_DSSV_dataGridView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TDV_DSSV_Windows";
            this.Text = "Danh sách sinh viên";
            this.Load += new System.EventHandler(this.TK_DSSV_Windows_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TDV_DSSV_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TDV_DSSV_dataGridView;
        private System.Windows.Forms.Label lbl_dssv;
        private System.Windows.Forms.Button btn_back;
    }
}