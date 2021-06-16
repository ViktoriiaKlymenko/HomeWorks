USE [master]
GO
/****** Object:  Database [pastries_delivery]    Script Date: 6/16/2021 4:12:24 PM ******/
CREATE DATABASE [pastries_delivery]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'pastries_delivery', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\pastries_delivery.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'pastries_delivery_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\pastries_delivery_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [pastries_delivery] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [pastries_delivery].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [pastries_delivery] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [pastries_delivery] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [pastries_delivery] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [pastries_delivery] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [pastries_delivery] SET ARITHABORT OFF 
GO
ALTER DATABASE [pastries_delivery] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [pastries_delivery] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [pastries_delivery] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [pastries_delivery] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [pastries_delivery] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [pastries_delivery] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [pastries_delivery] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [pastries_delivery] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [pastries_delivery] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [pastries_delivery] SET  DISABLE_BROKER 
GO
ALTER DATABASE [pastries_delivery] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [pastries_delivery] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [pastries_delivery] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [pastries_delivery] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [pastries_delivery] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [pastries_delivery] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [pastries_delivery] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [pastries_delivery] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [pastries_delivery] SET  MULTI_USER 
GO
ALTER DATABASE [pastries_delivery] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [pastries_delivery] SET DB_CHAINING OFF 
GO
ALTER DATABASE [pastries_delivery] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [pastries_delivery] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [pastries_delivery] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [pastries_delivery] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [pastries_delivery] SET QUERY_STORE = OFF
GO
USE [pastries_delivery]
GO
/****** Object:  Table [dbo].[currency]    Script Date: 6/16/2021 4:12:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[currency](
	[currencyName] [nchar](3) NOT NULL,
	[baseCurrency] [nchar](3) NOT NULL,
	[buy] [decimal](18, 0) NOT NULL,
	[sale] [decimal](18, 0) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[order]    Script Date: 6/16/2021 4:12:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[order](
	[id] [int] NOT NULL,
	[pastry_id] [int] NOT NULL,
	[user_id] [int] NOT NULL,
	[total_price] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_order] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pastry]    Script Date: 6/16/2021 4:12:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pastry](
	[id] [int] NOT NULL,
	[name] [nchar](10) NOT NULL,
	[type] [nchar](10) NOT NULL,
	[weight] [int] NOT NULL,
	[price] [decimal](18, 0) NOT NULL,
	[amount] [int] NOT NULL,
 CONSTRAINT [PK_pastry] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[product]    Script Date: 6/16/2021 4:12:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[product](
	[id] [int] NOT NULL,
	[pastry_id] [int] NOT NULL,
	[user_id] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[user]    Script Date: 6/16/2021 4:12:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user](
	[id] [int] NOT NULL,
	[name] [nchar](30) NOT NULL,
	[adress] [nchar](30) NOT NULL,
	[phone_number] [nchar](10) NOT NULL,
	[role] [nchar](10) NOT NULL,
 CONSTRAINT [PK_user] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[order]  WITH CHECK ADD  CONSTRAINT [FK_order_pastry] FOREIGN KEY([pastry_id])
REFERENCES [dbo].[pastry] ([id])
GO
ALTER TABLE [dbo].[order] CHECK CONSTRAINT [FK_order_pastry]
GO
ALTER TABLE [dbo].[order]  WITH CHECK ADD  CONSTRAINT [FK_order_user] FOREIGN KEY([user_id])
REFERENCES [dbo].[user] ([id])
GO
ALTER TABLE [dbo].[order] CHECK CONSTRAINT [FK_order_user]
GO
ALTER TABLE [dbo].[product]  WITH CHECK ADD  CONSTRAINT [FK_product_pastry] FOREIGN KEY([pastry_id])
REFERENCES [dbo].[pastry] ([id])
GO
ALTER TABLE [dbo].[product] CHECK CONSTRAINT [FK_product_pastry]
GO
ALTER TABLE [dbo].[product]  WITH CHECK ADD  CONSTRAINT [FK_product_user] FOREIGN KEY([user_id])
REFERENCES [dbo].[user] ([id])
GO
ALTER TABLE [dbo].[product] CHECK CONSTRAINT [FK_product_user]
GO
USE [master]
GO
ALTER DATABASE [pastries_delivery] SET  READ_WRITE 
GO
