namespace AirlineReservationCodeFirstFromDB
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AirlineReservationSystemEntity : DbContext
    {
        public AirlineReservationSystemEntity()
            : base("name=AirlineReservationConnection")
        {
        }

        public virtual DbSet<C__RefactorLog> C__RefactorLog { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<BookingDetail> BookingDetails { get; set; }
        public virtual DbSet<Carrier> Carriers { get; set; }
        public virtual DbSet<FlightDetail> FlightDetails { get; set; }
        public virtual DbSet<PassengerDetail> PassengerDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FlightDetail>()
                .Property(e => e.Flight_Charges)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PassengerDetail>()
                .Property(e => e.DateOfBirth)
                .IsUnicode(false);
        }
    }
}
