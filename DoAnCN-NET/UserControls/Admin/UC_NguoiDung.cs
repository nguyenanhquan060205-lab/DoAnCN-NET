using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCN_NET.UserControls
{
    public partial class UC_NguoiDung : UserControl
    {
        public UC_NguoiDung()
        {
            InitializeComponent();
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

        private void UC_NguoiDung_Load(object sender, EventArgs e)
        {
            picShowHide.Image = Properties.Resources.hideeyes;
        }
    }
}
