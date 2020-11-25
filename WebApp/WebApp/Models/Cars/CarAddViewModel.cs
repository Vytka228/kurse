using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class CarAddViewModel
    {
        public List<string> OwnerFIOs { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Неправильный ввод марки")]
        [Display(Name = "Марка")]
        public string Carbrands { get; set; }

        [Required]
        [StringLength(12, MinimumLength = 4, ErrorMessage = "Неправильный ввод номера автомобиля")]
        [Display(Name = "Номер")]
        public string Numberofthecar { get; set; }

        [Required]
        [Display(Name = "ФИО владельца")]
        public string OwnersFIO { get; set; }
    }
}
