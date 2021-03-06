USE [MyShopK6]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 7/14/2019 7:10:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HangHoa]    Script Date: 7/14/2019 7:10:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HangHoa](
	[MaHh] [int] IDENTITY(1,1) NOT NULL,
	[TenHh] [nvarchar](150) NOT NULL,
	[Hinh] [nvarchar](150) NULL,
	[MoTa] [nvarchar](max) NULL,
	[DonGia] [float] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[MaLoai] [int] NOT NULL,
	[MaTh] [nvarchar](50) NULL,
 CONSTRAINT [PK_HangHoa] PRIMARY KEY CLUSTERED 
(
	[MaHh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Loai]    Script Date: 7/14/2019 7:10:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Loai](
	[MaLoai] [int] IDENTITY(1,1) NOT NULL,
	[TenLoai] [nvarchar](50) NULL,
	[MoTa] [nvarchar](max) NULL,
	[Hinh] [nvarchar](150) NULL,
	[MaLoaiCha] [int] NULL,
 CONSTRAINT [PK_Loai] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThuongHieu]    Script Date: 7/14/2019 7:10:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThuongHieu](
	[MaTh] [nvarchar](50) NOT NULL,
	[TenThuongHieu] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](150) NULL,
	[DienThoai] [nvarchar](50) NULL,
	[Logo] [nvarchar](150) NULL,
 CONSTRAINT [PK_ThuongHieu] PRIMARY KEY CLUSTERED 
