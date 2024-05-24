using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using BTL_CoffeeShop.Class;
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
        using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
        {
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (var package = new OfficeOpenXml.ExcelPackage())
                {
                    var ws = package.Workbook.Worksheets.Add("Sheet1");
                    for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                    {
                        ws.Cells[1, i].Value = dataGridView1.Columns[i - 1].HeaderText;
                    }

                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            ws.Cells[i + 2, j + 1].Value = dataGridView1.Rows[i].Cells[j].Value;
                        }
                    }

                    var ws2 = package.Workbook.Worksheets.Add("Sheet2");
                    for (int i = 1; i < dataGridView2.Columns.Count + 1; i++)
                    {
                        ws2.Cells[1, i].Value = dataGridView2.Columns[i - 1].HeaderText;
                    }

                    for (int i = 0; i < dataGridView2.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView2.Columns.Count; j++)
                        {
                            ws2.Cells[i + 2, j + 1].Value = dataGridView2.Rows[i].Cells[j].Value;
                        }
                    }

                    package.SaveAs(new FileInfo(sfd.FileName));
                }
            }
        }

        MessageBox.Show("In hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnhienthi_Click(object sender, EventArgs e)
    {
        Load_DataGridView2();
    }
}

