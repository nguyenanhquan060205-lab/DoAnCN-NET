using DoAnCN_NET.Forms;
using DoAnCN_NET.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using OfficeOpenXml.Style;
namespace DoAnCN_NET.UserControls.Giangvien

{
    public partial class UC_DiemDanh : UserControl
    {
        private int giangVienID;
        public UC_DiemDanh(int idGV)
        {
            giangVienID = idGV;
            InitializeComponent();
        }

        private void UC_DiemDanh_Load(object sender, EventArgs e)
        {

            LoadMonHoc();
            LoadBuoi();

        }
        private void LoadLopHoc()
        {
            using (var db = new QLDIEMDANHEntities())
            {
                var lops = db.LopHocs
                    .Where(l => l.GiangVienID == giangVienID)
                    .Select(l => new { l.LopHocID, l.Tenlop })
                    .ToList();

                cboLop.DisplayMember = "TenLop";
                cboLop.ValueMember = "LopHocID";
                cboLop.DataSource = lops;
                cboLop.SelectedIndex = -1;
            }
        }
        private void LoadMonHoc()
        {
            using (var db = new QLDIEMDANHEntities())
            {
                var monhoc = db.LopHocs
                    .Where(l => l.GiangVienID == giangVienID)
                    .Select(l => new { l.MonHocID, l.MonHoc.TenMon })
                    .Distinct()
                    .ToList();

                cboMonHoc.DataSource = monhoc;
                cboMonHoc.DisplayMember = "TenMon";
                cboMonHoc.ValueMember = "MonHocID";
            }
        }
        private QLDIEMDANHEntities db = new QLDIEMDANHEntities();
        private void LoadBuoi()
        {
            if (cboLop.SelectedValue == null)
                return;

            int lopHocID = Convert.ToInt32(cboLop.SelectedValue);

            var buoiList = db.BuoiHocs
                .Where(b => b.LopHocID == lopHocID)
                .OrderBy(b => b.NgayHoc)
                .Select(b => new { b.BuoiHocID, b.LoaiBuoi, b.NgayHoc })
                .ToList();

            cboBuoi.DisplayMember = "LoaiBuoi";
            cboBuoi.ValueMember = "BuoiHocID";
            cboBuoi.DataSource = buoiList;
            cboBuoi.SelectedIndex = -1;

            cboBuoi.SelectedIndexChanged += (s, e) =>
            {
                if (cboBuoi.SelectedValue != null)
                {
                    int buoiID = Convert.ToInt32(cboBuoi.SelectedValue);
                    var buoi = db.BuoiHocs.FirstOrDefault(b => b.BuoiHocID == buoiID);
                    if (buoi != null)
                        dtNgay.Value = buoi.NgayHoc;
                }
            };
        }





