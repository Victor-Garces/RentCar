using RentCar.DataLayer.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RentCar.DataLayer.Configurations
{
    internal class BrandConfiguration : EntityTypeConfiguration<Brand>
    {
        internal BrandConfiguration()
        {
            HasKey(caseFile => caseFile.Id);
            Property(caseFile => caseFile.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(caseFile => caseFile.Description).IsRequired();
            Property(caseFile => caseFile.Status).IsRequired();
        }
    }
}
