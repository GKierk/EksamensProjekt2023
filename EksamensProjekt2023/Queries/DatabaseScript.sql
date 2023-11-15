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
    UserID INT PRIMARY KEY,
    Username NVARCHAR(25),
    FirstName NVARCHAR(15),
    LastName NVARCHAR(15),
    UserPassword NVARCHAR(25),
    Email NVARCHAR(55),
    PhoneNumber INT,
    IsAdmin BIT,
    IsLeader BIT,
    IsApproved BIT,
)

--CREATE TABLE Sale (
--    SaleID int PRIMARY KEY,
--    Assignee NVARCHAR(25),
--    DateGiven DATETIME,
--    DateSold DATETIME,
--    AssignedAmout INT,
--    SalesAmount INT,
--    Income INT,
--)

CREATE TABLE Groups (
    GroupID INT PRIMARY KEY,
    GroupName NVARCHAR(15),
    Member INT,
)

--CREATE TABLE MessageLog (
--    MessageID INT PRIMARY KEY,
--    DateSent DATETIME,
--    Sender NVARCHAR(25),
--    Reciever NVARCHAR(25),
--    MessageText NVARCHAR(255),
--    IsRead BIT,
--)

--ALTER TABLE Sale
--    ADD CONSTRAINT FK_Assignee_Username
--    FOREIGN KEY (Assignee) REFERENCES Users(Username)

ALTER TABLE Groups
    ADD CONSTRAINT FK_Member_Username
    FOREIGN KEY (Member) REFERENCES Users(UserID)

--ALTER TABLE MessageLog
--    ADD CONSTRAINT FK_Sender_Username
--    FOREIGN KEY (Sender) REFERENCES Users(Username)

--ALTER TABLE MessageLog
--    ADD CONSTRAINT FK_Reciever_Username
--    FOREIGN KEY (RECIEVER) REFERENCES Users(Username)


INSERT INTO Users (UserID, Username, FirstName, LastName, UserPassword, Email, PhoneNumber, IsAdmin, IsLeader, IsApproved) VALUES (1, 'Tastan', 'Tastan', 'Tastan', 'EverybodyKnowsThePassword', 'Tastan@Tastan.dk', 88888888, 1, 0, 1)

USE MASTER