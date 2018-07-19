USE [master]
GO

/****** Object:  Database [CardDB]    Script Date: 17/7/2561 0:17:16 ******/
CREATE DATABASE [CardDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CardDB', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\CardDB.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'CardDB_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\CardDB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [CardDB] SET COMPATIBILITY_LEVEL = 110
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CardDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [CardDB] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [CardDB] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [CardDB] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [CardDB] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [CardDB] SET ARITHABORT OFF 
GO

ALTER DATABASE [CardDB] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [CardDB] SET AUTO_CREATE_STATISTICS ON 
GO

ALTER DATABASE [CardDB] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [CardDB] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [CardDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [CardDB] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [CardDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [CardDB] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [CardDB] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [CardDB] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [CardDB] SET  DISABLE_BROKER 
GO

ALTER DATABASE [CardDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [CardDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [CardDB] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [CardDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [CardDB] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [CardDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [CardDB] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [CardDB] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [CardDB] SET  MULTI_USER 
GO

ALTER DATABASE [CardDB] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [CardDB] SET DB_CHAINING OFF 
GO

ALTER DATABASE [CardDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [CardDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO

ALTER DATABASE [CardDB] SET  READ_WRITE 
GO