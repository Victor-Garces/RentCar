using RentCar.DataLayer.Models;
using System.Data.Entity;

namespace RentCar.DataLayer
{
    public class RentCarContext : DbContext
    {
        public RentCarContext() : base("name=RentCar") { }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<FuelType> FuelTypes { get; set; }
        public DbSet<Inspection> Inspections { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Rent> Rents { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleType> VehicleTypes { get; set; }
    }
}
