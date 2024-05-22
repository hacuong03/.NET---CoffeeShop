namespace QuanLyQuanCafe.Forms
{
    partial class frmTKHoaDonBan
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
            this.lblTKHoaDonBan = new System.Windows.Forms.Label();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.lblMaNhanVien = new System.Windows.Forms.Label();
            this.txtMaKhachHang = new System.Windows.Forms.TextBox();
            this.lblMaKhachHang = new System.Windows.Forms.Label();
            this.txtMaHDB = new System.Windows.Forms.TextBox();
            this.lblMaHDB = new System.Windows.Forms.Label();
            this.mskNgayBan = new System.Windows.Forms.MaskedTextBox();
            this.lblNgayBan = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.dgvTimKiemHDB = new System.Windows.Forms.DataGridView();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnTimLai = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.gbxHoaDonBan = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiemHDB)).BeginInit();
            this.gbxHoaDonBan.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTKHoaDonBan
            // 
            this.lblTKHoaDonBan.AutoSize = true;
            this.lblTKHoaDonBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTKHoaDonBan.Location = new System.Drawing.Point(293, 36);
            this.lblTKHoaDonBan.Name = "lblTKHoaDonBan";
            this.lblTKHoaDonBan.Size = new System.Drawing.Size(289, 26);
            this.lblTKHoaDonBan.TabIndex = 105;
            this.lblTKHoaDonBan.Text = "TÌM KIẾM HÓA ĐƠN BÁN";
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNhanVien.Location = new System.Drawing.Point(176, 82);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(187, 24);
            this.txtMaNhanVien.TabIndex = 112;
            // 
            // lblMaNhanVien
            // 
            this.lblMaNhanVien.AutoSize = true;
            this.lblMaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNhanVien.Location = new System.Drawing.Point(38, 83);
            this.lblMaNhanVien.Name = "lblMaNhanVien";
            this.lblMaNhanVien.Size = new System.Drawing.Size(99, 18);
            this.lblMaNhanVien.TabIndex = 107;
            this.lblMaNhanVien.Text = "Mã nhân viên:";
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKhachHang.Location = new System.Drawing.Point(176, 129);
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Size = new System.Drawing.Size(187, 24);
            this.txtMaKhachHang.TabIndex = 113;
            // 
            // lblMaKhachHang
            // 
            this.lblMaKhachHang.AutoSize = true;
            this.lblMaKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaKhachHang.Location = new System.Drawing.Point(38, 129);
            this.lblMaKhachHang.Name = "lblMaKhachHang";
            this.lblMaKhachHang.Size = new System.Drawing.Size(113, 18);
            this.lblMaKhachHang.TabIndex = 108;
            this.lblMaKhachHang.Text = "Mã khách hàng:";
            // 
            // txtMaHDB
            // 
            this.txtMaHDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHDB.Location = new System.Drawing.Point(176, 37);
            this.txtMaHDB.Name = "txtMaHDB";
            this.txtMaHDB.Size = new System.Drawing.Size(187, 24);
            this.txtMaHDB.TabIndex = 111;
            // 
            // lblMaHDB
            // 
            this.lblMaHDB.AutoSize = true;
            this.lblMaHDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHDB.Location = new System.Drawing.Point(38, 38);
            this.lblMaHDB.Name = "lblMaHDB";
            this.lblMaHDB.Size = new System.Drawing.Size(119, 18);
            this.lblMaHDB.TabIndex = 106;
            this.lblMaHDB.Text = "Mã hóa đơn bán:";
            // 
            // mskNgayBan
            // 
            this.mskNgayBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskNgayBan.Location = new System.Drawing.Point(562, 37);
            this.mskNgayBan.Mask = "00/00/0000";
            this.mskNgayBan.Name = "mskNgayBan";
            this.mskNgayBan.Size = new System.Drawing.Size(187, 24);
            this.mskNgayBan.TabIndex = 114;
            this.mskNgayBan.ValidatingType = typeof(System.DateTime);
            // 
            // lblNgayBan
            // 
            this.lblNgayBan.AutoSize = true;
            this.lblNgayBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayBan.Location = new System.Drawing.Point(468, 39);
            this.lblNgayBan.Name = "lblNgayBan";
            this.lblNgayBan.Size = new System.Drawing.Size(74, 18);
            this.lblNgayBan.TabIndex = 109;
            this.lblNgayBan.Text = "Ngày bán:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(562, 82);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(187, 24);
            this.txtTongTien.TabIndex = 115;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(468, 83);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(73, 18);
            this.lblTongTien.TabIndex = 110;
            this.lblTongTien.Text = "Tổng tiền:";
            // 
            // dgvTimKiemHDB
            // 
            this.dgvTimKiemHDB.AllowUserToOrderColumns = true;
            this.dgvTimKiemHDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimKiemHDB.Location = new System.Drawing.Point(33, 255);
            this.dgvTimKiemHDB.Name = "dgvTimKiemHDB";
            this.dgvTimKiemHDB.RowHeadersWidth = 51;
            this.dgvTimKiemHDB.RowTemplate.Height = 24;
            this.dgvTimKiemHDB.Size = new System.Drawing.Size(806, 389);
            this.dgvTimKiemHDB.TabIndex = 116;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(494, 671);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(102, 40);
            this.btnTimKiem.TabIndex = 117;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnTimLai
            // 
            this.btnTimLai.Location = new System.Drawing.Point(623, 671);
            this.btnTimLai.Name = "btnTimLai";
            this.btnTimLai.Size = new System.Drawing.Size(102, 40);
            this.btnTimLai.TabIndex = 118;
            this.btnTimLai.Text = "Tìm lại";
            this.btnTimLai.UseVisualStyleBackColor = true;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(751, 671);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(88, 40);
            this.btnDong.TabIndex = 119;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // gbxHoaDonBan
            // 
            this.gbxHoaDonBan.Controls.Add(this.lblMaHDB);
            this.gbxHoaDonBan.Controls.Add(this.lblMaNhanVien);
            this.gbxHoaDonBan.Controls.Add(this.txtMaNhanVien);
            this.gbxHoaDonBan.Controls.Add(this.lblMaKhachHang);
            this.gbxHoaDonBan.Controls.Add(this.txtMaKhachHang);
            this.gbxHoaDonBan.Controls.Add(this.txtTongTien);
            this.gbxHoaDonBan.Controls.Add(this.txtMaHDB);
            this.gbxHoaDonBan.Controls.Add(this.lblTongTien);
            this.gbxHoaDonBan.Controls.Add(this.lblNgayBan);
            this.gbxHoaDonBan.Controls.Add(this.mskNgayBan);
            this.gbxHoaDonBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxHoaDonBan.Location = new System.Drawing.Point(33, 68);
            this.gbxHoaDonBan.Name = "gbxHoaDonBan";
            this.gbxHoaDonBan.Size = new System.Drawing.Size(806, 172);
            this.gbxHoaDonBan.TabIndex = 105;
            this.gbxHoaDonBan.TabStop = false;
            this.gbxHoaDonBan.Text = "Thông tin chi tiết";
            // 
            // frmTKHoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 743);
            this.Controls.Add(this.gbxHoaDonBan);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnTimLai);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.dgvTimKiemHDB);
            this.Controls.Add(this.lblTKHoaDonBan);
            this.Name = "frmTKHoaDonBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm Kiếm Hóa Đơn Bán";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiemHDB)).EndInit();
            this.gbxHoaDonBan.ResumeLayout(false);
            this.gbxHoaDonBan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTKHoaDonBan;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.Label lblMaNhanVien;
        private System.Windows.Forms.TextBox txtMaKhachHang;
        private System.Windows.Forms.Label lblMaKhachHang;
        private System.Windows.Forms.TextBox txtMaHDB;
        private System.Windows.Forms.Label lblMaHDB;
        private System.Windows.Forms.MaskedTextBox mskNgayBan;
        private System.Windows.Forms.Label lblNgayBan;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.DataGridView dgvTimKiemHDB;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnTimLai;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.GroupBox gbxHoaDonBan;
    }
}