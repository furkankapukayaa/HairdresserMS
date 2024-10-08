USE [master]
GO
/****** Object:  Database [dbHairdresserMS]    Script Date: 22.09.2024 13:05:39 ******/
CREATE DATABASE [dbHairdresserMS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dbHairdresserMS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\dbHairdresserMS.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'dbHairdresserMS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\dbHairdresserMS_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [dbHairdresserMS] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbHairdresserMS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dbHairdresserMS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dbHairdresserMS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dbHairdresserMS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dbHairdresserMS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dbHairdresserMS] SET ARITHABORT OFF 
GO
ALTER DATABASE [dbHairdresserMS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [dbHairdresserMS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dbHairdresserMS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dbHairdresserMS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dbHairdresserMS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dbHairdresserMS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dbHairdresserMS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dbHairdresserMS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dbHairdresserMS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dbHairdresserMS] SET  ENABLE_BROKER 
GO
ALTER DATABASE [dbHairdresserMS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dbHairdresserMS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dbHairdresserMS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dbHairdresserMS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dbHairdresserMS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dbHairdresserMS] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [dbHairdresserMS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dbHairdresserMS] SET RECOVERY FULL 
GO
ALTER DATABASE [dbHairdresserMS] SET  MULTI_USER 
GO
ALTER DATABASE [dbHairdresserMS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dbHairdresserMS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dbHairdresserMS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dbHairdresserMS] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [dbHairdresserMS] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [dbHairdresserMS] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'dbHairdresserMS', N'ON'
GO
ALTER DATABASE [dbHairdresserMS] SET QUERY_STORE = ON
GO
ALTER DATABASE [dbHairdresserMS] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [dbHairdresserMS]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 22.09.2024 13:05:39 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Appointments]    Script Date: 22.09.2024 13:05:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Appointments](
	[Id] [nvarchar](450) NOT NULL,
	[EmployeeId] [nvarchar](max) NOT NULL,
	[CustomerId] [nvarchar](max) NOT NULL,
	[Notes] [nvarchar](max) NOT NULL,
	[Date] [datetime2](7) NOT NULL,
	[Time] [datetime2](7) NOT NULL,
	[Products] [nvarchar](max) NOT NULL,
	[Amount] [float] NOT NULL,
	[AppointmentStatusType] [int] NOT NULL,
	[CreatedAtTime] [datetime2](7) NOT NULL,
	[UpdatedAtTime] [datetime2](7) NULL,
	[DeletedAtTime] [datetime2](7) NULL,
	[IsDeleted] [bit] NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_Appointments] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 22.09.2024 13:05:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[CreatedAtTime] [datetime2](7) NOT NULL,
	[UpdatedAtTime] [datetime2](7) NULL,
	[DeletedAtTime] [datetime2](7) NULL,
	[IsDeleted] [bit] NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Chairs]    Script Date: 22.09.2024 13:05:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chairs](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[EmployeeId] [nvarchar](max) NOT NULL,
	[ChairStatusType] [int] NOT NULL,
	[OrderId] [nvarchar](max) NULL,
	[CreatedAtTime] [datetime2](7) NOT NULL,
	[UpdatedAtTime] [datetime2](7) NULL,
	[DeletedAtTime] [datetime2](7) NULL,
	[IsDeleted] [bit] NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_Chairs] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 22.09.2024 13:05:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[Id] [nvarchar](450) NOT NULL,
	[NameSurname] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[Phone] [nvarchar](max) NOT NULL,
	[Address] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[CreatedAtTime] [datetime2](7) NOT NULL,
	[UpdatedAtTime] [datetime2](7) NULL,
	[DeletedAtTime] [datetime2](7) NULL,
	[IsDeleted] [bit] NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 22.09.2024 13:05:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[Id] [nvarchar](450) NOT NULL,
	[NameSurname] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
	[Phone] [nvarchar](max) NOT NULL,
	[Type] [int] NOT NULL,
	[CreatedAtTime] [datetime2](7) NOT NULL,
	[UpdatedAtTime] [datetime2](7) NULL,
	[DeletedAtTime] [datetime2](7) NULL,
	[IsDeleted] [bit] NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 22.09.2024 13:05:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[Id] [nvarchar](450) NOT NULL,
	[EmployeeId] [nvarchar](max) NOT NULL,
	[CustomerId] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[Products] [nvarchar](max) NOT NULL,
	[Tip] [decimal](18, 2) NOT NULL,
	[Discount] [decimal](18, 2) NOT NULL,
	[Amount] [decimal](18, 2) NOT NULL,
	[PaymentType] [int] NOT NULL,
	[ChairName] [nvarchar](max) NOT NULL,
	[CreatedAtTime] [datetime2](7) NOT NULL,
	[UpdatedAtTime] [datetime2](7) NULL,
	[DeletedAtTime] [datetime2](7) NULL,
	[IsDeleted] [bit] NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 22.09.2024 13:05:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [nvarchar](450) NOT NULL,
	[CategoryId] [nvarchar](max) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[CreatedAtTime] [datetime2](7) NOT NULL,
	[UpdatedAtTime] [datetime2](7) NULL,
	[DeletedAtTime] [datetime2](7) NULL,
	[IsDeleted] [bit] NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Settings]    Script Date: 22.09.2024 13:05:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Settings](
	[Id] [nvarchar](450) NOT NULL,
	[WorkplaceName] [nvarchar](max) NOT NULL,
	[WorkplaceAddress] [nvarchar](max) NOT NULL,
	[WorkplacePhone] [nvarchar](max) NOT NULL,
	[WorkplaceAuthority] [nvarchar](max) NOT NULL,
	[CreatedAtTime] [datetime2](7) NOT NULL,
	[UpdatedAtTime] [datetime2](7) NULL,
	[DeletedAtTime] [datetime2](7) NULL,
	[IsDeleted] [bit] NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_Settings] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [dbHairdresserMS] SET  READ_WRITE 
GO
