using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    class Ship : Vehicle
    {
        int passangersCount;
        string port;

        int PassangersCount
        {
            get { return passangersCount; }
            set
            {
                if (value < 0)
                    passangersCount = 0;
                else
                    passangersCount = value;
            }
        }
        string Port { get { return port; } set { port = value; } }

        public Ship(int passangersCount, string port, int price, int speed, DateTime productionDate, int coordX, int coordY) : base(price, speed, productionDate, coordX, coordY)
        {
            PassangersCount = passangersCount;
            Port = port;
        }

        public string ShowInfo()
        {
            return string.Format("Ship passengers count:\0" + PassangersCount + "\nShip port:\0" + Port + "\nShip price:\0" + base.Price + "\nShip speed:\0" + base.Speed + "\nShip coordinates:\0X:" + base.ShowCoordinateX() + "," + "\0Y:" + base.ShowCoordinateY()+"\nShip production date:\0" + base.ProductionDate.ToShortDateString());
        }
    }
}
