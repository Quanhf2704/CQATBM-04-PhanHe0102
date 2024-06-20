namespace Oracle_Database_Management_Application
{
    partial class TK_DSSV_Windows
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
            this.TK_DSSV_dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.quaylaiButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TK_DSSV_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TK_DSSV_dataGridView
            // 
            this.TK_DSSV_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TK_DSSV_dataGridView.Location = new System.Drawing.Point(12, 80);
            this.TK_DSSV_dataGridView.Name = "TK_DSSV_dataGridView";
            this.TK_DSSV_dataGridView.RowHeadersWidth = 62;
            this.TK_DSSV_dataGridView.RowTemplate.Height = 28;
            this.TK_DSSV_dataGridView.Size = new System.Drawing.Size(776, 307);
            this.TK_DSSV_dataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(202, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH SINH VIÊN";
            // 
            // quaylaiButton
            // 
            this.quaylaiButton.Location = new System.Drawing.Point(693, 393);
            this.quaylaiButton.Name = "quaylaiButton";
            this.quaylaiButton.Size = new System.Drawing.Size(95, 45);
            this.quaylaiButton.TabIndex = 2;
            this.quaylaiButton.Text = "Back";
            this.quaylaiButton.UseVisualStyleBackColor = true;
            this.quaylaiButton.Click += new System.EventHandler(this.quaylaiButton_Click);
            // 
            // TK_DSSV_Windows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.quaylaiButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TK_DSSV_dataGridView);
            this.Name = "TK_DSSV_Windows";
            this.Text = "Danh sách sinh viên";
            this.Load += new System.EventHandler(this.TK_DSSV_Windows_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TK_DSSV_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TK_DSSV_dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button quaylaiButton;
    }
}