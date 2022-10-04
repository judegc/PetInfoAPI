using System;
using System.Collections.Generic;

namespace PetInfoAPI.Models
{
    public partial class AvailablePet
    {
        public int PetId { get; set; }
        public string? Name { get; set; }
        public decimal? Price { get; set; }
        public string? Class { get; set; }
        public string? Species { get; set; }
    }
}
