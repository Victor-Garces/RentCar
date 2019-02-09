namespace RentCar.DataLayer.Models
{
    public sealed class Vehicle
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int ChassisNumber { get; set; }
        public int MotorNumber { get; set; }
        public int PlateNumber { get; set; }
        public VehicleType VehicleType { get; set; }
        public Brand Brand { get; set; }
        public Model Model { get; set; }
        public FuelType FuelType { get; set; }
        public bool Status { get; set; }
    }
}
