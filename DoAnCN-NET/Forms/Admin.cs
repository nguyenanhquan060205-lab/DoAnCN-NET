using DoAnCN_NET.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCN_NET.Forms
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void LoadUserControl(UserControl uc)
        {
            PnlAdmin.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            PnlAdmin.Controls.Add(uc);
        }
        private void btnSinhvien_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_SinhVien());
        }

        private void btnGiangvien_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_GiangVien());
        }

        private void btnMonhoc_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_MonHoc());
        }

        private void btnLophoc_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_LopHoc());
        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_Khoa());
        }

        private void btnNguoidung_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_NguoiDung());
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            LoadUserControl(new UC_SinhVien());
        }
    }
}
