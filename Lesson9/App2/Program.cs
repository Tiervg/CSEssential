using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Создайте четыре лямбда оператора для выполнения арифметических действий: (Add – сложение, Sub – вычитание, Mul – умножение, Div – деление).
// Каждый лямбда оператор должен принимать два аргумента и возвращать результат вычисления.Лямбда оператор деления должен делать проверку деления на ноль.
// Написать программу, которая будет выполнять арифметические действия указанные пользователем.

namespace App2
{

    public delegate int Calculate(int a, int b);

    class Program
    {
        static void Main(string[] args)
        {
            Calculate sum = (a, b) => { return a + b; };
            Calculate dif = (a, b) => { return a - b; };
            Calculate mul = (a, b) => { return a * b; };
            Calculate div = (a, b) =>
            {
                if (b == 0)
                {
                    Console.WriteLine("Try to devide by zero");
                    return 0;
                }
                else
                    return a / b;
            };

            Random rand = new Random();
            int first = rand.Next(0, 10), second = rand.Next(0, 10);

            Console.WriteLine("{0} + {1} = {2}",first,second,sum(first,second));
            Console.WriteLine("{0} - {1} = {2}",first,second,dif(first,second));
            Console.WriteLine("{0} * {1} = {2}",first,second,mul(first,second));
            Console.WriteLine("{0} / {1} = {2},",first,second,div(first,second));

        }
    }
}
