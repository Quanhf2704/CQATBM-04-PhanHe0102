namespace Oracle_Database_Management_Application
{
    partial class TK_XEMPHANCONG_Windows
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
            this.GV_PHANCONG_dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.backbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GV_PHANCONG_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // GV_PHANCONG_dataGridView
            // 
            this.GV_PHANCONG_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_PHANCONG_dataGridView.Location = new System.Drawing.Point(15, 80);
            this.GV_PHANCONG_dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GV_PHANCONG_dataGridView.Name = "GV_PHANCONG_dataGridView";
            this.GV_PHANCONG_dataGridView.RowHeadersWidth = 62;
            this.GV_PHANCONG_dataGridView.RowTemplate.Height = 28;
            this.GV_PHANCONG_dataGridView.Size = new System.Drawing.Size(1037, 414);
            this.GV_PHANCONG_dataGridView.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(429, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "PHÂN CÔNG";
            // 
            // backbutton
            // 
            this.backbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.backbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbutton.Location = new System.Drawing.Point(960, 498);
            this.backbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(92, 42);
            this.backbutton.TabIndex = 12;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // TK_XEMPHANCONG_Windows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.backbutton;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.GV_PHANCONG_dataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backbutton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TK_XEMPHANCONG_Windows";
            this.Text = "Trưởng khoa xem phân công";
            this.Load += new System.EventHandler(this.TK_XEMPHANCONG_Windows_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GV_PHANCONG_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GV_PHANCONG_dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backbutton;
    }
}