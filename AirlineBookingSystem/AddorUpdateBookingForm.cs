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
    public partial class AddorUpdateBookingForm : Form
    {
        public AddorUpdateBookingForm()
        {
            InitializeComponent();

            //Initialize the form
            this.Load += AddorUpdateBookingForm_Load;

            //set the button handlers
            buttonAdd.Click += ButtonAdd_Click;
            buttonUpdate.Click += ButtonUpdate_Click;

            //set the gridview handler
            dataGridViewBooking.Click += (s, e) => GetBooking();
        }
        /// <summary>
        /// This method adds booking
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            //instert a new passenger
            BookingDetail bookingDetail = new BookingDetail();

            bookingDetail.Customer_ID = Int16.Parse(textBoxCustomerID.Text);
            bookingDetail.Source = textBoxSource.Text;
            bookingDetail.Destination = textBoxDestination.Text;
            bookingDetail.DateOfJourney = textBoxDateOfJourney.Text;
            bookingDetail.SeatNo = Int16.Parse(textBoxSeatNo.Text);


            if (Controller<AirlineReservationSystemEntity, BookingDetail>.AddEntity(bookingDetail) == null)
            {
                MessageBox.Show("Cannot add booking Details to database");
                return;
            }
            this.DialogResult = DialogResult.OK;

            Close();
        }
        /// <summary>
        /// This method updates passenger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            if (!(dataGridViewBooking.CurrentRow.DataBoundItem is BookingDetail bookingDetail))
            {
                MessageBox.Show("Booking must be selected for updation!");
                return;
            }

            //Gets info
            bookingDetail.Customer_ID = Int16.Parse(textBoxCustomerID.Text);
            bookingDetail.Source = textBoxSource.Text;
            bookingDetail.Destination = textBoxDestination.Text;
            bookingDetail.DateOfJourney = textBoxDateOfJourney.Text;
            bookingDetail.SeatNo = Int16.Parse(textBoxSeatNo.Text);

            if (Controller<AirlineReservationSystemEntity, BookingDetail>.UpdateEntity(bookingDetail) == false)
            {
                MessageBox.Show("Cannot update Booking Details to database");
                return;
            }
            this.DialogResult = DialogResult.OK;

            Close();
        }

        /// <summary>
        /// This method gets the flight if it was selected
        /// in the gridview
        /// </summary>
        private void GetBooking()
        {

            if (!(dataGridViewBooking.CurrentRow.DataBoundItem is BookingDetail bookingDetail))
                return;
           
            textBoxCustomerID.Text = bookingDetail.Customer_ID.ToString();
            textBoxSource.Text = bookingDetail.Source;
            textBoxDestination.Text = bookingDetail.Destination;
            textBoxDateOfJourney.Text = bookingDetail.DateOfJourney;
            textBoxSeatNo.Text = bookingDetail.SeatNo.ToString();

        }
        /// <summary>
        /// The method sets default setting for the child form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddorUpdateBookingForm_Load(object sender, EventArgs e)
        {
            dataGridViewBooking.AllowUserToAddRows = false;
            dataGridViewBooking.AllowUserToDeleteRows = false;
            dataGridViewBooking.ReadOnly = true;
            dataGridViewBooking.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            dataGridViewBooking.DataSource = Controller<AirlineReservationSystemEntity, BookingDetail>.SetBindingList();
            string[] columnsToHide = new string[3];
            columnsToHide[0] = "PassengerDetail";
            columnsToHide[1] = "Carrier_ID";
            columnsToHide[2] = "Carrier";
            foreach (string column in columnsToHide)
                dataGridViewBooking.Columns[column].Visible = false;
        }
        /// <summary>
        /// This method does the validation for the user input
        /// </summary>
        /// <returns></returns>
        private Boolean validateFormInput()
        {

            return true;
        }

    }
}