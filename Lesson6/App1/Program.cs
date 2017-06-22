using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//x Создать статический класс Calculator, с методами для выполнения основных арифметических операций.
//x Написать программу, которая выводит на экран основные арифметические операции.

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randValue = new Random();
            int a = randValue.Next(0,100), b = randValue.Next(0, 100); 

            Console.WriteLine(Calculator.Sum(a, b));
            Console.WriteLine(Calculator.Subtract(a, b));
            Console.WriteLine(Calculator.Multiply(a, b));
            Calculator.Divide(a, b);
        }
    }
}
