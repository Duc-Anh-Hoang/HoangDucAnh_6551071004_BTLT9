CREATE DATABASE QL_NhaTro;
GO
USE QL_NhaTro;
GO
CREATE TABLE PhongTro (
    MaPhong INT IDENTITY(1,1) PRIMARY KEY,
    TenPhong NVARCHAR(20) NOT NULL,
    GiaThue DECIMAL(18,0) NOT NULL,
    TinhTrang NVARCHAR(20) NOT NULL
);
GO
CREATE TABLE KhachThue (
    MaKhach INT IDENTITY(1,1) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    GioiTinh NVARCHAR(5) NOT NULL,
    NgaySinh DATE NOT NULL,
    SoDienThoai VARCHAR(15) NOT NULL,
    MaTinh INT NOT NULL,
    TenTinh NVARCHAR(100) NOT NULL,
    MaPhuongXa INT NOT NULL,
    TenPhuongXa NVARCHAR(100) NOT NULL,
    DaDangKyTamTru BIT NOT NULL,
    MaPhong INT NOT NULL,
    CONSTRAINT FK_KhachThue_PhongTro FOREIGN KEY (MaPhong) REFERENCES PhongTro(MaPhong) ON DELETE CASCADE
);
GO
INSERT INTO PhongTro (TenPhong, GiaThue, TinhTrang) VALUES
(N'P01', 1500000, N'Đang thuê'),
(N'P02', 1600000, N'Đang thuê'),
(N'P03', 1800000, N'Đang thuê'),
(N'P04', 2000000, N'Đang thuê'),
(N'P05', 1700000, N'Đang thuê'),
(N'P06', 1900000, N'Trống');
GO
INSERT INTO KhachThue (HoTen, GioiTinh, NgaySinh, SoDienThoai, MaTinh, TenTinh, MaPhuongXa, TenPhuongXa, DaDangKyTamTru, MaPhong) VALUES
(N'Trần Thị Bình', N'Nữ', '2001-05-10', '0876543210', 1, N'Thành phố Hà Nội', 1, N'Phường Phúc Xá', 0, 1),
(N'Lê Văn Cường', N'Nam', '2000-08-20', '0901234567', 38, N'Tỉnh Thanh Hóa', 14500, N'Phường Ba Đình', 0, 2),
(N'Nguyễn Văn An', N'Nam', '2004-12-05', '0912345678', 1, N'Thành phố Hà Nội', 4, N'Phường Hàng Bạc', 1, 3),
(N'Phạm Minh Đức', N'Nam', '2002-03-15', '0987654321', 38, N'Tỉnh Thanh Hóa', 14503, N'Phường Lam Sơn', 0, 4),
(N'Hoàng Thị Dung', N'Nữ', '2003-11-25', '0765432109', 27, N'Tỉnh Bắc Ninh', 9800, N'Phường Tiền An', 0, 5);
GO
