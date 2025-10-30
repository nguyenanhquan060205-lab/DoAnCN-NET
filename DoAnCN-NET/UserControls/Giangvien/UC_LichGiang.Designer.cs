namespace DoAnCN_NET.UserControls.Giangvien
{
    partial class UC_LichGiang
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
            this.dtgLichGiang = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboHocKy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboNamHoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboTenMon = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtpNgay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnLamMoi = new Guna.UI2.WinForms.Guna2Button();
            this.btnXem = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLichGiang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(59, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lịch giảng của tôi";
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Học kỳ";
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(298, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Năm học";
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(572, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tên môn";
            // 
            // dtgLichGiang
            // 
            this.dtgLichGiang.BackgroundColor = System.Drawing.Color.Thistle;
            this.dtgLichGiang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLichGiang.Location = new System.Drawing.Point(3, 210);
            this.dtgLichGiang.Name = "dtgLichGiang";
            this.dtgLichGiang.Size = new System.Drawing.Size(1357, 449);
            this.dtgLichGiang.TabIndex = 60;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "DANH SÁCH LỚP ĐANG DẠY";
            // 
            // label6
            // 
            this.label6.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(846, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày";
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
            this.cboHocKy.Location = new System.Drawing.Point(88, 101);
            this.cboHocKy.Name = "cboHocKy";
            this.cboHocKy.Size = new System.Drawing.Size(165, 36);
            this.cboHocKy.TabIndex = 63;
            this.cboHocKy.SelectedIndexChanged += new System.EventHandler(this.cboHocKy_SelectedIndexChanged);
            // 
            // cboNamHoc
            // 
            this.cboNamHoc.BackColor = System.Drawing.Color.Transparent;
            this.cboNamHoc.BorderRadius = 10;
            this.cboNamHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboNamHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNamHoc.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboNamHoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboNamHoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboNamHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboNamHoc.ItemHeight = 30;
            this.cboNamHoc.Location = new System.Drawing.Point(372, 98);
            this.cboNamHoc.Name = "cboNamHoc";
            this.cboNamHoc.Size = new System.Drawing.Size(165, 36);
            this.cboNamHoc.TabIndex = 62;
            this.cboNamHoc.SelectedIndexChanged += new System.EventHandler(this.cboNamHoc_SelectedIndexChanged);
            // 
            // cboTenMon
            // 
            this.cboTenMon.BackColor = System.Drawing.Color.Transparent;
            this.cboTenMon.BorderRadius = 10;
            this.cboTenMon.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTenMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTenMon.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboTenMon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboTenMon.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboTenMon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboTenMon.ItemHeight = 30;
            this.cboTenMon.Location = new System.Drawing.Point(645, 101);
            this.cboTenMon.Name = "cboTenMon";
            this.cboTenMon.Size = new System.Drawing.Size(165, 36);
            this.cboTenMon.TabIndex = 64;
            // 
            // dtpNgay
            // 
            this.dtpNgay.BackColor = System.Drawing.Color.Transparent;
            this.dtpNgay.BorderRadius = 15;
            this.dtpNgay.Checked = true;
            this.dtpNgay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dtpNgay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgay.Location = new System.Drawing.Point(896, 101);
            this.dtpNgay.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgay.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(165, 36);
            this.dtpNgay.TabIndex = 65;
            this.dtpNgay.Value = new System.DateTime(2025, 10, 30, 0, 14, 31, 383);
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
            this.btnLamMoi.Location = new System.Drawing.Point(28, 676);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(188, 36);
            this.btnLamMoi.TabIndex = 66;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
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
            this.btnXem.Location = new System.Drawing.Point(862, 168);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(199, 36);
            this.btnXem.TabIndex = 67;
            this.btnXem.Text = "Xem danh sách";
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // UC_LichGiang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.dtpNgay);
            this.Controls.Add(this.cboTenMon);
            this.Controls.Add(this.cboHocKy);
            this.Controls.Add(this.cboNamHoc);
            this.Controls.Add(this.dtgLichGiang);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "UC_LichGiang";
            this.Size = new System.Drawing.Size(1363, 726);
            this.Load += new System.EventHandler(this.UC_LichGiang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgLichGiang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtgLichGiang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox cboHocKy;
        private Guna.UI2.WinForms.Guna2ComboBox cboNamHoc;
        private Guna.UI2.WinForms.Guna2ComboBox cboTenMon;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgay;
        private Guna.UI2.WinForms.Guna2Button btnLamMoi;
        private Guna.UI2.WinForms.Guna2Button btnXem;
    }
}
