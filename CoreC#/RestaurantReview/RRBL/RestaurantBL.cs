using System;
using System.Collections.Generic;
using RRDL;
using RRModel;

namespace RRBL
{
    public class RestaurantBL : IRestaurantBL
    {
        /// <summary>
        /// We are defining the dependenices this class needs in the constructor
        /// We do it this way (with interfaces) because we can easily switch out the implementation of RRDL when we want to change data source 
        /// (change from file system into database stored in the cloud)
        /// </summary>
        private IRepository _repo;
        public RestaurantBL(IRepository p_repo)
        {
            _repo = p_repo;
        }

        public Restaurant AddRestaurant(Restaurant p_rest)
        {
            p_rest.State = p_rest.State.ToUpper();
            return _repo.AddRestaurant(p_rest);
        }

        public List<Restaurant> GetAllRestaurant()
        {
            return _repo.GetAllRestaurant();
        }

        public Restaurant GetRestaurant(Restaurant p_rest)
        {
            Restaurant found = _repo.GetRestaurant(p_rest);

            if (found == null)
            {
                throw new Exception("The Restaurant was not found!");
            }

            return found;
        }

        public Restaurant GetRestaurant(int p_id)
        {
            Restaurant found = _repo.GetRestaurant(p_id);

            if (found == null)
            {
                throw new Exception("The Restaurant was not found!");
            }

            return found;
        }
    }
}