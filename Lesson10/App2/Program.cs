using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//x Создайте класс MyList<T>.Реализуйте в простейшем приближении возможность использования его экземпляра аналогично экземпляру класса List<T>.
//x Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать метод добавления элемента, индексатор для получения значения элемента по указанному индексу и 
//x свойство только для чтения для получения общего количества элементов. 

 // App 4
//x Создайте расширяющий метод: public static T[] GetArray<T>(this MyList<T> list)
//x Примените расширяющий метод к экземпляру типа MyList<T>, разработанному в домашнем задании 2 для данного урока.Выведите на экран значения элементов массива, который вернул расширяющий метод GetArray().

namespace App2
{
    // App 4
    static class Extention
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            T[] array = new T [list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                array[i] = list[i];
            }
            return array;
        }
    }
        
    class Program
    {

        static void Main(string[] args)
        {
            MyList<string> list = new MyList<string>(10);

            list.Add("Hi");
            list.Add("Hello");
            list.Add("World");

            Console.WriteLine(list.Count);
            Console.WriteLine(list[1]);

            // Extention method (App 4)
            string[] array = list.GetArray();

            Console.Write("List contains: ");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]!=null)
                {
                    Console.Write("{0},",array[i]);
                }
            }
        }
    }
}
