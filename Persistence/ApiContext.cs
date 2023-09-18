using System.Reflection;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence;
public class ApiContext : DbContext
{
        public ApiContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Buy> Shopping { get; set; }
        public DbSet<Employee> Empoyees { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<MedicinePurchased> MedicinesPurchased { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

}
