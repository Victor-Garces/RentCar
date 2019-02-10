using System;
using Core.Contracts;
using Core.Enums;

namespace DXApplication1.DataLayer.Models
{
    public  class Inspection: IEntity
    {
        public int Id { get; set; }

        public int VehicleId { get; set; }

        public Vehicle Vehicle { get; set; }

        public int ClientId { get; set; }

        public Client Client { get; set; }

        public bool HasGrazes { get; set; }

        public FuelQuantity FuelQuantity { get; set; }

        public bool RubberOne { get; set; }

        public bool RubberTwo { get; set; }

        public bool RubberThree { get; set; }

        public bool RubberFour { get; set; }

        public bool HasReplacementRubber { get; set; }

        public bool HasHydraulicJack { get; set; }

        public bool HasGlassBreaks { get; set; }

        public DateTime CreationDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
