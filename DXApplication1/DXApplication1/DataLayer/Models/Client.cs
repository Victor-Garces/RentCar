using System.ComponentModel.DataAnnotations;
using RentCar.Enums;

namespace RentCar.DataLayer.Models
{
    public sealed class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Identification { get; set; }
        public int CrCard { get; set; }
        public int CreditLimit { get; set; }
        public PersonType PersonType { get; set; }
        public bool Status { get; set; }
    }
}
