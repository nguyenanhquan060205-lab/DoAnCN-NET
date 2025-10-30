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
using System.Data.Entity;

namespace DoAnCN_NET.UserControls.Giangvien
{
    public partial class UC_LichGiang : UserControl
    {
        private int giangVienID;
        public UC_LichGiang(int idGV)
        {
            giangVienID = idGV;
            InitializeComponent();
        }

        private void UC_LichGiang_Load(object sender, EventArgs e)
        {
            using (var db = new QLDIEMDANHEntities())
            {
                // Load học kỳ
                var hocKyList = db.LopHocs.Select(l => l.HocKy).Distinct().ToList();
                cboHocKy.DataSource = hocKyList;


                // Load năm học
                var namHocList = db.LopHocs.Select(l => l.NamHoc).Distinct().ToList();
                cboNamHoc.DataSource = namHocList;

                // Load tên môn (ban đầu trống, chỉ load khi chọn Học kỳ/Năm học)
                cboHocKy.SelectedIndex = -1;
                cboNamHoc.SelectedIndex = -1;
                cboTenMon.SelectedIndex = -1;
                cboTenMon.DataSource = null;

                // 🔥 Load mặc định tất cả buổi giảng của giảng viên này
                var tatCaBuoi = db.BuoiHocs
                    .Include(b => b.LopHoc)
                    .Include(b => b.LopHoc.MonHoc)
                    .Where(b => b.LopHoc.GiangVienID == giangVienID)
                    .Select(b => new
                    {
                        b.BuoiHocID,
                        TenLop = b.LopHoc.Tenlop,
                        MonHoc = b.LopHoc.MonHoc.TenMon,
                        b.NgayHoc,
                        b.GioBatDau,
                        b.GioKetThuc,
                        b.LoaiBuoi
                    })
                    .OrderBy(b => b.NgayHoc)
                    .ToList();

                dtgLichGiang.DataSource = tatCaBuoi;

                // Đặt lại header
                dtgLichGiang.Columns["BuoiHocID"].Visible = false;
                dtgLichGiang.Columns["TenLop"].HeaderText = "Tên lớp";
                dtgLichGiang.Columns["MonHoc"].HeaderText = "Môn học";
                dtgLichGiang.Columns["NgayHoc"].HeaderText = "Ngày học";
                dtgLichGiang.Columns["GioBatDau"].HeaderText = "Bắt đầu";
                dtgLichGiang.Columns["GioKetThuc"].HeaderText = "Kết thúc";
                dtgLichGiang.Columns["LoaiBuoi"].HeaderText = "Loại buổi";
                dtgLichGiang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dtgLichGiang.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                dtgLichGiang.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                dtgLichGiang.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtgLichGiang.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtgLichGiang.RowTemplate.Height = 28;
            }
        }

        private void cboHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMonHocTheoFilter();
        }

