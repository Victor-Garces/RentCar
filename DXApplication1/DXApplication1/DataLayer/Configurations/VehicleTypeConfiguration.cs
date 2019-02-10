using Core.Models;
using System.Data.Entity.ModelConfiguration;

namespace Persistence.EntitiesConfigurations
{
    internal class VehicleTypeConfiguration: EntityTypeConfiguration<VehicleType>
    {
        public VehicleTypeConfiguration()
        {
            HasKey(type => type.Id);
        }
    }
}
