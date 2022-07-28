USE [master]
GO
/****** Object:  Database [PremiumCalCulator]    Script Date: 28-07-2022 09:07:55 ******/
CREATE DATABASE [PremiumCalCulator]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PremiumCalCulator', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\PremiumCalCulator.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PremiumCalCulator_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\PremiumCalCulator_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [PremiumCalCulator] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PremiumCalCulator].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PremiumCalCulator] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PremiumCalCulator] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PremiumCalCulator] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PremiumCalCulator] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PremiumCalCulator] SET ARITHABORT OFF 
GO
ALTER DATABASE [PremiumCalCulator] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PremiumCalCulator] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PremiumCalCulator] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PremiumCalCulator] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PremiumCalCulator] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PremiumCalCulator] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PremiumCalCulator] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PremiumCalCulator] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PremiumCalCulator] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PremiumCalCulator] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PremiumCalCulator] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PremiumCalCulator] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PremiumCalCulator] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PremiumCalCulator] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PremiumCalCulator] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PremiumCalCulator] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PremiumCalCulator] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PremiumCalCulator] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PremiumCalCulator] SET  MULTI_USER 
GO
ALTER DATABASE [PremiumCalCulator] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PremiumCalCulator] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PremiumCalCulator] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PremiumCalCulator] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PremiumCalCulator] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PremiumCalCulator] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [PremiumCalCulator] SET QUERY_STORE = OFF
GO
USE [PremiumCalCulator]
GO
/****** Object:  Table [dbo].[OccupationMaster]    Script Date: 28-07-2022 09:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OccupationMaster](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Occupation] [nvarchar](50) NULL,
	[Rating] [int] NULL,
 CONSTRAINT [PK_OccupationMaster] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RatingMaster]    Script Date: 28-07-2022 09:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RatingMaster](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Rating] [varchar](50) NULL,
	[Factor] [decimal](18, 2) NULL,
 CONSTRAINT [PK_RatingMaster] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[OccupationMaster] ON 

INSERT [dbo].[OccupationMaster] ([ID], [Occupation], [Rating]) VALUES (1, N'Cleaner', 3)
INSERT [dbo].[OccupationMaster] ([ID], [Occupation], [Rating]) VALUES (2, N'Doctor', 1)
INSERT [dbo].[OccupationMaster] ([ID], [Occupation], [Rating]) VALUES (3, N'Author', 2)
INSERT [dbo].[OccupationMaster] ([ID], [Occupation], [Rating]) VALUES (4, N'Farmer', 4)
INSERT [dbo].[OccupationMaster] ([ID], [Occupation], [Rating]) VALUES (5, N'Mechanic ', 4)
INSERT [dbo].[OccupationMaster] ([ID], [Occupation], [Rating]) VALUES (6, N'Florist', 3)
SET IDENTITY_INSERT [dbo].[OccupationMaster] OFF
GO
SET IDENTITY_INSERT [dbo].[RatingMaster] ON 

INSERT [dbo].[RatingMaster] ([ID], [Rating], [Factor]) VALUES (1, N'Professional', CAST(1.00 AS Decimal(18, 2)))
INSERT [dbo].[RatingMaster] ([ID], [Rating], [Factor]) VALUES (2, N'White Collar', CAST(1.25 AS Decimal(18, 2)))
INSERT [dbo].[RatingMaster] ([ID], [Rating], [Factor]) VALUES (3, N'Light Manual', CAST(1.50 AS Decimal(18, 2)))
INSERT [dbo].[RatingMaster] ([ID], [Rating], [Factor]) VALUES (4, N'Heavy Manual', CAST(1.75 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[RatingMaster] OFF
GO
ALTER TABLE [dbo].[OccupationMaster]  WITH CHECK ADD  CONSTRAINT [FK_OccupationMaster_RatingMaster] FOREIGN KEY([Rating])
REFERENCES [dbo].[RatingMaster] ([ID])
GO
ALTER TABLE [dbo].[OccupationMaster] CHECK CONSTRAINT [FK_OccupationMaster_RatingMaster]
GO
USE [master]
GO
ALTER DATABASE [PremiumCalCulator] SET  READ_WRITE 
GO
