using System.Data.Entity.ModelConfiguration;
using DXApplication1.DataLayer.Models;

namespace DXApplication1.DataLayer.Configurations
{
    internal sealed class BrandConfiguration: EntityTypeConfiguration<Brand>
    {
        public BrandConfiguration()
        {
            HasKey(brand => brand.Id);
        }
    }
}
