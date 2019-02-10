using Core.Models;
using System.Data.Entity.ModelConfiguration;

namespace Persistence.EntitiesConfigurations
{
    internal sealed class BrandConfiguration: EntityTypeConfiguration<Brand>
    {
        /// <summary>
        /// Creates an instance of <see cref="BrandConfiguration"/>
        /// </summary>
        public BrandConfiguration()
        {
            HasKey(brand => brand.Id);
        }
    }
}
