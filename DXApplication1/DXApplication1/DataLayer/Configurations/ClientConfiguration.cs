using Core.Models;
using System.Data.Entity.ModelConfiguration;

namespace Persistence.EntitiesConfigurations
{
    internal sealed class ClientConfiguration: EntityTypeConfiguration<Client>
    {
        public ClientConfiguration()
        {
            HasKey(client => client.Id);
        }
    }
}
