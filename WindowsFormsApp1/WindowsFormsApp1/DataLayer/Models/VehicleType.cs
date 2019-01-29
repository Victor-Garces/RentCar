using System;

namespace WindowsFormsApp1.DataLayer.Models
{
    public sealed class VehicleType
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}
