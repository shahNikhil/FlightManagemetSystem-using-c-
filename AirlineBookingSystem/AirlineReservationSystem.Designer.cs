namespace AirlineBookingSystem
{
    partial class AirlineReservationSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AirlineReservationSystem));
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.bookFlightButton = new System.Windows.Forms.Button();
            this.viewBookingButton = new System.Windows.Forms.Button();
            this.viewPassengerDetailButton = new System.Windows.Forms.Button();
            this.viewTransactionButton = new System.Windows.Forms.Button();
            this.manageReservatinButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(107, 6);
            this.welcomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(431, 43);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome To Flight Booking";
            // 
            // bookFlightButton
            // 
            this.bookFlightButton.Location = new System.Drawing.Point(273, 75);
            this.bookFlightButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bookFlightButton.Name = "bookFlightButton";
            this.bookFlightButton.Size = new System.Drawing.Size(94, 40);
            this.bookFlightButton.TabIndex = 1;
            this.bookFlightButton.Text = "Book Flight";
            this.bookFlightButton.UseVisualStyleBackColor = true;
            // 
            // viewBookingButton
            // 
            this.viewBookingButton.Location = new System.Drawing.Point(273, 147);
            this.viewBookingButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.viewBookingButton.Name = "viewBookingButton";
            this.viewBookingButton.Size = new System.Drawing.Size(94, 40);
            this.viewBookingButton.TabIndex = 2;
            this.viewBookingButton.Text = "View Bookings";
            this.viewBookingButton.UseVisualStyleBackColor = true;
            // 
            // viewPassengerDetailButton
            // 
            this.viewPassengerDetailButton.Location = new System.Drawing.Point(273, 218);
            this.viewPassengerDetailButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.viewPassengerDetailButton.Name = "viewPassengerDetailButton";
            this.viewPassengerDetailButton.Size = new System.Drawing.Size(94, 40);
            this.viewPassengerDetailButton.TabIndex = 3;
            this.viewPassengerDetailButton.Text = "View Passenger Details";
            this.viewPassengerDetailButton.UseVisualStyleBackColor = true;
            // 
            // viewTransactionButton
            // 
            this.viewTransactionButton.Location = new System.Drawing.Point(273, 287);
            this.viewTransactionButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.viewTransactionButton.Name = "viewTransactionButton";
            this.viewTransactionButton.Size = new System.Drawing.Size(94, 40);
            this.viewTransactionButton.TabIndex = 4;
            this.viewTransactionButton.Text = "View Flights";
            this.viewTransactionButton.UseVisualStyleBackColor = true;
            // 
            // manageReservatinButton
            // 
            this.manageReservatinButton.Location = new System.Drawing.Point(273, 355);
            this.manageReservatinButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.manageReservatinButton.Name = "manageReservatinButton";
            this.manageReservatinButton.Size = new System.Drawing.Size(94, 40);
            this.manageReservatinButton.TabIndex = 5;
            this.manageReservatinButton.Text = "Manage Reservations";
            this.manageReservatinButton.UseVisualStyleBackColor = true;
            // 
            // AirlineReservationSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(689, 475);
            this.Controls.Add(this.manageReservatinButton);
            this.Controls.Add(this.viewTransactionButton);
            this.Controls.Add(this.viewPassengerDetailButton);
            this.Controls.Add(this.viewBookingButton);
            this.Controls.Add(this.bookFlightButton);
            this.Controls.Add(this.welcomeLabel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "AirlineReservationSystem";
            this.Text = "Airline Reservation System";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button bookFlightButton;
        private System.Windows.Forms.Button viewBookingButton;
        private System.Windows.Forms.Button viewPassengerDetailButton;
        private System.Windows.Forms.Button viewTransactionButton;
        private System.Windows.Forms.Button manageReservatinButton;
    }
}

