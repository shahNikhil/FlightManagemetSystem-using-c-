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
    public partial class AddorUpdateFlightForm : Form
    {
        public AddorUpdateFlightForm()
        {
            InitializeComponent();

            //Initialize the form
            this.Load += AddorUpdateFlightForm_Load;

            //set the button handlers
            buttonAdd.Click += ButtonAdd_Click;
            buttonUpdate.Click += ButtonUpdate_Click;

            //set the gridview handler
            dataGridViewFlight.Click += (s, e) => GetFlight();
        }
        /// <summary>
        /// This method adds passenger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            //instert a new passenger
            FlightDetail flightDetail = new FlightDetail();

            flightDetail.Flight_Name = textBoxFlightName.Text;
            flightDetail.Source = textBoxSource.Text;
            flightDetail.Destination = textBoxDestination.Text;
            flightDetail.Arrival_Time = textBoxArrivalTime.Text;
            flightDetail.Departure = textBoxDeparture.Text;
            flightDetail.Flight_Class = textBoxFlightClass.Text;
            flightDetail.Seats = Int16.Parse(textBoxSeats.Text);
            flightDetail.Airplane_Name = textBoxAirplaneName.Text;

            if (Controller<AirlineReservationSystemEntity, FlightDetail>.AddEntity(flightDetail) == null)
            {
                MessageBox.Show("Cannot add Flight Details to database");
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
            if (!(dataGridViewFlight.CurrentRow.DataBoundItem is FlightDetail flightDetail))
            {
                MessageBox.Show("Flight must be selected for updation!");
                return;
            }

            //Gets info
            flightDetail.Flight_Name = textBoxFlightName.Text;
            flightDetail.Source = textBoxSource.Text;
            flightDetail.Destination = textBoxDestination.Text;
            flightDetail.Arrival_Time = textBoxArrivalTime.Text;
            flightDetail.Departure = textBoxDeparture.Text;
            flightDetail.Flight_Class = textBoxFlightClass.Text;
            flightDetail.Seats = Int16.Parse(textBoxSeats.Text);
            flightDetail.Airplane_Name = textBoxAirplaneName.Text;

            if (Controller<AirlineReservationSystemEntity, FlightDetail>.UpdateEntity(flightDetail) == false)
            {
                MessageBox.Show("Cannot update Flight Details to database");
                return;
            }
            this.DialogResult = DialogResult.OK;

            Close();
        }

        /// <summary>
        /// This method gets the flight if it was selected
        /// in the gridview
        /// </summary>
        private void GetFlight()
        {

            if (!(dataGridViewFlight.CurrentRow.DataBoundItem is FlightDetail flightDetail))
                return;

            textBoxFlightName.Text =  flightDetail.Flight_Name;
            textBoxSource.Text = flightDetail.Source;
            textBoxDestination.Text = flightDetail.Destination;
            textBoxArrivalTime.Text = flightDetail.Arrival_Time;
            textBoxDeparture.Text = flightDetail.Departure;
            textBoxFlightClass.Text = flightDetail.Flight_Class;
            textBoxSeats.Text = flightDetail.Seats.ToString();
            textBoxAirplaneName.Text = flightDetail.Airplane_Name;
        }
        /// <summary>
        /// The method sets default setting for the child form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddorUpdateFlightForm_Load(object sender, EventArgs e)
        {
            dataGridViewFlight.AllowUserToAddRows = false;
            dataGridViewFlight.AllowUserToDeleteRows = false;
            dataGridViewFlight.ReadOnly = true;
            dataGridViewFlight.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            dataGridViewFlight.DataSource = Controller<AirlineReservationSystemEntity, FlightDetail>.SetBindingList();
            string[] columnsToHide = new string[3];
            columnsToHide[0] = "Flight_Charges";
            columnsToHide[1] = "Carrier_ID";
            columnsToHide[2] = "Carrier";
            foreach (string column in columnsToHide)
                dataGridViewFlight.Columns[column].Visible = false;
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