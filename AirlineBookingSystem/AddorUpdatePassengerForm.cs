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
    public partial class AddorUpdatePassengerForm : Form
    {

        public AddorUpdatePassengerForm()
        {

            InitializeComponent();


            //Initialize the form
            this.Load += AddorUpdatePassengerForm_Load;

            //set the button handlers
            addButton.Click += ButtonAdd_Click;
            updateButton.Click += ButtonUpdate_Click;

            //set the gridview handler
            passengerView.Click += (s, e) => GetPassenger();
        }
        /// <summary>
        /// This method adds passenger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            //instert a new passenger
            PassengerDetail passengerDetail = new PassengerDetail();

            passengerDetail.FirstName = textBoxFirstName.Text;
            passengerDetail.LastName = textBoxLastName.Text;
            passengerDetail.DateOfBirth = textBoxDateOfBirth.Text;
            passengerDetail.Email = textBoxMail.Text;
            passengerDetail.Phone = textBoxPhone.Text;
            passengerDetail.Address = textBoxAddress.Text;

            if (Controller<AirlineReservationSystemEntity, PassengerDetail>.AddEntity(passengerDetail) == null)
            {
                MessageBox.Show("Cannot add Passenger Details to database");
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
          if (!(passengerView.CurrentRow.DataBoundItem is PassengerDetail passengerDetail))
            {
                MessageBox.Show("Passenger must be selected for updation!");
                return;
            }

            //Gets info
            passengerDetail.FirstName = textBoxFirstName.Text;
            passengerDetail.LastName = textBoxLastName.Text;
            passengerDetail.DateOfBirth = textBoxDateOfBirth.Text;
            passengerDetail.Email = textBoxMail.Text;
            passengerDetail.Phone = textBoxPhone.Text;
            passengerDetail.Address = textBoxAddress.Text;

            if (Controller<AirlineReservationSystemEntity, PassengerDetail>.UpdateEntity(passengerDetail) == false)
            {
                MessageBox.Show("Cannot update Passenger Details to database");
                return;
            }
            this.DialogResult = DialogResult.OK;

            Close();
        }

        /// <summary>
        /// This method gets the passenger if it was selected
        /// in the gridview
        /// </summary>
        private void GetPassenger()
        {
           
            if (!(passengerView.CurrentRow.DataBoundItem is PassengerDetail passengerDetail))
                return;
            textBoxFirstName.Text = passengerDetail.FirstName;
            textBoxLastName.Text = passengerDetail.LastName;
            textBoxDateOfBirth.Text = passengerDetail.DateOfBirth;
            textBoxMail.Text = passengerDetail.Email;
            textBoxPhone.Text = passengerDetail.Phone;
            textBoxAddress.Text = passengerDetail.Address;
        }
        /// <summary>
        /// The method sets default setting for the child form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddorUpdatePassengerForm_Load(object sender, EventArgs e)
        {
            passengerView.AllowUserToAddRows = false;
            passengerView.AllowUserToDeleteRows = false;
            passengerView.ReadOnly = true;
            passengerView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            passengerView.DataSource = Controller<AirlineReservationSystemEntity, PassengerDetail>.SetBindingList();
            string [] columnsToHide =new string[1];
            columnsToHide[0] = "BookingDetails";
            foreach (string column in columnsToHide)
                passengerView.Columns[column].Visible = false;
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
