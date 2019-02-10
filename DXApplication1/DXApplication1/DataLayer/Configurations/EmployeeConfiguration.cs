using Core.Models;
using System.Data.Entity.ModelConfiguration;

namespace Persistence.EntitiesConfigurations
{
    internal sealed class EmployeeConfiguration: EntityTypeConfiguration<Employee>
    {
        public EmployeeConfiguration()
        {
            HasKey(employee => employee.Id);
        }
    }
}
