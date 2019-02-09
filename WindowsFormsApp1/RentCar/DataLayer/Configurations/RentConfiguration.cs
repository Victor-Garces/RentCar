using RentCar.DataLayer.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RentCar.DataLayer.Configurations
{
    internal class RentConfiguration : EntityTypeConfiguration<Rent>
    {
        internal RentConfiguration()
        { 
            HasKey(caseFile => caseFile.Id);
            Property(caseFile => caseFile.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(caseFile => caseFile.AmountPerDay).IsRequired();
            Property(caseFile => caseFile.Comment).IsRequired();
            Property(caseFile => caseFile.DaysQuantity).IsRequired();
            Property(caseFile => caseFile.RentDateTime).IsRequired();
            Property(caseFile => caseFile.ReturnDateTime).IsRequired();
            Property(caseFile => caseFile.Status).IsRequired();
        }
    }
}
