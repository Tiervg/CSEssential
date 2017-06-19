using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//x Создать класс Vehicle.
//x В теле класса создайте поля:  координаты и параметры средств передвижения(цена, скорость, год выпуска).  
//x Создайте 3 производных класса Plane, Саг и Ship.
//x Для класса Plane должна быть определена высота и количество пассажиров.
//x Для класса Ship — количество пассажиров и порт приписки.
//x Написать программу, которая выводит на экран информацию о каждом средстве передвижения.

namespace App2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Mitsubisi", "LancerX", 22000, 240, Convert.ToDateTime("2007,11,10"), 10, 10);
            Console.WriteLine(car.ShowInfo());
            Console.WriteLine(new string('-',50));
            Plane plane = new Plane(10000, 250, 2000000, 1049, Convert.ToDateTime("2000,06,12"), 120, 15);
            Console.WriteLine(plane.ShowInfo());
            Console.WriteLine(new string('-',50));
            Ship ship = new Ship(1400, "Southhampton", 14000000, 23, Convert.ToDateTime("2006,03,09"), 250, 90);
            Console.WriteLine(ship.ShowInfo());
            Console.ReadKey();
        }
    }
}
