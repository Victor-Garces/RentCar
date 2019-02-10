using System.Data.Entity.ModelConfiguration;
using DXApplication1.DataLayer.Models;

namespace DXApplication1.DataLayer.Configurations
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
