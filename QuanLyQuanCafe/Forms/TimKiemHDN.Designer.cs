namespace QuanLyQuanCafe.Forms
{
    partial class frmTKHoaDonNhap
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
            this.btnDong = new System.Windows.Forms.Button();
            this.btnTimLai = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dgvTimKiemHDN = new System.Windows.Forms.DataGridView();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.mskNgayNhap = new System.Windows.Forms.MaskedTextBox();
            this.lblNgayNhap = new System.Windows.Forms.Label();
            this.txtMaHDB = new System.Windows.Forms.TextBox();
            this.lblMaHDN = new System.Windows.Forms.Label();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.lblMaNCC = new System.Windows.Forms.Label();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.lblMaNhanVien = new System.Windows.Forms.Label();
            this.lblTKHoaDonNhap = new System.Windows.Forms.Label();
            this.gbxHoaDonNhap = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiemHDN)).BeginInit();
            this.gbxHoaDonNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(750, 671);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(88, 40);
            this.btnDong.TabIndex = 134;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // btnTimLai
            // 
            this.btnTimLai.Location = new System.Drawing.Point(610, 671);
            this.btnTimLai.Name = "btnTimLai";
            this.btnTimLai.Size = new System.Drawing.Size(102, 40);
            this.btnTimLai.TabIndex = 133;
            this.btnTimLai.Text = "Tìm lại";
            this.btnTimLai.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(471, 671);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(102, 40);
            this.btnTimKiem.TabIndex = 132;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // dgvTimKiemHDN
            // 
            this.dgvTimKiemHDN.AllowUserToOrderColumns = true;
            this.dgvTimKiemHDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimKiemHDN.Location = new System.Drawing.Point(32, 259);
            this.dgvTimKiemHDN.Name = "dgvTimKiemHDN";
            this.dgvTimKiemHDN.RowHeadersWidth = 51;
            this.dgvTimKiemHDN.RowTemplate.Height = 24;
            this.dgvTimKiemHDN.Size = new System.Drawing.Size(806, 389);
            this.dgvTimKiemHDN.TabIndex = 131;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(560, 81);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(187, 24);
            this.txtTongTien.TabIndex = 130;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(466, 82);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(73, 18);
            this.lblTongTien.TabIndex = 125;
            this.lblTongTien.Text = "Tổng tiền:";
            // 
            // mskNgayNhap
            // 
            this.mskNgayNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskNgayNhap.Location = new System.Drawing.Point(560, 36);
            this.mskNgayNhap.Mask = "00/00/0000";
            this.mskNgayNhap.Name = "mskNgayNhap";
            this.mskNgayNhap.Size = new System.Drawing.Size(187, 24);
            this.mskNgayNhap.TabIndex = 129;
            this.mskNgayNhap.ValidatingType = typeof(System.DateTime);
            // 
            // lblNgayNhap
            // 
            this.lblNgayNhap.AutoSize = true;
            this.lblNgayNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayNhap.Location = new System.Drawing.Point(466, 38);
            this.lblNgayNhap.Name = "lblNgayNhap";
            this.lblNgayNhap.Size = new System.Drawing.Size(82, 18);
            this.lblNgayNhap.TabIndex = 124;
            this.lblNgayNhap.Text = "Ngày nhập:";
            // 
            // txtMaHDB
            // 
            this.txtMaHDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHDB.Location = new System.Drawing.Point(174, 36);
            this.txtMaHDB.Name = "txtMaHDB";
            this.txtMaHDB.Size = new System.Drawing.Size(187, 24);
            this.txtMaHDB.TabIndex = 126;
            // 
            // lblMaHDN
            // 
            this.lblMaHDN.AutoSize = true;
            this.lblMaHDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHDN.Location = new System.Drawing.Point(36, 37);
            this.lblMaHDN.Name = "lblMaHDN";
            this.lblMaHDN.Size = new System.Drawing.Size(127, 18);
            this.lblMaHDN.TabIndex = 121;
            this.lblMaHDN.Text = "Mã hóa đơn nhập:";
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNCC.Location = new System.Drawing.Point(174, 128);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(187, 24);
            this.txtMaNCC.TabIndex = 128;
            // 
            // lblMaNCC
            // 
            this.lblMaNCC.AutoSize = true;
            this.lblMaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNCC.Location = new System.Drawing.Point(36, 128);
            this.lblMaNCC.Name = "lblMaNCC";
            this.lblMaNCC.Size = new System.Drawing.Size(125, 18);
            this.lblMaNCC.TabIndex = 123;
            this.lblMaNCC.Text = "Mã nhà cung cấp:";
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNhanVien.Location = new System.Drawing.Point(174, 81);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(187, 24);
            this.txtMaNhanVien.TabIndex = 127;
            // 
            // lblMaNhanVien
            // 
            this.lblMaNhanVien.AutoSize = true;
            this.lblMaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNhanVien.Location = new System.Drawing.Point(36, 82);
            this.lblMaNhanVien.Name = "lblMaNhanVien";
            this.lblMaNhanVien.Size = new System.Drawing.Size(99, 18);
            this.lblMaNhanVien.TabIndex = 122;
            this.lblMaNhanVien.Text = "Mã nhân viên:";
            // 
            // lblTKHoaDonNhap
            // 
            this.lblTKHoaDonNhap.AutoSize = true;
            this.lblTKHoaDonNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTKHoaDonNhap.Location = new System.Drawing.Point(288, 35);
            this.lblTKHoaDonNhap.Name = "lblTKHoaDonNhap";
            this.lblTKHoaDonNhap.Size = new System.Drawing.Size(306, 26);
            this.lblTKHoaDonNhap.TabIndex = 120;
            this.lblTKHoaDonNhap.Text = "TÌM KIẾM HÓA ĐƠN NHẬP";
            // 
            // gbxHoaDonNhap
            // 
            this.gbxHoaDonNhap.Controls.Add(this.lblMaHDN);
            this.gbxHoaDonNhap.Controls.Add(this.lblMaNhanVien);
            this.gbxHoaDonNhap.Controls.Add(this.txtMaNhanVien);
            this.gbxHoaDonNhap.Controls.Add(this.lblMaNCC);
            this.gbxHoaDonNhap.Controls.Add(this.txtMaNCC);
            this.gbxHoaDonNhap.Controls.Add(this.txtTongTien);
            this.gbxHoaDonNhap.Controls.Add(this.txtMaHDB);
            this.gbxHoaDonNhap.Controls.Add(this.lblTongTien);
            this.gbxHoaDonNhap.Controls.Add(this.lblNgayNhap);
            this.gbxHoaDonNhap.Controls.Add(this.mskNgayNhap);
            this.gbxHoaDonNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxHoaDonNhap.Location = new System.Drawing.Point(32, 67);
            this.gbxHoaDonNhap.Name = "gbxHoaDonNhap";
            this.gbxHoaDonNhap.Size = new System.Drawing.Size(806, 177);
            this.gbxHoaDonNhap.TabIndex = 120;
            this.gbxHoaDonNhap.TabStop = false;
            this.gbxHoaDonNhap.Text = "Thông tin chi tiết";
            // 
            // frmTKHoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 742);
            this.Controls.Add(this.gbxHoaDonNhap);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnTimLai);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.dgvTimKiemHDN);
            this.Controls.Add(this.lblTKHoaDonNhap);
            this.Name = "frmTKHoaDonNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm Kiếm Hóa Đơn Nhập";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiemHDN)).EndInit();
            this.gbxHoaDonNhap.ResumeLayout(false);
            this.gbxHoaDonNhap.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnTimLai;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgvTimKiemHDN;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.MaskedTextBox mskNgayNhap;
        private System.Windows.Forms.Label lblNgayNhap;
        private System.Windows.Forms.TextBox txtMaHDB;
        private System.Windows.Forms.Label lblMaHDN;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.Label lblMaNCC;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.Label lblMaNhanVien;
        private System.Windows.Forms.Label lblTKHoaDonNhap;
        private System.Windows.Forms.GroupBox gbxHoaDonNhap;
    }
}