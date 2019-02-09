using System;
using System.ComponentModel.DataAnnotations;

namespace RentCar.DataLayer.Models
{
    public sealed class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Identification { get; set; }
        public string WorkShift { get; set; }
        public int PercentCommission { get; set; }
        public DateTime AdmissionDate { get; set; }
        public bool Status { get; set; }
    }
}
