using System;

namespace Model.UserModel
{
    public class Adress
    {
        public City city { get; set; }
        public String name { get; set; }
        public int number { get; set; }

        public Adress(City city, String name, int number)
        {
            this.city = city;
            this.name = name;
            this.number = number;
        }

    }
}