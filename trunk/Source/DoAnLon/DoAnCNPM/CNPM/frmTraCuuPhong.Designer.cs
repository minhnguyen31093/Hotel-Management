﻿namespace CNPM
{
    partial class frmTraCuuPhong
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.dgrvDanhSachPhong = new System.Windows.Forms.DataGridView();
            this.columnSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.lblMaPhong = new System.Windows.Forms.Label();
            this.lblTraCuu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvDanhSachPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(419, 167);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(97, 32);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHuy.Location = new System.Drawing.Point(257, 167);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(97, 32);
            this.btnHuy.TabIndex = 10;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTim.Location = new System.Drawing.Point(358, 52);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(97, 32);
            this.btnTim.TabIndex = 11;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu.Location = new System.Drawing.Point(91, 167);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(97, 32);
            this.btnLuu.TabIndex = 12;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // dgrvDanhSachPhong
            // 
            this.dgrvDanhSachPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvDanhSachPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnSTT,
            this.ColumnPhong,
            this.ColumnLoaiPhong,
            this.ColumnDonGia,
            this.ColumnTinhTrang});
            this.dgrvDanhSachPhong.Enabled = false;
            this.dgrvDanhSachPhong.Location = new System.Drawing.Point(16, 100);
            this.dgrvDanhSachPhong.Name = "dgrvDanhSachPhong";
            this.dgrvDanhSachPhong.ReadOnly = true;
            this.dgrvDanhSachPhong.Size = new System.Drawing.Size(544, 42);
            this.dgrvDanhSachPhong.TabIndex = 8;
            // 
            // columnSTT
            // 
            this.columnSTT.HeaderText = "STT";
            this.columnSTT.Name = "columnSTT";
            this.columnSTT.ReadOnly = true;
            // 
            // ColumnPhong
            // 
            this.ColumnPhong.HeaderText = "Phòng";
            this.ColumnPhong.Name = "ColumnPhong";
            this.ColumnPhong.ReadOnly = true;
            // 
            // ColumnLoaiPhong
            // 
            this.ColumnLoaiPhong.HeaderText = "Loại Phòng";
            this.ColumnLoaiPhong.Name = "ColumnLoaiPhong";
            this.ColumnLoaiPhong.ReadOnly = true;
            // 
            // ColumnDonGia
            // 
            this.ColumnDonGia.HeaderText = "Đơn Giá";
            this.ColumnDonGia.Name = "ColumnDonGia";
            this.ColumnDonGia.ReadOnly = true;
            // 
            // ColumnTinhTrang
            // 
            this.ColumnTinhTrang.HeaderText = "Tình Trạng";
            this.ColumnTinhTrang.Name = "ColumnTinhTrang";
            this.ColumnTinhTrang.ReadOnly = true;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(202, 59);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(119, 20);
            this.txtMaPhong.TabIndex = 7;
            // 
            // lblMaPhong
            // 
            this.lblMaPhong.AutoSize = true;
            this.lblMaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaPhong.Location = new System.Drawing.Point(125, 60);
            this.lblMaPhong.Name = "lblMaPhong";
            this.lblMaPhong.Size = new System.Drawing.Size(71, 16);
            this.lblMaPhong.TabIndex = 6;
            this.lblMaPhong.Text = "Mã phòng:";
            // 
            // lblTraCuu
            // 
            this.lblTraCuu.AutoSize = true;
            this.lblTraCuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTraCuu.Location = new System.Drawing.Point(139, 9);
            this.lblTraCuu.Name = "lblTraCuu";
            this.lblTraCuu.Size = new System.Drawing.Size(316, 25);
            this.lblTraCuu.TabIndex = 5;
            this.lblTraCuu.Text = "TRA CỨU DANH SÁCH PHÒNG";
            // 
            // frmTraCuuPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 215);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.dgrvDanhSachPhong);
            this.Controls.Add(this.txtMaPhong);
            this.Controls.Add(this.lblMaPhong);
            this.Controls.Add(this.lblTraCuu);
            this.Name = "frmTraCuuPhong";
            this.Text = "frmTraCuuPhong";
            ((System.ComponentModel.ISupportInitialize)(this.dgrvDanhSachPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridView dgrvDanhSachPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTinhTrang;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.Label lblMaPhong;
        private System.Windows.Forms.Label lblTraCuu;
    }
}