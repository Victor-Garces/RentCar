using Core.Models;
using System.Data.Entity.ModelConfiguration;

namespace Persistence.EntitiesConfigurations
{
    internal sealed class BrandModelConfiguration: EntityTypeConfiguration<BrandModel>
    {
        public BrandModelConfiguration()
        {
            HasKey(model => model.Id);
            Property(model => model.BrandId).IsRequired();
        }
    }
}
