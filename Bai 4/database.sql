CREATE DATABASE QL_TraSua;
GO
USE QL_TraSua;
GO
CREATE TABLE DanhMucMon (
    MaDM INT IDENTITY(1,1) PRIMARY KEY,
    TenDM NVARCHAR(50) NOT NULL
);
GO
CREATE TABLE MonUong (
    MaMon INT IDENTITY(1,1) PRIMARY KEY,
    TenMon NVARCHAR(100) NOT NULL,
    GiaBan DECIMAL(18,0) NOT NULL,
    DangBan BIT NOT NULL,
    MaDM INT NOT NULL,
    CONSTRAINT FK_MonUong_DanhMuc FOREIGN KEY (MaDM) REFERENCES DanhMucMon(MaDM)
);
GO
CREATE TABLE HoaDon (
    MaHD INT IDENTITY(1,1) PRIMARY KEY,
    NgayLap DATETIME NOT NULL,
    TongTien DECIMAL(18,0) NOT NULL,
    HinhThucTT NVARCHAR(20) NOT NULL,
    DaThanhToan BIT NOT NULL
);
GO
CREATE TABLE ChiTietHoaDon (
    MaHD INT NOT NULL,
    MaMon INT NOT NULL,
    SoLy INT NOT NULL,
    DonGia DECIMAL(18,0) NOT NULL,
    PRIMARY KEY (MaHD, MaMon),
    CONSTRAINT FK_CTHD_HoaDon FOREIGN KEY (MaHD) REFERENCES HoaDon(MaHD) ON DELETE CASCADE,
    CONSTRAINT FK_CTHD_MonUong FOREIGN KEY (MaMon) REFERENCES MonUong(MaMon)
);
GO
INSERT INTO DanhMucMon (TenDM) VALUES
(N'Trà sữa'),
(N'Trà trái cây'),
(N'Topping'),
(N'Đồ ăn vặt');
GO
INSERT INTO MonUong (TenMon, GiaBan, DangBan, MaDM) VALUES
(N'Trà sữa trân châu', 35000, 1, 1),
(N'Trà sữa matcha', 40000, 1, 1),
(N'Hồng trà sữa', 32000, 1, 1),
(N'Trà sữa khoai môn', 38000, 1, 1),
(N'Trà đào cam sả', 35000, 1, 2),
(N'Trà vải hoa hồng', 35000, 1, 2),
(N'Trà dâu tằm', 32000, 1, 2),
(N'Trân châu trắng', 5000, 1, 3),
(N'Trân châu đen đường đen', 6000, 1, 3),
(N'Thạch pudding trứng', 7000, 1, 3),
(N'Bánh tráng trộn', 20000, 1, 4),
(N'Khoai tây lắc phô mai', 25000, 1, 4),
(N'Cá viên chiên', 25000, 1, 4);
GO
