using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Создать класс Converter.
//В теле класса создать пользовательский конструктор, который принимает три вещественных аргумента, и инициализирует поля соответствующие курсу 3-х основных валют, 
//по отношению к гривне – public Converter(double usd, double eur, double rub).  
//Написать программу, которая будет выполнять конвертацию из гривны в одну из указанных валют, также программа должна производить конвертацию из указанных валют в гривну.

namespace App2
{
    class Program
    {
        static void Main(string[] args)
        {
            double usd = 0, eur = 0, rub = 0;
            Console.WriteLine("Enter currency course: ");
            Console.Write("USD: ");
            double.TryParse(Console.ReadLine(), out usd);
            Console.Write("EUR: ");
            double.TryParse(Console.ReadLine(), out eur);
            Console.Write("RUB: ");
            double.TryParse(Console.ReadLine(), out rub);

            Converter myConverter = new Converter(usd, eur, rub);

            Console.Write("What operation you want to do: 1 - sale Hryvna , 2 - buy Hryvna , any other key - exit :\0");
            char choise = Convert.ToChar(Console.ReadLine());
            switch (choise)
            {
                case '1':
                    {
                        Console.WriteLine(myConverter.ToString(myConverter.ConvertFromUAH()));
                        break;
                    }
                case '2':
                    {
                        Console.WriteLine(myConverter.ToString(myConverter.ConvertToUAH()));
                        break;
                    }
            }
        }
    }
}
