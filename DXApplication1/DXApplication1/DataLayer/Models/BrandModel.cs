using System;
using System.Collections.Generic;

namespace Core.Models
{
    public class BrandModel
    {
        public int Id { get; set; }

        public int BrandId { get; set; }

        public Brand Brand { get; set; }

        public ISet<Vehicle> Vehicles { get; set; }

        public bool IsActive { get; set; }

        public string Description { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime UpdateDate { get; set; }
    }
}
