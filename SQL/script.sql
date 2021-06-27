USE [master]
GO
/****** Object:  Database [PastriesDelivery]    Script Date: 6/27/2021 2:00:52 PM ******/
CREATE DATABASE [PastriesDelivery]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'pastries_delivery', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\pastries_delivery.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'pastries_delivery_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\pastries_delivery_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [PastriesDelivery] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PastriesDelivery].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PastriesDelivery] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PastriesDelivery] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PastriesDelivery] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PastriesDelivery] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PastriesDelivery] SET ARITHABORT OFF 
GO
ALTER DATABASE [PastriesDelivery] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PastriesDelivery] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PastriesDelivery] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PastriesDelivery] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PastriesDelivery] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PastriesDelivery] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PastriesDelivery] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PastriesDelivery] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PastriesDelivery] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PastriesDelivery] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PastriesDelivery] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PastriesDelivery] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PastriesDelivery] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PastriesDelivery] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PastriesDelivery] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PastriesDelivery] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PastriesDelivery] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PastriesDelivery] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PastriesDelivery] SET  MULTI_USER 
GO
ALTER DATABASE [PastriesDelivery] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PastriesDelivery] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PastriesDelivery] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PastriesDelivery] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PastriesDelivery] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PastriesDelivery] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [PastriesDelivery] SET QUERY_STORE = OFF
GO
USE [PastriesDelivery]
GO
/****** Object:  Table [dbo].[CurrencyRates]    Script Date: 6/27/2021 2:00:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CurrencyRates](
	[CurrencyNames] [nchar](3) NOT NULL,
	[BaseCurrencies] [nchar](3) NOT NULL,
	[Buy] [decimal](18, 0) NOT NULL,
	[Sale] [decimal](18, 0) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 6/27/2021 2:00:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[Id] [int] NOT NULL,
	[PastryId] [int] NOT NULL,
	[TotalPrice] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_order] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pastries]    Script Date: 6/27/2021 2:00:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pastries](
	[Id] [int] NOT NULL,
	[Name] [nchar](10) NOT NULL,
	[Type] [nchar](10) NOT NULL,
	[Weight] [int] NOT NULL,
	[Price] [decimal](18, 0) NOT NULL,
	[Amount] [int] NOT NULL,
	[Currency] [nchar](3) NOT NULL,
 CONSTRAINT [PK_pastry] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 6/27/2021 2:00:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[RoleId] [smallint] NOT NULL,
	[RoleName] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 6/27/2021 2:00:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] NOT NULL,
	[Name] [nchar](30) NOT NULL,
	[Adress] [nchar](30) NOT NULL,
	[PhoneNumber] [nchar](10) NOT NULL,
	[RoleId] [smallint] NOT NULL,
 CONSTRAINT [PK_user] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsersOrders]    Script Date: 6/27/2021 2:00:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsersOrders](
	[UserId] [int] NOT NULL,
	[OrderId] [int] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_order_pastry] FOREIGN KEY([PastryId])
REFERENCES [dbo].[Pastries] ([Id])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_order_pastry]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Users] FOREIGN KEY([RoleId])
REFERENCES [dbo].[Roles] ([RoleId])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Users]
GO
ALTER TABLE [dbo].[UsersOrders]  WITH CHECK ADD  CONSTRAINT [FK_UsersOrders_Orders] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Orders] ([Id])
GO
ALTER TABLE [dbo].[UsersOrders] CHECK CONSTRAINT [FK_UsersOrders_Orders]
GO
ALTER TABLE [dbo].[UsersOrders]  WITH CHECK ADD  CONSTRAINT [FK_UsersOrders_Users] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[UsersOrders] CHECK CONSTRAINT [FK_UsersOrders_Users]
GO
USE [master]
GO
ALTER DATABASE [PastriesDelivery] SET  READ_WRITE 
GO
