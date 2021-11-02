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
    public partial class ManageReservation : Form
    {
        public ManageReservation()
        {
            // unit-of-work pattern for context
            using (AirlineReservationSystemEntity context = Controller<AirlineReservationSystemEntity, DbSet>.SetContext())
            {

            }
            InitializeComponent();
            //Event Handlers to handle child forms
            AddorUpdatePassengerForm addOrUpdatePassengerForm = new AddorUpdatePassengerForm();
            addPassengerButton.Click += (s, e) => AddOrUpdateForm<PassengerDetail>(passengerDetailsView, addOrUpdatePassengerForm);

            AddorUpdateFlightForm addOrUpdateFlightForm = new AddorUpdateFlightForm();
            flightAddButton.Click += (s, e) => AddOrUpdateForm<FlightDetail>(flightDetailsView, addOrUpdateFlightForm);


            AddorUpdateBookingForm addOrUpdateBookingForm = new AddorUpdateBookingForm();
            addBookingButton.Click += (s, e) => AddOrUpdateForm<BookingDetail>(bookingsView, addOrUpdateBookingForm);

            //xml backup and restore
            backupXMLButton.Click += (s, e) => BackupToXML();
            restoreXMLButton.Click += (s, e) => RestoreFromXML();

            //calling method to initialize datagridview
            InitializeDataGridView<FlightDetail>(flightDetailsView, "Flight_Charges", "Carrier_ID", "Carrier");
            InitializeDataGridView<PassengerDetail>(passengerDetailsView, "BookingDetails");
            InitializeDataGridView<BookingDetail>(bookingsView, "Carrier", "PassengerDetail", "Carrier_ID");
        }
        /// <summary>
        /// method restore the data from xml
        /// </summary>

        private void RestoreFromXML()
        {
            //still work needed
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.RestoreDirectory = true;
            openFileDialog.DefaultExt = "XML";
            openFileDialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            openFileDialog.ShowDialog();
            string s = openFileDialog.FileName;


        }
        /// <summary>
        /// method backsup data to xml
        /// </summary>
        private void BackupToXML()
        {
            //still work needed
            SaveFileDialog SaveXMLFileDialog = new SaveFileDialog();
            SaveXMLFileDialog.Filter = "Xml files (.xml)|.xml";
            SaveXMLFileDialog.FilterIndex = 2;
            SaveXMLFileDialog.RestoreDirectory = true;
            SaveXMLFileDialog.InitialDirectory = Application.StartupPath;
            SaveXMLFileDialog.FileName = "backupAirlineReservationDB";
            SaveXMLFileDialog.Title = "XML Export";
            if (SaveXMLFileDialog.ShowDialog() == DialogResult.OK)
            {


                try
                {
                    DataTable dataTableFlightDetails = (DataTable)flightDetailsView.DataSource;
                    DataTable dataTablePassengerDetails = (DataTable)passengerDetailsView.DataSource;
                    DataTable dataTableBookingDetails = (DataTable)bookingsView.DataSource;
                    dataTableFlightDetails.WriteXml("backupAirlineReservationDB");
                    dataTablePassengerDetails.WriteXml("backupAirlineReservationDB");
                    dataTableBookingDetails.WriteXml("backupAirlineReservationDB");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }

            }
            else
            {
                MessageBox.Show("Cant Save the xml File! Please try again");
            }
        }

        /// <summary>
        /// generic method to initialize data gridviews
        /// this method is only created for displaying 
        /// the data and not for performing and updates
        /// ,add or delete
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="gridView"></param>
        /// <param name="columnsToHide"></param>
        private void InitializeDataGridView<T>(DataGridView gridView, params string[] columnsToHide) where T : class
        {
            //Sets grid controls
            gridView.AllowUserToAddRows = false;
            gridView.AllowUserToDeleteRows = true;
            gridView.ReadOnly = true;
            gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // set event handler used to delete an item
            gridView.UserDeletingRow += (s, e) => DeletingRow<T>(s as DataGridView, e);

            gridView.DataSource = Controller<AirlineReservationSystemEntity, T>.SetBindingList();

            foreach (string column in columnsToHide)
                gridView.Columns[column].Visible = false;
        }
        /// <summary>
        /// Generic method to display a form and then update the relevant gridviews.
        /// </summary>
        /// <typeparam name="T">Data type associated with the gridview</typeparam>
        /// <param name="dataGridView">DataGridView to be updated with new data from DB</param>
        /// <param name="form"></param>
        private void AddOrUpdateForm<T>(DataGridView dataGridView, Form form) where T : class
        {
            var result = form.ShowDialog();

            // form has closed

            if (result == DialogResult.OK)
            {
                // reload the db and update the gridview

                dataGridView.DataSource = Controller<AirlineReservationSystemEntity, T>.SetBindingList();

            }

            //Hide Form
            form.Hide();
        }
        /// <summary>
        /// Method to delete a row in a datagridview
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dataGridView"></param>
        /// <param name="e"></param>
        private void DeletingRow<T>(DataGridView dataGridView, DataGridViewRowCancelEventArgs e) where T : class
        {
            // Get item
            T item = e.Row.DataBoundItem as T;

            Debug.WriteLine("DeletingRow " + e.Row.Index + " entity " + typeof(T) + " " + item);

            // Delete the item in the DB. 
            Controller<AirlineReservationSystemEntity, T>.DeleteEntity(item);
            dataGridView.Refresh();

        }
    }
}
