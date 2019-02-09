namespace RentCar.DataLayer.Models
{
    public sealed class Model
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}
