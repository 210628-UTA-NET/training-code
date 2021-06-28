using System;

namespace HouseFunction
{
    public class House
    {
        private string _color;
        private int _price;

        //This is a constructor (special method that is called upon when an object is initialized)
        public House()
        {
            Console.WriteLine("That constructor of this class was used");
            _color = "Red";
        }

        public int Price
        {
            //This is the implementation details to how you can get that naming field
            get
            {
                return _price;
            }

            //This is the implementaiton details to how you can set that naming field
            set
            {
                _price = value;
            }
        }

        public string Name { get; set; }

        //Java way to getting information from field
        public string getColor()
        {
            return _color;
        }
        //Some methods have parameters to send information
        public void setColor(string p_color)
        {
            _color = p_color;
        }
    }
}