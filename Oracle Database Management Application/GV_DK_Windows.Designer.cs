namespace Oracle_Database_Management_Application
{
    partial class GV_DK_Windows
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
            this.SV_DK_dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.backbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SV_DK_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SV_DK_dataGridView
            // 
            this.SV_DK_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SV_DK_dataGridView.Location = new System.Drawing.Point(15, 80);
            this.SV_DK_dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SV_DK_dataGridView.Name = "SV_DK_dataGridView";
            this.SV_DK_dataGridView.RowHeadersWidth = 62;
            this.SV_DK_dataGridView.RowTemplate.Height = 28;
            this.SV_DK_dataGridView.Size = new System.Drawing.Size(1037, 404);
            this.SV_DK_dataGridView.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "DANH SÁCH SINH VIÊN ĐĂNG KÝ";
            // 
            // backbutton
            // 
            this.backbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.backbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbutton.Location = new System.Drawing.Point(960, 489);
            this.backbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(92, 42);
            this.backbutton.TabIndex = 9;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // GV_DK_Windows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.backbutton;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.SV_DK_dataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backbutton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GV_DK_Windows";
            this.Text = "Sinh viên đăng ký";
            this.Load += new System.EventHandler(this.GV_DK_Windows_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SV_DK_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SV_DK_dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backbutton;
    }
}