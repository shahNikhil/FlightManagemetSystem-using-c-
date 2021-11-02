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
    public partial class PassengerDetails : Form
    {
        public PassengerDetails()
        {
            // unit-of-work pattern for context
            using (AirlineReservationSystemEntity context = Controller<AirlineReservationSystemEntity, DbSet>.SetContext())
            {
                //call seed database extension method defined in SeedDatabaseExtensionMethods cs file
                context.SeedDatabase();
            }
            InitializeComponent();
            //calling method to initialize datagridview
            InitializeDataGridView<PassengerDetail>(passengerDetailsView,"BookingDetails");
            passengerNameTextBox.TextChanged += PassengerNameTextBox_TextChanged;
        }

        private void PassengerNameTextBox_TextChanged(object sender, EventArgs e)
        {
            //(passengerDetailsView.DataSource as DataTable).DefaultView.RowFilter = string.Format("FirstName LIKE '%{0}%'", passengerNameTextBox.Text);
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
            gridView.AllowUserToDeleteRows = false;
            gridView.ReadOnly = true;
            gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            gridView.DataSource = Controller<AirlineReservationSystemEntity, T>.SetBindingList();

            foreach (string column in columnsToHide)
                gridView.Columns[column].Visible = false;
        }
    }
}
