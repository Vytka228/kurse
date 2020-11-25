using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class ParkingViewModel
    {
        public List<ParkingSecondaryViewModel> Parkings { get; set; }

        public List<string> CarsNumbers { get; set; }

        public PageViewModel PageViewModel { get; set; }

        public string CarNumbFiltr { get; set; }

        public List<string> TypeParkingsFiltr { get; set; }

        public string TypeParkingFiltr { get; set; }
    }
}
