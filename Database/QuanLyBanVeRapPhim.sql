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
	idNV INT NOT NULL,  

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
	idQuanLy INT,
	SDT VARCHAR(255),
	CMND INT NOT NULL UNIQUE,
	CONSTRAINT PK_NhanVien PRIMARY KEY (id)
)

-- Tạo bảng LoaiManHinh
CREATE TABLE LoaiManHinh
(
    id INT IDENTITY(1,1) NOT NULL, -- ID tự động tăng
	TenMH NVARCHAR(100) NOT NULL UNIQUE,
	KichThuoc INT DEFAULT 20,
	CONSTRAINT PK_LoaiManHinh PRIMARY KEY (id) -- Thêm tên cho khóa chính
)
GO

-- Tạo bảng PhongChieu
CREATE TABLE PhongChieu
(
    id INT IDENTITY(1,1) NOT NULL, -- ID tự động tăng
	TenPhong NVARCHAR(100) NOT NULL UNIQUE,
	idManHinh INT,
	SoGheNgoi INT NOT NULL,
	TrangThaiChoNgoi INT NOT NULL DEFAULT 1,
	SoHangGhe INT NOT NULL,
	SoCotGhe INT NOT NULL,
	CONSTRAINT PK_PhongChieu PRIMARY KEY (id) -- Thêm tên cho khóa chính
)
GO

-- Tạo bảng Phim
CREATE TABLE Phim
(
    id INT IDENTITY(1,1) NOT NULL, -- ID tự động tăng
	TenPhim NVARCHAR(100) NOT NULL,
	MoTa NVARCHAR(1000),
	ThoiLuong INT NOT NULL,
	NgayKhoiChieu DATE NOT NULL,
	NgayKetThuc DATE NOT NULL,
	SanXuat NVARCHAR(50) NOT NULL,
	DaoDien NVARCHAR(100),
	DienVien NVARCHAR(100),
	NamSX INT NOT NULL,
	PosterPath NVARCHAR(100) NULL,
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
	CONSTRAINT PK_LichChieuPhim PRIMARY KEY (id) 
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
	LoaiVePhim INT DEFAULT '0', --0: Vé người lớn , 1 vé sinh viên, trẻ em
	idLichChieuPhim  INT  NOT NULL,
	MaGheNgoi VARCHAR(50) ,
	idKhachHang  INT ,
	TrangThaiVePhim INT NOT NULL DEFAULT '0', --0: 'Chưa Bán' || 1: 'Đã Bán'
	TienVePhim MONEY DEFAULT '0', -- tùy thuộc vào loại vé phim
	CONSTRAINT PK_VePhim PRIMARY KEY (id) 
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
    TenVoucher NVARCHAR(50) NOT NULL UNIQUE,  -- Mã voucher
    GiaTriGiam MONEY NOT NULL,  -- Giá trị giảm
    NgayBatDau DATETIME NOT NULL,  -- Ngày bắt đầu
    NgayKetThuc DATETIME NOT NULL,  -- Ngày kết thúc
    CONSTRAINT PK_Voucher PRIMARY KEY (id)
)
GO
CREATE TABLE HoaDon
(
    id INT IDENTITY(1,1) NOT NULL,  -- ID tự động tăng
    idKhachHang INT  NULL,  -- ID khách hàng
    NgayMua DATETIME NOT NULL,  -- Ngày mua vé
    TongTien MONEY NOT NULL,  -- Tổng tiền
	idVoucher INT NULL,
    CONSTRAINT PK_HoaDon PRIMARY KEY (id),  -- Khóa chính
    CONSTRAINT FK_HoaDon_KhachHang FOREIGN KEY (idKhachHang) REFERENCES dbo.KhachHang(id)
)
CREATE TABLE ChiTietHoaDon
(
    idHoaDon INT NOT NULL,  -- ID hóa đơn
    idVePhim INT NOT NULL,  -- ID vé
    SoLuong INT NOT NULL,  -- Số lượng vé
    GiaTien MONEY NOT NULL,  -- Giá vé
    CONSTRAINT PK_ChiTietHoaDon PRIMARY KEY (idHoaDon, idVePhim),  -- Khóa chính nhiều cột
    CONSTRAINT FK_ChiTietHoaDon_HoaDon FOREIGN KEY (idHoaDon) REFERENCES HoaDon(id),
    CONSTRAINT FK_ChiTietHoaDon_Ve FOREIGN KEY (idVePhim) REFERENCES VePhim(id)
)


