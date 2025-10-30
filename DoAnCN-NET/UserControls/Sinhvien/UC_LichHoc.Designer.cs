namespace DoAnCN_NET.UserControls.Sinhvien
{
    partial class UC_LichHoc
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvDanhSachLichHoc = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.cboHocKy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboMon = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtpNgay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnXem = new Guna.UI2.WinForms.Guna2Button();
            this.btnLamMoi = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLichHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(139, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Học kỳ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Lịch học của bạn";
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(411, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Môn";
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(657, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ngày";
            // 
            // dgvDanhSachLichHoc
            // 
            this.dgvDanhSachLichHoc.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dgvDanhSachLichHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachLichHoc.Location = new System.Drawing.Point(3, 266);
            this.dgvDanhSachLichHoc.Name = "dgvDanhSachLichHoc";
            this.dgvDanhSachLichHoc.Size = new System.Drawing.Size(1357, 460);
            this.dgvDanhSachLichHoc.TabIndex = 60;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 20);
            this.label5.TabIndex = 61;
            this.label5.Text = "DANH SÁCH LỊCH HỌC";
            // 
            // cboHocKy
            // 
            this.cboHocKy.BackColor = System.Drawing.Color.Transparent;
            this.cboHocKy.BorderRadius = 10;
            this.cboHocKy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHocKy.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboHocKy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboHocKy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboHocKy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboHocKy.ItemHeight = 30;
            this.cboHocKy.Location = new System.Drawing.Point(196, 108);
            this.cboHocKy.Name = "cboHocKy";
            this.cboHocKy.Size = new System.Drawing.Size(165, 36);
            this.cboHocKy.TabIndex = 67;
            // 
            // cboMon
            // 
            this.cboMon.BackColor = System.Drawing.Color.Transparent;
            this.cboMon.BorderRadius = 10;
            this.cboMon.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMon.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboMon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboMon.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboMon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboMon.ItemHeight = 30;
            this.cboMon.Location = new System.Drawing.Point(454, 108);
            this.cboMon.Name = "cboMon";
            this.cboMon.Size = new System.Drawing.Size(165, 36);
            this.cboMon.TabIndex = 68;
            // 
            // dtpNgay
            // 
            this.dtpNgay.BackColor = System.Drawing.Color.Transparent;
            this.dtpNgay.BorderRadius = 10;
            this.dtpNgay.Checked = true;
            this.dtpNgay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dtpNgay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgay.Location = new System.Drawing.Point(707, 108);
            this.dtpNgay.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgay.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(165, 36);
            this.dtpNgay.TabIndex = 69;
            this.dtpNgay.Value = new System.DateTime(2025, 10, 29, 23, 15, 39, 652);
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.Color.Transparent;
            this.btnXem.BorderRadius = 10;
            this.btnXem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnXem.ForeColor = System.Drawing.Color.White;
            this.btnXem.Location = new System.Drawing.Point(288, 191);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(133, 23);
            this.btnXem.TabIndex = 71;
            this.btnXem.Text = "Xem chi tiết";
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
            this.btnLamMoi.Location = new System.Drawing.Point(463, 191);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(133, 23);
            this.btnLamMoi.TabIndex = 70;
            this.btnLamMoi.Text = "Làm mới";
            // 
            // UC_LichHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.dtpNgay);
            this.Controls.Add(this.cboMon);
            this.Controls.Add(this.cboHocKy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvDanhSachLichHoc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "UC_LichHoc";
            this.Size = new System.Drawing.Size(1363, 726);
            this.Load += new System.EventHandler(this.UC_LichHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLichHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvDanhSachLichHoc;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox cboHocKy;
        private Guna.UI2.WinForms.Guna2ComboBox cboMon;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgay;
        private Guna.UI2.WinForms.Guna2Button btnXem;
        private Guna.UI2.WinForms.Guna2Button btnLamMoi;
    }
}
