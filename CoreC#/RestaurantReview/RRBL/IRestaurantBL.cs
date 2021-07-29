using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RRModel;

namespace RRBL
{
    /// <summary>
    /// Handles all the business logic for the restaurant model
    /// They are in charge of further processing/ sanitizing/ further validation of data
    /// Any logic that is used to access the data is for the DL, anything else will be in BL
    /// </summary>
    public interface IRestaurantBL
    {
        /// <summary>
        /// Gets all the restaurant from the database
        /// </summary>
        /// <returns>Returns a list of restaurants</returns>
        Task<List<Restaurant>> GetAllRestaurant();

        Restaurant AddRestaurant(Restaurant p_rest);
        /// <summary>
        /// It will get a specific restaurant
        /// </summary>
        /// <param name="p_rest">This restaurant object will be used to check the properties that should match in the database</param>
        /// <returns>Will return the restaurant object from the database</returns>
        Restaurant GetRestaurant(Restaurant p_rest);
        /// <summary>
        /// It will get a specific restaurant using the id
        /// </summary>
        /// <param name="p_id">The Id of the restaurant</param>
        /// <returns>Will return the restaurant object from the database</returns>
        Restaurant GetRestaurant(int p_id);
    }
}
