-- =============================================
-- Date Created: 2023-11-14
-- Author: Gabriel H. Kierkegaard
-- =============================================

IF EXISTS (SELECT * FROM sys.databases WHERE NAME = 'TastanDB')
BEGIN
    EXEC('DROP DATABASE TastanDB')
END

CREATE DATABASE TastanDB

USE TastanDB

CREATE TABLE Users (
    Username NVARCHAR(25) PRIMARY KEY,
    FirstName NVARCHAR(15),
    LastName NVARCHAR(15),
    UserPassword NVARCHAR(25),
    Email NVARCHAR(55),
    PhoneNumber INT,
    IsAdmin BIT,
    IsLeader BIT,
    IsApproved BIT,
)

CREATE TABLE Sale (
    SaleID int PRIMARY KEY,
    Username NVARCHAR(25),
    DateGiven DATETIME,
    DateSold DATETIME,
    AssignedAmout INT,
    SalesAmount INT,
    Income INT,
)

CREATE TABLE Groups (
    GroupID INT PRIMARY KEY,
    GroupName NVARCHAR(15),
    Username NVARCHAR(25),
)

CREATE TABLE MessageLog (
    MessageID INT PRIMARY KEY,
    DateSent DATETIME,
    Sender NVARCHAR(25),
    Reciever NVARCHAR(25),
    MessageText NVARCHAR(255),
    IsRead BIT,
)

USE MASTER