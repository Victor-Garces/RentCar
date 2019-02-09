using RentCar.DataLayer.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RentCar.DataLayer.Configurations
{
    internal class ClientConfiguration : EntityTypeConfiguration<Client>
    {
        internal ClientConfiguration()
        {
            HasKey(caseFile => caseFile.Id);
            Property(caseFile => caseFile.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(caseFile => caseFile.Status).IsRequired();
            Property(caseFile => caseFile.CrCard).IsRequired();
            Property(caseFile => caseFile.CreditLimit).IsRequired();
            Property(caseFile => caseFile.Name).IsRequired();
            Property(caseFile => caseFile.Identification).IsRequired();
            Property(caseFile => caseFile.PersonType).IsRequired();
        }
    }
}
