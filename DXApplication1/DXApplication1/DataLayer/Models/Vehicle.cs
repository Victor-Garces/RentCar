﻿using Core.Contracts;
using System;
using System.Collections.Generic;

namespace Core.Models
{
    public class Vehicle: IEntity
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public string ChassisNumber { get; set; }

        public string MotorNumber { get; set; }

        public string LicensePlate { get; set; }

        public int VehicleTypeId { get; set; }

        public VehicleType VehicleType { get; set; }

        public int BrandId { get; set; }

        public Brand Brand { get; set; }

        public int BrandModelId { get; set; }

        public BrandModel BrandModel { get; set; }

        public int FuelTypeId { get; set; }

        public FuelType FuelType { get; set; }

        public bool IsActive { get; set; }

        public ISet<Rent> Rents { get; set; }

        public ISet<Inspection> Inspections { get; set; }

        public DateTime CreationDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
