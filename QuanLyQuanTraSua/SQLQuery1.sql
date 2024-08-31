USE [master]
GO
/****** Object:  Database [QuanLyQuanTraSua]    Script Date: 17/07/2023 11:07:58 SA ******/
CREATE DATABASE [QuanLyQuanTraSua]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyQuanTraSua', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.PHANHUY\MSSQL\DATA\QuanLyQuanTraSua.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuanLyQuanTraSua_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.PHANHUY\MSSQL\DATA\QuanLyQuanTraSua_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QuanLyQuanTraSua] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyQuanTraSua].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyQuanTraSua] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyQuanTraSua] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyQuanTraSua] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyQuanTraSua] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyQuanTraSua] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyQuanTraSua] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QuanLyQuanTraSua] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyQuanTraSua] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyQuanTraSua] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyQuanTraSua] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyQuanTraSua] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyQuanTraSua] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyQuanTraSua] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyQuanTraSua] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyQuanTraSua] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QuanLyQuanTraSua] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyQuanTraSua] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyQuanTraSua] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyQuanTraSua] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyQuanTraSua] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyQuanTraSua] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyQuanTraSua] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyQuanTraSua] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyQuanTraSua] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyQuanTraSua] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyQuanTraSua] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyQuanTraSua] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyQuanTraSua] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLyQuanTraSua] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QuanLyQuanTraSua] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [QuanLyQuanTraSua] SET QUERY_STORE = OFF
GO
USE [QuanLyQuanTraSua]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 17/07/2023 11:07:58 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[user_Name] [nvarchar](300) NOT NULL,
	[display_Name] [nvarchar](300) NOT NULL,
	[password] [nvarchar](100) NOT NULL,
	[id_Role] [int] NOT NULL,
	[salary] [float] NULL,
	[image] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[user_Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bill]    Script Date: 17/07/2023 11:07:58 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
	[id_Bill] [int] IDENTITY(1,1) NOT NULL,
	[date_CheckIn] [date] NOT NULL,
	[date_CheckOut] [date] NOT NULL,
	[id_Table] [int] NOT NULL,
	[status] [bit] NOT NULL,
	[discount] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Bill] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BillInformation]    Script Date: 17/07/2023 11:07:58 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillInformation](
	[id_Bill_Infor] [int] IDENTITY(1,1) NOT NULL,
	[id_Bill] [int] NOT NULL,
	[id_Food] [int] NOT NULL,
	[quanlity] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Bill_Infor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Food]    Script Date: 17/07/2023 11:07:58 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Food](
	[id_Food] [int] IDENTITY(1,1) NOT NULL,
	[name_Food] [nvarchar](200) NOT NULL,
	[id_Category] [int] NOT NULL,
	[price_Food] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Food] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FoodCategory]    Script Date: 17/07/2023 11:07:58 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FoodCategory](
	[id_Category] [int] IDENTITY(1,1) NOT NULL,
	[name_Category] [nvarchar](300) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Category] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RoleAccount]    Script Date: 17/07/2023 11:07:58 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoleAccount](
	[id_Role] [int] NOT NULL,
	[name_Role] [nvarchar](200) NULL,
	[description] [nvarchar](400) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Role] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TableFood]    Script Date: 17/07/2023 11:07:58 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TableFood](
	[id_Table] [int] IDENTITY(1,1) NOT NULL,
	[name_Table] [nvarchar](300) NULL,
	[status] [bit] NULL,
	[maximun_People] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Table] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Account] ([user_Name], [display_Name], [password], [id_Role], [salary], [image]) VALUES (N'phanhao.com', N'Phan Anh Hao1', N'3244185981728979115075721453575112', 0, 100000, N'D:\KI 5\PRN211\ProjectQuanliQuanTraSua\QuanLyQuanTraSua\bin\Debug\net6.0-windows\Image\defaultimage.jpg')
