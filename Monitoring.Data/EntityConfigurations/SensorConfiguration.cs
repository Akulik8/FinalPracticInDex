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
    public class SensorConfiguration : IEntityTypeConfiguration<Sensor>
    {
        public void Configure(EntityTypeBuilder<Sensor> builder)
        {
            builder.ToTable("Sensors");

            builder.HasKey(s => s.Id);

            builder.Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(s => s.Description)
                .HasMaxLength(1000);

            builder.Property(s => s.GeoLocation)
                .HasMaxLength(200);

            builder.Property(s => s.PhotoUrl)
                .HasMaxLength(500);

            builder.Property(s => s.BatteryLevel)
                .HasColumnType("decimal(5,2)");

            builder.Property(s => s.Temperature)
                .HasColumnType("decimal(5,2)");

            builder.Property(s => s.Humidity)
                .HasColumnType("decimal(5,2)");

            builder.Property(s => s.LastDataReceived)
                .HasDefaultValueSql("GETDATE()");
        }
    }
}
