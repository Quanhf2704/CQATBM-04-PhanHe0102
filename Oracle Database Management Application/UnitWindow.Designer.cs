﻿namespace Oracle_Database_Management_Application
{
    partial class UnitWindow
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dataGridViewListUnit = new System.Windows.Forms.DataGridView();
            this.lblUnitInfo = new System.Windows.Forms.Label();
            this.txtUnitHead = new System.Windows.Forms.TextBox();
            this.txtUnitName = new System.Windows.Forms.TextBox();
            this.lblUnitHead = new System.Windows.Forms.Label();
            this.lblUnitName = new System.Windows.Forms.Label();
            this.txtUnitCode = new System.Windows.Forms.TextBox();
            this.lblUnitCode = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListUnit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(630, 494);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 40);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(744, 494);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(108, 40);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(858, 494);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(108, 40);
            this.btnBack.TabIndex = 20;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dataGridViewListUnit
            // 
            this.dataGridViewListUnit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListUnit.Location = new System.Drawing.Point(45, 74);
            this.dataGridViewListUnit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewListUnit.Name = "dataGridViewListUnit";
            this.dataGridViewListUnit.RowHeadersWidth = 62;
            this.dataGridViewListUnit.RowTemplate.Height = 28;
            this.dataGridViewListUnit.Size = new System.Drawing.Size(566, 416);
            this.dataGridViewListUnit.TabIndex = 19;
            // 
            // lblUnitInfo
            // 
            this.lblUnitInfo.AutoSize = true;
            this.lblUnitInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitInfo.Location = new System.Drawing.Point(315, 9);
            this.lblUnitInfo.Name = "lblUnitInfo";
            this.lblUnitInfo.Size = new System.Drawing.Size(373, 55);
            this.lblUnitInfo.TabIndex = 18;
            this.lblUnitInfo.Text = "Thông tin Đơn vị";
            this.lblUnitInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUnitHead
            // 
            this.txtUnitHead.Location = new System.Drawing.Point(745, 160);
            this.txtUnitHead.Name = "txtUnitHead";
            this.txtUnitHead.Size = new System.Drawing.Size(214, 26);
            this.txtUnitHead.TabIndex = 50;
            // 
            // txtUnitName
            // 
            this.txtUnitName.Location = new System.Drawing.Point(745, 116);
            this.txtUnitName.Name = "txtUnitName";
            this.txtUnitName.Size = new System.Drawing.Size(214, 26);
            this.txtUnitName.TabIndex = 49;
            // 
            // lblUnitHead
            // 
            this.lblUnitHead.AutoSize = true;
            this.lblUnitHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitHead.Location = new System.Drawing.Point(617, 160);
            this.lblUnitHead.Name = "lblUnitHead";
            this.lblUnitHead.Size = new System.Drawing.Size(121, 22);
            this.lblUnitHead.TabIndex = 41;
            this.lblUnitHead.Text = "Trưởng đơn vị";
            this.lblUnitHead.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUnitName
            // 
            this.lblUnitName.AutoSize = true;
            this.lblUnitName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitName.Location = new System.Drawing.Point(617, 116);
            this.lblUnitName.Name = "lblUnitName";
            this.lblUnitName.Size = new System.Drawing.Size(95, 22);
            this.lblUnitName.TabIndex = 40;
            this.lblUnitName.Text = "Tên đơn vị";
            this.lblUnitName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUnitCode
            // 
            this.txtUnitCode.Location = new System.Drawing.Point(745, 74);
            this.txtUnitCode.Name = "txtUnitCode";
            this.txtUnitCode.Size = new System.Drawing.Size(214, 26);
            this.txtUnitCode.TabIndex = 39;
            // 
            // lblUnitCode
            // 
            this.lblUnitCode.AutoSize = true;
            this.lblUnitCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitCode.Location = new System.Drawing.Point(617, 74);
            this.lblUnitCode.Name = "lblUnitCode";
            this.lblUnitCode.Size = new System.Drawing.Size(87, 22);
            this.lblUnitCode.TabIndex = 38;
            this.lblUnitCode.Text = "Mã đơn vị";
            this.lblUnitCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(516, 494);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(108, 39);
            this.btnRefresh.TabIndex = 51;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // UnitWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 544);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtUnitHead);
            this.Controls.Add(this.txtUnitName);
            this.Controls.Add(this.lblUnitHead);
            this.Controls.Add(this.lblUnitName);
            this.Controls.Add(this.txtUnitCode);
            this.Controls.Add(this.lblUnitCode);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridViewListUnit);
            this.Controls.Add(this.lblUnitInfo);
            this.Name = "UnitWindow";
            this.Text = "Thông tin đơn vị";
            this.Load += new System.EventHandler(this.UnitWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListUnit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dataGridViewListUnit;
        private System.Windows.Forms.Label lblUnitInfo;
        private System.Windows.Forms.TextBox txtUnitHead;
        private System.Windows.Forms.TextBox txtUnitName;
        private System.Windows.Forms.Label lblUnitHead;
        private System.Windows.Forms.Label lblUnitName;
        private System.Windows.Forms.TextBox txtUnitCode;
        private System.Windows.Forms.Label lblUnitCode;
        private System.Windows.Forms.Button btnRefresh;
    }
}