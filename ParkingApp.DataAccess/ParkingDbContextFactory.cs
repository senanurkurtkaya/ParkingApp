using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp.DataAccess
{
    internal class ParkingDbContextFactory : IDesignTimeDbContextFactory<ParkingDbContext>
    {
        public ParkingDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder =new DbContextOptionsBuilder<ParkingDbContext>();
            optionsBuilder.UseSqlServer("Server=SENANURKURTKAYA\\SQLEXPRESS;Database=ParkingApp;Trusted_Connection=True; TrustServerCertificate=True;Encrypt=False;");

            return new ParkingDbContext(optionsBuilder.Options);
        }
    }
}
