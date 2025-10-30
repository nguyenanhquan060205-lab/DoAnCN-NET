namespace DoAnCN_NET.UserControls.Sinhvien
{
    partial class UC_DiemDanhSV
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
            this.dgvChuyenCan = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLamMoi = new Guna.UI2.WinForms.Guna2Button();
            this.btnXem = new Guna.UI2.WinForms.Guna2Button();
            this.dtpNgay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cboMonHoc = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuyenCan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kết quả điểm danh";
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(126, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Môn học";
            // 
            // dgvChuyenCan
            // 
            this.dgvChuyenCan.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dgvChuyenCan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChuyenCan.Location = new System.Drawing.Point(3, 266);
            this.dgvChuyenCan.Name = "dgvChuyenCan";
            this.dgvChuyenCan.Size = new System.Drawing.Size(1357, 457);
            this.dgvChuyenCan.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ngày";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "THỐNG KÊ CHUYÊN CẦN";
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
            this.btnLamMoi.Location = new System.Drawing.Point(435, 150);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(133, 23);
            this.btnLamMoi.TabIndex = 63;
            this.btnLamMoi.Text = "Làm mới";
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
            this.btnXem.Location = new System.Drawing.Point(435, 104);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(133, 23);
            this.btnXem.TabIndex = 64;
            this.btnXem.Text = "Xem chi tiết";
            // 
            // dtpNgay
            // 
            this.dtpNgay.BackColor = System.Drawing.Color.Transparent;
            this.dtpNgay.BorderRadius = 10;
            this.dtpNgay.Checked = true;
            this.dtpNgay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dtpNgay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgay.Location = new System.Drawing.Point(206, 150);
            this.dtpNgay.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgay.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(165, 36);
            this.dtpNgay.TabIndex = 65;
            this.dtpNgay.Value = new System.DateTime(2025, 10, 29, 23, 15, 39, 652);
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
            this.cboMonHoc.Location = new System.Drawing.Point(206, 104);
            this.cboMonHoc.Name = "cboMonHoc";
            this.cboMonHoc.Size = new System.Drawing.Size(165, 36);
            this.cboMonHoc.TabIndex = 66;
            // 
            // UC_DiemDanhSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cboMonHoc);
            this.Controls.Add(this.dtpNgay);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.dgvChuyenCan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "UC_DiemDanhSV";
            this.Size = new System.Drawing.Size(1363, 726);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuyenCan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvChuyenCan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btnLamMoi;
        private Guna.UI2.WinForms.Guna2Button btnXem;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgay;
        private Guna.UI2.WinForms.Guna2ComboBox cboMonHoc;
    }
}
