using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ParkingApp.DataAccess.Entities;
using ParkingApp.DataAccess.EntityConfigurations.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp.DataAccess.EntityConfigurations
{
    internal class CarConfig : BaseEntityConfiguration<Car>
    {
        public override void Configure(EntityTypeBuilder<Car> builder)
        {
            base.Configure(builder);

            builder.HasOne(x => x.Owner)
                .WithMany(x => x.Cars)
                .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.Cascade);
        }
    }
}
