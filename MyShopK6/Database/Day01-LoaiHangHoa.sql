USE [MyShopK6]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 7/13/2019 6:39:17 PM ******/
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
/****** Object:  Table [dbo].[HangHoa]    Script Date: 7/13/2019 6:39:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HangHoa](
	[MaHh] [int] IDENTITY(1,1) NOT NULL,
	[TenHh] [nvarchar](50) NULL,
	[Hinh] [nvarchar](150) NULL,
	[MoTa] [nvarchar](max) NULL,
	[DonGia] [float] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[MaLoai] [int] NOT NULL,
 CONSTRAINT [PK_HangHoa] PRIMARY KEY CLUSTERED 
(
	[MaHh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Loai]    Script Date: 7/13/2019 6:39:17 PM ******/
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
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190713074016_InitDb', N'2.2.4-servicing-10062')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190713092144_AddHangHoa', N'2.2.4-servicing-10062')
SET IDENTITY_INSERT [dbo].[Loai] ON 

INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha]) VALUES (1, N'Điện thoại', N'Điện thoại', NULL, NULL)
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha]) VALUES (2, N'Dòng Phổ thông', N'Dòng Phổ thông', NULL, 1)
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha]) VALUES (3, N'Dòng trung cấp', N'Dòng trung cấp', NULL, 1)
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha]) VALUES (4, N'Dòng cao cấp', N'Dòng cao cấp', NULL, 1)
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha]) VALUES (5, N'Điện máy - Điện lạnh', N'Điện máy - Điện lạnh', NULL, NULL)
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha]) VALUES (6, N'Tivi', N'Tivi', NULL, 5)
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha]) VALUES (7, N'Tủ lạnh', N'Tủ lạnh', NULL, 5)
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha]) VALUES (8, N'Điều hòa', N'Điều hòa', NULL, 5)
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha]) VALUES (9, N'Phụ kiện', N'Phụ kiện', NULL, NULL)
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha]) VALUES (10, N'Phụ kiện laptop', N'Phụ kiện laptop', NULL, 9)
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha]) VALUES (11, N'Sạc dự phòng', N'Sạc dự phòng', NULL, 9)
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha]) VALUES (12, N'Tai nghe bluetooth', N'Tai nghe bluetooth', NULL, 9)
INSERT [dbo].[Loai] ([MaLoai], [TenLoai], [MoTa], [Hinh], [MaLoaiCha]) VALUES (13, N'Tai Hàn', N'Tai Hàn', NULL, 12)
SET IDENTITY_INSERT [dbo].[Loai] OFF
ALTER TABLE [dbo].[HangHoa]  WITH CHECK ADD  CONSTRAINT [FK_HangHoa_Loai_MaLoai] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[Loai] ([MaLoai])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HangHoa] CHECK CONSTRAINT [FK_HangHoa_Loai_MaLoai]
GO
ALTER TABLE [dbo].[Loai]  WITH CHECK ADD  CONSTRAINT [FK_Loai_Loai_MaLoaiCha] FOREIGN KEY([MaLoaiCha])
REFERENCES [dbo].[Loai] ([MaLoai])
GO
ALTER TABLE [dbo].[Loai] CHECK CONSTRAINT [FK_Loai_Loai_MaLoaiCha]
GO
