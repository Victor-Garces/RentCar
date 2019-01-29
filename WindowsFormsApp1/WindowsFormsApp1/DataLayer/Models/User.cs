using System;

namespace WindowsFormsApp1.DataLayer.Models
{
    public sealed class User
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
