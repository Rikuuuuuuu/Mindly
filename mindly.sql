USE [master]
GO
/****** Object:  Database [MindlyTestDatabase]    Script Date: 18.2.2021 18.22.11 ******/
CREATE DATABASE [MindlyTestDatabase]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MindlyTestDatabase', FILENAME = N'C:\Users\Omistaja\MindlyTestDatabase.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MindlyTestDatabase_log', FILENAME = N'C:\Users\Omistaja\MindlyTestDatabase_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [MindlyTestDatabase] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MindlyTestDatabase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MindlyTestDatabase] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MindlyTestDatabase] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MindlyTestDatabase] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MindlyTestDatabase] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MindlyTestDatabase] SET ARITHABORT OFF 
GO
ALTER DATABASE [MindlyTestDatabase] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MindlyTestDatabase] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MindlyTestDatabase] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MindlyTestDatabase] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MindlyTestDatabase] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MindlyTestDatabase] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MindlyTestDatabase] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MindlyTestDatabase] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MindlyTestDatabase] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MindlyTestDatabase] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MindlyTestDatabase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MindlyTestDatabase] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MindlyTestDatabase] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MindlyTestDatabase] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MindlyTestDatabase] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MindlyTestDatabase] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MindlyTestDatabase] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MindlyTestDatabase] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MindlyTestDatabase] SET  MULTI_USER 
GO
ALTER DATABASE [MindlyTestDatabase] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MindlyTestDatabase] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MindlyTestDatabase] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MindlyTestDatabase] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MindlyTestDatabase] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [MindlyTestDatabase] SET QUERY_STORE = OFF
GO
USE [MindlyTestDatabase]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [MindlyTestDatabase]
GO
/****** Object:  Table [dbo].[Kysymys]    Script Date: 18.2.2021 18.22.12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kysymys](
	[Id] [int] NOT NULL,
	[IdTesti] [int] NOT NULL,
	[Kysymys] [nvarchar](50) NULL,
 CONSTRAINT [PK_Kysymys] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rahoittaja]    Script Date: 18.2.2021 18.22.12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rahoittaja](
	[Id] [int] NOT NULL,
	[RahoittajaNimi] [nvarchar](50) NULL,
 CONSTRAINT [PK_Rahoittaja] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Testi]    Script Date: 18.2.2021 18.22.12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Testi](
	[Id] [int] NOT NULL,
	[IdRahoittaja] [int] NOT NULL,
	[TestinNimi] [nvarchar](50) NULL,
 CONSTRAINT [PK_Testi] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vastaukset]    Script Date: 18.2.2021 18.22.12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vastaukset](
	[Id] [int] NOT NULL,
	[IdKysymys] [int] NOT NULL,
	[IdYritys] [int] NOT NULL,
	[Vastaus] [nvarchar](50) NULL,
 CONSTRAINT [PK_Vastaukset] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Yrittäjä]    Script Date: 18.2.2021 18.22.12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Yrittäjä](
	[id] [int] NOT NULL,
	[YrittäjänNimi] [nvarchar](50) NOT NULL,
	[IdRahoittaja] [int] NOT NULL,
 CONSTRAINT [PK_Yrittäjä] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Kysymys]  WITH CHECK ADD  CONSTRAINT [FK_Kysymys_Testi] FOREIGN KEY([IdTesti])
REFERENCES [dbo].[Testi] ([Id])
GO
ALTER TABLE [dbo].[Kysymys] CHECK CONSTRAINT [FK_Kysymys_Testi]
GO
ALTER TABLE [dbo].[Testi]  WITH CHECK ADD  CONSTRAINT [FK_Testi_Rahoittaja] FOREIGN KEY([IdRahoittaja])
REFERENCES [dbo].[Rahoittaja] ([Id])
GO
ALTER TABLE [dbo].[Testi] CHECK CONSTRAINT [FK_Testi_Rahoittaja]
GO
ALTER TABLE [dbo].[Vastaukset]  WITH CHECK ADD  CONSTRAINT [FK_Vastaukset_Kysymys] FOREIGN KEY([IdKysymys])
REFERENCES [dbo].[Kysymys] ([Id])
GO
ALTER TABLE [dbo].[Vastaukset] CHECK CONSTRAINT [FK_Vastaukset_Kysymys]
GO
ALTER TABLE [dbo].[Vastaukset]  WITH CHECK ADD  CONSTRAINT [FK_Vastaukset_Yrittäjä] FOREIGN KEY([IdYritys])
REFERENCES [dbo].[Yrittäjä] ([id])
GO
ALTER TABLE [dbo].[Vastaukset] CHECK CONSTRAINT [FK_Vastaukset_Yrittäjä]
GO
ALTER TABLE [dbo].[Yrittäjä]  WITH CHECK ADD  CONSTRAINT [FK_Yrittäjä_Rahoittaja] FOREIGN KEY([IdRahoittaja])
REFERENCES [dbo].[Rahoittaja] ([Id])
GO
ALTER TABLE [dbo].[Yrittäjä] CHECK CONSTRAINT [FK_Yrittäjä_Rahoittaja]
GO
USE [master]
GO
ALTER DATABASE [MindlyTestDatabase] SET  READ_WRITE 
GO
