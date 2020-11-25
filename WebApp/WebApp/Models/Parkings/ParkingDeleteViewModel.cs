using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class ParkingDeleteViewModel
    {
        public List<int> IdList { get; set; }

        [Required]
        [Display(Name = "Id")]
        public int Id { get; set; }
    }
}
