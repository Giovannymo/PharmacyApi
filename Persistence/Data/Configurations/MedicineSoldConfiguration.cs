using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations
{
    public class MedicineSoldConfiguration
    {
        public void Configure(EntityTypeBuilder <MedicineSold> builder)
        {
            builder.ToTable("MedicineSold");
            builder.Property(p => p.Price)
            .IsRequired()
            .HasColumnType("decimal(10,2)");
            
            builder.ToTable("AmountSold");
            builder.Property(p => p.AmountSold)
            .IsRequired()
            .HasColumnType("decimal(10,2)");

            builder.HasOne(p => p.Sale)
            .WithMany(p => p.MedicinesSold)
            .HasForeignKey(p => p.IdSaleFk);

            builder.HasOne(p => p.Sale)
            .WithMany(p => p.MedicinesSold)
            .HasForeignKey(p => p.IdSaleFk);
            
            builder.HasOne(p => p.Medicine)
            .WithMany(p => p.MedicinesSold)
            .HasForeignKey(p => p.IdMedicineFk);
        }
    }
}
