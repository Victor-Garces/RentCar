using System;
using System.Collections.Generic;
using Core.Contracts;

namespace DXApplication1.DataLayer.Models
{
    public class Client : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Identification { get; set; }

        public string CreditCarNumber { get; set; }

        public long CreditLimit { get; set; }

        public bool IsActive { get; set; }

        public ISet<Inspection> Inspections { get; set; }

        public ISet<Rent> Rents { get; set; }

        public DateTime CreationDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
