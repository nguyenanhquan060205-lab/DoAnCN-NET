using DoAnCN_NET.Models;
using DoAnCN_NET.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCN_NET.Forms
{
    public partial class Admin : Form
    {
        private int _userID;
        public Admin(int userID)
        {
            InitializeComponent();
            _userID = userID;
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
        private bool isExitButtonClicked = false;
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
        private void Admin_Load(object sender, EventArgs e)
        {
            LoadUserControl(new UC_SinhVien());
  
            using (var db = new QLDIEMDANHEntities())
            {
                var user = db.NguoiDungs.FirstOrDefault(u => u.UserID == _userID);
                if (user != null)
                {
                    lblWelcome.Text = user.Username;
                }
            }

           
        }

      
        
    }
}