-- Thêm ràng buộc FOREIGN KEY cho bảng TaiKhoan
ALTER TABLE TaiKhoan
ADD CONSTRAINT FK_TaiKhoan_NhanVien FOREIGN KEY (idNV)
REFERENCES dbo.NhanVien(id);


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

ALTER TABLE HoaDon
ADD CONSTRAINT FK_HoaDon_Voucher FOREIGN KEY (idVoucher) REFERENCES Voucher(id);
--ALTER TABLE LichChieuPhim
--ADD CONSTRAINT UK_LichChieu_Phong_ThoiGian
--UNIQUE (ThoiGianChieu, idPhong);

ALTER TABLE NhanVien
ADD CONSTRAINT FK_NhanVien_QuanLy FOREIGN KEY (idQuanLy) REFERENCES NhanVien(id);


ALTER TABLE VePhim
ADD CONSTRAINT UQ_VePhim UNIQUE (idLichChieuPhim, MaGheNgoi);

go

INSERT INTO Role (TenRole, MoTa)
VALUES ('Admin', N'Quản lý toàn bộ hệ thống.');
INSERT INTO Role (TenRole, MoTa)
VALUES (N'Khách Hàng', N'Người dùng mua vé xem phim.');
INSERT INTO Role (TenRole, MoTa)
VALUES ('Staff', N'Quản lý hệ thống suất chiếu phim.');

INSERT INTO KhachHang (HoTen, NgaySinh, DiemTichLuy, DiaChi, SDT, EMAIL, GioiTinh)
VALUES (N'Nguyen Van A', '1990-01-01', 0, N'123 Đường ABC, Quận 1, TP.HCM', '0123456789', 'nguyenvana@example.com', N'Nam');

INSERT INTO KhachHang (HoTen, NgaySinh, DiemTichLuy, DiaChi, SDT, EMAIL, GioiTinh)
VALUES (N'Tran Thi B', '1995-05-15', 0, N'456 Đường XYZ, Quận 2, TP.HCM', '0987654321', 'tranthib@example.com', N'Nữ');

INSERT INTO NhanVien (HoTen, NgaySinh, DiaChi, SDT, CMND)
VALUES (N'Le Van C', '1985-03-20', N'789 Đường DEF, Quận 3, TP.HCM', '0123456780', 123456789);

INSERT INTO NhanVien (HoTen, NgaySinh, DiaChi, SDT, CMND)
VALUES ('Pham Thi D', '1992-07-30', N'321 Đường GHI, Quận 4, TP.HCM', '0987654300', 987654321);

INSERT INTO NhanVien (HoTen, NgaySinh, DiaChi, SDT, CMND)
VALUES ('Vo Ngoc E', '1994-02-26', N'30 Đường Thới an, Quận 12, TP.HCM', '0772837620', 424162626);

GO
INSERT INTO TaiKhoan (UserName, PassWord, idRole, GhiNhoTK, idNV)
VALUES 
('admin', 'admin123', 1, 1,1),
('staff', 'staff123', 2, 1, 2),
('staff2', 'staff123', 2, 1, 3);


