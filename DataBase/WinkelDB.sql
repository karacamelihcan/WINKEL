USE [master]
GO

/****** Object:  Database [WinkelDB]    Script Date: 13.05.2020 01:20:10 ******/
CREATE DATABASE [WinkelDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'WinkelDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\WinkelDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'WinkelDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\WinkelDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [WinkelDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [WinkelDB] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [WinkelDB] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [WinkelDB] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [WinkelDB] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [WinkelDB] SET ARITHABORT OFF 
GO

ALTER DATABASE [WinkelDB] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [WinkelDB] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [WinkelDB] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [WinkelDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [WinkelDB] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [WinkelDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [WinkelDB] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [WinkelDB] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [WinkelDB] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [WinkelDB] SET  DISABLE_BROKER 
GO

ALTER DATABASE [WinkelDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [WinkelDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [WinkelDB] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [WinkelDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [WinkelDB] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [WinkelDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [WinkelDB] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [WinkelDB] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [WinkelDB] SET  MULTI_USER 
GO

ALTER DATABASE [WinkelDB] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [WinkelDB] SET DB_CHAINING OFF 
GO

ALTER DATABASE [WinkelDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [WinkelDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [WinkelDB] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [WinkelDB] SET QUERY_STORE = OFF
GO

ALTER DATABASE [WinkelDB] SET  READ_WRITE 
GO