        private void btnTaiDanhSach_Click(object sender, EventArgs e)
        {
            if (cboLop.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Lớp học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboMonHoc.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Môn học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboBuoi.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Buổi học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int lopID = (int)cboLop.SelectedValue;
            int buoiHocID = (int)cboBuoi.SelectedValue;

            using (var db = new QLDIEMDANHEntities())
            {
                var dsSinhVien = db.DangKyLops
                    .Where(dk => dk.LopHocID == lopID)
                    .Select(dk => dk.SinhVien)
                    .ToList();

                var dsDiemDanh = db.DiemDanhs
                    .Where(dd => dd.BuoiHocID == buoiHocID)
                    .ToList();

                // 🟢 Tạo DataTable
                DataTable dt = new DataTable();
                dt.Columns.Add("SinhVienID", typeof(int));
                dt.Columns.Add("MaSV", typeof(string));
                dt.Columns.Add("HoTen", typeof(string));
                dt.Columns.Add("Lop", typeof(string));
                dt.Columns.Add("TrangThai", typeof(string));
                dt.Columns.Add("ThoiGianCheckin", typeof(DateTime));
                dt.Columns.Add("GhiChu", typeof(string)); // 🟩 thêm cột ghi chú

                foreach (var sv in dsSinhVien)
                {
                    var diem = dsDiemDanh.FirstOrDefault(d => d.SinhVienID == sv.SinhVienID);

                    dt.Rows.Add(
                        sv.SinhVienID,
                        sv.MaSV,
                        sv.HoTen,
                        sv.Lop,
                        diem?.TrangThai ?? "Chưa điểm danh",
                        (object)diem?.ThoiGianCheckin ?? DBNull.Value,
                        diem?.GhiChu ?? "" //lấy ghi chú từ DB (nếu có)
                    );
                }

                dgvSinhVien.DataSource = dt;

                // Xoá cột thừa (mũi tên bên trái)
                dgvSinhVien.RowHeadersVisible = false;

                // Thêm cột STT nếu chưa có
                if (!dgvSinhVien.Columns.Contains("STT"))
                {
                    DataGridViewTextBoxColumn sttCol = new DataGridViewTextBoxColumn();
                    sttCol.Name = "STT";
                    sttCol.HeaderText = "STT";
                    sttCol.ReadOnly = true;
                    sttCol.Width = 50;
                    dgvSinhVien.Columns.Insert(0, sttCol);
                }

                //Gán số thứ tự cho từng dòng
                for (int i = 0; i < dgvSinhVien.Rows.Count; i++)
                {
                    dgvSinhVien.Rows[i].Cells["STT"].Value = i + 1;
                }

                //Cấu hình DataGridView
                dgvSinhVien.AllowUserToAddRows = false;
                dgvSinhVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvSinhVien.MultiSelect = false;
                dgvSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvSinhVien.Columns["SinhVienID"].Visible = false;

                //Cột ghi chú cho phép nhập — các cột khác chỉ đọc
                foreach (DataGridViewColumn col in dgvSinhVien.Columns)
                {
                    col.ReadOnly = true;
                }
                dgvSinhVien.Columns["GhiChu"].ReadOnly = false; // chỉ cột Ghi chú cho phép sửa
                //Đổi tên hiển thị các cột sang tiếng Việt
                dgvSinhVien.Columns["MaSV"].HeaderText = "Mã SV";
                dgvSinhVien.Columns["HoTen"].HeaderText = "Họ tên";
                dgvSinhVien.Columns["Lop"].HeaderText = "Lớp";
                dgvSinhVien.Columns["TrangThai"].HeaderText = "Trạng thái";
                dgvSinhVien.Columns["ThoiGianCheckin"].HeaderText = "Thời gian điểm danh";
                dgvSinhVien.Columns["GhiChu"].HeaderText = "Ghi chú";
            }
        }

        private void cboMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadLopHoc();

        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadBuoi();
        }

        private void cboBuoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboBuoi.SelectedValue != null)
            {
                int buoiID = Convert.ToInt32(cboBuoi.SelectedValue);
                using (var db = new QLDIEMDANHEntities())
                {
                    var buoi = db.BuoiHocs.FirstOrDefault(b => b.BuoiHocID == buoiID);
                    if (buoi != null)
                        dtNgay.Value = buoi.NgayHoc;
                }
            }
        }

        private void btnComat_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvSinhVien.SelectedRows)
            {
                row.Cells["TrangThai"].Value = "Có mặt";
                row.DefaultCellStyle.BackColor = Color.LightGreen;
            }

        }

        private void btnVang_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvSinhVien.SelectedRows)
            {
                row.Cells["TrangThai"].Value = "Vắng";
                row.DefaultCellStyle.BackColor = Color.LightPink;
            }
        }

        private void btnMuon_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvSinhVien.SelectedRows)
            {
                row.Cells["TrangThai"].Value = "Muộn";
                row.DefaultCellStyle.BackColor = Color.Khaki;
            }
        }

        private void btnLuuDiemDanh_Click(object sender, EventArgs e)
        {
            if (cboBuoi.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn buổi học!", "Thông báo");
                return;
            }

            int buoiHocID = (int)cboBuoi.SelectedValue;
            int giangVienID = this.giangVienID;

            using (var db = new QLDIEMDANHEntities())
            {
                foreach (DataGridViewRow row in dgvSinhVien.Rows)
                {
                    if (row.Cells["SinhVienID"].Value == null) continue;

                    int svID = (int)row.Cells["SinhVienID"].Value;
                    string trangThai = row.Cells["TrangThai"].Value?.ToString() ?? "Chưa điểm danh";

                    var diem = db.DiemDanhs.FirstOrDefault(d => d.BuoiHocID == buoiHocID && d.SinhVienID == svID);

                    if (diem == null)
                    {
                        db.DiemDanhs.Add(new DiemDanh
                        {
                            BuoiHocID = buoiHocID,
                            SinhVienID = svID,
                            TrangThai = trangThai,
                            ThoiGianCheckin = DateTime.Now,
                            NguoiDiemDanh = giangVienID
                        });
                    }
                    else
                    {
                        diem.TrangThai = trangThai;
                        diem.ThoiGianCheckin = DateTime.Now;
                        diem.NguoiDiemDanh = giangVienID;
                        diem.GhiChu = row.Cells["GhiChu"].Value?.ToString();
                    }
                }

                db.SaveChanges();
            }

            MessageBox.Show("Lưu điểm danh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvSinhVien.Rows)
            {
                row.Cells["TrangThai"].Value = "Chưa điểm danh";
            }
        }
    }
}
