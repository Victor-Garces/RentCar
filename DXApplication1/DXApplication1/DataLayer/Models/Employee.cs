using System;
using System.Collections.Generic;
using Core.Contracts;
using Core.Enums;

namespace DXApplication1.DataLayer.Models
{
    public class Employee : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Identification { get; set; }

        public IdentificationType IdentificationType { get; set; }

        public Workload Workload { get; set; }

        public int PercentCommission { get; set; }

        public DateTime AdmissionDate { get; set; }

        public bool IsActive { get; set; }

        public ISet<Rent> Rents { get; set; }

        public DateTimeOffset CreationDate { get; set; }
        public DateTimeOffset UpdateDate { get; set; }
    }
}
