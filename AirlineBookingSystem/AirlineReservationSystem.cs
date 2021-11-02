using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AirlineBookingSystem;
using System.Data.Entity;
using System.Diagnostics;
using AirlineReservationCodeFirstFromDB;
using EFControllerUtilities;
using SeedDatabaseExtensions;

namespace AirlineBookingSystem
{
    public partial class AirlineReservationSystem : Form
    {
        public AirlineReservationSystem()
        {
            // unit-of-work pattern for context
            using (AirlineReservationSystemEntity context = Controller<AirlineReservationSystemEntity, DbSet>.SetContext())
            {
                //call seed database extension method defined in SeedDatabaseExtensionMethods cs file
                //uncomment only if you want to do everything from manage reservation as you are booking flight outside this form calling
                //this method will resulting in resetting the database back to the original data
                context.SeedDatabase();
            }
            InitializeComponent();
            this.Text = "Airline Reservation System";
            //creating onclicklisteners for all the button to open the child forms
            this.bookFlightButton.Click += new System.EventHandler(this.bookFlightButtonClick);
            this.viewBookingButton.Click += new System.EventHandler(this.viewBookingButtonClick);
            this.viewPassengerDetailButton.Click += new System.EventHandler(this.viewPassengerDetailsButtonClick);
            this.viewTransactionButton.Click += new System.EventHandler(this.viewTransactionsButtonClick);
            this.manageReservatinButton.Click += new System.EventHandler(this.manageReservationButtonClick);
        }


        /// <summary>
        /// This is a onlick listener which opens the bookflight form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bookFlightButtonClick(object sender, EventArgs e)
        {
            BookFlight bookFlight = new BookFlight();
            bookFlight.Show();
        }
        /// <summary>
        ///  This is a onlick listener which opens the booking list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void viewBookingButtonClick(object sender, EventArgs e)
        {
            ViewBookings viewBookings = new ViewBookings();
            viewBookings.Show();
        }
        /// <summary>
        ///  This is a onlick listener which opens the Passenger details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void viewPassengerDetailsButtonClick(object sender, EventArgs e)
        {
            PassengerDetails passengerDetails = new PassengerDetails();
            passengerDetails.Show();
        }
        /// <summary>
        ///  This is a onlick listener which opens up all the transactions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void viewTransactionsButtonClick(object sender, EventArgs e)
        {
            ViewFlights viewTransactions = new ViewFlights();
            viewTransactions.Show();
        }
        /// <summary>
        /// This is a onlick listener which opens up the manage reservation and 
        /// perform the crud on that
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void manageReservationButtonClick(object sender, EventArgs e)
        {
            try
            {
                ManageReservation manageReservation = new ManageReservation();
                manageReservation.Show();
            }catch(Exception ex)
            {
                System.Console.WriteLine(ex.ToString());
            }
        }


    }
}
