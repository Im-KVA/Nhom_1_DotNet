Create database Nhom1_dotnet

use Nhom1_dotnet
go
-- Tạo bảng Vai trò
CREATE TABLE VaiTro (
    VAITRO CHAR(10) PRIMARY KEY
);


-- Tạo bảng Khoa
CREATE TABLE Khoa (
    MAKHOA CHAR(10) PRIMARY KEY,
    TENKHOA NVARCHAR(100)
);

-- Tạo bảng GiangVien
CREATE TABLE GiangVien (
    MAGIANGVIEN CHAR(10) PRIMARY KEY,
    TENGIANGVIEN NVARCHAR(100),
    NGAYSINH DATETIME,
    GIOITINH INT,
    SODIENTHOAI CHAR(11),
    EMAIL CHAR(100),
    CCCD CHAR(15),
    MAKHOA CHAR(10),
    FOREIGN KEY (MAKHOA) REFERENCES Khoa(MAKHOA)
);

-- Tạo bảng SinhVien
CREATE TABLE SinhVien (
    MASV CHAR(10) PRIMARY KEY,
    TENSV NVARCHAR(100),
    NGAYSINH DATETIME,
    GIOITINH INT,
    SODIENTHOAI CHAR(11),
    EMAIL CHAR(100),
    CCCD CHAR(15),
    MAKHOA CHAR(10),
    FOREIGN KEY (MAKHOA) REFERENCES Khoa(MAKHOA)
);

-- Tạo bảng LinhVuc
CREATE TABLE LinhVuc (
    MALINHVUC CHAR(10) PRIMARY KEY,
    TENLINHVUC NVARCHAR(100),
    MOTALINHVUC NVARCHAR(200)
);

-- Tạo bảng TrangThai
CREATE TABLE TrangThai (
    MATRANGTHAI CHAR(10) PRIMARY KEY,
    TENTRANGTHAI NVARCHAR(100)
);

-- Tạo bảng Giaithuong
CREATE TABLE Giaithuong (
    MAGIAITHUONG CHAR(10) PRIMARY KEY,
    TENGIAITHUONG NVARCHAR(100),
    MOTAGIAITHUONG NVARCHAR(200)
);

-- Tạo bảng DeTaiNCKH
CREATE TABLE DeTaiNCKH (
    MADT CHAR(10) PRIMARY KEY,
    TENDT NVARCHAR(100),
    MOTA NVARCHAR(200),
    MALINHVUC CHAR(10),
    MASV CHAR(10),
    MAKHOA CHAR(10),
    MAGIANGVIEN CHAR(10),
    NAMHOC CHAR(15),
    MATRANGTHAI CHAR(10),
    MAGIAITHUONG CHAR(10),
	NHANXET NVARCHAR(200),
    FOREIGN KEY (MALINHVUC) REFERENCES LinhVuc(MALINHVUC),
    FOREIGN KEY (MASV) REFERENCES SinhVien(MASV),
    FOREIGN KEY (MAKHOA) REFERENCES Khoa(MAKHOA),
    FOREIGN KEY (MAGIANGVIEN) REFERENCES GiangVien(MAGIANGVIEN),
    FOREIGN KEY (MATRANGTHAI) REFERENCES TrangThai(MATRANGTHAI),
    FOREIGN KEY (MAGIAITHUONG) REFERENCES Giaithuong(MAGIAITHUONG)
);

-- Tạo bảng TaiKhoan, liên kết đến cả SinhVien và GiangVien
CREATE TABLE TaiKhoan (
    MADANGNHAP CHAR(10) PRIMARY KEY,
    MATKHAU NVARCHAR(100),
    VAITRO CHAR(10),
    FOREIGN KEY (VAITRO) REFERENCES VaiTro(VAITRO),
);

INSERT INTO VaiTro (VAITRO) VALUES (N'SINHVIEN');
INSERT INTO VaiTro (VAITRO) VALUES (N'GIANGVIEN');
INSERT INTO VaiTro (VAITRO) VALUES (N'ADMIN');

-- Chèn dữ liệu vào bảng Khoa
INSERT INTO Khoa (MAKHOA, TENKHOA)
VALUES
(N'K01', N'Công nghệ thông tin'),
(N'K02', N'Kinh tế'),
(N'K03', N'Toán học'),
(N'K04', N'Ngôn ngữ Anh'),
(N'K05', N'Vật lý'),
(N'K06', N'Hóa học');

-- Chèn dữ liệu vào bảng GiangVien
INSERT INTO GiangVien (MAGIANGVIEN, TENGIANGVIEN, NGAYSINH, GIOITINH, SODIENTHOAI, EMAIL, CCCD, MAKHOA)
VALUES
(N'GV01', N'Nguyễn Văn A', '1980-01-01', 0, N'0123456789', N'anv@example.com', N'1234567890123', N'K01'),
(N'GV02', N'Lê Thị B', '1985-05-15', 1, N'0987654321', N'lethib@example.com', N'9876543210123', N'K02'),
(N'GV03', N'Phạm Minh E', '1982-02-10', 0, N'0912121212', N'pme@example.com', N'3333333333333', N'K03'),
(N'GV04', N'Trần Thị F', '1979-09-22', 1, N'0923232323', N'ttf@example.com', N'4444444444444', N'K04'),
(N'GV05', N'Nguyễn Văn G', '1986-11-05', 0, N'0934343434', N'nvg@example.com', N'5555555555555', N'K05');