GO
-- Thêm dữ liệu vào bảng Phim
INSERT INTO Phim (TenPhim, MoTa, ThoiLuong, NgayKhoiChieu, NgayKetThuc, SanXuat, DaoDien, DienVien, NamSX)
VALUES
('Avatar', N'Phim hành động khoa học viễn tưởng.', 160, '2023-10-27', '2025-01-10', '20th Century Studios', 'James Cameron', 'Sam Worthington', 2022),
('Avengers', N'Phim siêu anh hùng.', 180, '2019-04-26', '2025-05-03', 'Marvel Studios', 'Anthony Russo, Joe Russo', 'Robert Downey Jr', 2019),
('Spider-Man', N'Phim siêu anh hùng.', 130, '2021-12-17', '2025-01-07', 'Sony Pictures', 'Jon Watts', 'Tom Holland', 2021),
('The Batman', N'Phim hành động.', 160, '2022-03-03', '2025-03-10', 'Warner Bros.', 'Matt Reeves', 'Robert Pattinson', 2022),
('Top Gun', 'Phim hành động.', 130, '2022-05-27', '2025-06-03', 'Paramount Pictures', 'Joseph Kosinski', 'Tom Cruise, Miles Teller', 2022),
('Interstellar', 'Phim khoa học viễn tưởng.', 169, '2014-11-07', '2025-11-14', 'Paramount Pictures', 'Christopher Nolan', 'Matthew McConaughey, Anne Hathaway', 2014);
-- Thêm dữ liệu vào bảng TheLoai
INSERT INTO TheLoai (TenTheLoai, MoTa) VALUES
(N'Hành động', N'Thể loại hành động, phiêu lưu.'),
(N'Siêu anh hùng', N'Thể loại siêu anh hùng, phiêu lưu.'),
(N'Khoa học viễn tưởng', N'Thể loại khoa học viễn tưởng.'),
(N'Hài hước', N'Thể loại hài hước.');

-- Thêm dữ liệu vào bảng ChiTietPhimTL
INSERT INTO ChiTietPhimTL (idPhim, idTheLoai) VALUES
(1, 1), -- Avatar - Hành động
(1, 3), -- Avatar - Khoa học viễn tưởng
(2, 2), -- Avengers: Endgame - Siêu anh hùng
(3, 2), -- Spider-Man: No Way Home - Siêu anh hùng
(4, 1),
(5,1);-- The Batman - Hành động
INSERT INTO LoaiManHinh (TenMH, KichThuoc)
VALUES
('2D', 100),
('3D', 120),
('IMAX', 150);
INSERT INTO PhongChieu (TenPhong, idManHinh, SoGheNgoi, SoHangGhe, SoCotGhe)
VALUES
(N'Phòng 1', 1, 50, 5, 10),
(N'Phòng 2', 2, 100, 10, 10),
(N'Phòng 3', 3, 75, 5, 15);

go
INSERT INTO Voucher (TenVoucher, GiaTriGiam, NgayBatDau, NgayKetThuc)
VALUES
('AVATAR2024', 5000, '2024-01-01', '2024-02-28'),
('SUMMERDISCOUNT', 2000, '2024-06-15', '2024-08-31');
GO

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

	UPDATE LichChieuPhim
    SET TrangThaiChieu = 1
    WHERE id = @idLichChieu;
END
GO


-- Trigger để kiểm tra thời gian chiếu phim không trùng lặp trong cùng phòng chiếu

