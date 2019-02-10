using System;
using Core.Contracts;

namespace DXApplication1.DataLayer.Models
{
    public class Rent: IEntity
    {
        public int Id { get; set; }

        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }

        public int VehicleId { get; set; }

        public Vehicle Vehicle { get; set; }

        public int ClientId { get; set; }

        public Client Client { get; set; }

        public DateTime RentDate { get; set; }

        public DateTime ReturnDate { get; set; }

        public long AmountPerDay { get; set; }

        public long DayQuantity { get; set; }

        public string Comment { get; set; }

        public bool IsActive { get; set; }

        public DateTimeOffset CreationDate { get; set; }
        public DateTimeOffset UpdateDate { get; set; }
    }
}
