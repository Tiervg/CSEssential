using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    class Car:Vehicle
    {
        string brand;
        string factory;

        public Car(string factory,string brand,int price,int speed,DateTime prodDate,int coordX,int coordY):base(price,speed,prodDate,coordX,coordY)
        {
            this.factory = factory;
            this.brand = brand;            
        }

        public string ShowInfo()
        {
            return string.Format("Car factory:\0" + factory + "\nCar brand:\0" + brand + "\nCar price:\0" + base.Price + "\nCar speed:\0" + base.Speed +"\nCar coordinates:\0X:\0"+base.ShowCoordinateX()+","+"Y:\0"+base.ShowCoordinateY()+"\nCar production date:\0"+base.ProductionDate.ToShortDateString());
        }
    }
}
