IF EXISTS (SELECT name FROM sys.databases WHERE name = N'QLRP')
BEGIN
    -- Đóng tất cả các kết nối đến database (nếu có)
    ALTER DATABASE QLRP SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    -- Xóa database
    DROP DATABASE QLRP;
END
-- Tạo database mới
CREATE DATABASE QLRP;

go

USE QLRP;

-- Thông báo database đã được tạo thành công
PRINT N'Database QLRP đã tạo thành công.';

GO
-- Phần chung
-- Tạo bảng TaiKhoan
CREATE TABLE TaiKhoan
(
    id INT IDENTITY(1,1) NOT NULL ,
	UserName NVARCHAR(100)  NOT NULL UNIQUE,
	PassWord VARCHAR(1000) NOT NULL,
	idRole INT NOT NULL DEFAULT 2,  
	GhiNhoTK INT NOT NULL DEFAULT 1,
	idNV INT NULL,  -- NULL nếu là khách hàng
	idKH INT NULL,  -- NULL nếu là nhân viên

	CONSTRAINT PK_TaiKhoan PRIMARY KEY (id) 

)

-- Tạo bảng Role
CREATE TABLE Role
(
    id INT IDENTITY(1,1) NOT NULL, -- ID tự động tăng
    TenRole NVARCHAR(100)  NOT NULL UNIQUE, -- Tên vai trò, ví dụ: Admin, Staff
    MoTa NVARCHAR(255), -- Mô tả chi tiết về vai trò
    CONSTRAINT PK_Role PRIMARY KEY (id) -- Thêm tên cho khóa chính
);
GO
GO

-- Phần nhân viên quản lý
-- Tạo bảng NhanVien
CREATE TABLE NhanVien
(
	id INT IDENTITY(1,1) NOT NULL,
	HoTen NVARCHAR(255) NOT NULL,
	NgaySinh DATE NOT NULL,
	DiaChi NVARCHAR(255),
	SDT VARCHAR(255),
	CMND INT NOT NULL UNIQUE,
	CONSTRAINT PK_NhanVien PRIMARY KEY (id)
)

-- Tạo bảng LoaiManHinh
CREATE TABLE LoaiManHinh
(
    id INT IDENTITY(1,1) NOT NULL, -- ID tự động tăng
	TenMH NVARCHAR(100),
	KichThuoc int DEFAULT 20,
	CONSTRAINT PK_LoaiManHinh PRIMARY KEY (id) -- Thêm tên cho khóa chính
)
GO

-- Tạo bảng PhongChieu
CREATE TABLE PhongChieu
(
    id INT IDENTITY(1,1) NOT NULL, -- ID tự động tăng
	TenPhong NVARCHAR(100) NOT NULL,
	idManHinh INT,
	SoGheNgoi INT NOT NULL,
	TrangThaiChoNgoi INT NOT NULL DEFAULT 1,
	SoHangGhe INT NOT NULL,
	SoGheMotHang INT NOT NULL,
	CONSTRAINT PK_PhongChieu PRIMARY KEY (id) -- Thêm tên cho khóa chính
)
GO

-- Tạo bảng Phim
CREATE TABLE Phim
(
    id INT IDENTITY(1,1) NOT NULL, -- ID tự động tăng
	TenPhim NVARCHAR(100) NOT NULL,
	MoTa NVARCHAR(1000),
	ThoiLuong FLOAT NOT NULL,
	NgayKhoiChieu DATE NOT NULL,
	NgayKetThuc DATE NOT NULL,
	SanXuat NVARCHAR(50) NOT NULL,
	DaoDien NVARCHAR(100),
	DienVien NVARCHAR(100),
	NamSX INT NOT NULL,
	Poster IMAGE,
	CONSTRAINT PK_Phim PRIMARY KEY (id) 
)
GO

-- Tạo bảng TheLoai
CREATE TABLE TheLoai
(
	id INT IDENTITY(1,1) NOT NULL,
	TenTheLoai NVARCHAR(255) NOT NULL,
	MoTa NVARCHAR(255),
	CONSTRAINT PK_TheLoai PRIMARY KEY (id)
)
GO

