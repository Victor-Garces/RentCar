using DXApplication1.Contracts;
using DXApplication1.DataLayer.Configurations;
using DXApplication1.DataLayer.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace DXApplication1.DataLayer
{
    public class RentCarContext : DbContext
    {
        public RentCarContext() : base("RentCarConfiguration") { }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<FuelType> FuelTypes { get; set; }
        public DbSet<Inspection> Inspections { get; set; }
        public DbSet<Rent> Rents { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleType> VehicleTypes { get; set; }
        public DbSet<User> Users { get; set; }

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
            modelBuilder.Configurations.Add(new RentConfiguration());
            modelBuilder.Configurations.Add(new VehicleConfiguration());
            modelBuilder.Configurations.Add(new VehicleTypeConfiguration());
            modelBuilder.Configurations.Add(new UserConfiguration());
        }

        public override int SaveChanges()
        {
            try
            {
                var any = CreateAuditLogInformation();
                if (any)
                {
                    return base.SaveChanges();
                }

                return 1;
        }

        public bool CreateAuditLogInformation()
        {
            bool any = true;

            foreach (var entry in ChangeTracker.Entries<IAudit>().Where(x => x.State == EntityState.Added))
            {
                var entity = entry.Entity;
                entity.CreationDate = DateTime.Now;
            }

            foreach (var entry in ChangeTracker.Entries<IAudit>().Where(x => x.State == EntityState.Modified))
            {
                var entity = entry.Entity;
                entity.UpdateDate = DateTime.Now;
            }

            foreach (var entry in ChangeTracker.Entries<IUser>().Where(x => x.State == EntityState.Added))
            {
                var entity = entry.Entity;
                string pass = EncryptString(entity.Password);
                entity.Password = pass;
            }

            foreach (var entry in ChangeTracker.Entries<IEmployee>().Where(x => x.State == EntityState.Added))
            {
                var entity = entry.Entity;
                any = ValidaCedula(entity.Identification);
            }

            foreach (var entry in ChangeTracker.Entries<IEmployee>().Where(x => x.State == EntityState.Modified))
            {
                var entity = entry.Entity;
                any = ValidaCedula(entity.Identification);
            }

            return any;
        }

        public static string EncryptString(string inputString)
        {
            byte[] data = System.Text.Encoding.ASCII.GetBytes(inputString);
            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
            string hash = System.Text.Encoding.ASCII.GetString(data);
            return hash;
        }

        public bool ValidaCedula(string cedula)
        {
            if(cedula.Length >= 10)
            {
                return true;
            }
            MessageBox.Show("Identificación inválida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }
}
