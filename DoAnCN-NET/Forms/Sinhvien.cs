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
        private int _userID;
        bool isCollapsed = true;

        private void btnToggle_Click(object sender, EventArgs e)
        {
            menuTimer.Start();
        }

        private void menuTimer_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                pnlMenu.Width += 10;
                PnlSinhvien.Left += 10; // di chuyển panel nội dung theo
                if (pnlMenu.Width >= 200)
                {
                    menuTimer.Stop();
                    isCollapsed = false;
                    btnToggle.Text = "<";
                }
            }
            else
            {
                pnlMenu.Width -= 10;
                PnlSinhvien.Left -= 10; // di chuyển panel nội dung theo
                if (pnlMenu.Width <= 10)
                {
                    menuTimer.Stop();
                    isCollapsed = true;
                    btnToggle.Text = ">";
                }
            }
        }
        public Sinhvien(int userID)
        {
            InitializeComponent();
            _userID = userID;
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
