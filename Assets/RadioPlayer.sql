CREATE DATABASE [RadioPlayer_Db]


USE [RadioPlayer_Db]


CREATE TABLE [Radio]
(
IdRadio INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
RadioName NVARCHAR(max) NOT NULL,
ImageRadio NVARCHAR(max) NOT NULL,
RadioFile NVARCHAR(max) NOT NULL,
RadioCountry NVARCHAR(max) NOT NULL,
)