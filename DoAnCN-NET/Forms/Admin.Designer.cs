namespace DoAnCN_NET.Forms
{
    partial class Admin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLophoc = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnMochoc = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnKhoa = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnGiangvien = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnNguoidung = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSinhvien = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnThoat = new Guna.UI2.WinForms.Guna2GradientButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.PnlAdmin = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2BorderlessForm2 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnLophoc);
            this.panel1.Controls.Add(this.btnMochoc);
            this.panel1.Controls.Add(this.btnKhoa);
            this.panel1.Controls.Add(this.btnGiangvien);
            this.panel1.Controls.Add(this.btnNguoidung);
            this.panel1.Controls.Add(this.btnSinhvien);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Location = new System.Drawing.Point(3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 62);
            this.panel1.TabIndex = 0;
            // 
            // btnLophoc
            // 
            this.btnLophoc.BackColor = System.Drawing.Color.Transparent;
            this.btnLophoc.BorderRadius = 15;
            this.btnLophoc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLophoc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLophoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLophoc.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLophoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLophoc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLophoc.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLophoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLophoc.ForeColor = System.Drawing.Color.White;
            this.btnLophoc.Location = new System.Drawing.Point(422, 13);
            this.btnLophoc.Name = "btnLophoc";
            this.btnLophoc.ShadowDecoration.BorderRadius = 25;
            this.btnLophoc.ShadowDecoration.Depth = 15;
            this.btnLophoc.ShadowDecoration.Enabled = true;
            this.btnLophoc.Size = new System.Drawing.Size(89, 37);
            this.btnLophoc.TabIndex = 8;
            this.btnLophoc.Text = "Lớp Học";
            this.btnLophoc.Click += new System.EventHandler(this.btnLophoc_Click);
            // 
            // btnMochoc
            // 
            this.btnMochoc.BackColor = System.Drawing.Color.Transparent;
            this.btnMochoc.BorderRadius = 15;
            this.btnMochoc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMochoc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMochoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMochoc.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMochoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMochoc.FillColor = System.Drawing.Color.Olive;
            this.btnMochoc.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnMochoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMochoc.ForeColor = System.Drawing.Color.White;
            this.btnMochoc.Location = new System.Drawing.Point(293, 13);
            this.btnMochoc.Name = "btnMochoc";
            this.btnMochoc.ShadowDecoration.BorderRadius = 25;
            this.btnMochoc.ShadowDecoration.Depth = 15;
            this.btnMochoc.ShadowDecoration.Enabled = true;
            this.btnMochoc.Size = new System.Drawing.Size(89, 37);
            this.btnMochoc.TabIndex = 12;
            this.btnMochoc.Text = "Môn Học";
            this.btnMochoc.Click += new System.EventHandler(this.btnMonhoc_Click);
            // 
            // btnKhoa
            // 
            this.btnKhoa.BackColor = System.Drawing.Color.Transparent;
            this.btnKhoa.BorderRadius = 15;
            this.btnKhoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKhoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKhoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKhoa.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKhoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKhoa.FillColor = System.Drawing.Color.Green;
            this.btnKhoa.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnKhoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnKhoa.ForeColor = System.Drawing.Color.White;
            this.btnKhoa.Location = new System.Drawing.Point(549, 13);
            this.btnKhoa.Name = "btnKhoa";
            this.btnKhoa.ShadowDecoration.BorderRadius = 25;
            this.btnKhoa.ShadowDecoration.Depth = 15;
            this.btnKhoa.ShadowDecoration.Enabled = true;
            this.btnKhoa.Size = new System.Drawing.Size(89, 37);
            this.btnKhoa.TabIndex = 9;
            this.btnKhoa.Text = "Khoa";
            this.btnKhoa.Click += new System.EventHandler(this.btnKhoa_Click);
            // 
            // btnGiangvien
            // 
            this.btnGiangvien.BackColor = System.Drawing.Color.Transparent;
            this.btnGiangvien.BorderRadius = 15;
            this.btnGiangvien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGiangvien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGiangvien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGiangvien.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGiangvien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGiangvien.FillColor = System.Drawing.Color.Purple;
            this.btnGiangvien.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGiangvien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGiangvien.ForeColor = System.Drawing.Color.White;
            this.btnGiangvien.Location = new System.Drawing.Point(165, 13);
            this.btnGiangvien.Name = "btnGiangvien";
            this.btnGiangvien.ShadowDecoration.BorderRadius = 25;
            this.btnGiangvien.ShadowDecoration.Depth = 15;
            this.btnGiangvien.ShadowDecoration.Enabled = true;
            this.btnGiangvien.Size = new System.Drawing.Size(89, 37);
            this.btnGiangvien.TabIndex = 7;
            this.btnGiangvien.Text = "Giảng Viên";
            this.btnGiangvien.Click += new System.EventHandler(this.btnGiangvien_Click);
            // 
            // btnNguoidung
            // 
            this.btnNguoidung.BackColor = System.Drawing.Color.Transparent;
            this.btnNguoidung.BorderRadius = 15;
            this.btnNguoidung.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNguoidung.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNguoidung.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNguoidung.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNguoidung.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNguoidung.FillColor = System.Drawing.Color.Navy;
            this.btnNguoidung.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnNguoidung.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNguoidung.ForeColor = System.Drawing.Color.White;
            this.btnNguoidung.Location = new System.Drawing.Point(682, 13);
            this.btnNguoidung.Name = "btnNguoidung";
            this.btnNguoidung.ShadowDecoration.BorderRadius = 25;
            this.btnNguoidung.ShadowDecoration.Depth = 15;
            this.btnNguoidung.ShadowDecoration.Enabled = true;
            this.btnNguoidung.Size = new System.Drawing.Size(92, 37);
            this.btnNguoidung.TabIndex = 10;
            this.btnNguoidung.Text = "Người Dùng";
            this.btnNguoidung.Click += new System.EventHandler(this.btnNguoidung_Click);
            // 
            // btnSinhvien
            // 
            this.btnSinhvien.BackColor = System.Drawing.Color.Transparent;
            this.btnSinhvien.BorderRadius = 15;
            this.btnSinhvien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSinhvien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSinhvien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSinhvien.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSinhvien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSinhvien.FillColor = System.Drawing.Color.Maroon;
            this.btnSinhvien.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSinhvien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSinhvien.ForeColor = System.Drawing.Color.White;
            this.btnSinhvien.Location = new System.Drawing.Point(39, 13);
            this.btnSinhvien.Name = "btnSinhvien";
            this.btnSinhvien.ShadowDecoration.BorderRadius = 25;
            this.btnSinhvien.ShadowDecoration.Depth = 15;
            this.btnSinhvien.ShadowDecoration.Enabled = true;
            this.btnSinhvien.Size = new System.Drawing.Size(88, 37);
            this.btnSinhvien.TabIndex = 0;
            this.btnSinhvien.Text = "Sinh Viên";
            this.btnSinhvien.Click += new System.EventHandler(this.btnSinhvien_Click);
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
            this.btnThoat.FillColor = System.Drawing.Color.DarkGray;
            this.btnThoat.FillColor2 = System.Drawing.Color.DarkGray;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(811, 13);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ShadowDecoration.BorderRadius = 25;
            this.btnThoat.ShadowDecoration.Depth = 15;
            this.btnThoat.ShadowDecoration.Enabled = true;
            this.btnThoat.Size = new System.Drawing.Size(89, 37);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "HỆ THỐNG QUẢN LÍ ĐIỂM DANH SINH VIÊN";
            // 
            // PnlAdmin
            // 
            this.PnlAdmin.AutoScroll = true;
            this.PnlAdmin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PnlAdmin.Location = new System.Drawing.Point(3, 117);
            this.PnlAdmin.Name = "PnlAdmin";
            this.PnlAdmin.Size = new System.Drawing.Size(970, 709);
            this.PnlAdmin.TabIndex = 2;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(333, 80);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(22, 16);
            this.lblWelcome.TabIndex = 3;
            this.lblWelcome.Text = "---";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2BorderlessForm2
            // 
            this.guna2BorderlessForm2.ContainerControl = this;
            this.guna2BorderlessForm2.DockIndicatorColor = System.Drawing.Color.IndianRed;
            this.guna2BorderlessForm2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm2.TransparentWhileDrag = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(976, 828);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.PnlAdmin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống quản lí điểm danh - ADMIN";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PnlAdmin;
        private System.Windows.Forms.Label lblWelcome;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm2;
        private Guna.UI2.WinForms.Guna2GradientButton btnSinhvien;
        private Guna.UI2.WinForms.Guna2GradientButton btnLophoc;
        private Guna.UI2.WinForms.Guna2GradientButton btnMochoc;
        private Guna.UI2.WinForms.Guna2GradientButton btnKhoa;
        private Guna.UI2.WinForms.Guna2GradientButton btnGiangvien;
        private Guna.UI2.WinForms.Guna2GradientButton btnNguoidung;
        private Guna.UI2.WinForms.Guna2GradientButton btnThoat;
    }
}