namespace Oracle_Database_Management_Application
{
    partial class TK_INFORMATION
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
            this.backbutton = new System.Windows.Forms.Button();
            this.TTCNdataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TTCNdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // backbutton
            // 
            this.backbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbutton.Location = new System.Drawing.Point(699, 396);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(89, 36);
            this.backbutton.TabIndex = 5;
            this.backbutton.Text = "Quay lại";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // TTCNdataGridView
            // 
            this.TTCNdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TTCNdataGridView.Location = new System.Drawing.Point(12, 74);
            this.TTCNdataGridView.Name = "TTCNdataGridView";
            this.TTCNdataGridView.Size = new System.Drawing.Size(776, 316);
            this.TTCNdataGridView.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "THÔNG TIN CÁ NHÂN";
            // 
            // TK_INFORMATION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.TTCNdataGridView);
            this.Controls.Add(this.label1);
            this.Name = "TK_INFORMATION";
            this.Text = "Thông tin cá nhân";
            this.Load += new System.EventHandler(this.TK_INFORMATION_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TTCNdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.DataGridView TTCNdataGridView;
        private System.Windows.Forms.Label label1;
    }
}