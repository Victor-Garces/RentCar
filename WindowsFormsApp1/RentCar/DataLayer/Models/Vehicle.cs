using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentCar.DataLayer.Models
{
    public sealed class Vehicle
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public int ChassisNumber { get; set; }
        public int MotorNumber { get; set; }
        public int PlateNumber { get; set; }
        [ForeignKey("VehicleType")]
        public int VehicleTypeId { get; set; }
        [ForeignKey("Brand")]
        public int BrandId { get; set; }
        [ForeignKey("Model")]
        public int ModelId { get; set; }
        [ForeignKey("FuelType")]
        public int FuelTypeId { get; set; }
        public bool Status { get; set; }
    }
}
