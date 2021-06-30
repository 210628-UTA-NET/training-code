using System;
using System.Text.Json;
using HouseFunction;

namespace HelloWord
{
    public class Serialization
    {
        private const string _filePath = "./StoreFile/House.json";
        public static void SerializationMain()
        {
            Console.WriteLine("==== Serialize Demo ====");
            //Create house object to be serialized
            House house1 = new House()
            {
                Name = "Stephen",
                Price = 500
            };
            house1.setColor("Red");

            //Declare a string var and point it to the serialized version of house1
            string jsonString = JsonSerializer.Serialize(house1, new JsonSerializerOptions {WriteIndented = true});

            Console.WriteLine(jsonString);

            

        }
    }
}