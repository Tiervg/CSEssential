using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//x создать расширяющий метод для целочисленного массива, который сортирует элементы массива по возрастанию.
namespace App4
{
    static class Array
    {
        public static int[] SortArrByAsc(this int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        array[i] = array[i] + array[j];
                        array[j] = array[i] - array[j];
                        array[i] = array[i] - array[j];
                    }
                }

            }
            return array;
        }

        public static void ShowSortedArr(this int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0},\0", array[i]);
            }
        }

        public static void ShowUnsortArray(this int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0},\0",array[i]);
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 6, 3, 9, 0, 7, 2, 5, 8, 4 };
            Console.Write("Unsorted array:\0");
            array.ShowUnsortArray();
            Console.WriteLine();
            int[] sortedArray = array.SortArrByAsc();
            Console.WriteLine();
            Console.Write("Sorted array:\0");
            sortedArray.ShowSortedArr();
        }
    }
}
