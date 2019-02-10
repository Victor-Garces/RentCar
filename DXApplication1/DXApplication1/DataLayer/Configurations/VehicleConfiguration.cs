using System.Data.Entity.ModelConfiguration;
using Core.Models;

namespace Persistence.EntitiesConfigurations
{
    internal sealed class VehicleConfiguration: EntityTypeConfiguration<Vehicle>
    {
        public VehicleConfiguration()
        {
            HasKey(vehicle => vehicle.Id);
            Property(vehicle => vehicle.BrandId).IsRequired();
            Property(vehicle => vehicle.BrandModelId).IsRequired();
            Property(vehicle => vehicle.FuelTypeId).IsRequired();
            Property(vehicle => vehicle.VehicleTypeId).IsRequired();
        }
    }
}
