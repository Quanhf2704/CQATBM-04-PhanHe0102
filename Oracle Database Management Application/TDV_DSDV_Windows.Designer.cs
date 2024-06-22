namespace Oracle_Database_Management_Application
{
    partial class TDV_DSDV_Windows
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
            this.TDV_DSDV_dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TDV_DSDV_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(620, 318);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH ĐƠN VỊ";
            // 
            // TDV_DSDV_dataGridView
            // 
            this.TDV_DSDV_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TDV_DSDV_dataGridView.Location = new System.Drawing.Point(11, 62);
            this.TDV_DSDV_dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TDV_DSDV_dataGridView.Name = "TDV_DSDV_dataGridView";
            this.TDV_DSDV_dataGridView.RowHeadersWidth = 62;
            this.TDV_DSDV_dataGridView.RowTemplate.Height = 28;
            this.TDV_DSDV_dataGridView.Size = new System.Drawing.Size(690, 252);
            this.TDV_DSDV_dataGridView.TabIndex = 2;
            // 
            // TDV_DSDV_Windows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.TDV_DSDV_dataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TDV_DSDV_Windows";
            this.Text = "Danh sách đơn vị";
            this.Load += new System.EventHandler(this.TK_DSDV_Windows_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TDV_DSDV_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView TDV_DSDV_dataGridView;
    }
}