--Nó kiểm tra ba trường hợp xung đột:
--Phim mới bắt đầu trong khoảng thời gian chiếu của phim hiện tại.
--Phim mới kết thúc trong khoảng thời gian chiếu của phim hiện tại.
--Phim hiện tại bắt đầu trong khoảng thời gian chiếu của phim mới.
CREATE TRIGGER trg_KiemTraTrungLapSuatChieu 
ON LichChieuPhim
INSTEAD OF INSERT
AS
BEGIN
    DECLARE @ThoiGianChieu DATETIME;
    DECLARE @idPhong INT;
    DECLARE @ThoiLuong INT;

    -- Lấy thông tin từ dòng đang được chèn
    SELECT 
        @ThoiGianChieu = ThoiGianChieu,
        @idPhong = idPhong
    FROM inserted;

    -- Lấy thời lượng của phim từ bảng Phim
    --SELECT @ThoiLuong = ThoiLuong FROM Phim WHERE id = (SELECT idPhim FROM inserted);
	 SELECT @ThoiLuong = p.ThoiLuong FROM Phim p
	JOIN inserted i ON p.id = i.idPhim;
    -- Tính toán thời gian kết thúc của lịch chiếu mới
    DECLARE @ThoiGianKetThuc DATETIME = DATEADD(MINUTE, @ThoiLuong, @ThoiGianChieu);

    -- Kiểm tra xung đột với các lịch chiếu khác trong cùng phòng chiếu vào cùng ngày
    IF EXISTS (
        SELECT 1
        FROM LichChieuPhim AS lcp
        JOIN Phim AS p ON lcp.idPhim = p.id
        WHERE lcp.idPhong = @idPhong
          AND CONVERT(DATE, lcp.ThoiGianChieu) = CONVERT(DATE, @ThoiGianChieu) -- Cùng ngày
          AND (
              -- Thời gian bắt đầu hoặc kết thúc của lịch mới nằm trong khoảng thời gian chiếu của lịch hiện tại
              (@ThoiGianChieu BETWEEN lcp.ThoiGianChieu AND DATEADD(MINUTE, p.ThoiLuong, lcp.ThoiGianChieu)) OR
              (@ThoiGianKetThuc BETWEEN lcp.ThoiGianChieu AND DATEADD(MINUTE, p.ThoiLuong, lcp.ThoiGianChieu)) OR
              -- Lịch hiện tại bắt đầu trong khoảng thời gian của lịch mới
              (lcp.ThoiGianChieu BETWEEN @ThoiGianChieu AND @ThoiGianKetThuc)
          )
    )
    BEGIN
        RAISERROR('Thời gian chiếu không hợp lệ. Có sự xung đột với lịch chiếu hiện tại!', 16, 1);
        ROLLBACK TRANSACTION; -- Hủy bỏ transaction nếu có xung đột
    END
    ELSE
    BEGIN
	print @ThoiGianKetThuc
        -- Nếu không có xung đột, cho phép chèn
        INSERT INTO LichChieuPhim (ThoiGianChieu, idPhong, GiaVePhim, idPhim, TrangThaiChieu)
        SELECT ThoiGianChieu, idPhong, GiaVePhim, idPhim, TrangThaiChieu FROM inserted;
    END
END;

--Thêm dữ liệu vào bảng LichChieuPhim để test

INSERT INTO LichChieuPhim (ThoiGianChieu, idPhong, GiaVePhim, idPhim)
VALUES
('2024-10-23 14:00:00', 1, 10000, 1); 
INSERT INTO LichChieuPhim (ThoiGianChieu, idPhong, GiaVePhim, idPhim)
VALUES
('2024-10-23 19:00:00', 1, 15000, 2);
INSERT INTO LichChieuPhim (ThoiGianChieu, idPhong, GiaVePhim, idPhim)
VALUES
('2024-10-23 10:00:00', 2, 12000, 3);
INSERT INTO LichChieuPhim (ThoiGianChieu, idPhong, GiaVePhim, idPhim)
VALUES
('2024-10-24 18:00:00', 1, 12000, 3);
INSERT INTO LichChieuPhim (ThoiGianChieu, idPhong, GiaVePhim, idPhim)
VALUES
('2024-10-24 10:00:00', 1, 15000, (SELECT id FROM Phim WHERE TenPhim = 'Avengers')),
('2024-10-24 14:00:00', 1, 18000, (SELECT id FROM Phim WHERE TenPhim = 'Avengers')),
('2024-10-25 19:00:00', 2, 20000, (SELECT id FROM Phim WHERE TenPhim = 'Avengers')),
('2024-10-25 10:00:00', 3, 22000, (SELECT id FROM Phim WHERE TenPhim = 'Avengers'));
-- Ví dụ thêm lịch chiếu cho phim 'Spider-Man: No Way Home'
INSERT INTO LichChieuPhim (ThoiGianChieu, idPhong, GiaVePhim, idPhim)
VALUES
('2024-11-16 13:00:00', 1, 12000, (SELECT id FROM Phim WHERE TenPhim = 'Spider-Man')),
('2024-11-16 17:00:00', 2, 15000, (SELECT id FROM Phim WHERE TenPhim = 'Spider-Man')),
('2024-11-17 10:00:00', 1, 13000, (SELECT id FROM Phim WHERE TenPhim = 'Spider-Man'));

