USE [QLST]
GO
/****** Object:  UserDefinedFunction [dbo].[func_SLHD_Ban]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--SLHD BAN
create function [dbo].[func_SLHD_Ban]
(
	@Ngay datetime,
	@TieuChi nvarchar(5)
)
returns int 
as
BEGIN
declare @SLHD_Ban int = 0
	if @TieuChi = N'Ngày'
		SET @SLHD_Ban = (SELECT COUNT(MaHD) FROM HoaDonBanHang WHERE Day(NgayLapHD) = DAY(@Ngay) 
											AND MONTH(NgayLapHD) = MONTH(@Ngay) 
											AND YEAR(NgayLapHD) = YEAR(@Ngay))
	else if @TieuChi = N'Tuần'
		BEGIN
			SET @SLHD_Ban = (SELECT COUNT(MaHD) FROM HoaDonBanHang WHERE DATEPART(WW, @Ngay) = DATEPART(WW, NgayLapHD) AND YEAR(NgayLapHD) = YEAR(@Ngay))							
		END
	else if @TieuChi = N'Tháng'
		SET @SLHD_Ban = (SELECT COUNT(MaHD) FROM HoaDonBanHang WHERE MONTH(NgayLapHD) = MONTH(@Ngay) AND YEAR(NgayLapHD) = YEAR(@Ngay))
	else if @TieuChi = N'Quý'
		BEGIN
			SET @SLHD_Ban = (SELECT COUNT(MaHD) FROM HoaDonBanHang WHERE DATEPART(QQ, @Ngay) = DATEPART(QQ, NgayLapHD) AND YEAR(NgayLapHD) = YEAR(@Ngay))
		END
	else if @TieuChi = N'Năm'
	BEGIN
		SET @SLHD_Ban = (SELECT COUNT(MaHD) FROM HoaDonBanHang WHERE YEAR(NgayLapHD) = YEAR(@Ngay))
	END
	return @SLHD_Ban
END
GO
/****** Object:  UserDefinedFunction [dbo].[func_SLHD_Nhap]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--SLHD Nhap
create function [dbo].[func_SLHD_Nhap]
(
	@Ngay datetime,
	@TieuChi nvarchar(5)
)
returns int 
as
BEGIN
declare @SLHD_Nhap int = 0
	if @TieuChi = N'Ngày'
		SET @SLHD_Nhap = (SELECT COUNT(MaNK) FROM HoaDonNhapKho WHERE Day(NgayNhapKho) = DAY(@Ngay) 
											AND MONTH(NgayNhapKho) = MONTH(@Ngay) 
											AND YEAR(NgayNhapKho) = YEAR(@Ngay))
	else if @TieuChi = N'Tuần'
		BEGIN
			SET @SLHD_Nhap = (SELECT COUNT(MaNK) FROM HoaDonNhapKho WHERE DATEPART(WW, @Ngay) = DATEPART(WW, NgayNhapKho) AND YEAR(NgayNhapKho) = YEAR(@Ngay))							
		END
	else if @TieuChi = N'Tháng'
		SET @SLHD_Nhap = (SELECT COUNT(MaNK) FROM HoaDonNhapKho WHERE MONTH(NgayNhapKho) = MONTH(@Ngay) AND YEAR(NgayNhapKho) = YEAR(@Ngay))
	else if @TieuChi = N'Quý'
		BEGIN
			SET @SLHD_Nhap = (SELECT COUNT(MaNK) FROM HoaDonNhapKho WHERE DATEPART(QQ, @Ngay) = DATEPART(QQ, NgayNhapKho) AND YEAR(NgayNhapKho) = YEAR(@Ngay))
		END
	else if @TieuChi = N'Năm'
	BEGIN
		SET @SLHD_Nhap = (SELECT COUNT(MaNK) FROM HoaDonNhapKho WHERE YEAR(NgayNhapKho) = YEAR(@Ngay))
	END
	return @SLHD_Nhap
END
GO
/****** Object:  UserDefinedFunction [dbo].[func_SLKM]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--SLKM
create function [dbo].[func_SLKM]
(
	@Ngay datetime,
	@TieuChi nvarchar(5)
)
returns int 
as
BEGIN
declare @SLKM int = 0
	if @TieuChi = N'Ngày'
		SET @SLKM = (SELECT COUNT(MaKM) FROM KhuyenMai WHERE @Ngay BETWEEN NgayBatDau AND NgayKetThuc)
	else if @TieuChi = N'Tuần'
		BEGIN
			SET @SLKM = (SELECT COUNT(MaKM) FROM KhuyenMai WHERE DATEPART(WW, @Ngay) BETWEEN DATEPART(WW, NgayBatDau) AND DATEPART(WW, NgayKetThuc))							
		END
	else if @TieuChi = N'Tháng'
		SET @SLKM = (SELECT COUNT(MaKM) FROM KhuyenMai WHERE MONTH(@Ngay) BETWEEN MONTH(NgayBatDau) AND MONTH(NgayKetThuc))
	else if @TieuChi = N'Quý'
		BEGIN
			SET @SLKM = (SELECT COUNT(MaKM) FROM KhuyenMai WHERE DATEPART(QQ, @Ngay) BETWEEN DATEPART(QQ, NgayBatDau) AND DATEPART(QQ, NgayKetThuc))
		END
	else if @TieuChi = N'Năm'
	BEGIN
		SET @SLKM = (SELECT COUNT(MaKM) FROM KhuyenMai WHERE YEAR(@Ngay) BETWEEN YEAR(NgayBatDau) AND YEAR(NgayKetThuc))
	END
	return @SLKM
END
GO
/****** Object:  UserDefinedFunction [dbo].[func_SLNCC]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--SL_NCC
create function [dbo].[func_SLNCC]
(
	@Ngay datetime,
	@TieuChi nvarchar(5)
)
returns int 
as
BEGIN
declare @SLNCC int = 0
	if @TieuChi = N'Ngày'
		SET @SLNCC = (SELECT DISTINCT COUNT(MaNCC) FROM HoaDonNhapKho WHERE Day(NgayNhapKho) = DAY(@Ngay) 
																	AND MONTH(NgayNhapKho) = MONTH(@Ngay) 
																	AND YEAR(NgayNhapKho) = YEAR(@Ngay))
	else if @TieuChi = N'Tuần'
		BEGIN
			SET @SLNCC = (SELECT DISTINCT COUNT(MaNCC) FROM HoaDonNhapKho 
							WHERE DATEPART(WW, @Ngay) = DATEPART(WW, NgayNhapKho) AND YEAR(NgayNhapKho) = YEAR(@Ngay))							
		END
	else if @TieuChi = N'Tháng'
		SET @SLNCC = (SELECT DISTINCT COUNT(MaNCC) FROM HoaDonNhapKho 
						WHERE MONTH(NgayNhapKho) = MONTH(@Ngay) AND YEAR(NgayNhapKho) = YEAR(@Ngay))
	else if @TieuChi = N'Quý'
		BEGIN
			SET @SLNCC = (SELECT DISTINCT COUNT(MaNCC) FROM HoaDonNhapKho 
							WHERE DATEPART(QQ, @Ngay) = DATEPART(QQ, NgayNhapKho) AND YEAR(NgayNhapKho) = YEAR(@Ngay))
		END
	else if @TieuChi = N'Năm'
	BEGIN
		SET @SLNCC = (SELECT DISTINCT COUNT(MaNCC) FROM HoaDonNhapKho 
						WHERE YEAR(NgayNhapKho) = YEAR(@Ngay))
	END
	return @SLNCC
END
GO
/****** Object:  UserDefinedFunction [dbo].[func_SLNV]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--SL_NV
create function [dbo].[func_SLNV]
(
	@Ngay datetime,
	@TieuChi nvarchar(5)
)
returns int 
as
BEGIN
declare @SLNV int = 0
	if @TieuChi = N'Ngày'
		SET @SLNV = (SELECT DISTINCT COUNT(MaNV) FROM HoaDonBanHang	WHERE Day(NgayLapHD) = DAY(@Ngay) 
															AND MONTH(NgayLapHD) = MONTH(@Ngay) 
															AND YEAR(NgayLapHD) = YEAR(@Ngay))
	else if @TieuChi = N'Tuần'
		BEGIN
			SET @SLNV = (SELECT DISTINCT COUNT(MaNV) FROM HoaDonBanHang
							WHERE DATEPART(WW, @Ngay) = DATEPART(WW, NgayLapHD) AND YEAR(NgayLapHD) = YEAR(@Ngay))							
		END
	else if @TieuChi = N'Tháng'
		SET @SLNV = (SELECT DISTINCT COUNT(MaNV) FROM HoaDonBanHang
						WHERE MONTH(NgayLapHD) = MONTH(@Ngay) AND YEAR(NgayLapHD) = YEAR(@Ngay))
	else if @TieuChi = N'Quý'
		BEGIN
			SET @SLNV = (SELECT DISTINCT COUNT(MaNV) FROM HoaDonBanHang
							WHERE DATEPART(QQ, @Ngay) = DATEPART(QQ, NgayLapHD) AND YEAR(NgayLapHD) = YEAR(@Ngay))
		END
	else if @TieuChi = N'Năm'
	BEGIN
		SET @SLNV = (SELECT DISTINCT COUNT(MaNV) FROM HoaDonBanHang
						WHERE YEAR(NgayLapHD) = YEAR(@Ngay))
	END
	return @SLNV
END
GO
/****** Object:  UserDefinedFunction [dbo].[func_SLSP_Ban]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--SLHD Ban
create function [dbo].[func_SLSP_Ban]
(
	@Ngay datetime,
	@TieuChi nvarchar(5)
)
returns int 
as
BEGIN
declare @SLSP_Ban int = 0
	if @TieuChi = N'Ngày'
		SET @SLSP_Ban = (SELECT Sum(SoLuong) FROM ChiTietHoaDonBanHang CT JOIN HoaDonBanHang HD ON  CT.MaHD = HD.MaHD
						WHERE Day(NgayLapHD) = DAY(@Ngay) 
							AND MONTH(NgayLapHD) = MONTH(@Ngay) 
							AND YEAR(NgayLapHD) = YEAR(@Ngay)
						)
	else if @TieuChi = N'Tuần'
		BEGIN
			SET @SLSP_Ban = (SELECT Sum(SoLuong) FROM ChiTietHoaDonBanHang CT JOIN HoaDonBanHang HD ON  CT.MaHD = HD.MaHD
							WHERE DATEPART(WW, @Ngay) = DATEPART(WW, NgayLapHD) AND YEAR(NgayLapHD) = YEAR(@Ngay))							
		END
	else if @TieuChi = N'Tháng'
		SET @SLSP_Ban = (SELECT Sum(SoLuong) FROM ChiTietHoaDonBanHang CT JOIN HoaDonBanHang HD ON  CT.MaHD = HD.MaHD 
						WHERE MONTH(NgayLapHD) = MONTH(@Ngay) AND YEAR(NgayLapHD) = YEAR(@Ngay))
	else if @TieuChi = N'Quý'
		BEGIN
			SET @SLSP_Ban = (SELECT Sum(SoLuong) FROM ChiTietHoaDonBanHang CT JOIN HoaDonBanHang HD ON  CT.MaHD = HD.MaHD
							WHERE DATEPART(QQ, @Ngay) = DATEPART(QQ, NgayLapHD) AND YEAR(NgayLapHD) = YEAR(@Ngay))
		END
	else if @TieuChi = N'Năm'
	BEGIN
		SET @SLSP_Ban = (SELECT Sum(SoLuong) FROM ChiTietHoaDonBanHang CT JOIN HoaDonBanHang HD ON  CT.MaHD = HD.MaHD
						WHERE YEAR(NgayLapHD) = YEAR(@Ngay))
	END
	return @SLSP_Ban
END
GO
/****** Object:  UserDefinedFunction [dbo].[func_SLSP_Nhap]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--SLSP_Nhap
create function [dbo].[func_SLSP_Nhap]
(
	@Ngay datetime,
	@TieuChi nvarchar(5)
)
returns int 
as
BEGIN
declare @SLSP_Nhap int = 0
	if @TieuChi = N'Ngày'
		SET @SLSP_Nhap = (SELECT Sum(SoLuong) FROM ChiTietHoaDonNhapKho CT JOIN HoaDonNhapKho NK ON  CT.MaNK = NK.MaNK
						WHERE Day(NgayNhapKho) = DAY(@Ngay) 
							AND MONTH(NgayNhapKho) = MONTH(@Ngay) 
							AND YEAR(NgayNhapKho) = YEAR(@Ngay)
						)
	else if @TieuChi = N'Tuần'
		BEGIN
			SET @SLSP_Nhap = (SELECT Sum(SoLuong) FROM ChiTietHoaDonNhapKho CT JOIN HoaDonNhapKho NK ON  CT.MaNK = NK.MaNK
							WHERE DATEPART(WW, @Ngay) = DATEPART(WW, NgayNhapKho) AND YEAR(NgayNhapKho) = YEAR(@Ngay))							
		END
	else if @TieuChi = N'Tháng'
		SET @SLSP_Nhap = (SELECT Sum(SoLuong) FROM ChiTietHoaDonNhapKho CT JOIN HoaDonNhapKho NK ON  CT.MaNK = NK.MaNK
						WHERE MONTH(NgayNhapKho) = MONTH(@Ngay) AND YEAR(NgayNhapKho) = YEAR(@Ngay))
	else if @TieuChi = N'Quý'
		BEGIN
			SET @SLSP_Nhap = (SELECT Sum(SoLuong) FROM ChiTietHoaDonNhapKho CT JOIN HoaDonNhapKho NK ON  CT.MaNK = NK.MaNK
							WHERE DATEPART(QQ, @Ngay) = DATEPART(QQ, NgayNhapKho) AND YEAR(NgayNhapKho) = YEAR(@Ngay))
		END
	else if @TieuChi = N'Năm'
	BEGIN
		SET @SLSP_Nhap = (SELECT Sum(SoLuong) FROM ChiTietHoaDonNhapKho CT JOIN HoaDonNhapKho NK ON  CT.MaNK = NK.MaNK
						WHERE YEAR(NgayNhapKho) = YEAR(@Ngay))
	END
	return @SLSP_Nhap
END
GO
/****** Object:  UserDefinedFunction [dbo].[func_TienBanSP]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--=================================================
create function [dbo].[func_TienBanSP]
(
	@Ngay datetime,
	@TieuChi nvarchar(5)
)
returns decimal 
as
BEGIN
declare @TienBanSP decimal = 0
	if @TieuChi = N'Ngày'
		SET @TienBanSP = (SELECT SUM(TongTien) FROM HoaDonBanHang WHERE Day(NgayLapHD) = DAY(@Ngay) 
											AND MONTH(NgayLapHD) = MONTH(@Ngay) 
											AND YEAR(NgayLapHD) = YEAR(@Ngay))
	else if @TieuChi = N'Tuần'
		BEGIN
			SET @TienBanSP = (SELECT SUM(TongTien) FROM HoaDonBanHang WHERE DATEPART(WW, @Ngay) = DATEPART(WW, NgayLapHD) AND YEAR(NgayLapHD) = YEAR(@Ngay))
		END
	else if @TieuChi = N'Tháng'
		SET @TienBanSP = (SELECT SUM(TongTien) FROM HoaDonBanHang WHERE MONTH(NgayLapHD) = MONTH(@Ngay) AND YEAR(NgayLapHD) = YEAR(@Ngay))
	else if @TieuChi = N'Quý'
		BEGIN
			SET @TienBanSP = (SELECT SUM(TongTien) FROM HoaDonBanHang WHERE DATEPART(QQ, @Ngay) = DATEPART(QQ, NgayLapHD) AND YEAR(NgayLapHD) = YEAR(@Ngay))
		END
	else if @TieuChi = N'Năm'
		BEGIN
			SET @TienBanSP = (SELECT SUM(TongTien) FROM HoaDonBanHang WHERE YEAR(NgayLapHD) = YEAR(@Ngay))						
		END
	return @TienBanSP
END;
GO
/****** Object:  UserDefinedFunction [dbo].[func_TienNhapSP]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create function [dbo].[func_TienNhapSP]
(
	@Ngay datetime,
	@TieuChi nvarchar(5)
)
returns decimal 
as
BEGIN
declare @TienNhapSP decimal = 0
	if @TieuChi = N'Ngày'
		SET @TienNhapSP = (SELECT SUM(TongTien) FROM HoaDonNhapKho WHERE Day(NgayNhapKho) = DAY(@Ngay) 
													AND MONTH(NgayNhapKho) = MONTH(@Ngay) 
													AND YEAR(NgayNhapKho) = YEAR(@Ngay))
	else if @TieuChi = N'Tuần'
		BEGIN
			SET @TienNhapSP = (SELECT SUM(TongTien) FROM HoaDonNhapKho WHERE DATEPART(WW, @Ngay) = DATEPART(WW, NgayNhapKho) AND YEAR(NgayNhapKho) = YEAR(@Ngay))
		END
	else if @TieuChi = N'Tháng'
		SET @TienNhapSP = (SELECT SUM(TongTien) FROM HoaDonNhapKho WHERE MONTH(NgayNhapKho) = MONTH(@Ngay) AND YEAR(NgayNhapKho) = YEAR(@Ngay))
	else if @TieuChi = N'Quý'
		BEGIN
			SET @TienNhapSP = (SELECT SUM(TongTien) FROM HoaDonNhapKho WHERE DATEPART(QQ, @Ngay) = DATEPART(QQ, NgayNhapKho) AND YEAR(NgayNhapKho) = YEAR(@Ngay))
		END
	else if @TieuChi = N'Năm'
		BEGIN
			SET @TienNhapSP = (SELECT SUM(TongTien) FROM HoaDonNhapKho WHERE YEAR(NgayNhapKho) = YEAR(@Ngay))
		END
	return @TienNhapSP
END
GO
/****** Object:  UserDefinedFunction [dbo].[GenerateMaHD]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[GenerateMaHD]()
RETURNS VARCHAR(10)
AS
BEGIN
    DECLARE @NextID INT;
    DECLARE @NewMaHD VARCHAR(10);

    -- Tìm số thứ tự tiếp theo
    SELECT @NextID = COALESCE(MAX(CAST(RIGHT(MaHD, 3) AS INT)), 1) + 1 FROM HoaDonBanHang;

    -- Tạo mã mới
    SET @NewMaHD = 'HD' + RIGHT('000' + CAST(@NextID AS VARCHAR(3)), 3);

    RETURN @NewMaHD;
END;
GO
/****** Object:  UserDefinedFunction [dbo].[GenerateMaKH]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GenerateMaKH]()
RETURNS VARCHAR(10)
AS
BEGIN
    DECLARE @NextID INT;
    DECLARE @NewMaKH VARCHAR(10);

    -- Tìm số thứ tự tiếp theo
    SELECT @NextID = COALESCE(MAX(CAST(RIGHT(MaKH, 5) AS INT)), 1) + 1 FROM KhachHang;

    -- Tạo mã mới
    SET @NewMaKH = RIGHT('00000' + CAST(@NextID AS VARCHAR(5)), 5);

    RETURN @NewMaKH;
END;
GO
/****** Object:  UserDefinedFunction [dbo].[GenerateMaLSP]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[GenerateMaLSP]()
RETURNS VARCHAR(10)
AS
BEGIN
    DECLARE @NextID INT;
    DECLARE @NewMaLSP VARCHAR(10);

    -- Tìm số thứ tự tiếp theo
    SELECT @NextID = COALESCE(MAX(CAST(RIGHT(MaLoaiSP, 3) AS INT)), 1) + 1 FROM LoaiSanPham;

    -- Tạo mã mới
    SET @NewMaLSP = 'LSP' + RIGHT('000' + CAST(@NextID AS VARCHAR(3)), 3);

    RETURN @NewMaLSP;
END;
GO
/****** Object:  UserDefinedFunction [dbo].[GenerateMaNCC]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[GenerateMaNCC]()
RETURNS VARCHAR(10)
AS
BEGIN
    DECLARE @NextID INT;
    DECLARE @NewMaNCC VARCHAR(10);

    -- Tìm số thứ tự tiếp theo
    SELECT @NextID = COALESCE(MAX(CAST(RIGHT(MaNCC, 3) AS INT)), 1) + 1 FROM NhaCungCap;

    -- Tạo mã mới
    SET @NewMaNCC = 'NCC' + RIGHT('000' + CAST(@NextID AS VARCHAR(3)), 3);

    RETURN @NewMaNCC;
END;
GO
/****** Object:  UserDefinedFunction [dbo].[GenerateMaNK]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[GenerateMaNK]()
RETURNS VARCHAR(10)
AS
BEGIN
    DECLARE @NextID INT;
    DECLARE @NewMaNK VARCHAR(10);

    -- Tìm số thứ tự tiếp theo
    SELECT @NextID = COALESCE(MAX(CAST(RIGHT(MaNK, 3) AS INT)), 1) + 1 FROM HoaDonNhapKho;

    -- Tạo mã mới
    SET @NewMaNK = 'NK' + RIGHT('000' + CAST(@NextID AS VARCHAR(3)), 3);

    RETURN @NewMaNK;
END;

GO
/****** Object:  UserDefinedFunction [dbo].[GenerateMaNV]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GenerateMaNV]()
RETURNS VARCHAR(10)
AS
BEGIN
    DECLARE @NextID INT;
    DECLARE @NewMaNV VARCHAR(10);

    -- Tìm số thứ tự tiếp theo
    SELECT @NextID = COALESCE(MAX(CAST(RIGHT(MaNV, 3) AS INT)), 1) + 1 FROM NhanVien;

    -- Tạo mã mới
    SET @NewMaNV = 'NV' + RIGHT('000' + CAST(@NextID AS VARCHAR(3)), 3);

    RETURN @NewMaNV;
END;
GO
/****** Object:  UserDefinedFunction [dbo].[GenerateMaSP]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[GenerateMaSP]()
RETURNS VARCHAR(10)
AS
BEGIN
    DECLARE @NextID INT;
    DECLARE @NewMaSP VARCHAR(10);

    -- Tìm số thứ tự tiếp theo
    SELECT @NextID = COALESCE(MAX(CAST(RIGHT(MaSP, 3) AS INT)), 1) + 1 FROM SanPham;

    -- Tạo mã mới
    SET @NewMaSP = 'SP' + RIGHT('000' + CAST(@NextID AS VARCHAR(3)), 3);

    RETURN @NewMaSP;
END;
GO
/****** Object:  Table [dbo].[ChiTietHoaDonBanHang]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDonBanHang](
	[MaHD] [varchar](10) NOT NULL,
	[MaSP] [varchar](20) NOT NULL,
	[MaKM] [varchar](10) NULL,
	[SoLuong] [int] NULL,
	[DonGia] [decimal](18, 0) NULL,
	[ThanhTien] [decimal](18, 0) NULL,
 CONSTRAINT [PK_CTHDBH] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietHoaDonNhapKho]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDonNhapKho](
	[MaNK] [varchar](20) NOT NULL,
	[MaSP] [varchar](20) NOT NULL,
	[NgayHetHan] [date] NULL,
	[SoLuong] [int] NULL,
	[DonGiaNhap] [decimal](18, 0) NULL,
	[ThanhTien] [decimal](18, 0) NULL,
	[TrangThai] [bit] NULL,
	[SoLuongDaBan] [int] NULL,
 CONSTRAINT [PK_CTHDNK] PRIMARY KEY CLUSTERED 
(
	[MaNK] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucVu](
	[MaChucVu] [varchar](5) NOT NULL,
	[TenChucVu] [nvarchar](255) NULL,
	[TrangThai] [bit] NULL,
 CONSTRAINT [PK_ChucVu] PRIMARY KEY CLUSTERED 
(
	[MaChucVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDonBanHang]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDonBanHang](
	[MaHD] [varchar](10) NOT NULL,
	[MaNV] [varchar](10) NOT NULL,
	[MaKH] [varchar](10) NULL,
	[NgayLapHD] [datetime] NULL,
	[TongTien] [decimal](18, 0) NULL,
	[TienKhachDua] [decimal](18, 0) NULL,
	[TienTraKhach] [decimal](18, 0) NULL,
 CONSTRAINT [PK_HDBH] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDonNhapKho]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDonNhapKho](
	[MaNK] [varchar](20) NOT NULL,
	[MaNV] [varchar](10) NOT NULL,
	[MaNCC] [varchar](20) NOT NULL,
	[NgayNhapKho] [datetime] NULL,
	[TongTien] [decimal](18, 0) NULL,
 CONSTRAINT [PK_HDNK] PRIMARY KEY CLUSTERED 
(
	[MaNK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [varchar](10) NOT NULL,
	[HoTen] [nvarchar](255) NULL,
	[CCCD] [varchar](12) NULL,
	[SDT] [varchar](12) NULL,
	[GioiTinh] [nvarchar](3) NULL,
	[DiaChi] [nvarchar](255) NULL,
	[NgayDangKy] [date] NULL,
	[TrangThai] [bit] NULL,
 CONSTRAINT [PK_KH] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhuyenMai]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhuyenMai](
	[MaKM] [varchar](10) NOT NULL,
	[TenKM] [nvarchar](255) NULL,
	[GiaKhuyenMai] [float] NULL,
	[NgayBatDau] [date] NULL,
	[NgayKetThuc] [date] NULL,
 CONSTRAINT [PK_KM] PRIMARY KEY CLUSTERED 
(
	[MaKM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiSanPham]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiSanPham](
	[MaLoaiSP] [varchar](10) NOT NULL,
	[TenLoai] [nvarchar](100) NULL,
	[MoTa] [nvarchar](255) NULL,
 CONSTRAINT [PK_LoaiSP] PRIMARY KEY CLUSTERED 
(
	[MaLoaiSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNCC] [varchar](20) NOT NULL,
	[TenNCC] [nvarchar](255) NULL,
	[SDT] [varchar](12) NULL,
	[DiaChi] [nvarchar](255) NULL,
	[TrangThai] [bit] NULL,
 CONSTRAINT [PK_NCC] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [varchar](10) NOT NULL,
	[CCCD] [varchar](12) NULL,
	[HoTen] [nvarchar](255) NULL,
	[GioiTinh] [nvarchar](3) NULL,
	[DiaChi] [nvarchar](255) NULL,
	[SDT] [varchar](12) NULL,
	[NgayTao] [date] NULL,
	[MaChucVu] [varchar](5) NULL,
	[TrangThai] [bit] NULL,
 CONSTRAINT [PK_NV] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSP] [varchar](20) NOT NULL,
	[TenSP] [nvarchar](50) NULL,
	[MaNCC] [varchar](20) NOT NULL,
	[MaLoaiSP] [varchar](10) NULL,
	[GiaNhap] [decimal](18, 0) NULL,
	[GiaBan] [decimal](18, 0) NULL,
	[SoLuong] [int] NULL,
	[HanSuDung] [varchar](5) NULL,
	[DonViTinh] [nvarchar](20) NULL,
	[HinhAnh] [varchar](255) NULL,
	[TrangThai] [bit] NULL,
 CONSTRAINT [PK_SP] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[MaNV] [varchar](10) NOT NULL,
	[MatKhau] [varchar](255) NULL,
	[MaChucVu] [varchar](5) NULL,
	[TrangThai] [bit] NULL,
 CONSTRAINT [PK_TK] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[HoaDonBanHang] ADD  CONSTRAINT [DF_HDBanHang_MaHD]  DEFAULT ([dbo].[GenerateMaHD]()) FOR [MaHD]
GO
ALTER TABLE [dbo].[HoaDonNhapKho] ADD  CONSTRAINT [DF_HDNhapKho_MaNK]  DEFAULT ([dbo].[GenerateMaNK]()) FOR [MaNK]
GO
ALTER TABLE [dbo].[KhachHang] ADD  CONSTRAINT [DF_KH_MAKH]  DEFAULT ([dbo].[GenerateMaKH]()) FOR [MaKH]
GO
ALTER TABLE [dbo].[LoaiSanPham] ADD  CONSTRAINT [DF_LSP_MaLoaiSP]  DEFAULT ([dbo].[GenerateMaLSP]()) FOR [MaLoaiSP]
GO
ALTER TABLE [dbo].[NhaCungCap] ADD  CONSTRAINT [DF_NCC_MANCC]  DEFAULT ([dbo].[GenerateMaNCC]()) FOR [MaNCC]
GO
ALTER TABLE [dbo].[NhanVien] ADD  CONSTRAINT [DF_TK_MANV]  DEFAULT ([dbo].[GenerateMaNV]()) FOR [MaNV]
GO
ALTER TABLE [dbo].[SanPham] ADD  CONSTRAINT [DF_SP_MaSP]  DEFAULT ([dbo].[GenerateMaSP]()) FOR [MaSP]
GO
ALTER TABLE [dbo].[TaiKhoan] ADD  DEFAULT ('NV') FOR [MaChucVu]
GO
ALTER TABLE [dbo].[ChiTietHoaDonBanHang]  WITH CHECK ADD  CONSTRAINT [FK_CTHDBH_HD] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDonBanHang] ([MaHD])
GO
ALTER TABLE [dbo].[ChiTietHoaDonBanHang] CHECK CONSTRAINT [FK_CTHDBH_HD]
GO
ALTER TABLE [dbo].[ChiTietHoaDonBanHang]  WITH CHECK ADD  CONSTRAINT [FK_CTHDBH_KM] FOREIGN KEY([MaKM])
REFERENCES [dbo].[KhuyenMai] ([MaKM])
GO
ALTER TABLE [dbo].[ChiTietHoaDonBanHang] CHECK CONSTRAINT [FK_CTHDBH_KM]
GO
ALTER TABLE [dbo].[ChiTietHoaDonBanHang]  WITH CHECK ADD  CONSTRAINT [FK_CTHDBH_SP] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[ChiTietHoaDonBanHang] CHECK CONSTRAINT [FK_CTHDBH_SP]
GO
ALTER TABLE [dbo].[ChiTietHoaDonNhapKho]  WITH CHECK ADD  CONSTRAINT [FK_CTHDNK_SP] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[ChiTietHoaDonNhapKho] CHECK CONSTRAINT [FK_CTHDNK_SP]
GO
ALTER TABLE [dbo].[HoaDonBanHang]  WITH CHECK ADD  CONSTRAINT [FK_HDBH_KH] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[HoaDonBanHang] CHECK CONSTRAINT [FK_HDBH_KH]
GO
ALTER TABLE [dbo].[HoaDonBanHang]  WITH CHECK ADD  CONSTRAINT [FK_HDBH_NV] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HoaDonBanHang] CHECK CONSTRAINT [FK_HDBH_NV]
GO
ALTER TABLE [dbo].[HoaDonNhapKho]  WITH CHECK ADD  CONSTRAINT [FK_HDNK_NCC] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[HoaDonNhapKho] CHECK CONSTRAINT [FK_HDNK_NCC]
GO
ALTER TABLE [dbo].[HoaDonNhapKho]  WITH CHECK ADD  CONSTRAINT [FK_HDNK_NV] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HoaDonNhapKho] CHECK CONSTRAINT [FK_HDNK_NV]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NV_CV] FOREIGN KEY([MaChucVu])
REFERENCES [dbo].[ChucVu] ([MaChucVu])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NV_CV]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SP_LoaiSP] FOREIGN KEY([MaLoaiSP])
REFERENCES [dbo].[LoaiSanPham] ([MaLoaiSP])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SP_LoaiSP]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SP_NCC] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SP_NCC]
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_TK_CV] FOREIGN KEY([MaChucVu])
REFERENCES [dbo].[ChucVu] ([MaChucVu])
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [FK_TK_CV]
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_TK_NV] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [FK_TK_NV]
GO
/****** Object:  StoredProcedure [dbo].[sp_checkAccount]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_checkAccount]
(
	@MaNV varchar(255),
	@MatKhau varchar(255)
)
as
begin
	SELECT COUNT(MatKhau), MaChucVu
	FROM TaiKhoan
	WHERE MaNV = @MaNV AND MatKhau =  @MatKhau AND TrangThai = 1
	GROUP BY MaChucVu
end
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteDetailInvoiceImportWareHouse]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Detail Invoice Import Warehouse
CREATE PROC [dbo].[sp_DeleteDetailInvoiceImportWareHouse]
(
	@MaSP varchar(20)
)
as
begin
	DELETE FROM ChiTietHoaDonNhapKho
	WHERE MaSP = @MaSP

	SELECT 1
end
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteDetailInvoiceSelling]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Detail Invoice Selling
CREATE PROC [dbo].[sp_DeleteDetailInvoiceSelling]
(
	@MaHD varchar(10),
	@MaSP varchar(20) = null
)
as
begin
	IF @MaSP IS NULL
		BEGIN 
			DELETE FROM ChiTietHoaDonBanHang
			WHERE MaHD = @MaHD
		END
	ELSE
		BEGIN
			DELETE FROM ChiTietHoaDonBanHang
			WHERE MaHD = @MaHD AND MaSP = @MaSP
		END


	SELECT 1
end
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteInvoiceImportWareHouse]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Invoice Import Warehouse

CREATE PROC [dbo].[sp_DeleteInvoiceImportWareHouse]
(
	@MaNK varchar(20) = null
)
as
begin
	DELETE FROM ChiTietHoaDonNhapKho
	WHERE MaNK = @MaNK

	DELETE FROM HoaDonNhapKho
	WHERE MaNK = @MaNK

	SELECT 1
end
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteInvoiceSelling]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Discount

--Invoice Selling
CREATE PROC [dbo].[sp_DeleteInvoiceSelling]
(
	@MaHD varchar(10)
)
as
begin
	DELETE FROM ChiTietHoaDonBanHang
	WHERE MaHD = @MaHD
	
	DELETE FROM HoaDonBanHang
	WHERE MaHD = @MaHD

	SELECT 1
end
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteProductExpire]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--FINISH
--DELETE PRODUCT FULL DATE
CREATE PROC [dbo].[sp_DeleteProductExpire]
(
	@MaNK varchar(20),
	@MaSP varchar(20)
)
AS
BEGIN
	declare @SoLuongTru int;
	SELECT @SoLuongTru = (SoLuong - SoLuongDaBan)
	FROM ChiTietHoaDonNhapKho
	WHERE MaSP = @MaSP AND MaNK = @MaNK

	UPDATE SanPham
	SET SoLuong = Soluong - @SoLuongTru
	WHERE MaSP = @MaSP

	UPDATE ChiTietHoaDonNhapKho
	SET TrangThai = 0
	WHERE MaSP = @MaSP AND MaNK = @MaNK

	SELECT 1
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAccount]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Account
CREATE PROC [dbo].[sp_GetAccount]
(
	@MaNV varchar(255) = null,
	@HoTen nvarchar(255) = null,
	@TrangThai bit = null
)
AS
BEGIN
	IF @TrangThai is null
	BEGIN
		SELECT TK.MaNV, HoTen ,MatKhau, TenChucVu, TK.TrangThai
		FROM TaiKhoan TK 
			JOIN ChucVu CV ON TK.MaChucVu = CV.MaChucVu
			JOIN NhanVien NV ON TK.MaNV = NV.MaNV
		WHERE (TK.MaNV LIKE '%' + ISNULL(@MaNV, '') + '%')
			AND (HoTen LIKE '%' + ISNULL(@HoTen, '') + '%') 
	END
	ELSE
	BEGIN
		SELECT TK.MaNV, HoTen, MatKhau, TenChucVu, TK.TrangThai
		FROM TaiKhoan TK 
			JOIN ChucVu CV ON TK.MaChucVu = CV.MaChucVu
			JOIN NhanVien NV ON TK.MaNV = NV.MaNV
		WHERE (TK.MaNV LIKE '%' + ISNULL(@MaNV, '') + '%')
			AND (HoTen LIKE '%' + ISNULL(@HoTen, '') + '%') 
			AND TK.TrangThai = @TrangThai
	END
END
GO
/****** Object:  StoredProcedure [dbo].[sp_getCustomerTo]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Customer
create proc [dbo].[sp_getCustomerTo]
(
	@MaKH varchar(10) = null,
	@HoTen nvarchar(255) = null,
	@CCCD varchar(12) = null,
	@SDT varchar(12) = null,
	@GioiTinh nvarchar(3) = null,
	@DiaChi nvarchar(255) = null,
	@NgayDangKy datetime = null,
	@TrangThai bit = null
)
as
begin
	IF @TrangThai is null
	BEGIN
		SELECT MaKH, HoTen, CCCD, SDT, GioiTinh, DiaChi, NgayDangKy, TrangThai
		FROM KhachHang
		WHERE (MaKH LIKE '%' + ISNULL(@MaKH, '') + '%')
		AND (HoTen LIKE '%' + ISNULL(@HoTen, '') + '%')
		AND (CCCD LIKE '%' + ISNULL(@CCCD, '') + '%')
		AND (GioiTinh LIKE '%' + ISNULL(@GioiTinh, '') + '%')
		AND (DiaChi LIKE '%' + ISNULL(@DiaChi, '') + '%')
		AND (SDT LIKE '%' + ISNULL(@SDT, '') + '%')
		AND (NgayDangKy = ISNULL(@NgayDangKy, NgayDangKy))
	END
	ELSE
	BEGIN
		SELECT MaKH, HoTen, CCCD, SDT, GioiTinh, DiaChi, NgayDangKy, TrangThai
		FROM KhachHang
		WHERE (MaKH LIKE '%' + ISNULL(@MaKH, '') + '%')
		AND (HoTen LIKE '%' + ISNULL(@HoTen, '') + '%')
		AND (CCCD LIKE '%' + ISNULL(@CCCD, '') + '%')
		AND (GioiTinh LIKE '%' + ISNULL(@GioiTinh, '') + '%')
		AND (DiaChi LIKE '%' + ISNULL(@DiaChi, '') + '%')
		AND (SDT LIKE '%' + ISNULL(@SDT, '') + '%')
		AND (NgayDangKy = ISNULL(@NgayDangKy, NgayDangKy))
		And (TrangThai = @TrangThai)
	END
	
	
end
GO
/****** Object:  StoredProcedure [dbo].[sp_GetCustomerToPhone]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_GetCustomerToPhone]
(
	@SDT varchar(12)
)
AS
BEGIN
	SELECT MaKH, HoTen, CCCD, SDT, GioiTinh, DiaChi, NgayDangKy, TrangThai
	FROM KhachHang
	WHERE SDT = @SDT 
END

GO
/****** Object:  StoredProcedure [dbo].[sp_GetDetailInvoiceImportWareHouse]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Detail Invoice Import Warehouse
CREATE PROC [dbo].[sp_GetDetailInvoiceImportWareHouse]
(
	@MaNK varchar(20) = null,
	@MaSp varchar(20) = null
)
as
begin
	SELECT MaNK, MaSP, SoLuong, DonGiaNhap, ThanhTien, SoLuongDaBan
	FROM ChiTietHoaDonNhapKho
	WHERE (MaNK LIKE '%' + ISNULL(@MaNK, '') + '%')
		AND (MaSP LIKE '%' + ISNULL(@MaSp, '') + '%')
end
GO
/****** Object:  StoredProcedure [dbo].[sp_GetDetailInvoiceSelling]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Detail Invoice Selling
CREATE PROC [dbo].[sp_GetDetailInvoiceSelling]
(
	@MaHD varchar(10) = null,
	@MaSP varchar(20) = null,
	@MaKM varchar(10) = null
)
as
begin
	IF @MaKM IS NULL
		BEGIN
			SELECT MaHD, TenSP, MaKM, DonGia, CT.SoLuong as SL, ThanhTien
			FROM 
				ChiTietHoaDonBanHang CT
			LEFT JOIN
				SanPham SP ON SP.MaSP = CT.MaSP
			WHERE (MaHD LIKE '%' + ISNULL(@MaHD, '') + '%')
				AND (CT.MaSP LIKE '%' + ISNULL(@MaSP, '') + '%')
		END
	ELSE
		BEGIN
			SELECT MaHD, TenSp, MaKM, DonGia, CT.SoLuong as SL, ThanhTien
			FROM 
				ChiTietHoaDonBanHang CT
			LEFT JOIN
				SanPham SP ON SP.MaSP = CT.MaSP
			WHERE (MaHD LIKE '%' + ISNULL(@MaHD, '') + '%')
				AND (CT.MaSP LIKE '%' + ISNULL(@MaSP, '') + '%')
				AND (MaKM LIKE '%' + @MaKM + '%')
		END
end
GO
/****** Object:  StoredProcedure [dbo].[sp_getDiscount]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_getDiscount]
(
	@MaKM varchar(10) = null,
	@TenKM varchar(255) = null,
	@NgayBatDat date = null,
	@NgayKetThuc date = null
)
as
begin
	SELECT MaKM,TenKM, GiaKhuyenMai,NgayBatDau, NgayKetThuc
	FROM KhuyenMai
	WHERE (MaKM LIKE '%' + ISNULL(@MaKM, '') + '%')
		AND (TenKM LIKE '%' + ISNULL(@TenKM, '') + '%')
		AND (NgayBatDau = ISNULL(@NgayBatDat, NgayBatDau))
		AND (NgayKetThuc = ISNULL(@NgayKetThuc, NgayKetThuc))
end
GO
/****** Object:  StoredProcedure [dbo].[sp_getDiscountToDay]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Discount
CREATE PROC [dbo].[sp_getDiscountToDay]
as
begin
	SELECT MaKM, TenKM, GiaKhuyenMai, NgayBatDau, NgayKetThuc
	FROM KhuyenMai
	WHERE GETDATE() BETWEEN  NgayBatDau AND NgayKetThuc
end
GO
/****** Object:  StoredProcedure [dbo].[sp_getEmployeeTo]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Employee
CREATE PROC [dbo].[sp_getEmployeeTo]
(
	@MaNV varchar(10) = null,
	@CCCD varchar(12) = null,
	@HoTen nvarchar(255) = null,
	@GioiTinh nvarchar(3) = null,
	@DiaChi nvarchar(255) = null,
	@SDT varchar(12) = null,
	@NgayTao datetime = null,
	@MaChucVu varchar(5) = null,
	@TrangThai bit = null
)
as
begin 
	IF @TrangThai is null
	BEGIN
		SELECT MaNV, CCCD, HoTen, GioiTinh, DiaChi, SDT, NgayTao, MaChucVu, TrangThai
		FROM NhanVien
		WHERE (MaNV LIKE '%' + ISNULL(@MaNV, '') + '%')
			AND (HoTen LIKE '%' + ISNULL(@HoTen, '') + '%')
			AND (CCCD LIKE '%' + ISNULL(@CCCD, '') + '%')
			AND (GioiTinh LIKE '%' + ISNULL(@GioiTinh, '') + '%')
			AND (DiaChi LIKE '%' + ISNULL(@DiaChi, '') + '%')
			AND (SDT LIKE '%' + ISNULL(@SDT, '') + '%')
			AND (NgayTao = ISNULL(@NgayTao, NgayTao))
			AND (MaChucVu LIKE '%' + ISNULL(@MaChucVu, '') + '%')
	END
	ELSE
	BEGIN
		SELECT MaNV, CCCD, HoTen, GioiTinh, DiaChi, SDT, NgayTao, MaChucVu, TrangThai
		FROM NhanVien
		WHERE (MaNV LIKE '%' + ISNULL(@MaNV, '') + '%')
			AND (HoTen LIKE '%' + ISNULL(@HoTen, '') + '%')
			AND (CCCD LIKE '%' + ISNULL(@CCCD, '') + '%')
			AND (GioiTinh LIKE '%' + ISNULL(@GioiTinh, '') + '%')
			AND (DiaChi LIKE '%' + ISNULL(@DiaChi, '') + '%')
			AND (SDT LIKE '%' + ISNULL(@SDT, '') + '%')
			AND (NgayTao = ISNULL(@NgayTao, NgayTao))
			AND (MaChucVu LIKE '%' + ISNULL(@MaChucVu, '') + '%')
			And (TrangThai = @TrangThai)
	END
end
GO
/****** Object:  StoredProcedure [dbo].[sp_GetError]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_GetError]
(
	@TrangThai bit = 1
)
AS
BEGIN
	SELECT STT, TenLoi, ViTriLoi, ThoiGian, TrangThai
	FROM QuanLyLoi
	WHERE TrangThai = @TrangThai
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GetInvoiceImportWareHouse]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Invoice Import Warehouse
CREATE PROC [dbo].[sp_GetInvoiceImportWareHouse]
(
	@MaNK varchar(10) = null,
	@MaNV varchar(10) = null,
	@MaNCC varchar(10) = null,
	@NgayNhapKho datetime = null,
	@TongTien decimal = null
)
as
begin
	SELECT MaNK, MaNV, MaNCC, NgayNhapKho, TongTien
	FROM HoaDonNhapKho
	WHERE (MaNK LIKE '%' + ISNULL(@MaNK, '') + '%')
		AND (MaNV LIKE '%' + ISNULL(@MaNV, '') + '%')
		AND (MaNCC LIKE '%' + ISNULL(@MaNCC, '') + '%')
		AND (NgayNhapKho = ISNULL(@NgayNhapKho, NgayNhapKho))
		AND (TongTien = ISNULL(@TongTien, TongTien))
end
GO
/****** Object:  StoredProcedure [dbo].[sp_getInvoiceSelling]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Invoice Selling
CREATE PROC [dbo].[sp_getInvoiceSelling]
(
	@MaHD varchar(10) = null,
	@MaNV varchar(10) = null,
	@MaKH varchar(10) = null,
	@NgayLapHD datetime = null
)
as
begin
	IF @MaKH IS NULL
		BEGIN
			SELECT MaHD, MaNV, MaKH,NgayLapHD, TongTien, TienKhachDua, TienTraKhach
			FROM HoaDonBanHang HD
			WHERE (MaHD LIKE '%' + ISNULL(@MaHD, '') + '%')
				AND (MaNV LIKE '%' + ISNULL(@MaNV, '') + '%')
				AND (NgayLapHD = ISNULL(@NgayLapHD, NgayLapHD))
		END
	ELSE
		BEGIN
			SELECT MaHD, MaNV, MaKH, NgayLapHD, TongTien, TienKhachDua, TienTraKhach
			FROM HoaDonBanHang
			WHERE (MaHD LIKE '%' + ISNULL(@MaHD, '') + '%')
				AND (MaNV LIKE '%' + ISNULL(@MaNV, '') + '%')
				AND (MaKH LIKE '%' + ISNULL(@MaKH, '') + '%')
				AND (NgayLapHD = ISNULL(@NgayLapHD, NgayLapHD))
		END
end
GO
/****** Object:  StoredProcedure [dbo].[sp_getProduct]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Product
CREATE PROC [dbo].[sp_getProduct]
(
	@MaSP varchar(20) = null,
	@TenSP nvarchar(50) = null,
	@TenNCC nvarchar(255) = null,
	@TenLoai varchar(10) = null,
	@DonViTinh nvarchar(20) = null,
	@TrangThai bit = null
)
as
begin
	IF @TrangThai is null
		BEGIN
			SELECT MaSP, HinhAnh, TenSP, TenNCC, TenLoai, GiaNhap, GiaBan, SoLuong, HanSuDung, DonViTinh, SanPham.TrangThai
			FROM SanPham
			JOIN LoaiSanPham lsp ON lsp.MaLoaiSP = SanPham.MaLoaiSP
			JOIN NhaCungCap ON NhaCungCap.MaNCC = SanPham.MaNCC
			WHERE (MaSP LIKE '%' + ISNULL(@MaSP, '') + '%')
				AND (TenSP LIKE '%' + ISNULL(@TenSP, '') + '%')
				AND (TenNCC LIKE '%' + ISNULL(@TenNCC, '') + '%')
				AND (lsp.TenLoai LIKE '%' + ISNULL(@TenLoai, '') + '%')
				AND (DonViTinh LIKE '%' + ISNULL(@DonViTinh, '') + '%')
		END
	ELSE
		BEGIN
			SELECT MaSP, HinhAnh, TenSP, TenNCC, TenLoai, GiaNhap, GiaBan, SoLuong, HanSuDung, DonViTinh, SanPham.TrangThai
			FROM SanPham
			JOIN LoaiSanPham lsp ON lsp.MaLoaiSP = SanPham.MaLoaiSP
			JOIN NhaCungCap ON NhaCungCap.MaNCC = SanPham.MaNCC
			WHERE (MaSP LIKE '%' + ISNULL(@MaSP, '') + '%')
				AND (TenSP LIKE '%' + ISNULL(@TenSP, '') + '%')
				AND (TenNCC LIKE '%' + ISNULL(@TenNCC, '') + '%')
				AND (lsp.TenLoai LIKE '%' + ISNULL(@TenLoai, '') + '%')
				AND (DonViTinh LIKE '%' + ISNULL(@DonViTinh, '') + '%')
				AND (SanPham.TrangThai = @TrangThai)
		END
end
GO
/****** Object:  StoredProcedure [dbo].[sp_GetProductExpire]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_GetProductExpire]
AS
BEGIN
	SELECT MaNK, CT.MaSP, TenSP, CT.SoLuong, NgayHetHan
	FROM ChiTietHoaDonNhapKho CT
	JOIN SanPham SP ON SP.MaSP = CT.MaSP
	WHERE (NgayHetHan < GETDATE() OR NgayHetHan is not NULL) AND CT.TrangThai = 1 

END
GO
/****** Object:  StoredProcedure [dbo].[sp_GetRevenue]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_GetRevenue]
(
	@Ngay datetime,
	@TieuChi nvarchar(5)
)
AS
BEGIN
SELECT
	dbo.func_TienBanSP(@Ngay, @TieuChi) - dbo.func_TienNhapSP(@Ngay, @TieuChi) AS DoanhThu,
	dbo.func_TienBanSP(@Ngay, @TieuChi) AS TienBanSP,
	dbo.func_TienNhapSP(@Ngay, @TieuChi) AS TienNhapSP,
	dbo.func_SLHD_Ban(@Ngay, @TieuChi) AS SLHD_Ban,
	dbo.func_SLHD_Nhap(@Ngay, @TieuChi) AS SLHD_Nhap,
	dbo.func_SLSP_Ban(@Ngay, @TieuChi) AS SLSP_Ban,
	dbo.func_SLSP_Nhap(@Ngay, @TieuChi) AS SLSP_Nhap,
	dbo.func_SLKM(@Ngay, @TieuChi) AS SLKM,
	dbo.func_SLNCC(@Ngay, @TieuChi) AS SLNCC,
	dbo.func_SLNV(@Ngay, @TieuChi) AS SLNV
END

--PROC
------------------------------------------- GET AND SEARCH  -------------------------------------------
GO
/****** Object:  StoredProcedure [dbo].[sp_getRole]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Role
CREATE PROC [dbo].[sp_getRole]
(
	@MaChucVu varchar(5) = null, 
	@TenChucVu nvarchar(255) = null
)
as
begin
	SELECT MaChucVu, TenChucVu, TrangThai
	FROM ChucVu
	WHERE (MaChucVu LIKE '%' + ISNULL(@MaChucVu, '') + '%')
		AND (TenChucVu LIKE '%' + ISNULL(@TenChucVu, '') + '%')
end
GO
/****** Object:  StoredProcedure [dbo].[sp_getSupplier]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Supplier
CREATE PROC [dbo].[sp_getSupplier]
(
	@MaNCC varchar(20) = null,
	@TenNCC nvarchar(255) = null,
	@SDT varchar(12) = null,
	@DiaChi nvarchar(255) = null,
	@TrangThai bit = null
)
as
begin
	IF @TrangThai is null
		SELECT MaNCC, TenNCC, SDT, DiaChi, TrangThai
		FROM NhaCungCap
		WHERE (MaNCC LIKE '%' + ISNULL(@MaNCC, '') + '%')
			AND (TenNCC LIKE '%' + ISNULL(@TenNCC, '') + '%')
			AND (SDT LIKE '%' + ISNULL(@SDT, '') + '%')
			AND (DiaChi LIKE '%' + ISNULL(@DiaChi, '') + '%')
	ELSE
		SELECT MaNCC, TenNCC, SDT, DiaChi, TrangThai
		FROM NhaCungCap
		WHERE (MaNCC LIKE '%' + ISNULL(@MaNCC, '') + '%')
			AND (TenNCC LIKE '%' + ISNULL(@TenNCC, '') + '%')
			AND (SDT LIKE '%' + ISNULL(@SDT, '') + '%')
			AND (DiaChi LIKE '%' + ISNULL(@DiaChi, '') + '%')
			AND (TrangThai = @TrangThai) 
end
GO
/****** Object:  StoredProcedure [dbo].[sp_getTypeProduct]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--TypeProduct
CREATE PROC [dbo].[sp_getTypeProduct]
(
	@MaLoaiSP varchar(10) = null,
	@TenLoai nvarchar(100) = null,
	@MoTa nvarchar(255) = null
)
as
begin
	SELECT MaLoaiSP, TenLoai, MoTa
	FROM LoaiSanPham
	WHERE (MaLoaiSP LIKE '%' + ISNULL(@MaLoaiSP, '') + '%')
		AND (TenLoai LIKE '%' + ISNULL(@TenLoai, '') + '%')
		AND (MoTa LIKE '%' + ISNULL(@MoTa, '') + '%')
end
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertAccount]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

------------------------------------------- INSERT  -------------------------------------------
--Account
CREATE PROC [dbo].[sp_InsertAccount]
(
	@MaNV varchar(10),
	@MaChucVu varchar(5)
)
as
begin
	declare @isMaNV int = (SELECT COUNT(MANV) 
							FROM NhanVien
							WHERE MaNV = @MaNV)
	if (@isMaNV <= 0)	
	begin
		declare @pass varchar(255) = (SELECT CCCD FROM NhanVien WHERE MaNV = @MaNV)
		INSERT INTO TaiKhoan (MaNV, MatKhau, MaChucVu, TrangThai)
		VALUES (@MaNV, @pass, @MaChucVu, 1)

		SELECT 1
	end
end
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertCustomer]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Customer
create proc [dbo].[sp_InsertCustomer]
(
	 @CCCD varchar(12), @HoTen nvarchar(100) = null,
	@GioiTinh nvarchar(3) = 'Nam', @DiaChi nvarchar(255) = null, @SDT varchar(12) = null, @NgayDangKy date = GETDATE,
	 @TrangThai bit = 1

)
as 
begin 
		INSERT INTO KhachHang( HoTen, CCCD, SDT, GioiTinh, DiaChi, NgayDangKy, TrangThai)
		VAlUES( @HoTen ,@CCCD , @SDT ,@GioiTinh , @DiaChi , @NgayDangKy ,@TrangThai )
		SELECT 1
end
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertDetailInvoiceImportWareHouse]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Detail Invoice Import Warehouse
CREATE PROC [dbo].[sp_InsertDetailInvoiceImportWareHouse]
(
	@MaNK varchar(20) = null,
	@MaSP varchar(20) = null,
	@SoLuong int = 0,
	@DonGiaNhap decimal = 0
)
as
begin
	declare @NgayNhap datetime = ( SELECT NgayNhapKho
									FROM HoaDonNhapKho
									WHERE MaNK = @MaNK);
	declare @HSD varchar(5) = ( SELECT HanSuDung 
						FROM SanPham
						WHERE MaSP = @MaSP);

	declare @charHSD varchar(1) = RIGHT(@HSD, 1);
	declare @NgayHetHan date = null;

	IF @charHSD = 'D'
		BEGIN
			SET @NgayHetHan = DATEADD(day, CAST(LEFT(@HSD, LEN(@HSD) - 1 ) AS INT) , @NgayNhap)
		END
	ELSE IF @charHSD = 'M'
		BEGIN
			SET @NgayHetHan = DATEADD(MONTH, CAST(LEFT(@HSD, LEN(@HSD) - 1 ) AS INT) , @NgayNhap)
		END
	ELSE IF @charHSD = 'Y'
		BEGIN
			SET @NgayHetHan = DATEADD(YEAR, CAST(LEFT(@HSD, LEN(@HSD) - 1 ) AS INT) , @NgayNhap)
		END

	INSERT INTO ChiTietHoaDonNhapKho(MaNK, MaSP, NgayHetHan, SoLuong, DonGiaNhap, ThanhTien, SoLuongDaBan, TrangThai)
	VALUES (@MaNK, @MaSP, @NgayHetHan, @SoLuong, @DonGiaNhap, @SoLuong * @DonGiaNhap, 0, 1)

	UPDATE SanPham
	SET SoLuong = SoLuong + @SoLuong
	WHERE MaSP = @MaSP

	SELECT 1
end
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertDetailInvoiceSelling]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Detail Invoice Selling
CREATE PROC [dbo].[sp_InsertDetailInvoiceSelling]
(
	@MaHD varchar(10),
	@MaSP varchar(20) = null,
	@MaKM varchar(10) = null,
	@SoLuong int = 0,
	@DonGia decimal = 0
)
as
begin
	INSERT INTO ChiTietHoaDonBanHang(MaHD, MaSP, MaKM, SoLuong, DonGia, ThanhTien)
	VALUES (@MaHD, @MaSP, @MaKM, @SoLuong, @DonGia, @SoLuong* @DonGia* (1 - ISNULL( (SELECT GiaKhuyenMai
																					FROM KhuyenMai
																					WHERE MaKM = @MaKM), 0) )
			)

	UPDATE SanPham
	SET SoLuong = SoLuong - @SoLuong
	WHERE MaSP = @MaSP
	
	--Lấy các sản phẩm có mã nhập kho gần nhất
	UPDATE ChiTietHoaDonNhapKho
	SET SoLuongDaBan = SoLuongDaBan + @SoLuong
	WHERE MaSP = @MaSP AND MaNK = (SELECT TOP 1 MaNK
									FROM ChiTietHoaDonNhapKho
									WHERE MaSP = @MaSP AND SoLuongDaBan != 0 AND TrangThai = 1
									ORDER BY NgayHetHan ASC)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertDiscount]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Discount
CREATE PROC [dbo].[sp_InsertDiscount]
(
	@MaKM varchar(20),
	@TenKM nvarchar(255),
	@GiaKhuyenMai float = 0,
	@NgayBatDau date = GETDATE,
	@NgayKetThuc date = GETDATE
)
as
begin
	INSERT INTO KhuyenMai (MaKM, TenKM, GiaKhuyenMai, NgayBatDau, NgayKetThuc)
	VALUES (@MaKM, @TenKM, @GiaKhuyenMai, @NgayBatDau, @NgayKetThuc)

	SELECT 1
end
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertEmployee]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Employee
CREATE PROC [dbo].[sp_InsertEmployee]
(
	@CCCD varchar(12), @HoTen nvarchar(100) = null, @GioiTinh nvarchar(3) = 'Nam',
	@DiaChi nvarchar(255) = null, @SDT varchar(12) = null, @NgayTao date = GETDATE,
	@MaChucVu varchar(5) = null, @TrangThai bit = 1
)
as 
begin 
		INSERT INTO NhanVien(CCCD, HoTen, GioiTinh, DiaChi, SDT, NgayTao, MaChucVu, TrangThai)
		VAlUES(@CCCD, @HoTen, @GioiTinh, @DiaChi, @SDT, @NgayTao, @MaChucVu, @TrangThai)

		declare @MaNV_New varchar(10) = ( SELECT TOP 1 MaNV
										FROM NhanVien
										ORDER BY MaNV DESC)
		INSERT INTO TaiKhoan(MaNV, MatKhau, MaChucVu, TrangThai) 
		VALUES(@MaNV_New, @CCCD, @MaChucVu, @TrangThai)

		SELECT 1
end
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertError]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_InsertError]
(
	@TenLoi varchar(255),
	@ViTriLoi varchar(255)
)
AS
BEGIN
	INSERT INTO QuanLyLoi(TenLoi, ViTriLoi, ThoiGian , TrangThai)
	VALUES(@TenLoi, @ViTriLoi, GETDATE(), 1)

	SELECT 1
END
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertInvoiceImportWareHouse]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--Invoice Import Warehouse
CREATE PROC [dbo].[sp_InsertInvoiceImportWareHouse]
(
	@MaNV varchar(10),
	@MaNCC varchar(20),
	@NgayNhapKho datetime = GETDATE,
	@TongTien decimal
)
as
begin
	INSERT INTO HoaDonNhapKho (MaNV, MaNCC, NgayNhapKho, TongTien)
	VALUES (@MaNV, @MaNCC, @NgayNhapKho, @TongTien)

	SELECT TOP 1 MaNK
	FROM HoaDonNhapKho
	ORDER BY MaNK DESC
end
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertInvoiceSelling]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---===========================
CREATE PROC [dbo].[sp_InsertInvoiceSelling]
(
	@MaNV varchar(10),
	@MaKH varchar(10) = null,
	@TongTien decimal,
	@TienKhachDua decimal = 0
)
as
begin
	INSERT INTO HoaDonBanHang(MaNV, MaKH, NgayLapHD,TongTien, TienKhachDua, TienTraKhach)
	VALUES (@MaNV, @MaKH, GETDATE() ,@TongTien, @TienKhachDua, @TienKhachDua - @TongTien)


	SELECT TOP 1 MaHD
	FROM HoaDonBanHang
	ORDER BY MaHD DESC

end
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertProduct]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Product
CREATE PROC [dbo].[sp_InsertProduct]
(
	@TenSp nvarchar(50), @MaNCC varchar(20), @MaLoaiSP varchar(10),
	@GiaNhap decimal, @GiaBan decimal, @SoLuong int, @HanSuDung varchar(5),
	@DonViTinh nvarchar(20), @HinhAnh varchar(255) = null, @TrangThai bit
)
as
begin
	INSERT INTO SanPham (TenSP, MaNCC, MaLoaiSP, GiaNhap, GiaBan, SoLuong, HanSuDung, DonViTinh, HinhAnh, TrangThai)
	VALUES (@TenSP, @MaNCC, @MaLoaiSP, @GiaNhap, @GiaBan, @SoLuong, @HanSuDung, @DonViTinh, @HinhAnh, @TrangThai)

	SELECT 1
end
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertRole]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Role
CREATE PROC [dbo].[sp_InsertRole]
(
	@MaChucVu varchar(5) = null, 
	@TenChucVu nvarchar(255) = null,
	@TrangThai bit = 0
)
as
begin
	INSERT INTO ChucVu (MaChucVu, TenChucVu, TrangThai) VALUES (@MaChucVu, @TenChucVu, @TrangThai)

	SELECT 1
end
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertSupplier]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Supplier
CREATE PROC [dbo].[sp_InsertSupplier]
(
	@TenNCC nvarchar(255), @SDT varchar(12),
	@DiaChi nvarchar(255), @TrangThai bit = 1
)
as
begin
	INSERT INTO NhaCungCap(TenNCC, SDT, DiaChi, TrangThai)
	VALUES (@TenNCC, @SDT, @DiaChi, @TrangThai)

	SELECT 1
end
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertTypeProduct]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--TypeProduct
CREATE PROC [dbo].[sp_InsertTypeProduct]
(
	@TenLoai nvarchar(100) = null,
	@MoTa nvarchar(255) = null
)
as
begin
	INSERT INTO LoaiSanPham (TenLoai, MoTa)
	VALUES (@TenLoai, @MoTa)

	
	SELECT 1
end
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateCustomer]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Customer

create proc [dbo].[sp_UpdateCustomer]
(
	@MaKH varchar(10),  @CCCD varchar(12), @HoTen nvarchar(100),
	@GioiTinh nvarchar(3), @DiaChi nvarchar(255), @SDT varchar(12), @NgayDangKy date,
	 @TrangThai bit = 0 
)
as 
begin 
		UPDATE KhachHang
		SET  CCCD = @CCCD, HoTen = @HoTen,
			GioiTinh = @GioiTinh, DiaChi = @DiaChi, SDT = @SDT, NgayDangKy = @NgayDangKy, 
			TrangThai = @TrangThai
		WHERE MaKH = @MaKH
		SELECT 1
end
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateDetailInvoiceImportWareHouse]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Detail Invoice Import Warehouse
CREATE PROC [dbo].[sp_UpdateDetailInvoiceImportWareHouse]
(
	@MaNK varchar(20) = null,
	@MaSp varchar(20) = null,
	@SoLuong int = 0,
	@DonGiaNhap decimal = 0
)
as
begin
	UPDATE ChiTietHoaDonNhapKho
	SET MaNK = @MaNK, MaSP = @MaSP, SoLuong = @SoLuong, 
		DonGiaNhap = @DonGiaNhap, ThanhTien = @SoLuong * DonGiaNhap

	SELECT 1
end
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateDetailInvoiceSelling]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Detail Invoice Selling --Cancel - Because don't fix Bill
CREATE PROC [dbo].[sp_UpdateDetailInvoiceSelling]
(
	@MaHD varchar(10) = null,
	@MaSP varchar(20) = null,
	@MaKM varchar(10) = null,
	@SoLuong int = 0,
	@DonGia decimal = 0
)
as
begin
	UPDATE ChiTietHoaDonBanHang
	SET MaSP =  @MaSP, MaKM = @MaKM, SoLuong = @SoLuong, DonGia = @DonGia, ThanhTien = @SoLuong * @DonGia * ISNULL((SELECT GiaKhuyenMai
																													FROM KhuyenMai
																													WHERE MaKM = @MaKM), 1)
	WHERE MaHD = @MaHD

	IF @SoLuong > (SELECT SoLuong FROM SanPham WHERE MaSP = @MaSP)
		BEGIN
			UPDATE SanPham
			SET SoLuong = SoLuong - @SoLuong
			WHERE MaSP = @MaSP
		END
	ELSE IF @SoLuong < (SELECT SoLuong FROM SanPham WHERE MaSP = @MaSP)
		BEGIN 
			UPDATE SanPham
			SET SoLuong = SoLuong + @SoLuong
			WHERE MaSP = @MaSP
		END
	SELECT 1
end
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateDiscount]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Discount
CREATE PROC [dbo].[sp_UpdateDiscount]
(
	@MaKM varchar(20),
	@TenKM nvarchar(255),
	@GiaKhuyenMai float = 0,
	@NgayBatDau date = GETDATE,
	@NgayKetThuc date = GETDATE
)
as
begin
	UPDATE KhuyenMai 
	SET TenKM = @TenKM, GiaKhuyenMai = @GiaKhuyenMai, 
		NgayBatDau = @NgayBatDau, NgayKetThuc = @NgayKetThuc
	WHERE MaKM = @MaKM

	SELECT 1
end
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateEmployee]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Employee
CREATE PROC [dbo].[sp_UpdateEmployee]
(
	@MaNV varchar(10), @CCCD varchar(12), @HoTen nvarchar(100),
	@GioiTinh nvarchar(3), @DiaChi nvarchar(255), @SDT varchar(12), @NgayTao date,
	@MaChucVu varchar(5), @TrangThai bit = 0 

)
as 
begin 
		UPDATE NhanVien
		SET CCCD = @CCCD, HoTen = @HoTen,GioiTinh = @GioiTinh, DiaChi = @DiaChi, 
			SDT = @SDT, NgayTao = @NgayTao, 
			MaChucVu = @MaChucVu, TrangThai = @TrangThai
		WHERE MaNV = @MaNV

		UPDATE TaiKhoan
		SET MaChucVu = @MaChucVu
		WHERE MaNV = @MaNV

		SELECT 1
end
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateInvoiceImportWareHouse]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--Invoice Import Warehouse
CREATE PROC [dbo].[sp_UpdateInvoiceImportWareHouse]
(
	@MaNK varchar(20),
	@MaNV varchar(10),
	@MaNCC varchar(20),
	@NgayNhapKho datetime = GETDATE,
	@TongTien decimal
)
as
begin
	UPDATE HoaDonNhapKho
	SET MaNK = @MaNK, MaNV = @MaNV, MaNCC = @MaNCC, 
		NgayNhapKho = @NgayNhapKho, TongTien = @TongTien

	SELECT 1
end
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateInvoiceSelling]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Invoice Selling
CREATE PROC [dbo].[sp_UpdateInvoiceSelling]
(
	@MaHD varchar(10) = null,
	@MaNV varchar(20) = null,
	@MaKH varchar(10) = null,
	@NgayLapHD Datetime = 0,
	@TongTien decimal = 0,
	@TienKhachDua decimal = 0
)
as
begin
	UPDATE HoaDonBanHang
	SET @MaNV =  @MaNV, MaKH = @MaKH, NgayLapHD = @NgayLapHD, TongTien = @TongTien, 
		TienKhachDua = @TienKhachDua,  TienTraKhach = @TienKhachDua - @TongTien
	WHERE MaHD = @MaHD

	SELECT 1
end
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdatePasswordAccount]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

------------------------------------------- UPDATE  -------------------------------------------
--Account

CREATE PROC [dbo].[sp_UpdatePasswordAccount]
(
	@MaNV varchar(10),
	@MatKhau varchar(255)
)
as
begin
	declare @isMaNV int = (SELECT COUNT(MANV) 
							FROM NhanVien
							WHERE MaNV = @MaNV)
	if (@isMaNV > 0)
		begin
			UPDATE TaiKhoan
			SET MatKhau = @MatKhau
			WHERE @MaNV = MaNV
		end
	

	SELECT 1
end
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateProduct]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--Product
CREATE PROC [dbo].[sp_UpdateProduct]
(
	@MaSP nvarchar(10), @TenSp nvarchar(50), @MaNCC varchar(20), @MaLoaiSP varchar(10),
	@GiaNhap decimal, @GiaBan decimal, @SoLuong int, @HanSuDung varchar(5),
	@DonViTinh nvarchar(20), @HinhAnh varchar(255), @TrangThai int
)
as
begin
	UPDATE SanPham
	SET TenSP = @TenSp, MaNCC = @MaNCC, MaLoaiSP = @MaLoaiSP, GiaNhap = @GiaNhap, GiaBan = @GiaBan, SoLuong = @SoLuong, 
		HanSuDung = @HanSuDung, DonViTinh = @DonViTinh, HinhAnh = @HinhAnh, TrangThai = @TrangThai
	WHERE MaSP = @MaSp

	SELECT 1
end
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateRole]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Role
CREATE PROC [dbo].[sp_UpdateRole]
(
	@MaChucVu varchar(5) = null,
	@TenChucVu nvarchar(255) = null,
	@TrangThai bit = 0
)
as
begin
	UPDATE ChucVu
	SET MaChucVu = @MaChucVu, TenChucVu = @TenChucVu, TrangThai = @TrangThai

	SELECT 1
end
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateStatusAccount]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
------------------------------------------- UPDATE STATUS OR DELETE -------------------------------------------
--Account
CREATE PROC [dbo].[sp_UpdateStatusAccount]
(
	@MaNV varchar(10),
	@TrangThai bit
)
AS
BEGIN
	UPDATE TaiKhoan
	SET TrangThai = @TrangThai
	WHERE MaNV = @MaNV

	SELECT 1
END
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateStatusCustomer]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Customer

create proc [dbo].[sp_UpdateStatusCustomer]
(
	@MaKH varchar(10) = null
)
as 
begin
	Update KhachHang
	set TrangThai=0
	where MaKH=@MaKH
	select 1

end
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateStatusEmployee]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Employee
CREATE PROC [dbo].[sp_UpdateStatusEmployee]
(
	@MaNV varchar(10) = null
)
as 
begin
	UPDATE NhanVien
	SET TrangThai = 0
	WHERE MaNV = @MaNV

	UPDATE TaiKhoan
	SET TrangThai = 0
	WHERE MaNV = @MaNV

	SELECT 1
end
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateStatusError]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_UpdateStatusError]
(
	@STT int,
	@TrangThai bit
)
AS
BEGIN
	UPDATE QuanLyLoi
	SET TrangThai = @TrangThai
	WHERE STT = @STT

	SELECT 1
END
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateStatusProduct]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Product
CREATE PROC [dbo].[sp_UpdateStatusProduct]
(
	@MaSP varchar(20)
)
as
begin
	UPDATE SanPham
	SET TrangThai = 0
	WHERE MaSP = @MaSP

	SELECT 1
end
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateStatusSupplier]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Supplier
CREATE PROC [dbo].[sp_UpdateStatusSupplier]
(
	@MaNCC varchar(20)
)
as
begin
	UPDATE NhaCungCap
	SET TrangThai = 0
	WHERE MaNCC = @MaNCC

	UPDATE SanPham
	SET TrangThai = 0
	WHERE MaNCC = @MaNCC

	SELECT 1
end
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateStatusTypeProduct]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--TypeProduct
CREATE PROC [dbo].[sp_UpdateStatusTypeProduct]
(
	@MaLoaiSP varchar(10)
)
as
begin
	DELETE FROM LoaiSanPham
	WHERE MaLoaiSP = @MaLoaiSP

	SELECT 1
end
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateSupplier]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Supplier
CREATE PROC [dbo].[sp_UpdateSupplier]
(
	@MaNCC varchar(20), @TenNCC nvarchar(255), @SDT varchar(12),
	@DiaChi nvarchar(255), @TrangThai bit = 1
)
as
begin
	UPDATE NhaCungCap
	SET TenNCC = @TenNCC, SDT = @SDT, DiaChi = @DiaChi, TrangThai = @TrangThai
	WHERE MaNCC = @MaNCC

	SELECT 1
end
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateTypeProduct]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--TypeProduct
CREATE PROC [dbo].[sp_UpdateTypeProduct]
(
	@MaLoaiSP varchar(10),
	@TenLoai nvarchar(100) = null,
	@MoTa nvarchar(255) = null
)
as
begin
	UPDATE LoaiSanPham
	SET TenLoai = @TenLoai, MoTa = @MoTa
	WHERE MaLoaiSP = @MaLoaiSP

	SELECT 1
end
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdatStatusRole]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Role
CREATE PROC [dbo].[sp_UpdatStatusRole]
(
	@MaChucVu varchar(5) = null
)
as
begin
	UPDATE ChucVu
	SET TrangThai = 0

	SELECT 1
end
GO
/****** Object:  StoredProcedure [dbo].[UpdateStatusError]    Script Date: 06/05/2025 20:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[UpdateStatusError]
(
	@STT int,
	@TrangThai bit
)
AS
BEGIN
	UPDATE QuanLyLoi
	SET TrangThai = @TrangThai
	WHERE STT = @STT

	SELECT 1
END
GO
--------------------------------------------------------------
--ADD DATA 
--ADD DATA CHUCVU
INSERT INTO CHUCVU (MaChucVu, TenChucVu, TrangThai) VALUES
('QLCC',N'Quản Lý Cấp Cao',1)
,('QL',N'Quản Lý',1)
,('NV',N'Nhân Viên',1)

--ADD DATA NHANVIEN
INSERT INTO NHANVIEN (MaNV, CCCD, HoTen, GioiTinh, DiaChi, SDT, NgayTao,MaChucVu, TrangThai) VALUES
('NV001',N'1234567890',N'Nguyễn Văn An',N'Nam',N'123 Lê Lợi, Quận 1, TP.HCM','0123456789','2023-08-09','NV',1)
,('NV002',N'987654321',N'Trần Thị Bình',N'Nữ',N'456 Nguyễn Văn Linh, Quận 7, TP.HCM','0987654321','2023-09-12','NV',1)
,('NV003',N'1357924680',N'Lê Văn Cường',N'Nam',N'789 Trần Hưng Đạo, Đà Nẵng','0909888777','2023-06-21','NV',0)
,('NV004',N'2468013579',N'Phạm Thị Dung',N'Nữ',N'101 Lê Lai, Hải Phòng','0275928289','2023-10-03','NV',1)
,('NV005',N'9876543210',N'Nguyễn Văn Bắc',N'Nam',N'456 Lý Thường Kiệt, Hà Nội','0798261174','2023-09-12','NV',1)
,('NV006',N'1234567777',N'Trần Hữu Minh Hiệp',N'Nam',N'448 Nguyễn Tất Thành, Quận 4,  ','0387976595','2024-03-28','QLCC',1)
,('NV007',N'5678901234',N'Lê Văn Hoàng',N'Nam',N'101 Hùng Vương, Đà Nẵng','0286571997','2022-11-15','NV',1)
,('NV008',N'4321098765',N'Phạm Thị Hương',N'Nữ',N'123 Bạch Đằng, Hải Phòng','0152397704','2023-03-11','NV',1)
,('NV009',N'987123456',N'Nguyễn Văn Thành',N'Nam',N'456 Nguyễn Huệ, TP.HCM','03503979231','2023-03-12','NV',1)
,('NV010',N'6543210987',N'Phạm Quang Khải',N'Nam',N'Quận 2, Tp.Hcm','09786451744','2023-09-14','QL',1)


--ADD DATA TAIKHOAN
INSERT INTO TAIKHOAN (MaNV, MatKhau, MaChucVu, TrangThai) VALUES
('NV001','password123','NV',1)
,('NV002','123456','NV',1)
,('NV003','abcdef','NV',0)
,('NV004','pass1234','NV',1)
,('NV005','987654','NV',1)
,('NV006','qwerty','QLCC',0)
,('NV007','654321','NV',1)
,('NV008','passpass','NV',1)
,('NV009','111111','NV',1)
,('NV010','222222','QL',1)

--ADD DATA KHACHHANG
INSERT INTO KHACHHANG (MaKH,HoTen, CCCD, SDT, GioiTinh, DiaChi, NgayDangKy, TrangThai) VALUES
('00001',N'Nguyễn Thị Hồng','1234567890','0123456789',N'Nữ',N'10 Nguyễn Du, Quận 1, TP.HCM','2023-12-23',1)
,('00002',N'Trần Văn Long','987654321','0987654321',N'Nam',N'20 Lê Lợi, Quận 3, TP.HCM','2023-11-30',1)
,('00003',N'Lê Thị Thanh','1357924680','0909888777',N'Nữ',N'30 Đống Đa, Quận 5, TP.HCM','2023-10-14',0)
,('00004',N'Phạm Văn Đức','2468013579','0888999000',N'Nam',N'40 Nguyễn Huệ, Quận 10, TP.HCM','2024-02-26',1)
,('00005',N'Hoàng Thị Mai','9876543210','0752482910',N'Nữ',N'50 Hai Bà Trưng, Quận 11, TP.HCM','2024-02-23',1)
,('00006',N'Nguyễn Văn Đức','123456789','0532763863',N'Nam',N'60 Cộng Hòa, Quận Tân Bình, TP.HCM','2024-01-08',0)
,('00007',N'Trần Thị Hương','5678901234','0786489709',N'Nữ',N'70 Nguyễn Thị Minh Khai, Quận 3, TP.HCM','2023-12-31',1)
,('00008',N'Lê Văn Nam','4321098765','0546217599',N'Nam',N'80 Trần Hưng Đạo, Quận 5, TP.HCM','2023-12-17',1)
,('00009',N'Phạm Thị Hằng','987123456','0928223819',N'Nữ',N'90 Bến Thành, Quận 1, TP.HCM','2023-12-02',1)
,('00010',N'Hoàng Văn Tuấn','6543210987','0928335309',N'Nam',N'100 Phạm Ngọc Thạch, Quận 3, TP.HCM','2024-01-13',0)



--ADD DATA NHACUNGCAP
INSERT INTO NHACUNGCAP (MaNCC,TenNCC, SDT, DiaChi, TrangThai) VALUES
('NCC001',N'Cửa hàng Thực Phẩm A','0123 456 789',N'12 Nguyễn Văn Linh, Quận 7, HCM',1)
,('NCC002',N'Cửa hàng Tiện Lợi B','0987 654 321',N'34 Lê Lai, Quận 1, HCM',1)
,('NCC003',N'Cửa hàng Vật Liệu C','0909 888 777',N'56 Nguyễn Thị Minh Khai, Q.3, HCM',0)
,('NCC004',N'Siêu Thị Mini XYZ','0888 999 000',N'78 Lý Thường Kiệt, Quận 10, HCM',1)
,('NCC005',N'Cửa hàng Đồ Điện D','0123 456 123',N'90 Trần Hưng Đạo, Quận 5, HCM',1)
,('NCC006',N'Siêu Thị Nhỏ ABC','0987 654 987',N'123 Bến Thành, Quận 1, HCM',1)
,('NCC007',N'Cửa hàng Thực Phẩm E','0909 888 555',N'456 Cống Quỳnh, Quận 1, HCM',0)
,('NCC008',N'Cửa hàng Tiện Lợi F','0888 999 111',N'678 Nguyễn Văn Cừ, Quận 5, HCM',1)
,('NCC009',N'Cửa hàng Vật Liệu G','0123 456 333',N'890 Nguyễn Đình Chiểu, Q.3, HCM',1)
,('NCC010',N'Siêu Thị Mini KLM','0987 654 444',N'101 Lê Lợi, Quận 1, HCM',0)


--ADD DATA LOAISANPHAM
INSERT INTO LOAISANPHAM (MaLoaiSP, TenLoai, MoTa) VALUES
('LSP001',N'Bánh Kẹo',N'Loại sản phẩm gồm các loại bánh và kẹo')
,('LSP002',N'Nước Giải Khát',N'Loại sản phẩm chứa các loại nước giải khát')
,('LSP003',N'Thực Phẩm',N'Loại sản phẩm bao gồm các sản phẩm thực phẩm')
,('LSP004',N'Gia Vị',N'Loại sản phẩm chứa các loại gia vị khác nhau')
,('LSP005',N'Đồ Điện Tử',N'Loại sản phẩm bao gồm các sản phẩm điện tử')
,('LSP006',N'Quần Áo',N'Loại sản phẩm chứa các sản phẩm quần áo và phụ kiện')
,('LSP007',N'Đồ Chơi',N'Loại sản phẩm gồm các loại đồ chơi cho trẻ em')
,('LSP008',N'Mỹ Phẩm',N'Loại sản phẩm chứa các sản phẩm mỹ phẩm và làm đẹp')
,('LSP009',N'Đồ Gia Dụng',N'Loại sản phẩm chứa các sản phẩm gia dụng và đồ nội thất')
,('LSP010',N'Thực Phẩm Tươi',N'Loại sản phẩm chứa các sản phẩm thực phẩm tươi sống')


--ADD DATA SANPHAM
INSERT INTO SANPHAM (MaSP,TenSP, MaNCC, MaLoaiSP, GiaNhap, GiaBan, SoLuong, HanSuDung, DonViTinh,HinhAnh, TrangThai) VALUES
('SP001',N'Bánh Quy Hương Vị Socola','NCC001','LSP001','10000','15000','50','1Y',N'Hộp','banhquysocola.jpg',1)
,('SP002',N'Nước Ngọt Pepsi','NCC002','LSP002','8000','12000','30','1Y',N'Lon','nuocngotpepsi.jpg',1)
,('SP003',N'Gạo Tám Sáng','NCC003','LSP003','20000','25000','20','5M',N'Kg','gaotamsang.jpg',1)
,('SP004',N'Bột Ngọt Ajinomoto','NCC004','LSP004','5000','7000','40','1.5Y',N'Gói','botngotajinomoto.jpg',1)
,('SP005',N'Điện Thoại Smartphone Samsung','NCC005','LSP005','5000000','5500000','5','',N'Cái','dthsamsung.jpg',1)
,('SP006',N'Áo Thun Nam','NCC006','LSP006','120000','150000','10','99Y',N'Cái','aothunnam.jpg',1)
,('SP007',N'Búp Bê Barbie','NCC007','LSP007','150000','200000','20','99Y',N'Cái','bbbarbie.jpg',1)
,('SP008',N'Kem Chống Nắng SPF 50','NCC008','LSP008','200000','250000','12','2Y',N'Chai','kemchongnangspf_50.jpg',1)
,('SP009',N'Nồi Cơm Điện Tự Động','NCC009','LSP009','300000','350000','8','99Y',N'Cái','noicomdien.jpg',1)
,('SP010',N'Rau Cải Xanh Tươi','NCC010','LSP010','20000','25000','30','2D',N'Kg','raucaixanh.jpg',1)
,('SP011',N'Bánh Bông Lan','NCC001','LSP001','30000','40000','40','7D',N'Hộp','banhbonglan.jpg',1)
,('SP012',N'Nước Suối Lavie','NCC002','LSP002','5000','7000','70','99Y',N'Chai','nuoclavie.jpg',1)
,('SP013',N'Sữa Tươi Vinamilk','NCC003','LSP003','25000','30000','60','6M',N'Hủ','suavinamilk.jpg',1)
,('SP014',N'Tiêu Xanh','NCC004','LSP004','7000','10000','80','3M',N'Gói','tieuxanh.jpg',1)
,('SP015',N'Tai Nghe Bluetooth','NCC005','LSP005','300000','350000','10','99Y',N'Cái','tainghebluetooth.jpg',1)
,('SP016',N'Áo Khoác Dù','NCC006','LSP006','250000','300000','20','99Y',N'Cái','aokhoacdu.jpg',1)
,('SP017',N'Puzzle','NCC007','LSP007','100000','150000','15','99Y',N'Hộp','puzzle.jpg',1)
,('SP018',N'Kem Dưỡng Da Neutrogena','NCC008','LSP008','150000','200000','8','3Y',N'Hũ','kemduongdaneutrogena.jpg',1)
,('SP019',N'Bình Đun Siêu Tốc','NCC009','LSP009','500000','600000','5','99Y',N'Cái','binhdunsieutoc.jpg',1)
,('SP020',N'Dưa Hấu','NCC010','LSP010','15000','20000','40','4D',N'Kg','duahau.jpg',1)

--ADD DATA KHUYENMAI
INSERT INTO KHUYENMAI (MaKM, TenKM, GiaKhuyenMai, NgayBatDau, NgayKetThuc)  VALUES
('KM080324',N'Khuyến Mãi 8/3/2024','0.1','2024-03-06','2024-03-08')
,('KMGP24',N'Khuyến Mãi Ngày Giải Phóng 30/4/2024','0.2','2024-04-27','2024-05-02')
,('KMQK23',N'Khuyến Mãi Ngày Quốc Khánh 2/9/2023','0.2','2023-08-28','2023-09-04')
,('KMSN24',N'Khuyến Mãi Sinh Nhật Năm 24','0.15','2024-02-22','2024-02-22')
,('KMTEST',N'Khuýen Mãi Test','0.3','2024-04-19','2024-05-15')
,('TETST2',N'Test 2','0.2','2024-04-19','2024-05-15')



--ADD DATA HOADONBANHANG
INSERT INTO HOADONBANHANG (MaHD, MaNV, MaKH, NgayLapHD, TongTien, TienKhachDua, TienTraKhach) VALUES
('HD001','NV001','00001','2023-12-25 22:28:48','200000','300000','100000')
,('HD002','NV002','00002','2024-02-28 00:11:58','24000','50000','26000')
,('HD003','NV003','00003','2023-09-27 18:48:03','28000','30000','2000')
,('HD004','NV004','00004','2024-01-26 14:52:43','450000','500000','50000')
,('HD005','NV005','00005','2023-04-07 14:26:19','500000','500000','0')
,('HD006','NV006','00006','1900-01-01 00:00:00','75000','75000','0')
,('HD007','NV007','00007','2023-03-24 13:26:11','70000','70000','0')
,('HD008','NV008','00008','2023-09-02 12:55:13','32000','50000','18000')
,('HD009','NV009','00009','2023-07-22 00:24:46','300000','500000','200000')
,('HD010','NV010',NULL,'1900-01-01 00:00:00','0','0','0')
,('HD012','NV002',NULL,'1900-01-01 00:00:00','0','0','0')
,('HD013','NV002',NULL,'2024-04-21 17:59:33','0','0','0')
,('HD014','NV002',NULL,'2024-04-21 18:00:57','8400','10000','1600')
,('HD015','NV002',NULL,'2024-05-04 20:37:34','243600','300000','56400')
,('HD016','NV002',NULL,'2024-05-04 20:38:06','572600','300000','-272600')
,('HD017','NV002',NULL,'2024-05-04 20:38:19','572600','800000','227400')
,('HD018','NV002',NULL,'2024-05-04 21:14:08','112700','120000','7300')
,('HD019','NV002',NULL,'2024-05-04 21:16:50','7940800','8000000','59200')
,('HD020','NV002',NULL,'2024-05-04 21:25:57','1190000','2000000','810000')
,('HD021','NV002','00007','2024-05-04 21:45:05','98700','100000','1300')
,('HD022','NV002',NULL,'2024-05-04 21:56:52','129500','130000','500')
,('HD023','NV002',NULL,'2024-05-04 21:59:52','25900','30000','4100')
,('HD024','NV002',NULL,'2024-05-04 23:36:01','18900','20000','1100')
,('HD025','NV002',NULL,'2024-05-05 11:35:00','35700','40000','4300')
,('HD026','NV002','00001','2024-05-05 11:36:19','35700','40000','4300')
,('HD027','NV002',NULL,'2024-05-05 12:00:48','48300','60000','11700')
,('HD028','NV002',NULL,'2024-05-06 14:15:50','227500','250000','22500')
,('HD029','NV002',NULL,'2024-05-08 11:36:40','39900','40000','100')
,('HD030','NV002',NULL,'2024-05-08 19:40:48','10500','11000','500')




--ADD DATA CHITIETHOADONBANHANG
INSERT INTO CHITIETHOADONBANHANG (MaHD, MaSP, MaKM,SoLuong, DonGia, ThanhTien) VALUES
('HD001','SP003',null,4,25000,100000)
,('HD001','SP020',null,5,20000,100000)
,('HD002','SP002',null,2,12000,24000)
,('HD003','SP002', 'KMTEST',4,7000,19600)
,('HD003','SP004',null,4,7000,28000)
,('HD004','SP006',null,3,150000,450000)
,('HD004','SP008', 'KMTEST',1,2345,1642)
,('HD005','SP008',null,2,250000,500000)
,('HD006','SP010',null,3,25000,75000)
,('HD007','SP012',null,10,7000,70000)
,('HD008','SP014', 'KMQK23',4,10000,32000)
,('HD009','SP016',null,1,300000,300000)
,('HD015','SP002', 'KMTEST',4,12000,33600)
,('HD015','SP006', 'KMTEST',2,150000,210000)
,('HD016','SP002', 'KMTEST',4,12000,33600)
,('HD016','SP006', 'KMTEST',5,150000,525000)
,('HD016','SP014', 'KMTEST',2,10000,14000)
,('HD017','SP002', 'KMTEST',4,12000,33600)
,('HD017','SP006', 'KMTEST',5,150000,525000)
,('HD017','SP014', 'KMTEST',2,10000,14000)
,('HD018','SP004', 'KMTEST',8,7000,39200)
,('HD018','SP010', 'KMTEST',3,25000,52500)
,('HD018','SP014', 'KMTEST',3,10000,21000)
,('HD019','SP001', 'KMTEST',2,15000,21000)
,('HD019','SP005', 'KMTEST',2,5500000,7700000)
,('HD019','SP012', 'KMTEST',2,7000,9800)
,('HD019','SP016', 'KMTEST',1,300000,210000)
,('HD020','SP003', 'KMTEST',2,25000,35000)
,('HD020','SP007', 'KMTEST',3,200000,420000)
,('HD020','SP009', 'KMTEST',3,350000,735000)
,('HD021','SP002', 'KMTEST',2,12000,16800)
,('HD021','SP004', 'KMTEST',1,7000,4900)
,('HD021','SP011', 'KMTEST',2,40000,56000)
,('HD021','SP014', 'KMTEST',3,10000,21000)
,('HD022','SP001', 'KMTEST',5,15000,52500)
,('HD022','SP003', 'KMTEST',2,25000,35000)
,('HD022','SP020', 'KMTEST',3,20000,42000)
,('HD023','SP002', 'KMTEST',1,12000,8400)
,('HD023','SP003', 'KMTEST',1,25000,17500)
,('HD024','SP001', 'KMTEST',1,15000,10500)
,('HD024','SP002', 'KMTEST',1,12000,8400)
,('HD025','SP001', 'KMTEST',1,15000,10500)
,('HD025','SP002', 'KMTEST',3,12000,25200)
,('HD026','SP001', 'KMTEST',1,15000,10500)
,('HD026','SP002', 'KMTEST',3,12000,25200)
,('HD027','SP001', 'KMTEST',3,15000,31500)
,('HD027','SP002', 'KMTEST',2,12000,16800)
,('HD028','SP003', 'KMTEST',1,25000,17500)
,('HD028','SP006', 'KMTEST',2,150000,210000)
,('HD029','SP003','KMTEST',2,25000,35000)
,('HD029','SP004','KMTEST',1,7000,4900)
,('HD030','SP001', 'KMTEST',1,15000,10500)


--ADD DATA HOADONNHAPKHO
INSERT INTO HOADONNHAPKHO (MaNK, NgayNhapKho, MaNV, MaNCC, TongTien) VALUES
('NK001','2023-05-04 04:50:10','NV001','NCC002',3300000)
,('NK002','2022-10-13 05:21:55','NV002','NCC003',2840000)
,('NK003','2024-01-17 06:00:42','NV003','NCC001',285500000)
,('NK004','2023-05-28 09:59:04','NV004','NCC004',17520000)
,('NK005','2022-11-23 22:14:42','NV005','NCC002',25000000)
,('NK006','2022-11-26 02:25:39','NV006','NCC003',1500000)
,('NK007','2023-11-22 15:35:09','NV007','NCC001',1100000)
,('NK008','2023-08-13 12:16:43','NV008','NCC004',1700000)
,('NK009','2023-12-26 05:29:38','NV009','NCC002',1400000)
,('NK010','2023-12-05 16:35:18','NV010','NCC003',1600000)
,('NK011','2024-05-06 13:54:02','NV002','NCC006',1500000)
,('NK012','2024-05-06 13:54:02','NV002','NCC006',16500000)
,('NK013','2024-05-06 14:08:39','NV002','NCC006',13800000)
,('NK014','2024-05-12 21:55:53','NV002','NCC002',7000)



--ADD DATA CHITIETHOADONNHAPKHO
INSERT INTO CHITIETHOADONNHAPKHO(MaNK, MaSP, NgayHetHan, SoLuong, DonGiaNhap, ThanhTien, TrangThai, SoLuongDaBan) VALUES
('NK001','SP001',NULL,100,10000,1000000,'TRUE',0)
,('NK001','SP002',NULL,150,8000,1200000,'TRUE',0)
,('NK002','SP003',NULL,80,20000,1600000,'TRUE',0)
,('NK002','SP004',NULL,120,5000,600000,'TRUE',0)
,('NK003','SP005',NULL,50,5000000,250000000,'TRUE',0)
,('NK003','SP006',NULL,70,120000,8400000,'TRUE',0)
,('NK004','SP007',NULL,30,150000,4500000,'TRUE',0)
,('NK004','SP008',NULL,45,200000,9000000,'TRUE',0)
,('NK005','SP009',NULL,65,300000,19500000,'TRUE',0)
,('NK005','SP010',NULL,90,20000,1800000,'TRUE',0)
,('NK011','SP006','2024-05-13',10,150000,1500000,'FALSE',0)
,('NK013','SP006',NULL,92,150000,13800000,'TRUE',0)
,('NK014','SP012','2024-05-13',1,7000,7000,'FALSE',0)

