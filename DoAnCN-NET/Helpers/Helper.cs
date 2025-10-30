using System;
using System.Windows.Forms;
using DoAnCN_NET.Forms;
namespace DoAnCN_NET.Helpers
{
    public static class Helper
    {
        public static void DangXuat(Form currentForm, FormClosingEventArgs e = null)
        {
            DialogResult result = MessageBox.Show(
            "Bạn có chắc chắn muốn đăng xuất và quay lại trang đăng nhập không?",
            "Xác nhận đăng xuất",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2
        );

            if (result == DialogResult.Yes)
            {
                currentForm.Hide();
            }
            else
            {
                if (e != null)
                    e.Cancel = true;
            }
        }

    }

}
