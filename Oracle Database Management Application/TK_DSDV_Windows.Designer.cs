﻿namespace Oracle_Database_Management_Application
{
    partial class TK_DSDV_Windows
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TK_DSDV_dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TK_DSDV_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(465, 259);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH ĐƠN VỊ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TK_DSDV_dataGridView
            // 
            this.TK_DSDV_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TK_DSDV_dataGridView.Location = new System.Drawing.Point(8, 50);
            this.TK_DSDV_dataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TK_DSDV_dataGridView.Name = "TK_DSDV_dataGridView";
            this.TK_DSDV_dataGridView.RowHeadersWidth = 62;
            this.TK_DSDV_dataGridView.RowTemplate.Height = 28;
            this.TK_DSDV_dataGridView.Size = new System.Drawing.Size(517, 205);
            this.TK_DSDV_dataGridView.TabIndex = 2;
            this.TK_DSDV_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TK_DSDV_dataGridView_CellContentClick);
            // 
            // TK_DSDV_Windows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.TK_DSDV_dataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TK_DSDV_Windows";
            this.Text = "Danh sách đơn vị";
            this.Load += new System.EventHandler(this.TK_DSDV_Windows_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TK_DSDV_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView TK_DSDV_dataGridView;
    }
}