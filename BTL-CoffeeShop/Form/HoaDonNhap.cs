using System.Windows.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using BTL_CoffeeShop.Class;

namespace BTL_CoffeeShop
{
   public partial class HoaDonNhap : Form
   {
       DataTable tblHDN;
  
       
      
       public HoaDonNhap()
       {
           InitializeComponent();
      
       }


       private void HoaDonNhap_Load(object sender, EventArgs e)
       {
           Functions.Connect();
           Load_DataGridView();
           LoadComboBoxNhaCungCap();
           LoadComboBoxNhanVien();
           LoadComboBoxMaSanPham();
       }
      
     
       private void Load_DataGridView()


       {
          
           string sql = "SELECT tblChiTietHDN.MaSP, tblSanPham.TenSP, tblChiTietHDN.DonGia AS DonGia, tblChiTietHDN.SoLuong, " +
                        "tblChiTietHDN.ThanhTien, tblChiTietHDN.ChietKhau, " +
                        "tblHoaDonNhap.MaHDN, tblHoaDonNhap.NgayNhap, tblHoaDonNhap.MaNCC, tblNhaCungCap.TenNCC, tblNhaCungCap.DiaChi, tblNhaCungCap.SDT, tblHoaDonNhap.MaNV, tblNhanVien.TenNV " +
                        "FROM tblChiTietHDN " +
                        "JOIN tblSanPham ON tblChiTietHDN.MaSP = tblSanPham.MaSP " +
                        "JOIN tblHoaDonNhap ON tblChiTietHDN.MaHDN = tblHoaDonNhap.MaHDN " +
                        "JOIN tblNhaCungCap ON tblHoaDonNhap.MaNCC = tblNhaCungCap.MaNCC " +
                        "JOIN tblNhanVien ON tblHoaDonNhap.MaNV = tblNhanVien.MaNV";


           tblHDN = Class.Functions.GetDataToTable(sql);
           dataGridView1.DataSource = tblHDN;


           dataGridView1.Columns[0].HeaderText = "Ma San Pham";
           dataGridView1.Columns[1].HeaderText = "Ten San Pham";
           dataGridView1.Columns[2].HeaderText = "Don Gia Nhap";
           dataGridView1.Columns[3].HeaderText = "So Luong";
           dataGridView1.Columns[4].HeaderText = "Thanh Tien";
           dataGridView1.Columns[5].HeaderText = "Chiet Khau";
           dataGridView1.Columns[6].HeaderText = "Ma Hoa Don Nhap";
           dataGridView1.Columns[7].HeaderText = "Ngay Nhap";
           dataGridView1.Columns[8].HeaderText = "Ma Nha Cung Cap";
           dataGridView1.Columns[9].HeaderText = "Ten Nha Cung Cap";
           dataGridView1.Columns[10].HeaderText = "Dia Chi";
           dataGridView1.Columns[11].HeaderText = "So Dien Thoai";
           dataGridView1.Columns[12].HeaderText = "Ma Nhan Vien";
           dataGridView1.Columns[13].HeaderText = "Ten Nhan vien";


           dataGridView1.Columns[0].Width = 100;
           dataGridView1.Columns[1].Width = 100;
           dataGridView1.Columns[2].Width = 100;
           dataGridView1.Columns[3].Width = 80;
           dataGridView1.Columns[4].Width = 100;
           dataGridView1.Columns[5].Width = 100;
           dataGridView1.Columns[6].Width = 100;
           dataGridView1.Columns[7].Width = 100;
           dataGridView1.Columns[8].Width = 100;
           dataGridView1.Columns[9].Width = 100;
           dataGridView1.Columns[10].Width = 100;
           dataGridView1.Columns[11].Width = 100;
           dataGridView1.Columns[12].Width = 100;
           dataGridView1.Columns[13].Width = 100;


           dataGridView1.AllowUserToAddRows = false;
           dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
       }
       private void ResetValues()
       {
           txtmahoadonnhap.Text = "";
           mskngaynhap.Text = "";
           cbomasanpham.SelectedIndex = -1;
           txttensanpham.Text = "";
           txtsoluong.Text = "";
           txtdongianhap.Text = "";
           txtchietkhau.Text = "";
           txttongtien.Text = "";
           cbomanhacungcap.SelectedIndex = -1;
           txttennhacungcap.Text = "";
           txtdiachi.Text = "";
           msksodienthoai.Text = "";
           cbomanhanvien.SelectedIndex = -1;
           txttennhanvien.Text = "";
       }
       


