using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using BTL_CoffeeShop.Class;
using COMExcel = Microsoft.Office.Interop.Excel;
using OfficeOpenXml; // phải cài EPPPlus từ NuGet trong Manage NuGet Package thì mới dùng được nhé
namespace BTL_CoffeeShop;



public partial class BaoCaoHoaDonNhap : Form
{
    private DataTable tblCTDH;
    private DataTable tblSP;
    public BaoCaoHoaDonNhap()
    {
        InitializeComponent();
        btninhoadon.Click += new System.EventHandler(this.btnhienthi_Click);
    }

   

    private void BaoCaoHoaDonNhap_Load(object sender, EventArgs e)
    {
        Functions.Connect();
        cbomahoadon.Enabled = false;
        cbotensanpham.Enabled = false;
        cbotennhacungcap.Enabled = false;
        cbostaff.Enabled = false;
        txtgiaban.Enabled = false;
        dataGridView2.Visible = true;
        Load_DataGridView1();
        Load_DataGridView2();
    }

    private void Load_DataGridView1()
    {
        string sql;
        sql = "SELECT tblChiTietHDN.MaSP, tblSanPham.TenSP, tblChiTietHDN.DonGia AS DonGia, tblChiTietHDN.SoLuong, " +
              "tblChiTietHDN.ThanhTien, tblChiTietHDN.ChietKhau, " +
              "tblHoaDonNhap.MaHDN, tblHoaDonNhap.NgayNhap, tblHoaDonNhap.MaNCC, tblNhaCungCap.TenNCC, tblNhaCungCap.DiaChi, tblNhaCungCap.SDT, tblHoaDonNhap.MaNV, tblNhanVien.TenNV " +
              "FROM tblChiTietHDN " +
              "JOIN tblSanPham ON tblChiTietHDN.MaSP = tblSanPham.MaSP " +
              "JOIN tblHoaDonNhap ON tblChiTietHDN.MaHDN = tblHoaDonNhap.MaHDN " +
              "JOIN tblNhaCungCap ON tblHoaDonNhap.MaNCC = tblNhaCungCap.MaNCC " +
              "JOIN tblNhanVien ON tblHoaDonNhap.MaNV = tblNhanVien.MaNV";
        tblCTDH = Class.Functions.GetDataToTable(sql);
        dataGridView1.DataSource = tblCTDH;

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
    private void dataGridView1_Click(object sender, EventArgs e)
    {
        if (tblCTDH.Rows.Count == 0)
        {
            MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK,


                MessageBoxIcon.Information);
            return;
        }
        if(dataGridView1.CurrentRow != null)
        {
             cbomahoadon.Text = dataGridView1.CurrentRow.Cells["MaHDN"].Value.ToString();
             cbotensanpham.Text = dataGridView1.CurrentRow.Cells["TenSP"].Value.ToString();
             txtgiaban.Text = dataGridView1.CurrentRow.Cells["DonGia"].Value.ToString();
             cbotennhacungcap.Text = dataGridView1.CurrentRow.Cells["TenNCC"].Value.ToString();
             cbostaff.Text = dataGridView1.CurrentRow.Cells["TenNV"].Value.ToString();
        }
    }

