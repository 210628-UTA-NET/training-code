using System;

namespace RRUI
{
    public class RestaurantMenu : IMenu
    {
        public void Menu()
        {
            Console.WriteLine("Welcome to Restaurant Menu!");
            Console.WriteLine("What would you like to do");
            Console.WriteLine("[1] Give list of restaurants");
            Console.WriteLine("[0] Go Back");
        }

        public string YourChoice()
        {
            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "0":
                    return "MainMenu";
                case "1":
                    return "RestaurantMenu";
                default:
                    return "Unknown";
            }
        }
    }
}