using RentCar.DataLayer.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RentCar.DataLayer.Configurations
{
    internal class VehicleTypeConfiguration : EntityTypeConfiguration<VehicleType>
    {
        internal VehicleTypeConfiguration()
        {
            HasKey(caseFile => caseFile.Id);
            Property(caseFile => caseFile.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(caseFile => caseFile.Status).IsRequired();
            Property(caseFile => caseFile.Description).IsRequired();
        }
    }
}
