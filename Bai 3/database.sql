CREATE DATABASE QL_DaNgoai;
GO
USE QL_DaNgoai;
GO
CREATE TABLE ChuyenDi (
    MaChuyen INT IDENTITY(1,1) PRIMARY KEY,
    TenChuyen NVARCHAR(100) NOT NULL,
    DiaDiem NVARCHAR(100) NOT NULL,
    NgayDi DATE NOT NULL,
    SoNguoi INT NOT NULL,
    NganSach DECIMAL(18,0) NOT NULL,
    PhuongTien NVARCHAR(30) NOT NULL,
    DaHoanThanh BIT NOT NULL,
    GhiChu NVARCHAR(200) NULL
);
GO
INSERT INTO ChuyenDi (TenChuyen, DiaDiem, NgayDi, SoNguoi, NganSach, PhuongTien, DaHoanThanh, GhiChu) VALUES
(N'Cắm trại đồi chè', N'Đà Lạt', '2026-10-25', 6, 3500000, N'Ô tô', 0, N'Mang theo lều'),
(N'Săn mây Fansipan', N'Sa Pa', '2026-10-28', 4, 4000000, N'Tàu hỏa', 0, N'Áo ấm'),
(N'Nghỉ dưỡng biển cuối tuần', N'Vũng Tàu', '2026-10-22', 5, 2500000, N'Xe máy', 0, N'Hải sản bờ biển'),
(N'Khám phá phố cổ', N'Hội An', '2026-11-01', 8, 6000000, N'Xe khách', 0, N'Tham quan hoa đăng'),
(N'Dã ngoại Ba Vì', N'Ba Vì', '2026-10-20', 10, 2000000, N'Xe máy', 0, N'Đi trong ngày'),
(N'Tắm biển Mỹ Khê', N'Đà Nẵng', '2026-10-30', 4, 5000000, N'Ô tô', 0, N'Nghỉ khách sạn'),
(N'Phượt Hà Giang', N'Hà Giang', '2026-11-05', 6, 4500000, N'Xe máy', 0, N'Ngắm hoa tam giác mạch'),
(N'Cắm trại hồ Trị An', N'Đồng Nai', '2026-10-18', 4, 1500000, N'Ô tô', 1, N'Đã hoàn thành');
GO