-- Chèn dữ liệu vào bảng SinhVien
INSERT INTO SinhVien (MASV, TENSV, NGAYSINH, GIOITINH, SODIENTHOAI, EMAIL, CCCD, MAKHOA)
VALUES
(N'SV01', N'Trần Văn C', '2000-03-10', 0, N'0912345678', N'tranvanc@example.com', N'1112223334445', N'K01'),
(N'SV02', N'Nguyễn Thị D', '2001-07-25', 1, N'0987654321', N'nguyentid@example.com', N'5556667778889', N'K02'),
(N'SV03', N'Lê Văn H', '2001-01-15', 0, N'0945454545', N'levanh@example.com', N'6666666666666', N'K03'),
(N'SV04', N'Đỗ Thị I', '2002-02-20', 1, N'0956565656', N'dothii@example.com', N'7777777777777', N'K04'),
(N'SV05', N'Hoàng Văn J', '2003-03-25', 0, N'0967676767', N'hoangvj@example.com', N'8888888888888', N'K05');

-- Chèn dữ liệu vào bảng LinhVuc
INSERT INTO LinhVuc (MALINHVUC, TENLINHVUC, MOTALINHVUC)
VALUES
(N'LV01', N'Công nghệ thông tin', N'Nghiên cứu về công nghệ thông tin'),
(N'LV02', N'Khoa học máy tính', N'Nghiên cứu về khoa học máy tính'),
(N'LV03', N'Môi trường', N'Nghiên cứu về bảo vệ môi trường'),
(N'LV04', N'Vật liệu học', N'Nghiên cứu về các vật liệu mới');

-- Chèn dữ liệu vào bảng TrangThai
INSERT INTO TrangThai (MATRANGTHAI, TENTRANGTHAI)
VALUES
(N'TT01', N'Đang xét duyệt'),
(N'TT02', N'Đã duyệt'),
(N'TT03', N'Hoàn thành')


-- Chèn dữ liệu vào bảng Giaithuong
INSERT INTO Giaithuong (MAGIAITHUONG, TENGIAITHUONG, MOTAGIAITHUONG)
VALUES
(N'GT01', N'Giải nhất', N'Giải thưởng cao nhất'),
(N'GT02', N'Giải nhì', N'Giải thưởng cao thứ nhì'),
(N'GT03', N'Giải ba', N'Giải thưởng cao thứ ba');

-- Chèn dữ liệu vào bảng DeTaiNCKH
INSERT INTO DeTaiNCKH (MADT, TENDT, MOTA, MALINHVUC, MASV, MAKHOA, MAGIANGVIEN, NAMHOC, MATRANGTHAI, MAGIAITHUONG, NHANXET)
VALUES
(N'DT01', N'Ứng dụng AI trong y tế', N'Nghiên cứu ứng dụng AI...', N'LV01', N'SV01', N'K01', N'GV01', N'2023-2024', N'TT01', NULL, NULL),
(N'DT02', N'Phân tích dữ liệu lớn', N'Phân tích dữ liệu lớn...', N'LV02', N'SV02', N'K02', N'GV02', N'2023-2024', N'TT02', NULL, NULL),
(N'DT03', N'Bảo vệ tài nguyên nước', N'Nghiên cứu bảo vệ...', N'LV03', N'SV03', N'K03', N'GV01', N'2023-2024', N'TT03', N'GT03', 'good chop'),
(N'DT04', N'Phát triển vật liệu mới', N'Nghiên cứu và phát triển...', N'LV04', N'SV04', N'K04', N'GV04', N'2023-2024', N'TT01', NULL, NULL),
(N'DT05', N'Giảm thiểu ô nhiễm môi trường', N'Nghiên cứu và cải thiện các giải pháp...', N'LV03', N'SV05', N'K05', N'GV05', N'2024-2025', N'TT03', N'GT02', NULL);

-- Chèn dữ liệu vào bảng TaiKhoan
INSERT INTO TaiKhoan (MADANGNHAP, MATKHAU, VAITRO)
VALUES
(N'SV01', N'password123', N'SINHVIEN'),
(N'SV02', N'password456', N'SINHVIEN'),
(N'SV03', N'password789', N'SINHVIEN'),
(N'GV02', N'passwordDEF', N'GIANGVIEN'),
(N'GV01', N'passwordABC', N'GIANGVIEN'),
(N'ADMIN', N'adminPass', N'ADMIN');

select * from DeTaiNCKH

delete DeTaiNCKH