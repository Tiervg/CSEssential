using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Adress
    {
        int index, house, apartment;
        string country, city, street;

        public int Index
        {
            get { return index; }
            set
            {
                if (value <= 0)
                    Console.WriteLine("Please write your index");
                else
                    index = value;
            }
        }
        public int House
        {
            get { return house; }
            set
            {
                if (value <= 0)
                    Console.WriteLine("Please write correct house number");
                else
                    house = value;

            }
        }
        public int Apartment
        {
            get { return apartment; }
            set
            {
                if (value <= 0)
                    Console.WriteLine("Please write correct apartment number");
                else
                    apartment = value;

            }
        }
        public string Country
        {
            get { return country; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    Console.WriteLine("Please write your country");
                else
                    country = value;
            }
        }
        public string City
        {
            get { return city; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    Console.WriteLine("Please write your city");
                else
                    city = value;
            }
        }
        public string Street
        {
            get { return street; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    Console.WriteLine("Please enter your street");
                else
                    street = value;
            }
        }

        public string Show()
        {
            return "MyIndex:\0" + Index + "\nMy country:\0" + Country + "\nMyCity:\0" + City + "\nMyStreet:\0" + Street + "\nMyHouse:\0" + House + "\nMyApartment:\0" + Apartment;
        }
    }
}
