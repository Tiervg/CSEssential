using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//x Создайте статический класс с методом void Print(string stroka, int color), который выводит на экран строку заданным цветом.
//x Используя перечисление, создайте набор цветов, доступных пользователю.Ввод строки и выбор цвета предоставьте пользователю.
namespace App2
{
    class Program
    {
        enum Color
        {
            Red,
            Blue,
            Yellow,
            Green
        }

        static void Main(string[] args)
        {
            // User set text and choose color
            Console.Write("Enter your text:\0");
            string text = Console.ReadLine();
            Console.Write("Choise your text color: red, blue, yellow, green:\0");
            string choosedColor = Console.ReadLine();

            Color enumColor = new Color();
            
            for (enumColor = Color.Red; enumColor<=Color.Green; enumColor++)
            {
                if (choosedColor.ToUpper() == enumColor.ToString().ToUpper())
                {
                    Printer.Print(text, (int)enumColor);
                    break;
                }
            }
        }
    }
}
