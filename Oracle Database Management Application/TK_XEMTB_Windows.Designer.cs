namespace Oracle_Database_Management_Application
{
    partial class TK_XEMTB_Windows
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
            this.quaylaiButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TK_THONGBAO_dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TK_THONGBAO_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // quaylaiButton
            // 
            this.quaylaiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quaylaiButton.Location = new System.Drawing.Point(726, 405);
            this.quaylaiButton.Margin = new System.Windows.Forms.Padding(2);
            this.quaylaiButton.Name = "quaylaiButton";
            this.quaylaiButton.Size = new System.Drawing.Size(63, 29);
            this.quaylaiButton.TabIndex = 11;
            this.quaylaiButton.Text = "Back";
            this.quaylaiButton.UseVisualStyleBackColor = true;
            this.quaylaiButton.Click += new System.EventHandler(this.quaylaiButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(319, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "THÔNG BÁO";
            // 
            // TK_THONGBAO_dataGridView
            // 
            this.TK_THONGBAO_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TK_THONGBAO_dataGridView.Location = new System.Drawing.Point(11, 59);
            this.TK_THONGBAO_dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.TK_THONGBAO_dataGridView.Name = "TK_THONGBAO_dataGridView";
            this.TK_THONGBAO_dataGridView.RowHeadersWidth = 62;
            this.TK_THONGBAO_dataGridView.RowTemplate.Height = 28;
            this.TK_THONGBAO_dataGridView.Size = new System.Drawing.Size(778, 342);
            this.TK_THONGBAO_dataGridView.TabIndex = 9;
            // 
            // TK_XEMTB_Windows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.quaylaiButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TK_THONGBAO_dataGridView);
            this.Name = "TK_XEMTB_Windows";
            this.Text = "Trưởng khoa xem thông báo";
            this.Load += new System.EventHandler(this.TK_XEMTB_Windows_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TK_THONGBAO_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button quaylaiButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView TK_THONGBAO_dataGridView;
    }
}