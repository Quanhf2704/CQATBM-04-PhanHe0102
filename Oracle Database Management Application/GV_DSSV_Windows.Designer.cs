namespace Oracle_Database_Management_Application
{
    partial class GV_DSSV_Windows
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
            this.TK_DSSV_dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TK_DSSV_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // quaylaiButton
            // 
            this.quaylaiButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.quaylaiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quaylaiButton.Location = new System.Drawing.Point(968, 498);
            this.quaylaiButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.quaylaiButton.Name = "quaylaiButton";
            this.quaylaiButton.Size = new System.Drawing.Size(84, 36);
            this.quaylaiButton.TabIndex = 8;
            this.quaylaiButton.Text = "Back";
            this.quaylaiButton.UseVisualStyleBackColor = true;
            this.quaylaiButton.Click += new System.EventHandler(this.quaylaiButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(352, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "DANH SÁCH SINH VIÊN";
            // 
            // TK_DSSV_dataGridView
            // 
            this.TK_DSSV_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TK_DSSV_dataGridView.Location = new System.Drawing.Point(15, 73);
            this.TK_DSSV_dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TK_DSSV_dataGridView.Name = "TK_DSSV_dataGridView";
            this.TK_DSSV_dataGridView.RowHeadersWidth = 62;
            this.TK_DSSV_dataGridView.RowTemplate.Height = 28;
            this.TK_DSSV_dataGridView.Size = new System.Drawing.Size(1037, 421);
            this.TK_DSSV_dataGridView.TabIndex = 6;
            // 
            // GV_DSSV_Windows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.quaylaiButton;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.quaylaiButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TK_DSSV_dataGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GV_DSSV_Windows";
            this.Text = "GV_DSSV_Windows";
            this.Load += new System.EventHandler(this.GV_DSSV_Windows_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TK_DSSV_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button quaylaiButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView TK_DSSV_dataGridView;
    }
}