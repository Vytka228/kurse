using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class OwnerViewModel
    {
        public List<Owner> Owners { get; set; }

        public PageViewModel PageViewModel { get; set; }

        public string FoneFiltr { get; set; }
    }
}
