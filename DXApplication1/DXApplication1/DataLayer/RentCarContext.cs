using RentCar.DataLayer.Configurations;
using RentCar.DataLayer.Models;
using System.Data.Entity;

namespace RentCar.DataLayer
{
    public class RentCarContext : DbContext
    {
        public RentCarContext() : base("RentCarConfiguration") { }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<FuelType> FuelTypes { get; set; }
        public DbSet<Inspection> Inspections { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Rent> Rents { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleType> VehicleTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            ApplyConfigurations(modelBuilder);
        }

        private static void ApplyConfigurations(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BrandConfiguration());
            modelBuilder.Configurations.Add(new ClientConfiguration());
            modelBuilder.Configurations.Add(new EmployeeConfiguration());
            modelBuilder.Configurations.Add(new FuelTypeConfiguration());
            modelBuilder.Configurations.Add(new InspectionConfiguration());
            modelBuilder.Configurations.Add(new ModelConfiguration());
            modelBuilder.Configurations.Add(new RentConfiguration());
            modelBuilder.Configurations.Add(new VehicleConfiguration());
            modelBuilder.Configurations.Add(new VehicleTypeConfiguration());
        }
    }
}
