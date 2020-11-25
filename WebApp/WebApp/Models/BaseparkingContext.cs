using Microsoft.EntityFrameworkCore;

namespace WebApp.Models
{
    // Класс контекста данных
    public partial class BaseparkingContext : DbContext
    {
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Owner> Owners { get; set; }
        public virtual DbSet<Parking> Parkings { get; set; }
        public BaseparkingContext(DbContextOptions<BaseparkingContext> options) : base(options)
        {
        }
    }
}
