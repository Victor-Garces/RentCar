using System.Data.Entity.ModelConfiguration;
using DXApplication1.DataLayer.Models;

namespace DXApplication1.DataLayer.Configurations
{
    internal sealed class EmployeeConfiguration: EntityTypeConfiguration<Employee>
    {
        public EmployeeConfiguration()
        {
            HasKey(employee => employee.Id);
        }
    }
}
