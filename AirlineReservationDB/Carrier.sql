CREATE TABLE [dbo].[Carrier]
(
	[Carrier_ID] INT NOT NULL PRIMARY KEY IDENTITY (1, 1), 
    [Airplane Name] NVARCHAR(50) NULL, 
    [Country] NVARCHAR(50) NULL, 
    [Flight_Name] NVARCHAR(50) NULL
);

GO
CREATE NONCLUSTERED INDEX [IX_Carrier_ID]
    ON [dbo].[Carrier]([Carrier_ID] ASC);
