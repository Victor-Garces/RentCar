using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using RentCar.DataLayer.Models;

namespace RentCar.DataLayer.Configurations
{
    internal class ModelConfiguration : EntityTypeConfiguration<Model>
    {
        internal ModelConfiguration()
        {
            HasKey(caseFile => caseFile.Id);
            Property(caseFile => caseFile.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(caseFile => caseFile.Description).IsRequired();
            Property(caseFile => caseFile.Status).IsRequired();
        }
    }
}
