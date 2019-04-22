USE [master]

/****** Object:  Database [SP_SE]    Script Date: 21.04.2019 23:51:43 ******/
CREATE DATABASE [SP_SE]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SP_SE', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\SP_SE.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SP_SE_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\SP_SE_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)

ALTER DATABASE [SP_SE] SET COMPATIBILITY_LEVEL = 120

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SP_SE].[dbo].[sp_fulltext_database] @action = 'enable'
end

ALTER DATABASE [SP_SE] SET ANSI_NULL_DEFAULT OFF 

ALTER DATABASE [SP_SE] SET ANSI_NULLS OFF 

ALTER DATABASE [SP_SE] SET ANSI_PADDING OFF 

ALTER DATABASE [SP_SE] SET ANSI_WARNINGS OFF 

ALTER DATABASE [SP_SE] SET ARITHABORT OFF 

ALTER DATABASE [SP_SE] SET AUTO_CLOSE OFF 

ALTER DATABASE [SP_SE] SET AUTO_SHRINK OFF 

ALTER DATABASE [SP_SE] SET AUTO_UPDATE_STATISTICS ON 

ALTER DATABASE [SP_SE] SET CURSOR_CLOSE_ON_COMMIT OFF 

ALTER DATABASE [SP_SE] SET CURSOR_DEFAULT  GLOBAL 

ALTER DATABASE [SP_SE] SET CONCAT_NULL_YIELDS_NULL OFF 

ALTER DATABASE [SP_SE] SET NUMERIC_ROUNDABORT OFF 

ALTER DATABASE [SP_SE] SET QUOTED_IDENTIFIER OFF 

ALTER DATABASE [SP_SE] SET RECURSIVE_TRIGGERS OFF 

ALTER DATABASE [SP_SE] SET  DISABLE_BROKER 

ALTER DATABASE [SP_SE] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 

ALTER DATABASE [SP_SE] SET DATE_CORRELATION_OPTIMIZATION OFF 

ALTER DATABASE [SP_SE] SET TRUSTWORTHY OFF 

ALTER DATABASE [SP_SE] SET ALLOW_SNAPSHOT_ISOLATION OFF 

ALTER DATABASE [SP_SE] SET PARAMETERIZATION SIMPLE 

ALTER DATABASE [SP_SE] SET READ_COMMITTED_SNAPSHOT OFF 

ALTER DATABASE [SP_SE] SET HONOR_BROKER_PRIORITY OFF 

ALTER DATABASE [SP_SE] SET RECOVERY SIMPLE 

ALTER DATABASE [SP_SE] SET  MULTI_USER 

ALTER DATABASE [SP_SE] SET PAGE_VERIFY CHECKSUM  

ALTER DATABASE [SP_SE] SET DB_CHAINING OFF 

ALTER DATABASE [SP_SE] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 

ALTER DATABASE [SP_SE] SET TARGET_RECOVERY_TIME = 0 SECONDS 

ALTER DATABASE [SP_SE] SET DELAYED_DURABILITY = DISABLED 

ALTER DATABASE [SP_SE] SET  READ_WRITE 