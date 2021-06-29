using System;

namespace RRModel
{
    public class Restaurant
    {
        private string _city;
        public Restaurant()
        { }
        public string Name { get; set; }
        public string City {

        get; 

            set
            {
                if (!Regex.isMatch(value, "@^[A-Za-z .]+$"))
                {
                    throw new Exception("City can only hold letters!");
                }

                _city = value;
            }

        }
        public string State { get; set; }

        public List<Review> Reviews { get; set; }
    }
}
