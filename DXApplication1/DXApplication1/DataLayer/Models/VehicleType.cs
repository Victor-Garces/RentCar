using Core.Contracts;
using System;
using System.Collections.Generic;

namespace Core.Models
{
    public class VehicleType: IEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

        public ISet<Vehicle> Vehicles { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
