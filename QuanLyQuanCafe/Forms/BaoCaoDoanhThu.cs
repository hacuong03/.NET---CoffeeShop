using QuanLyQuanCafe.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMExcel = Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace QuanLyQuanCafe.Forms
{
    public partial class frmBaoCaoDoanhThu : Form
    {
        public frmBaoCaoDoanhThu()
        {
            InitializeComponent();
        }

        DataTable tblDT;

        private void frmBaoCaoDoanhThu_Load(object sender, EventArgs e)
        {
            ResetValues();
            dgvBaoCaoDoanhThu.DataSource = null;
            txtTongTien.ReadOnly = true;
            Functions.FillCombo("SELECT TenSP FROM tblSanPham", cboTenSP, "TenSP", "TenSP");
            cboTenSP.SelectedIndex = -1;
        }

        private void Load_DataGridView()
        {
            dgvBaoCaoDoanhThu.Columns[0].HeaderText = "Ngày bán";
            dgvBaoCaoDoanhThu.Columns[1].HeaderText = "Tên sản phẩm";
            dgvBaoCaoDoanhThu.Columns[2].HeaderText = "Số lượng bán";
            dgvBaoCaoDoanhThu.Columns[3].HeaderText = "Đơn giá bán";
            dgvBaoCaoDoanhThu.Columns[4].HeaderText = "Doanh thu";
            dgvBaoCaoDoanhThu.Columns[0].Width = 200;
            dgvBaoCaoDoanhThu.Columns[1].Width = 150;
            dgvBaoCaoDoanhThu.Columns[2].Width = 150;
            dgvBaoCaoDoanhThu.Columns[3].Width = 150;
            dgvBaoCaoDoanhThu.Columns[4].Width = 150;
            dgvBaoCaoDoanhThu.AllowUserToAddRows = false;
            dgvBaoCaoDoanhThu.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void ResetValues()
        {
            cboTenSP.Text = "";
            txtSoLuong.Text = "0";
            txtGiaBan.Text = "0";
            rdTheoNgay.Checked = false;
            mskTheoNgay.Text = "  /  /";
            rdTheoKhoang.Checked = false;
            grbKhoangNgay.Enabled = false;
            mskTheoKhoang1.Text = "  /  /";
            mskTheoKhoang2.Text = "  /  /";
            txtDoanhThu.Text = "0";
            txtTongTien.Text = "";
            lblBangChu.Text = "Bằng chữ: ";
        }

        private void dgvBaoCaoDoanhThu_Click(object sender, EventArgs e)
        {
            string ma;
            if (tblDT.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ma = dgvBaoCaoDoanhThu.CurrentRow.Cells["TenSP"].Value.ToString();
            cboTenSP.Text = Functions.GetFieldValues("SELECT TenSP FROM tblSanPham WHERE TenSP = N'" + ma + "'");
            txtSoLuong.Text = dgvBaoCaoDoanhThu.CurrentRow.Cells["SoLuongBan"].Value.ToString();
            txtGiaBan.Text = dgvBaoCaoDoanhThu.CurrentRow.Cells["GiaSanPham"].Value.ToString();
            mskTheoNgay.Text = DateTime.Parse(dgvBaoCaoDoanhThu.CurrentRow.Cells["NgayBan"].Value.ToString()).ToString("dd/MM/yyyy");
            txtDoanhThu.Text = dgvBaoCaoDoanhThu.CurrentRow.Cells["DoanhThuSanPham"].Value.ToString();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sql;
            if (cboTenSP.SelectedValue == null && txtSoLuong.Text == "0" && txtGiaBan.Text == "0" && mskTheoNgay.Text == "  /  /" && mskTheoKhoang1.Text == "  /  /" && mskTheoKhoang2.Text == "  /  /" && txtDoanhThu.Text == "0")
            {
                MessageBox.Show("Hãy nhập ít nhất 1 dữ liệu để tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if ((mskTheoKhoang1.Text != "  /  /" && mskTheoKhoang2.Text == "  /  /") || (mskTheoKhoang1.Text == "  /  /" && mskTheoKhoang2.Text != "  /  /"))
            {
                MessageBox.Show("Bạn phải nhập đủ cả ngày bắt đầu và ngày kết thúc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            sql = "SELECT * FROM tblDoanhThu where 1=1";
            if (cboTenSP.SelectedValue != null)
            {
                sql += " AND TenSP = N'" + cboTenSP.Text + "'";
            }
            if (txtSoLuong.Text != "0")
            {
                sql += " AND SoLuongBan = " + txtSoLuong.Text;
            }
            if (txtGiaBan.Text != "0")
            {
                sql += " AND GiaSanPham = " + txtGiaBan.Text;
            }
            if (mskTheoNgay.Text != "  /  /")
            {
                if (!Functions.IsDate(mskTheoNgay.Text))
                {
                    MessageBox.Show("Hãy nhập lại ngày bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mskTheoNgay.Focus();
                    mskTheoNgay.Text = "";
                    return;
                }
                sql += " and CONVERT(date, NgayBan) = '" + Functions.ConvertDateTime(mskTheoNgay.Text) + "'";
            }
            if (mskTheoKhoang1.Text != "  /  /" && mskTheoKhoang2.Text != "  /  /")
            {
                if (!Functions.IsDate(mskTheoKhoang2.Text) || !Functions.IsDate(mskTheoKhoang1.Text))
                {
                    MessageBox.Show("Hãy nhập lại ngày", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mskTheoKhoang2.Focus();
                    mskTheoKhoang2.Text = "";
                    mskTheoKhoang1.Text = "";
                    return;
                }
                if (DateTime.ParseExact(mskTheoKhoang1.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture) > DateTime.ParseExact(mskTheoKhoang2.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture))
                {
                    MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mskTheoKhoang2.Text = "";
                    mskTheoKhoang1.Text = "";
                    return;
                }
                sql += " AND (CONVERT(date, NgayBan) BETWEEN '" + Functions.ConvertDateTime(mskTheoKhoang1.Text) + "' AND '" + Functions.ConvertDateTime(mskTheoKhoang2.Text) + "')";
            }
            if (txtDoanhThu.Text != "0")
            {
                sql += " AND DoanhThuSanPham >= " + txtDoanhThu.Text;
            }
            tblDT = Class.Functions.GetDataToTable(sql);
            if (tblDT.Rows.Count == 0)
            {
                MessageBox.Show("Không có hóa đơn bán nào thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetValues();
                dgvBaoCaoDoanhThu.DataSource = tblDT;
                Load_DataGridView();
            }
            else
            {
                MessageBox.Show("Có " + tblDT.Rows.Count + " hóa đơn bán thỏa mãn điều kiện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvBaoCaoDoanhThu.DataSource = tblDT;
                Load_DataGridView();
                txtTongTien.Text = Functions.GetFieldValues("SELECT SUM(DoanhThuSanPham) FROM  tblDoanhThu WHERE " + sql.Substring(sql.IndexOf("where") + 5));
                lblBangChu.Text = "Bằng chữ:    " + Functions.ChuyenSoSangChu(txtTongTien.Text);
            }
        }

        private void btnTimLai_Click(object sender, EventArgs e)
        {
            ResetValues();
            dgvBaoCaoDoanhThu.DataSource = null;
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tblDoanhThu";
            tblDT = Class.Functions.GetDataToTable(sql);
            dgvBaoCaoDoanhThu.DataSource = tblDT;
            Load_DataGridView();
            Functions.FillCombo("SELECT TenSP FROM tblSanPham", cboTenSP, "TenSP", "TenSP");
            cboTenSP.SelectedIndex = -1;
            txtSoLuong.Text = "0";
            txtGiaBan.Text = "0";
            rdTheoNgay.Checked = false;
            mskTheoNgay.Text = "  /  /";
            mskTheoNgay.Enabled = false;
            rdTheoKhoang.Checked = false;
            grbKhoangNgay.Enabled = false;
            mskTheoKhoang1.Text = "  /  /";
            mskTheoKhoang2.Text = "  /  /";
            txtDoanhThu.Text = "0";
            txtTongTien.Text = Functions.GetFieldValues("SELECT SUM(DoanhThuSanPham) FROM tblDoanhThu");
            lblBangChu.Text = "Bằng chữ:    " + Functions.ChuyenSoSangChu(txtTongTien.Text);
        }

        private void btnInBaoCao_Click(object sender, EventArgs e)
        {
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook;
            COMExcel.Worksheet exSheet;
            COMExcel.Range exRange;

            int hang = 0, cot = 0;

            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            exRange = exSheet.Cells[1, 1];

            exRange.Range["C1:D1:E1"].Font.Size = 14;
            exRange.Range["C1:D1:E1"].Font.Name = "Times new roman";
            exRange.Range["C1:D1:E1"].Font.Bold = true;
            exRange.Range["C1:D1:E1"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C1:D1:E1"].MergeCells = true;
            exRange.Range["C1:D1:E1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C1:D1:E1"].Value = "BÁO CÁO DOANH THU";

            int rowCount = tblDT.Rows.Count;
            int colCount = tblDT.Columns.Count;

            // Phạm vi bắt đầu từ ô A3 và kết thúc ở ô cuối cùng chứa dữ liệu
            COMExcel.Range dataRange = exSheet.Range[exSheet.Cells[3, 1], exSheet.Cells[rowCount + 3, colCount + 1]];

            // Thiết lập viền cho phạm vi dữ liệu
            dataRange.Borders.LineStyle = COMExcel.XlLineStyle.xlContinuous;
            exRange.Range["A3:F3"].Font.Bold = true;
            exRange.Range["A3:F3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:A3"].Value = "STT";
            exRange.Range["B3:B3"].Value = "Ngày bán";
            exRange.Range["B3:B3"].ColumnWidth = 20;
            exRange.Range["C3:C3"].Value = "Tên sản phẩm";
            exRange.Range["C3:C3"].ColumnWidth = 25;
            exRange.Range["D3:D3"].Value = "Số lượng bán";
            exRange.Range["D3:D3"].ColumnWidth = 15;
            exRange.Range["E3:E3"].Value = "Giá bán sản phẩm";
            exRange.Range["E3:E3"].ColumnWidth = 20;
            exRange.Range["F3:F3"].Value = "Doanh thu sản phẩm ";
            exRange.Range["F3:F3"].ColumnWidth = 20;
            exRange.Range["H3:H3"].Value = "Tổng tiền:";
            exRange.Range["I3:I3"].Value = txtTongTien.Text;

            for (hang = 0; hang < tblDT.Rows.Count; hang++)
            {
                exSheet.Cells[hang + 4, 1] = hang + 1;
                for (cot = 0; cot < tblDT.Columns.Count; cot++)
                {
                    if (tblDT.Columns[cot].ColumnName == "NgayBan")
                        exSheet.Cells[hang + 4, cot + 2] = DateTime.Parse(tblDT.Rows[hang][cot].ToString()).ToString("dd/MM/yyyy HH:mm:ss");
                    else
                        exSheet.Cells[hang + 4, cot + 2] = tblDT.Rows[hang][cot].ToString();
                }
            }

            exApp.Visible = true;
        }

        private void rdTheoNgay_CheckedChanged(object sender, EventArgs e)
        {
            if (rdTheoNgay.Checked == true)
                mskTheoNgay.Enabled = true;
            else
            {
                mskTheoNgay.Enabled = false;
                mskTheoNgay.Text = "  /  /";
            }
        }

        private void rdTheoKhoang_CheckedChanged(object sender, EventArgs e)
        {
            if (rdTheoKhoang.Checked == true)
                grbKhoangNgay.Enabled = true;
            else
            {
                grbKhoangNgay.Enabled = false;
                mskTheoKhoang1.Text = "  /  /";
                mskTheoKhoang2.Text = "  /  /";
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtDoanhThu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}