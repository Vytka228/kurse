using System;
using System.Collections.Generic;

namespace BaseparkingLibrary.Models
{
    public partial class Car
    {
        public Car()
        {
            Parkings = new HashSet<Parking>();
        }

        public int Id { get; set; }
        public string Carbrands { get; set; }
        public string Numberofthecar { get; set; }
        public int OwnersId { get; set; }

        public virtual Owner Owners { get; set; }
        public virtual ICollection<Parking> Parkings { get; set; }
    }
}
