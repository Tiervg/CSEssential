using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// В коллекцию  ArrayList, через вызов метода Add добавьте элементы структурного и ссылочного типа, переберите данную коллекцию с помощью, цикла for – 
// С какой проблемой вы столкнулись?
namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myList = new ArrayList();
            myList.Add(10);
            myList.Add("Hello!");
            myList.Add(7.5);
            myList.Add("Test");
            myList.Add("ArrayList don't have length property");
            myList.Add("It have Count property");
            Console.WriteLine(3.1415f);

            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }
        }
    }
}
