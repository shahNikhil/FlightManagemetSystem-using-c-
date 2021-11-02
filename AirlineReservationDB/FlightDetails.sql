CREATE TABLE [dbo].[FlightDetails]
(
	[Flight_ID] INT NOT NULL IDENTITY (1, 1),
    [Flight_Name] NVARCHAR(50) NULL, 
    [Source] NVARCHAR(50) NULL, 
    [Destination] NVARCHAR(50) NULL, 
    [Arrival_Time] NVARCHAR(50) NULL, 
    [Departure] NVARCHAR(50) NULL, 
    [Flight_Class] NVARCHAR(50) NULL, 
    [Flight_Charges] DECIMAL NULL, 
    [Seats] INT NULL,
    [Airplane Name] NVARCHAR(50) NULL,
    [Carrier_ID] int null,
    CONSTRAINT [PK_Flight_Details] PRIMARY KEY ([Flight_ID]),
    CONSTRAINT [FK_Carrier] FOREIGN KEY ([Carrier_ID]) REFERENCES [Carrier] ([Carrier_ID])
);
