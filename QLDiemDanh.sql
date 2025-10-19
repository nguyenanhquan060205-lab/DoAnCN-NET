CREATE DATABASE QLDIEMDANH;
USe QLDIEMDANH;


SET DATEFORMAT DMY;

CREATE TABLE NguoiDung (
    UserID INT IDENTITY(1,1),	
    Username VARCHAR(50) NOT NULL,
    Password VARCHAR(100) NOT NULL,
    Role NVARCHAR(20) NOT NULL
);

INSERT INTO NguoiDung VALUES 
('taikhoan', 'matkhau1', 'Admin');

-- Ràng buộc
ALTER TABLE NguoiDung
    ADD CONSTRAINT PK_NguoiDung PRIMARY KEY (UserID);

ALTER TABLE NguoiDung
    ADD CONSTRAINT UQ_NguoiDung_Username UNIQUE (Username);

ALTER TABLE NguoiDung
    ADD CONSTRAINT CK_NguoiDung_Role CHECK (Role IN (N'Admin',N'Giảng Viên',N'Sinh Viên'));
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
    MaSV VARCHAR(20) NOT NULL,
    HoTen NVARCHAR(100) NOT NULL,
    Lop NVARCHAR(50) NOT NULL,
    UserID INT NULL
);


-- Ràng buộc
ALTER TABLE SinhVien
	ADD CONSTRAINT FK_SinhVien_Khoa foreign key (MAKHOA) references KHOA(MAKHOA)
ALTER TABLE SinhVien
    ADD CONSTRAINT PK_SinhVien PRIMARY KEY (SinhVienID);

ALTER TABLE SinhVien
    ADD CONSTRAINT UQ_SinhVien_MaSV UNIQUE (MaSV);

ALTER TABLE SinhVien
    ADD CONSTRAINT FK_SinhVien_User FOREIGN KEY (UserID) REFERENCES NguoiDung(UserID) ;

-- =============================
-- 3. GIANGVIEN
-- =============================
CREATE TABLE GiangVien (
    GiangVienID INT IDENTITY(1,1),
    MaGV VARCHAR(20) NOT NULL,
    HoTen NVARCHAR(100) NOT NULL,
    UserID INT NULL
);

-- Ràng buộc
ALTER TABLE GiangVien
    ADD CONSTRAINT PK_GiangVien PRIMARY KEY (GiangVienID);

ALTER TABLE GiangVien
    ADD CONSTRAINT UQ_GiangVien_MaGV UNIQUE (MaGV);

ALTER TABLE GiangVien
    ADD CONSTRAINT FK_GiangVien_User FOREIGN KEY (UserID) REFERENCES NguoiDung(UserID);

-- =============================
-- 4. MONHOC
-- =============================
CREATE TABLE MonHoc (
    MonHocID INT IDENTITY(1,1),
    TenMon NVARCHAR(100) NOT NULL,
	MAKHOA VARCHAR(20) NOT NULL,
);

-- Ràng buộc
ALTER TABLE MonHoc
    ADD CONSTRAINT PK_MonHoc PRIMARY KEY (MonHocID);

ALTER TABLE MonHoc
    ADD CONSTRAINT UQ_MonHoc_TenMon UNIQUE (TenMon);
ALTER TABLE MonHoc
	ADD CONSTRAINT FK_MonHoc_Khoa FOREIGN KEY (MaKhoa) REFERENCES Khoa(MaKhoa);

-- =============================
-- 5. LOPHOC
-- =============================
CREATE TABLE LopHoc (
    LopHocID INT IDENTITY(1,1),
    MonHocID INT NOT NULL,
    GiangVienID INT NOT NULL
);

-- Ràng buộc
ALTER TABLE LopHoc
    ADD CONSTRAINT PK_LopHoc PRIMARY KEY (LopHocID);

ALTER TABLE LopHoc
    ADD CONSTRAINT FK_LopHoc_MonHoc FOREIGN KEY (MonHocID) REFERENCES MonHoc(MonHocID);

ALTER TABLE LopHoc
    ADD CONSTRAINT FK_LopHoc_GiangVien FOREIGN KEY (GiangVienID) REFERENCES GiangVien(GiangVienID);

-- =============================
-- 6. DANGKYLOP
-- =============================
CREATE TABLE DangKyLop (
    LopHocID INT NOT NULL,
    SinhVienID INT NOT NULL,
    NgayDangKy DATETIME2 NOT NULL DEFAULT SYSDATETIME()
);

-- Ràng buộc
ALTER TABLE DangKyLop
    ADD CONSTRAINT PK_DangKyLop PRIMARY KEY (LopHocID, SinhVienID);

ALTER TABLE DangKyLop
    ADD CONSTRAINT FK_DangKyLop_LopHoc FOREIGN KEY (LopHocID) REFERENCES LopHoc(LopHocID);

ALTER TABLE DangKyLop
    ADD CONSTRAINT FK_DangKyLop_SinhVien FOREIGN KEY (SinhVienID) REFERENCES SinhVien(SinhVienID);

