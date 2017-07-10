using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//x Создайте класс MyDictionary<TKey, TValue>.
//x Реализуйте в простейшем приближении возможность использования его экземпляра аналогично экземпляру класса Dictionary(Урок 6 пример 5). 
//x Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать метод добавления пар элементов, индексатор для получения значения элемента по указанному индексу
//x свойство только для чтения для получения общего количества пар элементов
namespace App3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> dictionary = new MyDictionary<string, string>(5);
            dictionary.Add("мир", "world");
            dictionary.Add("удача", "luck");
            dictionary.Add("крыша", "roof");
            Console.WriteLine(dictionary["крыша"]);
            Console.WriteLine(dictionary.Lenght);


        }
    }
}
