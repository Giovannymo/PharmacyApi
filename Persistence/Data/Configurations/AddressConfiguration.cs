using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("Address");
            builder.Property(p => p.Id)
            .IsRequired();
            
            builder.Property(p => p.Street)
            .IsRequired()
            .HasMaxLength(50);
            
            builder.Property(p => p.Number)
            .IsRequired()
            .HasColumnType("int")
            .HasMaxLength(10);

            builder.Property(p => p.ZipCode)
            .IsRequired()
            .HasColumnType("int")
            .HasMaxLength(10);

            builder.HasOne(p => p.Patient)
            .WithOne(p => p.Address)
            .HasForeignKey<Patient>(p => p.IdAddressFk);
        }
    }
}