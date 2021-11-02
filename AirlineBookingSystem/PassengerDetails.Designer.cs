namespace AirlineBookingSystem
{
    partial class PassengerDetails
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
            this.labelPassengerName = new System.Windows.Forms.Label();
            this.passengerNameTextBox = new System.Windows.Forms.TextBox();
            this.passengerDetailsView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.passengerDetailsView)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPassengerName
            // 
            this.labelPassengerName.AutoSize = true;
            this.labelPassengerName.Location = new System.Drawing.Point(57, 29);
            this.labelPassengerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPassengerName.Name = "labelPassengerName";
            this.labelPassengerName.Size = new System.Drawing.Size(88, 13);
            this.labelPassengerName.TabIndex = 0;
            this.labelPassengerName.Text = "Passenger Name";
            // 
            // passengerNameTextBox
            // 
            this.passengerNameTextBox.Location = new System.Drawing.Point(209, 29);
            this.passengerNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passengerNameTextBox.Name = "passengerNameTextBox";
            this.passengerNameTextBox.Size = new System.Drawing.Size(149, 20);
            this.passengerNameTextBox.TabIndex = 1;
            // 
            // passengerDetailsView
            // 
            this.passengerDetailsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.passengerDetailsView.Location = new System.Drawing.Point(25, 60);
            this.passengerDetailsView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passengerDetailsView.Name = "passengerDetailsView";
            this.passengerDetailsView.RowHeadersWidth = 62;
            this.passengerDetailsView.RowTemplate.Height = 28;
            this.passengerDetailsView.Size = new System.Drawing.Size(475, 210);
            this.passengerDetailsView.TabIndex = 2;
            // 
            // PassengerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.passengerDetailsView);
            this.Controls.Add(this.passengerNameTextBox);
            this.Controls.Add(this.labelPassengerName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PassengerDetails";
            this.Text = "PassengerDetails";
            ((System.ComponentModel.ISupportInitialize)(this.passengerDetailsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPassengerName;
        private System.Windows.Forms.TextBox passengerNameTextBox;
        private System.Windows.Forms.DataGridView passengerDetailsView;
    }
}