-- Tạo bảng LichChieuPhim
CREATE TABLE LichChieuPhim
(
    id INT IDENTITY(1,1) NOT NULL, -- ID tự động tăng
	ThoiGianChieu DATETIME NOT NULL,
	idPhong INT NOT NULL,
	GiaVePhim MONEY NOT NULL,
	idPhim INT NOT NULL,
	TrangThaiChieu INT NOT NULL DEFAULT '0', --0: Chưa tạo vé cho lịch chiếu || 1: Đã tạo vé
	CONSTRAINT PK_LichChieuPhim PRIMARY KEY (id) -- Thêm tên cho khóa chính
)
GO

CREATE TABLE ChiTietPhimTL
(
	idPhim  INT  NOT NULL,
	idTheLoai  INT NOT NULL,
	CONSTRAINT PK_ChiTietPhimTL PRIMARY KEY (idPhim, idTheLoai) 
	)
GO


GO


-- Phần khách hàng

-- Tạo bảng VePhim
CREATE TABLE VePhim
(
	id INT IDENTITY(1,1) NOT NULL,
	LoaiVePhim INT DEFAULT '0', --0: Vé người lớn || 1: Vé học sinh - sinh viên || 2: vé trẻ em
	idLichChieuPhim  INT  NOT NULL,
	MaGheNgoi VARCHAR(50) Unique,
	idKhachHang  INT NOT NULL,
	TrangThaiVePhim INT NOT NULL DEFAULT '0', --0: 'Chưa Bán' || 1: 'Đã Bán'
	TienVePhim MONEY DEFAULT '0',
	CONSTRAINT PK_VePhim PRIMARY KEY (id) -- Thêm tên cho khóa chính
)
GO
-- Tạo bảng KhachHang
CREATE TABLE KhachHang
(
    id INT IDENTITY(1,1) NOT NULL, -- ID tự động tăng
	HoTen NVARCHAR(255) NOT NULL,
	NgaySinh DATE NOT NULL,
	DiemTichLuy INT,
	DiaChi NVARCHAR(255),
	SDT VARCHAR(255),
	EMAIL VARCHAR(255) NOT NULL UNIQUE,
	GioiTinh NVARCHAR(10),
	CONSTRAINT PK_KhachHang PRIMARY KEY (id)
)
CREATE TABLE Voucher
(
    id INT IDENTITY(1,1) NOT NULL, -- ID tự động tăng
    MaVoucher NVARCHAR(50) NOT NULL UNIQUE,  -- Mã voucher
    GiaTriGiam MONEY NOT NULL,  -- Giá trị giảm
    NgayBatDau DATETIME NOT NULL,  -- Ngày bắt đầu
    NgayKetThuc DATETIME NOT NULL,  -- Ngày kết thúc
    CONSTRAINT PK_Voucher PRIMARY KEY (id)
);
GO
CREATE TABLE HoaDon
(
    id INT IDENTITY(1,1) NOT NULL,  -- ID tự động tăng
    idKhachHang INT NOT NULL,  -- ID khách hàng
    NgayMua DATETIME NOT NULL,  -- Ngày mua vé
    TongTien MONEY NOT NULL,  -- Tổng tiền
    CONSTRAINT PK_HoaDon PRIMARY KEY (id),  -- Khóa chính
    CONSTRAINT FK_HoaDon_KhachHang FOREIGN KEY (idKhachHang) REFERENCES dbo.KhachHang(id)
);
CREATE TABLE ChiTietHoaDon
(
    idHoaDon INT NOT NULL,  -- ID hóa đơn
    idVePhim INT NOT NULL,  -- ID vé
    SoLuong INT NOT NULL,  -- Số lượng vé
    GiaTien MONEY NOT NULL,  -- Giá vé
    CONSTRAINT PK_ChiTietHoaDon PRIMARY KEY (idHoaDon, idVePhim),  -- Khóa chính nhiều cột
    CONSTRAINT FK_ChiTietHoaDon_HoaDon FOREIGN KEY (idHoaDon) REFERENCES HoaDon(id),
    CONSTRAINT FK_ChiTietHoaDon_Ve FOREIGN KEY (idVePhim) REFERENCES VePhim(id)
);


