using System;

namespace RentCar.DataLayer.Models
{
    public sealed class Rent
    {
        public int Id { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public DateTime RentDateTime { get; set; }
        public DateTime ReturnDateTime { get; set; }
        public int AmountPerDay { get; set; }
        public int DaysQuantity { get; set; }
        public string Comment { get; set; }
        public bool Status { get; set; }
    }
}
