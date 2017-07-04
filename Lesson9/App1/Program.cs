using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Создайте анонимный метод, который принимает в качестве параметров три целочисленных аргумента и возвращает среднее арифметическое этих аргументов.

namespace App1
{

    public delegate int AverageMean(int a, int b, int c);

    class Program
    {
        static void Main(string[] args)
        {
            // initialize variables by random values
            Random rand = new Random();
            int first = rand.Next(1, 10), second = rand.Next(1, 10), third = rand.Next(1, 10);

            // Anonimized method
            AverageMean mean = delegate (int a, int b, int c) { return (a + b + c) / 3; };

            //Show result
            Console.WriteLine("({0} + {1} + {2}) / 3 = {3}",first,second,third,mean(first, second, third));
        }
    }
}