-- Thêm ràng buộc FOREIGN KEY cho bảng TaiKhoan
ALTER TABLE TaiKhoan
ADD CONSTRAINT FK_TaiKhoan_NhanVien FOREIGN KEY (idNV)
REFERENCES dbo.NhanVien(id);

ALTER TABLE TaiKhoan
ADD CONSTRAINT FK_TaiKhoan_KhachHang FOREIGN KEY (idKH)
REFERENCES dbo.KhachHang(id);
-- Thêm ràng buộc FOREIGN KEY cho bảng PhongChieu
ALTER TABLE PhongChieu
ADD CONSTRAINT FK_PhongChieu_LoaiManHinh FOREIGN KEY (idManHinh)
REFERENCES dbo.LoaiManHinh(id);

-- Thêm ràng buộc FOREIGN KEY cho bảng ChiTietPhimTL
ALTER TABLE ChiTietPhimTL
ADD CONSTRAINT FK_ChiTietPhimTL_Phim FOREIGN KEY (idPhim)
REFERENCES dbo.Phim(id);

ALTER TABLE ChiTietPhimTL
ADD CONSTRAINT FK_ChiTietPhimTL_TheLoai FOREIGN KEY (idTheLoai)
REFERENCES dbo.TheLoai(id);

-- Thêm ràng buộc FOREIGN KEY cho bảng LichChieuPhim
ALTER TABLE LichChieuPhim
ADD CONSTRAINT FK_LichChieuPhim_PhongChieu FOREIGN KEY (idPhong)
REFERENCES dbo.PhongChieu(id);

ALTER TABLE LichChieuPhim
ADD CONSTRAINT FK_LichChieuPhim_Phim FOREIGN KEY (idPhim)
REFERENCES dbo.Phim(id);

-- Thêm ràng buộc FOREIGN KEY cho bảng VePhim
ALTER TABLE VePhim
ADD CONSTRAINT FK_VePhim_LichChieuPhim FOREIGN KEY (idLichChieuPhim)
REFERENCES dbo.LichChieuPhim(id);

ALTER TABLE VePhim
ADD CONSTRAINT FK_VePhim_KhachHang FOREIGN KEY (idKhachHang)
REFERENCES dbo.KhachHang(id);

ALTER TABLE TaiKhoan
ADD CONSTRAINT FK_TaiKhoan_Role FOREIGN KEY (idRole)
REFERENCES dbo.Role(id);
go

INSERT INTO Role (TenRole, MoTa)
VALUES ('Admin', N'Quản lý toàn bộ hệ thống.');
INSERT INTO Role (TenRole, MoTa)
VALUES (N'Khách Hàng', N'Người dùng mua vé xem phim.');
INSERT INTO Role (TenRole, MoTa)
VALUES ('Staff', N'Quản lý hệ thống suất chiếu phim.');

INSERT INTO KhachHang (HoTen, NgaySinh, DiemTichLuy, DiaChi, SDT, EMAIL, GioiTinh)
VALUES ('Nguyen Van A', '1990-01-01', 0, N'123 Đường ABC, Quận 1, TP.HCM', '0123456789', 'nguyenvana@example.com', N'Nam');

INSERT INTO KhachHang (HoTen, NgaySinh, DiemTichLuy, DiaChi, SDT, EMAIL, GioiTinh)
VALUES ('Tran Thi B', '1995-05-15', 0, N'456 Đường XYZ, Quận 2, TP.HCM', '0987654321', 'tranthib@example.com', N'Nữ');

INSERT INTO NhanVien (HoTen, NgaySinh, DiaChi, SDT, CMND)
VALUES ('Le Van C', '1985-03-20', N'789 Đường DEF, Quận 3, TP.HCM', '0123456780', 123456789);

