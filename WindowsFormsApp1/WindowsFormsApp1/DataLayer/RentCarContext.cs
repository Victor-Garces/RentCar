using Microsoft.EntityFrameworkCore;
using WindowsFormsApp1.DataLayer.Models;

namespace WindowsFormsApp1.DataLayer
{
    public class RentCarContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Password=1234;Persist Security Info=True;User ID=sa;Initial Catalog=RentCar;Data Source=WEPSYS-CC");
        }

        internal DbSet<User> Users { get; set; }
        internal DbSet<VehicleType> VehicleTypes { get; set; }
    }
}
