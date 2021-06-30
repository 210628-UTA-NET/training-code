using System;
using System.Collections.Generic;
using RRModel;

namespace RRDL
{
    /// <summary>
    /// It is responsible for accessing our database (in this case it will be a JSON file stored in our folder)
    /// </summary>
    public interface IRepository
    {
        /// <summary>
        /// Gets a list of Restaurants stored in our database
        /// </summary>
        /// <returns>Returns a list of Restaurant</returns>
        List<Restaurant> GetAllRestaurant();

        /// <summary>
        /// It will get a specific restaurant
        /// </summary>
        /// <param name="p_rest">This restaurant object will be used to check the properties that should match in the database</param>
        /// <returns>Will return the restaurant object from the database</returns>
        Restaurant GetRestaurant(Restaurant p_rest);

        /// <summary>
        /// It will ad a restaurant in our database
        /// </summary>
        /// <param name="p_rest">This is the restaurant object that will be added to the database</param>
        /// <returns>Will return the restaurant object we just added</returns>
        Restaurant AddRestaurant(Restaurant p_rest);
    }
}
