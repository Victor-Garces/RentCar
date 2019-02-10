using System;
using DXApplication1.Contracts;

namespace Core.Contracts
{
    public interface IEntity: IAudit
    {
        int Id { get; set; }

    }
}
