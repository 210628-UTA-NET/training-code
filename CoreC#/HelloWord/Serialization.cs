using System;
using System.IO;
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

            //Store this jsonString into a JSON file
            File.WriteAllText(_filePath, jsonString);

            //Deserialize the object we just stored
            try
            {
                //ReadAllText method will read the file that you gave
                jsonString = File.ReadAllText(_filePath);
                //Deserialize method will deserialize the jsonString into the object that you specified <T>
                House house2 = JsonSerializer.Deserialize<House>(jsonString);

                //Just to see if we got the same object that was stored in our JSON file
                Console.WriteLine(house2);
            }
            catch (System.Exception)
            {
                //Will catch the error if the file can't be found by the given path
                Console.WriteLine("The file used to store your information is corrupt");
            }

        }
    }
}