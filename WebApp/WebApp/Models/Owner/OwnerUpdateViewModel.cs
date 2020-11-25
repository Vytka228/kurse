using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class OwnerUpdateViewModel
    {
        public List<int> IdList { get; set; }

        [Required]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 12, ErrorMessage = "Неправильный ввод ФИО владельца")]
        [Display(Name = "ФИО")]
        public string Fio { get; set; }

        [Required]
        [StringLength(12, MinimumLength = 9, ErrorMessage = "Неправильный ввод номера")]
        [Display(Name = "Телефон")]
        public string NameFone { get; set; }
    }
}
