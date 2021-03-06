USE [master]
GO
/****** Object:  Database [WellRentalCenter]    Script Date: 5/23/2018 5:26:29 PM ******/
CREATE DATABASE [WellRentalCenter]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'New Database', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\New Database.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'New Database_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\New Database.ldf' , SIZE = 73728KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [WellRentalCenter] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [WellRentalCenter].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [WellRentalCenter] SET ANSI_NULL_DEFAULT ON 
GO
ALTER DATABASE [WellRentalCenter] SET ANSI_NULLS ON 
GO
ALTER DATABASE [WellRentalCenter] SET ANSI_PADDING ON 
GO
ALTER DATABASE [WellRentalCenter] SET ANSI_WARNINGS ON 
GO
ALTER DATABASE [WellRentalCenter] SET ARITHABORT ON 
GO
ALTER DATABASE [WellRentalCenter] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [WellRentalCenter] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [WellRentalCenter] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [WellRentalCenter] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [WellRentalCenter] SET CURSOR_DEFAULT  LOCAL 
GO
ALTER DATABASE [WellRentalCenter] SET CONCAT_NULL_YIELDS_NULL ON 
GO
ALTER DATABASE [WellRentalCenter] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [WellRentalCenter] SET QUOTED_IDENTIFIER ON 
GO
ALTER DATABASE [WellRentalCenter] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [WellRentalCenter] SET  DISABLE_BROKER 
GO
ALTER DATABASE [WellRentalCenter] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [WellRentalCenter] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [WellRentalCenter] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [WellRentalCenter] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [WellRentalCenter] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [WellRentalCenter] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [WellRentalCenter] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [WellRentalCenter] SET RECOVERY FULL 
GO
ALTER DATABASE [WellRentalCenter] SET  MULTI_USER 
GO
ALTER DATABASE [WellRentalCenter] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [WellRentalCenter] SET DB_CHAINING OFF 
GO
ALTER DATABASE [WellRentalCenter] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [WellRentalCenter] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [WellRentalCenter] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'WellRentalCenter', N'ON'
GO
ALTER DATABASE [WellRentalCenter] SET QUERY_STORE = OFF
GO
USE [WellRentalCenter]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [WellRentalCenter]
GO
/****** Object:  Table [dbo].[Assignment]    Script Date: 5/23/2018 5:26:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Assignment](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OrderNo] [varchar](50) NOT NULL,
	[PlateNumber] [nvarchar](10) NOT NULL,
	[DriverName] [nvarchar](20) NOT NULL,
	[DriverPhone] [varchar](50) NOT NULL,
	[AssignmentStatus] [int] NULL,
	[AuditUser] [varchar](50) NOT NULL,
	[AuditDateTime] [datetime] NOT NULL,
 CONSTRAINT [PK_Assignment] PRIMARY KEY CLUSTERED 
(
	[OrderNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[City]    Script Date: 5/23/2018 5:26:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[City](
	[CityID] [bigint] IDENTITY(1,1) NOT NULL,
	[CityName] [nvarchar](50) NULL,
	[ZipCode] [nvarchar](50) NULL,
	[ProvinceID] [bigint] NULL,
	[DateCreated] [datetime] NULL,
	[DateUpdated] [datetime] NULL,
 CONSTRAINT [PK_S_City] PRIMARY KEY CLUSTERED 
(
	[CityID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[District]    Script Date: 5/23/2018 5:26:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[District](
	[DistrictID] [bigint] IDENTITY(1,1) NOT NULL,
	[DistrictName] [nvarchar](50) NULL,
	[CityID] [bigint] NULL,
	[DateCreated] [datetime] NULL,
	[DateUpdated] [datetime] NULL,
 CONSTRAINT [PK_S_District] PRIMARY KEY CLUSTERED 
(
	[DistrictID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Merchant]    Script Date: 5/23/2018 5:26:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Merchant](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MerchantId] [uniqueidentifier] NOT NULL,
	[MerchantTypeId] [uniqueidentifier] NULL,
	[Name] [nvarchar](100) NOT NULL,
	[RebateAmount] [float] NULL,
	[RespoPerson] [nvarchar](50) NULL,
	[RespoPhone] [varchar](50) NULL,
	[Attest1] [varchar](max) NULL,
	[Attest2] [varchar](max) NULL,
	[Attest3] [varchar](max) NULL,
	[Attest4] [varchar](max) NULL,
	[Attest5] [varchar](max) NULL,
	[AliPayAccount] [varchar](100) NULL,
	[WeiXinPayAccount] [varchar](100) NULL,
	[Address] [nvarchar](max) NULL,
	[Longitude] [decimal](18, 0) NULL,
	[Latitude] [decimal](18, 0) NULL,
	[Contactor] [varchar](50) NULL,
	[ContactPhone] [varchar](50) NULL,
	[QRCode] [image] NULL,
	[CreatedBy] [int] NOT NULL,
	[CreateDateTime] [datetime] NOT NULL,
	[UpdatedBy] [int] NULL,
	[UpdateDateTime] [datetime] NULL,
 CONSTRAINT [PK_Merchant] PRIMARY KEY CLUSTERED 
(
	[MerchantId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MerchantType]    Script Date: 5/23/2018 5:26:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MerchantType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TypeId] [uniqueidentifier] NOT NULL,
	[TypeName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_MerchantType_1] PRIMARY KEY CLUSTERED 
(
	[TypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 5/23/2018 5:26:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OrderNo] [varchar](50) NOT NULL,
	[OpenId] [varchar](150) NOT NULL,
	[EstimateLeaveTime] [datetime] NOT NULL,
	[LastestLeaveTime] [datetime] NOT NULL,
	[PassengerCount] [int] NOT NULL,
	[ProceedPlace] [nvarchar](100) NOT NULL,
	[DestinationPlace] [nvarchar](100) NOT NULL,
	[HasPet] [bit] NOT NULL,
	[HasLargeLuggage] [bit] NOT NULL,
	[LuggageWeight] [float] NULL,
	[VehicleTypeReq] [nvarchar](50) NULL,
	[RentingType] [int] NULL,
	[CustomerPhone] [varchar](50) NOT NULL,
	[OrderStatus] [int] NOT NULL,
	[SubscribeDateTime] [datetime] NULL,
	[AuditUser] [varchar](50) NULL,
	[AuditDateTime] [datetime] NULL,
	[TransactionAmount] [float] NULL,
	[PrePayAmount] [float] NULL,
 CONSTRAINT [PK_OrderBill] PRIMARY KEY CLUSTERED 
(
	[OrderNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Payment]    Script Date: 5/23/2018 5:26:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payment](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OrderNo] [varchar](50) NOT NULL,
	[PaymentMethod] [int] NOT NULL,
	[PaidDateTime] [datetime] NOT NULL,
	[Amount] [float] NOT NULL,
	[PaymentCatalog] [int] NULL,
	[SequnceNO] [varchar](50) NULL,
 CONSTRAINT [PK_Payment] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Province]    Script Date: 5/23/2018 5:26:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Province](
	[ProvinceID] [bigint] IDENTITY(1,1) NOT NULL,
	[ProvinceName] [nvarchar](50) NULL,
	[DateCreated] [datetime] NULL,
	[DateUpdated] [datetime] NULL,
 CONSTRAINT [PK_S_Province] PRIMARY KEY CLUSTERED 
(
	[ProvinceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Remission]    Script Date: 5/23/2018 5:26:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Remission](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SequenceNo] [varchar](50) NOT NULL,
	[MerchantId] [uniqueidentifier] NOT NULL,
	[WithdrawAmount] [float] NOT NULL,
	[WithdrawDateTime] [datetime] NOT NULL,
	[WithdrawStatus] [int] NULL,
	[ArrivalDateTime] [datetime] NULL,
	[Description] [varchar](max) NULL,
 CONSTRAINT [PK_Remission] PRIMARY KEY CLUSTERED 
(
	[SequenceNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WxOpenUser]    Script Date: 5/23/2018 5:26:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WxOpenUser](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OpenId] [varchar](150) NOT NULL,
	[NickName] [nvarchar](50) NOT NULL,
	[Sex] [int] NULL,
	[City] [nvarchar](50) NULL,
	[Province] [nvarchar](50) NULL,
	[Country] [nvarchar](50) NULL,
	[HeadImhUrl] [varchar](max) NULL,
	[EntranceMerchant] [uniqueidentifier] NULL,
	[Mobile] [varchar](50) NULL,
	[VisitCount] [int] NULL,
	[LastVisitDateTime] [datetime] NULL,
 CONSTRAINT [PK_WxOpenUser] PRIMARY KEY CLUSTERED 
(
	[OpenId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Merchant]    Script Date: 5/23/2018 5:26:30 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Merchant] ON [dbo].[Merchant]
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_MerchantType]    Script Date: 5/23/2018 5:26:30 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_MerchantType] ON [dbo].[MerchantType]
(
	[TypeName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Merchant] ADD  CONSTRAINT [DF_Merchant_MerchantId]  DEFAULT (newid()) FOR [MerchantId]
GO
USE [master]
GO
ALTER DATABASE [WellRentalCenter] SET  READ_WRITE 
GO
