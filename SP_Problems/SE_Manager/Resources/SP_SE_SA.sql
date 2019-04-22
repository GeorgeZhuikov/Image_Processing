USE [master]
CREATE LOGIN [IIS APPPOOL\SP_SE] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
USE [SP_SE]
CREATE USER [IIS APPPOOL\SP_SE] FOR LOGIN [IIS APPPOOL\SP_SE] WITH DEFAULT_SCHEMA=[dbo]
ALTER ROLE db_datareader ADD MEMBER [IIS APPPOOL\SP_SE];  