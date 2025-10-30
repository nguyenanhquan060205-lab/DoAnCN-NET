using DoAnCN_NET.Forms;
using DoAnCN_NET.Models;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace DoAnCN_NET.UserControls.Giangvien
{
    public partial class UC_ThongTinLop : UserControl
    {
        private int giangVienID;
        public UC_ThongTinLop(int idGV)
        {
            giangVienID = idGV;
            InitializeComponent();
        }

        private void btnTaiDanhSach_Click(object sender, EventArgs e)
        {

            using (var db = new QLDIEMDANHEntities())
            {
                var dsLopHoc = db.LopHocs
                    .Where(l => l.GiangVienID == giangVienID)
                    .Select(l => new
                    {
                        l.LopHocID,
                        Tenlop = l.Tenlop,
                        TenMon = l.MonHoc.TenMon,
                        l.HocKy,
                        l.NamHoc,
                        LoaiBuoi = l.BuoiHocs
                                    .Select(b => b.LoaiBuoi)
                                    .FirstOrDefault(),
                        SoLuongSV = l.DangKyLops.Count()
                    })
                    .ToList();

                dgvLopHoc.DataSource = dsLopHoc;

                if (dgvLopHoc.Columns.Contains("Tenlop"))
                    dgvLopHoc.Columns["Tenlop"].HeaderText = "Tên lớp";
                if (dgvLopHoc.Columns.Contains("TenMon"))
                    dgvLopHoc.Columns["TenMon"].HeaderText = "Môn học";
                if (dgvLopHoc.Columns.Contains("HocKy"))
                    dgvLopHoc.Columns["HocKy"].HeaderText = "Học kỳ";
                if (dgvLopHoc.Columns.Contains("NamHoc"))
                    dgvLopHoc.Columns["NamHoc"].HeaderText = "Năm học";
                if (dgvLopHoc.Columns.Contains("LoaiBuoi"))
                    dgvLopHoc.Columns["LoaiBuoi"].HeaderText = "Loại buổi";
                if (dgvLopHoc.Columns.Contains("SoLuongSV"))
                    dgvLopHoc.Columns["SoLuongSV"].HeaderText = "Số lượng SV";

                dgvLopHoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvLopHoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (cboxMon.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn môn học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int monHocID = (int)cboxMon.SelectedValue;
            int? lopID = cboxTimlop.SelectedValue as int?;

            using (var db = new QLDIEMDANHEntities())
            {
                var dsLopHoc = db.LopHocs
                    .Where(l => l.GiangVienID == giangVienID &&
                                l.MonHocID == monHocID &&
                                (lopID == null || l.LopHocID == lopID))
                    .Select(l => new
                    {
                        l.LopHocID,
                        l.Tenlop,
                        TenMon = l.MonHoc.TenMon,
                        l.HocKy,
                        l.NamHoc,
                        LoaiBuoi = l.BuoiHocs.FirstOrDefault().LoaiBuoi,
                        SoLuongSV = l.DangKyLops.Count()
                    })
                    .ToList();

                dgvLopHoc.DataSource = dsLopHoc;
                dgvLopHoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvLopHoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }

        }

        private void UC_ThongTinLop_Load(object sender, EventArgs e)
        {
            using (var db = new QLDIEMDANHEntities())
            {
                var dsMonHoc = db.LopHocs
                    .Where(l => l.GiangVienID == giangVienID)
                    .Select(l => new { l.MonHoc.MonHocID, l.MonHoc.TenMon })
                    .Distinct()
                    .ToList();

                // Set DisplayMember/ValueMember BEFORE assigning DataSource to avoid SelectedIndexChanged
                cboxMon.DisplayMember = "TenMon";
                cboxMon.ValueMember = "MonHocID";
                cboxMon.DataSource = dsMonHoc;
                cboxMon.SelectedIndex = -1;

                cboxTimlop.DataSource = null;
                cboxTimlop.Text = "-- Chọn môn trước --";
            }
        }

        private void cboxMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxMon.SelectedValue == null)
                return;

            int monHocID = Convert.ToInt32(cboxMon.SelectedValue);

            using (var db = new QLDIEMDANHEntities())
            {
                var dsLop = db.LopHocs
                    .Where(l => l.MonHocID == monHocID && l.GiangVienID == giangVienID)
                    .Select(l => new { l.LopHocID, l.Tenlop })
                    .ToList();

                cboxTimlop.DataSource = dsLop;
                // Fix DisplayMember to match anonymous property name
                cboxTimlop.DisplayMember = "Tenlop";
                cboxTimlop.ValueMember = "LopHocID";
                cboxTimlop.SelectedIndex = -1;
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            cboxMon.SelectedIndex = -1;
            cboxTimlop.DataSource = null;
            cboxTimlop.Text = "-- Chọn môn trước --";
            dgvLopHoc.DataSource = null;
        }
        private int selectedLopHocID = 0;
        private void dgvLopHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedLopHocID = Convert.ToInt32(dgvLopHoc.Rows[e.RowIndex].Cells["LopHocID"].Value);
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (dgvLopHoc.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn lớp cần xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int lopHocID = Convert.ToInt32(dgvLopHoc.CurrentRow.Cells["LopHocID"].Value);

            using (var db = new QLDIEMDANHEntities())
            {
                var lop = db.LopHocs.Include("MonHoc").FirstOrDefault(l => l.LopHocID == lopHocID);
                if (lop == null)
                {
                    MessageBox.Show("Không tìm thấy thông tin lớp học!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SaveFileDialog sfd = new SaveFileDialog
                {
                    Filter = "Excel Files|*.xlsx",
                    FileName = $"ThongTin_{lop.Tenlop}_{DateTime.Now:yyyyMMdd_HHmm}.xlsx"
                };

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ExportToExcel(lopHocID, sfd.FileName);
                    MessageBox.Show("Xuất danh sách điểm danh thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ExportToExcel(int lopHocID, string filePath)
        {
            ExcelPackage.License.SetNonCommercialPersonal("HUIT Project");

            using (var db = new QLDIEMDANHEntities())
            {
                var lop = db.LopHocs
                    .Include(l => l.MonHoc)
                    .Include(l => l.GiangVien.KHOA)
                    .FirstOrDefault(l => l.LopHocID == lopHocID);

                if (lop == null)
                {
                    MessageBox.Show("Không tìm thấy lớp học!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var buoiHocList = db.BuoiHocs
                    .Where(b => b.LopHocID == lopHocID)
                    .OrderBy(b => b.NgayHoc)
                    .ToList();

                var svList = db.DangKyLops
                    .Include(dk => dk.SinhVien.KHOA)
                    .Where(dk => dk.LopHocID == lopHocID)
                    .Select(dk => dk.SinhVien)
                    .ToList();

                var diemDanhList = db.DiemDanhs
                    .Include(dd => dd.BuoiHoc)
                    .Include(dd => dd.SinhVien)
                    .Where(dd => dd.BuoiHoc.LopHocID == lopHocID)
                    .ToList();

                using (var package = new ExcelPackage())
                {
                    var ws = package.Workbook.Worksheets.Add("DiemDanh");

                    // Tiêu đề
                    ws.Cells["A1:H1"].Merge = true;
                    ws.Cells["A1"].Value = $"THÔNG TIN LỚP – {lop.MonHoc.TenMon} ({lop.HocKy})";
                    ws.Cells["A1"].Style.Font.Bold = true;
                    ws.Cells["A1"].Style.Font.Size = 14;
                    ws.Cells["A1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                    // Thông tin lớp
                    ws.Cells["A3"].Value = "Khoa:"; ws.Cells["B3"].Value = lop.GiangVien.KHOA.TENKHOA; // ⚠ EF sinh chữ HOA
                    ws.Cells["A4"].Value = "Lớp:"; ws.Cells["B4"].Value = lop.Tenlop;
                    ws.Cells["C3"].Value = "Giảng viên:"; ws.Cells["D3"].Value = lop.GiangVien.HoTen;
                    ws.Cells["C4"].Value = "Ngày xuất:"; ws.Cells["D4"].Value = DateTime.Now.ToString("dd/MM/yyyy");

                    // Header
                    int startRow = 6;
                    int col = 1;
                    ws.Cells[startRow, col++].Value = "STT";
                    ws.Cells[startRow, col++].Value = "Mã SV";
                    ws.Cells[startRow, col++].Value = "Họ tên";
                    ws.Cells[startRow, col++].Value = "Giới tính";
                    ws.Cells[startRow, col++].Value = "Ngày sinh";
                    ws.Cells[startRow, col++].Value = "Email";
                    ws.Cells[startRow, col++].Value = "Khoa";

                    foreach (var buoi in buoiHocList)
                        ws.Cells[startRow, col++].Value = $"Buổi {buoi.BuoiHocID} ({buoi.LoaiBuoi})";

                    ws.Cells[startRow, col++].Value = "Có mặt";
                    ws.Cells[startRow, col++].Value = "Vắng";
                    ws.Cells[startRow, col++].Value = "Muộn";
                    ws.Cells[startRow, col++].Value = "Tỷ lệ (%)";

                    // Ghi dữ liệu sinh viên
                    int row = startRow + 1;
                    int stt = 1;

                    foreach (var sv in svList)
                    {
                        col = 1;
                        ws.Cells[row, col++].Value = stt++;
                        ws.Cells[row, col++].Value = sv.MaSV;
                        ws.Cells[row, col++].Value = sv.HoTen;
                        ws.Cells[row, col++].Value = sv.GioiTinh;
                        ws.Cells[row, col++].Value = sv.NgaySinh?.ToString("dd/MM/yyyy");
                        ws.Cells[row, col++].Value = sv.Email;
                        ws.Cells[row, col++].Value = sv.KHOA.TENKHOA;

                        int coMat = 0, vang = 0, muon = 0;

                        foreach (var buoi in buoiHocList)
                        {
                            var dd = diemDanhList.FirstOrDefault(x =>
                                x.SinhVienID == sv.SinhVienID && x.BuoiHocID == buoi.BuoiHocID);
                            string tt = dd?.TrangThai ?? "Chưa điểm danh";

                            if (tt == "Có mặt") { ws.Cells[row, col].Value = "✔"; coMat++; }
                            else if (tt == "Vắng") { ws.Cells[row, col].Value = "✖"; vang++; }
                            else if (tt == "Muộn") { ws.Cells[row, col].Value = "⚠"; muon++; }
                            else ws.Cells[row, col].Value = "-";
                            col++;
                        }

                        ws.Cells[row, col++].Value = coMat;
                        ws.Cells[row, col++].Value = vang;
                        ws.Cells[row, col++].Value = muon;
                        double tile = (coMat * 100.0) / Math.Max(1, buoiHocList.Count);
                        ws.Cells[row, col++].Value = $"{tile:F1}%";

                        row++;
                    }

                    ws.Cells[6, 1, row - 1, col - 1].AutoFitColumns();
                    ws.Cells[6, 1, 6, col - 1].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    ws.Cells[6, 1, 6, col - 1].Style.Fill.BackgroundColor.SetColor(Color.FromArgb(0, 122, 204));
                    ws.Cells[6, 1, 6, col - 1].Style.Font.Color.SetColor(Color.White);
                    ws.Cells[6, 1, 6, col - 1].Style.Font.Bold = true;

                    package.SaveAs(new FileInfo(filePath));
                }
            }

        }
    }
}
