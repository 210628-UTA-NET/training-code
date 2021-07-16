using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using RRModel;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace RRDL
{
    public class Repository : IRepository
    {
        private RRDBContext _context;
        public Repository(RRDBContext p_context)
        {
            _context = p_context;
        }
        public Restaurant AddRestaurant(Restaurant p_rest)
        {
            _context.Restaurants.Add(p_rest);
            _context.SaveChanges();
            return p_rest;
        }

        public List<Restaurant> GetAllRestaurant()
        {
            //Method Syntax way
            return _context.Restaurants.Select(rest => rest).ToList();
        }

        public Restaurant GetRestaurant(Restaurant p_rest)
        {
            return _context.Restaurants.AsNoTracking().FirstOrDefault(rest => rest.Name == p_rest.Name
                                                       && rest.City == p_rest.City
                                                       && rest.State == p_rest.State);
        }

        public Restaurant GetRestaurant(int p_id)
        {
            return _context.Restaurants.Find(p_id);
        }

        public Restaurant UpdateRestaurant(Restaurant p_rest)
        {
            _context.Restaurants.Update(p_rest);
            _context.SaveChanges();
            return p_rest;
        }
    }
}