GO
INSERT [dbo].[Account] ([user_Name], [display_Name], [password], [id_Role], [salary], [image]) VALUES (N'phanhuy.com', N'Phan Huy', N'3244185981728979115075721453575112', 1, 100000, N'D:\KI 5\PRN211\ProjectQuanliQuanTraSua\QuanLyQuanTraSua\bin\Debug\net6.0-windows\Image\phanhuy.png')
GO
INSERT [dbo].[Account] ([user_Name], [display_Name], [password], [id_Role], [salary], [image]) VALUES (N'phankien.com', N'Phan Kien', N'123', 1, 4555555, N'D:\KI 5\PRN211\ProjectQuanliQuanTraSua\QuanLyQuanTraSua\bin\Debug\net6.0-windows\/Image/1688796199508.jpg')
GO
SET IDENTITY_INSERT [dbo].[Bill] ON 
GO
INSERT [dbo].[Bill] ([id_Bill], [date_CheckIn], [date_CheckOut], [id_Table], [status], [discount]) VALUES (5, CAST(N'2023-06-26' AS Date), CAST(N'2023-05-26' AS Date), 2, 1, 0)
GO
INSERT [dbo].[Bill] ([id_Bill], [date_CheckIn], [date_CheckOut], [id_Table], [status], [discount]) VALUES (6, CAST(N'2023-06-26' AS Date), CAST(N'2023-05-26' AS Date), 3, 1, 0)
GO
INSERT [dbo].[Bill] ([id_Bill], [date_CheckIn], [date_CheckOut], [id_Table], [status], [discount]) VALUES (7, CAST(N'2023-06-26' AS Date), CAST(N'2023-05-26' AS Date), 4, 1, 0)
GO
INSERT [dbo].[Bill] ([id_Bill], [date_CheckIn], [date_CheckOut], [id_Table], [status], [discount]) VALUES (8, CAST(N'2023-06-26' AS Date), CAST(N'2023-05-26' AS Date), 5, 1, 0)
GO
INSERT [dbo].[Bill] ([id_Bill], [date_CheckIn], [date_CheckOut], [id_Table], [status], [discount]) VALUES (9, CAST(N'2023-06-26' AS Date), CAST(N'2023-05-26' AS Date), 6, 0, 0)
GO
INSERT [dbo].[Bill] ([id_Bill], [date_CheckIn], [date_CheckOut], [id_Table], [status], [discount]) VALUES (10, CAST(N'2023-06-26' AS Date), CAST(N'2023-05-26' AS Date), 6, 0, 0)
GO
INSERT [dbo].[Bill] ([id_Bill], [date_CheckIn], [date_CheckOut], [id_Table], [status], [discount]) VALUES (11, CAST(N'2023-06-30' AS Date), CAST(N'0001-01-01' AS Date), 19, 0, 0)
GO
INSERT [dbo].[Bill] ([id_Bill], [date_CheckIn], [date_CheckOut], [id_Table], [status], [discount]) VALUES (12, CAST(N'2023-06-30' AS Date), CAST(N'0001-01-01' AS Date), 9, 0, 0)
GO
INSERT [dbo].[Bill] ([id_Bill], [date_CheckIn], [date_CheckOut], [id_Table], [status], [discount]) VALUES (16, CAST(N'2023-06-30' AS Date), CAST(N'0001-01-01' AS Date), 10, 0, 0)
GO
INSERT [dbo].[Bill] ([id_Bill], [date_CheckIn], [date_CheckOut], [id_Table], [status], [discount]) VALUES (22, CAST(N'2023-07-01' AS Date), CAST(N'0001-01-01' AS Date), 14, 0, 0)
GO
INSERT [dbo].[Bill] ([id_Bill], [date_CheckIn], [date_CheckOut], [id_Table], [status], [discount]) VALUES (23, CAST(N'2023-07-01' AS Date), CAST(N'0001-01-01' AS Date), 13, 0, 0)
GO
INSERT [dbo].[Bill] ([id_Bill], [date_CheckIn], [date_CheckOut], [id_Table], [status], [discount]) VALUES (24, CAST(N'2023-07-01' AS Date), CAST(N'0001-01-01' AS Date), 2, 1, 0)
GO
INSERT [dbo].[Bill] ([id_Bill], [date_CheckIn], [date_CheckOut], [id_Table], [status], [discount]) VALUES (25, CAST(N'2023-07-05' AS Date), CAST(N'0001-01-01' AS Date), 2, 1, 0)
GO
INSERT [dbo].[Bill] ([id_Bill], [date_CheckIn], [date_CheckOut], [id_Table], [status], [discount]) VALUES (26, CAST(N'2023-07-10' AS Date), CAST(N'0001-01-01' AS Date), 2, 1, 10)
GO
INSERT [dbo].[Bill] ([id_Bill], [date_CheckIn], [date_CheckOut], [id_Table], [status], [discount]) VALUES (27, CAST(N'2023-07-10' AS Date), CAST(N'0001-01-01' AS Date), 25, 0, 0)
GO
SET IDENTITY_INSERT [dbo].[Bill] OFF
GO
SET IDENTITY_INSERT [dbo].[BillInformation] ON 
GO
INSERT [dbo].[BillInformation] ([id_Bill_Infor], [id_Bill], [id_Food], [quanlity]) VALUES (19, 5, 7, 3)
GO
INSERT [dbo].[BillInformation] ([id_Bill_Infor], [id_Bill], [id_Food], [quanlity]) VALUES (20, 5, 12, 3)
GO
INSERT [dbo].[BillInformation] ([id_Bill_Infor], [id_Bill], [id_Food], [quanlity]) VALUES (21, 5, 19, 3)
GO
INSERT [dbo].[BillInformation] ([id_Bill_Infor], [id_Bill], [id_Food], [quanlity]) VALUES (22, 6, 3, 3)
GO
INSERT [dbo].[BillInformation] ([id_Bill_Infor], [id_Bill], [id_Food], [quanlity]) VALUES (23, 6, 2, 3)
GO
INSERT [dbo].[BillInformation] ([id_Bill_Infor], [id_Bill], [id_Food], [quanlity]) VALUES (24, 6, 9, 3)
GO
INSERT [dbo].[BillInformation] ([id_Bill_Infor], [id_Bill], [id_Food], [quanlity]) VALUES (25, 26, 17, 4)
GO
INSERT [dbo].[BillInformation] ([id_Bill_Infor], [id_Bill], [id_Food], [quanlity]) VALUES (27, 26, 15, 3)
GO
INSERT [dbo].[BillInformation] ([id_Bill_Infor], [id_Bill], [id_Food], [quanlity]) VALUES (28, 9, 7, 3)
GO
INSERT [dbo].[BillInformation] ([id_Bill_Infor], [id_Bill], [id_Food], [quanlity]) VALUES (29, 9, 12, 3)
GO
INSERT [dbo].[BillInformation] ([id_Bill_Infor], [id_Bill], [id_Food], [quanlity]) VALUES (30, 9, 19, 3)
GO
INSERT [dbo].[BillInformation] ([id_Bill_Infor], [id_Bill], [id_Food], [quanlity]) VALUES (31, 10, 13, 3)
GO
INSERT [dbo].[BillInformation] ([id_Bill_Infor], [id_Bill], [id_Food], [quanlity]) VALUES (32, 10, 14, 3)
GO
INSERT [dbo].[BillInformation] ([id_Bill_Infor], [id_Bill], [id_Food], [quanlity]) VALUES (33, 10, 15, 3)
GO
INSERT [dbo].[BillInformation] ([id_Bill_Infor], [id_Bill], [id_Food], [quanlity]) VALUES (35, 12, 1, 1)
GO
INSERT [dbo].[BillInformation] ([id_Bill_Infor], [id_Bill], [id_Food], [quanlity]) VALUES (50, 22, 17, 0)
GO
INSERT [dbo].[BillInformation] ([id_Bill_Infor], [id_Bill], [id_Food], [quanlity]) VALUES (51, 23, 1, 1)
GO
INSERT [dbo].[BillInformation] ([id_Bill_Infor], [id_Bill], [id_Food], [quanlity]) VALUES (53, 6, 1, 10)
GO
INSERT [dbo].[BillInformation] ([id_Bill_Infor], [id_Bill], [id_Food], [quanlity]) VALUES (55, 24, 1, 1)
GO
INSERT [dbo].[BillInformation] ([id_Bill_Infor], [id_Bill], [id_Food], [quanlity]) VALUES (57, 11, 1, 1)
GO
INSERT [dbo].[BillInformation] ([id_Bill_Infor], [id_Bill], [id_Food], [quanlity]) VALUES (60, 26, 6, 5)
GO
INSERT [dbo].[BillInformation] ([id_Bill_Infor], [id_Bill], [id_Food], [quanlity]) VALUES (61, 27, 1, 1)
GO
SET IDENTITY_INSERT [dbo].[BillInformation] OFF
GO
SET IDENTITY_INSERT [dbo].[Food] ON 
GO
INSERT [dbo].[Food] ([id_Food], [name_Food], [id_Category], [price_Food]) VALUES (1, N'Potato chips12', 1, 23370)
GO
INSERT [dbo].[Food] ([id_Food], [name_Food], [id_Category], [price_Food]) VALUES (2, N'Popcorn', 1, 14370)
GO
INSERT [dbo].[Food] ([id_Food], [name_Food], [id_Category], [price_Food]) VALUES (3, N'Pretzels', 1, 32370)
GO
INSERT [dbo].[Food] ([id_Food], [name_Food], [id_Category], [price_Food]) VALUES (4, N'Trail mix', 1, 14470)
GO
INSERT [dbo].[Food] ([id_Food], [name_Food], [id_Category], [price_Food]) VALUES (5, N'Coffe', 2, 21170)
GO
INSERT [dbo].[Food] ([id_Food], [name_Food], [id_Category], [price_Food]) VALUES (6, N'Tea', 2, 4370)
GO
INSERT [dbo].[Food] ([id_Food], [name_Food], [id_Category], [price_Food]) VALUES (7, N'Soda', 2, 2370)
GO
INSERT [dbo].[Food] ([id_Food], [name_Food], [id_Category], [price_Food]) VALUES (8, N'Juice', 3, 6370)
GO
INSERT [dbo].[Food] ([id_Food], [name_Food], [id_Category], [price_Food]) VALUES (9, N'Chocolate cake', 3, 87370)
GO
INSERT [dbo].[Food] ([id_Food], [name_Food], [id_Category], [price_Food]) VALUES (10, N'Carrot cake', 3, 87370)
GO
INSERT [dbo].[Food] ([id_Food], [name_Food], [id_Category], [price_Food]) VALUES (11, N'Red velvet cake', 3, 87370)
GO
INSERT [dbo].[Food] ([id_Food], [name_Food], [id_Category], [price_Food]) VALUES (12, N'Cheesecake', 3, 452370)
GO
INSERT [dbo].[Food] ([id_Food], [name_Food], [id_Category], [price_Food]) VALUES (13, N'Fried chicken', 5, 452370)
GO
INSERT [dbo].[Food] ([id_Food], [name_Food], [id_Category], [price_Food]) VALUES (14, N'Spring rolls', 5, 452370)
GO
INSERT [dbo].[Food] ([id_Food], [name_Food], [id_Category], [price_Food]) VALUES (15, N'Fried dumplings', 5, 452370)
GO
INSERT [dbo].[Food] ([id_Food], [name_Food], [id_Category], [price_Food]) VALUES (16, N'baked ribs', 5, 452370)
GO
INSERT [dbo].[Food] ([id_Food], [name_Food], [id_Category], [price_Food]) VALUES (17, N'Potato chips', 4, 23370)
GO
INSERT [dbo].[Food] ([id_Food], [name_Food], [id_Category], [price_Food]) VALUES (18, N'Popcorn 1', 4, 14370)
GO
INSERT [dbo].[Food] ([id_Food], [name_Food], [id_Category], [price_Food]) VALUES (19, N'Pretzels 1', 4, 32370)
GO
INSERT [dbo].[Food] ([id_Food], [name_Food], [id_Category], [price_Food]) VALUES (20, N'Pretzels 1', 4, 32370)
GO
INSERT [dbo].[Food] ([id_Food], [name_Food], [id_Category], [price_Food]) VALUES (21, N'Potato chips122', 2, 5673563)
GO
SET IDENTITY_INSERT [dbo].[Food] OFF
GO
SET IDENTITY_INSERT [dbo].[FoodCategory] ON 
GO
INSERT [dbo].[FoodCategory] ([id_Category], [name_Category]) VALUES (1, N'Snackshuy')
GO
INSERT [dbo].[FoodCategory] ([id_Category], [name_Category]) VALUES (2, N'Drinks')
GO
INSERT [dbo].[FoodCategory] ([id_Category], [name_Category]) VALUES (3, N'Cake')
GO
INSERT [dbo].[FoodCategory] ([id_Category], [name_Category]) VALUES (4, N'Meat dishes')
GO
INSERT [dbo].[FoodCategory] ([id_Category], [name_Category]) VALUES (5, N'Fried food')
GO
SET IDENTITY_INSERT [dbo].[FoodCategory] OFF
GO
INSERT [dbo].[RoleAccount] ([id_Role], [name_Role], [description]) VALUES (0, N'Customer', N'Dung He Thong')
GO
INSERT [dbo].[RoleAccount] ([id_Role], [name_Role], [description]) VALUES (1, N'Admin', N'Quan Ly')
GO
SET IDENTITY_INSERT [dbo].[TableFood] ON 
GO
INSERT [dbo].[TableFood] ([id_Table], [name_Table], [status], [maximun_People]) VALUES (2, N'Table 1@', 0, 1)
GO
INSERT [dbo].[TableFood] ([id_Table], [name_Table], [status], [maximun_People]) VALUES (3, N'Table 2', 0, 2)
GO
INSERT [dbo].[TableFood] ([id_Table], [name_Table], [status], [maximun_People]) VALUES (4, N'Table 3', 0, 3)
GO
INSERT [dbo].[TableFood] ([id_Table], [name_Table], [status], [maximun_People]) VALUES (5, N'Table 4', 0, 4)
GO
INSERT [dbo].[TableFood] ([id_Table], [name_Table], [status], [maximun_People]) VALUES (6, N'Table 5', 1, 5)
GO
INSERT [dbo].[TableFood] ([id_Table], [name_Table], [status], [maximun_People]) VALUES (7, N'Table 6', 1, 6)
GO
INSERT [dbo].[TableFood] ([id_Table], [name_Table], [status], [maximun_People]) VALUES (8, N'Table 7', 0, 7)
GO
INSERT [dbo].[TableFood] ([id_Table], [name_Table], [status], [maximun_People]) VALUES (9, N'Table 8', 1, 8)
GO
INSERT [dbo].[TableFood] ([id_Table], [name_Table], [status], [maximun_People]) VALUES (10, N'Table 9', 1, 9)
GO
INSERT [dbo].[TableFood] ([id_Table], [name_Table], [status], [maximun_People]) VALUES (11, N'Table 10', 1, 2)
GO
INSERT [dbo].[TableFood] ([id_Table], [name_Table], [status], [maximun_People]) VALUES (12, N'Table 11', 1, 1)
GO
INSERT [dbo].[TableFood] ([id_Table], [name_Table], [status], [maximun_People]) VALUES (13, N'Table 12', 1, 2)
GO
INSERT [dbo].[TableFood] ([id_Table], [name_Table], [status], [maximun_People]) VALUES (14, N'Table 13', 1, 3)
GO
INSERT [dbo].[TableFood] ([id_Table], [name_Table], [status], [maximun_People]) VALUES (15, N'Table 14', 1, 4)
GO
INSERT [dbo].[TableFood] ([id_Table], [name_Table], [status], [maximun_People]) VALUES (16, N'Table 15', 1, 5)
GO
INSERT [dbo].[TableFood] ([id_Table], [name_Table], [status], [maximun_People]) VALUES (17, N'Table 16', 1, 6)
GO
INSERT [dbo].[TableFood] ([id_Table], [name_Table], [status], [maximun_People]) VALUES (18, N'Table 17', 1, 7)
GO
INSERT [dbo].[TableFood] ([id_Table], [name_Table], [status], [maximun_People]) VALUES (19, N'Table 18', 1, 8)
GO
INSERT [dbo].[TableFood] ([id_Table], [name_Table], [status], [maximun_People]) VALUES (20, N'Table 19', 1, 9)
GO
INSERT [dbo].[TableFood] ([id_Table], [name_Table], [status], [maximun_People]) VALUES (21, N'Table 20', 1, 2)
GO
INSERT [dbo].[TableFood] ([id_Table], [name_Table], [status], [maximun_People]) VALUES (22, N'Table 21', 1, 1)
GO
INSERT [dbo].[TableFood] ([id_Table], [name_Table], [status], [maximun_People]) VALUES (23, N'Table 22', 1, 2)
GO
INSERT [dbo].[TableFood] ([id_Table], [name_Table], [status], [maximun_People]) VALUES (24, N'Table 23', 1, 3)
GO
INSERT [dbo].[TableFood] ([id_Table], [name_Table], [status], [maximun_People]) VALUES (25, N'Table 24', 1, 4)
GO
INSERT [dbo].[TableFood] ([id_Table], [name_Table], [status], [maximun_People]) VALUES (26, N'Table 25', 1, 5)
GO
INSERT [dbo].[TableFood] ([id_Table], [name_Table], [status], [maximun_People]) VALUES (27, N'Table 26', 1, 6)
GO
INSERT [dbo].[TableFood] ([id_Table], [name_Table], [status], [maximun_People]) VALUES (28, N'Table 27', 0, 7)
GO
INSERT [dbo].[TableFood] ([id_Table], [name_Table], [status], [maximun_People]) VALUES (29, N'Table 28', 1, 8)
GO
INSERT [dbo].[TableFood] ([id_Table], [name_Table], [status], [maximun_People]) VALUES (30, N'Table 29', 1, 9)
GO
INSERT [dbo].[TableFood] ([id_Table], [name_Table], [status], [maximun_People]) VALUES (32, N'Table 1', 0, 9)
GO
SET IDENTITY_INSERT [dbo].[TableFood] OFF
GO
ALTER TABLE [dbo].[Account] ADD  DEFAULT (N'Fpter') FOR [display_Name]
GO
ALTER TABLE [dbo].[Account] ADD  DEFAULT ((123)) FOR [password]
GO
ALTER TABLE [dbo].[Account] ADD  DEFAULT ((0)) FOR [id_Role]
GO
ALTER TABLE [dbo].[Bill] ADD  DEFAULT (getdate()) FOR [date_CheckIn]
GO
ALTER TABLE [dbo].[Bill] ADD  DEFAULT ((0)) FOR [status]
GO
ALTER TABLE [dbo].[BillInformation] ADD  DEFAULT ((0)) FOR [quanlity]
GO
ALTER TABLE [dbo].[Food] ADD  DEFAULT (N'Unknown name') FOR [name_Food]
GO
ALTER TABLE [dbo].[FoodCategory] ADD  DEFAULT (N'Unknown name') FOR [name_Category]
GO
ALTER TABLE [dbo].[TableFood] ADD  DEFAULT (N'Unknown name') FOR [name_Table]
GO
ALTER TABLE [dbo].[TableFood] ADD  DEFAULT ((0)) FOR [status]
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD  CONSTRAINT [user_role] FOREIGN KEY([id_Role])
REFERENCES [dbo].[RoleAccount] ([id_Role])
GO
ALTER TABLE [dbo].[Account] CHECK CONSTRAINT [user_role]
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD  CONSTRAINT [Table_Bill] FOREIGN KEY([id_Table])
REFERENCES [dbo].[TableFood] ([id_Table])
GO
ALTER TABLE [dbo].[Bill] CHECK CONSTRAINT [Table_Bill]
GO
ALTER TABLE [dbo].[BillInformation]  WITH CHECK ADD  CONSTRAINT [BillInformation_Bill] FOREIGN KEY([id_Bill])
REFERENCES [dbo].[Bill] ([id_Bill])
GO
ALTER TABLE [dbo].[BillInformation] CHECK CONSTRAINT [BillInformation_Bill]
GO
ALTER TABLE [dbo].[BillInformation]  WITH CHECK ADD  CONSTRAINT [BillInformation_Food] FOREIGN KEY([id_Food])
REFERENCES [dbo].[Food] ([id_Food])
GO
ALTER TABLE [dbo].[BillInformation] CHECK CONSTRAINT [BillInformation_Food]
GO
ALTER TABLE [dbo].[Food]  WITH CHECK ADD  CONSTRAINT [Category_Food] FOREIGN KEY([id_Category])
REFERENCES [dbo].[FoodCategory] ([id_Category])
GO
ALTER TABLE [dbo].[Food] CHECK CONSTRAINT [Category_Food]
GO
USE [master]
GO
ALTER DATABASE [QuanLyQuanTraSua] SET  READ_WRITE 
GO
