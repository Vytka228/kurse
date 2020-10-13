using System;
using System.Collections.Generic;

namespace BaseparkingLibrary.Models
{
    public partial class Owner
    {
        public Owner()
        {
            Cars = new HashSet<Car>();
        }

        public int Id { get; set; }
        public string Fio { get; set; }
        public string NameFone { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
    }
}
