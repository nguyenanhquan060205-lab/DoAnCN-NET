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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.btnNguoidung = new System.Windows.Forms.Button();
            this.btnKhoa = new System.Windows.Forms.Button();
            this.btnLophoc = new System.Windows.Forms.Button();
            this.btnMonhoc = new System.Windows.Forms.Button();
            this.btnGiangvien = new System.Windows.Forms.Button();
            this.btnSinhvien = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.PnlAdmin = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.btnNguoidung);
            this.panel1.Controls.Add(this.btnKhoa);
            this.panel1.Controls.Add(this.btnLophoc);
            this.panel1.Controls.Add(this.btnMonhoc);
            this.panel1.Controls.Add(this.btnGiangvien);
            this.panel1.Controls.Add(this.btnSinhvien);
            this.panel1.Location = new System.Drawing.Point(3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1363, 62);
            this.panel1.TabIndex = 0;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(798, 13);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(89, 37);
            this.button7.TabIndex = 6;
            this.button7.Text = "Thoát";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // btnNguoidung
            // 
            this.btnNguoidung.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNguoidung.Location = new System.Drawing.Point(673, 13);
            this.btnNguoidung.Name = "btnNguoidung";
            this.btnNguoidung.Size = new System.Drawing.Size(89, 37);
            this.btnNguoidung.TabIndex = 5;
            this.btnNguoidung.Text = "Người dùng";
            this.btnNguoidung.UseVisualStyleBackColor = true;
            this.btnNguoidung.Click += new System.EventHandler(this.btnNguoidung_Click);
            // 
            // btnKhoa
            // 
            this.btnKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoa.Location = new System.Drawing.Point(540, 13);
            this.btnKhoa.Name = "btnKhoa";
            this.btnKhoa.Size = new System.Drawing.Size(89, 37);
            this.btnKhoa.TabIndex = 4;
            this.btnKhoa.Text = "Khoa";
            this.btnKhoa.UseVisualStyleBackColor = true;
            this.btnKhoa.Click += new System.EventHandler(this.btnKhoa_Click);
            // 
            // btnLophoc
            // 
            this.btnLophoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLophoc.Location = new System.Drawing.Point(409, 13);
            this.btnLophoc.Name = "btnLophoc";
            this.btnLophoc.Size = new System.Drawing.Size(89, 37);
            this.btnLophoc.TabIndex = 3;
            this.btnLophoc.Text = "Lớp học";
            this.btnLophoc.UseVisualStyleBackColor = true;
            this.btnLophoc.Click += new System.EventHandler(this.btnLophoc_Click);
            // 
            // btnMonhoc
            // 
            this.btnMonhoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonhoc.Location = new System.Drawing.Point(280, 13);
            this.btnMonhoc.Name = "btnMonhoc";
            this.btnMonhoc.Size = new System.Drawing.Size(89, 37);
            this.btnMonhoc.TabIndex = 2;
            this.btnMonhoc.Text = "Môn học";
            this.btnMonhoc.UseVisualStyleBackColor = true;
            this.btnMonhoc.Click += new System.EventHandler(this.btnMonhoc_Click);
            // 
            // btnGiangvien
            // 
            this.btnGiangvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiangvien.Location = new System.Drawing.Point(158, 13);
            this.btnGiangvien.Name = "btnGiangvien";
            this.btnGiangvien.Size = new System.Drawing.Size(89, 37);
            this.btnGiangvien.TabIndex = 1;
            this.btnGiangvien.Text = "Giảng viên";
            this.btnGiangvien.UseVisualStyleBackColor = true;
            this.btnGiangvien.Click += new System.EventHandler(this.btnGiangvien_Click);
            // 
            // btnSinhvien
            // 
            this.btnSinhvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSinhvien.Location = new System.Drawing.Point(35, 13);
            this.btnSinhvien.Name = "btnSinhvien";
            this.btnSinhvien.Size = new System.Drawing.Size(89, 37);
            this.btnSinhvien.TabIndex = 0;
            this.btnSinhvien.Text = "Sinh viên";
            this.btnSinhvien.UseVisualStyleBackColor = true;
            this.btnSinhvien.Click += new System.EventHandler(this.btnSinhvien_Click);
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
            this.label1.Size = new System.Drawing.Size(380, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "HỆ THỐNG QUẢN LÍ ĐIỂM DANH SINH VIÊN - ADMIN ";
            // 
            // PnlAdmin
            // 
            this.PnlAdmin.Location = new System.Drawing.Point(3, 117);
            this.PnlAdmin.Name = "PnlAdmin";
            this.PnlAdmin.Size = new System.Drawing.Size(1363, 726);
            this.PnlAdmin.TabIndex = 2;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1369, 828);
            this.Controls.Add(this.PnlAdmin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
        private System.Windows.Forms.Button btnSinhvien;
        private System.Windows.Forms.Button btnNguoidung;
        private System.Windows.Forms.Button btnKhoa;
        private System.Windows.Forms.Button btnLophoc;
        private System.Windows.Forms.Button btnMonhoc;
        private System.Windows.Forms.Button btnGiangvien;
        private System.Windows.Forms.Button button7;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PnlAdmin;
    }
}