using Core.Models;
using System.Data.Entity.ModelConfiguration;

namespace Persistence.EntitiesConfigurations
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
