using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    class MyArray
    {
        Random random = new Random();

        /// <summary>
        /// Fill array by random values from 1 to 100
        /// </summary>
        /// <param name="array"></param>
        public void FillArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 100);
            }
        }

        /// <summary>
        /// Show all array elements
        /// </summary>
        /// <param name="array"></param>
        public void ShowArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
        }

        /// <summary>
        /// Searching bigest value in array
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public int SearchBigestValue(int[] array)
        {
            int temp = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (temp < array[i])
                {
                    temp = array[i];
                }
            }
            return temp;
        }

        public int SearchSmallestValue(int[] array)
        {
            int temp = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (temp>array[i])
                {
                    temp = array[i];
                }
            }
            return temp;
        }

        public int SummAllElements(int[] array)
        {
            int summ = 0;
            for (int i = 0; i < array.Length; i++)
            {
                 summ += array[i];
            }
            return summ;
        }

        public double AverageAllElements(int[] array)
        {
            return SummAllElements(array) / array.Length;
        }

        public int[] AllNegativeElements(int[] array)
        {
            int[] tempAr = new int[array.Length];
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]%2==1)
                {

                    tempAr[counter] = array[i];
                    counter++;
                }
            }
            return tempAr;
        }

    }
}
