﻿namespace Oracle_Database_Management_Application
{
    partial class TK_DK_Windows
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
            this.label1 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.TK_DK_dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TK_DK_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(125, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ ĐĂNG KÝ HỌC PHẦN";
            // 
            // backButton
            // 
            this.backButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.backButton.Location = new System.Drawing.Point(618, 318);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(83, 32);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // TK_DK_dataGridView
            // 
            this.TK_DK_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TK_DK_dataGridView.Location = new System.Drawing.Point(11, 66);
            this.TK_DK_dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TK_DK_dataGridView.Name = "TK_DK_dataGridView";
            this.TK_DK_dataGridView.RowHeadersWidth = 62;
            this.TK_DK_dataGridView.RowTemplate.Height = 28;
            this.TK_DK_dataGridView.Size = new System.Drawing.Size(690, 248);
            this.TK_DK_dataGridView.TabIndex = 2;
            // 
            // TK_DK_Windows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.backButton;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.TK_DK_dataGridView);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TK_DK_Windows";
            this.Text = "Quản lý đăng ký học phần";
            this.Load += new System.EventHandler(this.TK_DK_Windows_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TK_DK_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridView TK_DK_dataGridView;
    }
}