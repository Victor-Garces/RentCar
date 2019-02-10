using Core.Enums;
using System;
using System.Collections.Generic;

namespace Core.Models
{
    public class Employee
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

        public DateTime CreationDate { get; set; }

        public DateTime UpdateDate { get; set; }
    }
}