---- PROC
CREATE PROCEDURE TimPhimTheoNgayVaLoaiDistinct
    @Date DATE,
    @Genre NVARCHAR(100)
AS
BEGIN
    --Kiểm tra nếu ngày không hợp lệ.
    IF @Date IS NULL
    BEGIN
        RAISERROR('Ngày không hợp lệ.', 16, 1)
        RETURN
    END

    --Kiểm tra nếu thể loại không hợp lệ.
    IF @Genre IS NULL
    BEGIN
        RAISERROR('Thể loại không hợp lệ.', 16, 1)
        RETURN
    END
		IF NOT EXISTS (SELECT 1 FROM Phim p JOIN ChiTietPhimTL cpt ON p.id = cpt.idPhim JOIN TheLoai t ON cpt.idTheLoai = t.id WHERE t.TenTheLoai = @Genre AND p.NgayKhoiChieu <= @Date AND p.NgayKetThuc >= @Date)
	BEGIN
		RAISERROR('Không tìm thấy phim nào có thể loại này trong khoảng thời gian này.', 16, 1)
		RETURN
	END

    SELECT
	DISTINCT
        p.id AS PhimId,
        p.TenPhim,
        p.PosterPath,
        p.ThoiLuong,
        p.DaoDien,
		p.MoTa,
		p.NamSX,
		p.DienVien,
		p.NgayKhoiChieu,
		p.NgayKetThuc
    FROM
        Phim p
    JOIN
        ChiTietPhimTL cpt ON p.id = cpt.idPhim
    JOIN
        TheLoai t ON cpt.idTheLoai = t.id
    JOIN
        LichChieuPhim lcp ON p.id = lcp.idPhim 
	WHERE
        t.TenTheLoai = @Genre
		AND p.NgayKhoiChieu <= @Date
		AND p.NgayKetThuc >= @Date
		AND lcp.ThoiGianChieu >= @Date
		AND lcp.ThoiGianChieu < DATEADD(day, 1, @Date)  -- Chắc chắn phim đang chiếu vào ngày đó
	ORDER BY p.TenPhim;
END;
    

--------------------
SET DATEFORMAT dmy; 
CREATE PROCEDURE TimPhimTheoNgayVaLoai
    @Date DATE,
    @Genre NVARCHAR(100)
