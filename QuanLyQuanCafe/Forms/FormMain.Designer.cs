namespace QuanLyQuanCafe
{
    partial class frmMain
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
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBCHoaDonNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBCHoaDonBan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBCDoanhThu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTKHoaDonBan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTKHoaDonNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoaDonNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoaDonBan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhaCungCap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCongDung = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoaiSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLQuanCafe = new System.Windows.Forms.MenuStrip();
            this.mnuQLQuanCafe.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuThoat
            // 
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(61, 24);
            this.mnuThoat.Text = "Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // mnuBaoCao
            // 
            this.mnuBaoCao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBCHoaDonNhap,
            this.mnuBCHoaDonBan,
            this.mnuBCDoanhThu});
            this.mnuBaoCao.Name = "mnuBaoCao";
            this.mnuBaoCao.Size = new System.Drawing.Size(77, 24);
            this.mnuBaoCao.Text = "Báo cáo";
            // 
            // mnuBCHoaDonNhap
            // 
            this.mnuBCHoaDonNhap.Name = "mnuBCHoaDonNhap";
            this.mnuBCHoaDonNhap.Size = new System.Drawing.Size(224, 26);
            this.mnuBCHoaDonNhap.Text = "Hóa đơn nhập";
            this.mnuBCHoaDonNhap.Click += new System.EventHandler(this.mnuBCHoaDonNhap_Click);
            // 
            // mnuBCHoaDonBan
            // 
            this.mnuBCHoaDonBan.Name = "mnuBCHoaDonBan";
            this.mnuBCHoaDonBan.Size = new System.Drawing.Size(187, 26);
            this.mnuBCHoaDonBan.Text = "Hóa đơn bán";
            this.mnuBCHoaDonBan.Click += new System.EventHandler(this.mnuBCHoaDonBan_Click);
            // 
            // mnuBCDoanhThu
            // 
            this.mnuBCDoanhThu.Name = "mnuBCDoanhThu";
            this.mnuBCDoanhThu.Size = new System.Drawing.Size(224, 26);
            this.mnuBCDoanhThu.Text = "Doanh thu";
            this.mnuBCDoanhThu.Click += new System.EventHandler(this.mnuBCDoanhThu_Click);
            // 
            // mnuTKHoaDonBan
            // 
            this.mnuTKHoaDonBan.Name = "mnuTKHoaDonBan";
            this.mnuTKHoaDonBan.Size = new System.Drawing.Size(187, 26);
            this.mnuTKHoaDonBan.Text = "Hóa đơn bán";
            this.mnuTKHoaDonBan.Click += new System.EventHandler(this.mnuTKHoaDonBan_Click);
            // 
            // mnuTimKiem
            // 
            this.mnuTimKiem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTKHoaDonNhap,
            this.mnuTKHoaDonBan});
            this.mnuTimKiem.Name = "mnuTimKiem";
            this.mnuTimKiem.Size = new System.Drawing.Size(84, 24);
            this.mnuTimKiem.Text = "Tìm kiếm";
            // 
            // mnuTKHoaDonNhap
            // 
            this.mnuTKHoaDonNhap.Name = "mnuTKHoaDonNhap";
            this.mnuTKHoaDonNhap.Size = new System.Drawing.Size(187, 26);
            this.mnuTKHoaDonNhap.Text = "Hóa đơn nhập";
            this.mnuTKHoaDonNhap.Click += new System.EventHandler(this.mnuTKHoaDonNhap_Click);
            // 
            // mnuHoaDon
            // 
            this.mnuHoaDon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHoaDonNhap,
            this.mnuHoaDonBan});
            this.mnuHoaDon.Name = "mnuHoaDon";
            this.mnuHoaDon.Size = new System.Drawing.Size(81, 24);
            this.mnuHoaDon.Text = "Hóa đơn";
            // 
            // mnuHoaDonNhap
            // 
            this.mnuHoaDonNhap.Name = "mnuHoaDonNhap";
            this.mnuHoaDonNhap.Size = new System.Drawing.Size(224, 26);
            this.mnuHoaDonNhap.Text = "Hóa đơn nhập";
            this.mnuHoaDonNhap.Click += new System.EventHandler(this.mnuHoaDonNhap_Click);
            // 
            // mnuHoaDonBan
            // 
            this.mnuHoaDonBan.Name = "mnuHoaDonBan";
            this.mnuHoaDonBan.Size = new System.Drawing.Size(187, 26);
            this.mnuHoaDonBan.Text = "Hóa đơn bán";
            this.mnuHoaDonBan.Click += new System.EventHandler(this.mnuHoaDonBan_Click);
            // 
            // mnuNhaCungCap
            // 
            this.mnuNhaCungCap.Name = "mnuNhaCungCap";
            this.mnuNhaCungCap.Size = new System.Drawing.Size(183, 26);
            this.mnuNhaCungCap.Text = "Nhà cung cấp";
            this.mnuNhaCungCap.Click += new System.EventHandler(this.mnuNhaCungCap_Click);
            // 
            // mnuKhachHang
            // 
            this.mnuKhachHang.Name = "mnuKhachHang";
            this.mnuKhachHang.Size = new System.Drawing.Size(183, 26);
            this.mnuKhachHang.Text = "Khách hàng";
            this.mnuKhachHang.Click += new System.EventHandler(this.mnuKhachHang_Click);
            // 
            // mnuNhanVien
            // 
            this.mnuNhanVien.Name = "mnuNhanVien";
            this.mnuNhanVien.Size = new System.Drawing.Size(183, 26);
            this.mnuNhanVien.Text = "Nhân viên";
            this.mnuNhanVien.Click += new System.EventHandler(this.mnuNhanVien_Click);
            // 
            // mnuSanPham
            // 
            this.mnuSanPham.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCongDung,
            this.mnuLoaiSanPham});
            this.mnuSanPham.Name = "mnuSanPham";
            this.mnuSanPham.Size = new System.Drawing.Size(183, 26);
            this.mnuSanPham.Text = "Sản phẩm";
            this.mnuSanPham.Click += new System.EventHandler(this.mnuSanPham_Click);
            // 
            // mnuCongDung
            // 
            this.mnuCongDung.Name = "mnuCongDung";
            this.mnuCongDung.Size = new System.Drawing.Size(188, 26);
            this.mnuCongDung.Text = "Công dụng";
            this.mnuCongDung.Click += new System.EventHandler(this.mnuCongDung_Click);
            // 
            // mnuLoaiSanPham
            // 
            this.mnuLoaiSanPham.Name = "mnuLoaiSanPham";
            this.mnuLoaiSanPham.Size = new System.Drawing.Size(188, 26);
            this.mnuLoaiSanPham.Text = "Loại sản phẩm";
            this.mnuLoaiSanPham.Click += new System.EventHandler(this.mnuLoaiSanPham_Click);
            // 
            // mnuDanhMuc
            // 
            this.mnuDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSanPham,
            this.mnuNhanVien,
            this.mnuKhachHang,
            this.mnuNhaCungCap});
            this.mnuDanhMuc.Name = "mnuDanhMuc";
            this.mnuDanhMuc.Size = new System.Drawing.Size(90, 24);
            this.mnuDanhMuc.Text = "Danh mục";
            // 
            // mnuQLQuanCafe
            // 
            this.mnuQLQuanCafe.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuQLQuanCafe.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDanhMuc,
            this.mnuHoaDon,
            this.mnuTimKiem,
            this.mnuBaoCao,
            this.mnuThoat});
            this.mnuQLQuanCafe.Location = new System.Drawing.Point(0, 0);
            this.mnuQLQuanCafe.Name = "mnuQLQuanCafe";
            this.mnuQLQuanCafe.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.mnuQLQuanCafe.Size = new System.Drawing.Size(800, 28);
            this.mnuQLQuanCafe.TabIndex = 1;
            this.mnuQLQuanCafe.Text = "Menu Quản Lý Quán Cafe";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnuQLQuanCafe);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Quán Cafe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnuQLQuanCafe.ResumeLayout(false);
            this.mnuQLQuanCafe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ToolStripMenuItem mnuBaoCao;
        private System.Windows.Forms.ToolStripMenuItem mnuTKHoaDonBan;
        private System.Windows.Forms.ToolStripMenuItem mnuTimKiem;
        private System.Windows.Forms.ToolStripMenuItem mnuHoaDon;
        private System.Windows.Forms.ToolStripMenuItem mnuHoaDonBan;
        private System.Windows.Forms.ToolStripMenuItem mnuNhaCungCap;
        private System.Windows.Forms.ToolStripMenuItem mnuKhachHang;
        private System.Windows.Forms.ToolStripMenuItem mnuNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnuSanPham;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhMuc;
        private System.Windows.Forms.MenuStrip mnuQLQuanCafe;
        private System.Windows.Forms.ToolStripMenuItem mnuCongDung;
        private System.Windows.Forms.ToolStripMenuItem mnuLoaiSanPham;
        private System.Windows.Forms.ToolStripMenuItem mnuHoaDonNhap;
        private System.Windows.Forms.ToolStripMenuItem mnuTKHoaDonNhap;
        private System.Windows.Forms.ToolStripMenuItem mnuBCHoaDonBan;
        private System.Windows.Forms.ToolStripMenuItem mnuBCHoaDonNhap;
        private System.Windows.Forms.ToolStripMenuItem mnuBCDoanhThu;
    }
}

