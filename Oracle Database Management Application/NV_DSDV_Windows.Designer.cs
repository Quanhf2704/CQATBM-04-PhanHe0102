namespace Oracle_Database_Management_Application
{
    partial class NV_DSDV_Windows
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
            this.TK_DSDV_dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.backbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TK_DSDV_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TK_DSDV_dataGridView
            // 
            this.TK_DSDV_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TK_DSDV_dataGridView.Location = new System.Drawing.Point(15, 90);
            this.TK_DSDV_dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TK_DSDV_dataGridView.Name = "TK_DSDV_dataGridView";
            this.TK_DSDV_dataGridView.RowHeadersWidth = 62;
            this.TK_DSDV_dataGridView.RowTemplate.Height = 28;
            this.TK_DSDV_dataGridView.Size = new System.Drawing.Size(1037, 404);
            this.TK_DSDV_dataGridView.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(361, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "DANH SÁCH ĐƠN VỊ";
            // 
            // backbutton
            // 
            this.backbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.backbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbutton.Location = new System.Drawing.Point(960, 498);
            this.backbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(92, 42);
            this.backbutton.TabIndex = 3;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // NV_DSDV_Windows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.backbutton;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.TK_DSDV_dataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backbutton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NV_DSDV_Windows";
            this.Text = "Danh sách đơn vị";
            this.Load += new System.EventHandler(this.NV_DSDV_Windows_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TK_DSDV_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TK_DSDV_dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backbutton;
    }
}