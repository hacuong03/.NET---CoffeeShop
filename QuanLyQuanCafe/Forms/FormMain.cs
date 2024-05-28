using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
        }

        private void mnuSanPham_Click(object sender, EventArgs e)
        {
            Forms.frmDMSanPham f = new Forms.frmDMSanPham();
            f.Show();
        }

        private void mnuCongDung_Click(object sender, EventArgs e)
        {
            Forms.frmDMCongDung f = new Forms.frmDMCongDung();
            f.Show();
        }

        private void mnuLoaiSanPham_Click(object sender, EventArgs e)
        {
            Forms.frmDMLoaiSanPham f = new Forms.frmDMLoaiSanPham();
            f.Show();
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            Forms.frmDMNhanVien f = new Forms.frmDMNhanVien();
            f.Show();
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            Forms.frmDMKhachHang f = new Forms.frmDMKhachHang();
            f.Show();
        }

        private void mnuNhaCungCap_Click(object sender, EventArgs e)
        {
            Forms.frmDMNhaCungCap f = new Forms.frmDMNhaCungCap();
            f.Show();
        }

        private void mnuHoaDonNhap_Click(object sender, EventArgs e)
        {

        }

        private void mnuHoaDonBan_Click(object sender, EventArgs e)
        {
            Forms.frmHoaDonBan f = new Forms.frmHoaDonBan();
            f.Show();
        }

        private void mnuTKHoaDonNhap_Click(object sender, EventArgs e)
        {
            Forms.frmTKHoaDonNhap f = new Forms.frmTKHoaDonNhap();
            f.Show();
        }

        private void mnuTKHoaDonBan_Click(object sender, EventArgs e)
        {
            Forms.frmTKHoaDonBan f = new Forms.frmTKHoaDonBan();
            f.Show();
        }

        private void mnuBCHoaDonNhap_Click(object sender, EventArgs e)
        {

        }

        private void mnuBCHoaDonBan_Click(object sender, EventArgs e)
        {

        }

        private void mnuBCDoanhThu_Click(object sender, EventArgs e)
        {

        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát khỏi ứng dụng?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Class.Functions.Disconnect();
                Application.Exit();
            }
        }
    }
}