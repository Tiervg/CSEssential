using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    class Program:MyArray
    {

        static void Main(string[] args)
        {
            int[] array = new int[new Random().Next(10, 20)];
            new MyArray().FillArray(array);
            Console.Write("Array elements:\0");
            new MyArray().ShowArray(array);
            Console.WriteLine();
            Console.WriteLine("Maximum value in an array: {0}",new MyArray().MaxValue(array));
            Console.WriteLine("Minimum value in an array: {0}",new MyArray().MinValue(array));
            Console.WriteLine("Summ of all elements of array: {0}",new MyArray().Summ(array));
            Console.WriteLine("Count of elements in an array: {0}",array.Length);
            Console.WriteLine("Average of all elements in array: {0}",new MyArray().Average(array));
            int[] negative = new MyArray().AllNegativeElements(array);
            Console.Write("All negative elements in array:\0");
            for (int i = 0; i < negative.Length; i++)
            {
                if (negative[i]!=0)
                {
                    Console.Write("{0}\0",negative[i]);
                }
            }
        }
    }
}
