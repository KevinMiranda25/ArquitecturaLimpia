USE [master]
GO
CREATE DATABASE [ESFEDB]
GO
USE [ESFEDB]
GO
-- Crear la tabla de User
CREATE TABLE [dbo].[User](
  [Id] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
  [Email] [varchar](100) NOT NULL,
  [Password] [varchar](30) NOT NULL,
  [Name] [varchar](50) NOT NULL
)