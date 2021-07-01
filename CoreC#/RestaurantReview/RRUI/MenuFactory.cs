using RRBL;
using RRDL;

namespace RRUI
{
    public class MenuFactory : IFactory
    {
        public IMenu GetMenu(MenuType p_menu)
        {
            switch (p_menu)
            {
                case MenuType.MainMenu:
                    return new MainMenu();
                case MenuType.RestaurantMenu:
                    return new RestaurantMenu();
                case MenuType.ShowRestaurantMenu:
                    //ShowRestaurantMenu needs a RestaurantBL object in the parameter because it depends on that object to be able to run its functionality
                    //RestaurantBL needs the Repository object in the parameter because it depends on that object to be able to run
                    //This is call Dependency Injection
                    return new ShowRestaurantMenu(new RestaurantBL(new Repository()));
                case MenuType.AddRestaurantMenu:
                    return new AddRestaurantMenu(new RestaurantBL(new Repository()));
                default:
                    return null;
            }
        }
    }
}