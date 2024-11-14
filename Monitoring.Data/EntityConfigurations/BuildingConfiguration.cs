using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Monitoring.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitoring.Data.EntityConfigurations
{
    public class BuildingConfiguration : IEntityTypeConfiguration<Building>
    {
        public void Configure(EntityTypeBuilder<Building> builder)
        {
            builder.ToTable("Buildings");

            builder.HasKey(b => b.Id);

            builder.Property(b => b.Name)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(b => b.Address)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(b => b.Description)
                .HasMaxLength(1000);

            builder.HasMany(b => b.Sensors)
                .WithOne()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
