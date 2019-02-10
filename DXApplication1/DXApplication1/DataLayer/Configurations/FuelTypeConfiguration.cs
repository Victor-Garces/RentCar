using Core.Models;
using System.Data.Entity.ModelConfiguration;

namespace Persistence.EntitiesConfigurations
{
    internal sealed class FuelTypeConfiguration: EntityTypeConfiguration<FuelType>
    {
        public FuelTypeConfiguration()
        {
            HasKey(fuel => fuel.Id);
        }
    }
}
