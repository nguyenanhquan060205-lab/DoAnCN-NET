namespace DoAnCN_NET.UserControls.Giangvien
{
    partial class UC_DiemDanh
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.dtNgay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cboMonHoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboLop = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboBuoi = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnCo = new Guna.UI2.WinForms.Guna2Button();
            this.btnVang = new Guna.UI2.WinForms.Guna2Button();
            this.btnMuon = new Guna.UI2.WinForms.Guna2Button();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.btnLamMoi = new Guna.UI2.WinForms.Guna2Button();
            this.btnTai = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(48, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Điểm danh sinh viên";
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(107, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Môn học";
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Buổi";
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(422, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Lớp";
            // 
            // label5
            // 
            this.label5.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(411, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày";
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.BackgroundColor = System.Drawing.Color.Thistle;
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Location = new System.Drawing.Point(3, 249);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.Size = new System.Drawing.Size(1357, 398);
            this.dgvSinhVien.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "DANH SÁCH SINH VIÊN";
            // 
            // dtNgay
            // 
            this.dtNgay.BackColor = System.Drawing.Color.Transparent;
            this.dtNgay.BorderRadius = 15;
            this.dtNgay.Checked = true;
            this.dtNgay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dtNgay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgay.Location = new System.Drawing.Point(476, 148);
            this.dtNgay.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtNgay.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtNgay.Name = "dtNgay";
            this.dtNgay.Size = new System.Drawing.Size(165, 36);
            this.dtNgay.TabIndex = 51;
            this.dtNgay.Value = new System.DateTime(2025, 10, 30, 0, 14, 31, 383);
            // 
            // cboMonHoc
            // 
            this.cboMonHoc.BackColor = System.Drawing.Color.Transparent;
            this.cboMonHoc.BorderRadius = 10;
            this.cboMonHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonHoc.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboMonHoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboMonHoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboMonHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboMonHoc.ItemHeight = 30;
            this.cboMonHoc.Location = new System.Drawing.Point(192, 86);
            this.cboMonHoc.Name = "cboMonHoc";
            this.cboMonHoc.Size = new System.Drawing.Size(165, 36);
            this.cboMonHoc.TabIndex = 52;
            this.cboMonHoc.SelectedIndexChanged += new System.EventHandler(this.cboMonHoc_SelectedIndexChanged);
            // 
            // cboLop
            // 
            this.cboLop.BackColor = System.Drawing.Color.Transparent;
            this.cboLop.BorderRadius = 10;
            this.cboLop.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLop.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboLop.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboLop.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboLop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboLop.ItemHeight = 30;
            this.cboLop.Location = new System.Drawing.Point(476, 86);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(165, 36);
            this.cboLop.TabIndex = 54;
            this.cboLop.SelectedIndexChanged += new System.EventHandler(this.cboLop_SelectedIndexChanged);
            // 
            // cboBuoi
            // 
            this.cboBuoi.BackColor = System.Drawing.Color.Transparent;
            this.cboBuoi.BorderRadius = 10;
            this.cboBuoi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboBuoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuoi.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboBuoi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboBuoi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboBuoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboBuoi.ItemHeight = 30;
            this.cboBuoi.Location = new System.Drawing.Point(192, 148);
            this.cboBuoi.Name = "cboBuoi";
            this.cboBuoi.Size = new System.Drawing.Size(165, 36);
            this.cboBuoi.TabIndex = 55;
            this.cboBuoi.SelectedIndexChanged += new System.EventHandler(this.cboBuoi_SelectedIndexChanged);
            // 
            // btnCo
            // 
            this.btnCo.BackColor = System.Drawing.Color.Transparent;
            this.btnCo.BorderRadius = 10;
            this.btnCo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCo.ForeColor = System.Drawing.Color.White;
            this.btnCo.Location = new System.Drawing.Point(68, 669);
            this.btnCo.Name = "btnCo";
            this.btnCo.Size = new System.Drawing.Size(121, 36);
            this.btnCo.TabIndex = 56;
            this.btnCo.Text = "Có mặt";
            this.btnCo.Click += new System.EventHandler(this.btnComat_Click);
            // 
            // btnVang
            // 
            this.btnVang.BackColor = System.Drawing.Color.Transparent;
            this.btnVang.BorderRadius = 10;
            this.btnVang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnVang.ForeColor = System.Drawing.Color.White;
            this.btnVang.Location = new System.Drawing.Point(239, 669);
            this.btnVang.Name = "btnVang";
            this.btnVang.Size = new System.Drawing.Size(121, 36);
            this.btnVang.TabIndex = 57;
            this.btnVang.Text = "Vắng mặt";
            this.btnVang.Click += new System.EventHandler(this.btnVang_Click);
            // 
            // btnMuon
            // 
            this.btnMuon.BackColor = System.Drawing.Color.Transparent;
            this.btnMuon.BorderRadius = 10;
            this.btnMuon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMuon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMuon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMuon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMuon.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMuon.ForeColor = System.Drawing.Color.White;
            this.btnMuon.Location = new System.Drawing.Point(419, 669);
            this.btnMuon.Name = "btnMuon";
            this.btnMuon.Size = new System.Drawing.Size(121, 36);
            this.btnMuon.TabIndex = 58;
            this.btnMuon.Text = "Muộn";
            this.btnMuon.Click += new System.EventHandler(this.btnMuon_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Transparent;
            this.btnLuu.BorderRadius = 10;
            this.btnLuu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLuu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLuu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLuu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(599, 669);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(121, 36);
            this.btnLuu.TabIndex = 59;
            this.btnLuu.Text = "Lưu điểm danh";
            this.btnLuu.Click += new System.EventHandler(this.btnLuuDiemDanh_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.Transparent;
            this.btnLamMoi.BorderRadius = 10;
            this.btnLamMoi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLamMoi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLamMoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLamMoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(774, 669);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(121, 36);
            this.btnLamMoi.TabIndex = 60;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnTai
            // 
            this.btnTai.BackColor = System.Drawing.Color.Transparent;
            this.btnTai.BorderRadius = 10;
            this.btnTai.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTai.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTai.ForeColor = System.Drawing.Color.White;
            this.btnTai.Location = new System.Drawing.Point(1125, 207);
            this.btnTai.Name = "btnTai";
            this.btnTai.Size = new System.Drawing.Size(167, 36);
            this.btnTai.TabIndex = 61;
            this.btnTai.Text = "Tải danh sách";
            this.btnTai.Click += new System.EventHandler(this.btnTaiDanhSach_Click);
            // 
            // UC_DiemDanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnTai);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnMuon);
            this.Controls.Add(this.btnVang);
            this.Controls.Add(this.btnCo);
            this.Controls.Add(this.cboBuoi);
            this.Controls.Add(this.cboLop);
            this.Controls.Add(this.cboMonHoc);
            this.Controls.Add(this.dtNgay);
            this.Controls.Add(this.dgvSinhVien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "UC_DiemDanh";
            this.Size = new System.Drawing.Size(1363, 726);
            this.Load += new System.EventHandler(this.UC_DiemDanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtNgay;
        private Guna.UI2.WinForms.Guna2ComboBox cboMonHoc;
        private Guna.UI2.WinForms.Guna2ComboBox cboLop;
        private Guna.UI2.WinForms.Guna2ComboBox cboBuoi;
        private Guna.UI2.WinForms.Guna2Button btnCo;
        private Guna.UI2.WinForms.Guna2Button btnVang;
        private Guna.UI2.WinForms.Guna2Button btnMuon;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private Guna.UI2.WinForms.Guna2Button btnLamMoi;
        private Guna.UI2.WinForms.Guna2Button btnTai;
    }
}
