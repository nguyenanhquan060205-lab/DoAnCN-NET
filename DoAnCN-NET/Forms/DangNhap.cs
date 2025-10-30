using DoAnCN_NET.Forms;
using DoAnCN_NET.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DoAnCN_NET
{

    public partial class DangNhap : Form
    {
        private bool isExitButtonClicked = false;

        public DangNhap()
        {
            InitializeComponent();


        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {


            // Lấy control hiện tại
            Control ctrl = this.ActiveControl;

            // Xử lý phím mũi tên xuống
            if (keyData == Keys.Down)
            {
                if (ctrl == txtUsername)
                    txtPassword.Focus();
                else if (ctrl == txtPassword)
                    cboVaiTro.Focus();
                else if (ctrl == cboVaiTro)
                    btnDangNhap.Focus();
                else if (ctrl == btnDangNhap)
                    txtUsername.Focus();
                return true;
            }

            // Xử lý phím mũi tên lên
            if (keyData == Keys.Up)
            {
                if (ctrl == txtUsername)
                    btnDangNhap.Focus();
                else if (ctrl == txtPassword)
                    txtUsername.Focus();
                else if (ctrl == cboVaiTro)
                    txtPassword.Focus();
                else if (ctrl == btnDangNhap)
                    cboVaiTro.Focus();
                return true;
            }
            // Nếu nhấn phím Enter thì đăng nhập
            if (keyData == Keys.Enter)
            {
                if (this.ActiveControl == btnThoat)
                    btnThoat.PerformClick();
                else
                    btnDangNhap.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }



        private void DangNhap_Load(object sender, EventArgs e)
        {
            using (var db = new QLDIEMDANHEntities())
            {
                var roles = db.NguoiDungs
                              .Select(u => u.Role)
                              .Distinct()
                              .ToList();

                cboVaiTro.DataSource = roles;
            }

            lblError.Visible = false;
            txtPassword.UseSystemPasswordChar = true;
            picShowHide.Image = Properties.Resources.hideeyes;


        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;


            // 1️⃣ Validate trống
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                lblError.Text = "Vui lòng nhập tên tài khoản!";
                lblError.Visible = true;
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                lblError.Text = "Vui lòng nhập mật khẩu!";
                lblError.Visible = true;
                txtPassword.Focus();
                return;
            }

            if (cboVaiTro.SelectedItem == null)
            {
                lblError.Text = "Vui lòng chọn vai trò!";
                lblError.Visible = true;
                cboVaiTro.Focus();
                return;
            }

            //  Kiểm tra DB
            using (var db = new QLDIEMDANHEntities())
            {
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text.Trim();
                string role = cboVaiTro.SelectedItem.ToString();

                var user = db.NguoiDungs
                    .AsEnumerable()
                    .FirstOrDefault(u =>
                        string.Equals(u.Username, username, StringComparison.Ordinal) &&
                        string.Equals(u.Password, password, StringComparison.Ordinal) &&
                        string.Equals(u.Role, role, StringComparison.Ordinal));

                if (user == null)
                {
                    lblError.Text = "Sai tài khoản, mật khẩu hoặc vai trò!";
                    lblError.Visible = true;
                    return;
                }

                MessageBox.Show($"Đăng nhập thành công với vai trò: {role}",
                                "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();

                switch (role)
                {
                    case "Admin": new Admin(user.UserID).ShowDialog(); break;
                    case "Giảng Viên":
                        // Tìm GiangVienID tương ứng với UserID
                        var giangVien = db.GiangViens.FirstOrDefault(g => g.UserID == user.UserID);
                        if (giangVien != null)
                        {
                            this.Hide();
                            Giangvien frm = new Giangvien(giangVien.GiangVienID);
                            frm.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thông tin giảng viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    case "Sinh Viên":
                        var sv = db.SinhViens.FirstOrDefault(s => s.UserID == user.UserID);
                        if (sv != null)
                        {
                            new Sinhvien(sv.SinhVienID).ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thông tin sinh viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                }

                this.Show();
                txtPassword.Clear();
            }
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            isExitButtonClicked = true;

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát chương trình không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2
            );

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                isExitButtonClicked = false;
            }

        }
        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isExitButtonClicked && e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có chắc chắn muốn thoát chương trình không?",
                    "Xác nhận thoát",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2
                );

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
        bool isPasswordVisible = false;
        private void picShowHide_Click(object sender, EventArgs e)
        {
            if (isPasswordVisible)
            {
                txtPassword.UseSystemPasswordChar = true;
                picShowHide.Image = Properties.Resources.hideeyes;
                isPasswordVisible = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
                picShowHide.Image = Properties.Resources.eyes;
                isPasswordVisible = true;
            }
        }
    }
}
