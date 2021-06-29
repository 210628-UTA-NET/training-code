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
            string currentMenu = "MainMenu";

            
            while (repeat)
            {
                Console.Clear();
                restMenu.Menu();
                currentMenu = restMenu.YourChoice();

                switch (currentMenu)
                {
                    case "MainMenu":
                        restMenu = new MainMenu();
                        break;
                    case "RestaurantMenu":
                        restMenu = new RestaurantMenu();
                        break;
                    case "Exit":
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
