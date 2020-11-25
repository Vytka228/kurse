using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class CarIndexViewModel
    {
        public List<CarSecondaryViewModel> Cars { get; set; }

        public List<string> OwnerFIOs { get; set; }

        public PageViewModel PageViewModel { get; set; }

        public string OwnerFIOFiltr { get; set; }

        public string NumberFiltr { get; set; }
    }
}
