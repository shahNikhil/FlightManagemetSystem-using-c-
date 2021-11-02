namespace AirlineBookingSystem
{
    partial class ViewBookings
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
            this.label1 = new System.Windows.Forms.Label();
            this.bookingsView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Bookings";
            // 
            // bookingsView
            // 
            this.bookingsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookingsView.Location = new System.Drawing.Point(33, 94);
            this.bookingsView.Name = "bookingsView";
            this.bookingsView.RowHeadersWidth = 62;
            this.bookingsView.RowTemplate.Height = 28;
            this.bookingsView.Size = new System.Drawing.Size(733, 344);
            this.bookingsView.TabIndex = 1;
            // 
            // viewBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bookingsView);
            this.Controls.Add(this.label1);
            this.Name = "viewBookings";
            this.Text = "viewBookings";
            ((System.ComponentModel.ISupportInitialize)(this.bookingsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView bookingsView;
    }
}