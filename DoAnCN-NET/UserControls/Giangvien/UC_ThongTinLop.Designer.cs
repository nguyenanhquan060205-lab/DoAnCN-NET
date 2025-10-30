namespace DoAnCN_NET.UserControls.Giangvien
{
    partial class UC_ThongTinLop
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
            this.dgvLopHoc = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLamMoi = new Guna.UI2.WinForms.Guna2Button();
            this.btnTim = new Guna.UI2.WinForms.Guna2Button();
            this.btnXuat = new Guna.UI2.WinForms.Guna2Button();
            this.cboxMon = new System.Windows.Forms.ComboBox();
            this.cboxTimlop = new System.Windows.Forms.ComboBox();
            this.btnTaidanhsach = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Thông tin các lớp";
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(437, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tìm lớp";
            // 
            // dgvLopHoc
            // 
            this.dgvLopHoc.BackgroundColor = System.Drawing.Color.Thistle;
            this.dgvLopHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLopHoc.Location = new System.Drawing.Point(3, 212);
            this.dgvLopHoc.Name = "dgvLopHoc";
            this.dgvLopHoc.Size = new System.Drawing.Size(1357, 511);
            this.dgvLopHoc.TabIndex = 59;
            this.dgvLopHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLopHoc_CellClick);
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(184, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Môn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "DANH SÁCH LỚP";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.Transparent;
            this.btnLamMoi.BorderRadius = 10;
            this.btnLamMoi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLamMoi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLamMoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLamMoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(788, 112);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(114, 23);
            this.btnLamMoi.TabIndex = 61;
            this.btnLamMoi.Text = "↻ Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.Transparent;
            this.btnTim.BorderRadius = 10;
            this.btnTim.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTim.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTim.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTim.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTim.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTim.ForeColor = System.Drawing.Color.White;
            this.btnTim.Location = new System.Drawing.Point(694, 112);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(73, 23);
            this.btnTim.TabIndex = 60;
            this.btnTim.Text = "🔍 Tìm";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnXuat
            // 
            this.btnXuat.BackColor = System.Drawing.Color.Transparent;
            this.btnXuat.BorderRadius = 10;
            this.btnXuat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXuat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXuat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXuat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXuat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXuat.ForeColor = System.Drawing.Color.White;
            this.btnXuat.Location = new System.Drawing.Point(187, 183);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(223, 23);
            this.btnXuat.TabIndex = 64;
            this.btnXuat.Text = "Xuất thông tin excel";
            this.btnXuat.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // cboxMon
            // 
            this.cboxMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxMon.FormattingEnabled = true;
            this.cboxMon.Location = new System.Drawing.Point(233, 112);
            this.cboxMon.Name = "cboxMon";
            this.cboxMon.Size = new System.Drawing.Size(167, 21);
            this.cboxMon.TabIndex = 65;
            this.cboxMon.SelectedIndexChanged += new System.EventHandler(this.cboxMon_SelectedIndexChanged);
            // 
            // cboxTimlop
            // 
            this.cboxTimlop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTimlop.FormattingEnabled = true;
            this.cboxTimlop.Location = new System.Drawing.Point(506, 114);
            this.cboxTimlop.Name = "cboxTimlop";
            this.cboxTimlop.Size = new System.Drawing.Size(167, 21);
            this.cboxTimlop.TabIndex = 66;
            // 
            // btnTaidanhsach
            // 
            this.btnTaidanhsach.BackColor = System.Drawing.Color.Transparent;
            this.btnTaidanhsach.BorderRadius = 10;
            this.btnTaidanhsach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTaidanhsach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTaidanhsach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTaidanhsach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTaidanhsach.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTaidanhsach.ForeColor = System.Drawing.Color.White;
            this.btnTaidanhsach.Location = new System.Drawing.Point(1128, 171);
            this.btnTaidanhsach.Name = "btnTaidanhsach";
            this.btnTaidanhsach.Size = new System.Drawing.Size(167, 35);
            this.btnTaidanhsach.TabIndex = 67;
            this.btnTaidanhsach.Text = "Tải danh sách";
            this.btnTaidanhsach.Click += new System.EventHandler(this.btnTaiDanhSach_Click);
            // 
            // UC_ThongTinLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnTaidanhsach);
            this.Controls.Add(this.cboxTimlop);
            this.Controls.Add(this.cboxMon);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.dgvLopHoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "UC_ThongTinLop";
            this.Size = new System.Drawing.Size(1363, 726);
            this.Load += new System.EventHandler(this.UC_ThongTinLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvLopHoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btnLamMoi;
        private Guna.UI2.WinForms.Guna2Button btnTim;
        private Guna.UI2.WinForms.Guna2Button btnXuat;
        private System.Windows.Forms.ComboBox cboxMon;
        private System.Windows.Forms.ComboBox cboxTimlop;
        private Guna.UI2.WinForms.Guna2Button btnTaidanhsach;
    }
}
