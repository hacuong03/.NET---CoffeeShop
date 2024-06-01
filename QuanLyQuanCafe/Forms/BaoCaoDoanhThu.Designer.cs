namespace QuanLyQuanCafe.Forms
{
    partial class frmBaoCaoDoanhThu
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
            this.btnInBaoCao = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtDoanhThu = new System.Windows.Forms.TextBox();
            this.lblDoanhThu = new System.Windows.Forms.Label();
            this.grbKhoangNgay = new System.Windows.Forms.GroupBox();
            this.mskTheoKhoang2 = new System.Windows.Forms.MaskedTextBox();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.mskTheoKhoang1 = new System.Windows.Forms.MaskedTextBox();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.lblBangChu = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.dgvBaoCaoDoanhThu = new System.Windows.Forms.DataGridView();
            this.mskTheoNgay = new System.Windows.Forms.MaskedTextBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.cboTenSP = new System.Windows.Forms.ComboBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.rdTheoKhoang = new System.Windows.Forms.RadioButton();
            this.rdTheoNgay = new System.Windows.Forms.RadioButton();
            this.lblGiaBan = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.grbThongTinTimKiem = new System.Windows.Forms.GroupBox();
            this.btnTimLai = new System.Windows.Forms.Button();
            this.lblBaoCaoDoanhThu = new System.Windows.Forms.Label();
            this.grbKhoangNgay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCaoDoanhThu)).BeginInit();
            this.grbThongTinTimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInBaoCao
            // 
            this.btnInBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInBaoCao.Location = new System.Drawing.Point(1070, 969);
            this.btnInBaoCao.Name = "btnInBaoCao";
            this.btnInBaoCao.Size = new System.Drawing.Size(113, 42);
            this.btnInBaoCao.TabIndex = 188;
            this.btnInBaoCao.Text = "In báo cáo";
            this.btnInBaoCao.UseVisualStyleBackColor = true;
            this.btnInBaoCao.Click += new System.EventHandler(this.btnInBaoCao_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(927, 203);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(97, 38);
            this.btnTimKiem.TabIndex = 181;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtDoanhThu
            // 
            this.txtDoanhThu.Location = new System.Drawing.Point(735, 155);
            this.txtDoanhThu.Name = "txtDoanhThu";
            this.txtDoanhThu.Size = new System.Drawing.Size(215, 24);
            this.txtDoanhThu.TabIndex = 180;
            this.txtDoanhThu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDoanhThu_KeyPress);
            // 
            // lblDoanhThu
            // 
            this.lblDoanhThu.AutoSize = true;
            this.lblDoanhThu.Location = new System.Drawing.Point(614, 158);
            this.lblDoanhThu.Name = "lblDoanhThu";
            this.lblDoanhThu.Size = new System.Drawing.Size(80, 18);
            this.lblDoanhThu.TabIndex = 173;
            this.lblDoanhThu.Text = "Doanh thu:";
            // 
            // grbKhoangNgay
            // 
            this.grbKhoangNgay.Controls.Add(this.mskTheoKhoang2);
            this.grbKhoangNgay.Controls.Add(this.lblDenNgay);
            this.grbKhoangNgay.Controls.Add(this.mskTheoKhoang1);
            this.grbKhoangNgay.Controls.Add(this.lblTuNgay);
            this.grbKhoangNgay.Location = new System.Drawing.Point(735, 85);
            this.grbKhoangNgay.Name = "grbKhoangNgay";
            this.grbKhoangNgay.Size = new System.Drawing.Size(363, 38);
            this.grbKhoangNgay.TabIndex = 175;
            this.grbKhoangNgay.TabStop = false;
            // 
            // mskTheoKhoang2
            // 
            this.mskTheoKhoang2.Location = new System.Drawing.Point(228, 11);
            this.mskTheoKhoang2.Mask = "00/00/0000";
            this.mskTheoKhoang2.Name = "mskTheoKhoang2";
            this.mskTheoKhoang2.Size = new System.Drawing.Size(130, 24);
            this.mskTheoKhoang2.TabIndex = 179;
            this.mskTheoKhoang2.ValidatingType = typeof(System.DateTime);
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Location = new System.Drawing.Point(181, 14);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(35, 18);
            this.lblDenNgay.TabIndex = 178;
            this.lblDenNgay.Text = "Đến";
            // 
            // mskTheoKhoang1
            // 
            this.mskTheoKhoang1.Location = new System.Drawing.Point(38, 11);
            this.mskTheoKhoang1.Mask = "00/00/0000";
            this.mskTheoKhoang1.Name = "mskTheoKhoang1";
            this.mskTheoKhoang1.Size = new System.Drawing.Size(130, 24);
            this.mskTheoKhoang1.TabIndex = 177;
            this.mskTheoKhoang1.ValidatingType = typeof(System.DateTime);
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Location = new System.Drawing.Point(6, 14);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(25, 18);
            this.lblTuNgay.TabIndex = 176;
            this.lblTuNgay.Text = "Từ";
            // 
            // lblBangChu
            // 
            this.lblBangChu.AutoSize = true;
            this.lblBangChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBangChu.Location = new System.Drawing.Point(41, 941);
            this.lblBangChu.Name = "lblBangChu";
            this.lblBangChu.Size = new System.Drawing.Size(85, 20);
            this.lblBangChu.TabIndex = 186;
            this.lblBangChu.Text = "Bằng chữ:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(141, 894);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(202, 27);
            this.txtTongTien.TabIndex = 185;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(41, 897);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(83, 20);
            this.lblTongTien.TabIndex = 184;
            this.lblTongTien.Text = "Tổng tiền:";
            // 
            // dgvBaoCaoDoanhThu
            // 
            this.dgvBaoCaoDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaoCaoDoanhThu.Location = new System.Drawing.Point(30, 365);
            this.dgvBaoCaoDoanhThu.Name = "dgvBaoCaoDoanhThu";
            this.dgvBaoCaoDoanhThu.RowHeadersWidth = 51;
            this.dgvBaoCaoDoanhThu.RowTemplate.Height = 24;
            this.dgvBaoCaoDoanhThu.Size = new System.Drawing.Size(1153, 504);
            this.dgvBaoCaoDoanhThu.TabIndex = 183;
            this.dgvBaoCaoDoanhThu.Click += new System.EventHandler(this.dgvBaoCaoDoanhThu_Click);
            // 
            // mskTheoNgay
            // 
            this.mskTheoNgay.Location = new System.Drawing.Point(735, 37);
            this.mskTheoNgay.Mask = "00/00/0000";
            this.mskTheoNgay.Name = "mskTheoNgay";
            this.mskTheoNgay.Size = new System.Drawing.Size(130, 24);
            this.mskTheoNgay.TabIndex = 174;
            this.mskTheoNgay.ValidatingType = typeof(System.DateTime);
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(172, 155);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(215, 24);
            this.txtGiaBan.TabIndex = 170;
            this.txtGiaBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaBan_KeyPress);
            // 
            // cboTenSP
            // 
            this.cboTenSP.FormattingEnabled = true;
            this.cboTenSP.Location = new System.Drawing.Point(172, 37);
            this.cboTenSP.Name = "cboTenSP";
            this.cboTenSP.Size = new System.Drawing.Size(215, 26);
            this.cboTenSP.TabIndex = 168;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(172, 96);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(215, 24);
            this.txtSoLuong.TabIndex = 169;
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // rdTheoKhoang
            // 
            this.rdTheoKhoang.AutoSize = true;
            this.rdTheoKhoang.Location = new System.Drawing.Point(617, 97);
            this.rdTheoKhoang.Name = "rdTheoKhoang";
            this.rdTheoKhoang.Size = new System.Drawing.Size(120, 22);
            this.rdTheoKhoang.TabIndex = 172;
            this.rdTheoKhoang.TabStop = true;
            this.rdTheoKhoang.Text = "Theo khoảng:";
            this.rdTheoKhoang.UseVisualStyleBackColor = true;
            this.rdTheoKhoang.CheckedChanged += new System.EventHandler(this.rdTheoKhoang_CheckedChanged);
            // 
            // rdTheoNgay
            // 
            this.rdTheoNgay.AutoSize = true;
            this.rdTheoNgay.Location = new System.Drawing.Point(617, 38);
            this.rdTheoNgay.Name = "rdTheoNgay";
            this.rdTheoNgay.Size = new System.Drawing.Size(102, 22);
            this.rdTheoNgay.TabIndex = 171;
            this.rdTheoNgay.TabStop = true;
            this.rdTheoNgay.Text = "Theo ngày:";
            this.rdTheoNgay.UseVisualStyleBackColor = true;
            this.rdTheoNgay.CheckedChanged += new System.EventHandler(this.rdTheoNgay_CheckedChanged);
            // 
            // lblGiaBan
            // 
            this.lblGiaBan.AutoSize = true;
            this.lblGiaBan.Location = new System.Drawing.Point(51, 158);
            this.lblGiaBan.Name = "lblGiaBan";
            this.lblGiaBan.Size = new System.Drawing.Size(63, 18);
            this.lblGiaBan.TabIndex = 167;
            this.lblGiaBan.Text = "Giá bán:";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(51, 99);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(71, 18);
            this.lblSoLuong.TabIndex = 166;
            this.lblSoLuong.Text = "Số lượng:";
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Location = new System.Drawing.Point(51, 40);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(106, 18);
            this.lblTenSP.TabIndex = 165;
            this.lblTenSP.Text = "Tên sản phẩm:";
            // 
            // btnHienThi
            // 
            this.btnHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThi.Location = new System.Drawing.Point(938, 969);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(113, 42);
            this.btnHienThi.TabIndex = 187;
            this.btnHienThi.Text = "Hiển thị";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // grbThongTinTimKiem
            // 
            this.grbThongTinTimKiem.Controls.Add(this.btnTimLai);
            this.grbThongTinTimKiem.Controls.Add(this.btnTimKiem);
            this.grbThongTinTimKiem.Controls.Add(this.txtDoanhThu);
            this.grbThongTinTimKiem.Controls.Add(this.lblDoanhThu);
            this.grbThongTinTimKiem.Controls.Add(this.grbKhoangNgay);
            this.grbThongTinTimKiem.Controls.Add(this.mskTheoNgay);
            this.grbThongTinTimKiem.Controls.Add(this.txtGiaBan);
            this.grbThongTinTimKiem.Controls.Add(this.cboTenSP);
            this.grbThongTinTimKiem.Controls.Add(this.txtSoLuong);
            this.grbThongTinTimKiem.Controls.Add(this.rdTheoKhoang);
            this.grbThongTinTimKiem.Controls.Add(this.rdTheoNgay);
            this.grbThongTinTimKiem.Controls.Add(this.lblGiaBan);
            this.grbThongTinTimKiem.Controls.Add(this.lblSoLuong);
            this.grbThongTinTimKiem.Controls.Add(this.lblTenSP);
            this.grbThongTinTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThongTinTimKiem.Location = new System.Drawing.Point(30, 81);
            this.grbThongTinTimKiem.Name = "grbThongTinTimKiem";
            this.grbThongTinTimKiem.Size = new System.Drawing.Size(1153, 262);
            this.grbThongTinTimKiem.TabIndex = 164;
            this.grbThongTinTimKiem.TabStop = false;
            this.grbThongTinTimKiem.Text = "Thông tin tìm kiếm";
            // 
            // btnTimLai
            // 
            this.btnTimLai.Location = new System.Drawing.Point(1040, 203);
            this.btnTimLai.Name = "btnTimLai";
            this.btnTimLai.Size = new System.Drawing.Size(89, 38);
            this.btnTimLai.TabIndex = 182;
            this.btnTimLai.Text = "Tìm lại";
            this.btnTimLai.UseVisualStyleBackColor = true;
            this.btnTimLai.Click += new System.EventHandler(this.btnTimLai_Click);
            // 
            // lblBaoCaoDoanhThu
            // 
            this.lblBaoCaoDoanhThu.AutoSize = true;
            this.lblBaoCaoDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaoCaoDoanhThu.Location = new System.Drawing.Point(435, 33);
            this.lblBaoCaoDoanhThu.Name = "lblBaoCaoDoanhThu";
            this.lblBaoCaoDoanhThu.Size = new System.Drawing.Size(331, 32);
            this.lblBaoCaoDoanhThu.TabIndex = 163;
            this.lblBaoCaoDoanhThu.Text = "BÁO CÁO DOANH THU";
            // 
            // frmBaoCaoDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1210, 1055);
            this.Controls.Add(this.btnInBaoCao);
            this.Controls.Add(this.lblBangChu);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.dgvBaoCaoDoanhThu);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.grbThongTinTimKiem);
            this.Controls.Add(this.lblBaoCaoDoanhThu);
            this.Name = "frmBaoCaoDoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo Cáo Doanh Thu";
            this.Load += new System.EventHandler(this.frmBaoCaoDoanhThu_Load);
            this.grbKhoangNgay.ResumeLayout(false);
            this.grbKhoangNgay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCaoDoanhThu)).EndInit();
            this.grbThongTinTimKiem.ResumeLayout(false);
            this.grbThongTinTimKiem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnInBaoCao;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtDoanhThu;
        private System.Windows.Forms.Label lblDoanhThu;
        private System.Windows.Forms.GroupBox grbKhoangNgay;
        private System.Windows.Forms.MaskedTextBox mskTheoKhoang2;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.MaskedTextBox mskTheoKhoang1;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.Label lblBangChu;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.DataGridView dgvBaoCaoDoanhThu;
        private System.Windows.Forms.MaskedTextBox mskTheoNgay;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.ComboBox cboTenSP;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.RadioButton rdTheoKhoang;
        private System.Windows.Forms.RadioButton rdTheoNgay;
        private System.Windows.Forms.Label lblGiaBan;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.GroupBox grbThongTinTimKiem;
        private System.Windows.Forms.Label lblBaoCaoDoanhThu;
        private System.Windows.Forms.Button btnTimLai;
    }
}