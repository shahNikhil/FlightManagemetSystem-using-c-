using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AirlineBookingSystem;
using AirlineReservationCodeFirstFromDB;
using EFControllerUtilities;
using SeedDatabaseExtensions;

namespace AirlineBookingSystem
{
    public partial class BookFlight : Form
    {
        public BookFlight()
        {
            InitializeComponent();

            //Initialize the form
            this.Load += BookingForm_Load;

            //button click handlers
            buttonGoBack.Click += ButtonGoBackClick;
            buttonBook.Click += ButtonBookClick;

            //datgrid get selected id
            dataGridViewPassenger.Click += (s, e) => GetPassenger();
            dataGridViewCarrier.Click += (s, e) => GetCarrier();
           
        }
        /// <summary>
        /// this creates a booking on click of the book button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonBookClick(object sender, EventArgs e)
        {
            //insert new booking in database
            BookingDetail bookingDetail = new BookingDetail();
            
                bookingDetail.Carrier_ID = Int16.Parse(textBoxCarrierID.Text);
                bookingDetail.Customer_ID = Int16.Parse(textBoxCustomerID.Text);
                bookingDetail.Source = textBoxSource.Text;
                bookingDetail.Destination = textBoxDestination.Text;
                bookingDetail.DateOfJourney = dateTimePicker.Text.ToString();
                bookingDetail.SeatNo = Int16.Parse(textBoxSeatNo.Text);
            if (Controller<AirlineReservationSystemEntity, BookingDetail>.AddEntity(bookingDetail) == null)
            {
                MessageBox.Show("Cannot add booking Details to database");
                return;
            }
            this.DialogResult = DialogResult.OK;
            MessageBox.Show("Success");
            Close();
        }

        /// <summary>
        /// goes back to home page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonGoBackClick(object sender,EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// This method gets the passenger if it was selected
        /// in the gridview
        /// </summary>
        private void GetPassenger()
        {

            if (!(dataGridViewPassenger.CurrentRow.DataBoundItem is PassengerDetail passengerDetail))
                return;
            textBoxCustomerID.Text = passengerDetail.Customer_ID.ToString();

        }
        /// <summary>
        /// This method gets the Carrier if it was selected
        /// in the gridview
        /// </summary>
        private void GetCarrier()
        {

            if (!(dataGridViewCarrier.CurrentRow.DataBoundItem is Carrier passengerDetail))
                return;
            textBoxCarrierID.Text = passengerDetail.Carrier_ID.ToString();

        }

        /// <summary>
        /// This method load the data in the gridviews and list boxes
        /// it bind the respective values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BookingForm_Load(object sender, EventArgs e)
        {
            dataGridViewPassenger.AllowUserToAddRows = false;
            dataGridViewPassenger.AllowUserToDeleteRows = false;
            dataGridViewPassenger.ReadOnly = true;
            dataGridViewPassenger.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewCarrier.AllowUserToAddRows = false;
            dataGridViewCarrier.AllowUserToDeleteRows = false;
            dataGridViewCarrier.ReadOnly = true;
            dataGridViewCarrier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewCarrier.DataSource = Controller<AirlineReservationSystemEntity, Carrier>.SetBindingList();
            string[] hideForCarrier = new string[2];
            hideForCarrier[0] = "BookingDetails";
            hideForCarrier[1] = "FlightDetails";
            foreach (string column in hideForCarrier)
                dataGridViewCarrier.Columns[column].Visible = false;
            dataGridViewPassenger.DataSource = Controller<AirlineReservationSystemEntity, PassengerDetail>.SetBindingList();
            string[] columnsToHide = new string[1];
            columnsToHide[0] = "BookingDetails";
            foreach (string column in columnsToHide)
                dataGridViewPassenger.Columns[column].Visible = false;
        }
    }
}
