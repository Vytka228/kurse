using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class ParkingUpdateViewModel
    {
        public List<int> IdList { get; set; }

        [Required]
        [Display(Name = "Id")]
        public int Id { get; set; }

        public List<string> CarsNumbers { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Неправильный ввод типа парковки")]
        [Display(Name = "Тип парковки")]
        public string TypeParking { get; set; }

        [Required]
        [Display(Name = "Дата заезда")]
        public DateTime Dateentry { get; set; }

        [Required]
        [Display(Name = "Дата выезда")]
        public DateTime Datedeparture { get; set; }

        [Required]
        [Display(Name = "Стоимость")]
        public string CarsNumber { get; set; }

        [Display(Name = "Цена")]
        public decimal Price { get; set; }
    }
}
