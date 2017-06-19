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
            Console.WriteLine("Bigest value in array: {0}",new MyArray().SearchBigestValue(array));
            Console.WriteLine("Smallest value in array: {0}",new MyArray().SearchSmallestValue(array));
            Console.WriteLine("Summ of all elements of array: {0}",new MyArray().SummAllElements(array));
            Console.WriteLine("Average of all elements in array: {0}",new MyArray().AverageAllElements(array));
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
