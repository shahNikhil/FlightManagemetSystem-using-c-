﻿CREATE TABLE [dbo].[Admin]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY (1, 1),
    [UserName] NVARCHAR(50) NULL, 
    [Password] NVARCHAR(50) NULL
)
