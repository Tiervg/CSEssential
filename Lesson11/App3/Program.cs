using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//x Создайте класс Dictionary<TKey, TValue>.
//x Реализуйте в простейшем приближении возможность использования его экземпляра аналогично экземпляру класса Dictionary из пространства имен System.Collections.Generic.
//x Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать метод добавления пар элементов, индексатор для получения значения элемента по указанному индексу ключа и 
//x свойство только для чтения для получения общего количества пар элементов.
namespace App3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("ручка", "pen");
            dic.Add("небо", "sky");
            dic.Add("стекло", "glass");

            Console.WriteLine(dic["небо"]);

            Console.WriteLine(dic.Count);
        }
    }
}