       private void dataGridView1_Click(object sender, EventArgs e)
       {
           string ma;
          
           if (btnthem.Enabled == false)
           {
               MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo",


                   MessageBoxButtons.OK, MessageBoxIcon.Information);
               txtmahoadonnhap.Focus();
               return;
           }


           if (tblHDN.Rows.Count == 0)
           {
               MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK,


                   MessageBoxIcon.Information);
               return;
           }


           cbomasanpham.Text = dataGridView1.CurrentRow.Cells["MaSP"].Value.ToString();
           txttensanpham.Text = dataGridView1.CurrentRow.Cells["TenSP"].Value.ToString();
           txtdongianhap.Text = dataGridView1.CurrentRow.Cells["DonGia"].Value.ToString();
           txtsoluong.Text = dataGridView1.CurrentRow.Cells["SoLuong"].Value.ToString();
           txttongtien.Text = dataGridView1.CurrentRow.Cells["ThanhTien"].Value.ToString();
           txtchietkhau.Text = dataGridView1.CurrentRow.Cells["ChietKhau"].Value.ToString();
           
           

           txtmahoadonnhap.Text = dataGridView1.CurrentRow.Cells["MaHDN"].Value.ToString();
           mskngaynhap.Text = dataGridView1.CurrentRow.Cells["NgayNhap"].Value.ToString();
           cbomanhacungcap.Text = dataGridView1.CurrentRow.Cells["MaNCC"].Value.ToString();
           txttennhacungcap.Text = dataGridView1.CurrentRow.Cells["TenNCC"].Value.ToString();
           cbomanhanvien.Text = dataGridView1.CurrentRow.Cells["MaNV"].Value.ToString();
           txttennhanvien.Text = dataGridView1.CurrentRow.Cells["TenNV"].Value.ToString();
           txtdiachi.Text = dataGridView1.CurrentRow.Cells["DiaChi"].Value.ToString();
           msksodienthoai.Text = dataGridView1.CurrentRow.Cells["SDT"].Value.ToString();

