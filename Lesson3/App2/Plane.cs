using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    class Plane : Vehicle
    {
        int altitude, passangersCount;

        public int Altitude
        {
            get { return altitude; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Altitude must be 0 or bigger");
                    altitude = 0;
                }
                else
                    altitude = value;
            }
        }
        public int PasangersCount
        {
            get { return passangersCount; }
            set
            {
                if (value < 0)
                {
                    passangersCount = 0;
                }
                passangersCount = value;
            }
        }

        public Plane(int altitude, int passCount, int price, int speed, DateTime productionDate, int coordX, int coordY) : base(price, speed, productionDate, coordX, coordY)
        {
            this.altitude = altitude;
            this.passangersCount = passCount;
        }

        public string ShowInfo()
        {
            return string.Format("Plane altitude:\0" + Altitude + "\nPlane passangers count:\0" + PasangersCount + "\nPlane price:\0" + base.Price + "\nPlane speed:\0" + base.Speed + "\nPlane coordinates:\0X:" + base.ShowCoordinateX() + "," + "Y:" + base.ShowCoordinateY() + "\nPlane production date:\0" + base.ProductionDate.ToShortDateString());
        }
    }
}
