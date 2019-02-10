using System;

namespace Core.Contracts
{
    public interface IAudit
    {
        DateTime CreationDate { get; set; }
        DateTime UpdateDate { get; set; }
    }
}