           btnluu.Enabled = true;
           btnxoa.Enabled = true;
           btnsua.Enabled = true;
           btnboqua.Enabled = true;
       }




       private void btnthem_Click(object sender, EventArgs e)
       {
           string sql;

            // Kiểm tra các giá trị nhập vào để đảm bảo không để trống
            if (txtmahoadonnhap.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập mã hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmahoadonnhap.Focus();
                return;
            }
            if (cbomasanpham.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn phải chọn mã sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomasanpham.Focus();
                return;
            }
            if (cbomanhacungcap.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn phải chọn mã nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomanhacungcap.Focus();
                return;
            }
            if (cbomanhanvien.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn phải chọn mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomanhanvien.Focus();
                return;
            }
            if (txtsoluong.Text.Trim() == "" || txtdongianhap.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập số lượng và đơn giá nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xem mã hóa đơn đã tồn tại trong bảng tblHoaDonNhap chưa
            sql = "SELECT MaHDN FROM tblHoaDonNhap WHERE MaHDN=N'" + txtmahoadonnhap.Text.Trim() + "'";
            if (!Functions.CheckKey(sql))
            {
                // Thêm dữ liệu vào bảng tblHoaDonNhap
                sql = "INSERT INTO tblHoaDonNhap(MaHDN, NgayNhap, MaNV, MaNCC, TongTien) VALUES(N'"
                    + txtmahoadonnhap.Text.Trim() + "', '"
                    + mskngaynhap.Text.Trim() + "', '"
                    + cbomanhanvien.SelectedValue.ToString() + "', '"
                    + cbomanhacungcap.SelectedValue.ToString() + "', 0)"; // TongTien sẽ được cập nhật sau
                Functions.RunSql(sql);
            }

            // Kiểm tra xem mã sản phẩm đã tồn tại trong chi tiết hóa đơn nhập chưa
            sql = "SELECT MaHDN, MaSP FROM tblChiTietHDN WHERE MaHDN=N'" + txtmahoadonnhap.Text.Trim() + "' AND MaSP=N'" + cbomasanpham.SelectedValue.ToString() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Sản phẩm này đã có trong chi tiết hóa đơn. Vui lòng chọn sản phẩm khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomasanpham.Focus();
                return;
            }

            // Thêm dữ liệu vào bảng tblChiTietHDN
            decimal thanhTien = Convert.ToInt32(txtsoluong.Text) * Convert.ToDecimal(txtdongianhap.Text);
            sql = "INSERT INTO tblChiTietHDN(MaHDN, MaSP, SoLuong, DonGia, ThanhTien, ChietKhau) VALUES(N'"
                + txtmahoadonnhap.Text.Trim() + "', '"
                + cbomasanpham.SelectedValue.ToString() + "', '"
                + txtsoluong.Text.Trim() + "', '"
                + txtdongianhap.Text.Trim() + "', '"
                + thanhTien.ToString() + "', '"
                + txtchietkhau.Text.Trim() + "')";
            Functions.RunSql(sql);

            // Cập nhật tổng tiền trong bảng tblHoaDonNhap
            sql = "UPDATE tblHoaDonNhap SET TongTien = (SELECT SUM(ThanhTien) FROM tblChiTietHDN WHERE MaHDN = N'"
                + txtmahoadonnhap.Text.Trim() + "') WHERE MaHDN = N'" + txtmahoadonnhap.Text.Trim() + "'";
            Functions.RunSql(sql);

            // Cập nhật DataGridView
            Load_DataGridView();
            ResetValues();
            btnthem.Enabled = true;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnboqua.Enabled = false;
            btnluu.Enabled = false;
            txtmahoadonnhap.Enabled = true;
       }

       
       
       private void LoadComboBoxNhaCungCap()
       {
           string sql = "SELECT MaNCC FROM tblNhaCungCap";
           DataTable table = Functions.GetDataToTable(sql);
           cbomanhacungcap.DataSource = table;
           cbomanhacungcap.DisplayMember = ""; // Hiển thị tên nhà cung cấp
           cbomanhacungcap.ValueMember = "MaNCC"; // Giá trị là mã nhà cung cấp
           cbomanhacungcap.SelectedIndex = -1; // Không chọn mục nào khi mới tải
       }
       private void LoadComboBoxNhanVien()
       {
           string sql = "SELECT MaNV FROM tblNhanVien";
           DataTable table = Functions.GetDataToTable(sql);
           cbomanhanvien.DataSource = table;
           cbomanhanvien.DisplayMember = ""; // Hiển thị tên nhân viên
           cbomanhanvien.ValueMember = "MaNV"; // Giá trị là mã nhân viên
           cbomanhanvien.SelectedIndex = -1; // Không chọn mục nào khi mới tải
       }
       
       private void cbomanhacungcap_SelectedIndexChanged(object sender, EventArgs e)
              {
                  if (cbomanhacungcap.SelectedIndex != -1)
                  {
                      string selectedMaNCC = cbomanhacungcap.SelectedValue.ToString();
                      string sql = "SELECT DiaChi, SDT, TenNCC FROM tblNhaCungCap WHERE MaNCC = N'" + selectedMaNCC + "'";
                      DataTable table = Functions.GetDataToTable(sql);
                      if (table.Rows.Count > 0)
                      {
                          txttennhacungcap.Text = table.Rows[0]["TenNCC"].ToString();
                          txtdiachi.Text = table.Rows[0]["DiaChi"].ToString();
                          msksodienthoai.Text = table.Rows[0]["SDT"].ToString();
                      }
                  }
              }

       private void cbomanhanvien_SelectedIndexChanged(object sender, EventArgs e)
       {
           if (cbomanhanvien.SelectedIndex != -1)
           {
               string selectedMaNV = cbomanhanvien.SelectedValue.ToString();
               string sql = "SELECT TenNV FROM tblNhanVien WHERE MaNV = N'" + selectedMaNV + "'";
               DataTable table = Functions.GetDataToTable(sql);
               if (table.Rows.Count > 0)
               {
                   txttennhanvien.Text = table.Rows[0]["TenNV"].ToString();
               }
           }
       }
       private void cbomasanpham_SelectedIndexChanged(object sender, EventArgs e)
              {
                  if (cbomasanpham.SelectedIndex != -1)
                  {
                      string selectedMaSP = cbomasanpham.SelectedValue.ToString();
                      string sql = "SELECT GiaNhap, TenSP FROM tblSanPham WHERE MaSP = N'" + selectedMaSP + "'";
                      DataTable table = Functions.GetDataToTable(sql);
                      if (table.Rows.Count > 0)
                      {
                          txtdongianhap.Text = table.Rows[0]["GiaNhap"].ToString();
                          txttensanpham.Text = table.Rows[0]["TenSP"].ToString();
                      }
                  }
              }
    private void LoadComboBoxMaSanPham()
           {
               string sql = "SELECT MaSP FROM tblSanPham";
               DataTable table = Functions.GetDataToTable(sql);
               cbomasanpham.DataSource = table;
               cbomasanpham.DisplayMember = "";
               cbomasanpham.ValueMember = "MaSP";
               cbomasanpham.SelectedIndex = -1;
           }
       

       private void btnxoa_Click(object sender, EventArgs e)
       {
           string sql;
           if (tblHDN.Rows.Count == 0)
           {
               MessageBox.Show("Không có dữ liệu để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
               return;
           }

           if (txtmahoadonnhap.Text == "")
           {
               MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
               return;
           }

           if (MessageBox.Show("Bạn có muốn xóa bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
           {
               // Xóa chi tiết hóa đơn nhập
               sql = "DELETE FROM tblChiTietHDN WHERE MaHDN=N'" + txtmahoadonnhap.Text + "' AND MaSP=N'" + cbomasanpham.SelectedValue.ToString() + "'";
               Functions.RunSql(sql);

               // Kiểm tra xem hóa đơn nhập còn chi tiết nào không, nếu không thì xóa hóa đơn nhập
               sql = "SELECT MaHDN FROM tblChiTietHDN WHERE MaHDN=N'" + txtmahoadonnhap.Text + "'";
               if (!Functions.CheckKey(sql))
               {
                   sql = "DELETE FROM tblHoaDonNhap WHERE MaHDN=N'" + txtmahoadonnhap.Text + "'";
                   Functions.RunSql(sql);
               }

               Load_DataGridView();
               ResetValues();
               btnxoa.Enabled = false;
               btnsua.Enabled = false;
               btnboqua.Enabled = false;
               btnluu.Enabled = false;
           }
       }


       private void btnsua_Click(object sender, EventArgs e)
       {
           string sql;
           if (txtmahoadonnhap.Text.Trim() == "")
           {
               MessageBox.Show("Bạn phải nhập mã hóa đơn", "Thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
               txtmahoadonnhap.Focus();
               return;
           }

           if (cbomasanpham.SelectedIndex == -1)
           {
               MessageBox.Show("Bạn phải chọn mã sản phẩm", "Thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
               cbomasanpham.Focus();
               return;
           }

           if (cbomanhanvien.SelectedIndex == -1)
           {
               MessageBox.Show("Bạn phải chọn mã nhân viên", "Thồn báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
               cbomanhanvien.Focus();
               return;
           }

           if (txtsoluong.Text.Trim() == "" || txtdongianhap.Text.Trim() == "")
           {
               MessageBox.Show("Bạn phải nhập số lượng và đơn giá nhập", "Thông báo", MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
               return;
           }
           sql = "SELECT MaHDN FROM tblHoaDonNhap WHERE MaHDN=N'" + txtmahoadonnhap.Text.Trim() + "'";
           if (!Functions.CheckKey(sql))
           {
               // Thêm dữ liệu vào bảng tblHoaDonNhap
               sql = "INSERT INTO tblHoaDonNhap(MaHDN, NgayNhap, MaNV, MaNCC, TongTien) VALUES(N'"
                     + txtmahoadonnhap.Text.Trim() + "', '"
                     + mskngaynhap.Text.Trim() + "', '"
                     + cbomanhanvien.SelectedValue.ToString() + "', '"
                     + cbomanhacungcap.SelectedValue.ToString() + "', 0)"; // TongTien sẽ được cập nhật sau
               Functions.RunSql(sql);
           }
           // Kiểm tra xem mã sản phẩm đã tồn tại trong chi tiết hóa đơn nhập chưa
           sql = "SELECT MaHDN, MaSP FROM tblChiTietHDN WHERE MaHDN=N'" + txtmahoadonnhap.Text.Trim() + "' AND MaSP=N'" + cbomasanpham.SelectedValue.ToString() + "'";
           if (Functions.CheckKey(sql))
           {
               MessageBox.Show("Sản phẩm này đã có trong chi tiết hóa đơn. Vui lòng chọn sản phẩm khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               cbomasanpham.Focus();
               return;
           }
           // Thêm dữ liệu vào bảng tblChiTietHDN
           decimal thanhTien = Convert.ToInt32(txtsoluong.Text) * Convert.ToDecimal(txtdongianhap.Text);
           sql = "INSERT INTO tblChiTietHDN(MaHDN, MaSP, SoLuong, DonGiaNhap, ThanhTien, ChietKhau) VALUES(N'"
                 + txtmahoadonnhap.Text.Trim() + "', '"
                 + cbomasanpham.SelectedValue.ToString() + "', '"
                 + txtsoluong.Text.Trim() + "', '"
                 + txtdongianhap.Text.Trim() + "', '"
                 + thanhTien.ToString() + "', '"
                 + txtchietkhau.Text.Trim() + "')";
           Functions.RunSql(sql);

           // Cập nhật tổng tiền trong bảng tblHoaDonNhap
           sql = "UPDATE tblHoaDonNhap SET TongTien = (SELECT SUM(ThanhTien) FROM tblChiTietHDN WHERE MaHDN = N'"
                 + txtmahoadonnhap.Text.Trim() + "') WHERE MaHDN = N'" + txtmahoadonnhap.Text.Trim() + "'";
           Functions.RunSql(sql);

           // Cập nhật DataGridView
           Load_DataGridView();
           ResetValues();
           btnthem.Enabled = true;
           btnsua.Enabled = false;
           btnxoa.Enabled = false;
           btnboqua.Enabled = false;
           btnluu.Enabled = false;
           txtmahoadonnhap.Enabled = false;
       }


       private void btnboqua_Click(object sender, EventArgs e)
       {
           ResetValues();
           btnxoa.Enabled = false;
           btnsua.Enabled = false;
           btnboqua.Enabled = false;
           btnluu.Enabled = false;
           txtmahoadonnhap.Enabled = true;
           btnthem.Enabled = true;
       }

       private void btndong_Click(object sender, EventArgs e)
       {
           this.Close();
       }
   }
}