INSERT INTO NhanVien (HoTen, NgaySinh, DiaChi, SDT, CMND)
VALUES ('Pham Thi D', '1992-07-30', N'321 Đường GHI, Quận 4, TP.HCM', '0987654300', 987654321);


INSERT INTO TaiKhoan (UserName, PassWord, idRole, GhiNhoTK, idNV, idKH)
VALUES 
('admin', 'admin123', 1, 1, NULL, 2),
('customer1', 'customer123', 2, 1, NULL, 1);


INSERT INTO Voucher (MaVoucher, GiaTriGiam, NgayBatDau, NgayKetThuc)
VALUES
('AVATAR2024', 5000, '2024-01-01', '2024-02-28');

-- Thêm dữ liệu vào bảng Phim
INSERT INTO Phim (TenPhim, MoTa, ThoiLuong, NgayKhoiChieu, NgayKetThuc, SanXuat, DaoDien, DienVien, NamSX)
VALUES
('Avatar', 'Phim hành động khoa học viễn tưởng.', 2.5, '2023-10-27', '2024-01-10', '20th Century Studios', 'James Cameron', 'Sam Worthington', 2022),
('Avengers: Endgame', 'Phim siêu anh hùng.', 3, '2019-04-26', '2019-05-03', 'Marvel Studios', 'Anthony Russo, Joe Russo', 'Robert Downey Jr', 2019),
('Spider-Man: No Way Home', 'Phim siêu anh hùng.', 2.1, '2021-12-17', '2022-01-07', 'Sony Pictures', 'Jon Watts', 'Tom Holland', 2021),
('The Batman', 'Phim hành động.', 2.5, '2022-03-03', '2022-03-10', 'Warner Bros.', 'Matt Reeves', 'Robert Pattinson', 2022);
-- Thêm dữ liệu vào bảng TheLoai
INSERT INTO TheLoai (TenTheLoai, MoTa) VALUES
('Hành động', 'Thể loại hành động, phiêu lưu.'),
('Siêu anh hùng', 'Thể loại siêu anh hùng, phiêu lưu.'),
('Khoa học viễn tưởng', 'Thể loại khoa học viễn tưởng.'),
('Hài hước', 'Thể loại hài hước.');

-- Thêm dữ liệu vào bảng ChiTietPhimTL
INSERT INTO ChiTietPhimTL (idPhim, idTheLoai) VALUES
(1, 1), -- Avatar - Hành động
(1, 3), -- Avatar - Khoa học viễn tưởng
(2, 2), -- Avengers: Endgame - Siêu anh hùng
(3, 2), -- Spider-Man: No Way Home - Siêu anh hùng
(4, 1); -- The Batman - Hành động

INSERT INTO PhongChieu (TenPhong, idManHinh, SoGheNgoi, SoHangGhe, SoGheMotHang)
VALUES
('Phong 1', 1, 50, 5, 10),
('Phong 2', 2, 100, 10, 10);

--Thêm dữ liệu vào bảng LichChieuPhim để test
INSERT INTO LichChieuPhim (ThoiGianChieu, idPhong, GiaVePhim, idPhim)
VALUES
('2024-01-20 14:00:00', 1, 10000, 1), --Avatar chiếu trong ngày 20/01/2024
('2024-01-20 19:00:00', 1, 15000, 2),-- Avengers chiếu trong ngày 20/01/2024
('2024-01-20 10:00:00', 2, 12000, 3);--Spider-Man chiếu trong ngày 20/01/2024


DROP PROC TimPhimTheoNgayKTVaBatDauTheoTheLoai
  CREATE PROCEDURE TimPhimTheoNgayKTVaBatDauTheoTheLoai
    @StartDate DATE,
    @EndDate DATE,
	@Genre NVARCHAR(50)
