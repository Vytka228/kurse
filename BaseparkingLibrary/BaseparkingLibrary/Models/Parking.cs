using System;
using System.Collections.Generic;

namespace BaseparkingLibrary.Models
{
    public partial class Parking
    {
        public int Id { get; set; }
        public string TypeParking { get; set; }
        public DateTime Dateentry { get; set; }
        public DateTime Datedeparture { get; set; }
        public int CarsId { get; set; }
        public decimal Price { get; set; }
        public int StaffsId { get; set; }

        public virtual Car Car { get; set; }
    }
}
