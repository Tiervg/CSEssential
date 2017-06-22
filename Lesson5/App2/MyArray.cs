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
        /// Returns max value in an array
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public int MaxValue(int[] array)
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

        /// <summary>
        /// Returns minimal value in an array
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public int MinValue(int[] array)
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

        /// <summary>
        /// Returns the sum of all elements in an array
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public int Summ(int[] array)
        {
            int summ = 0;
            for (int i = 0; i < array.Length; i++)
            {
                 summ += array[i];
            }
            return summ;
        }

        /// <summary>
        /// Returns average mean of array
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public int Average(int[] array)
        {
            return Summ(array) / array.Length;
        }

        /// <summary>
        /// Returns all negative values in an array
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
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
