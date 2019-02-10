using System;

namespace Core.Contracts
{
    public interface IEntity: IAudit
    {
        int Id { get; set; }

    }
}
