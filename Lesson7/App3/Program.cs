using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//x Создайте класс MyClass и структуру MyStruct, которые содержат в себе поля public string change.
//x В классе Program  создайте два  метода:  
//todo - static void ClassTaker(MyClass myClass), который присваивает полю change экземпляра myClass значение «изменено». 
//todo - static void StruktTaker(MyStruct myStruct), который присваивает полю change экземпляра myStruct значение «изменено». 
//todo Продемонстрируйте разницу в использовании классов и структур, создав в методе Main() экземпляры структуры и класса.Измените, значения полей экземпляров на «не изменено», а затем вызовите методы ClassTaker и StruktTaker.Выведите на экран значения полей экземпляров. Проанализируйте полученные результаты.

namespace App3
{
    class Program
    {
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "class field changed";
        }

        static void StructTaker(MyStruct myStruct)
        {
            myStruct.change = "struct field changed";
        }

        static void Main(string[] args)
        {
            MyClass @class = new MyClass();
            MyStruct @struct = new MyStruct();

            @class.change = "field class";
            @struct.change = "struct field";

            ClassTaker(@class);
            StructTaker(@struct);

            Console.WriteLine(@class.change);
            Console.WriteLine(@struct.change);
        }
    }
}
