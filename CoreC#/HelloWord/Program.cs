using System; //Importing System namespace
using HouseFunction;

/*
    Naming conventions in C#
    -We use PascalCase for most of the naming convention
    -We use camelCase for naming fields 
*/

namespace HelloWord
{
    class Program
    {
        //We can use underscores for private fields to reference them easier in our code
        private static string _first = "Hello";
        public static string _last = "World!";

        /*
            -Main method is the first method that will be called/run. Whenever you do the command dotnet run
            -the static means, I don't have to instantiate the program class to use that method
            -Void, the method will not return anything
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Whatever I want");

            Test obj = new Test(); //Will instantiate the Test class
            obj.SomeMethod();//Method was called because the class was instantiated

            Console.WriteLine(_first + _last);
            Console.WriteLine(obj.SomeMethod());

            // Console.WriteLine(args[0] + args[1]);

            //House Example
            House objHouse = new House();
            Console.WriteLine(objHouse.getColor());
            objHouse.setColor("Blue");
            Console.WriteLine(objHouse.getColor());
            objHouse.Price = 803;
            Console.WriteLine(objHouse.Price);
            objHouse.Name = "Stephen's House";
            Console.WriteLine(objHouse.Name);
            Console.WriteLine("Hello" == "Hello");

            Collection.CollectionMain();

            OOP.OOPMain();

            BoxingAndUnboxing.BoxingAndUnboxingMain();
        }
    }

    class Test
    {
        public string SomeMethod()
        {
            //return keyword will tell that to return the follow implemtation
            return "Hello World SomeMethod";
        }
    }
}
