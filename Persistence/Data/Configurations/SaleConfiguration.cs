using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations
{
    public class SaleConfiguration : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder <Sale> builder)
        {
            builder.ToTable("Sale");
            builder.Property(p => p.SaleDate)
            .HasColumnName("Date")
            .IsRequired()
            .HasMaxLength(50);  
        
        }
    }
}