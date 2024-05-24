using System.ComponentModel;

namespace BTL_CoffeeShop
{
    partial class BaoCaoDoanhThu
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
            this.btntimkiem = new System.Windows.Forms.Button();
            this.txtdoanhthu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.msktheothang = new System.Windows.Forms.MaskedTextBox();
            this.msktheongay = new System.Windows.Forms.MaskedTextBox();
            this.txtgiaban = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbotensanpham = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.txttongtien = new System.Windows.Forms.TextBox();
            this.btnhienthi = new System.Windows.Forms.Button();
            this.radiotheongay = new System.Windows.Forms.RadioButton();
            this.radiotheothang = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(545, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "BÁO CÁO DOANH THU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radiotheothang);
            this.groupBox1.Controls.Add(this.radiotheongay);
            this.groupBox1.Controls.Add(this.btntimkiem);
            this.groupBox1.Controls.Add(this.txtdoanhthu);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.msktheothang);
            this.groupBox1.Controls.Add(this.msktheongay);
            this.groupBox1.Controls.Add(this.txtgiaban);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtsoluong);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbotensanpham);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(72, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(956, 184);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(869, 147);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(81, 31);
            this.btntimkiem.TabIndex = 13;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            // 
            // txtdoanhthu
            // 
            this.txtdoanhthu.Location = new System.Drawing.Point(549, 123);
            this.txtdoanhthu.Name = "txtdoanhthu";
            this.txtdoanhthu.Size = new System.Drawing.Size(120, 22);
            this.txtdoanhthu.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(467, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "Doanh thu";
            // 
            // msktheothang
            // 
            this.msktheothang.Location = new System.Drawing.Point(549, 77);
            this.msktheothang.Mask = "00/00/0000";
            this.msktheothang.Name = "msktheothang";
            this.msktheothang.Size = new System.Drawing.Size(135, 22);
            this.msktheothang.TabIndex = 10;
            this.msktheothang.ValidatingType = typeof(System.DateTime);
            // 
            // msktheongay
            // 
            this.msktheongay.Location = new System.Drawing.Point(549, 34);
            this.msktheongay.Mask = "00/00/0000";
            this.msktheongay.Name = "msktheongay";
            this.msktheongay.Size = new System.Drawing.Size(135, 22);
            this.msktheongay.TabIndex = 9;
            this.msktheongay.ValidatingType = typeof(System.DateTime);
            // 
            // txtgiaban
            // 
            this.txtgiaban.Location = new System.Drawing.Point(130, 119);
            this.txtgiaban.Name = "txtgiaban";
            this.txtgiaban.Size = new System.Drawing.Size(120, 22);
            this.txtgiaban.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(22, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Giá bán";
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(130, 73);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(120, 22);
            this.txtsoluong.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(22, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lượng";
            // 
            // cbotensanpham
            // 
            this.cbotensanpham.FormattingEnabled = true;
            this.cbotensanpham.Location = new System.Drawing.Point(130, 29);
            this.cbotensanpham.Name = "cbotensanpham";
            this.cbotensanpham.Size = new System.Drawing.Size(122, 24);
            this.cbotensanpham.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(22, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên sản phẩm";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(73, 285);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(955, 337);
            this.dataGridView1.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(73, 650);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 23);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tổng tiền";
            // 
            // txttongtien
            // 
            this.txttongtien.Location = new System.Drawing.Point(157, 647);
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.Size = new System.Drawing.Size(120, 22);
            this.txttongtien.TabIndex = 14;
            // 
            // btnhienthi
            // 
            this.btnhienthi.Location = new System.Drawing.Point(941, 647);
            this.btnhienthi.Name = "btnhienthi";
            this.btnhienthi.Size = new System.Drawing.Size(81, 31);
            this.btnhienthi.TabIndex = 15;
            this.btnhienthi.Text = "Hiển thị";
            this.btnhienthi.UseVisualStyleBackColor = true;
            // 
            // radiotheongay
            // 
            this.radiotheongay.Location = new System.Drawing.Point(439, 32);
            this.radiotheongay.Name = "radiotheongay";
            this.radiotheongay.Size = new System.Drawing.Size(104, 24);
            this.radiotheongay.TabIndex = 14;
            this.radiotheongay.TabStop = true;
            this.radiotheongay.Text = "Theo ngày";
            this.radiotheongay.UseVisualStyleBackColor = true;
            // 
            // radiotheothang
            // 
            this.radiotheothang.Location = new System.Drawing.Point(439, 76);
            this.radiotheothang.Name = "radiotheothang";
            this.radiotheothang.Size = new System.Drawing.Size(104, 24);
            this.radiotheothang.TabIndex = 15;
            this.radiotheothang.TabStop = true;
            this.radiotheothang.Text = "Theo tháng";
            this.radiotheothang.UseVisualStyleBackColor = true;
            // 
            // BaoCaoDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 759);
            this.Controls.Add(this.btnhienthi);
            this.Controls.Add(this.txttongtien);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "BaoCaoDoanhThu";
            this.Text = "BaoCaoHoaDonNhap";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.RadioButton radiotheongay;

        private System.Windows.Forms.Button btnhienthi;

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txttongtien;

        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.Button btntimkiem;

        private System.Windows.Forms.TextBox txtdoanhthu;

        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.MaskedTextBox msktheongay;
        private System.Windows.Forms.MaskedTextBox msktheothang;

        private System.Windows.Forms.RadioButton radiotheothang;

        private System.Windows.Forms.TextBox txtgiaban;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.TextBox txtsoluong;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.ComboBox cbotensanpham;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}