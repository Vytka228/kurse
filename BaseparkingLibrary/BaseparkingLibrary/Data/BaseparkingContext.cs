using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using BaseparkingLibrary.Models;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace BaseparkingLibrary.Data
{
    public partial class BaseparkingContext : DbContext
    {
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Owner> Owners { get; set; }
        public virtual DbSet<Parking> Parkings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("config.json");

            IConfigurationRoot configuration = builder.Build();
            string connectionString = configuration.GetConnectionString("SQLConnection");

            DbContextOptions options = optionsBuilder
                .UseSqlServer(connectionString)
                .Options;
        }
    }
}
