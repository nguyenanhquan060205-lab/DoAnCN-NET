namespace DoAnCN_NET.Forms
{
    partial class Giangvien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnDiemdanh = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnThongtinlop = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnLichgiang = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnThongtincanhan = new Guna.UI2.WinForms.Guna2GradientButton();
            this.PnlGiangvien = new System.Windows.Forms.Panel();
            this.btnToggle = new System.Windows.Forms.Button();
            this.menuTimer = new System.Windows.Forms.Timer(this.components);
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Transparent;
            this.pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenu.Controls.Add(this.label1);
            this.pnlMenu.Controls.Add(this.btnThoat);
            this.pnlMenu.Controls.Add(this.btnDiemdanh);
            this.pnlMenu.Controls.Add(this.btnThongtinlop);
            this.pnlMenu.Controls.Add(this.btnLichgiang);
            this.pnlMenu.Controls.Add(this.btnThongtincanhan);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(10, 736);
            this.pnlMenu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 64);
            this.label1.TabIndex = 2;
            this.label1.Text = "HỆ THỐNG QUẢN LÍ \r\nĐIỂM DANH SINH VIÊN\r\n\r\n - GIẢNG VIÊN";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Transparent;
            this.btnThoat.BorderRadius = 15;
            this.btnThoat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThoat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThoat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThoat.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThoat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThoat.FillColor = System.Drawing.Color.Purple;
            this.btnThoat.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Image = global::DoAnCN_NET.Properties.Resources.z7157919336204_142f5b9653ca93ca2bf46b20a0abf4f3;
            this.btnThoat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnThoat.ImageSize = new System.Drawing.Size(50, 50);
            this.btnThoat.Location = new System.Drawing.Point(22, 558);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ShadowDecoration.BorderRadius = 25;
            this.btnThoat.ShadowDecoration.Depth = 15;
            this.btnThoat.ShadowDecoration.Enabled = true;
            this.btnThoat.Size = new System.Drawing.Size(150, 80);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "     Thoát";
            this.btnThoat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDiemdanh
            // 
            this.btnDiemdanh.BackColor = System.Drawing.Color.Transparent;
            this.btnDiemdanh.BorderRadius = 15;
            this.btnDiemdanh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDiemdanh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDiemdanh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDiemdanh.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDiemdanh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDiemdanh.FillColor = System.Drawing.Color.Purple;
            this.btnDiemdanh.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDiemdanh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDiemdanh.ForeColor = System.Drawing.Color.White;
            this.btnDiemdanh.Image = global::DoAnCN_NET.Properties.Resources.z7157946934421_137c0980c115634d1873919de9005a03;
            this.btnDiemdanh.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnDiemdanh.ImageSize = new System.Drawing.Size(50, 50);
            this.btnDiemdanh.Location = new System.Drawing.Point(22, 91);
            this.btnDiemdanh.Name = "btnDiemdanh";
            this.btnDiemdanh.ShadowDecoration.BorderRadius = 25;
            this.btnDiemdanh.ShadowDecoration.Depth = 15;
            this.btnDiemdanh.ShadowDecoration.Enabled = true;
            this.btnDiemdanh.Size = new System.Drawing.Size(148, 81);
            this.btnDiemdanh.TabIndex = 8;
            this.btnDiemdanh.Text = "Điểm Danh";
            this.btnDiemdanh.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDiemdanh.Click += new System.EventHandler(this.btnDiemdanh_Click);
            // 
            // btnThongtinlop
            // 
            this.btnThongtinlop.BackColor = System.Drawing.Color.Transparent;
            this.btnThongtinlop.BorderRadius = 15;
            this.btnThongtinlop.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThongtinlop.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThongtinlop.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThongtinlop.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThongtinlop.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThongtinlop.FillColor = System.Drawing.Color.Purple;
            this.btnThongtinlop.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnThongtinlop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThongtinlop.ForeColor = System.Drawing.Color.White;
            this.btnThongtinlop.Image = global::DoAnCN_NET.Properties.Resources.z7157946936080_d7ba9eec6d84b31482bb47417514d7011;
            this.btnThongtinlop.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnThongtinlop.ImageSize = new System.Drawing.Size(50, 50);
            this.btnThongtinlop.Location = new System.Drawing.Point(22, 206);
            this.btnThongtinlop.Name = "btnThongtinlop";
            this.btnThongtinlop.ShadowDecoration.BorderRadius = 25;
            this.btnThongtinlop.ShadowDecoration.Depth = 15;
            this.btnThongtinlop.ShadowDecoration.Enabled = true;
            this.btnThongtinlop.Size = new System.Drawing.Size(148, 85);
            this.btnThongtinlop.TabIndex = 9;
            this.btnThongtinlop.Text = "Thông Tin                             Lớp";
            this.btnThongtinlop.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThongtinlop.Click += new System.EventHandler(this.btnThongtinlop_Click);
            // 
            // btnLichgiang
            // 
            this.btnLichgiang.BackColor = System.Drawing.Color.Transparent;
            this.btnLichgiang.BorderRadius = 15;
            this.btnLichgiang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLichgiang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLichgiang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLichgiang.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLichgiang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLichgiang.FillColor = System.Drawing.Color.Purple;
            this.btnLichgiang.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLichgiang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLichgiang.ForeColor = System.Drawing.Color.White;
            this.btnLichgiang.Image = global::DoAnCN_NET.Properties.Resources.Untitled11;
            this.btnLichgiang.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnLichgiang.ImageSize = new System.Drawing.Size(50, 50);
            this.btnLichgiang.Location = new System.Drawing.Point(22, 323);
            this.btnLichgiang.Name = "btnLichgiang";
            this.btnLichgiang.ShadowDecoration.BorderRadius = 25;
            this.btnLichgiang.ShadowDecoration.Depth = 15;
            this.btnLichgiang.ShadowDecoration.Enabled = true;
            this.btnLichgiang.Size = new System.Drawing.Size(150, 85);
            this.btnLichgiang.TabIndex = 10;
            this.btnLichgiang.Text = "Lịch Giảng";
            this.btnLichgiang.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLichgiang.Click += new System.EventHandler(this.btnLichgiang_Click);
            // 
            // btnThongtincanhan
            // 
            this.btnThongtincanhan.BackColor = System.Drawing.Color.Transparent;
            this.btnThongtincanhan.BorderRadius = 15;
            this.btnThongtincanhan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThongtincanhan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThongtincanhan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThongtincanhan.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThongtincanhan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThongtincanhan.FillColor = System.Drawing.Color.Purple;
            this.btnThongtincanhan.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnThongtincanhan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThongtincanhan.ForeColor = System.Drawing.Color.White;
            this.btnThongtincanhan.Image = global::DoAnCN_NET.Properties.Resources.Untitled;
            this.btnThongtincanhan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnThongtincanhan.ImageSize = new System.Drawing.Size(50, 50);
            this.btnThongtincanhan.Location = new System.Drawing.Point(22, 441);
            this.btnThongtincanhan.Name = "btnThongtincanhan";
            this.btnThongtincanhan.ShadowDecoration.BorderRadius = 25;
            this.btnThongtincanhan.ShadowDecoration.Depth = 15;
            this.btnThongtincanhan.ShadowDecoration.Enabled = true;
            this.btnThongtincanhan.Size = new System.Drawing.Size(148, 85);
            this.btnThongtincanhan.TabIndex = 11;
            this.btnThongtincanhan.Text = "Thông Tin                           Cá Nhân";
            this.btnThongtincanhan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThongtincanhan.Click += new System.EventHandler(this.btnThongtincanhan_Click);
            // 
            // PnlGiangvien
            // 
            this.PnlGiangvien.BackColor = System.Drawing.Color.Thistle;
            this.PnlGiangvien.Location = new System.Drawing.Point(12, 4);
            this.PnlGiangvien.Name = "PnlGiangvien";
            this.PnlGiangvien.Size = new System.Drawing.Size(1332, 726);
            this.PnlGiangvien.TabIndex = 3;
            // 
            // btnToggle
            // 
            this.btnToggle.Location = new System.Drawing.Point(0, 290);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Size = new System.Drawing.Size(27, 28);
            this.btnToggle.TabIndex = 4;
            this.btnToggle.Text = ">";
            this.btnToggle.UseVisualStyleBackColor = true;
            this.btnToggle.Click += new System.EventHandler(this.btnToggle_Click);
            // 
            // menuTimer
            // 
            this.menuTimer.Interval = 10;
            this.menuTimer.Tick += new System.EventHandler(this.menuTimer_Tick);
            // 
            // Giangvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1347, 736);
            this.Controls.Add(this.btnToggle);
            this.Controls.Add(this.PnlGiangvien);
            this.Controls.Add(this.pnlMenu);
            this.Name = "Giangvien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hệ thống quản lí điểm danh - GIẢNG VIÊN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Giangvien_FormClosing);
            this.Load += new System.EventHandler(this.Giangvien_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel PnlGiangvien;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientButton btnLichgiang;
        private Guna.UI2.WinForms.Guna2GradientButton btnDiemdanh;
        private Guna.UI2.WinForms.Guna2GradientButton btnThongtinlop;
        private Guna.UI2.WinForms.Guna2GradientButton btnThongtincanhan;
        private Guna.UI2.WinForms.Guna2GradientButton btnThoat;
        private System.Windows.Forms.Button btnToggle;
        private System.Windows.Forms.Timer menuTimer;
    }
}