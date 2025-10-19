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

namespace DoAnCN_NET.Forms
{
    public partial class Giangvien : Form
    {
        public Giangvien()
        {
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
            LoadUserControl(new UC_LichGiang());
        }

        private void btnThongtinlop_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_ThongTinLop());
        }

        private void btnThongtincanhan_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_ThongTinGV());
        }

        private void btnDiemdanh_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_DiemDanh());
        }

        private void Giangvien_Load(object sender, EventArgs e)
        {
            LoadUserControl(new UC_SinhVien());
        }
    }
}
