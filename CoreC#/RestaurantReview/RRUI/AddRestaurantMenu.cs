using System;

namespace RRUI
{
    public class AddRestaurantMenu : IMenu
    {
        public void Menu()
        {
            Console.WriteLine();
            Console.WriteLine(@"  /$$$$$$        /$$       /$$");
            Console.WriteLine(@" /$$__  $$      | $$      | $$");
            Console.WriteLine(@"| $$  \ $$  /$$$$$$$  /$$$$$$$");
            Console.WriteLine(@"| $$$$$$$$ /$$__  $$ /$$__  $$");
            Console.WriteLine(@"| $$__  $$| $$  | $$| $$  | $$");
            Console.WriteLine(@"| $$  | $$| $$  | $$| $$  | $$");
            Console.WriteLine(@"| $$  | $$|  $$$$$$$|  $$$$$$$");
            Console.WriteLine(@"|__/  |__/ \_______/ \_______/");
            Console.WriteLine();
            Console.WriteLine("[4] Name");
            Console.WriteLine("[3] City");
            Console.WriteLine("[2] State");
            Console.WriteLine("[1] Add Restaurant");
            Console.WriteLine("[0] Go back");
        }

        public MenuType YourChoice()
        {
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "0":
                    return MenuType.RestaurantMenu;
                case "1":
                    return MenuType.RestaurantMenu;
                case "2":
                    return MenuType.RestaurantMenu;
                case "3":
                    return MenuType.RestaurantMenu;
                case "4":
                    return MenuType.RestaurantMenu;
                default:
                    Console.WriteLine("Input was not correct");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.AddRestaurantMenu;
            }
        }
    }
}