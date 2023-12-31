using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Persistence.Data.Configurations;

    public class EmployeeConfiguration
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee");
            builder.Property(p => p.Id)
            .IsRequired();
            
            builder.Property(p => p.EmployeeName)
            .IsRequired()
            .HasColumnName("Name")
            .HasMaxLength(50);
            
            builder.Property(p => p.Charge)
            .IsRequired()
            .HasMaxLength(30);

            builder.Property(p => p.ContractingDate)
            .IsRequired()
            .HasColumnType("Date")
            .HasMaxLength(50);

    
        }
    }
    }
