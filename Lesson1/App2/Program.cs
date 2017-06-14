using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//x Создать класс с именем Rectangle.
//x В теле класса создать два поля, описывающие длины сторон double side1, side2.   
//x Создать пользовательский конструктор Rectangle(double side1, double side2), в теле которого поля side1 и side2 инициализируются значениями аргументов.
//x Создать два метода, вычисляющие площадь прямоугольника - double AreaCalculator() и периметр прямоугольника - double PerimeterCalculator().  
//x Создать два свойства double Area и double Perimeter с одним методом доступа get.
//x Написать программу, которая принимает от пользователя длины двух сторон прямоугольника и выводит на экран периметр и площадь

namespace App2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(20, 40);
            Console.WriteLine(rectangle.Perimeter);
            Console.WriteLine(rectangle.Area);
        }
    }
}
