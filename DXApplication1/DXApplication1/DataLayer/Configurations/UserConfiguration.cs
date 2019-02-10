using DXApplication1.DataLayer.Models;
using System.Data.Entity.ModelConfiguration;

namespace DXApplication1.DataLayer.Configurations
{
    internal sealed class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            HasKey(brand => brand.Id);
        }
    }
}
