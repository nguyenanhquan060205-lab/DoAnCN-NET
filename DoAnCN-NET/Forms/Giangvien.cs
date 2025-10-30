using DoAnCN_NET.UserControls;
using DoAnCN_NET.UserControls.Giangvien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnCN_NET.Helpers;

namespace DoAnCN_NET.Forms
{
    public partial class Giangvien : Form
    {
        private int currentGiangVienID;

        public Giangvien(int idGV)
        {
            currentGiangVienID = idGV;
            InitializeComponent();

        }

        private void LoadUserControl(UserControl uc)
        {
            PnlGiangvien.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            PnlGiangvien.Controls.Add(uc);
        }



        private void btnLichgiang_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_LichGiang(currentGiangVienID));
        }

        private void btnThongtinlop_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_ThongTinLop(currentGiangVienID));
        }

        private void btnThongtincanhan_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_ThongTinGV(currentGiangVienID));
        }

        private void btnDiemdanh_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_DiemDanh(currentGiangVienID));
        }

        private void Giangvien_Load(object sender, EventArgs e)
        {
            LoadUserControl(new UC_DiemDanh(currentGiangVienID));
        }
        bool isLogoutClicked = false;
        private void btnThoat_Click(object sender, EventArgs e)
        {
            isLogoutClicked = true;
            Helper.DangXuat(this);

        }

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
                PnlGiangvien.Left += 10; // di chuyển panel nội dung theo
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
                PnlGiangvien.Left -= 10; // di chuyển panel nội dung theo
                if (pnlMenu.Width <= 10)
                {
                    menuTimer.Stop();
                    isCollapsed = true;
                    btnToggle.Text = ">";
                }
            }
        }

        private void Giangvien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isLogoutClicked && e.CloseReason == CloseReason.UserClosing)
            {
                Helper.DangXuat(this,e);
            }
        }


    }
}
