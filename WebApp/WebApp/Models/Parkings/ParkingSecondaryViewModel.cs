using System;

namespace WebApp.Models
{
    public class ParkingSecondaryViewModel
    {
        public int Id { get; set; }
        public string TypeParking { get; set; }
        public DateTime Dateentry { get; set; }
        public DateTime Datedeparture { get; set; }
        public string CarsNumber { get; set; }
        public decimal Price { get; set; }
    }
}
