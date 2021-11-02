CREATE TABLE [dbo].[BookingDetails]
(
	[Booking_ ID] INT NOT NULL IDENTITY(1000,1), 
    [Customer_ID] INT NULL,
    [Carrier_ID] INT NULL,
    [Source] NVARCHAR(50) NULL, 
    [Destination] NVARCHAR(50) NULL,
    [DateOfJourney] NVARCHAR(50) NULL,  
    [SeatNo] INT NULL,
    CONSTRAINT [PK_Booking_ID] PRIMARY KEY ([Booking_ ID]),
    CONSTRAINT [FK_Customer_ID] FOREIGN KEY ([Customer_ID]) REFERENCES [PassengerDetails] ([Customer_ID]),
    CONSTRAINT [FK_Carrier_ID] FOREIGN KEY ([Carrier_ID]) REFERENCES [Carrier] ([Carrier_ID])
)

GO
CREATE NONCLUSTERED INDEX [IX_customerId]
    ON [BookingDetails]([Customer_ID] ASC);

GO
CREATE NONCLUSTERED INDEX [IX_CarrierId]
    ON [BookingDetails]([Carrier_ID] ASC);
