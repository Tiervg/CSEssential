using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//x Описать структуру с именем Train, содержащую следующие поля: название пункта назначения, номер поезда, время отправления.
//x Написать программу, выполняющую следующие действия: 
//x - ввод с клавиатуры данных в массив, состоящий из восьми элементов типа Train(записи должны быть упорядочены по номерам поездов); 
//x - вывод на экран информации о поезде, номер которого введен с клавиатуры(если таких поездов нет, вывести соответствующее сообщение). 


namespace App2
{
    class Program
    {
        static void Main(string[] args)
        {
            Station southRailway = new Station();

            //add trains 
            southRailway.AddTrain("Kiyv",625,Convert.ToDateTime("15:20") + TimeSpan.FromSeconds(30));
            southRailway.AddTrain("Belgorod", 802, Convert.ToDateTime("21:30") + TimeSpan.FromSeconds(15));
            southRailway.AddTrain("Odessa", 417, DateTime.Now+TimeSpan.FromHours(10));
            southRailway.AddTrain("Lviv", 713, DateTime.Now + TimeSpan.FromHours(15));
            southRailway.AddTrain("Moscow", 219, DateTime.Now + TimeSpan.FromDays(2) + TimeSpan.FromHours(2));
            southRailway.AddTrain("Debaltsevo", 110, DateTime.Parse("22:20"));
            southRailway.AddTrain("Donetsk", 56, DateTime.Parse("14:45"));
            southRailway.AddTrain("Dresden", 2049, DateTime.Now + TimeSpan.FromDays(2) + TimeSpan.FromHours(2) + TimeSpan.FromMinutes(25));

            // show all trains
            Console.WriteLine("Trains in station:");
            Console.WriteLine(new string('-', 58));
            Console.WriteLine("{0,-10} | {1,-20} | {2,-20} |", "Number", "Destination", "Departure");
            Console.WriteLine(new string('-', 58));
            southRailway.ShowTrains();
            Console.WriteLine(new string('-', 58));

            //Show sorted trains table
            Console.WriteLine();
            Console.WriteLine("Trains table sorted by number:");
            Console.WriteLine(new string('-', 58));
            southRailway.SortTrains();
            Console.WriteLine("{0,-10} | {1,-20} | {2,-20} |","Number","Destination","Departure");
            Console.WriteLine(new string ('-',58));
            southRailway.ShowTrains();
            Console.WriteLine(new string('-', 58));

            // Search trains by number
            Console.WriteLine(southRailway[713]);
            Console.WriteLine(southRailway[222]);
        }
    }
}
