namespace Oracle_Database_Management_Application
{
    partial class TK_DSHP_Windows
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
            this.TK_DSHP_dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.quaylaiButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TK_DSHP_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TK_DSHP_dataGridView
            // 
            this.TK_DSHP_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TK_DSHP_dataGridView.Location = new System.Drawing.Point(11, 69);
            this.TK_DSHP_dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TK_DSHP_dataGridView.Name = "TK_DSHP_dataGridView";
            this.TK_DSHP_dataGridView.RowHeadersWidth = 62;
            this.TK_DSHP_dataGridView.RowTemplate.Height = 28;
            this.TK_DSHP_dataGridView.Size = new System.Drawing.Size(690, 242);
            this.TK_DSHP_dataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(194, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH HỌC PHẦN";
            // 
            // quaylaiButton
            // 
            this.quaylaiButton.Location = new System.Drawing.Point(609, 316);
            this.quaylaiButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.quaylaiButton.Name = "quaylaiButton";
            this.quaylaiButton.Size = new System.Drawing.Size(92, 34);
            this.quaylaiButton.TabIndex = 2;
            this.quaylaiButton.Text = "Back";
            this.quaylaiButton.UseVisualStyleBackColor = true;
            this.quaylaiButton.Click += new System.EventHandler(this.quaylaiButton_Click);
            // 
            // TK_DSHP_Windows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.quaylaiButton;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.quaylaiButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TK_DSHP_dataGridView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TK_DSHP_Windows";
            this.Text = "Danh sách học phần";
            this.Load += new System.EventHandler(this.TK_DSHP_Windows_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TK_DSHP_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TK_DSHP_dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button quaylaiButton;
    }
}