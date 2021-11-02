/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/


SET IDENTITY_INSERT [dbo].[PassengerDetails] ON
INSERT INTO [dbo].[PassengerDetails] ([Customer_ID], [FirstName], [LastName],[DateOfBirth],[Email],[Phone],[Address]) VALUES (1,N'Nikhil', N'Shah','07-10-1997','shahn6@studentdouglascollege.ca','911','USA')
INSERT INTO [dbo].[PassengerDetails] ([Customer_ID], [FirstName], [LastName],[DateOfBirth],[Email],[Phone],[Address]) VALUES (2,N'Akash', N'Nayyar','07-01-1998','shaha@studentdouglascollege.ca','911','Surrey')
INSERT INTO [dbo].[PassengerDetails] ([Customer_ID], [FirstName], [LastName],[DateOfBirth],[Email],[Phone],[Address]) VALUES (3,N'Rashmeet', N'Kaur','05-10-2020','shahr@studentdouglascollege.ca','911','Surrey')
INSERT INTO [dbo].[PassengerDetails] ([Customer_ID], [FirstName], [LastName],[DateOfBirth],[Email],[Phone],[Address]) VALUES (4,N'Henil', N'Shah','10-06-1997','shahh@studentdouglascollege.ca','911','new west')
INSERT INTO [dbo].[PassengerDetails] ([Customer_ID], [FirstName], [LastName],[DateOfBirth],[Email],[Phone],[Address]) VALUES (5,N'Tanvi', N'Somani','04-10-1997','somanit@studentdouglascollege.ca','911','new west')
INSERT INTO [dbo].[PassengerDetails] ([Customer_ID], [FirstName], [LastName],[DateOfBirth],[Email],[Phone],[Address]) VALUES (6,N'Prajakta', N'Selukar','07-08-1997','selukarp@studentdouglascollege.ca','911','Burnaby')
INSERT INTO [dbo].[PassengerDetails] ([Customer_ID], [FirstName], [LastName],[DateOfBirth],[Email],[Phone],[Address]) VALUES (7,N'Ninad', N'Tande','07-10-1996','tanden@studentdouglascollege.ca','911','Burnaby')
SET IDENTITY_INSERT [dbo].[PassengerDetails] OFF
go

SET IDENTITY_INSERT [dbo].[FlightDetails] ON
INSERT INTO [dbo].[FlightDetails] ([Flight_ID], [Flight_Name], [Source],[Destination],[Arrival_Time],[Departure],[Flight_Class],[Seats],[Airplane Name])  VALUES (1,N'Air Canada', N'YVR','N HKG',N'10:00',N'22:00',N'ECONOMY',100,N'ac1')
INSERT INTO [dbo].[FlightDetails] ([Flight_ID], [Flight_Name], [Source],[Destination],[Arrival_Time],[Departure],[Flight_Class],[Seats],[Airplane Name]) VALUES (2,N'Air China', N'YVR','N BOM',N'10:00',N'22:00',N'ECONOMY',99,N'ac2')
INSERT INTO [dbo].[FlightDetails] ([Flight_ID], [Flight_Name], [Source],[Destination],[Arrival_Time],[Departure],[Flight_Class],[Seats],[Airplane Name]) VALUES (3,N'Air India', N'BOM','N LEX',N'10:00',N'22:00',N'ECONOMY',80,N'ai3')
INSERT INTO [dbo].[FlightDetails] ([Flight_ID], [Flight_Name], [Source],[Destination],[Arrival_Time],[Departure],[Flight_Class],[Seats],[Airplane Name]) VALUES (4,N'British Airways', N'LHR','N YVR',N'10:00',N'22:00',N'ECONOMY',115,N'ba4')
INSERT INTO [dbo].[FlightDetails] ([Flight_ID], [Flight_Name], [Source],[Destination],[Arrival_Time],[Departure],[Flight_Class],[Seats],[Airplane Name]) VALUES (5,N'Emirates', N'DIY',N'RIP',N'10:00',N'22:00',N'ECONOMY',125,N'em5')
INSERT INTO [dbo].[FlightDetails] ([Flight_ID], [Flight_Name], [Source],[Destination],[Arrival_Time],[Departure],[Flight_Class],[Seats],[Airplane Name]) VALUES (6,N'Lufthanza', N'RIP','N DIY',N'10:00',N'22:00',N'ECONOMY',110,N'lu6')
SET IDENTITY_INSERT [dbo].[FlightDetails] OFF
go

SET IDENTITY_INSERT [dbo].[Admin] ON
INSERT INTO [dbo].[Admin] ([Id],[UserName],[Password]) VALUES(1,N'aakash',N'admin1')
INSERT INTO [dbo].[Admin] ([Id],[UserName],[Password]) VALUES(2,N'nikhil',N'admin2')
INSERT INTO [dbo].[Admin] ([Id],[UserName],[Password]) VALUES(3,N'rashmeet',N'admin3')
SET IDENTITY_INSERT [dbo].[Admin] OFF
go

SET IDENTITY_INSERT [dbo].[Carrier] ON
INSERT INTO [dbo].[Carrier] ([Carrier_ID],[Airplane Name],[Country]) VALUES (1,N'ac1',N'CANADA')
INSERT INTO [dbo].[Carrier] ([Carrier_ID],[Airplane Name],[Country]) VALUES (2,N'ac2',N'CHINA')
INSERT INTO [dbo].[Carrier] ([Carrier_ID],[Airplane Name],[Country]) VALUES (3,N'lu6',N'USA')
INSERT INTO [dbo].[Carrier] ([Carrier_ID],[Airplane Name],[Country]) VALUES (4,N'em5',N'USA')
INSERT INTO [dbo].[Carrier] ([Carrier_ID],[Airplane Name],[Country]) VALUES (5,N'ba4',N'LONDON')
INSERT INTO [dbo].[Carrier] ([Carrier_ID],[Airplane Name],[Country]) VALUES (6,N'ai3',N'INDIA')
SET IDENTITY_INSERT [dbo].[Carrier] OFF
go

SET IDENTITY_INSERT [dbo].[BookingDetails] ON
INSERT INTO [dbo].[BookingDetails] ([Booking_ ID],[Carrier_ID],[Customer_ID],[Source],[Destination],[DateOfJourney],[SeatNo]) VALUES (1,3,4, N'RIP',N'DIY','20-01-2021',1)
INSERT INTO [dbo].[BookingDetails] ([Booking_ ID],[Carrier_ID],[Customer_ID],[Source],[Destination],[DateOfJourney],[SeatNo]) VALUES (2,3,1, N'RIP',N'DIY','20-01-2021',2)
INSERT INTO [dbo].[BookingDetails] ([Booking_ ID],[Carrier_ID],[Customer_ID],[Source],[Destination],[DateOfJourney],[SeatNo]) VALUES (3,4,4, N'DIY',N'RIP','25-01-2021',1)
INSERT INTO [dbo].[BookingDetails] ([Booking_ ID],[Carrier_ID],[Customer_ID],[Source],[Destination],[DateOfJourney],[SeatNo]) VALUES (4,4,1, N'DIY',N'RIP','25-01-2021',2)
SET IDENTITY_INSERT [dbo].[BookingDetails] OFF
go