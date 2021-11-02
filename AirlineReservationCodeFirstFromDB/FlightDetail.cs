namespace AirlineReservationCodeFirstFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FlightDetail
    {
        [Key]
        public int Flight_ID { get; set; }

        [StringLength(50)]
        public string Flight_Name { get; set; }

        [StringLength(50)]
        public string Source { get; set; }

        [StringLength(50)]
        public string Destination { get; set; }

        [StringLength(50)]
        public string Arrival_Time { get; set; }

        [StringLength(50)]
        public string Departure { get; set; }

        [StringLength(50)]
        public string Flight_Class { get; set; }

        public decimal? Flight_Charges { get; set; }

        public int? Seats { get; set; }

        [Column("Airplane Name")]
        [StringLength(50)]
        public string Airplane_Name { get; set; }

        public int? Carrier_ID { get; set; }

        public virtual Carrier Carrier { get; set; }
    }
}
