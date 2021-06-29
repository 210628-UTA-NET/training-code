using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace RRModel
{
    public class Restaurant
    {
        private string _city;
        public Restaurant()
        { }
        public string Name { get; set; }
        public string City {

            get
            {
                return _city;
            } 

            set
            {
                if (!Regex.IsMatch(value, "@^[A-Za-z .]+$"))
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
