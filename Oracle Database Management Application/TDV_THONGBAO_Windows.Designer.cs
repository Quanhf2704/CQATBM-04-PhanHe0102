namespace Oracle_Database_Management_Application
{
    partial class TDV_THONGBAO_Windows
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
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_thongbao = new System.Windows.Forms.Label();
            this.TDV_THONGBAO_dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TDV_THONGBAO_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(617, 316);
            this.btn_back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(84, 36);
            this.btn_back.TabIndex = 5;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lbl_thongbao
            // 
            this.lbl_thongbao.AutoSize = true;
            this.lbl_thongbao.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbl_thongbao.Location = new System.Drawing.Point(237, 21);
            this.lbl_thongbao.Name = "lbl_thongbao";
            this.lbl_thongbao.Size = new System.Drawing.Size(261, 31);
            this.lbl_thongbao.TabIndex = 4;
            this.lbl_thongbao.Text = "BẢNG THÔNG BÁO\r\n";
            // 
            // TDV_THONGBAO_dataGridView
            // 
            this.TDV_THONGBAO_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TDV_THONGBAO_dataGridView.Location = new System.Drawing.Point(12, 66);
            this.TDV_THONGBAO_dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TDV_THONGBAO_dataGridView.Name = "TDV_THONGBAO_dataGridView";
            this.TDV_THONGBAO_dataGridView.ReadOnly = true;
            this.TDV_THONGBAO_dataGridView.RowHeadersWidth = 62;
            this.TDV_THONGBAO_dataGridView.RowTemplate.Height = 28;
            this.TDV_THONGBAO_dataGridView.Size = new System.Drawing.Size(690, 246);
            this.TDV_THONGBAO_dataGridView.TabIndex = 3;
            // 
            // TDV_THONGBAO_Windows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 357);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lbl_thongbao);
            this.Controls.Add(this.TDV_THONGBAO_dataGridView);
            this.Name = "TDV_THONGBAO_Windows";
            this.Text = "Thông báo";
            this.Load += new System.EventHandler(this.TDV_THONGBAO_Windows_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TDV_THONGBAO_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_thongbao;
        private System.Windows.Forms.DataGridView TDV_THONGBAO_dataGridView;
    }
}