        private void cboNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMonHocTheoFilter();
        }
        private void LoadMonHocTheoFilter()
        {
            if (cboHocKy.SelectedItem == null || cboNamHoc.SelectedItem == null)
                return;

            using (var db = new QLDIEMDANHEntities())
            {
                var hocKy = cboHocKy.SelectedItem.ToString();
                var namHoc = cboNamHoc.SelectedItem.ToString();

                var monList = db.LopHocs
                    .Include(l => l.MonHoc)
                    .Where(l => l.GiangVienID == giangVienID &&
                                l.HocKy == hocKy &&
                                l.NamHoc == namHoc)
                    .Select(l => l.MonHoc.TenMon)
                    .Distinct()
                    .ToList();

                cboTenMon.DataSource = monList;
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (cboHocKy.SelectedItem == null || cboNamHoc.SelectedItem == null || cboTenMon.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn đầy đủ học kỳ, năm học và môn học!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string hocKy = cboHocKy.SelectedItem.ToString();
            string namHoc = cboNamHoc.SelectedItem.ToString();
            string tenMon = cboTenMon.SelectedItem.ToString();
            DateTime ngay = dtpNgay.Value.Date;

            using (var db = new QLDIEMDANHEntities())
            {
                var danhSachBuoi = db.BuoiHocs
                    .Include(b => b.LopHoc)
                    .Include(b => b.LopHoc.MonHoc)
                    .Where(b => b.LopHoc.GiangVienID == giangVienID &&
                                b.LopHoc.HocKy == hocKy &&
                                b.LopHoc.NamHoc == namHoc &&
                                b.LopHoc.MonHoc.TenMon == tenMon &&
                                b.NgayHoc == ngay)
                    .Select(b => new
                    {
                        b.BuoiHocID,
                        TenLop = b.LopHoc.Tenlop,
                        MonHoc = b.LopHoc.MonHoc.TenMon,
                        b.NgayHoc,
                        b.GioBatDau,
                        b.GioKetThuc,
                        b.LoaiBuoi
                    })
                    .ToList();

                dtgLichGiang.DataSource = danhSachBuoi;
            }

            // =============================
            // 🎨 Định dạng DataGridView
            // =============================
            try
            {
                if (dtgLichGiang.Columns.Contains("BuoiHocID"))
                    dtgLichGiang.Columns["BuoiHocID"].Visible = false;

                if (dtgLichGiang.Columns.Contains("TenLop"))
                    dtgLichGiang.Columns["TenLop"].HeaderText = "Tên lớp";

                if (dtgLichGiang.Columns.Contains("MonHoc"))
                    dtgLichGiang.Columns["MonHoc"].HeaderText = "Môn học";

                if (dtgLichGiang.Columns.Contains("NgayHoc"))
                    dtgLichGiang.Columns["NgayHoc"].HeaderText = "Ngày học";

                if (dtgLichGiang.Columns.Contains("GioBatDau"))
                    dtgLichGiang.Columns["GioBatDau"].HeaderText = "Bắt đầu";

                if (dtgLichGiang.Columns.Contains("GioKetThuc"))
                    dtgLichGiang.Columns["GioKetThuc"].HeaderText = "Kết thúc";

                if (dtgLichGiang.Columns.Contains("LoaiBuoi"))
                    dtgLichGiang.Columns["LoaiBuoi"].HeaderText = "Loại buổi";

                // Căn chỉnh và font
                dtgLichGiang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dtgLichGiang.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                dtgLichGiang.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                dtgLichGiang.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtgLichGiang.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtgLichGiang.RowTemplate.Height = 28;
            }
            catch (Exception)
            {
                // Không làm gì nếu lỗi nhỏ (vd: chưa có dữ liệu)
            }
        }


        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            using (var db = new QLDIEMDANHEntities())
            {
                // Xóa chọn trong combobox (về null)
                cboHocKy.SelectedIndex = -1;
                cboNamHoc.SelectedIndex = -1;
                cboTenMon.DataSource = null;

                // Lấy tất cả buổi giảng của giảng viên hiện tại
                var tatCaBuoi = db.BuoiHocs
                    .Include(b => b.LopHoc)
                    .Include(b => b.LopHoc.MonHoc)
                    .Where(b => b.LopHoc.GiangVienID == giangVienID)
                    .Select(b => new
                    {
                        b.BuoiHocID,
                        TenLop = b.LopHoc.Tenlop,
                        MonHoc = b.LopHoc.MonHoc.TenMon,
                        b.NgayHoc,
                        b.GioBatDau,
                        b.GioKetThuc,
                        b.LoaiBuoi
                    })
                    .OrderBy(b => b.NgayHoc)
                    .ToList();

                dtgLichGiang.DataSource = tatCaBuoi;

                // Cập nhật lại header
                dtgLichGiang.Columns["BuoiHocID"].Visible = false;
                dtgLichGiang.Columns["TenLop"].HeaderText = "Tên lớp";
                dtgLichGiang.Columns["MonHoc"].HeaderText = "Môn học";
                dtgLichGiang.Columns["NgayHoc"].HeaderText = "Ngày học";
                dtgLichGiang.Columns["GioBatDau"].HeaderText = "Bắt đầu";
                dtgLichGiang.Columns["GioKetThuc"].HeaderText = "Kết thúc";
                dtgLichGiang.Columns["LoaiBuoi"].HeaderText = "Loại buổi";
            }
        }
    }
}