(
	[MaTh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190713074016_InitDb', N'2.2.4-servicing-10062')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190713092144_AddHangHoa', N'2.2.4-servicing-10062')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190714113827_ThuongHieu', N'2.2.3-servicing-35854')
SET IDENTITY_INSERT [dbo].[HangHoa] ON 

INSERT [dbo].[HangHoa] ([MaHh], [TenHh], [Hinh], [MoTa], [DonGia], [SoLuong], [MaLoai], [MaTh]) VALUES (1, N'Sony 40inch', N'_636986977754681622kdl-40w660e_4.jpg', N'Sony', 7999000, 13, 6, N'SONY')
INSERT [dbo].[HangHoa] ([MaHh], [TenHh], [Hinh], [MoTa], [DonGia], [SoLuong], [MaLoai], [MaTh]) VALUES (2, N'Panel 21inc', N'_63698700657292796331EPGSm2s1L._SL500_AA300_.jpg', N'Panel 21"', 198600, 12, 10, N'SONY')
INSERT [dbo].[HangHoa] ([MaHh], [TenHh], [Hinh], [MoTa], [DonGia], [SoLuong], [MaLoai], [MaTh]) VALUES (3, N'Keyboard', N'_63698700723774209141G38jC0ajL._SL500_AA300_.jpg', N'Keyboard', 15900, 12, 2, N'DELL')
INSERT [dbo].[HangHoa] ([MaHh], [TenHh], [Hinh], [MoTa], [DonGia], [SoLuong], [MaLoai], [MaTh]) VALUES (4, N'Nhẫn bạc đính đá PNJSilver Friendzone Breaker', N'_636987252803176521nhan-bac-pnjsilver-friendzone-breaker-dinh-da.png', N'<h3 class="tab-list-title" id="features" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); margin: 10px 0px 8px; padding-bottom: 8px; border-bottom: none; font-size: 18px; font-family: Roboto, sans-serif; text-transform: uppercase; padding-top: 10px; color: rgb(40, 40, 40);">HÔNG SỐ</h3><div id="content_features" class="ty-wysiwyg-content content-features" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); font-family: Roboto, sans-serif; overflow-wrap: break-word;"><div class="ty-product-feature" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); font-size: 14px; color: rgb(40, 40, 40); display: inline-flex; margin-bottom: 10px; padding-bottom: 10px; width: 870px; border-bottom: 1px solid rgb(221, 221, 221);"><span class="ty-product-feature__label" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); width: 258px; padding-right: 5px;">Thương hiệu:</span><div class="ty-product-feature__value" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); width: 602px; padding-left: 5px; max-width: 70%;">PNJSilver</div></div><div class="ty-product-feature" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); font-size: 14px; color: rgb(40, 40, 40); display: inline-flex; margin-bottom: 10px; padding-bottom: 10px; width: 870px; border-bottom: 1px solid rgb(221, 221, 221);"><span class="ty-product-feature__label" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); width: 258px; padding-right: 5px;">Bộ sưu tập:</span><div class="ty-product-feature__value" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); width: 602px; padding-left: 5px; max-width: 70%;">Friendzone Breaker</div></div><div class="ty-product-feature" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); font-size: 14px; color: rgb(40, 40, 40); display: inline-flex; margin-bottom: 10px; padding-bottom: 10px; width: 870px; border-bottom: 1px solid rgb(221, 221, 221);"><span class="ty-product-feature__label" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); width: 258px; padding-right: 5px;">Loại đá chính:</span><div class="ty-product-feature__value" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); width: 602px; padding-left: 5px; max-width: 70%;">CZ</div></div><div class="ty-product-feature" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); font-size: 14px; color: rgb(40, 40, 40); display: inline-flex; margin-bottom: 10px; padding-bottom: 10px; width: 870px; border-bottom: 1px solid rgb(221, 221, 221);"><span class="ty-product-feature__label" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); width: 258px; padding-right: 5px;">Màu đá chính:</span><div class="ty-product-feature__value" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); width: 602px; padding-left: 5px; max-width: 70%;">Trắng</div></div><div class="ty-product-feature" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); font-size: 14px; color: rgb(40, 40, 40); display: inline-flex; margin-bottom: 10px; padding-bottom: 10px; width: 870px; border-bottom: 1px solid rgb(221, 221, 221);"><span class="ty-product-feature__label" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); width: 258px; padding-right: 5px;">Hình dạng đá:</span><div class="ty-product-feature__value" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); width: 602px; padding-left: 5px; max-width: 70%;">Tròn</div></div><div class="ty-product-feature" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); font-size: 14px; color: rgb(40, 40, 40); display: inline-flex; margin-bottom: 10px; padding-bottom: 10px; width: 870px; border-bottom: 1px solid rgb(221, 221, 221);"><span class="ty-product-feature__label" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); width: 258px; padding-right: 5px;">Giới tính:</span><div class="ty-product-feature__value" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); width: 602px; padding-left: 5px; max-width: 70%;">Nữ</div></div><div class="ty-product-feature" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); font-size: 14px; color: rgb(40, 40, 40); display: inline-flex; margin-bottom: 10px; padding-bottom: 10px; width: 870px; border-bottom: 1px solid rgb(221, 221, 221);"><span class="ty-product-feature__label" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); width: 258px; padding-right: 5px;">Dịp tặng quà:</span><div class="ty-product-feature__value" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); width: 602px; padding-left: 5px; max-width: 70%;"><ul class="ty-product-feature__multiple" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); padding: 0px; margin-right: 0px; margin-bottom: 0px; margin-left: 0px; list-style: none;"><li class="ty-product-feature__multiple-item" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); margin: 0px; padding: 2px 0px; list-style-type: inherit; list-style-position: initial; list-style-image: initial;"><span class="ty-product-feature__prefix" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0);"></span>Tình yêu<span class="ty-product-feature__suffix" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0);"></span></li></ul></div></div><div class="ty-product-feature" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); font-size: 14px; color: rgb(40, 40, 40); display: inline-flex; margin-bottom: 10px; padding-bottom: 10px; width: 870px; border-bottom: 1px solid rgb(221, 221, 221);"><span class="ty-product-feature__label" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); width: 258px; padding-right: 5px;">Quà tặng cho người thân:</span><div class="ty-product-feature__value" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); width: 602px; padding-left: 5px; max-width: 70%;"><ul class="ty-product-feature__multiple" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); padding: 0px; margin-right: 0px; margin-bottom: 0px; margin-left: 0px; list-style: none;"><li class="ty-product-feature__multiple-item" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); margin: 0px; padding: 2px 0px; list-style-type: inherit; list-style-position: initial; list-style-image: initial;"><span class="ty-product-feature__prefix" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0);"></span>Cho Nàng</li></ul></div></div></div>', 412000, 111, 23, N'PNJ')
INSERT [dbo].[HangHoa] ([MaHh], [TenHh], [Hinh], [MoTa], [DonGia], [SoLuong], [MaLoai], [MaTh]) VALUES (5, N'Nhẫn nam bạc đính đá PNJSilver', N'_636987274838193690nhan-bac-nam-pnjsilver-dinh-da.png', N'<p>Thương hiệu:</p><p>PNJSilver</p><p>Loại đá chính:</p><p>CZ</p><p>Màu đá chính:</p><p>Trắng</p><p>Hình dạng đá:</p><p>Tròn</p><p>Giới tính:</p><p>Nam</p><p>Dịp tặng quà:</p><ul><li>Sinh nhật</li><li>Tình yêu</li><li>Ngày kỷ niệm</li></ul><p>Quà tặng cho người thân:</p><ul><li>Cho Chàng</li></ul><p>Chủng loại:</p><p>Nhẫn</p>', 655000, 3, 23, N'PNJ')
INSERT [dbo].[HangHoa] ([MaHh], [TenHh], [Hinh], [MoTa], [DonGia], [SoLuong], [MaLoai], [MaTh]) VALUES (6, N'Nhẫn Vàng 18K đính ngọc trai South Sea PNJ Dáng Ngọc', N'_636987277827884859nhan-pnj-dang-ngoc-vang-18k-dinh-ngoc-trai-south-sea.png', N'<div class="ty-product-feature" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); font-family: Roboto, sans-serif; font-size: 14px; color: rgb(40, 40, 40); display: inline-flex; margin-bottom: 10px; padding-bottom: 10px; width: 870px; border-bottom: 1px solid rgb(221, 221, 221);"><span class="ty-product-feature__label" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); width: 258px; padding-right: 5px;">Thương hiệu:</span><div class="ty-product-feature__value" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); width: 602px; padding-left: 5px; max-width: 70%;">PNJ</div></div><div class="ty-product-feature" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); font-family: Roboto, sans-serif; font-size: 14px; color: rgb(40, 40, 40); display: inline-flex; margin-bottom: 10px; padding-bottom: 10px; width: 870px; border-bottom: 1px solid rgb(221, 221, 221);"><span class="ty-product-feature__label" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); width: 258px; padding-right: 5px;">Bộ sưu tập:</span><div class="ty-product-feature__value" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); width: 602px; padding-left: 5px; max-width: 70%;">Dáng Ngọc</div></div><div class="ty-product-feature" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); font-family: Roboto, sans-serif; font-size: 14px; color: rgb(40, 40, 40); display: inline-flex; margin-bottom: 10px; padding-bottom: 10px; width: 870px; border-bottom: 1px solid rgb(221, 221, 221);"><span class="ty-product-feature__label" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); width: 258px; padding-right: 5px;">Loại đá chính:</span><div class="ty-product-feature__value" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); width: 602px; padding-left: 5px; max-width: 70%;">Ngọc trai</div></div><div class="ty-product-feature" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); font-family: Roboto, sans-serif; font-size: 14px; color: rgb(40, 40, 40); display: inline-flex; margin-bottom: 10px; padding-bottom: 10px; width: 870px; border-bottom: 1px solid rgb(221, 221, 221);"><span class="ty-product-feature__label" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); width: 258px; padding-right: 5px;">Màu đá chính:</span><div class="ty-product-feature__value" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); width: 602px; padding-left: 5px; max-width: 70%;">Vàng</div></div><div class="ty-product-feature" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); font-family: Roboto, sans-serif; font-size: 14px; color: rgb(40, 40, 40); display: inline-flex; margin-bottom: 10px; padding-bottom: 10px; width: 870px; border-bottom: 1px solid rgb(221, 221, 221);"><span class="ty-product-feature__label" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); width: 258px; padding-right: 5px;">Hình dạng đá:</span><div class="ty-product-feature__value" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); width: 602px; padding-left: 5px; max-width: 70%;">Tròn</div></div><div class="ty-product-feature" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); font-family: Roboto, sans-serif; font-size: 14px; color: rgb(40, 40, 40); display: inline-flex; margin-bottom: 10px; padding-bottom: 10px; width: 870px; border-bottom: 1px solid rgb(221, 221, 221);"><span class="ty-product-feature__label" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); width: 258px; padding-right: 5px;">Loại đá phụ (nếu có):</span><div class="ty-product-feature__value" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); width: 602px; padding-left: 5px; max-width: 70%;">Kim cương</div></div><div class="ty-product-feature" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); font-family: Roboto, sans-serif; font-size: 14px; color: rgb(40, 40, 40); display: inline-flex; margin-bottom: 10px; padding-bottom: 10px; width: 870px; border-bottom: 1px solid rgb(221, 221, 221);"><span class="ty-product-feature__label" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); width: 258px; padding-right: 5px;">Màu đá phụ (nếu có):</span><div class="ty-product-feature__value" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); width: 602px; padding-left: 5px; max-width: 70%;">Trắng</div></div><div class="ty-product-feature" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); font-family: Roboto, sans-serif; font-size: 14px; color: rgb(40, 40, 40); display: inline-flex; margin-bottom: 10px; padding-bottom: 10px; width: 870px; border-bottom: 1px solid rgb(221, 221, 221);"><span class="ty-product-feature__label" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); width: 258px; padding-right: 5px;">Giới tính:</span><div class="ty-product-feature__value" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); width: 602px; padding-left: 5px; max-width: 70%;">Nữ</div></div><div class="ty-product-feature" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); font-family: Roboto, sans-serif; font-size: 14px; color: rgb(40, 40, 40); display: inline-flex; margin-bottom: 10px; padding-bottom: 10px; width: 870px; border-bottom: 1px solid rgb(221, 221, 221);"><span class="ty-product-feature__label" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); width: 258px; padding-right: 5px;">Quà tặng cho người thân:</span><div class="ty-product-feature__value" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); width: 602px; padding-left: 5px; max-width: 70%;"><ul class="ty-product-feature__multiple" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); padding: 0px; margin-right: 0px; margin-bottom: 0px; margin-left: 0px; list-style: none;"><li class="ty-product-feature__multiple-item" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); margin: 0px; padding: 2px 0px; list-style-type: inherit; list-style-position: initial; list-style-image: initial;"><span class="ty-product-feature__prefix" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0);"></span>Cho Nàng<span class="ty-product-feature__suffix" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0);"></span></li><li class="ty-product-feature__multiple-item" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); margin: 0px; padding: 2px 0px; list-style-type: inherit; list-style-position: initial; list-style-image: initial;"><span class="ty-product-feature__prefix" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0);"></span>Cho Mẹ<span class="ty-product-feature__suffix" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0);"></span></li></ul></div></div><div class="ty-product-feature" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); font-family: Roboto, sans-serif; font-size: 14px; color: rgb(40, 40, 40); display: inline-flex; margin-bottom: 10px; padding-bottom: 10px; width: 870px; border-bottom: 1px solid rgb(221, 221, 221);"><span class="ty-product-feature__label" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); width: 258px; padding-right: 5px;">Kích thước đá:</span><div class="ty-product-feature__value" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); width: 602px; padding-left: 5px; max-width: 70%;">10.5 ly</div></div><div class="ty-product-feature" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); font-family: Roboto, sans-serif; font-size: 14px; color: rgb(40, 40, 40); display: inline-flex; margin-bottom: 10px; padding-bottom: 10px; width: 870px; border-bottom: 1px solid rgb(221, 221, 221);"><span class="ty-product-feature__label" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); width: 258px; padding-right: 5px;">Loại ngọc trai:</span><div class="ty-product-feature__value" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); width: 602px; padding-left: 5px; max-width: 70%;">South Sea</div></div><div class="ty-product-feature" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); font-family: Roboto, sans-serif; font-size: 14px; color: rgb(40, 40, 40); display: inline-flex; margin-bottom: 10px; padding-bottom: 10px; width: 870px; border-bottom: 1px solid rgb(221, 221, 221);"><span class="ty-product-feature__label" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); width: 258px; padding-right: 5px;">Chủng loại:</span><div class="ty-product-feature__value" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); width: 602px; padding-left: 5px; max-width: 70%;">Nhẫn</div></div><div class="ty-product-feature" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); font-family: Roboto, sans-serif; font-size: 14px; color: rgb(40, 40, 40); display: inline-flex; margin-bottom: 10px; padding-bottom: 10px; width: 870px; border-bottom: 1px solid rgb(221, 221, 221);"><span class="ty-product-feature__label" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); width: 258px; padding-right: 5px;">Tuổi vàng:</span><div class="ty-product-feature__value" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); width: 602px; padding-left: 5px; max-width: 70%;">Vàng 18K</div></div><p><span style="font-family: Roboto, sans-serif;"></span><span style="font-family: Roboto, sans-serif;"></span><span style="font-family: Roboto, sans-serif;"></span><span style="font-family: Roboto, sans-serif;"></span><span style="font-family: Roboto, sans-serif;"></span><span style="font-family: Roboto, sans-serif;"></span><span style="font-family: Roboto, sans-serif;"></span><span style="font-family: Roboto, sans-serif;"></span><span style="font-family: Roboto, sans-serif;"></span><span style="font-family: Roboto, sans-serif;"></span><span style="font-family: Roboto, sans-serif;"></span><span style="font-family: Roboto, sans-serif;"></span><span style="font-family: Roboto, sans-serif;"></span></p><div class="ty-product-feature" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); font-family: Roboto, sans-serif; font-size: 14px; color: rgb(40, 40, 40); display: inline-flex; margin-bottom: 10px; padding-bottom: 10px; width: 870px; border-bottom: 1px solid rgb(221, 221, 221);"><span class="ty-product-feature__label" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); width: 258px; padding-right: 5px;">Trọng lượng vàng tham khảo (phân vàng):</span><div class="ty-product-feature__value" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); width: 602px; padding-left: 5px; max-width: 70%;">8.59500</div></div>', 25485000, 11, 23, N'PNJ')
INSERT [dbo].[HangHoa] ([MaHh], [TenHh], [Hinh], [MoTa], [DonGia], [SoLuong], [MaLoai], [MaTh]) VALUES (7, N'Nhẫn nam Kim cương Vàng 18K PNJ', N'_636987278901979465nhan-nam-kim-cuong-vang-18k.png', NULL, 35345000, 11, 23, N'PNJ')
SET IDENTITY_INSERT [dbo].[HangHoa] OFF
SET IDENTITY_INSERT [dbo].[Loai] ON 

INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha]) VALUES (1, N'Điện thoại/Laptop/Tablet', N'Điện thoại/Laptop/Tablet', NULL, NULL)
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha]) VALUES (2, N'Điện thoại', N'Điện thoại', NULL, 1)
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha]) VALUES (3, N'Laptop', N'Laptop', NULL, 1)
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha]) VALUES (4, N'Tablet', N'Tablet', NULL, 1)
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha]) VALUES (5, N'Điện máy - Điện lạnh', N'Điện máy - Điện lạnh', NULL, NULL)
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha]) VALUES (6, N'Tivi', N'Tivi', NULL, 5)
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha]) VALUES (7, N'Tủ lạnh', N'Tủ lạnh', NULL, 5)
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha]) VALUES (8, N'Điều hòa', N'Điều hòa', NULL, 5)
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha]) VALUES (9, N'Phụ kiện', N'Phụ kiện', NULL, NULL)
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha]) VALUES (10, N'USB', N'USB', NULL, 9)
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha]) VALUES (11, N'Sạc dự phòng', N'Sạc dự phòng', NULL, 9)
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha]) VALUES (12, N'Tai nghe bluetooth', N'Tai nghe bluetooth', NULL, 9)
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha]) VALUES (13, N'Chuột', N'Chuột', NULL, 9)
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha]) VALUES (14, N'Cáp', N'Cáp', NULL, 9)
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha]) VALUES (15, N'Đồng hồ', N'Đồng hồ', NULL, NULL)
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha]) VALUES (16, N'Đồng hồ Thông minh', N'Đồng hồ Thông minh', NULL, 15)
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha]) VALUES (17, N'Đồng hồ Thời trang', N'Đồng hồ Thời trang', NULL, 15)
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha]) VALUES (18, N'Vali/Ba lô/Túi xách', N'Vali/Ba lô/Túi xách', NULL, NULL)
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha]) VALUES (19, N'Vali', N'Vali', NULL, 18)
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha]) VALUES (20, N'Ba lô', N'Ba lô', NULL, 18)
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha]) VALUES (21, N'Túi xách', N'Túi xách', NULL, 18)
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha]) VALUES (22, N'Trang sức', N'Trang sức', NULL, NULL)
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha]) VALUES (23, N'Nhẫn', N'Nhẫn', NULL, 22)
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha]) VALUES (24, N'Dây chuyền', N'Dây chuyền', NULL, 22)
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha]) VALUES (25, N'Kim cương', N'Kim cương', NULL, 22)
SET IDENTITY_INSERT [dbo].[Loai] OFF
INSERT [dbo].[ThuongHieu] ([MaTh], [TenThuongHieu], [DiaChi], [DienThoai], [Logo]) VALUES (N'AP', N'Apple', NULL, NULL, N'apple.jpg')
INSERT [dbo].[ThuongHieu] ([MaTh], [TenThuongHieu], [DiaChi], [DienThoai], [Logo]) VALUES (N'DELL', N'DELL', NULL, NULL, N'dell-logo.jpg')
INSERT [dbo].[ThuongHieu] ([MaTh], [TenThuongHieu], [DiaChi], [DienThoai], [Logo]) VALUES (N'MO', N'Motorola', NULL, NULL, N'motorola.jpg')
INSERT [dbo].[ThuongHieu] ([MaTh], [TenThuongHieu], [DiaChi], [DienThoai], [Logo]) VALUES (N'NK', N'Nokia', NULL, NULL, N'nokia.jpg')
INSERT [dbo].[ThuongHieu] ([MaTh], [TenThuongHieu], [DiaChi], [DienThoai], [Logo]) VALUES (N'PNJ', N'Vàng bạc đá quý Phú Nhuận', N'70E Phan Đăng Lưu, P.3, Q.Phú Nhuận, TP.Hồ Chí Minh', N'028 3995 1703', N'pnj.com.vn.png')
INSERT [dbo].[ThuongHieu] ([MaTh], [TenThuongHieu], [DiaChi], [DienThoai], [Logo]) VALUES (N'SJC', N'Vàng bạc đá quý Sài Gòn', N'418-420 Nguyễn Thị Minh Khai, P5, Q3, Tp HCM', N'+84 28.39293388', N'sjc.png')
INSERT [dbo].[ThuongHieu] ([MaTh], [TenThuongHieu], [DiaChi], [DienThoai], [Logo]) VALUES (N'SONY', N'SONY', NULL, NULL, N'logo_sony.png')
INSERT [dbo].[ThuongHieu] ([MaTh], [TenThuongHieu], [DiaChi], [DienThoai], [Logo]) VALUES (N'SS', N'Samsung', NULL, NULL, N'samsung.jpg')
ALTER TABLE [dbo].[HangHoa]  WITH CHECK ADD  CONSTRAINT [FK_HangHoa_Loai_MaLoai] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[Loai] ([MaLoai])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HangHoa] CHECK CONSTRAINT [FK_HangHoa_Loai_MaLoai]
GO
ALTER TABLE [dbo].[HangHoa]  WITH CHECK ADD  CONSTRAINT [FK_HangHoa_ThuongHieu_MaTh] FOREIGN KEY([MaTh])
REFERENCES [dbo].[ThuongHieu] ([MaTh])
GO
ALTER TABLE [dbo].[HangHoa] CHECK CONSTRAINT [FK_HangHoa_ThuongHieu_MaTh]
GO
ALTER TABLE [dbo].[Loai]  WITH CHECK ADD  CONSTRAINT [FK_Loai_Loai_MaLoaiCha] FOREIGN KEY([MaLoaiCha])
REFERENCES [dbo].[Loai] ([MaLoai])
GO
ALTER TABLE [dbo].[Loai] CHECK CONSTRAINT [FK_Loai_Loai_MaLoaiCha]
GO
