using System.Data.Entity.ModelConfiguration;
using DXApplication1.DataLayer.Models;

namespace DXApplication1.DataLayer.Configurations
{
    internal sealed class RentConfiguration: EntityTypeConfiguration<Rent>
    {
        public RentConfiguration()
        {
            HasKey(rent => rent.Id);
            Property(model => model.ClientId).IsRequired();
            Property(model => model.EmployeeId).IsRequired();
        }
    }
}
