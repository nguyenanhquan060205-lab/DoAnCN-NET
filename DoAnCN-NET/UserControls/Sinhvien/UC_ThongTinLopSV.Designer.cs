namespace DoAnCN_NET.UserControls.Sinhvien
{
    partial class UC_ThongTinLopSV
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
            this.dgvThongTin = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnXem = new Guna.UI2.WinForms.Guna2Button();
            this.btnTaiLai = new Guna.UI2.WinForms.Guna2Button();
            this.txtTim = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTin)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvThongTin
            // 
            this.dgvThongTin.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dgvThongTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTin.Location = new System.Drawing.Point(3, 266);
            this.dgvThongTin.Name = "dgvThongTin";
            this.dgvThongTin.Size = new System.Drawing.Size(1357, 460);
            this.dgvThongTin.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 62;
            this.label1.Text = "Thông tin lớp học";
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 63;
            this.label3.Text = "Tìm lớp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(294, 20);
            this.label5.TabIndex = 66;
            this.label5.Text = "THÔNG TIN LỚP HỌC ĐÃ ĐĂNG KÍ";
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
            this.btnXem.Location = new System.Drawing.Point(371, 89);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(133, 23);
            this.btnXem.TabIndex = 67;
            this.btnXem.Text = "Xem chi tiết";
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.BackColor = System.Drawing.Color.Transparent;
            this.btnTaiLai.BorderRadius = 10;
            this.btnTaiLai.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTaiLai.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTaiLai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTaiLai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTaiLai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTaiLai.ForeColor = System.Drawing.Color.White;
            this.btnTaiLai.Location = new System.Drawing.Point(1191, 237);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(133, 23);
            this.btnTaiLai.TabIndex = 69;
            this.btnTaiLai.Text = "Tải lại";
            // 
            // txtTim
            // 
            this.txtTim.BackColor = System.Drawing.Color.Transparent;
            this.txtTim.BorderRadius = 5;
            this.txtTim.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTim.DefaultText = "";
            this.txtTim.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTim.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTim.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTim.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTim.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTim.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTim.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTim.Location = new System.Drawing.Point(183, 89);
            this.txtTim.Name = "txtTim";
            this.txtTim.PlaceholderText = "Nhập tên lớp";
            this.txtTim.SelectedText = "";
            this.txtTim.Size = new System.Drawing.Size(165, 28);
            this.txtTim.TabIndex = 70;
            // 
            // UC_ThongTinLopSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.btnTaiLai);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvThongTin);
            this.Name = "UC_ThongTinLopSV";
            this.Size = new System.Drawing.Size(1363, 726);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvThongTin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btnXem;
        private Guna.UI2.WinForms.Guna2Button btnTaiLai;
        private Guna.UI2.WinForms.Guna2TextBox txtTim;
    }
}
