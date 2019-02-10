using System;

namespace DXApplication1.Contracts
{
    public interface IAudit
    {
        DateTimeOffset CreationDate { get; set; }
        DateTimeOffset UpdateDate { get; set; }
    }
}
