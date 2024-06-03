namespace QuanLyQuanCafe.Forms
{
    partial class frmBaoCaoHDN
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
            this.labelHDN = new System.Windows.Forms.Label();
            this.buttonDong = new System.Windows.Forms.Button();
            this.gbxThongtin = new System.Windows.Forms.GroupBox();
            this.groupKhoangngay = new System.Windows.Forms.GroupBox();
            this.maskedNgaykt = new System.Windows.Forms.MaskedTextBox();
            this.labelNgaykt = new System.Windows.Forms.Label();
            this.maskedNgaybd = new System.Windows.Forms.MaskedTextBox();
            this.labelNgaybd = new System.Windows.Forms.Label();
            this.radioKhoang = new System.Windows.Forms.RadioButton();
            this.radioNgay = new System.Windows.Forms.RadioButton();
            this.maskNgay = new System.Windows.Forms.MaskedTextBox();
            this.buttonTimlai = new System.Windows.Forms.Button();
            this.textDongianhap = new System.Windows.Forms.TextBox();
            this.labelDongianhap = new System.Windows.Forms.Label();
            this.buttonTimkiem = new System.Windows.Forms.Button();
            this.comboMaNV = new System.Windows.Forms.ComboBox();
            this.comboMaNCC = new System.Windows.Forms.ComboBox();
            this.labelTenNV = new System.Windows.Forms.Label();
            this.labelNCC = new System.Windows.Forms.Label();
            this.comboMaSP = new System.Windows.Forms.ComboBox();
            this.labelTenSP = new System.Windows.Forms.Label();
            this.comboMaHD = new System.Windows.Forms.ComboBox();
            this.labelMaHD = new System.Windows.Forms.Label();
            this.buttonInBC = new System.Windows.Forms.Button();
            this.dataGridViewSanpham = new System.Windows.Forms.DataGridView();
            this.dataGridViewHoadon = new System.Windows.Forms.DataGridView();
            this.gbxThongtin.SuspendLayout();
            this.groupKhoangngay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSanpham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHDN
            // 
            this.labelHDN.AutoSize = true;
            this.labelHDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHDN.Location = new System.Drawing.Point(473, 37);
            this.labelHDN.Name = "labelHDN";
            this.labelHDN.Size = new System.Drawing.Size(477, 32);
            this.labelHDN.TabIndex = 241;
            this.labelHDN.Text = "BÁO CÁO HÓA ĐƠN NHẬP HÀNG";
            // 
            // buttonDong
            // 
            this.buttonDong.Location = new System.Drawing.Point(1270, 776);
            this.buttonDong.Name = "buttonDong";
            this.buttonDong.Size = new System.Drawing.Size(94, 43);
            this.buttonDong.TabIndex = 261;
            this.buttonDong.Text = "Đóng";
            this.buttonDong.UseVisualStyleBackColor = true;
            this.buttonDong.Click += new System.EventHandler(this.buttonDong_Click);
            // 
            // gbxThongtin
            // 
            this.gbxThongtin.Controls.Add(this.groupKhoangngay);
            this.gbxThongtin.Controls.Add(this.radioKhoang);
            this.gbxThongtin.Controls.Add(this.radioNgay);
            this.gbxThongtin.Controls.Add(this.maskNgay);
            this.gbxThongtin.Controls.Add(this.buttonTimlai);
            this.gbxThongtin.Controls.Add(this.textDongianhap);
            this.gbxThongtin.Controls.Add(this.labelDongianhap);
            this.gbxThongtin.Controls.Add(this.buttonTimkiem);
            this.gbxThongtin.Controls.Add(this.comboMaNV);
            this.gbxThongtin.Controls.Add(this.comboMaNCC);
            this.gbxThongtin.Controls.Add(this.labelTenNV);
            this.gbxThongtin.Controls.Add(this.labelNCC);
            this.gbxThongtin.Controls.Add(this.comboMaSP);
            this.gbxThongtin.Controls.Add(this.labelTenSP);
            this.gbxThongtin.Controls.Add(this.comboMaHD);
            this.gbxThongtin.Controls.Add(this.labelMaHD);
            this.gbxThongtin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxThongtin.Location = new System.Drawing.Point(48, 83);
            this.gbxThongtin.Name = "gbxThongtin";
            this.gbxThongtin.Size = new System.Drawing.Size(1316, 225);
            this.gbxThongtin.TabIndex = 242;
            this.gbxThongtin.TabStop = false;
            this.gbxThongtin.Text = "Thông tin hóa đơn";
            // 
            // groupKhoangngay
            // 
            this.groupKhoangngay.Controls.Add(this.maskedNgaykt);
            this.groupKhoangngay.Controls.Add(this.labelNgaykt);
            this.groupKhoangngay.Controls.Add(this.maskedNgaybd);
            this.groupKhoangngay.Controls.Add(this.labelNgaybd);
            this.groupKhoangngay.Location = new System.Drawing.Point(904, 82);
            this.groupKhoangngay.Name = "groupKhoangngay";
            this.groupKhoangngay.Size = new System.Drawing.Size(363, 38);
            this.groupKhoangngay.TabIndex = 265;
            this.groupKhoangngay.TabStop = false;
            // 
            // maskedNgaykt
            // 
            this.maskedNgaykt.Location = new System.Drawing.Point(228, 11);
            this.maskedNgaykt.Mask = "00/00/0000";
            this.maskedNgaykt.Name = "maskedNgaykt";
            this.maskedNgaykt.Size = new System.Drawing.Size(130, 24);
            this.maskedNgaykt.TabIndex = 265;
            this.maskedNgaykt.ValidatingType = typeof(System.DateTime);
            // 
            // labelNgaykt
            // 
            this.labelNgaykt.AutoSize = true;
            this.labelNgaykt.Location = new System.Drawing.Point(181, 14);
            this.labelNgaykt.Name = "labelNgaykt";
            this.labelNgaykt.Size = new System.Drawing.Size(32, 18);
            this.labelNgaykt.TabIndex = 265;
            this.labelNgaykt.Text = "đến";
            // 
            // maskedNgaybd
            // 
            this.maskedNgaybd.Location = new System.Drawing.Point(38, 11);
            this.maskedNgaybd.Mask = "00/00/0000";
            this.maskedNgaybd.Name = "maskedNgaybd";
            this.maskedNgaybd.Size = new System.Drawing.Size(130, 24);
            this.maskedNgaybd.TabIndex = 265;
            this.maskedNgaybd.ValidatingType = typeof(System.DateTime);
            // 
            // labelNgaybd
            // 
            this.labelNgaybd.AutoSize = true;
            this.labelNgaybd.Location = new System.Drawing.Point(6, 14);
            this.labelNgaybd.Name = "labelNgaybd";
            this.labelNgaybd.Size = new System.Drawing.Size(25, 18);
            this.labelNgaybd.TabIndex = 265;
            this.labelNgaybd.Text = "Từ";
            // 
            // radioKhoang
            // 
            this.radioKhoang.AutoSize = true;
            this.radioKhoang.Location = new System.Drawing.Point(771, 94);
            this.radioKhoang.Name = "radioKhoang";
            this.radioKhoang.Size = new System.Drawing.Size(120, 22);
            this.radioKhoang.TabIndex = 264;
            this.radioKhoang.TabStop = true;
            this.radioKhoang.Text = "Theo khoảng:";
            this.radioKhoang.UseVisualStyleBackColor = true;
            this.radioKhoang.CheckedChanged += new System.EventHandler(this.radioKhoang_CheckedChanged);
            // 
            // radioNgay
            // 
            this.radioNgay.AutoSize = true;
            this.radioNgay.Location = new System.Drawing.Point(771, 39);
            this.radioNgay.Name = "radioNgay";
            this.radioNgay.Size = new System.Drawing.Size(102, 22);
            this.radioNgay.TabIndex = 263;
            this.radioNgay.TabStop = true;
            this.radioNgay.Text = "Theo ngày:";
            this.radioNgay.UseVisualStyleBackColor = true;
            this.radioNgay.CheckedChanged += new System.EventHandler(this.radioNgay_CheckedChanged);
            // 
            // maskNgay
            // 
            this.maskNgay.Location = new System.Drawing.Point(904, 38);
            this.maskNgay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskNgay.Mask = "00/00/0000";
            this.maskNgay.Name = "maskNgay";
            this.maskNgay.Size = new System.Drawing.Size(156, 24);
            this.maskNgay.TabIndex = 264;
            this.maskNgay.ValidatingType = typeof(System.DateTime);
            // 
            // buttonTimlai
            // 
            this.buttonTimlai.Location = new System.Drawing.Point(1197, 169);
            this.buttonTimlai.Name = "buttonTimlai";
            this.buttonTimlai.Size = new System.Drawing.Size(89, 37);
            this.buttonTimlai.TabIndex = 262;
            this.buttonTimlai.Text = "Tìm lại";
            this.buttonTimlai.UseVisualStyleBackColor = true;
            this.buttonTimlai.Click += new System.EventHandler(this.buttonTimlai_Click);
            // 
            // textDongianhap
            // 
            this.textDongianhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDongianhap.Location = new System.Drawing.Point(542, 147);
            this.textDongianhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textDongianhap.Name = "textDongianhap";
            this.textDongianhap.Size = new System.Drawing.Size(162, 24);
            this.textDongianhap.TabIndex = 263;
            // 
            // labelDongianhap
            // 
            this.labelDongianhap.AutoSize = true;
            this.labelDongianhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDongianhap.Location = new System.Drawing.Point(394, 150);
            this.labelDongianhap.Name = "labelDongianhap";
            this.labelDongianhap.Size = new System.Drawing.Size(95, 18);
            this.labelDongianhap.TabIndex = 262;
            this.labelDongianhap.Text = "Đơn giá nhập";
            // 
            // buttonTimkiem
            // 
            this.buttonTimkiem.Location = new System.Drawing.Point(1079, 169);
            this.buttonTimkiem.Name = "buttonTimkiem";
            this.buttonTimkiem.Size = new System.Drawing.Size(89, 37);
            this.buttonTimkiem.TabIndex = 257;
            this.buttonTimkiem.Text = "Tìm kiếm";
            this.buttonTimkiem.UseVisualStyleBackColor = true;
            this.buttonTimkiem.Click += new System.EventHandler(this.buttonTimkiem_Click);
            // 
            // comboMaNV
            // 
            this.comboMaNV.FormattingEnabled = true;
            this.comboMaNV.Location = new System.Drawing.Point(542, 93);
            this.comboMaNV.Name = "comboMaNV";
            this.comboMaNV.Size = new System.Drawing.Size(162, 26);
            this.comboMaNV.TabIndex = 253;
            // 
            // comboMaNCC
            // 
            this.comboMaNCC.FormattingEnabled = true;
            this.comboMaNCC.Location = new System.Drawing.Point(542, 38);
            this.comboMaNCC.Name = "comboMaNCC";
            this.comboMaNCC.Size = new System.Drawing.Size(162, 26);
            this.comboMaNCC.TabIndex = 252;
            // 
            // labelTenNV
            // 
            this.labelTenNV.Location = new System.Drawing.Point(394, 96);
            this.labelTenNV.Name = "labelTenNV";
            this.labelTenNV.Size = new System.Drawing.Size(101, 18);
            this.labelTenNV.TabIndex = 246;
            this.labelTenNV.Text = "Mã nhân viên";
            // 
            // labelNCC
            // 
            this.labelNCC.Location = new System.Drawing.Point(394, 41);
            this.labelNCC.Name = "labelNCC";
            this.labelNCC.Size = new System.Drawing.Size(121, 17);
            this.labelNCC.TabIndex = 245;
            this.labelNCC.Text = "Mã nhà cung cấp";
            // 
            // comboMaSP
            // 
            this.comboMaSP.FormattingEnabled = true;
            this.comboMaSP.Location = new System.Drawing.Point(176, 93);
            this.comboMaSP.Name = "comboMaSP";
            this.comboMaSP.Size = new System.Drawing.Size(156, 26);
            this.comboMaSP.TabIndex = 251;
            // 
            // labelTenSP
            // 
            this.labelTenSP.Location = new System.Drawing.Point(53, 96);
            this.labelTenSP.Name = "labelTenSP";
            this.labelTenSP.Size = new System.Drawing.Size(101, 18);
            this.labelTenSP.TabIndex = 244;
            this.labelTenSP.Text = "Mã sản phẩm";
            // 
            // comboMaHD
            // 
            this.comboMaHD.FormattingEnabled = true;
            this.comboMaHD.Location = new System.Drawing.Point(176, 38);
            this.comboMaHD.Name = "comboMaHD";
            this.comboMaHD.Size = new System.Drawing.Size(156, 26);
            this.comboMaHD.TabIndex = 250;
            // 
            // labelMaHD
            // 
            this.labelMaHD.Location = new System.Drawing.Point(53, 41);
            this.labelMaHD.Name = "labelMaHD";
            this.labelMaHD.Size = new System.Drawing.Size(101, 18);
            this.labelMaHD.TabIndex = 243;
            this.labelMaHD.Text = "Mã hóa đơn";
            // 
            // buttonInBC
            // 
            this.buttonInBC.Location = new System.Drawing.Point(1130, 776);
            this.buttonInBC.Name = "buttonInBC";
            this.buttonInBC.Size = new System.Drawing.Size(113, 43);
            this.buttonInBC.TabIndex = 260;
            this.buttonInBC.Text = "In";
            this.buttonInBC.UseVisualStyleBackColor = true;
            this.buttonInBC.Click += new System.EventHandler(this.buttonInBC_Click);
            // 
            // dataGridViewSanpham
            // 
            this.dataGridViewSanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSanpham.Location = new System.Drawing.Point(962, 333);
            this.dataGridViewSanpham.Name = "dataGridViewSanpham";
            this.dataGridViewSanpham.RowHeadersWidth = 62;
            this.dataGridViewSanpham.RowTemplate.Height = 24;
            this.dataGridViewSanpham.Size = new System.Drawing.Size(402, 415);
            this.dataGridViewSanpham.TabIndex = 259;
            // 
            // dataGridViewHoadon
            // 
            this.dataGridViewHoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHoadon.Location = new System.Drawing.Point(48, 333);
            this.dataGridViewHoadon.Name = "dataGridViewHoadon";
            this.dataGridViewHoadon.RowHeadersWidth = 62;
            this.dataGridViewHoadon.RowTemplate.Height = 24;
            this.dataGridViewHoadon.Size = new System.Drawing.Size(887, 415);
            this.dataGridViewHoadon.TabIndex = 258;
            // 
            // frmBaoCaoHDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1412, 854);
            this.Controls.Add(this.labelHDN);
            this.Controls.Add(this.buttonDong);
            this.Controls.Add(this.gbxThongtin);
            this.Controls.Add(this.buttonInBC);
            this.Controls.Add(this.dataGridViewSanpham);
            this.Controls.Add(this.dataGridViewHoadon);
            this.Name = "frmBaoCaoHDN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo Cáo Hóa Đơn Nhập";
            this.Load += new System.EventHandler(this.frmBaoCaoHDN_Load);
            this.gbxThongtin.ResumeLayout(false);
            this.gbxThongtin.PerformLayout();
            this.groupKhoangngay.ResumeLayout(false);
            this.groupKhoangngay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSanpham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoadon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHDN;
        private System.Windows.Forms.Button buttonDong;
        private System.Windows.Forms.GroupBox gbxThongtin;
        private System.Windows.Forms.Button buttonTimkiem;
        private System.Windows.Forms.ComboBox comboMaNV;
        private System.Windows.Forms.ComboBox comboMaNCC;
        private System.Windows.Forms.Label labelTenNV;
        private System.Windows.Forms.Label labelNCC;
        private System.Windows.Forms.ComboBox comboMaSP;
        private System.Windows.Forms.Label labelTenSP;
        private System.Windows.Forms.ComboBox comboMaHD;
        private System.Windows.Forms.Label labelMaHD;
        private System.Windows.Forms.Button buttonInBC;
        private System.Windows.Forms.DataGridView dataGridViewSanpham;
        private System.Windows.Forms.DataGridView dataGridViewHoadon;
        private System.Windows.Forms.TextBox textDongianhap;
        private System.Windows.Forms.Label labelDongianhap;
        private System.Windows.Forms.Button buttonTimlai;
        private System.Windows.Forms.GroupBox groupKhoangngay;
        private System.Windows.Forms.MaskedTextBox maskedNgaykt;
        private System.Windows.Forms.Label labelNgaykt;
        private System.Windows.Forms.MaskedTextBox maskedNgaybd;
        private System.Windows.Forms.Label labelNgaybd;
        private System.Windows.Forms.RadioButton radioKhoang;
        private System.Windows.Forms.RadioButton radioNgay;
        private System.Windows.Forms.MaskedTextBox maskNgay;
    }
}