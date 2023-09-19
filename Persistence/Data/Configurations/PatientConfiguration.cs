using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Persistence.Data.Configurations
{
    public class PatientConfiguration : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder <Patient> builder)
        {
            builder.ToTable("Patient");
            builder.Property(p => p.PatientName)
            .IsRequired()
            .HasMaxLength(50);  
            
            builder.Property(p => p.PhoneNumber)
            .IsRequired()
            .HasColumnType("int")
            .HasMaxLength(10);

            builder.HasOne(p => p.Address)
            .WithOne(p => p.Patient)
            .HasForeignKey<Address>(p => p. IdPatientFk);
    
        }
    }
