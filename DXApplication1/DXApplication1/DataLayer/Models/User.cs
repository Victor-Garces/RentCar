namespace DXApplication1.DataLayer.Models
{
    public sealed class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
    }
}
