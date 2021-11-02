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
    public partial class ViewBookings : Form
    {
        public ViewBookings()
        {
            // unit-of-work pattern for context
            using (AirlineReservationSystemEntity context = Controller<AirlineReservationSystemEntity, DbSet>.SetContext())
            {
                //call seed database extension method defined in SeedDatabaseExtensionMethods cs file
                context.SeedDatabase();
            }
            InitializeComponent();
            InitializeDataGridView<BookingDetail>(bookingsView, "Carrier","PassengerDetail");
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