    private void Load_DataGridView2()
    {
            string sql = "SELECT TenSP, SoLuong FROM tblSanPham";
            SqlCommand command = new SqlCommand(sql, Functions.Conn);
            DataTable tblSP = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(tblSP);

            dataGridView2.DataSource = tblSP;
            
            dataGridView2.Columns[0].HeaderText = "Ten San Pham";
            dataGridView2.Columns[1].HeaderText = "So Luong";

            dataGridView2.Columns[0].Width = 150;
            dataGridView2.Columns[1].Width = 120;

            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.EditMode = DataGridViewEditMode.EditProgrammatically;
        
    }
     /*private void dataGridView2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.RowCount == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (dataGridView2.CurrentRow != null)
            {
                cbotensanpham.Text = dataGridView2.CurrentRow.Cells["TenSP"].Value.ToString();
                cbotennhacungcap.Text = dataGridView2.CurrentRow.Cells["TenNCC"].Value.ToString();
                txtgiaban.Text = dataGridView2.CurrentRow.Cells["DonGia"].Value.ToString();
            }
        }*/
     private void btntimkiem_Click(object sender, EventArgs e)
     {
         // Lấy dữ liệu từ dataGridView1
         DataTable dataFromDataGridView1 = (DataTable)dataGridView1.DataSource;

         // Kiểm tra xem có dữ liệu không
         if (dataFromDataGridView1 == null || dataFromDataGridView1.Rows.Count == 0)
         {
             MessageBox.Show("Không có dữ liệu từ dataGridView1!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
             return;
         }

         // Tạo một DataTable mới để chứa dữ liệu đã được lọc
         DataTable filteredData = new DataTable();
         filteredData.Columns.Add("Ten San Pham");
         filteredData.Columns.Add("So Luong");

         // Duyệt qua từng dòng trong dataGridView1
         foreach (DataRow row in dataFromDataGridView1.Rows)
         {
             // Lấy ngày từ dòng hiện tại
             DateTime ngayNhap = DateTime.Parse(row["NgayNhap"].ToString());

             // So sánh ngày nhập với ngày được chọn
             if (ngayNhap.Date == startdate.Value.Date)
             {
                 // Nếu ngày khớp, thêm dòng này vào dữ liệu đã được lọc
                 DataRow newRow = filteredData.NewRow();
                 newRow["Ten San Pham"] = row["TenSP"];
                 newRow["So Luong"] = row["SoLuong"];
                 filteredData.Rows.Add(newRow);
             }
         }

         // Hiển thị dữ liệu đã được lọc lên dataGridView2
         dataGridView2.DataSource = filteredData;

         // Thiết lập các thuộc tính cho dataGridView2
         dataGridView2.Columns[0].HeaderText = "Ten San Pham";
         dataGridView2.Columns[1].HeaderText = "So Luong";
         dataGridView2.Columns[0].Width = 150;
         dataGridView2.Columns[1].Width = 120;
         dataGridView2.AllowUserToAddRows = false;
         dataGridView2.EditMode = DataGridViewEditMode.EditProgrammatically;
         
         
     }

     private void cbotennhacungcap_SelectedIndexChanged(object sender, EventArgs e)
     {
         // Tạo câu lệnh SQL để lấy tất cả các tên nhà cung cấp từ bảng tblNhaCungCap
         string sql = "SELECT MaNCC, TenNCC FROM tblNhaCungCap";

         // Thực thi câu lệnh SQL và lấy dữ liệu trả về
         DataTable tblNCC = Functions.GetDataToTable(sql);

         // Đặt dữ liệu trả về làm nguồn dữ liệu cho cbotennhacungcap
         cbotennhacungcap.DataSource = tblNCC;
         cbotennhacungcap.DisplayMember = "TenNCC";
         cbotennhacungcap.ValueMember = "MaNCC";
     }


    private void radiotheongay_CheckedChanged(object sender, EventArgs e)
    {
        if (radiotheongay.Checked)
        {
            string startDate = startdate.Value.ToString("yyyy-MM-dd");
            Load_DataGridView2();
            dataGridView2.Visible = true;
        }
    }

    private DataTable FilterDataByDate(DateTime date)
    {
        DataTable filteredData = new DataTable();
        filteredData.Columns.Add("Ten San Pham");
        filteredData.Columns.Add("So Luong");

        foreach (DataRow row in tblCTDH.Rows)
        {
            DateTime ngayNhap = DateTime.Parse(row["NgayNhap"].ToString());
            if (ngayNhap.Date == date.Date)
            {
                DataRow newRow = filteredData.NewRow();
                newRow["Ten San Pham"] = row["TenSP"];
                newRow["So Luong"] = row["SoLuong"];
                filteredData.Rows.Add(newRow);
            }
        }

        return filteredData;
    }
    
    private void startdate_ValueChanged(object sender, EventArgs e)
    {
        Load_DataGridView2();
    }


    private void btninhoadon_Click(object sender, EventArgs e)
{
    // Khởi động chương trình Excel
    Microsoft.Office.Interop.Excel.Application exApp = new Microsoft.Office.Interop.Excel.Application();
    Microsoft.Office.Interop.Excel.Workbook exBook = exApp.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
    Microsoft.Office.Interop.Excel.Worksheet exSheet = (Microsoft.Office.Interop.Excel.Worksheet)exBook.Worksheets[1];
    //Microsoft.Office.Interop.Excel.Range exRange;

    string sql;
    int hang = 0, cot = 0;
    DataTable tblThongtinHD, tblThongtinHang;

    // Định dạng chung
    Microsoft.Office.Interop.Excel.Range exRange = (Microsoft.Office.Interop.Excel.Range)exSheet.Cells[1, 1];
    exRange.Range["A1:B3"].Font.Size = 10;
    exRange.Range["A1:B3"].Font.Name = "Times new roman";
    exRange.Range["A1:B3"].Font.Bold = true;
    exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
    exRange.Range["A1:A1"].ColumnWidth = 7;
    exRange.Range["B1:B1"].ColumnWidth = 15;
    exRange.Range["A1:B1"].MergeCells = true;
    exRange.Range["A1:B1"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
    exRange.Range["A1:B1"].Value = "Quán Cafe";

    exRange.Range["A2:B2"].MergeCells = true;
    exRange.Range["A2:B2"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
    exRange.Range["A2:B2"].Value = "Ba Đình - Hà Nội";

    exRange.Range["A3:B3"].MergeCells = true;
    exRange.Range["A3:B3"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
    exRange.Range["A3:B3"].Value = "Điện thoại: (09)84930223";

    exRange.Range["C2:E2"].Font.Size = 16;
    exRange.Range["C2:E2"].Font.Name = "Times new roman";
    exRange.Range["C2:E2"].Font.Bold = true;
    exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
    exRange.Range["C2:E2"].MergeCells = true;
    exRange.Range["C2:E2"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
    exRange.Range["C2:E2"].Value = "HÓA ĐƠN BÁN";

    // Biểu diễn thông tin chung của hóa đơn bán
    sql = "SELECT a.MaHDN, a.NgayNhap, a.TongTien, b.TenKH, b.DiaChi, b.SDT, c.TenNV " +
        "FROM tblHoaDonNhap AS a, tblKhachHang AS b, tblNhanVien AS c " +
        "WHERE a.MaHDN = N'" + cbomahoadon.Text + "' AND a.MaKH = b.MaKH AND a.MaNV = c.MaNV";
    tblThongtinHD = Functions.GetDataToTable(sql);

    // Lấy thông tin các mặt hàng
    sql = "SELECT b.TenSP, a.SoLuong, b.GiaBan, a.KhuyenMai, a.ThanhTien " +
          "FROM tblChiTietHDN AS a , tblSanPham AS b " +
          "WHERE a.MaHDB = N'" + cbomahoadon.Text + "' AND a.MaSP = b.MaSP";
    tblThongtinHang = Functions.GetDataToTable(sql);

    // Tạo dòng tiêu đề bảng
    exRange.Range["A11:F11"].Font.Bold = true;
    exRange.Range["A11:F11"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
    exRange.Range["C11:F11"].ColumnWidth = 12;
    exRange.Range["A11:A11"].Value = "STT";
    exRange.Range["B11:B11"].Value = "Tên hàng";
    exRange.Range["C11:C11"].Value = "Số lượng";
    exRange.Range["D11:D11"].Value = "Đơn giá";
    exRange.Range["E11:E11"].Value = "Giảm giá";
    exRange.Range["F11:F11"].Value = "Thành tiền";

    for (hang = 0; hang <= tblThongtinHang.Rows.Count - 1; hang++)
    {
        // Điền số thứ tự vào cột 1 từ dòng 12
        ((Microsoft.Office.Interop.Excel.Range)exSheet.Cells[1, hang + 12]).Value2 = hang + 1;
        for (cot = 0; cot <= tblThongtinHang.Columns.Count - 1; cot++)
            // Điền thông tin hàng từ cột thứ 2, dòng 12
            ((Microsoft.Office.Interop.Excel.Range)exSheet.Cells[cot + 2, hang + 12]).Value2 = tblThongtinHang.Rows[hang][cot].ToString();
    }

    exApp.Visible = true;
}

    private void btnhienthi_Click(object sender, EventArgs e)
    {
        Load_DataGridView2();
    }


}

