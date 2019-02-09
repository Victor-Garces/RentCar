using RentCar.Enums;
using System;

namespace RentCar.DataLayer.Models
{
    public sealed class Inspection
    {
        public int Id { get; set; }
        public Vehicle Vehicle { get; set; }
        public Client Client { get; set; }
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
        public Employee Employee { get; set; }
        public bool Status { get; set; }

    }
}
