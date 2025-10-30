using DoAnCN_NET.Forms;
using DoAnCN_NET.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DoAnCN_NET.UserControls
{
    public partial class UC_GiangVien : UserControl
    {
        public UC_GiangVien()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                Color.MediumPurple, Color.RoyalBlue, 45F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }
        
       
        
    }
}
