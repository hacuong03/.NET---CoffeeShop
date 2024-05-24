using System.ComponentModel;

namespace BTL_CoffeeShop;

partial class BaoCaoHoaDonNhap
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
        this.startdate = new System.Windows.Forms.DateTimePicker();
        this.btntimkiem = new System.Windows.Forms.Button();
        this.radiotheongay = new System.Windows.Forms.RadioButton();
        this.cbostaff = new System.Windows.Forms.ComboBox();
        this.cbotennhacungcap = new System.Windows.Forms.ComboBox();
        this.label6 = new System.Windows.Forms.Label();
        this.label5 = new System.Windows.Forms.Label();
        this.txtgiaban = new System.Windows.Forms.TextBox();
        this.label4 = new System.Windows.Forms.Label();
        this.cbotensanpham = new System.Windows.Forms.ComboBox();
        this.label3 = new System.Windows.Forms.Label();
        this.cbomahoadon = new System.Windows.Forms.ComboBox();
        this.label2 = new System.Windows.Forms.Label();
        this.dataGridView1 = new System.Windows.Forms.DataGridView();
        this.dataGridView2 = new System.Windows.Forms.DataGridView();
        this.btnhienthi = new System.Windows.Forms.Button();
        this.btninhoadon = new System.Windows.Forms.Button();
        this.groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
        this.SuspendLayout();
        // 
        // label1
        // 
        this.label1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
        this.label1.Location = new System.Drawing.Point(333, 30);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(696, 54);
        this.label1.TabIndex = 0;
        this.label1.Text = "BÁO CÁO HÓA ĐƠN NHẬP";
        this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        // 
        // groupBox1
        // 
        this.groupBox1.Controls.Add(this.startdate);
        this.groupBox1.Controls.Add(this.btntimkiem);
        this.groupBox1.Controls.Add(this.radiotheongay);
        this.groupBox1.Controls.Add(this.cbostaff);
        this.groupBox1.Controls.Add(this.cbotennhacungcap);
        this.groupBox1.Controls.Add(this.label6);
        this.groupBox1.Controls.Add(this.label5);
        this.groupBox1.Controls.Add(this.txtgiaban);
        this.groupBox1.Controls.Add(this.label4);
        this.groupBox1.Controls.Add(this.cbotensanpham);
        this.groupBox1.Controls.Add(this.label3);
        this.groupBox1.Controls.Add(this.cbomahoadon);
        this.groupBox1.Controls.Add(this.label2);
        this.groupBox1.Location = new System.Drawing.Point(124, 101);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new System.Drawing.Size(1133, 184);
        this.groupBox1.TabIndex = 1;
        this.groupBox1.TabStop = false;
        this.groupBox1.Text = "Thông tin";
        // 
        // startdate
        // 
        this.startdate.CustomFormat = "yyyy-MM-dd";
        this.startdate.Location = new System.Drawing.Point(911, 36);
        this.startdate.Name = "startdate";
        this.startdate.Size = new System.Drawing.Size(200, 22);
        this.startdate.TabIndex = 11;
        this.startdate.Value = new System.DateTime(2024, 5, 23, 10, 24, 44, 0);
        this.startdate.ValueChanged += new System.EventHandler(this.startdate_ValueChanged);
        // 
        // btntimkiem
        // 
        this.btntimkiem.Location = new System.Drawing.Point(801, 81);
        this.btntimkiem.Name = "btntimkiem";
        this.btntimkiem.Size = new System.Drawing.Size(120, 23);
        this.btntimkiem.TabIndex = 10;
        this.btntimkiem.Text = "Tìm kiếm";
        this.btntimkiem.UseVisualStyleBackColor = true;
        this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
        // 
        // radiotheongay
        // 
        this.radiotheongay.Location = new System.Drawing.Point(801, 32);
        this.radiotheongay.Name = "radiotheongay";
        this.radiotheongay.Size = new System.Drawing.Size(104, 24);
        this.radiotheongay.TabIndex = 8;
        this.radiotheongay.TabStop = true;
        this.radiotheongay.Text = "Theo ngày";
        this.radiotheongay.UseVisualStyleBackColor = true;
        this.radiotheongay.CheckedChanged += new System.EventHandler(this.radiotheongay_CheckedChanged);
        // 
        // cbostaff
        // 
        this.cbostaff.FormattingEnabled = true;
        this.cbostaff.Location = new System.Drawing.Point(546, 82);
        this.cbostaff.Name = "cbostaff";
        this.cbostaff.Size = new System.Drawing.Size(117, 24);
        this.cbostaff.TabIndex = 3;
        // 
        // cbotennhacungcap
        // 
        this.cbotennhacungcap.FormattingEnabled = true;
        this.cbotennhacungcap.Location = new System.Drawing.Point(546, 37);
        this.cbotennhacungcap.Name = "cbotennhacungcap";
        this.cbotennhacungcap.Size = new System.Drawing.Size(117, 24);
        this.cbotennhacungcap.TabIndex = 7;
        this.cbotennhacungcap.SelectedIndexChanged += new System.EventHandler(this.cbotennhacungcap_SelectedIndexChanged);
        // 
        // label6
        // 
        this.label6.Location = new System.Drawing.Point(439, 85);
        this.label6.Name = "label6";
        this.label6.Size = new System.Drawing.Size(101, 18);
        this.label6.TabIndex = 2;
        this.label6.Text = "Staff";
        // 
        // label5
        // 
        this.label5.Location = new System.Drawing.Point(439, 40);
        this.label5.Name = "label5";
        this.label5.Size = new System.Drawing.Size(101, 18);
        this.label5.TabIndex = 6;
        this.label5.Text = "Tên Nhà CC";
        // 
        // txtgiaban
        // 
        this.txtgiaban.Location = new System.Drawing.Point(132, 119);
        this.txtgiaban.Name = "txtgiaban";
        this.txtgiaban.Size = new System.Drawing.Size(117, 22);
        this.txtgiaban.TabIndex = 5;
        // 
        // label4
        // 
        this.label4.Location = new System.Drawing.Point(25, 123);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(101, 18);
        this.label4.TabIndex = 4;
        this.label4.Text = "Giá bán";
        // 
        // cbotensanpham
        // 
        this.cbotensanpham.FormattingEnabled = true;
        this.cbotensanpham.Location = new System.Drawing.Point(132, 75);
        this.cbotensanpham.Name = "cbotensanpham";
        this.cbotensanpham.Size = new System.Drawing.Size(117, 24);
        this.cbotensanpham.TabIndex = 3;
        // 
        // label3
        // 
        this.label3.Location = new System.Drawing.Point(25, 78);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(101, 18);
        this.label3.TabIndex = 2;
        this.label3.Text = "Tên sản phẩm";
        // 
        // cbomahoadon
        // 
        this.cbomahoadon.FormattingEnabled = true;
        this.cbomahoadon.Location = new System.Drawing.Point(132, 30);
        this.cbomahoadon.Name = "cbomahoadon";
        this.cbomahoadon.Size = new System.Drawing.Size(117, 24);
        this.cbomahoadon.TabIndex = 1;
        // 
        // label2
        // 
        this.label2.Location = new System.Drawing.Point(25, 33);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(101, 18);
        this.label2.TabIndex = 0;
        this.label2.Text = "Mã hóa đơn";
        // 
        // dataGridView1
        // 
        this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dataGridView1.Location = new System.Drawing.Point(34, 301);
        this.dataGridView1.Name = "dataGridView1";
        this.dataGridView1.RowTemplate.Height = 24;
        this.dataGridView1.Size = new System.Drawing.Size(701, 383);
        this.dataGridView1.TabIndex = 2;
        this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
        // 
        // dataGridView2
        // 
        this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dataGridView2.Location = new System.Drawing.Point(925, 301);
        this.dataGridView2.Name = "dataGridView2";
        this.dataGridView2.RowTemplate.Height = 24;
        this.dataGridView2.Size = new System.Drawing.Size(332, 382);
        this.dataGridView2.TabIndex = 3;
        // 
        // btnhienthi
        // 
        this.btnhienthi.Location = new System.Drawing.Point(750, 698);
        this.btnhienthi.Name = "btnhienthi";
        this.btnhienthi.Size = new System.Drawing.Size(75, 23);
        this.btnhienthi.TabIndex = 4;
        this.btnhienthi.Text = "Hiển thị";
        this.btnhienthi.UseVisualStyleBackColor = true;
        this.btnhienthi.Click += new System.EventHandler(this.btnhienthi_Click);
        // 
        // btninhoadon
        // 
        this.btninhoadon.Location = new System.Drawing.Point(842, 698);
        this.btninhoadon.Name = "btninhoadon";
        this.btninhoadon.Size = new System.Drawing.Size(75, 23);
        this.btninhoadon.TabIndex = 5;
        this.btninhoadon.Text = "In";
        this.btninhoadon.UseVisualStyleBackColor = true;
        // 
        // BaoCaoHoaDonNhap
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(1360, 733);
        this.Controls.Add(this.btninhoadon);
        this.Controls.Add(this.btnhienthi);
        this.Controls.Add(this.dataGridView2);
        this.Controls.Add(this.dataGridView1);
        this.Controls.Add(this.groupBox1);
        this.Controls.Add(this.label1);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.Name = "BaoCaoHoaDonNhap";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "BaoCaoHoaDonNhap";
        this.Load += new System.EventHandler(this.BaoCaoHoaDonNhap_Load);
        this.groupBox1.ResumeLayout(false);
        this.groupBox1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.DateTimePicker startdate;

    private System.Windows.Forms.TextBox textBox1;

    private System.Windows.Forms.Button btnhienthi;
    private System.Windows.Forms.Button btninhoadon;

    private System.Windows.Forms.DataGridView dataGridView2;

    private System.Windows.Forms.DataGridView dataGridView1;

    private System.Windows.Forms.Button btntimkiem;

    private System.Windows.Forms.RadioButton radiotheongay;

    private System.Windows.Forms.ComboBox cbotennhacungcap;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.ComboBox cbostaff;
    private System.Windows.Forms.Label label6;

    private System.Windows.Forms.TextBox txtgiaban;

    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.ComboBox cbotensanpham;
    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.ComboBox cbomahoadon;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.GroupBox groupBox1;

    private System.Windows.Forms.Label label1;

    #endregion
}