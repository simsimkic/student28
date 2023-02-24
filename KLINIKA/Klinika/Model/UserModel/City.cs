using System;

namespace Model.UserModel
{
    public class City
    {
        public Country country { get; set; }
        public String name { get; set; }
        public int postcode { get; set; }

        public City(Country country, String name, int postcode)
        {
            this.country = country;
            this.name = name;
            this.postcode = postcode;
        }

    }
}