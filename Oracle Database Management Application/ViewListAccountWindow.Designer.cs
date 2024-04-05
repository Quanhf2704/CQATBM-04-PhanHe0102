namespace Oracle_Database_Management_Application
{
    partial class ViewListAccountWindow
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
            this.lblViewListAccount = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.dataGridViewListAccount = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // lblViewListAccount
            // 
            this.lblViewListAccount.AutoSize = true;
            this.lblViewListAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewListAccount.Location = new System.Drawing.Point(145, 9);
            this.lblViewListAccount.Name = "lblViewListAccount";
            this.lblViewListAccount.Size = new System.Drawing.Size(715, 55);
            this.lblViewListAccount.TabIndex = 2;
            this.lblViewListAccount.Text = "Danh sách tài khoản người dùng";
            this.lblViewListAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(858, 492);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(108, 40);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dataGridViewListAccount
            // 
            this.dataGridViewListAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListAccount.Location = new System.Drawing.Point(12, 67);
            this.dataGridViewListAccount.Name = "dataGridViewListAccount";
            this.dataGridViewListAccount.RowHeadersWidth = 62;
            this.dataGridViewListAccount.RowTemplate.Height = 28;
            this.dataGridViewListAccount.Size = new System.Drawing.Size(953, 413);
            this.dataGridViewListAccount.TabIndex = 13;
            // 
            // ViewListAccountWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 544);
            this.Controls.Add(this.dataGridViewListAccount);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblViewListAccount);
            this.Name = "ViewListAccountWindow";
            this.Text = "Xem danh sách tài khoản";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblViewListAccount;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dataGridViewListAccount;
    }
}