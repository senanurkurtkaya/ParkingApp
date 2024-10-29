using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ParkingApp.DataAccess.Entities;
using ParkingApp.DataAccess.Entities.Base;
using ParkingApp.DataAccess.EntityConfigurations.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp.DataAccess.EntityConfigurations
{
    internal class CarOwnerConfig : BaseEntityConfiguration<CarOwner>
    {
        public override void Configure(EntityTypeBuilder<CarOwner> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.IdentityNumber).HasMaxLength(11);
            builder.Property(x => x.FirstName).HasMaxLength(50);
            builder.Property(x => x.LastName).HasMaxLength(50);

        }

    }
}
