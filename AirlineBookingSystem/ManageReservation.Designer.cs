namespace AirlineBookingSystem
{
    partial class ManageReservation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.passengerDetailsView = new System.Windows.Forms.DataGridView();
            this.bookingsView = new System.Windows.Forms.DataGridView();
            this.flightDetailsView = new System.Windows.Forms.DataGridView();
            this.addPassengerButton = new System.Windows.Forms.Button();
            this.addBookingButton = new System.Windows.Forms.Button();
            this.flightAddButton = new System.Windows.Forms.Button();
            this.backupXMLButton = new System.Windows.Forms.Button();
            this.restoreXMLButton = new System.Windows.Forms.Button();
            this.labelPassenger = new System.Windows.Forms.Label();
            this.labelBooking = new System.Windows.Forms.Label();
            this.labelFlight = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.passengerDetailsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightDetailsView)).BeginInit();
            this.SuspendLayout();
            // 
            // passengerDetailsView
            // 
            this.passengerDetailsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.passengerDetailsView.Location = new System.Drawing.Point(11, 32);
            this.passengerDetailsView.Margin = new System.Windows.Forms.Padding(2);
            this.passengerDetailsView.Name = "passengerDetailsView";
            this.passengerDetailsView.RowHeadersWidth = 62;
            this.passengerDetailsView.RowTemplate.Height = 28;
            this.passengerDetailsView.Size = new System.Drawing.Size(437, 145);
            this.passengerDetailsView.TabIndex = 0;
            // 
            // bookingsView
            // 
            this.bookingsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookingsView.Location = new System.Drawing.Point(490, 32);
            this.bookingsView.Margin = new System.Windows.Forms.Padding(2);
            this.bookingsView.Name = "bookingsView";
            this.bookingsView.RowHeadersWidth = 62;
            this.bookingsView.RowTemplate.Height = 28;
            this.bookingsView.Size = new System.Drawing.Size(460, 145);
            this.bookingsView.TabIndex = 1;
            // 
            // flightDetailsView
            // 
            this.flightDetailsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flightDetailsView.Location = new System.Drawing.Point(11, 252);
            this.flightDetailsView.Margin = new System.Windows.Forms.Padding(2);
            this.flightDetailsView.Name = "flightDetailsView";
            this.flightDetailsView.RowHeadersWidth = 62;
            this.flightDetailsView.RowTemplate.Height = 28;
            this.flightDetailsView.Size = new System.Drawing.Size(939, 184);
            this.flightDetailsView.TabIndex = 2;
            // 
            // addPassengerButton
            // 
            this.addPassengerButton.Location = new System.Drawing.Point(11, 181);
            this.addPassengerButton.Margin = new System.Windows.Forms.Padding(2);
            this.addPassengerButton.Name = "addPassengerButton";
            this.addPassengerButton.Size = new System.Drawing.Size(128, 34);
            this.addPassengerButton.TabIndex = 3;
            this.addPassengerButton.Text = "Add/update Passenger";
            this.addPassengerButton.UseVisualStyleBackColor = true;
            // 
            // addBookingButton
            // 
            this.addBookingButton.Location = new System.Drawing.Point(490, 181);
            this.addBookingButton.Margin = new System.Windows.Forms.Padding(2);
            this.addBookingButton.Name = "addBookingButton";
            this.addBookingButton.Size = new System.Drawing.Size(140, 35);
            this.addBookingButton.TabIndex = 4;
            this.addBookingButton.Text = "Add/update Bookings";
            this.addBookingButton.UseVisualStyleBackColor = true;
            // 
            // flightAddButton
            // 
            this.flightAddButton.Location = new System.Drawing.Point(11, 440);
            this.flightAddButton.Margin = new System.Windows.Forms.Padding(2);
            this.flightAddButton.Name = "flightAddButton";
            this.flightAddButton.Size = new System.Drawing.Size(140, 36);
            this.flightAddButton.TabIndex = 7;
            this.flightAddButton.Text = "Add/update Flights";
            this.flightAddButton.UseVisualStyleBackColor = true;
            // 
            // backupXMLButton
            // 
            this.backupXMLButton.Location = new System.Drawing.Point(596, 440);
            this.backupXMLButton.Margin = new System.Windows.Forms.Padding(2);
            this.backupXMLButton.Name = "backupXMLButton";
            this.backupXMLButton.Size = new System.Drawing.Size(140, 36);
            this.backupXMLButton.TabIndex = 9;
            this.backupXMLButton.Text = "Backup to XML";
            this.backupXMLButton.UseVisualStyleBackColor = true;
            // 
            // restoreXMLButton
            // 
            this.restoreXMLButton.Location = new System.Drawing.Point(753, 440);
            this.restoreXMLButton.Margin = new System.Windows.Forms.Padding(2);
            this.restoreXMLButton.Name = "restoreXMLButton";
            this.restoreXMLButton.Size = new System.Drawing.Size(140, 36);
            this.restoreXMLButton.TabIndex = 10;
            this.restoreXMLButton.Text = "Restore from XML";
            this.restoreXMLButton.UseVisualStyleBackColor = true;
            // 
            // labelPassenger
            // 
            this.labelPassenger.AutoSize = true;
            this.labelPassenger.Location = new System.Drawing.Point(13, 14);
            this.labelPassenger.Name = "labelPassenger";
            this.labelPassenger.Size = new System.Drawing.Size(65, 13);
            this.labelPassenger.TabIndex = 11;
            this.labelPassenger.Text = "Passengers:";
            // 
            // labelBooking
            // 
            this.labelBooking.AutoSize = true;
            this.labelBooking.Location = new System.Drawing.Point(487, 14);
            this.labelBooking.Name = "labelBooking";
            this.labelBooking.Size = new System.Drawing.Size(54, 13);
            this.labelBooking.TabIndex = 12;
            this.labelBooking.Text = "Bookings:";
            // 
            // labelFlight
            // 
            this.labelFlight.AutoSize = true;
            this.labelFlight.Location = new System.Drawing.Point(12, 226);
            this.labelFlight.Name = "labelFlight";
            this.labelFlight.Size = new System.Drawing.Size(37, 13);
            this.labelFlight.TabIndex = 13;
            this.labelFlight.Text = "Flights";
            // 
            // ManageReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 487);
            this.Controls.Add(this.labelFlight);
            this.Controls.Add(this.labelBooking);
            this.Controls.Add(this.labelPassenger);
            this.Controls.Add(this.restoreXMLButton);
            this.Controls.Add(this.backupXMLButton);
            this.Controls.Add(this.flightAddButton);
            this.Controls.Add(this.addBookingButton);
            this.Controls.Add(this.addPassengerButton);
            this.Controls.Add(this.flightDetailsView);
            this.Controls.Add(this.bookingsView);
            this.Controls.Add(this.passengerDetailsView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManageReservation";
            this.Text = "ManageReservation";
            ((System.ComponentModel.ISupportInitialize)(this.passengerDetailsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightDetailsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView passengerDetailsView;
        private System.Windows.Forms.DataGridView bookingsView;
        private System.Windows.Forms.DataGridView flightDetailsView;
        private System.Windows.Forms.Button addPassengerButton;
        private System.Windows.Forms.Button addBookingButton;
        private System.Windows.Forms.Button flightAddButton;
        private System.Windows.Forms.Button backupXMLButton;
        private System.Windows.Forms.Button restoreXMLButton;
        private System.Windows.Forms.Label labelPassenger;
        private System.Windows.Forms.Label labelBooking;
        private System.Windows.Forms.Label labelFlight;
    }
}