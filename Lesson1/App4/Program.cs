using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//x Создать классы Point и Figure.
//x Класс Point должен содержать два целочисленных поля и одно строковое поле.
//x Создать три свойства с одним методом доступа get.
//x Создать пользовательский конструктор, в теле которого проинициализируйте поля значениями аргументов.Класс Figure должен содержать конструкторы, которые принимают от 3-х до 5-ти аргументов типа Point. 
//x Создать два метода: double LengthSide(Point A, Point B), который рассчитывает длину стороны многоугольника; void PerimeterCalculator(), который рассчитывает периметр многоугольника.
//x Написать программу, которая выводит на экран название и периметр многоугольника. 

namespace App4
{
    class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(123, 208, "A");
            Point b = new Point(75, 32, "B");
            Point c = new Point(35, 220, "C");
            Point d = new Point(54, 67, "D");
            Point e = new Point(32, 54, "E");

            Figure triangle = new Figure(a, b, c);
            Figure rectangle = new Figure(a, b, c, d);
            Figure pentagon = new Figure(a, b, c, d, e);

            triangle.PerimeterCalculator();
            rectangle.PerimeterCalculator();
            pentagon.PerimeterCalculator();

        }
    }
}
