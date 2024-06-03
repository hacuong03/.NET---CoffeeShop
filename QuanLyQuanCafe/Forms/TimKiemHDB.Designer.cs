namespace QuanLyQuanCafe.Forms
{
    partial class frmTimKiemHDB
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
            this.lblMaNhanVien = new System.Windows.Forms.Label();
            this.lblMaKhachHang = new System.Windows.Forms.Label();
            this.lblMaHDB = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.dgvTimKiemHDB = new System.Windows.Forms.DataGridView();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnTimLai = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.gbxHoaDonBan = new System.Windows.Forms.GroupBox();
            this.dtpNgayKT = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayBD = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayBan = new System.Windows.Forms.DateTimePicker();
            this.cboMaKhachHang = new System.Windows.Forms.ComboBox();
            this.cboMaNhanVien = new System.Windows.Forms.ComboBox();
            this.cboMaHDB = new System.Windows.Forms.ComboBox();
            this.labelChuthich = new System.Windows.Forms.Label();
            this.grbKhoangNgay = new System.Windows.Forms.GroupBox();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.rdoTheoKhoang = new System.Windows.Forms.RadioButton();
            this.rdoTheoNgay = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiemHDB)).BeginInit();
            this.gbxHoaDonBan.SuspendLayout();
            this.grbKhoangNgay.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTKHoaDonBan
            // 
            this.lblTKHoaDonBan.AutoSize = true;
            this.lblTKHoaDonBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTKHoaDonBan.Location = new System.Drawing.Point(365, 36);
            this.lblTKHoaDonBan.Name = "lblTKHoaDonBan";
            this.lblTKHoaDonBan.Size = new System.Drawing.Size(289, 26);
            this.lblTKHoaDonBan.TabIndex = 138;
            this.lblTKHoaDonBan.Text = "TÌM KIẾM HÓA ĐƠN BÁN";
            // 
            // lblMaNhanVien
            // 
            this.lblMaNhanVien.AutoSize = true;
            this.lblMaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNhanVien.Location = new System.Drawing.Point(26, 83);
            this.lblMaNhanVien.Name = "lblMaNhanVien";
            this.lblMaNhanVien.Size = new System.Drawing.Size(99, 18);
            this.lblMaNhanVien.TabIndex = 141;
            this.lblMaNhanVien.Text = "Mã nhân viên:";
            // 
            // lblMaKhachHang
            // 
            this.lblMaKhachHang.AutoSize = true;
            this.lblMaKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaKhachHang.Location = new System.Drawing.Point(26, 129);
            this.lblMaKhachHang.Name = "lblMaKhachHang";
            this.lblMaKhachHang.Size = new System.Drawing.Size(113, 18);
            this.lblMaKhachHang.TabIndex = 142;
            this.lblMaKhachHang.Text = "Mã khách hàng:";
            // 
            // lblMaHDB
            // 
            this.lblMaHDB.AutoSize = true;
            this.lblMaHDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHDB.Location = new System.Drawing.Point(26, 38);
            this.lblMaHDB.Name = "lblMaHDB";
            this.lblMaHDB.Size = new System.Drawing.Size(119, 18);
            this.lblMaHDB.TabIndex = 140;
            this.lblMaHDB.Text = "Mã hóa đơn bán:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(586, 128);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(172, 22);
            this.txtTongTien.TabIndex = 152;
            this.txtTongTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTongTien_KeyPress);
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(477, 129);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(73, 18);
            this.lblTongTien.TabIndex = 148;
            this.lblTongTien.Text = "Tổng tiền:";
            // 
            // dgvTimKiemHDB
            // 
            this.dgvTimKiemHDB.AllowUserToOrderColumns = true;
            this.dgvTimKiemHDB.ColumnHeadersHeight = 29;
            this.dgvTimKiemHDB.Location = new System.Drawing.Point(33, 256);
            this.dgvTimKiemHDB.Name = "dgvTimKiemHDB";
            this.dgvTimKiemHDB.RowHeadersWidth = 51;
            this.dgvTimKiemHDB.RowTemplate.Height = 24;
            this.dgvTimKiemHDB.Size = new System.Drawing.Size(973, 389);
            this.dgvTimKiemHDB.TabIndex = 153;
            this.dgvTimKiemHDB.DoubleClick += new System.EventHandler(this.dgvTimKiemHDB_DoubleClick);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(661, 685);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(102, 40);
            this.btnTimKiem.TabIndex = 154;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnTimLai
            // 
            this.btnTimLai.Location = new System.Drawing.Point(790, 685);
            this.btnTimLai.Name = "btnTimLai";
            this.btnTimLai.Size = new System.Drawing.Size(102, 40);
            this.btnTimLai.TabIndex = 155;
            this.btnTimLai.Text = "Tìm lại";
            this.btnTimLai.UseVisualStyleBackColor = true;
            this.btnTimLai.Click += new System.EventHandler(this.btnTimLai_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(918, 685);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(88, 40);
            this.btnDong.TabIndex = 156;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // gbxHoaDonBan
            // 
            this.gbxHoaDonBan.Controls.Add(this.grbKhoangNgay);
            this.gbxHoaDonBan.Controls.Add(this.cboMaKhachHang);
            this.gbxHoaDonBan.Controls.Add(this.rdoTheoKhoang);
            this.gbxHoaDonBan.Controls.Add(this.cboMaNhanVien);
            this.gbxHoaDonBan.Controls.Add(this.rdoTheoNgay);
            this.gbxHoaDonBan.Controls.Add(this.dtpNgayBan);
            this.gbxHoaDonBan.Controls.Add(this.cboMaHDB);
            this.gbxHoaDonBan.Controls.Add(this.lblMaHDB);
            this.gbxHoaDonBan.Controls.Add(this.lblMaNhanVien);
            this.gbxHoaDonBan.Controls.Add(this.lblMaKhachHang);
            this.gbxHoaDonBan.Controls.Add(this.txtTongTien);
            this.gbxHoaDonBan.Controls.Add(this.lblTongTien);
            this.gbxHoaDonBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxHoaDonBan.Location = new System.Drawing.Point(33, 68);
            this.gbxHoaDonBan.Name = "gbxHoaDonBan";
            this.gbxHoaDonBan.Size = new System.Drawing.Size(973, 172);
            this.gbxHoaDonBan.TabIndex = 139;
            this.gbxHoaDonBan.TabStop = false;
            this.gbxHoaDonBan.Text = "Thông tin tìm kiếm";
            // 
            // dtpNgayKT
            // 
            this.dtpNgayKT.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKT.Location = new System.Drawing.Point(222, 11);
            this.dtpNgayKT.Name = "dtpNgayKT";
            this.dtpNgayKT.Size = new System.Drawing.Size(139, 22);
            this.dtpNgayKT.TabIndex = 151;
            // 
            // dtpNgayBD
            // 
            this.dtpNgayBD.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBD.Location = new System.Drawing.Point(36, 11);
            this.dtpNgayBD.Name = "dtpNgayBD";
            this.dtpNgayBD.Size = new System.Drawing.Size(137, 22);
            this.dtpNgayBD.TabIndex = 150;
            // 
            // dtpNgayBan
            // 
            this.dtpNgayBan.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayBan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBan.Location = new System.Drawing.Point(586, 36);
            this.dtpNgayBan.Name = "dtpNgayBan";
            this.dtpNgayBan.Size = new System.Drawing.Size(172, 22);
            this.dtpNgayBan.TabIndex = 149;
            // 
            // cboMaKhachHang
            // 
            this.cboMaKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaKhachHang.FormattingEnabled = true;
            this.cboMaKhachHang.Location = new System.Drawing.Point(158, 126);
            this.cboMaKhachHang.Name = "cboMaKhachHang";
            this.cboMaKhachHang.Size = new System.Drawing.Size(175, 24);
            this.cboMaKhachHang.TabIndex = 145;
            // 
            // cboMaNhanVien
            // 
            this.cboMaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaNhanVien.FormattingEnabled = true;
            this.cboMaNhanVien.Location = new System.Drawing.Point(158, 80);
            this.cboMaNhanVien.Name = "cboMaNhanVien";
            this.cboMaNhanVien.Size = new System.Drawing.Size(175, 24);
            this.cboMaNhanVien.TabIndex = 144;
            // 
            // cboMaHDB
            // 
            this.cboMaHDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaHDB.FormattingEnabled = true;
            this.cboMaHDB.Location = new System.Drawing.Point(158, 35);
            this.cboMaHDB.Name = "cboMaHDB";
            this.cboMaHDB.Size = new System.Drawing.Size(175, 24);
            this.cboMaHDB.TabIndex = 143;
            // 
            // labelChuthich
            // 
            this.labelChuthich.AutoSize = true;
            this.labelChuthich.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChuthich.Location = new System.Drawing.Point(30, 660);
            this.labelChuthich.Name = "labelChuthich";
            this.labelChuthich.Size = new System.Drawing.Size(404, 18);
            this.labelChuthich.TabIndex = 153;
            this.labelChuthich.Text = "* Kích đúp vào một hàng để xem chi tiết hóa đơn bán";
            // 
            // grbKhoangNgay
            // 
            this.grbKhoangNgay.Controls.Add(this.dtpNgayKT);
            this.grbKhoangNgay.Controls.Add(this.lblDenNgay);
            this.grbKhoangNgay.Controls.Add(this.dtpNgayBD);
            this.grbKhoangNgay.Controls.Add(this.lblTuNgay);
            this.grbKhoangNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbKhoangNgay.Location = new System.Drawing.Point(586, 71);
            this.grbKhoangNgay.Name = "grbKhoangNgay";
            this.grbKhoangNgay.Size = new System.Drawing.Size(368, 38);
            this.grbKhoangNgay.TabIndex = 147;
            this.grbKhoangNgay.TabStop = false;
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Location = new System.Drawing.Point(180, 14);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(35, 18);
            this.lblDenNgay.TabIndex = 147;
            this.lblDenNgay.Text = "Đến";
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Location = new System.Drawing.Point(5, 14);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(25, 18);
            this.lblTuNgay.TabIndex = 147;
            this.lblTuNgay.Text = "Từ";
            // 
            // rdoTheoKhoang
            // 
            this.rdoTheoKhoang.AutoSize = true;
            this.rdoTheoKhoang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTheoKhoang.Location = new System.Drawing.Point(457, 83);
            this.rdoTheoKhoang.Name = "rdoTheoKhoang";
            this.rdoTheoKhoang.Size = new System.Drawing.Size(120, 22);
            this.rdoTheoKhoang.TabIndex = 147;
            this.rdoTheoKhoang.TabStop = true;
            this.rdoTheoKhoang.Text = "Theo khoảng:";
            this.rdoTheoKhoang.UseVisualStyleBackColor = true;
            this.rdoTheoKhoang.CheckedChanged += new System.EventHandler(this.rdoTheoKhoang_CheckedChanged);
            // 
            // rdoTheoNgay
            // 
            this.rdoTheoNgay.AutoSize = true;
            this.rdoTheoNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTheoNgay.Location = new System.Drawing.Point(457, 36);
            this.rdoTheoNgay.Name = "rdoTheoNgay";
            this.rdoTheoNgay.Size = new System.Drawing.Size(102, 22);
            this.rdoTheoNgay.TabIndex = 146;
            this.rdoTheoNgay.TabStop = true;
            this.rdoTheoNgay.Text = "Theo ngày:";
            this.rdoTheoNgay.UseVisualStyleBackColor = true;
            this.rdoTheoNgay.CheckedChanged += new System.EventHandler(this.rdoTheoNgay_CheckedChanged);
            // 
            // frmTimKiemHDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 756);
            this.Controls.Add(this.labelChuthich);
            this.Controls.Add(this.gbxHoaDonBan);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnTimLai);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.dgvTimKiemHDB);
            this.Controls.Add(this.lblTKHoaDonBan);
            this.Name = "frmTimKiemHDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm Kiếm Hóa Đơn Bán";
            this.Load += new System.EventHandler(this.frmTimKiemHDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiemHDB)).EndInit();
            this.gbxHoaDonBan.ResumeLayout(false);
            this.gbxHoaDonBan.PerformLayout();
            this.grbKhoangNgay.ResumeLayout(false);
            this.grbKhoangNgay.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTKHoaDonBan;
        private System.Windows.Forms.Label lblMaNhanVien;
        private System.Windows.Forms.Label lblMaKhachHang;
        private System.Windows.Forms.Label lblMaHDB;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.DataGridView dgvTimKiemHDB;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnTimLai;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.GroupBox gbxHoaDonBan;
        private System.Windows.Forms.ComboBox cboMaKhachHang;
        private System.Windows.Forms.ComboBox cboMaNhanVien;
        private System.Windows.Forms.ComboBox cboMaHDB;
        private System.Windows.Forms.DateTimePicker dtpNgayBan;
        private System.Windows.Forms.Label labelChuthich;
        private System.Windows.Forms.DateTimePicker dtpNgayKT;
        private System.Windows.Forms.DateTimePicker dtpNgayBD;
        private System.Windows.Forms.RadioButton rdoTheoNgay;
        private System.Windows.Forms.GroupBox grbKhoangNgay;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.RadioButton rdoTheoKhoang;
    }
}