AS
BEGIN
    IF @StartDate IS NULL OR @EndDate IS NULL
    BEGIN
        RAISERROR(N'Trường @StartDate và @EndDate phải khác null.', 16, 1)
        RETURN
    END
    IF @StartDate > @EndDate
    BEGIN
        RAISERROR(N'Ngày khởi chiếu ko lớn hơn ngày kết thuc', 16, 1)
        RETURN
    END

    SELECT
        p.id,
        p.TenPhim,
        p.Poster,
        p.ThoiLuong,
        p.DaoDien
    FROM
        Phim p
    JOIN
        ChiTietPhimTL cpt ON p.id = cpt.idPhim
    JOIN
        TheLoai t ON cpt.idTheLoai = t.id
    WHERE
        t.TenTheLoai =@Genre  --Filter for Action movies
        AND p.NgayKhoiChieu BETWEEN @StartDate AND @EndDate
        AND p.NgayKetThuc BETWEEN @StartDate AND @EndDate; --Adjusted for movies running during that period
END;
go


EXEC TimPhimTheoNgayKTVaBatDauTheoTheLoai @StartDate = '2023-01-01', @EndDate = '2024-01-31', @Genre= 'Hành động';



CREATE PROCEDURE TimPhimTheoNgayVaLoai
    @Date DATE,
    @Genre NVARCHAR(100)
AS
BEGIN
    -- Check if the provided date is valid.  Important for robustness.
    IF @Date IS NULL
    BEGIN
        RAISERROR('Ngày nhập ko chính xác', 16, 1)
        RETURN
    END
    
    -- Check if the provided genre is valid.  Important for robustness.
	IF @Genre IS NULL
    BEGIN
        RAISERROR('Thể loại ko tồn tại.', 16, 1)
        RETURN
    END
	
    SELECT
        p.id,
        p.TenPhim,
        p.Poster,
        p.ThoiLuong,
        p.DaoDien,
		p.MoTa,
		p.NamSX,
		p.DienVien,
		p.NgayKetThuc,
		p.NgayKetThuc
    FROM
        Phim p
    JOIN
        ChiTietPhimTL cpt ON p.id = cpt.idPhim
    JOIN
        TheLoai t ON cpt.idTheLoai = t.id
	WHERE
        t.TenTheLoai = @Genre
		AND p.NgayKhoiChieu <= @Date
		AND p.NgayKetThuc >= @Date
		AND EXISTS (SELECT 1 FROM LichChieuPhim l WHERE l.idPhong = p.id AND l.ThoiGianChieu >= @Date); --If you want a list of movies *actually* playing on the day.
END;

go
EXEC TimPhimTheoNgayVaLoai @Date = '2023-10-29', @Genre = 'Hành động';
go
CREATE PROC PROC_TinhTongDoanhThuPhim
    @idPhim VARCHAR(10) -- ID của phim cần tính tổng doanh thu
AS
BEGIN
    -- Tính tổng doanh thu từ vé đã bán cho phim được chọn
    SELECT P.TenPhim AS [Tên phim], SUM(V.TienVePhim) AS [Tổng doanh thu]
    FROM VePhim AS V
    JOIN LichChieuPhim AS LCP ON V.idLichChieuPhim = LCP.id
    JOIN PhongChieu AS PC ON LCP.idPhong = PC.id
    JOIN Phim AS P ON P.id = LCP.idPhong
    WHERE P.id = @idPhim AND V.TrangThaiVePhim = 1 -- Chỉ tính vé đã bán
    GROUP BY P.TenPhim
END
GO

EXEC USP_TinhTongDoanhThuPhim 'P001' 
go
CREATE PROC PROC_TongDoanhThuAllPhim
AS
BEGIN
    -- Lấy tổng số vé đã bán và tổng doanh thu của từng phim
    SELECT 
        P.TenPhim AS [Tên phim], 
        COUNT(VP.id) AS [Số lượng vé đã bán], 
        SUM(VP.TienVePhim) AS [Tổng doanh thu]
    FROM 
        dbo.VePhim AS VP
        INNER JOIN dbo.LichChieuPhim AS LCP ON VP.idLichChieuPhim = LCP.id
        INNER JOIN dbo.PhongChieu AS PC ON LCP.idPhong = PC.id
        INNER JOIN dbo.Phim AS P ON LCP.idPhong = P.id
    WHERE 
        VP.TrangThaiVePhim = 1 -- Chỉ tính những vé đã bán
    GROUP BY 
        P.TenPhim
    ORDER BY 
        [Tổng doanh thu] DESC; -- Sắp xếp theo tổng doanh thu giảm dần
