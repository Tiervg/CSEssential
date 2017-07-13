using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//x Создайте класс CarCollection<T>.Реализуйте в простейшем приближении возможность использования его экземпляра для создания парка машин.
//x Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать метод добавления машин с названием машины и года ее выпуска, 
//x индексатор для получения значения элемента по указанному индексу и свойство только для чтения для получения общего количества элементов.  
//x Создайте метод удаления всех машин автопарка. 

namespace App2
{
    class Program
    {


        static void Main(string[] args)
        {
            Car carOne = new Car("Diablo", "Lamborgini", Convert.ToDateTime("20/10/1998"));
            Car carTwo = new Car("Omega", "Opel", Convert.ToDateTime("10/12/1996"));
            Car carThree = new Car("F40", "Ferrari", Convert.ToDateTime("21/12/2016"));
            Car carFour = new Car("Viper", "Dodge", Convert.ToDateTime("13/10/2014"));

            CarCollection<Car> carPark = new CarCollection<Car>();
            carPark.Add(carOne);
            carPark.Add(carTwo);
            carPark.Add(carThree);
            carPark.Add(carFour);

            //search car by name and by manufacture
            Console.WriteLine(carPark["F40"]);
            Console.WriteLine(new string('-',50));

            //search car by name by manufacture
            Console.WriteLine(carPark["lamborgini"]);
            Console.WriteLine(new string('-',50));

            // search car by productionDate
            Console.WriteLine(carPark[Convert.ToDateTime("10/12/1996")].ToString());
            Console.WriteLine(new string('-',50));
            
            // delete all cars
            Console.WriteLine(carPark.Clear());
        }
    }
}