-- =============================
-- 7. BUOIHOC
-- =============================
CREATE TABLE BuoiHoc (
    BuoiHocID INT IDENTITY(1,1),
    LopHocID INT NOT NULL,
    NgayHoc DATE NOT NULL,
    GioBatDau TIME NOT NULL,
    GioKetThuc TIME NULL,
	CONSTRAINT CK_BuoiHoc_Gio CHECK (GioBatDau BETWEEN '06:00' AND '21:45'),
    CONSTRAINT CK_BuoiHoc_GioHopLe CHECK (GioKetThuc > GioBatDau)
);

-- Ràng buộc
ALTER TABLE BuoiHoc
    ADD CONSTRAINT PK_BuoiHoc PRIMARY KEY (BuoiHocID);

ALTER TABLE BuoiHoc
    ADD CONSTRAINT FK_BuoiHoc_LopHoc FOREIGN KEY (LopHocID) REFERENCES LopHoc(LopHocID);


-- =============================
-- 8. DIEMDANH
-- =============================
CREATE TABLE DiemDanh (
    DiemDanhID INT IDENTITY(1,1),
    BuoiHocID INT NOT NULL,
    SinhVienID INT NOT NULL,
    TrangThai NVARCHAR(20) NOT NULL,
    ThoiGianCheckin DATETIME NULL
);

-- Ràng buộc
ALTER TABLE DiemDanh
    ADD CONSTRAINT PK_DiemDanh PRIMARY KEY (DiemDanhID);

ALTER TABLE DiemDanh
    ADD CONSTRAINT FK_DiemDanh_BuoiHoc FOREIGN KEY (BuoiHocID) REFERENCES BuoiHoc(BuoiHocID);

ALTER TABLE DiemDanh
    ADD CONSTRAINT FK_DiemDanh_SinhVien FOREIGN KEY (SinhVienID) REFERENCES SinhVien(SinhVienID);

ALTER TABLE DiemDanh
    ADD CONSTRAINT CK_DiemDanh_TrangThai CHECK (TrangThai IN (N'Có mặt',N'Vắng',N'Muộn'));

ALTER TABLE DiemDanh
    ADD CONSTRAINT UQ_DiemDanh UNIQUE (BuoiHocID, SinhVienID);

--- Bổ sung
ALTER TABLE SinhVien ADD NgaySinh DATE NULL;	
ALTER TABLE SinhVien ADD GioiTinh NVARCHAR(10) NULL CHECK (GioiTinh IN (N'Nam',N'Nữ'));
ALTER TABLE SinhVien ADD Email VARCHAR(100) NULL;
ALTER TABLE SinhVien ADD TrangThai NVARCHAR(20) DEFAULT N'Đang học';
ALTER TABLE SINHVIEN ADD CONSTRAINT DF_SinhVien_MaSV DEFAULT 'SV0000' FOR MaSV;
ALTER TABLE SINHVIEN ADD DiaChi nvarchar(100);

ALTER TABLE GiangVien ADD Email VARCHAR(100) NULL;
ALTER TABLE GiangVien ADD SDT VARCHAR(20) NULL;
ALTER TABLE GiangVien ADD Ngaysinh Date;
ALTER TABLE GiangVien ADD Diachi nvarchar(100);


ALTER TABLE MonHoc ADD SoTinChi INT NOT NULL DEFAULT 3;

ALTER TABLE LopHoc ADD HocKy VARCHAR(20) NOT NULL;
ALTER TABLE LopHoc ADD NamHoc VARCHAR(20) NOT NULL;
ALTER TABLE LopHoc ADD PhongHoc VARCHAR(50) NULL;
ALTER TABLE LopHoc ADD SiSoToiDa INT DEFAULT 50;
ALTER TABLE LOPHOC ADD NgayBatDau date;
ALTER TABLE LOPHOC ADD NgayKetThuc date;

ALTER TABLE BuoiHoc
ADD LoaiBuoi NVARCHAR(50)
    CONSTRAINT CHK_LoaiBuoi CHECK (LoaiBuoi IN (N'Lý thuyết', N'Thực hành', N'Thi', N'Buổi bù', N'Online', N'Offline'));


ALTER TABLE DangKyLop ADD TrangThai NVARCHAR(20) DEFAULT N'---';

ALTER TABLE BuoiHoc ADD PhongHoc VARCHAR(50) NULL;

ALTER TABLE DiemDanh ADD GhiChu NVARCHAR(200) NULL;
ALTER TABLE DiemDanh ADD NguoiDiemDanh INT NULL FOREIGN KEY REFERENCES GiangVien(GiangVienID);

ALTER TABLE GIANGVIEN ADD MaKhoa VARCHAR(20) NOT NULL
ALTER TABLE GiangVien
ADD CONSTRAINT FK_GiangVien_Khoa FOREIGN KEY (MaKhoa) REFERENCES KHOA(MaKhoa);

ALTER TABLE LopHoc
ADD CONSTRAINT CK_LopHoc_Ngay
CHECK (NgayKetThuc > NgayBatDau);
Alter table Lophoc add Tenlop nvarchar(50);


	


ALTER TABLE SinhVien ADD CONSTRAINT UQ_SinhVien_Email UNIQUE (Email);
ALTER TABLE GiangVien ADD CONSTRAINT UQ_GiangVien_Email UNIQUE (Email);


--ALTER TABLE GIANGVIEN
--DROP COLUMN 



