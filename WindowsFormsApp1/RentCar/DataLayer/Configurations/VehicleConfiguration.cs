using RentCar.DataLayer.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RentCar.DataLayer.Configurations
{
    internal class VehicleConfiguration : EntityTypeConfiguration<Vehicle>
    {
        internal VehicleConfiguration()
        {
            HasKey(caseFile => caseFile.Id);
            Property(caseFile => caseFile.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(caseFile => caseFile.ChassisNumber).IsRequired();
            Property(caseFile => caseFile.Description).IsRequired();
            Property(caseFile => caseFile.MotorNumber).IsRequired();
            Property(caseFile => caseFile.PlateNumber).IsRequired();
            Property(caseFile => caseFile.Status).IsRequired();
        }
    }
}
