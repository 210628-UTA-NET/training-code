using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Model = RRModel;
using Entity = RRDL.Entities;
using System.Linq;

namespace RRDL
{
    public class Repository : IRepository
    {
        private Entities.DemoDbContext _context;
        public Repository(Entity.DemoDbContext p_context)
        {
            _context = p_context;
        }
        public Model.Restaurant AddRestaurant(Model.Restaurant p_rest)
        {
            _context.Restaurants.Add(new Entity.Restaurant{
                Id = p_rest.Id,
                RestaurantName = p_rest.Name,
                RestaurantState = p_rest.State,
                City = p_rest.City
            });

            _context.SaveChanges();
            return p_rest;
        }

        public List<Model.Restaurant> GetAllRestaurant()
        {
            //Method Syntax way
            return _context.Restaurants.Select(
                rest => 
                    new Model.Restaurant()
                    {
                        Id = rest.Id,
                        Name = rest.RestaurantName,
                        City = rest.City,
                        State = rest.RestaurantState
                    }
            ).ToList();
        }

        public Model.Restaurant GetRestaurant(Model.Restaurant p_rest)
        {
            throw new System.NotImplementedException();
        }
    }
}