CREATE TABLE [dbo].[PassengerDetails]
(
	[Customer_ID] INT NOT NULL IDENTITY (1, 1), 
    [FirstName] NVARCHAR(50) NULL, 
    [LastName] NVARCHAR(50) NULL, 
    [DateOfBirth] TEXT NULL, 
    [Email] NVARCHAR(50) NULL, 
    [Phone] NVARCHAR(50) NULL, 
    [Address] NVARCHAR(MAX) NULL,
    CONSTRAINT [PK_Customer_Details] PRIMARY KEY ([Customer_ID])
)
