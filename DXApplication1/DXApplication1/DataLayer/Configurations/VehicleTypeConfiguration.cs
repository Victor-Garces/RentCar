using System.Data.Entity.ModelConfiguration;
using DXApplication1.DataLayer.Models;

namespace DXApplication1.DataLayer.Configurations
{
    internal class VehicleTypeConfiguration: EntityTypeConfiguration<VehicleType>
    {
        public VehicleTypeConfiguration()
        {
            HasKey(type => type.Id);
        }
    }
}
