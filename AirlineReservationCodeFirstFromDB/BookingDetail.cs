namespace AirlineReservationCodeFirstFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BookingDetail
    {
        [Key]
        [Column("Booking_ ID")]
        public int Booking__ID { get; set; }

        public int? Customer_ID { get; set; }

        public int? Carrier_ID { get; set; }

        [StringLength(50)]
        public string Source { get; set; }

        [StringLength(50)]
        public string Destination { get; set; }

        [StringLength(50)]
        public string DateOfJourney { get; set; }

        public int? SeatNo { get; set; }

        public virtual Carrier Carrier { get; set; }

        public virtual PassengerDetail PassengerDetail { get; set; }
    }
}
