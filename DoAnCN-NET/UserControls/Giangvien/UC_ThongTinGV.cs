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
    public partial class UC_ThongTinGV : UserControl
    {
        private int giangVienID;
        public UC_ThongTinGV(int idGV)
        {
            InitializeComponent();
            giangVienID = idGV;
        }

        private void UC_ThongTinGV_Load(object sender, EventArgs e)
        {
            using (var db = new QLDIEMDANHEntities())
            {
                var gv = db.GiangViens.Include(g => g.NguoiDung)
                                      .FirstOrDefault(g => g.GiangVienID == giangVienID);
                if (gv != null)
                {
                    txtMaGV.Text = gv.MaGV;
                    txtHoTenGV.Text = gv.HoTen;
                    txtEmail.Text = gv.Email;
                    txtSDT.Text = gv.SDT;
                    txtDiaChi.Text = gv.Diachi;
                    dtpNgaySinh.Value = gv.Ngaysinh ?? DateTime.Now;

                    if (gv.GioiTinh == "Nam")
                        radNam.Checked = true;
                    else
                        radNu.Checked = true;

                    // Khóa các trường không cho chỉnh sửa
                    txtMaGV.Enabled = false;
                    txtHoTenGV.Enabled = false;
                    radNam.Enabled = false;
                    radNu.Enabled = false;
                    dtpNgaySinh.Enabled = false;
                    //pass
                    txtMatKhauCu.UseSystemPasswordChar = true;
                    txtMatKhauMoi.UseSystemPasswordChar = true;
                    txtXacNhan.UseSystemPasswordChar = true;
                }
            }
        }

        private void btnLuuThongTin_Click(object sender, EventArgs e)
        {
            using (var db = new QLDIEMDANHEntities())
            {
                var gv = db.GiangViens.FirstOrDefault(g => g.GiangVienID == giangVienID);
                if (gv == null)
                {
                    MessageBox.Show("Không tìm thấy thông tin giảng viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                gv.Email = txtEmail.Text.Trim();
                gv.SDT = txtSDT.Text.Trim();
                gv.Diachi = txtDiaChi.Text.Trim();

                db.SaveChanges();
                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDoimk_Click(object sender, EventArgs e)
        {
            string oldPass = txtMatKhauCu.Text.Trim();
            string newPass = txtMatKhauMoi.Text.Trim();
            string rePass = txtXacNhan.Text.Trim();

            if (string.IsNullOrEmpty(oldPass) || string.IsNullOrEmpty(newPass) || string.IsNullOrEmpty(rePass))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các trường!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPass != rePass)
            {
                MessageBox.Show("Mật khẩu mới và mật khẩu nhập lại không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var db = new QLDIEMDANHEntities())
            {
                // Lấy giảng viên hiện tại
                var gv = db.GiangViens.FirstOrDefault(g => g.GiangVienID == giangVienID);
                if (gv == null || gv.UserID == null)
                {
                    MessageBox.Show("Không tìm thấy tài khoản giảng viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Lấy thông tin người dùng trong bảng NguoiDung
                var user = db.NguoiDungs.FirstOrDefault(u => u.UserID == gv.UserID);
                if (user == null)
                {
                    MessageBox.Show("Không tìm thấy thông tin đăng nhập!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kiểm tra mật khẩu cũ
                if (user.Password != oldPass)
                {
                    MessageBox.Show("Mật khẩu cũ không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Cập nhật mật khẩu mới
                user.Password = newPass;
                db.SaveChanges();

                MessageBox.Show("Đổi mật khẩu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Xoá nội dung textbox sau khi đổi
                txtMatKhauCu.Clear();
                txtMatKhauMoi.Clear();
                txtXacNhan.Clear();
            }
        }

        private void chckHienmk_CheckedChanged(object sender, EventArgs e)
        {
            bool hien = cboHienMK.Checked;

            txtMatKhauCu.UseSystemPasswordChar = !hien;
            txtMatKhauMoi.UseSystemPasswordChar = !hien;
            txtXacNhan.UseSystemPasswordChar = !hien;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMatKhauCu.Clear();
            txtMatKhauMoi.Clear();
            txtXacNhan.Clear();
            cboHienMK.Checked = false;
        }
    }
}
