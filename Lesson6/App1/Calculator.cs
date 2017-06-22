using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    static class Calculator
    {
        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static void Divide(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Divide by zero isn't possible");
            }
            else
            {
                Console.WriteLine(a/b);
            }
        }
    }
}
