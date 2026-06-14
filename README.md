# Hệ Thống Quản Lý Điểm Danh

Ứng dụng web quản lý điểm danh sinh viên được xây dựng bằng **ASP.NET (C#)** và **SQL Server**, hỗ trợ ba vai trò người dùng: Admin, Giảng Viên và Sinh Viên.

---

## Tính Năng Chính

### Phân quyền 3 vai trò
- **Admin**: Quản lý toàn bộ hệ thống (khoa, giảng viên, sinh viên, môn học, lớp học)
- **Giảng Viên**: Tạo buổi học, thực hiện điểm danh, xem danh sách lớp
- **Sinh Viên**: Đăng ký lớp học, xem lịch sử điểm danh của bản thân

### Quản lý học vụ
- Quản lý **Khoa**, **Môn học**, **Lớp học** theo học kỳ và năm học
- Quản lý **Giảng viên** và **Sinh viên** theo từng khoa
- Sinh viên đăng ký lớp học, admin/giảng viên duyệt đăng ký

### Quản lý buổi học & Điểm danh
- Tạo **Buổi học** với các loại: Lý thuyết, Thực hành, Thi, Buổi bù, Online
- Điểm danh theo 3 trạng thái: **Có mặt**, **Vắng**, **Muộn**
- Ghi nhận thời gian check-in và ghi chú của giảng viên

---

## Công Nghệ Sử Dụng

| Thành phần | Công nghệ |
|---|---|
| Backend | C#, ASP.NET |
| Database | SQL Server |
| ORM / Query | ADO.NET / T-SQL |
| IDE | Visual Studio |

---

## Cơ Sở Dữ Liệu

Hệ thống gồm **8 bảng chính**:

| Bảng | Mô tả |
|---|---|
| `NguoiDung` | Tài khoản người dùng với 3 vai trò (Admin, Giảng Viên, Sinh Viên) |
| `Khoa` | Danh sách các khoa trong trường |
| `SinhVien` | Thông tin sinh viên, liên kết với Khoa và NguoiDung |
| `GiangVien` | Thông tin giảng viên, liên kết với Khoa và NguoiDung |
| `MonHoc` | Danh sách môn học theo từng khoa, số tín chỉ |
| `LopHoc` | Lớp học theo học kỳ/năm học, giảng viên phụ trách, phòng học |
| `BuoiHoc` | Các buổi học cụ thể (ngày, giờ, loại buổi) |
| `DiemDanh` | Bản ghi điểm danh sinh viên cho từng buổi học |

---

## Hướng Dẫn Cài Đặt

### Yêu cầu hệ thống
- Visual Studio 2019 trở lên
- SQL Server 2019 trở lên (hoặc SQL Server Express)
- .NET Framework / .NET (theo phiên bản project)

### Các bước cài đặt

**1. Clone repository**
```bash
git clone https://github.com/nguyenanhquan060205-lab/DoAnCN-NET.git
```

**2. Tạo Database**
- Mở **SQL Server Management Studio (SSMS)**
- Mở file `QLDiemDanh.sql` và chạy toàn bộ script
- Script sẽ tự động tạo database `QLDIEMDANH` và dữ liệu mẫu

**3. Cấu hình Connection String**
- Mở file `Web.config` (hoặc `appsettings.json`)
- Cập nhật connection string trỏ đến SQL Server của bạn:
```xml
<connectionStrings>
  <add name="QLDiemDanhDB"
       connectionString="Server=YOUR_SERVER;Database=QLDIEMDANH;Trusted_Connection=True;"
       providerName="System.Data.SqlClient" />
</connectionStrings>
```

**4. Chạy ứng dụng**
- Mở file `DoAnCN-NET.sln` bằng Visual Studio
- Build solution (`Ctrl + Shift + B`)
- Nhấn `F5` để chạy

---

## Tài Khoản Mẫu

| Vai trò | Username | Password |
|---|---|---|
| Admin | Admin1 | pAdmin1 |
| Giảng Viên | Gv01 | 123 |
| Sinh Viên | Sv01 | 123 |

---

## Tác Giả

**Nguyễn Anh Quân**  
Sinh viên ngành Công nghệ Thông tin  
Trường Đại học Công Thương TP.HCM (HUIT)

---

## Giấy Phép

Dự án được thực hiện cho mục đích học tập và nghiên cứu.
