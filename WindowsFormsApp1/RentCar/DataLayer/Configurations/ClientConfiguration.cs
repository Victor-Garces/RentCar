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
            HasIndex(caseFile => caseFile.Identification);
            Property(caseFile => caseFile.Name).IsRequired();
            HasIndex(caseFile => caseFile.PersonType);
        }
    }
}
