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
    }
}