END
GO


ALTER TABLE LichChieuPhim
ADD CONSTRAINT CHK_LichChieu_NgayGio 
CHECK (ThoiGianChieu <= (SELECT NgayKhoiChieu FROM Phim WHERE Phim.id = LichChieuPhim.idPhim));

go
-- tự động tạo vé phim khi insert lịch chiếu
CREATE TRIGGER trg_AutoCreateVePhim
ON LichChieuPhim
AFTER INSERT
AS
BEGIN
    DECLARE @idPhong INT, @idLichChieu INT, @SoGhe INT;

    -- Lấy thông tin từ bảng LichChieuPhim vừa được insert
    SELECT @idPhong = idPhong, @idLichChieu = id 
    FROM inserted;

    -- Lấy số ghế ngồi từ bảng PhongChieu
    SELECT @SoGhe = SoGheNgoi
    FROM PhongChieu
    WHERE id = @idPhong;

    DECLARE @i INT = 1;
    DECLARE @MaGhe VARCHAR(50);

    -- Vòng lặp để tạo vé cho từng ghế
    WHILE @i <= @SoGhe
    BEGIN
        SET @MaGhe = 'Ghe_' + CAST(@i AS VARCHAR);  -- Tạo mã ghế
        
        -- Thêm vé vào bảng VePhim
        INSERT INTO VePhim (idLichChieuPhim, MaGheNgoi, idKhachHang, TrangThaiVePhim)
        VALUES (@idLichChieu, @MaGhe, NULL, 0);  -- idKhachHang là NULL, TrangThaiVePhim là 'Chưa Bán' (0)

        SET @i = @i + 1;  -- Tăng biến đếm
    END
END
GO

-- Lịch chiếu không được lớn hơn ngày khởi chiếu của phim.
CREATE TRIGGER trg_CheckNgayChieu
ON LichChieuPhim
INSTEAD OF INSERT
AS
BEGIN
    DECLARE @ThoiGianChieu DATETIME, @idPhim INT;

    -- Lặp qua các bản ghi mới được chèn
    DECLARE cur CURSOR FOR SELECT ThoiGianChieu, idPhim FROM inserted;
    OPEN cur;

    FETCH NEXT FROM cur INTO @ThoiGianChieu, @idPhim;
    WHILE @@FETCH_STATUS = 0
    BEGIN
        -- Kiểm tra điều kiện
        IF @ThoiGianChieu > (SELECT NgayKhoiChieu FROM Phim WHERE id = @idPhim)
        BEGIN
            RAISERROR('Lịch chiếu không được lớn hơn ngày khởi chiếu của phim.', 16, 1);
            ROLLBACK;  -- Hủy bỏ giao dịch
            RETURN;  -- Thoát khỏi trigger
        END

        -- Nếu không có lỗi, chèn bản ghi vào bảng LichChieuPhim
        INSERT INTO LichChieuPhim (ThoiGianChieu, idPhong, GiaVePhim, TrangThaiChieu, idPhim)
        VALUES (@ThoiGianChieu, (SELECT idPhong FROM inserted WHERE idPhim = @idPhim), 
                (SELECT GiaVePhim FROM inserted WHERE idPhim = @idPhim), 0, @idPhim);

        FETCH NEXT FROM cur INTO @ThoiGianChieu, @idPhim;
    END

    CLOSE cur;
    DEALLOCATE cur;
END
GO
-- kiểm tra 1 phim còn vé hay ko
CREATE PROCEDURE PROC_KiemTraPhimConVe
    @idPhim NVARCHAR(50)  -- Định nghĩa tham số đầu vào là ID của phim
