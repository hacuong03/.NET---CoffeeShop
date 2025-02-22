USE [master]
GO
/****** Object:  Database [QuanLyQuanCafe]    Script Date: 6/3/2024 6:30:34 PM ******/
CREATE DATABASE [QuanLyQuanCafe]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyQuanCafe', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.HATRONGCUONG\MSSQL\DATA\QuanLyQuanCafe.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuanLyQuanCafe_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.HATRONGCUONG\MSSQL\DATA\QuanLyQuanCafe_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [QuanLyQuanCafe] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyQuanCafe].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyQuanCafe] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyQuanCafe] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyQuanCafe] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLyQuanCafe] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyQuanCafe] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyQuanCafe] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyQuanCafe] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyQuanCafe] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyQuanCafe] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLyQuanCafe] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QuanLyQuanCafe] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'QuanLyQuanCafe', N'ON'
GO
ALTER DATABASE [QuanLyQuanCafe] SET QUERY_STORE = ON
GO
ALTER DATABASE [QuanLyQuanCafe] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [QuanLyQuanCafe]
GO
/****** Object:  Table [dbo].[tblChiTietHDB]    Script Date: 6/3/2024 6:30:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChiTietHDB](
	[MaHDB] [nvarchar](50) NOT NULL,
	[MaSP] [nvarchar](10) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[ThanhTien] [float] NOT NULL,
	[KhuyenMai] [float] NOT NULL,
 CONSTRAINT [PK_tblChiTietHDB] PRIMARY KEY CLUSTERED 
(
	[MaHDB] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblHoaDonBan]    Script Date: 6/3/2024 6:30:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHoaDonBan](
	[MaHDB] [nvarchar](50) NOT NULL,
	[NgayBan] [datetime] NOT NULL,
	[MaNV] [nvarchar](10) NOT NULL,
	[MaKH] [nvarchar](10) NOT NULL,
	[TongTien] [float] NOT NULL,
 CONSTRAINT [PK_tblHoaDonBan] PRIMARY KEY CLUSTERED 
(
	[MaHDB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblSanPham]    Script Date: 6/3/2024 6:30:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSanPham](
	[MaSP] [nvarchar](10) NOT NULL,
	[TenSP] [nvarchar](50) NOT NULL,
	[MaLoai] [nvarchar](10) NOT NULL,
	[GiaNhap] [float] NOT NULL,
	[GiaBan] [float] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[MaCongDung] [nvarchar](10) NOT NULL,
	[HinhAnh] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_tblSanPham] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[tblDoanhThu]    Script Date: 6/3/2024 6:30:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[tblDoanhThu]
AS
SELECT HDB.NgayBan, SP.TenSP, SUM(CTHDB.SoLuong) AS SoLuongBan, SP.GiaBan AS GiaSanPham, SUM(CTHDB.SoLuong * SP.GiaBan) AS DoanhThuSanPham
FROM     dbo.tblHoaDonBan AS HDB INNER JOIN
                  dbo.tblChiTietHDB AS CTHDB ON HDB.MaHDB = CTHDB.MaHDB INNER JOIN
                  dbo.tblSanPham AS SP ON CTHDB.MaSP = SP.MaSP
GROUP BY HDB.NgayBan, SP.TenSP, SP.GiaBan
GO
/****** Object:  Table [dbo].[tblChiTietHDN]    Script Date: 6/3/2024 6:30:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChiTietHDN](
	[MaHDN] [nvarchar](50) NOT NULL,
	[MaSP] [nvarchar](10) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[DonGia] [float] NOT NULL,
	[ThanhTien] [float] NOT NULL,
	[ChietKhau] [float] NOT NULL,
 CONSTRAINT [PK_tblChiTietHDN] PRIMARY KEY CLUSTERED 
(
	[MaHDN] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblCongDung]    Script Date: 6/3/2024 6:30:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCongDung](
	[MaCongDung] [nvarchar](10) NOT NULL,
	[TenCongDung] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblCongDung] PRIMARY KEY CLUSTERED 
(
	[MaCongDung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblHoaDonNhap]    Script Date: 6/3/2024 6:30:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHoaDonNhap](
	[MaHDN] [nvarchar](50) NOT NULL,
	[NgayNhap] [datetime] NOT NULL,
	[MaNV] [nvarchar](10) NOT NULL,
	[MaNCC] [nvarchar](10) NOT NULL,
	[TongTien] [float] NOT NULL,
 CONSTRAINT [PK_tblHoaDonNhap] PRIMARY KEY CLUSTERED 
(
	[MaHDN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblKhachHang]    Script Date: 6/3/2024 6:30:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblKhachHang](
	[MaKH] [nvarchar](10) NOT NULL,
	[TenKH] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](200) NOT NULL,
	[SDT] [nvarchar](15) NOT NULL,
 CONSTRAINT [PK_tblKhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblLoai]    Script Date: 6/3/2024 6:30:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLoai](
	[MaLoai] [nvarchar](10) NOT NULL,
	[TenLoai] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblLoai] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblNhaCungCap]    Script Date: 6/3/2024 6:30:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNhaCungCap](
	[MaNCC] [nvarchar](10) NOT NULL,
	[TenNCC] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](200) NOT NULL,
	[SDT] [nvarchar](15) NOT NULL,
 CONSTRAINT [PK_tblNhaCungCap] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblNhanVien]    Script Date: 6/3/2024 6:30:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNhanVien](
	[MaNV] [nvarchar](10) NOT NULL,
	[TenNV] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](200) NOT NULL,
	[GioiTinh] [nvarchar](10) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[MaQue] [nvarchar](10) NOT NULL,
	[SDT] [nvarchar](15) NOT NULL,
 CONSTRAINT [PK_tblNhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblQue]    Script Date: 6/3/2024 6:30:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblQue](
	[MaQue] [nvarchar](10) NOT NULL,
	[TenQue] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblQue] PRIMARY KEY CLUSTERED 
(
	[MaQue] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tblChiTietHDB]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietHDB_tblHoaDonBan] FOREIGN KEY([MaHDB])
REFERENCES [dbo].[tblHoaDonBan] ([MaHDB])
GO
ALTER TABLE [dbo].[tblChiTietHDB] CHECK CONSTRAINT [FK_tblChiTietHDB_tblHoaDonBan]
GO
ALTER TABLE [dbo].[tblChiTietHDB]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietHDB_tblSanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[tblSanPham] ([MaSP])
GO
ALTER TABLE [dbo].[tblChiTietHDB] CHECK CONSTRAINT [FK_tblChiTietHDB_tblSanPham]
GO
ALTER TABLE [dbo].[tblChiTietHDN]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietHDN_tblHoaDonNhap] FOREIGN KEY([MaHDN])
REFERENCES [dbo].[tblHoaDonNhap] ([MaHDN])
GO
ALTER TABLE [dbo].[tblChiTietHDN] CHECK CONSTRAINT [FK_tblChiTietHDN_tblHoaDonNhap]
GO
ALTER TABLE [dbo].[tblChiTietHDN]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietHDN_tblSanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[tblSanPham] ([MaSP])
GO
ALTER TABLE [dbo].[tblChiTietHDN] CHECK CONSTRAINT [FK_tblChiTietHDN_tblSanPham]
GO
ALTER TABLE [dbo].[tblHoaDonBan]  WITH CHECK ADD  CONSTRAINT [FK_tblHoaDonBan_tblKhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[tblKhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[tblHoaDonBan] CHECK CONSTRAINT [FK_tblHoaDonBan_tblKhachHang]
GO
ALTER TABLE [dbo].[tblHoaDonBan]  WITH CHECK ADD  CONSTRAINT [FK_tblHoaDonBan_tblNhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[tblNhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[tblHoaDonBan] CHECK CONSTRAINT [FK_tblHoaDonBan_tblNhanVien]
GO
ALTER TABLE [dbo].[tblHoaDonNhap]  WITH CHECK ADD  CONSTRAINT [FK_tblHoaDonNhap_tblNhaCungCap] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[tblNhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[tblHoaDonNhap] CHECK CONSTRAINT [FK_tblHoaDonNhap_tblNhaCungCap]
GO
ALTER TABLE [dbo].[tblHoaDonNhap]  WITH CHECK ADD  CONSTRAINT [FK_tblHoaDonNhap_tblNhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[tblNhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[tblHoaDonNhap] CHECK CONSTRAINT [FK_tblHoaDonNhap_tblNhanVien]
GO
ALTER TABLE [dbo].[tblNhanVien]  WITH CHECK ADD  CONSTRAINT [FK_tblNhanVien_tblQue] FOREIGN KEY([MaQue])
REFERENCES [dbo].[tblQue] ([MaQue])
GO
ALTER TABLE [dbo].[tblNhanVien] CHECK CONSTRAINT [FK_tblNhanVien_tblQue]
GO
ALTER TABLE [dbo].[tblSanPham]  WITH CHECK ADD  CONSTRAINT [FK_tblSanPham_tblCongDung] FOREIGN KEY([MaCongDung])
REFERENCES [dbo].[tblCongDung] ([MaCongDung])
GO
ALTER TABLE [dbo].[tblSanPham] CHECK CONSTRAINT [FK_tblSanPham_tblCongDung]
GO
ALTER TABLE [dbo].[tblSanPham]  WITH CHECK ADD  CONSTRAINT [FK_tblSanPham_tblLoai] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[tblLoai] ([MaLoai])
GO
ALTER TABLE [dbo].[tblSanPham] CHECK CONSTRAINT [FK_tblSanPham_tblLoai]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = -120
         Left = 0
      End
      Begin Tables = 
         Begin Table = "HDB"
            Begin Extent = 
               Top = 247
               Left = 48
               Bottom = 410
               Right = 258
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "CTHDB"
            Begin Extent = 
               Top = 247
               Left = 306
               Bottom = 410
               Right = 516
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "SP"
            Begin Extent = 
               Top = 247
               Left = 564
               Bottom = 410
               Right = 774
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'tblDoanhThu'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'tblDoanhThu'
GO
USE [master]
GO
ALTER DATABASE [QuanLyQuanCafe] SET  READ_WRITE 
GO
