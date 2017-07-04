using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Создайте анонимный метод, который принимает в качестве аргумента массив делегатов и возвращает среднее арифметическое возвращаемых значений методов 
// сообщенных с делегатами в массиве.Методы, сообщенные с делегатами из массива, возвращают случайное значение типа int. 
namespace App3
{
    delegate int AverageMean(Delegate[] arg);
    delegate int RandValue();


    class Program
    {
        static void Main(string[] args)
        {
            int res =0;
            Random rand = new Random();
            // create delegates array
            RandValue[] delegatesArray = new RandValue[3];
            //every delegate in array have lambda expresion that return random value
            for (int i = 0; i < delegatesArray.Length; i++)
            {
                delegatesArray[i] = () => rand.Next(10, 100);
            }

            AverageMean mean = (array) =>
            {
                for (int i = 0; i < array.Length; i++)
                {
                   res += (int) array[i].DynamicInvoke();
                }
                return res / array.Length;
            };
            Console.WriteLine(mean(delegatesArray));
        }
    }
}
