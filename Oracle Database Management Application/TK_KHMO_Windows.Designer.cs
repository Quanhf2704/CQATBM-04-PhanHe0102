﻿namespace Oracle_Database_Management_Application
{
    partial class TK_KHMO_Windows
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
            this.backButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TK_KHM_dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TK_KHM_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(698, 398);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(90, 40);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "KẾ HOẠCH MỞ";
            // 
            // TK_KHM_dataGridView
            // 
            this.TK_KHM_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TK_KHM_dataGridView.Location = new System.Drawing.Point(12, 91);
            this.TK_KHM_dataGridView.Name = "TK_KHM_dataGridView";
            this.TK_KHM_dataGridView.RowHeadersWidth = 62;
            this.TK_KHM_dataGridView.RowTemplate.Height = 28;
            this.TK_KHM_dataGridView.Size = new System.Drawing.Size(776, 301);
            this.TK_KHM_dataGridView.TabIndex = 2;
            // 
            // TK_KHMO_Windows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TK_KHM_dataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backButton);
            this.Name = "TK_KHMO_Windows";
            this.Text = "Kế hoạch mở";
            this.Load += new System.EventHandler(this.TK_KHMO_Windows_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TK_KHM_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView TK_KHM_dataGridView;
    }
}