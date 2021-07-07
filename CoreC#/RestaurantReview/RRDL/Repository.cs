using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using RRModel;
using System.Linq;

namespace RRDL
{
    public class Repository : IRepository
    {
        private Entities.DemoDbContext _context;
        public Repository(Entities.DemoDbContext p_context)
        {
            _context = p_context;
        }
        public Restaurant AddRestaurant(Restaurant p_rest)
        {
            // List<Restaurant> listOfRestaurants = this.GetAllRestaurant();
            // listOfRestaurants.Add(p_rest);

            // _jsonString = JsonSerializer.Serialize(listOfRestaurants, new JsonSerializerOptions{WriteIndented = true});
            // File.WriteAllText(_filePath, _jsonString);
            // return p_rest;
            throw new System.NotImplementedException();
        }

        public List<Restaurant> GetAllRestaurant()
        {
            //Method Syntax way
            return _context.Restaurants.Select(
                rest => 
                    new Restaurant()
                    {
                        Id = rest.Id,
                        Name = rest.RestaurantName,
                        City = rest.City,
                        State = rest.RestaurantState
                    }
            ).ToList();
        }

        public Restaurant GetRestaurant(Restaurant p_rest)
        {
            throw new System.NotImplementedException();
        }
    }
}