AS
BEGIN
    --Kiểm tra nếu ngày không hợp lệ.
    IF @Date IS NULL
    BEGIN
        RAISERROR('Ngày không hợp lệ.', 16, 1)
        RETURN
    END

    --Kiểm tra nếu thể loại không hợp lệ.
    IF @Genre IS NULL
    BEGIN
        RAISERROR('Thể loại không hợp lệ.', 16, 1)
        RETURN
    END
		IF NOT EXISTS (SELECT 1 FROM Phim p JOIN ChiTietPhimTL cpt ON p.id = cpt.idPhim JOIN TheLoai t ON cpt.idTheLoai = t.id WHERE t.TenTheLoai = @Genre AND p.NgayKhoiChieu <= @Date AND p.NgayKetThuc >= @Date)
	BEGIN
		RAISERROR('Không tìm thấy phim nào có thể loại này trong khoảng thời gian này.', 16, 1)
		RETURN
	END

    SELECT
	DISTINCT
        p.id AS PhimId,
        p.TenPhim,
        p.PosterPath,
        p.ThoiLuong,
        p.DaoDien,
		p.MoTa,
		p.NamSX,
		p.DienVien,
		p.NgayKhoiChieu,
		p.NgayKetThuc,
		lcp.id as LcpId
    FROM
        Phim p
    JOIN
        ChiTietPhimTL cpt ON p.id = cpt.idPhim
    JOIN
        TheLoai t ON cpt.idTheLoai = t.id
    JOIN
        LichChieuPhim lcp ON p.id = lcp.idPhim 
	WHERE
        t.TenTheLoai = @Genre
		AND p.NgayKhoiChieu <= @Date
		AND p.NgayKetThuc >= @Date
		AND lcp.ThoiGianChieu >= @Date
		AND lcp.ThoiGianChieu < DATEADD(day, 1, @Date)  -- Chắc chắn phim đang chiếu vào ngày đó
	ORDER BY p.TenPhim;
END;

go

EXEC TimPhimTheoNgayVaLoaiDistinct @date= '2024-10-17', @Genre = N'Siêu anh hùng';
select * from phim
select* from theloai
select * from LichChieuPhim
go



-------------------------------------------------------

CREATE PROCEDURE LayLichChieuCuaPhimTrongNgay
    @MovieId INT,
    @Date DATE
AS
BEGIN
    -- Kiểm tra nếu ngày không hợp lệ
    IF @Date IS NULL
    BEGIN
        RAISERROR('Ngày không hợp lệ.', 16, 1);
        RETURN;
    END

    -- Kiểm tra nếu ID phim không hợp lệ
	IF NOT EXISTS (SELECT 1 FROM Phim WHERE id = @MovieId)
    BEGIN
        RAISERROR('ID phim không hợp lệ.', 16, 1);
        RETURN;
    END

    SELECT
		 CONVERT(VARCHAR(5), LCP.ThoiGianChieu, 108) AS GioChieu, 
		CONVERT(VARCHAR(5), DATEADD(MINUTE, P.ThoiLuong, LCP.ThoiGianChieu), 108) AS GioKetThuc,  
		LCP.idPhong,
        LCP.id as idLCP,
		PC.TenPhong,
		PC.SoGheNgoi,
		PC.SoGheNgoi - ISNULL((SELECT COUNT(*) FROM VePhim WHERE idLichChieuPhim = LCP.id AND TrangThaiVePhim = 1), 0) AS SoGheConTrong

    FROM
        LichChieuPhim LCP
	JOIN 
		PhongChieu PC ON PC.id=idPhong
	JOIN
		Phim P ON P.id = LCP.idPhim 
    WHERE
        idPhim = @MovieId
		AND ThoiGianChieu >= @Date
		AND ThoiGianChieu < DATEADD(day, 1, @Date);
END;

select * from LichChieuPhim
EXEC LayLichChieuCuaPhimTrongNgay @MovieId= '3',  @date= '2024-10-23';
----------------------


CREATE PROCEDURE TimPhimTheoNgayVaLoai2
    @Date DATE,
    @Genre NVARCHAR(100)
