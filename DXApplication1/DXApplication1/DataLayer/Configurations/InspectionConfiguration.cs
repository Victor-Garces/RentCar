using RentCar.DataLayer.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RentCar.DataLayer.Configurations
{
    internal class InspectionConfiguration : EntityTypeConfiguration<Inspection>
    {
        internal InspectionConfiguration()
        {
            HasKey(caseFile => caseFile.Id);
            Property(caseFile => caseFile.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(caseFile => caseFile.Date).IsRequired();
            Property(caseFile => caseFile.FuelAmount).IsRequired();
            Property(caseFile => caseFile.HasACat).IsRequired();
            Property(caseFile => caseFile.HasCarvings).IsRequired();
            Property(caseFile => caseFile.HasGlassBreaks).IsRequired();
            Property(caseFile => caseFile.HasSpareRubber).IsRequired();
            Property(caseFile => caseFile.StateFirstRubber).IsRequired();
            Property(caseFile => caseFile.StateSecondRubber).IsRequired();
            Property(caseFile => caseFile.StateThirdRubber).IsRequired();
            Property(caseFile => caseFile.StateFourthRubber).IsRequired();
            Property(caseFile => caseFile.Status).IsRequired();
            HasRequired(x => x.Client).WithRequiredDependent().WillCascadeOnDelete(false);
            HasRequired(x => x.Vehicle).WithRequiredDependent().WillCascadeOnDelete(false);
            HasRequired(x => x.Employee).WithRequiredDependent().WillCascadeOnDelete(false);
        }
    }
}
