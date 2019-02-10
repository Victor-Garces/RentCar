using Core.Models;
using System.Data.Entity.ModelConfiguration;

namespace Persistence.EntitiesConfigurations
{
    internal sealed class InspectionConfiguration: EntityTypeConfiguration<Inspection>
    {
        public InspectionConfiguration()
        {
            HasKey(inspection => inspection.Id);
        }
    }
}
