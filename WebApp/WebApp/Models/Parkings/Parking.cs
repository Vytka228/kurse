using System;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    // Класс, представляющий запись в таблице Парковка
    public partial class Parking
    {
        [Key]
        public int Id { get; set; }
        public string TypeParking { get; set; }
        public DateTime Dateentry { get; set; }
        public DateTime Datedeparture { get; set; }
        public int CarsId { get; set; }
        public decimal Price { get; set; }
        public int StaffsId { get; set; }
    }
}
