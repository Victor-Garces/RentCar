using System.Data.Entity.ModelConfiguration;
using DXApplication1.DataLayer.Models;

namespace DXApplication1.DataLayer.Configurations
{
    internal sealed class FuelTypeConfiguration: EntityTypeConfiguration<FuelType>
    {
        public FuelTypeConfiguration()
        {
            HasKey(fuel => fuel.Id);
        }
    }
}
