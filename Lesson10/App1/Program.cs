using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Создайте класс MyClass<T>, содержащий статический фабричный метод – T FacrotyMethod(), который будет порождать экземпляры типа, указанного в качестве параметра типа(указателя места заполнения типом – Т). 

namespace App1
{

    class Program
    {
        static void Main(string[] args)
        {
            var i = MyClass<int>.FactoryMethod();
            Console.WriteLine(i);
        }
    }
}
