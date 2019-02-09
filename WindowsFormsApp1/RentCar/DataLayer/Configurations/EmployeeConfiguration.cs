using RentCar.DataLayer.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RentCar.DataLayer.Configurations
{
    internal class EmployeeConfiguration : EntityTypeConfiguration<Employee>
    {
        internal EmployeeConfiguration()
        {
            HasKey(caseFile => caseFile.Id);
            Property(caseFile => caseFile.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(caseFile => caseFile.Identification).IsRequired();
            Property(caseFile => caseFile.AdmissionDate).IsRequired();
            Property(caseFile => caseFile.Name).IsRequired();
            Property(caseFile => caseFile.PercentCommission).IsRequired();
            Property(caseFile => caseFile.Status).IsRequired();
            Property(caseFile => caseFile.WorkShift).IsRequired();
        }
    }
}
