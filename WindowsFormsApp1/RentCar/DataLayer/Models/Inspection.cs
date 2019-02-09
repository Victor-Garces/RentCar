using RentCar.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentCar.DataLayer.Models
{
    public sealed class Inspection
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Vehicle")]
        public int VehicleId { get; set; }
        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public bool HasCarvings { get; set; }
        public FuelAmount FuelAmount { get; set; }
        public bool HasSpareRubber { get; set; }
        public bool HasACat { get; set; }
        public bool HasGlassBreaks { get; set; }
        public bool StateFirstRubber { get; set; }
        public bool StateSecondRubber { get; set; }
        public bool StateThirdRubber { get; set; }
        public bool StateFourthRubber { get; set; }
        public DateTime Date { get; set; }
        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        public bool Status { get; set; }

    }
}
