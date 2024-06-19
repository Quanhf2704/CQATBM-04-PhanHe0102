namespace Oracle_Database_Management_Application
{
    partial class AnnouncementWindow
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
            this.btnBack = new System.Windows.Forms.Button();
            this.dataGridViewListAnnouncement = new System.Windows.Forms.DataGridView();
            this.lblAnnouncement = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListAnnouncement)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(858, 493);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(108, 40);
            this.btnBack.TabIndex = 62;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dataGridViewListAnnouncement
            // 
            this.dataGridViewListAnnouncement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListAnnouncement.Location = new System.Drawing.Point(26, 66);
            this.dataGridViewListAnnouncement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewListAnnouncement.Name = "dataGridViewListAnnouncement";
            this.dataGridViewListAnnouncement.RowHeadersWidth = 62;
            this.dataGridViewListAnnouncement.RowTemplate.Height = 28;
            this.dataGridViewListAnnouncement.Size = new System.Drawing.Size(921, 423);
            this.dataGridViewListAnnouncement.TabIndex = 61;
            // 
            // lblAnnouncement
            // 
            this.lblAnnouncement.AutoSize = true;
            this.lblAnnouncement.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnnouncement.Location = new System.Drawing.Point(378, 9);
            this.lblAnnouncement.Name = "lblAnnouncement";
            this.lblAnnouncement.Size = new System.Drawing.Size(255, 55);
            this.lblAnnouncement.TabIndex = 60;
            this.lblAnnouncement.Text = "Thông báo";
            this.lblAnnouncement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AnnouncementWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 544);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridViewListAnnouncement);
            this.Controls.Add(this.lblAnnouncement);
            this.Name = "AnnouncementWindow";
            this.Text = "Thông báo";
            this.Load += new System.EventHandler(this.AnnouncementWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListAnnouncement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dataGridViewListAnnouncement;
        private System.Windows.Forms.Label lblAnnouncement;
    }
}