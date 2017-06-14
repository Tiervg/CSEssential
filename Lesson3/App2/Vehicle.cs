using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    class Vehicle
    {
        Coordinates coordinate = new Coordinates();
        int price, speed;
        DateTime productionDate;

        protected int Price
        {
            get { return price; }
            private set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Bad price!");
                    price = 0;
                }
                else
                    price = value;
            }
        }
        protected int Speed
        {
            get { return speed; }
             set
            {
                if (value < 0)
                {
                    Console.WriteLine("The speed can not be less than 0");
                    speed = 0;
                }
                else
                    speed = value;
            }
        }

        protected DateTime ProductionDate { get { return productionDate; }}

        public Vehicle(int price,int speed,DateTime productionDate,int coordX,int coordY)
        {
            Price = price;
            Speed = speed;
            this.productionDate = productionDate;
            coordinate.X = coordX;
            coordinate.Y = coordY;
        }

        protected int ShowCoordinateX()
        {
            return coordinate.X;
        }
        protected int ShowCoordinateY()
        {
            return coordinate.Y;
        }
    }
}
