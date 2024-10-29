using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ParkingApp.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp.DataAccess
{
    public class ParkingDbContext : DbContext
    {
        public ParkingDbContext(DbContextOptions<ParkingDbContext> options) : base(options)
        {

        }
        public DbSet<CarOwner> CarOwners { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<LicensePlate> LicensePlates { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ParkingDbContext).Assembly);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=SENANURKURTKAYA\\SQLEXPRESS;Database=ParkingApp;Trusted_Connection=True; TrustServerCertificate=True;Encrypt=False;");

            optionsBuilder.LogTo(message => Debug.WriteLine(message), new[] { DbLoggerCategory.Database.Command.Name }, LogLevel.Information);
        }
    }
}
