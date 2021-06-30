using System;
using RRModel;

namespace RRUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IMenu restMenu = new MainMenu();
            bool repeat = true;
            MenuType currentMenu = MenuType.MainMenu;

            
            while (repeat)
            {
                Console.Clear();
                restMenu.Menu();
                currentMenu = restMenu.YourChoice();

                switch (currentMenu)
                {
                    case MenuType.MainMenu:
                        restMenu = new MainMenu();
                        break;
                    case MenuType.RestaurantMenu:
                        restMenu = new RestaurantMenu();
                        break;
                    case MenuType.Exit:
                        repeat = false;
                        break;
                    default:
                        Console.WriteLine("Cannot process what you want please try again");
                        break;
                }
            }
        }
    }
}
