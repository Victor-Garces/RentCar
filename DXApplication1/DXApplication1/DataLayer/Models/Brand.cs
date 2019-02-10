using System;
using System.Collections.Generic;
using Core.Contracts;

namespace DXApplication1.DataLayer.Models
{
    public class Brand : IEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

        public ISet<Vehicle> Vehicles { get; set; }

        public ISet<BrandModel> BrandModels { get; set; }
        public DateTimeOffset CreationDate { get; set; }
        public DateTimeOffset UpdateDate { get; set; }
    }
}
