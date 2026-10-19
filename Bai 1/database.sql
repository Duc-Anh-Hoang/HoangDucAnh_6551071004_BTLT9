CREATE DATABASE QL_ChiTieu;
GO
USE QL_ChiTieu;
GO
CREATE TABLE ChiTieu (
    MaCT INT IDENTITY(1,1) PRIMARY KEY,
    NgayChi DATE NOT NULL,
    NoiDung NVARCHAR(100) NOT NULL,
    LoaiChi NVARCHAR(30) NOT NULL,
    SoTien DECIMAL(18,0) NOT NULL,
    GhiChu NVARCHAR(200) NULL
);
GO
INSERT INTO ChiTieu (NgayChi, NoiDung, LoaiChi, SoTien, GhiChu) VALUES
('2026-10-01', N'Cơm trưa', N'Ăn uống', 35000, N'Cơm văn phòng'),
('2026-10-02', N'Xăng xe', N'Đi lại', 60000, N'Đổ xăng xe máy'),
('2026-10-03', N'Photo giáo trình', N'Học tập', 25000, N'Tài liệu C#'),
('2026-10-04', N'Xem phim', N'Giải trí', 90000, N'Vé xem phim cuối tuần'),
('2026-10-05', N'Trà sữa', N'Ăn uống', 40000, N'Trà sữa bạn bè'),
('2026-10-06', N'Mua sắm', N'Khác', 150000, N'Đồ dùng cá nhân'),
('2026-10-07', N'Tiền điện', N'Khác', 500000, N'Hóa đơn điện tháng'),
('2026-10-08', N'Ăn sáng', N'Ăn uống', 25000, N'Phở bò'),
('2026-10-10', N'Sách tham khảo', N'Học tập', 120000, N'Sách thuật toán'),
('2026-10-12', N'Vé xe buýt tháng', N'Đi lại', 100000, N'Thẻ buýt'),
('2026-10-15', N'Cà phê với bạn', N'Ăn uống', 45000, N'Hẹn cuối tuần');
GO
