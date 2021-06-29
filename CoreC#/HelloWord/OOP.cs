using System;

namespace HelloWord
{
    public class Animal
    {
        public Animal()
        { }

        public Animal(string p_color, string p_name)
        {
            Name = p_name;
            Color = p_color;
        }

        public string Name { get; set; }
        public string Color { get; set; }

        //virtual tells the compiler that this method will be overriden by the derived class
        public virtual void Speak()
        {
            Console.WriteLine("Speaking");
        }
    }

    public class Dog : Animal
    {
        private readonly int price;
        private const int price2 = 893;
        public Dog()
        {
            price = 1092;
        }
        public Dog(string p_color, string p_name) : base(p_color, p_name)
        { }

        //This is an example of method overriding in C#
        //overrride tells the compiler that this method will replace (override) the implementation details of the base class
        public override void Speak()
        {
            base.Speak();
            Console.WriteLine("Bark");
        }

        //This is an example of method overloading
        public void Speak(string p_talk)
        {
            Console.WriteLine(p_talk);
        }
    }

    public class OOP
    {
        public static void OOPMain()
        {
            Console.WriteLine("==== OOP Demo====");

            //The three ways to pass data to your new object
            //Create a new dog object
            Dog dog1 = new Dog();
            dog1.Color = "Dark";
            dog1.Name = "Minnie";

            Dog dog2 = new Dog()
            {
                Color = "Light",
                Name = "Marielle"
            };

            //Using constructor
            Dog dog3 = new Dog("Brown", "Jeffery");

            dog1.Speak();
            dog2.Speak();
            dog3.Speak();
            dog1.Speak("The dog is speaking OMG");
        }
    }
}