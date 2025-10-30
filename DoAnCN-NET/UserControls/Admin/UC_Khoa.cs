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

namespace DoAnCN_NET.UserControls
{
    public partial class UC_Khoa : UserControl
    {
        
        
        public UC_Khoa()
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
