using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// В коллекцию  ArrayList, через вызов метода Add добавьте элементы структурного и ссылочного типа, переберите данную коллекцию с помощью, цикла for – С какой проблемой вы столкнулись?
namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList
            {
                10,
                "Hello",
                20,
                "Eizo",
                30,
                "Philips",
                40,
                "Defender"
            };

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
