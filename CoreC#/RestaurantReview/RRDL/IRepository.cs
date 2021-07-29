using System;
using System.Collections.Generic;
using System.Threading.Tasks;
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
        Task<List<Restaurant>> GetAllRestaurant();

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

        /// <summary>
        /// It will ad a restaurant in our database
        /// </summary>
        /// <param name="p_rest">This is the restaurant object that will be added to the database</param>
        /// <returns>Will return the restaurant object we just added</returns>
        Restaurant AddRestaurant(Restaurant p_rest);
        /// <summary>
        /// It will update a restaurant in the database
        /// </summary>
        /// <param name="p_rest">This is the restaurant it will be updating</param>
        /// <returns></returns>
        Restaurant UpdateRestaurant(Restaurant p_rest);
        /// <summary>
        /// This will get all the reviews from a restaurant
        /// </summary>
        /// <param name="p_rest">This is the resturant it will get the reviews from</param>
        /// <returns></returns>
        List<Review> GetReviews(Restaurant p_rest);
    }
}
