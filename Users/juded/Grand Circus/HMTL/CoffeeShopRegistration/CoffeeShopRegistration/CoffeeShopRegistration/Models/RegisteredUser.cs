using System;
using System.Collections.Generic;

namespace CoffeeShopRegistration.Models
{
    public partial class RegisteredUser
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int? Points { get; set; } = 0;
        public DateTime TimeStamp { get; set; }
    }
}
