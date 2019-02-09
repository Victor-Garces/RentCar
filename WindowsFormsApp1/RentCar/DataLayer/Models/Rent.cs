using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentCar.DataLayer.Models
{
    public sealed class Rent
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        [ForeignKey("Vehicle")]
        public int VehicleId { get; set; }
        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public DateTime RentDateTime { get; set; }
        public DateTime ReturnDateTime { get; set; }
        public int AmountPerDay { get; set; }
        public int DaysQuantity { get; set; }
        public string Comment { get; set; }
        public bool Status { get; set; }
    }
}
