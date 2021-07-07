using System;
using System.Collections.Generic;

#nullable disable

namespace RRDL.Entities
{
    public partial class Restaurant
    {
        public int Id { get; set; }
        public string RestaurantName { get; set; }
        public string City { get; set; }
        public string RestaurantState { get; set; }
    }
}
