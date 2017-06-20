using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//x Создать класс Article, содержащий следующие закрытые поля: 
//x • название товара; 
//todo • название магазина, в котором продается товар; 
//todo • стоимость товара в гривнах.
//todo Создать класс Store, содержащий закрытый массив элементов типа Article.  
//todo Обеспечить следующие возможности: 
//todo • вывод информации о товаре по номеру с помощью индекса; 
//todo • вывод на экран информации о товаре, название которого введено с клавиатуры, если таких товаров нет, выдать соответствующее сообщение; 
//Написать программу, вывода на экран информацию о товаре.

namespace App3
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();
            Console.WriteLine(store["Router"]);
            Console.WriteLine(store[1]);
            Console.WriteLine(store["Videocard"]);
            Console.WriteLine(store[5]);
        }
    }
}
