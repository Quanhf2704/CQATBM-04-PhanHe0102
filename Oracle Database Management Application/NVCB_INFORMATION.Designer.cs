namespace Oracle_Database_Management_Application
{
    partial class NVCB_INFORMATION
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
            this.TTCNdataGridView = new System.Windows.Forms.DataGridView();
            this.backbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TTCNdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN CÁ NHÂN";
            // 
            // TTCNdataGridView
            // 
            this.TTCNdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TTCNdataGridView.Location = new System.Drawing.Point(12, 80);
            this.TTCNdataGridView.Name = "TTCNdataGridView";
            this.TTCNdataGridView.Size = new System.Drawing.Size(776, 316);
            this.TTCNdataGridView.TabIndex = 1;
            // 
            // backbutton
            // 
            this.backbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbutton.Location = new System.Drawing.Point(699, 402);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(89, 36);
            this.backbutton.TabIndex = 2;
            this.backbutton.Text = "Quay lại";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // NVCB_INFORMATION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.TTCNdataGridView);
            this.Controls.Add(this.label1);
            this.Name = "NVCB_INFORMATION";
            this.Text = "Xem thông tin cá nhân";
            this.Load += new System.EventHandler(this.NVCB_INFORMATION_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TTCNdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView TTCNdataGridView;
        private System.Windows.Forms.Button backbutton;
    }
}