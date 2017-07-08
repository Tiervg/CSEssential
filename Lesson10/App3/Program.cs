using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//todo Создайте класс MyDictionary<TKey, TValue>.
//todo Реализуйте в простейшем приближении возможность использования его экземпляра аналогично экземпляру класса Dictionary(Урок 6 пример 5). 
//todo Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать метод добавления пар элементов, индексатор для получения значения элемента по указанному индексу
//todo свойство только для чтения для получения общего количества пар элементов
namespace App3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> dictionary = new MyDictionary<string, string>();
            dictionary.Add("Hello", "world");
        }
    }
}
