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
            this.TK_DSSV_dataGridView.Location = new System.Drawing.Point(11, 64);
            this.TK_DSSV_dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TK_DSSV_dataGridView.Name = "TK_DSSV_dataGridView";
            this.TK_DSSV_dataGridView.RowHeadersWidth = 62;
            this.TK_DSSV_dataGridView.RowTemplate.Height = 28;
            this.TK_DSSV_dataGridView.Size = new System.Drawing.Size(690, 246);
            this.TK_DSSV_dataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(180, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH SINH VIÊN";
            // 
            // quaylaiButton
            // 
            this.quaylaiButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.quaylaiButton.Location = new System.Drawing.Point(616, 314);
            this.quaylaiButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.quaylaiButton.Name = "quaylaiButton";
            this.quaylaiButton.Size = new System.Drawing.Size(84, 36);
            this.quaylaiButton.TabIndex = 2;
            this.quaylaiButton.Text = "Back";
            this.quaylaiButton.UseVisualStyleBackColor = true;
            this.quaylaiButton.Click += new System.EventHandler(this.quaylaiButton_Click);
            // 
            // TK_DSSV_Windows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.quaylaiButton;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.quaylaiButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TK_DSSV_dataGridView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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