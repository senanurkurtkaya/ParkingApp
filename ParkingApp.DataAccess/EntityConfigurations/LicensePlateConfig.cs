using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ParkingApp.DataAccess.Entities;
using ParkingApp.DataAccess.EntityConfigurations.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp.DataAccess.EntityConfigurations
{
    internal class LicensePlateConfig : BaseEntityConfiguration<LicensePlate>
    {
        public override void Configure(EntityTypeBuilder<LicensePlate> builder)
        {
            base.Configure(builder);

            builder.HasOne(x => x.Car)
                .WithOne(x => x.LicensePlate)
                .HasForeignKey<LicensePlate>(x => x.CarId)
                .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.Cascade);

            builder.Property(x => x.FullLicensePlate).HasComputedColumnSql("[CityCode] +' ' + [ProvienceCode] + ' ' +[RegistrationYear]+CONVERT (nvarchar(50),[Id])" , stored : true);
        }
    }
}
