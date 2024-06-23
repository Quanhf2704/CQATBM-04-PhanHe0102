namespace Oracle_Database_Management_Application
{
    partial class GV_KHMO_Windows
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
            this.TK_KHM_dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TK_KHM_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TK_KHM_dataGridView
            // 
            this.TK_KHM_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TK_KHM_dataGridView.Location = new System.Drawing.Point(15, 81);
            this.TK_KHM_dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TK_KHM_dataGridView.Name = "TK_KHM_dataGridView";
            this.TK_KHM_dataGridView.RowHeadersWidth = 62;
            this.TK_KHM_dataGridView.RowTemplate.Height = 28;
            this.TK_KHM_dataGridView.Size = new System.Drawing.Size(1037, 411);
            this.TK_KHM_dataGridView.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(397, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "KẾ HOẠCH MỞ";
            // 
            // backButton
            // 
            this.backButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(964, 497);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(88, 34);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // GV_KHMO_Windows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.backButton;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.TK_KHM_dataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GV_KHMO_Windows";
            this.Text = "Kế hoạch mở";
            this.Load += new System.EventHandler(this.GV_KHMO_Windows_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TK_KHM_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TK_KHM_dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backButton;
    }
}