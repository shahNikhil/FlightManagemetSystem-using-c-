namespace AirlineBookingSystem
{
    partial class AddorUpdateBookingForm
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
            this.labelCustomerID = new System.Windows.Forms.Label();
            this.labelSource = new System.Windows.Forms.Label();
            this.labelDestination = new System.Windows.Forms.Label();
            this.labelJourneyDate = new System.Windows.Forms.Label();
            this.labelSeatNo = new System.Windows.Forms.Label();
            this.textBoxCustomerID = new System.Windows.Forms.TextBox();
            this.textBoxSource = new System.Windows.Forms.TextBox();
            this.textBoxDestination = new System.Windows.Forms.TextBox();
            this.textBoxSeatNo = new System.Windows.Forms.TextBox();
            this.dataGridViewBooking = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxDateOfJourney = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooking)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCustomerID
            // 
            this.labelCustomerID.AutoSize = true;
            this.labelCustomerID.Location = new System.Drawing.Point(44, 56);
            this.labelCustomerID.Name = "labelCustomerID";
            this.labelCustomerID.Size = new System.Drawing.Size(62, 13);
            this.labelCustomerID.TabIndex = 0;
            this.labelCustomerID.Text = "CustomerID";
            // 
            // labelSource
            // 
            this.labelSource.AutoSize = true;
            this.labelSource.Location = new System.Drawing.Point(44, 105);
            this.labelSource.Name = "labelSource";
            this.labelSource.Size = new System.Drawing.Size(41, 13);
            this.labelSource.TabIndex = 1;
            this.labelSource.Text = "Source";
            // 
            // labelDestination
            // 
            this.labelDestination.AutoSize = true;
            this.labelDestination.Location = new System.Drawing.Point(44, 157);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(60, 13);
            this.labelDestination.TabIndex = 2;
            this.labelDestination.Text = "Destination";
            // 
            // labelJourneyDate
            // 
            this.labelJourneyDate.AutoSize = true;
            this.labelJourneyDate.Location = new System.Drawing.Point(44, 213);
            this.labelJourneyDate.Name = "labelJourneyDate";
            this.labelJourneyDate.Size = new System.Drawing.Size(79, 13);
            this.labelJourneyDate.TabIndex = 3;
            this.labelJourneyDate.Text = "Date of journey";
            // 
            // labelSeatNo
            // 
            this.labelSeatNo.AutoSize = true;
            this.labelSeatNo.Location = new System.Drawing.Point(44, 270);
            this.labelSeatNo.Name = "labelSeatNo";
            this.labelSeatNo.Size = new System.Drawing.Size(46, 13);
            this.labelSeatNo.TabIndex = 4;
            this.labelSeatNo.Text = "Seat No";
            // 
            // textBoxCustomerID
            // 
            this.textBoxCustomerID.Location = new System.Drawing.Point(162, 56);
            this.textBoxCustomerID.Name = "textBoxCustomerID";
            this.textBoxCustomerID.Size = new System.Drawing.Size(100, 20);
            this.textBoxCustomerID.TabIndex = 5;
            // 
            // textBoxSource
            // 
            this.textBoxSource.Location = new System.Drawing.Point(162, 105);
            this.textBoxSource.Name = "textBoxSource";
            this.textBoxSource.Size = new System.Drawing.Size(100, 20);
            this.textBoxSource.TabIndex = 6;
            // 
            // textBoxDestination
            // 
            this.textBoxDestination.Location = new System.Drawing.Point(162, 157);
            this.textBoxDestination.Name = "textBoxDestination";
            this.textBoxDestination.Size = new System.Drawing.Size(100, 20);
            this.textBoxDestination.TabIndex = 7;
            // 
            // textBoxSeatNo
            // 
            this.textBoxSeatNo.Location = new System.Drawing.Point(162, 270);
            this.textBoxSeatNo.Name = "textBoxSeatNo";
            this.textBoxSeatNo.Size = new System.Drawing.Size(100, 20);
            this.textBoxSeatNo.TabIndex = 9;
            // 
            // dataGridViewBooking
            // 
            this.dataGridViewBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooking.Location = new System.Drawing.Point(292, 56);
            this.dataGridViewBooking.Name = "dataGridViewBooking";
            this.dataGridViewBooking.Size = new System.Drawing.Size(496, 234);
            this.dataGridViewBooking.TabIndex = 10;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(292, 370);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(430, 370);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 12;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // textBoxDateOfJourney
            // 
            this.textBoxDateOfJourney.Location = new System.Drawing.Point(162, 213);
            this.textBoxDateOfJourney.Name = "textBoxDateOfJourney";
            this.textBoxDateOfJourney.Size = new System.Drawing.Size(100, 20);
            this.textBoxDateOfJourney.TabIndex = 13;
            // 
            // AddorUpdateBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxDateOfJourney);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewBooking);
            this.Controls.Add(this.textBoxSeatNo);
            this.Controls.Add(this.textBoxDestination);
            this.Controls.Add(this.textBoxSource);
            this.Controls.Add(this.textBoxCustomerID);
            this.Controls.Add(this.labelSeatNo);
            this.Controls.Add(this.labelJourneyDate);
            this.Controls.Add(this.labelDestination);
            this.Controls.Add(this.labelSource);
            this.Controls.Add(this.labelCustomerID);
            this.Name = "AddorUpdateBookingForm";
            this.Text = "AddorUpdateBookingForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCustomerID;
        private System.Windows.Forms.Label labelSource;
        private System.Windows.Forms.Label labelDestination;
        private System.Windows.Forms.Label labelJourneyDate;
        private System.Windows.Forms.Label labelSeatNo;
        private System.Windows.Forms.TextBox textBoxCustomerID;
        private System.Windows.Forms.TextBox textBoxSource;
        private System.Windows.Forms.TextBox textBoxDestination;
        private System.Windows.Forms.TextBox textBoxSeatNo;
        private System.Windows.Forms.DataGridView dataGridViewBooking;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxDateOfJourney;
    }
}