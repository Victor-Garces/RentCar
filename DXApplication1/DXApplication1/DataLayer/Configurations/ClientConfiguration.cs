using System.Data.Entity.ModelConfiguration;
using DXApplication1.DataLayer.Models;

namespace DXApplication1.DataLayer.Configurations
{
    internal sealed class ClientConfiguration: EntityTypeConfiguration<Client>
    {
        public ClientConfiguration()
        {
            HasKey(client => client.Id);
        }
    }
}
