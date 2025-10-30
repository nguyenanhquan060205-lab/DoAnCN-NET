CREATE DATABASE QLDIEMDANH;
USe QLDIEMDANH;


SET DATEFORMAT DMY;

CREATE TABLE NguoiDung (
    UserID INT IDENTITY(1,1),	
    Username VARCHAR(50) NOT NULL,
    Password VARCHAR(100) NOT NULL,
    Role NVARCHAR(20) NOT NULL,
	CONSTRAINT PK_NguoiDung PRIMARY KEY (UserID),
	CONSTRAINT UQ_NguoiDung_Username UNIQUE (Username),
	CONSTRAINT CK_NguoiDung_Role CHECK (Role IN (N'Admin',N'Giảng Viên',N'Sinh Viên'))
);

-- =============================
-- 2. KHOA
-- =============================

CREATE TABLE KHOA
(
	MAKHOA VARCHAR(20),
	TENKHOA NVARCHAR(50) UNIQUE,
	CONSTRAINT PK_KHOA PRIMARY KEY(MAKHOA),
)
-- =============================
-- 2. SINHVIEN
-- =============================
CREATE TABLE SinhVien (
	MAKHOA VARCHAR(20),
    SinhVienID INT IDENTITY(1,1),
    MaSV VARCHAR(20) NOT NULL CONSTRAINT DF_SinhVien_MaSV DEFAULT 'SV0000',
    HoTen NVARCHAR(100) NOT NULL,
    Lop NVARCHAR(50) NOT NULL,
	NgaySinh DATE NULL,
	GioiTinh NVARCHAR(10) NULL CHECK (GioiTinh IN (N'Nam',N'Nữ')),
	Email VARCHAR(100) NULL,
	DiaChi nvarchar(100),
	SDT varchar(20) null,
	TrangThai NVARCHAR(20) DEFAULT N'Đang học',
    UserID INT NULL,
	CONSTRAINT FK_SinhVien_Khoa foreign key (MAKHOA) references KHOA(MAKHOA),
	CONSTRAINT PK_SinhVien PRIMARY KEY (SinhVienID),
	CONSTRAINT UQ_SinhVien_MaSV UNIQUE (MaSV),
	CONSTRAINT FK_SinhVien_User FOREIGN KEY (UserID) REFERENCES NguoiDung(UserID),
	CONSTRAINT UQ_SinhVien_Email UNIQUE (Email)
);

-- =============================
-- 3. GIANGVIEN
-- =============================
CREATE TABLE GiangVien (
	MaKhoa VARCHAR(20) NOT NULL,
    GiangVienID INT IDENTITY(1,1),
    MaGV VARCHAR(20) NOT NULL,
    HoTen NVARCHAR(100) NOT NULL,
	Email VARCHAR(100) NULL,
    UserID INT NULL,
	SDT VARCHAR(20) NULL,
	Ngaysinh Date,
	Diachi nvarchar(100),
	GioiTinh NVARCHAR(10) NULL CHECK (GioiTinh IN (N'Nam',N'Nữ')),
	CONSTRAINT UQ_GiangVien_Email UNIQUE (Email),
	CONSTRAINT PK_GiangVien PRIMARY KEY (GiangVienID),
	CONSTRAINT UQ_GiangVien_MaGV UNIQUE (MaGV),
	CONSTRAINT FK_GiangVien_User FOREIGN KEY (UserID) REFERENCES NguoiDung(UserID),
	CONSTRAINT FK_GiangVien_Khoa FOREIGN KEY (MaKhoa) REFERENCES KHOA(MaKhoa)
);

-- =============================
-- 4. MONHOC
-- =============================
CREATE TABLE MonHoc (
    MonHocID INT IDENTITY(1,1),
    TenMon NVARCHAR(100) NOT NULL,
	MAKHOA VARCHAR(20) NOT NULL,
	SoTinChi INT NOT NULL DEFAULT 3,
	CONSTRAINT PK_MonHoc PRIMARY KEY (MonHocID),
	CONSTRAINT UQ_MonHoc_TenMon UNIQUE (TenMon),
	CONSTRAINT FK_MonHoc_Khoa FOREIGN KEY (MaKhoa) REFERENCES Khoa(MaKhoa)
);


-- =============================
-- 5. LOPHOC
-- =============================
CREATE TABLE LopHoc (
	Tenlop nvarchar(50),
    LopHocID INT IDENTITY(1,1),
    MonHocID INT NOT NULL,
    GiangVienID INT NOT NULL,
	HocKy VARCHAR(20) NOT NULL,
	NamHoc VARCHAR(20) NOT NULL,
	PhongHoc VARCHAR(50) NULL,
	SiSoToiDa INT DEFAULT 50,
	NgayBatDau date,
	NgayKetThuc date,
	CONSTRAINT PK_LopHoc PRIMARY KEY (LopHocID),
	CONSTRAINT FK_LopHoc_MonHoc FOREIGN KEY (MonHocID) REFERENCES MonHoc(MonHocID),
	CONSTRAINT FK_LopHoc_GiangVien FOREIGN KEY (GiangVienID) REFERENCES GiangVien(GiangVienID),
	CONSTRAINT CK_LopHoc_Ngay CHECK (NgayKetThuc > NgayBatDau)
);


