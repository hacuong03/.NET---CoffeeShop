namespace QuanLyQuanCafe.Forms
{
    partial class frmBaoCaoHDB
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
            this.maskNgay = new System.Windows.Forms.MaskedTextBox();
            this.buttonInBC = new System.Windows.Forms.Button();
            this.dataGridViewSanpham = new System.Windows.Forms.DataGridView();
            this.dataGridViewHoadon = new System.Windows.Forms.DataGridView();
            this.buttonTimkiem = new System.Windows.Forms.Button();
            this.comboMaNV = new System.Windows.Forms.ComboBox();
            this.comboMaKH = new System.Windows.Forms.ComboBox();
            this.labelTenNV = new System.Windows.Forms.Label();
            this.labelKH = new System.Windows.Forms.Label();
            this.comboMaSP = new System.Windows.Forms.ComboBox();
            this.labelTenSP = new System.Windows.Forms.Label();
            this.comboMaHD = new System.Windows.Forms.ComboBox();
            this.labelMaHD = new System.Windows.Forms.Label();
            this.buttonDong = new System.Windows.Forms.Button();
            this.groupThongtinhoadon = new System.Windows.Forms.GroupBox();
            this.groupKhoangngay = new System.Windows.Forms.GroupBox();
            this.maskedNgaykt = new System.Windows.Forms.MaskedTextBox();
            this.labelNgaykt = new System.Windows.Forms.Label();
            this.maskedNgaybd = new System.Windows.Forms.MaskedTextBox();
            this.labelNgaybd = new System.Windows.Forms.Label();
            this.radioKhoang = new System.Windows.Forms.RadioButton();
            this.radioNgay = new System.Windows.Forms.RadioButton();
            this.buttonTimlai = new System.Windows.Forms.Button();
            this.labelHDB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSanpham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoadon)).BeginInit();
            this.groupThongtinhoadon.SuspendLayout();
            this.groupKhoangngay.SuspendLayout();
            this.SuspendLayout();
            // 
            // maskNgay
            // 
            this.maskNgay.Location = new System.Drawing.Point(885, 39);
            this.maskNgay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskNgay.Mask = "00/00/0000";
            this.maskNgay.Name = "maskNgay";
            this.maskNgay.Size = new System.Drawing.Size(156, 24);
            this.maskNgay.TabIndex = 277;
            this.maskNgay.ValidatingType = typeof(System.DateTime);
            // 
            // buttonInBC
            // 
            this.buttonInBC.Location = new System.Drawing.Point(1132, 736);
            this.buttonInBC.Name = "buttonInBC";
            this.buttonInBC.Size = new System.Drawing.Size(113, 43);
            this.buttonInBC.TabIndex = 283;
            this.buttonInBC.Text = "In";
            this.buttonInBC.UseVisualStyleBackColor = true;
            this.buttonInBC.Click += new System.EventHandler(this.buttonInBC_Click);
            // 
            // dataGridViewSanpham
            // 
            this.dataGridViewSanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSanpham.Location = new System.Drawing.Point(964, 293);
            this.dataGridViewSanpham.Name = "dataGridViewSanpham";
            this.dataGridViewSanpham.RowHeadersWidth = 62;
            this.dataGridViewSanpham.RowTemplate.Height = 24;
            this.dataGridViewSanpham.Size = new System.Drawing.Size(402, 415);
            this.dataGridViewSanpham.TabIndex = 282;
            // 
            // dataGridViewHoadon
            // 
            this.dataGridViewHoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHoadon.Location = new System.Drawing.Point(50, 293);
            this.dataGridViewHoadon.Name = "dataGridViewHoadon";
            this.dataGridViewHoadon.RowHeadersWidth = 62;
            this.dataGridViewHoadon.RowTemplate.Height = 24;
            this.dataGridViewHoadon.Size = new System.Drawing.Size(887, 415);
            this.dataGridViewHoadon.TabIndex = 281;
            // 
            // buttonTimkiem
            // 
            this.buttonTimkiem.Location = new System.Drawing.Point(1079, 141);
            this.buttonTimkiem.Name = "buttonTimkiem";
            this.buttonTimkiem.Size = new System.Drawing.Size(89, 37);
            this.buttonTimkiem.TabIndex = 280;
            this.buttonTimkiem.Text = "Tìm kiếm";
            this.buttonTimkiem.UseVisualStyleBackColor = true;
            this.buttonTimkiem.Click += new System.EventHandler(this.buttonTimkiem_Click);
            // 
            // comboMaNV
            // 
            this.comboMaNV.FormattingEnabled = true;
            this.comboMaNV.Location = new System.Drawing.Point(520, 94);
            this.comboMaNV.Name = "comboMaNV";
            this.comboMaNV.Size = new System.Drawing.Size(162, 26);
            this.comboMaNV.TabIndex = 276;
            // 
            // comboMaKH
            // 
            this.comboMaKH.FormattingEnabled = true;
            this.comboMaKH.Location = new System.Drawing.Point(520, 39);
            this.comboMaKH.Name = "comboMaKH";
            this.comboMaKH.Size = new System.Drawing.Size(162, 26);
            this.comboMaKH.TabIndex = 275;
            // 
            // labelTenNV
            // 
            this.labelTenNV.Location = new System.Drawing.Point(384, 97);
            this.labelTenNV.Name = "labelTenNV";
            this.labelTenNV.Size = new System.Drawing.Size(101, 18);
            this.labelTenNV.TabIndex = 269;
            this.labelTenNV.Text = "Mã nhân viên";
            // 
            // labelKH
            // 
            this.labelKH.Location = new System.Drawing.Point(384, 42);
            this.labelKH.Name = "labelKH";
            this.labelKH.Size = new System.Drawing.Size(121, 17);
            this.labelKH.TabIndex = 268;
            this.labelKH.Text = "Mã khách hàng";
            // 
            // comboMaSP
            // 
            this.comboMaSP.FormattingEnabled = true;
            this.comboMaSP.Location = new System.Drawing.Point(177, 94);
            this.comboMaSP.Name = "comboMaSP";
            this.comboMaSP.Size = new System.Drawing.Size(156, 26);
            this.comboMaSP.TabIndex = 274;
            // 
            // labelTenSP
            // 
            this.labelTenSP.Location = new System.Drawing.Point(55, 97);
            this.labelTenSP.Name = "labelTenSP";
            this.labelTenSP.Size = new System.Drawing.Size(101, 18);
            this.labelTenSP.TabIndex = 267;
            this.labelTenSP.Text = "Mã sản phẩm";
            // 
            // comboMaHD
            // 
            this.comboMaHD.FormattingEnabled = true;
            this.comboMaHD.Location = new System.Drawing.Point(177, 39);
            this.comboMaHD.Name = "comboMaHD";
            this.comboMaHD.Size = new System.Drawing.Size(156, 26);
            this.comboMaHD.TabIndex = 273;
            // 
            // labelMaHD
            // 
            this.labelMaHD.Location = new System.Drawing.Point(55, 42);
            this.labelMaHD.Name = "labelMaHD";
            this.labelMaHD.Size = new System.Drawing.Size(101, 18);
            this.labelMaHD.TabIndex = 266;
            this.labelMaHD.Text = "Mã hóa đơn";
            // 
            // buttonDong
            // 
            this.buttonDong.Location = new System.Drawing.Point(1272, 736);
            this.buttonDong.Name = "buttonDong";
            this.buttonDong.Size = new System.Drawing.Size(94, 43);
            this.buttonDong.TabIndex = 284;
            this.buttonDong.Text = "Đóng";
            this.buttonDong.UseVisualStyleBackColor = true;
            this.buttonDong.Click += new System.EventHandler(this.buttonDong_Click);
            // 
            // groupThongtinhoadon
            // 
            this.groupThongtinhoadon.Controls.Add(this.groupKhoangngay);
            this.groupThongtinhoadon.Controls.Add(this.radioKhoang);
            this.groupThongtinhoadon.Controls.Add(this.radioNgay);
            this.groupThongtinhoadon.Controls.Add(this.buttonTimlai);
            this.groupThongtinhoadon.Controls.Add(this.maskNgay);
            this.groupThongtinhoadon.Controls.Add(this.buttonTimkiem);
            this.groupThongtinhoadon.Controls.Add(this.comboMaNV);
            this.groupThongtinhoadon.Controls.Add(this.comboMaKH);
            this.groupThongtinhoadon.Controls.Add(this.labelTenNV);
            this.groupThongtinhoadon.Controls.Add(this.labelKH);
            this.groupThongtinhoadon.Controls.Add(this.comboMaSP);
            this.groupThongtinhoadon.Controls.Add(this.labelTenSP);
            this.groupThongtinhoadon.Controls.Add(this.comboMaHD);
            this.groupThongtinhoadon.Controls.Add(this.labelMaHD);
            this.groupThongtinhoadon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupThongtinhoadon.Location = new System.Drawing.Point(50, 79);
            this.groupThongtinhoadon.Name = "groupThongtinhoadon";
            this.groupThongtinhoadon.Size = new System.Drawing.Size(1316, 193);
            this.groupThongtinhoadon.TabIndex = 265;
            this.groupThongtinhoadon.TabStop = false;
            this.groupThongtinhoadon.Text = "Thông tin hóa đơn";
            // 
            // groupKhoangngay
            // 
            this.groupKhoangngay.Controls.Add(this.maskedNgaykt);
            this.groupKhoangngay.Controls.Add(this.labelNgaykt);
            this.groupKhoangngay.Controls.Add(this.maskedNgaybd);
            this.groupKhoangngay.Controls.Add(this.labelNgaybd);
            this.groupKhoangngay.Location = new System.Drawing.Point(885, 83);
            this.groupKhoangngay.Name = "groupKhoangngay";
            this.groupKhoangngay.Size = new System.Drawing.Size(363, 38);
            this.groupKhoangngay.TabIndex = 272;
            this.groupKhoangngay.TabStop = false;
            // 
            // maskedNgaykt
            // 
            this.maskedNgaykt.Location = new System.Drawing.Point(228, 11);
            this.maskedNgaykt.Mask = "00/00/0000";
            this.maskedNgaykt.Name = "maskedNgaykt";
            this.maskedNgaykt.Size = new System.Drawing.Size(130, 24);
            this.maskedNgaykt.TabIndex = 279;
            this.maskedNgaykt.ValidatingType = typeof(System.DateTime);
            // 
            // labelNgaykt
            // 
            this.labelNgaykt.AutoSize = true;
            this.labelNgaykt.Location = new System.Drawing.Point(181, 14);
            this.labelNgaykt.Name = "labelNgaykt";
            this.labelNgaykt.Size = new System.Drawing.Size(32, 18);
            this.labelNgaykt.TabIndex = 272;
            this.labelNgaykt.Text = "đến";
            // 
            // maskedNgaybd
            // 
            this.maskedNgaybd.Location = new System.Drawing.Point(38, 11);
            this.maskedNgaybd.Mask = "00/00/0000";
            this.maskedNgaybd.Name = "maskedNgaybd";
            this.maskedNgaybd.Size = new System.Drawing.Size(130, 24);
            this.maskedNgaybd.TabIndex = 278;
            this.maskedNgaybd.ValidatingType = typeof(System.DateTime);
            // 
            // labelNgaybd
            // 
            this.labelNgaybd.AutoSize = true;
            this.labelNgaybd.Location = new System.Drawing.Point(6, 14);
            this.labelNgaybd.Name = "labelNgaybd";
            this.labelNgaybd.Size = new System.Drawing.Size(25, 18);
            this.labelNgaybd.TabIndex = 272;
            this.labelNgaybd.Text = "Từ";
            // 
            // radioKhoang
            // 
            this.radioKhoang.AutoSize = true;
            this.radioKhoang.Location = new System.Drawing.Point(750, 95);
            this.radioKhoang.Name = "radioKhoang";
            this.radioKhoang.Size = new System.Drawing.Size(120, 22);
            this.radioKhoang.TabIndex = 271;
            this.radioKhoang.TabStop = true;
            this.radioKhoang.Text = "Theo khoảng:";
            this.radioKhoang.UseVisualStyleBackColor = true;
            this.radioKhoang.CheckedChanged += new System.EventHandler(this.radioKhoang_CheckedChanged);
            // 
            // radioNgay
            // 
            this.radioNgay.AutoSize = true;
            this.radioNgay.Location = new System.Drawing.Point(750, 40);
            this.radioNgay.Name = "radioNgay";
            this.radioNgay.Size = new System.Drawing.Size(102, 22);
            this.radioNgay.TabIndex = 270;
            this.radioNgay.TabStop = true;
            this.radioNgay.Text = "Theo ngày:";
            this.radioNgay.UseVisualStyleBackColor = true;
            this.radioNgay.CheckedChanged += new System.EventHandler(this.radioNgay_CheckedChanged);
            // 
            // buttonTimlai
            // 
            this.buttonTimlai.Location = new System.Drawing.Point(1197, 141);
            this.buttonTimlai.Name = "buttonTimlai";
            this.buttonTimlai.Size = new System.Drawing.Size(89, 37);
            this.buttonTimlai.TabIndex = 285;
            this.buttonTimlai.Text = "Tìm lại";
            this.buttonTimlai.UseVisualStyleBackColor = true;
            this.buttonTimlai.Click += new System.EventHandler(this.buttonTimlai_Click);
            // 
            // labelHDB
            // 
            this.labelHDB.AutoSize = true;
            this.labelHDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHDB.Location = new System.Drawing.Point(475, 33);
            this.labelHDB.Name = "labelHDB";
            this.labelHDB.Size = new System.Drawing.Size(456, 32);
            this.labelHDB.TabIndex = 264;
            this.labelHDB.Text = "BÁO CÁO HÓA ĐƠN BÁN HÀNG";
            // 
            // frmBaoCaoHDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1413, 814);
            this.Controls.Add(this.labelHDB);
            this.Controls.Add(this.buttonInBC);
            this.Controls.Add(this.dataGridViewSanpham);
            this.Controls.Add(this.dataGridViewHoadon);
            this.Controls.Add(this.buttonDong);
            this.Controls.Add(this.groupThongtinhoadon);
            this.Name = "frmBaoCaoHDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo Cáo Hóa Đơn Bán";
            this.Load += new System.EventHandler(this.frmBaoCaoHDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSanpham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoadon)).EndInit();
            this.groupThongtinhoadon.ResumeLayout(false);
            this.groupThongtinhoadon.PerformLayout();
            this.groupKhoangngay.ResumeLayout(false);
            this.groupKhoangngay.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox maskNgay;
        private System.Windows.Forms.Button buttonInBC;
        private System.Windows.Forms.DataGridView dataGridViewSanpham;
        private System.Windows.Forms.DataGridView dataGridViewHoadon;
        private System.Windows.Forms.Button buttonTimkiem;
        private System.Windows.Forms.ComboBox comboMaNV;
        private System.Windows.Forms.ComboBox comboMaKH;
        private System.Windows.Forms.Label labelTenNV;
        private System.Windows.Forms.Label labelKH;
        private System.Windows.Forms.ComboBox comboMaSP;
        private System.Windows.Forms.Label labelTenSP;
        private System.Windows.Forms.ComboBox comboMaHD;
        private System.Windows.Forms.Label labelMaHD;
        private System.Windows.Forms.Button buttonDong;
        private System.Windows.Forms.GroupBox groupThongtinhoadon;
        private System.Windows.Forms.Label labelHDB;
        private System.Windows.Forms.Button buttonTimlai;
        private System.Windows.Forms.RadioButton radioNgay;
        private System.Windows.Forms.GroupBox groupKhoangngay;
        private System.Windows.Forms.MaskedTextBox maskedNgaykt;
        private System.Windows.Forms.Label labelNgaykt;
        private System.Windows.Forms.MaskedTextBox maskedNgaybd;
        private System.Windows.Forms.Label labelNgaybd;
        private System.Windows.Forms.RadioButton radioKhoang;
    }
}