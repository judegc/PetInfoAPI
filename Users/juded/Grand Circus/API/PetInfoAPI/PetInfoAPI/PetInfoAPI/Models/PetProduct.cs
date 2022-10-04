using System;
using System.Collections.Generic;

namespace PetInfoAPI.Models
{
    public partial class PetProduct
    {
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public decimal? Price { get; set; }
        public string? Species { get; set; }
    }
}