-- =============================
-- 6. DANGKYLOP
-- =============================
CREATE TABLE DangKyLop (
    LopHocID INT NOT NULL,
    SinhVienID INT NOT NULL,
    NgayDangKy DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
	TrangThai NVARCHAR(20) DEFAULT N'Chưa đăng kí',
	CONSTRAINT PK_DangKyLop PRIMARY KEY (LopHocID, SinhVienID),
	CONSTRAINT FK_DangKyLop_LopHoc FOREIGN KEY (LopHocID) REFERENCES LopHoc(LopHocID),
	CONSTRAINT FK_DangKyLop_SinhVien FOREIGN KEY (SinhVienID) REFERENCES SinhVien(SinhVienID)
);



-- =============================
-- 7. BUOIHOC
-- =============================
CREATE TABLE BuoiHoc (
    BuoiHocID INT IDENTITY(1,1),
    LopHocID INT NOT NULL,
    NgayHoc DATE NOT NULL,
    GioBatDau TIME NOT NULL,
    GioKetThuc TIME NULL,
	LoaiBuoi NVARCHAR(50),
	CONSTRAINT CHK_LoaiBuoi CHECK (LoaiBuoi IN (N'Lý thuyết', N'Thực hành', N'Thi', N'Buổi bù', N'Online')),
	CONSTRAINT CK_BuoiHoc_Gio CHECK (GioBatDau BETWEEN '06:00' AND '21:45'),
    CONSTRAINT CK_BuoiHoc_GioHopLe CHECK (GioKetThuc > GioBatDau),
	CONSTRAINT PK_BuoiHoc PRIMARY KEY (BuoiHocID),
	CONSTRAINT FK_BuoiHoc_LopHoc FOREIGN KEY (LopHocID) REFERENCES LopHoc(LopHocID)

);

-- =============================
-- 8. DIEMDANH
-- =============================
CREATE TABLE DiemDanh (
    DiemDanhID INT IDENTITY(1,1),
    BuoiHocID INT NOT NULL,
    SinhVienID INT NOT NULL,
    TrangThai NVARCHAR(20) NOT NULL,
    ThoiGianCheckin DATETIME NULL,
	GhiChu NVARCHAR(200) NULL,
	NguoiDiemDanh INT NULL FOREIGN KEY REFERENCES GiangVien(GiangVienID),
	CONSTRAINT PK_DiemDanh PRIMARY KEY (DiemDanhID),
	CONSTRAINT FK_DiemDanh_BuoiHoc FOREIGN KEY (BuoiHocID) REFERENCES BuoiHoc(BuoiHocID),
	CONSTRAINT FK_DiemDanh_SinhVien FOREIGN KEY (SinhVienID) REFERENCES SinhVien(SinhVienID),
	CONSTRAINT CK_DiemDanh_TrangThai CHECK (TrangThai IN (N'Có mặt',N'Vắng',N'Muộn')),
	CONSTRAINT UQ_DiemDanh UNIQUE (BuoiHocID, SinhVienID)
);



--ALTER TABLE GIANGVIEN
--DROP COLUMN 
-- 1. NGƯỜI DÙNG
INSERT INTO NguoiDung VALUES 
('Admin1', 'pAdmin1', 'Admin'),
('Gv01', '123', N'Giảng Viên'),
('Sv01', '123', N'Sinh Viên')

-- 2. KHOA

INSERT INTO KHOA (MAKHOA, TENKHOA)
VALUES 
('CNTT', N'Công Nghệ Thông Tin'),
('QTKD', N'Quản Trị Kinh Doanh');


-- 3. GIẢNG VIÊN

INSERT INTO GiangVien (MaGV, HoTen, UserID, Email, SDT, NgaySinh, GioiTinh, DiaChi, MaKhoa)
VALUES ('GV001', N'Nguyễn Văn A', SCOPE_IDENTITY(), 'gv01@huit.edu.vn', '0909123456', '1985-01-01',N'Nam', N'TPHCM', 'CNTT');


-- 4. SINH VIÊN

INSERT INTO SinhVien (MaSV, HoTen, Lop, UserID, NgaySinh, GioiTinh, Email, TrangThai, DiaChi, MaKhoa, SDT)
VALUES ('SV001', N'Lê Thị B', N'D22_TH01', SCOPE_IDENTITY(), '2004-10-10', N'Nữ', 'sv01@huit.edu.vn', N'Đang học', N'TPHCM', 'CNTT','0385274441');


-- 5. MÔN HỌC

INSERT INTO MonHoc (TenMon, MaKhoa, SoTinChi)
VALUES 
(N'Lập trình C#', 'CNTT', 3),
(N'Cơ sở dữ liệu', 'CNTT', 3);

-- 6. LỚP HỌC

INSERT INTO LopHoc (MonHocID, GiangVienID, HocKy, NamHoc, PhongHoc, SiSoToiDa, NgayBatDau, NgayKetThuc, TenLop)
VALUES 
(1, 1, 'HK1', '2025-2026', 'P.101', 50, '01/09/2025', '30/12/2025', N'Lập trình C# - HK1');


-- 7. ĐĂNG KÝ LỚP
-- ==============================
INSERT INTO DangKyLop (LopHocID, SinhVienID, NgayDangKy, TrangThai)
VALUES 
(1, 1, SYSDATETIME(), N'Đã duyệt');

-- 8. BUỔI HỌC
-- ==============================
INSERT INTO BuoiHoc (LopHocID, NgayHoc, GioBatDau, GioKetThuc, LoaiBuoi)
VALUES 
(1, '20/10/2025', '07:00', '09:00', N'Lý thuyết');


-- 9. ĐIỂM DANH
-- ==============================
INSERT INTO DiemDanh (BuoiHocID, SinhVienID, TrangThai, ThoiGianCheckin, GhiChu, NguoiDiemDanh)
VALUES 
(1, 1, N'Có mặt', SYSDATETIME(), N'Đúng giờ', 1);