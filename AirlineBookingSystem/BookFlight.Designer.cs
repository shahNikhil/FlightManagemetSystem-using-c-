namespace AirlineBookingSystem
{
    partial class BookFlight
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
            this.buttonBook = new System.Windows.Forms.Button();
            this.buttonGoBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCustomers = new System.Windows.Forms.Label();
            this.dataGridViewPassenger = new System.Windows.Forms.DataGridView();
            this.labelSource = new System.Windows.Forms.Label();
            this.labelDestination = new System.Windows.Forms.Label();
            this.labelDateOfJourney = new System.Windows.Forms.Label();
            this.labelSeatNo = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textBoxSeatNo = new System.Windows.Forms.TextBox();
            this.textBoxDestination = new System.Windows.Forms.TextBox();
            this.textBoxSource = new System.Windows.Forms.TextBox();
            this.labelCustomerID = new System.Windows.Forms.Label();
            this.textBoxCustomerID = new System.Windows.Forms.TextBox();
            this.dataGridViewCarrier = new System.Windows.Forms.DataGridView();
            this.labelSelectCarrier = new System.Windows.Forms.Label();
            this.labelCarrierID = new System.Windows.Forms.Label();
            this.textBoxCarrierID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPassenger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarrier)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBook
            // 
            this.buttonBook.Location = new System.Drawing.Point(296, 389);
            this.buttonBook.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonBook.Name = "buttonBook";
            this.buttonBook.Size = new System.Drawing.Size(69, 33);
            this.buttonBook.TabIndex = 25;
            this.buttonBook.Text = "Book";
            this.buttonBook.UseVisualStyleBackColor = true;
            // 
            // buttonGoBack
            // 
            this.buttonGoBack.Location = new System.Drawing.Point(511, 389);
            this.buttonGoBack.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonGoBack.Name = "buttonGoBack";
            this.buttonGoBack.Size = new System.Drawing.Size(69, 33);
            this.buttonGoBack.TabIndex = 26;
            this.buttonGoBack.Text = "Go Back";
            this.buttonGoBack.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book A Flight";
            // 
            // labelCustomers
            // 
            this.labelCustomers.AutoSize = true;
            this.labelCustomers.Location = new System.Drawing.Point(39, 71);
            this.labelCustomers.Name = "labelCustomers";
            this.labelCustomers.Size = new System.Drawing.Size(93, 13);
            this.labelCustomers.TabIndex = 28;
            this.labelCustomers.Text = "Select a Customer";
            // 
            // dataGridViewPassenger
            // 
            this.dataGridViewPassenger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPassenger.Location = new System.Drawing.Point(42, 87);
            this.dataGridViewPassenger.Name = "dataGridViewPassenger";
            this.dataGridViewPassenger.Size = new System.Drawing.Size(397, 150);
            this.dataGridViewPassenger.TabIndex = 29;
            // 
            // labelSource
            // 
            this.labelSource.AutoSize = true;
            this.labelSource.Location = new System.Drawing.Point(180, 264);
            this.labelSource.Name = "labelSource";
            this.labelSource.Size = new System.Drawing.Size(41, 13);
            this.labelSource.TabIndex = 32;
            this.labelSource.Text = "Source";
            // 
            // labelDestination
            // 
            this.labelDestination.AutoSize = true;
            this.labelDestination.Location = new System.Drawing.Point(180, 312);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(60, 13);
            this.labelDestination.TabIndex = 33;
            this.labelDestination.Text = "Destination";
            // 
            // labelDateOfJourney
            // 
            this.labelDateOfJourney.AutoSize = true;
            this.labelDateOfJourney.Location = new System.Drawing.Point(422, 264);
            this.labelDateOfJourney.Name = "labelDateOfJourney";
            this.labelDateOfJourney.Size = new System.Drawing.Size(82, 13);
            this.labelDateOfJourney.TabIndex = 34;
            this.labelDateOfJourney.Text = "Date of Journey";
            // 
            // labelSeatNo
            // 
            this.labelSeatNo.AutoSize = true;
            this.labelSeatNo.Location = new System.Drawing.Point(422, 305);
            this.labelSeatNo.Name = "labelSeatNo";
            this.labelSeatNo.Size = new System.Drawing.Size(46, 13);
            this.labelSeatNo.TabIndex = 35;
            this.labelSeatNo.Text = "Seat No";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(511, 264);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(120, 20);
            this.dateTimePicker.TabIndex = 36;
            // 
            // textBoxSeatNo
            // 
            this.textBoxSeatNo.Location = new System.Drawing.Point(511, 305);
            this.textBoxSeatNo.Name = "textBoxSeatNo";
            this.textBoxSeatNo.Size = new System.Drawing.Size(120, 20);
            this.textBoxSeatNo.TabIndex = 37;
            // 
            // textBoxDestination
            // 
            this.textBoxDestination.Location = new System.Drawing.Point(265, 309);
            this.textBoxDestination.Name = "textBoxDestination";
            this.textBoxDestination.Size = new System.Drawing.Size(100, 20);
            this.textBoxDestination.TabIndex = 38;
            // 
            // textBoxSource
            // 
            this.textBoxSource.Location = new System.Drawing.Point(265, 261);
            this.textBoxSource.Name = "textBoxSource";
            this.textBoxSource.Size = new System.Drawing.Size(100, 20);
            this.textBoxSource.TabIndex = 39;
            // 
            // labelCustomerID
            // 
            this.labelCustomerID.AutoSize = true;
            this.labelCustomerID.Location = new System.Drawing.Point(183, 354);
            this.labelCustomerID.Name = "labelCustomerID";
            this.labelCustomerID.Size = new System.Drawing.Size(68, 13);
            this.labelCustomerID.TabIndex = 40;
            this.labelCustomerID.Text = "Customer ID:";
            // 
            // textBoxCustomerID
            // 
            this.textBoxCustomerID.Location = new System.Drawing.Point(265, 347);
            this.textBoxCustomerID.Name = "textBoxCustomerID";
            this.textBoxCustomerID.Size = new System.Drawing.Size(100, 20);
            this.textBoxCustomerID.TabIndex = 41;
            // 
            // dataGridViewCarrier
            // 
            this.dataGridViewCarrier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCarrier.Location = new System.Drawing.Point(500, 87);
            this.dataGridViewCarrier.Name = "dataGridViewCarrier";
            this.dataGridViewCarrier.Size = new System.Drawing.Size(397, 150);
            this.dataGridViewCarrier.TabIndex = 42;
            // 
            // labelSelectCarrier
            // 
            this.labelSelectCarrier.AutoSize = true;
            this.labelSelectCarrier.Location = new System.Drawing.Point(497, 71);
            this.labelSelectCarrier.Name = "labelSelectCarrier";
            this.labelSelectCarrier.Size = new System.Drawing.Size(79, 13);
            this.labelSelectCarrier.TabIndex = 43;
            this.labelSelectCarrier.Text = "Select a Carrier";
            // 
            // labelCarrierID
            // 
            this.labelCarrierID.AutoSize = true;
            this.labelCarrierID.Location = new System.Drawing.Point(422, 354);
            this.labelCarrierID.Name = "labelCarrierID";
            this.labelCarrierID.Size = new System.Drawing.Size(54, 13);
            this.labelCarrierID.TabIndex = 44;
            this.labelCarrierID.Text = "Carrier ID:";
            // 
            // textBoxCarrierID
            // 
            this.textBoxCarrierID.Location = new System.Drawing.Point(511, 351);
            this.textBoxCarrierID.Name = "textBoxCarrierID";
            this.textBoxCarrierID.Size = new System.Drawing.Size(120, 20);
            this.textBoxCarrierID.TabIndex = 45;
            // 
            // BookFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 464);
            this.Controls.Add(this.textBoxCarrierID);
            this.Controls.Add(this.labelCarrierID);
            this.Controls.Add(this.labelSelectCarrier);
            this.Controls.Add(this.dataGridViewCarrier);
            this.Controls.Add(this.textBoxCustomerID);
            this.Controls.Add(this.labelCustomerID);
            this.Controls.Add(this.textBoxSource);
            this.Controls.Add(this.textBoxDestination);
            this.Controls.Add(this.textBoxSeatNo);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.labelSeatNo);
            this.Controls.Add(this.labelDateOfJourney);
            this.Controls.Add(this.labelDestination);
            this.Controls.Add(this.labelSource);
            this.Controls.Add(this.dataGridViewPassenger);
            this.Controls.Add(this.labelCustomers);
            this.Controls.Add(this.buttonGoBack);
            this.Controls.Add(this.buttonBook);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "BookFlight";
            this.Text = "BookFlight";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPassenger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarrier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonBook;
        private System.Windows.Forms.Button buttonGoBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCustomers;
        private System.Windows.Forms.DataGridView dataGridViewPassenger;
        private System.Windows.Forms.Label labelSource;
        private System.Windows.Forms.Label labelDestination;
        private System.Windows.Forms.Label labelDateOfJourney;
        private System.Windows.Forms.Label labelSeatNo;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox textBoxSeatNo;
        private System.Windows.Forms.TextBox textBoxDestination;
        private System.Windows.Forms.TextBox textBoxSource;
        private System.Windows.Forms.Label labelCustomerID;
        private System.Windows.Forms.TextBox textBoxCustomerID;
        private System.Windows.Forms.DataGridView dataGridViewCarrier;
        private System.Windows.Forms.Label labelSelectCarrier;
        private System.Windows.Forms.Label labelCarrierID;
        private System.Windows.Forms.TextBox textBoxCarrierID;
    }
}