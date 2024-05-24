using System.ComponentModel;

namespace BTL_CoffeeShop
{
    partial class HoaDonNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txttennhanvien = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbomanhanvien = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.msksodienthoai = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbomanhacungcap = new System.Windows.Forms.ComboBox();
            this.mskngaynhap = new System.Windows.Forms.MaskedTextBox();
            this.txttennhacungcap = new System.Windows.Forms.TextBox();
            this.txtmahoadonnhap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtchietkhau = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtdongianhap = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txttensanpham = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbomasanpham = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btntim = new System.Windows.Forms.Button();
            this.btnboqua = new System.Windows.Forms.Button();
            this.btndong = new System.Windows.Forms.Button();
            this.txttongtien = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(752, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hóa Đơn Nhập";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txttennhanvien);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbomanhanvien);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.msksodienthoai);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtdiachi);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbomanhacungcap);
            this.groupBox1.Controls.Add(this.mskngaynhap);
            this.groupBox1.Controls.Add(this.txttennhacungcap);
            this.groupBox1.Controls.Add(this.txtmahoadonnhap);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(79, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(962, 164);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // txttennhanvien
            // 
            this.txttennhanvien.Location = new System.Drawing.Point(803, 66);
            this.txttennhanvien.Name = "txttennhanvien";
            this.txttennhanvien.Size = new System.Drawing.Size(136, 22);
            this.txttennhanvien.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(667, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 24);
            this.label9.TabIndex = 15;
            this.label9.Text = "Tên nhân viên";
            // 
            // cbomanhanvien
            // 
            this.cbomanhanvien.FormattingEnabled = true;
            this.cbomanhanvien.Location = new System.Drawing.Point(803, 29);
            this.cbomanhanvien.Name = "cbomanhanvien";
            this.cbomanhanvien.Size = new System.Drawing.Size(136, 24);
            this.cbomanhanvien.TabIndex = 14;
            this.cbomanhanvien.SelectedIndexChanged += new System.EventHandler(this.cbomanhanvien_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(667, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 24);
            this.label8.TabIndex = 13;
            this.label8.Text = "Mã nhân viên";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(345, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Mã nhà cung cấp";
            // 
            // msksodienthoai
            // 
            this.msksodienthoai.Location = new System.Drawing.Point(481, 141);
            this.msksodienthoai.Mask = "(999) 000-0000";
            this.msksodienthoai.Name = "msksodienthoai";
            this.msksodienthoai.Size = new System.Drawing.Size(136, 22);
            this.msksodienthoai.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(345, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 24);
            this.label7.TabIndex = 10;
            this.label7.Text = "Số điện thoại";
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(481, 107);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(136, 22);
            this.txtdiachi.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(345, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(345, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tên nhà cung cấp";
            // 
            // cbomanhacungcap
            // 
            this.cbomanhacungcap.FormattingEnabled = true;
            this.cbomanhacungcap.Location = new System.Drawing.Point(481, 32);
            this.cbomanhacungcap.Name = "cbomanhacungcap";
            this.cbomanhacungcap.Size = new System.Drawing.Size(136, 24);
            this.cbomanhacungcap.TabIndex = 6;
            this.cbomanhacungcap.SelectedIndexChanged += new System.EventHandler(this.cbomanhacungcap_SelectedIndexChanged);
            // 
            // mskngaynhap
            // 
            this.mskngaynhap.Location = new System.Drawing.Point(162, 63);
            this.mskngaynhap.Mask = "00/00/0000 90:00";
            this.mskngaynhap.Name = "mskngaynhap";
            this.mskngaynhap.Size = new System.Drawing.Size(133, 22);
            this.mskngaynhap.TabIndex = 4;
            this.mskngaynhap.ValidatingType = typeof(System.DateTime);
            // 
            // txttennhacungcap
            // 
            this.txttennhacungcap.Location = new System.Drawing.Point(481, 71);
            this.txttennhacungcap.Name = "txttennhacungcap";
            this.txttennhacungcap.Size = new System.Drawing.Size(136, 22);
            this.txttennhacungcap.TabIndex = 3;
            // 
            // txtmahoadonnhap
            // 
            this.txtmahoadonnhap.Location = new System.Drawing.Point(159, 32);
            this.txtmahoadonnhap.Name = "txtmahoadonnhap";
            this.txtmahoadonnhap.Size = new System.Drawing.Size(136, 22);
            this.txtmahoadonnhap.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(23, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày nhập";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(23, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã hóa đơn nhập";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtchietkhau);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtdongianhap);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtsoluong);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txttensanpham);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cbomasanpham);
            this.groupBox2.Location = new System.Drawing.Point(130, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(887, 127);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin hàng hóa";
            // 
            // txtchietkhau
            // 
            this.txtchietkhau.Location = new System.Drawing.Point(726, 53);
            this.txtchietkhau.Name = "txtchietkhau";
            this.txtchietkhau.Size = new System.Drawing.Size(136, 22);
            this.txtchietkhau.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(638, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 24);
            this.label14.TabIndex = 20;
            this.label14.Text = "Chiết khấu";
            // 
            // txtdongianhap
            // 
            this.txtdongianhap.Location = new System.Drawing.Point(448, 71);
            this.txtdongianhap.Name = "txtdongianhap";
            this.txtdongianhap.Size = new System.Drawing.Size(136, 22);
            this.txtdongianhap.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(341, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 24);
            this.label13.TabIndex = 8;
            this.label13.Text = "Đơn giá nhập";
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(448, 29);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(136, 22);
            this.txtsoluong.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(375, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 24);
            this.label12.TabIndex = 10;
            this.label12.Text = "Số lượng";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(20, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 24);
            this.label11.TabIndex = 18;
            this.label11.Text = "Tên sản phẩm";
            // 
            // txttensanpham
            // 
            this.txttensanpham.Location = new System.Drawing.Point(156, 71);
            this.txttensanpham.Name = "txttensanpham";
            this.txttensanpham.Size = new System.Drawing.Size(136, 22);
            this.txttensanpham.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(20, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 24);
            this.label10.TabIndex = 18;
            this.label10.Text = "Mã sản phẩm";
            // 
            // cbomasanpham
            // 
            this.cbomasanpham.FormattingEnabled = true;
            this.cbomasanpham.Location = new System.Drawing.Point(156, 29);
            this.cbomasanpham.Name = "cbomasanpham";
            this.cbomasanpham.Size = new System.Drawing.Size(136, 24);
            this.cbomasanpham.TabIndex = 17;
            this.cbomasanpham.SelectedIndexChanged += new System.EventHandler(this.cbomasanpham_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(72, 401);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(969, 170);
            this.dataGridView1.TabIndex = 3;
            //this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(60, 624);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(70, 27);
            this.btnthem.TabIndex = 4;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(199, 624);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(70, 27);
            this.btnxoa.TabIndex = 5;
            this.btnxoa.Text = "Xóa HĐ";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(366, 624);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(70, 27);
            this.btnsua.TabIndex = 6;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(517, 624);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(70, 27);
            this.btnluu.TabIndex = 7;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            // 
            // btntim
            // 
            this.btntim.Location = new System.Drawing.Point(661, 624);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(70, 27);
            this.btntim.TabIndex = 8;
            this.btntim.Text = "Tìm kiếm";
            this.btntim.UseVisualStyleBackColor = true;
            // 
            // btnboqua
            // 
            this.btnboqua.Location = new System.Drawing.Point(792, 624);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(70, 27);
            this.btnboqua.TabIndex = 9;
            this.btnboqua.Text = "Bỏ qua";
            this.btnboqua.UseVisualStyleBackColor = true;
            this.btnboqua.Click += new System.EventHandler(this.btnboqua_Click);
            // 
            // btndong
            // 
            this.btndong.Location = new System.Drawing.Point(947, 624);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(70, 27);
            this.btndong.TabIndex = 10;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // txttongtien
            // 
            this.txttongtien.Location = new System.Drawing.Point(166, 579);
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.Size = new System.Drawing.Size(136, 22);
            this.txttongtien.TabIndex = 23;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(77, 577);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 24);
            this.label15.TabIndex = 22;
            this.label15.Text = "Tổng tiền";
            // 
            // HoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 663);
            this.Controls.Add(this.txttongtien);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnboqua);
            this.Controls.Add(this.btntim);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "HoaDonNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HoaDonNhap";
            this.Load += new System.EventHandler(this.HoaDonNhap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnboqua;

        private System.Windows.Forms.Button btnthem;

        private System.Windows.Forms.TextBox txttongtien;
        private System.Windows.Forms.Label label15;

        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.Button btndong;

        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtchietkhau;

        private System.Windows.Forms.TextBox txtdongianhap;

        private System.Windows.Forms.Label label13;

        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.Label label12;

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txttensanpham;

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbomasanpham;

        private System.Windows.Forms.GroupBox groupBox2;

        private System.Windows.Forms.TextBox txttennhanvien;

        private System.Windows.Forms.Label label9;

        private System.Windows.Forms.ComboBox cbomanhanvien;

        private System.Windows.Forms.Label label8;

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox msksodienthoai;

        private System.Windows.Forms.TextBox txtdiachi;

        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbomanhacungcap;

        private System.Windows.Forms.MaskedTextBox mskngaynhap;

        private System.Windows.Forms.TextBox txttennhacungcap;

        private System.Windows.Forms.TextBox txtmahoadonnhap;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.Label label1;

        
        #endregion
    }
}