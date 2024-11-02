
-- Tạo bảng Vai trò
CREATE TABLE VaiTro (
    VAITRO CHAR(10) PRIMARY KEY
);

-- Chèn dữ liệu vào bảng Vai trò
INSERT INTO VaiTro (VAITRO) VALUES ('SINHVIEN');
INSERT INTO VaiTro (VAITRO) VALUES ('GIANGVIEN');
INSERT INTO VaiTro (VAITRO) VALUES ('ADMIN');

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
    MASV CHAR(10) NULL,
    MAGIANGVIEN CHAR(10) NULL,
    FOREIGN KEY (VAITRO) REFERENCES VaiTro(VAITRO),
    FOREIGN KEY (MASV) REFERENCES SinhVien(MASV),
    FOREIGN KEY (MAGIANGVIEN) REFERENCES GiangVien(MAGIANGVIEN)
);

-- Chèn dữ liệu vào bảng Khoa
INSERT INTO Khoa (MAKHOA, TENKHOA)
VALUES
('K01', 'Công nghệ thông tin'),
('K02', 'Kinh tế'),
('K03', 'Toán học'),
('K04', 'Ngôn ngữ Anh'),
('K05', 'Vật lý'),
('K06', 'Hóa học');

-- Chèn dữ liệu vào bảng GiangVien
INSERT INTO GiangVien (MAGIANGVIEN, TENGIANGVIEN, NGAYSINH, GIOITINH, SODIENTHOAI, EMAIL, CCCD, MAKHOA)
VALUES
('GV01', 'Nguyễn Văn A', '1980-01-01', 0, '0123456789', 'anv@example.com', '1234567890123', 'K01'),
('GV02', 'Lê Thị B', '1985-05-15', 1, '0987654321', 'lethib@example.com', '9876543210123', 'K02'),
('GV03', 'Phạm Minh E', '1982-02-10', 0, '0912121212', 'pme@example.com', '3333333333333', 'K03'),
('GV04', 'Trần Thị F', '1979-09-22', 1, '0923232323', 'ttf@example.com', '4444444444444', 'K04'),
('GV05', 'Nguyễn Văn G', '1986-11-05', 0, '0934343434', 'nvg@example.com', '5555555555555', 'K05');

-- Chèn dữ liệu vào bảng SinhVien
INSERT INTO SinhVien (MASV, TENSV, NGAYSINH, GIOITINH, SODIENTHOAI, EMAIL, CCCD, MAKHOA)
VALUES
('SV01', 'Trần Văn C', '2000-03-10', 0, '0912345678', 'tranvanc@example.com', '1112223334445', 'K01'),
('SV02', 'Nguyễn Thị D', '2001-07-25', 1, '0987654321', 'nguyentid@example.com', '5556667778889', 'K02'),
('SV03', 'Lê Văn H', '2001-01-15', 0, '0945454545', 'levanh@example.com', '6666666666666', 'K03'),
('SV04', 'Đỗ Thị I', '2002-02-20', 1, '0956565656', 'dothii@example.com', '7777777777777', 'K04'),
('SV05', 'Hoàng Văn J', '2003-03-25', 0, '0967676767', 'hoangvj@example.com', '8888888888888', 'K05');

-- Chèn dữ liệu vào bảng LinhVuc
INSERT INTO LinhVuc (MALINHVUC, TENLINHVUC, MOTALINHVUC)
VALUES
('LV01', 'Công nghệ thông tin', 'Nghiên cứu về công nghệ thông tin'),
('LV02', 'Khoa học máy tính', 'Nghiên cứu về khoa học máy tính'),
('LV03', 'Môi trường', 'Nghiên cứu về bảo vệ môi trường'),
('LV04', 'Vật liệu học', 'Nghiên cứu về các vật liệu mới');

-- Chèn dữ liệu vào bảng TrangThai
INSERT INTO TrangThai (MATRANGTHAI, TENTRANGTHAI)
VALUES
('TT01', 'Đang xét duyệt'),
('TT02', 'Đã duyệt'),
('TT03', 'Đang nghiên cứu'),
('TT04', 'Hoàn thành');

-- Chèn dữ liệu vào bảng Giaithuong
INSERT INTO Giaithuong (MAGIAITHUONG, TENGIAITHUONG, MOTAGIAITHUONG)
VALUES
('GT01', 'Giải nhất', 'Giải thưởng cao nhất'),
('GT02', 'Giải nhì', 'Giải thưởng cao thứ nhì'),
('GT03', 'Giải ba', 'Giải thưởng cao thứ ba');

-- Chèn dữ liệu vào bảng DeTaiNCKH
INSERT INTO DeTaiNCKH (MADT, TENDT, MOTA, MALINHVUC, MASV, MAKHOA, MAGIANGVIEN, NAMHOC, MATRANGTHAI, MAGIAITHUONG)
VALUES
('DT01', 'Ứng dụng AI trong y tế', 'Nghiên cứu ứng dụng AI...', 'LV01', 'SV01', 'K01', 'GV01', '2023-2024', 'TT01', 'GT01'),
('DT02', 'Phân tích dữ liệu lớn', 'Phân tích dữ liệu lớn...', 'LV02', 'SV02', 'K02', 'GV02', '2023-2024', 'TT02', NULL),
('DT03', 'Bảo vệ tài nguyên nước', 'Nghiên cứu bảo vệ...', 'LV03', 'SV03', 'K03', 'GV03', '2023-2024', 'TT03', 'GT03'),
('DT04', 'Phát triển vật liệu mới', 'Nghiên cứu và phát triển...', 'LV04', 'SV04', 'K04', 'GV04', '2023-2024', 'TT01', 'GT01'),
('DT05', 'Giảm thiểu ô nhiễm môi trường', 'Nghiên cứu và cải thiện các giải pháp...', 'LV03', 'SV05', 'K05', 'GV05', '2024-2025', 'TT03', 'GT02');

-- Chèn dữ liệu vào bảng TaiKhoan, liên kết với sinh viên và giảng viên
INSERT INTO TaiKhoan (MADANGNHAP, MATKHAU, VAITRO, MASV, MAGIANGVIEN)
VALUES
('SV01', 'password123', 'SINHVIEN', 'SV01', NULL),
('SV02', 'password456', 'SINHVIEN', 'SV02', NULL),
('SV03', 'password789', 'SINHVIEN', 'SV03', NULL),
('GV01', 'passwordABC', 'GIANGVIEN', NULL, 'GV01'),
('GV02', 'passwordDEF', 'GIANGVIEN', NULL, 'GV02'),
('ADMIN', 'adminPass', 'ADMIN', NULL, NULL);
