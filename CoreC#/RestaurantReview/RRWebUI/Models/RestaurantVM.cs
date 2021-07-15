using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RRWebUI.Models
{
    public class RestaurantVM
    {
        public RestaurantVM()
        { }

        public int Id { get; set; }
        public string City { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
    }
}