AS
BEGIN
    -- Truy vấn kiểm tra suất chiếu của phim còn vé hay không
    SELECT 
        p.TenPhim, 
        lc.ThoiGianChieu,
        pc.TenPhong,
        (pc.SoGheNgoi - COUNT(vp.id)) AS SoGheConLai
    FROM 
        Phim p
    INNER JOIN LichChieuPhim lc ON p.id = lc.id
    INNER JOIN PhongChieu pc ON lc.idPhong = pc.id
    LEFT JOIN VePhim vp ON lc.id = vp.idLichChieuPhim AND vp.TrangThaiVePhim = 1
    WHERE 
        p.id = @idPhim  -- Sử dụng tham số đầu vào
    GROUP BY 
        p.TenPhim, lc.ThoiGianChieu, pc.TenPhong, pc.SoGheNgoi
    HAVING 
        (pc.SoGheNgoi - COUNT(vp.id)) > 0  -- Phim còn ghế trống
END



CREATE PROCEDURE PROC_DatVe
    @idKhachHang INT,              -- ID khách hàng
    @idLichChieuPhim INT,         -- ID lịch chiếu phim
    @SoLuong INT,                  -- Số lượng vé cần đặt
    @LoaiVePhim INT                -- Loại vé (0: vé người lớn, 1: vé học sinh - sinh viên, 2: vé trẻ em)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @SoGheConLai INT;      -- Số ghế còn lại
    DECLARE @GiaVeMoney MONEY;      -- Giá vé
    DECLARE @TongTien MONEY;        -- Tổng tiền vé
    DECLARE @idVePhim INT;          -- ID vé phim tạm thời
    DECLARE @MaGhe VARCHAR(50);     -- Mã ghế tạm thời
    DECLARE @i INT = 1;             -- Biến đếm

    -- Kiểm tra số ghế còn lại
    SELECT @SoGheConLai = (SELECT pc.SoGheNgoi - COUNT(vp.id)
                           FROM PhongChieu pc
                           INNER JOIN LichChieuPhim lc ON pc.id = lc.idPhong
                           LEFT JOIN VePhim vp ON lc.id = vp.idLichChieuPhim AND vp.TrangThaiVePhim = 1
                           WHERE lc.id = @idLichChieuPhim
                           GROUP BY pc.SoGheNgoi)
    WHERE @SoGheConLai > 0;

    -- Kiểm tra xem còn ghế hay không
    IF @SoGheConLai < @SoLuong
    BEGIN
        RAISERROR('Không đủ ghế trống cho số lượng vé yêu cầu.', 16, 1);
        RETURN;
    END

    -- Lấy giá vé cho lịch chiếu phim
    SELECT @GiaVeMoney = GiaVePhim FROM LichChieuPhim WHERE id = @idLichChieuPhim;

    -- Tính tổng tiền vé
    SET @TongTien = @SoLuong * @GiaVeMoney;

    -- Tạo hóa đơn
    DECLARE @idHoaDon INT;
    INSERT INTO HoaDon (idKhachHang, NgayMua, TongTien)
    VALUES (@idKhachHang, GETDATE(), @TongTien);
    SET @idHoaDon = SCOPE_IDENTITY();  -- Lấy ID hóa đơn vừa tạo

    -- Cập nhật trạng thái vé
    WHILE @i <= @SoLuong
    BEGIN
        -- Lấy mã ghế cho vé
        SELECT TOP 1 @MaGhe = MaGheNgoi
        FROM VePhim
        WHERE idLichChieuPhim = @idLichChieuPhim AND TrangThaiVePhim = 0;  -- Chỉ lấy vé chưa bán

        -- Cập nhật vé đã bán
        UPDATE VePhim
        SET TrangThaiVePhim = 1, idKhachHang = @idKhachHang
        WHERE MaGheNgoi = @MaGhe;

        -- Thêm vào bảng chi tiết hóa đơn
        INSERT INTO ChiTietHoaDon (idHoaDon, idVePhim, SoLuong, GiaTien)
        VALUES (@idHoaDon, (SELECT id FROM VePhim WHERE MaGheNgoi = @MaGhe), 1, @GiaVeMoney);

        SET @i = @i + 1;  -- Tăng biến đếm
    END

    PRINT 'Đặt vé thành công!';
END
GO
