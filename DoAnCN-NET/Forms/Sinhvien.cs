using DoAnCN_NET.UserControls.Giangvien;
using DoAnCN_NET.UserControls.Sinhvien;
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
    public partial class Sinhvien : Form
    {
        public Sinhvien()
        {
            InitializeComponent();
        }
        private void LoadUserControl(UserControl uc)
        {
            PnlSinhvien.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            PnlSinhvien.Controls.Add(uc);
        }

        private void btnThongtincanhansv_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_ThongTinSV());
        }

        private void btnDiemdanhsv_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_DiemDanhSV());
        }

        private void btnThongtinlopsv_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_ThongTinLopSV());
        }

        private void btnLichhoc_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_LichHoc());
        }

        private void Sinhvien_Load(object sender, EventArgs e)
        {
            LoadUserControl(new UC_ThongTinSV());
        }
    }
}
