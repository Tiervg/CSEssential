using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//x Создайте класс MyList<T>.Реализуйте в простейшем приближении возможность использования его экземпляра аналогично экземпляру класса List<T>.
//x Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать метод добавления элемента, индексатор для получения значения элемента по указанному индексу и 
//x свойство только для чтения для получения общего количества элементов. 
namespace App2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> list = new MyList<string>();

            list.Add("Hi");
            list.Add("Hello");

            Console.WriteLine(list.Count);
            Console.WriteLine(list[1]);
        }
    }
}
