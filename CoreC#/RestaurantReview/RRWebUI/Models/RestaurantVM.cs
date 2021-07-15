using RRModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RRWebUI.Models
{
    public class RestaurantVM
    {
        public RestaurantVM()
        { }

        public RestaurantVM(Restaurant p_rest)
        {
            Id = p_rest.Id;
            City = p_rest.City;
            Name = p_rest.Name;
            State = p_rest.State;
            Revenue = p_rest.Revenue;
        }

        public int Id { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string State { get; set; }

        [Required]

        public double Revenue { get; set; }
    }
}
