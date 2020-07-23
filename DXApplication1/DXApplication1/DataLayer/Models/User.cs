using Core.Enums;
using DXApplication1.Contracts;

namespace DXApplication1.DataLayer.Models
{
    public sealed class User : IUser
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }

        public UserRole Rol { get; set; }
    }
}
