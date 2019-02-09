using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentCar.DataLayer.Models
{
    public sealed class Model
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Brand")]
        public int BrandId { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}
