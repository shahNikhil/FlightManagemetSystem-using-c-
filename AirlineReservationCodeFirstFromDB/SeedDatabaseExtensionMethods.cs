using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using AirlineReservationCodeFirstFromDB;
using System.Data.Entity;

namespace SeedDatabaseExtensions
{

    public static class SeedDatabaseExtensionMethods
    {
        /// <summary>
        /// delete db tables, then seed all tables with initial data
        /// </summary>
        public static void SeedDatabase(this AirlineReservationSystemEntity context)
        {
            // set up database log to write to output window in VS
            context.Database.Log = (s =>Debug.Write(s));


            // reset the db
            context.Database.Delete();
            context.Database.Create();

            context.SaveChanges();



            context.Admins.Load();
            context.Carriers.Load();
            context.FlightDetails.Load();
            context.PassengerDetails.Load();
            context.BookingDetails.Load();


            //seed the data 
            List<Admin> adminList = new List<Admin>() { 
            new Admin {UserName ="aakash",Password="admin1"},
            new Admin {UserName ="nikhil",Password="admin2"},
            new Admin {UserName ="rashmeet",Password="admin3"}
            };
            context.Admins.AddRange(adminList);
            context.SaveChanges();

            List<Carrier> carrierList = new List<Carrier>()
            {
                new Carrier{Airplane_Name="ac1",Country="CANADA",Flight_Name="Air Canada"},
                new Carrier{Airplane_Name="ac2",Country="CHINA",Flight_Name="Air China"},
                new Carrier{Airplane_Name="lu6",Country="USA",Flight_Name="Lufthanza"},
                new Carrier{Airplane_Name="em5",Country="USA",Flight_Name="Emirates"},
                new Carrier{Airplane_Name="ba4",Country="LONDON",Flight_Name="British Airways"},
                new Carrier{Airplane_Name="ai3",Country="INDIA",Flight_Name="Air India"}
            };
            context.Carriers.AddRange(carrierList);
            context.SaveChanges();

            //Using a dictionary to store valid FlightName in FlightDetail
            Dictionary<string, Carrier> flightName = carrierList.ToDictionary(x => x.Flight_Name, x => x);
            context.Carriers.AddRange(flightName.Values);
            context.SaveChanges();

            List<FlightDetail> flightList = new List<FlightDetail>()
            {
               new FlightDetail{Flight_Name="Air Canada",Source="YVR",Destination="HKG",Arrival_Time="10:00",Departure="22:00",Flight_Class="ECONOMY",Seats=100,Airplane_Name ="ac1" },
               new FlightDetail{Flight_Name="Air China",Source="BOM",Destination="LHR",Arrival_Time="10:00",Departure="22:00",Flight_Class="ECONOMY",Seats=100,Airplane_Name ="ac2"},
               new FlightDetail{Flight_Name="Air India",Source="LHR",Destination="BOM",Arrival_Time="10:00",Departure="22:00",Flight_Class="ECONOMY",Seats=100,Airplane_Name ="ai3"},
               new FlightDetail{Flight_Name="British Airways",Source="HKG",Destination="YVR",Arrival_Time="10:00",Departure="22:00",Flight_Class="ECONOMY",Seats=100,Airplane_Name ="ba4"},
               new FlightDetail{Flight_Name="Emirates",Source="DIY",Destination="RIP",Arrival_Time="10:00",Departure="22:00",Flight_Class="ECONOMY",Seats=100,Airplane_Name ="em5"},
               new FlightDetail{Flight_Name="Lufthanza",Source="RIP",Destination="DIY",Arrival_Time="10:00",Departure="22:00",Flight_Class="ECONOMY",Seats=100,Airplane_Name ="lu6"},
            };
            context.FlightDetails.AddRange(flightList);
            context.SaveChanges();

            //Using a dictionary to store valid source in FlightDetail
            Dictionary<string, FlightDetail> sourceFlight = flightList.ToDictionary(x => x.Source, x => x);
            context.FlightDetails.AddRange(sourceFlight.Values);
            context.SaveChanges();

            List<PassengerDetail> passengerList = new List<PassengerDetail>()
            {
                new PassengerDetail{FirstName="Nikhil",LastName="Shah",DateOfBirth="07-10-1997",Email="shahn6@studentdouglascollege.ca",Phone="911",Address="USA"},
                new PassengerDetail{FirstName="Akash",LastName="Nayyar",DateOfBirth="07-01-1998",Email="shaha@studentdouglascollege.ca",Phone="911",Address="Surrey"},
                new PassengerDetail{FirstName="Rashmeet",LastName="Kaur",DateOfBirth="05-10-2020",Email="shahr@studentdouglascollege.ca",Phone="911",Address="Surrey"},
                new PassengerDetail{FirstName="Henil",LastName="Shah",DateOfBirth="10-06-1997",Email="shahh@studentdouglascollege.ca",Phone="911",Address="new west"},
                new PassengerDetail{FirstName="Tanvi",LastName="Somani",DateOfBirth="04-10-1997",Email="somanit@studentdouglascollege.ca",Phone="911",Address="new west"},
                new PassengerDetail{FirstName="Prajakta",LastName="Selukar",DateOfBirth="07-08-1997",Email="selukarp@studentdouglascollege.ca",Phone="911",Address="Burnaby"},
                new PassengerDetail{FirstName="Ninad",LastName="Tande",DateOfBirth="07-10-1996",Email="tanden@studentdouglascollege.ca",Phone="911",Address="Burnaby"},
            };
            context.PassengerDetails.AddRange(passengerList);
            context.SaveChanges();

            List<BookingDetail> bookingList = new List<BookingDetail>()
            {
                new BookingDetail{ Carrier_ID=1,Customer_ID=4,Source="RIP",Destination="DIY",DateOfJourney="20-01-2021",SeatNo=1},
                new BookingDetail{ Carrier_ID=3,Customer_ID=1,Source="RIP",Destination="DIY",DateOfJourney="20-01-2021",SeatNo=2},
                new BookingDetail{ Carrier_ID=4,Customer_ID=4,Source="DIY",Destination="RIP",DateOfJourney="20-01-2021",SeatNo=1},
                new BookingDetail{ Carrier_ID=4,Customer_ID=1,Source="DIY",Destination="RIP",DateOfJourney="20-01-2021",SeatNo=2},
            };

            context.BookingDetails.AddRange(bookingList);
            context.SaveChanges();
        }
    }
}