AS
BEGIN
    -- Kiểm tra nếu ngày không hợp lệ
    IF @Date IS NULL
    BEGIN
        RAISERROR('Ngày không hợp lệ.', 16, 1)
        RETURN
    END

    -- Kiểm tra nếu thể loại không hợp lệ
    IF @Genre IS NULL
    BEGIN
        RAISERROR('Thể loại không hợp lệ.', 16, 1)
        RETURN
    END

    -- Kiểm tra nếu không có phim nào phù hợp với thể loại và ngày
    IF NOT EXISTS (
        SELECT 1
        FROM Phim p
        JOIN ChiTietPhimTL cpt ON p.id = cpt.idPhim
        JOIN TheLoai t ON cpt.idTheLoai = t.id
        WHERE t.TenTheLoai = @Genre
        AND p.NgayKhoiChieu <= @Date
        AND p.NgayKetThuc >= @Date
    )
    BEGIN
        RAISERROR('Không tìm thấy phim nào có thể loại này trong khoảng thời gian này.', 16, 1)
        RETURN
    END

    -- Truy vấn danh sách phim và lịch chiếu chi tiết
    SELECT
        p.id AS PhimId,
        p.TenPhim,
        p.PosterPath,
        p.ThoiLuong,
        p.DaoDien,
        p.MoTa,
        p.NamSX,
        p.DienVien,
        p.NgayKhoiChieu,
        p.NgayKetThuc,
        lcp.ThoiGianChieu,
        pc.TenPhong,
        lcp.GiaVePhim,
        (pc.SoGheNgoi - COUNT(vp.id)) AS SoGheConLai  -- Số ghế còn trống
    FROM
        Phim p
    JOIN
        ChiTietPhimTL cpt ON p.id = cpt.idPhim
    JOIN
        TheLoai t ON cpt.idTheLoai = t.id
    JOIN
        LichChieuPhim lcp ON p.id = lcp.idPhim
    JOIN
        PhongChieu pc ON lcp.idPhong = pc.id
    LEFT JOIN
        VePhim vp ON lcp.id = vp.idLichChieuPhim AND vp.TrangThaiVePhim = 1  -- Chỉ tính vé đã bán
    WHERE
        t.TenTheLoai = @Genre
        AND p.NgayKhoiChieu <= @Date
        AND p.NgayKetThuc >= @Date
        AND lcp.ThoiGianChieu >= @Date
        AND lcp.ThoiGianChieu < DATEADD(day, 1, @Date)  -- Phim chiếu trong ngày đã chọn
    GROUP BY
        p.id, p.TenPhim, p.PosterPath, p.ThoiLuong, p.DaoDien, p.MoTa, p.NamSX, p.DienVien,
        p.NgayKhoiChieu, p.NgayKetThuc, lcp.ThoiGianChieu, pc.TenPhong, lcp.GiaVePhim, pc.SoGheNgoi
    ORDER BY
        p.TenPhim, lcp.ThoiGianChieu;
END;


EXEC TimPhimTheoNgayVaLoai2 @Date = '2024-01-09', @Genre = 'Hành động';
-- -------------------------

drop proc LayThongTinChiTietLichChieu
CREATE PROCEDURE LayThongTinChiTietLichChieu
    @idLichChieuPhim INT  -- ID lịch chiếu phim mà người dùng chọn
AS
BEGIN
    -- Lấy thông tin chi tiết lịch chiếu phim
    SELECT 
        pc.id as idPhong,  -- Tên phòng chiếu
        lcp.GiaVePhim,  -- Giá vé
		lcp.ThoiGianChieu,
        (pc.SoGheNgoi - COUNT(vp.id)) AS SoGheConLai  -- Số ghế còn lại
    FROM 
        LichChieuPhim lcp
    INNER JOIN 
        PhongChieu pc ON lcp.idPhong = pc.id
    LEFT JOIN 
        VePhim vp ON lcp.id = vp.idLichChieuPhim AND vp.TrangThaiVePhim = 1  -- Chỉ tính những vé đã bán
    WHERE 
        lcp.id = @idLichChieuPhim  -- Lọc theo ID lịch chiếu phim
    GROUP BY 
        pc.id, lcp.GiaVePhim, lcp.ThoiGianChieu, pc.SoGheNgoi;
END;



--- -------------------------------------
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


    UPDATE VePhim 
    SET TrangThaiVePhim = 1, idKhachHang = 2 
    OUTPUT INSERTED.id 
    WHERE id = 42 AND idLichChieuPhim = 12;





-------------------------------------------- END PROC -----------------------------------------------------




--------------------------------------------START TRIGGER ------------------------------------------------------------

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
