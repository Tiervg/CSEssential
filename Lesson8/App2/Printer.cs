using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    static class Printer
    {
        public static void Print(string str, int color)
        {
            switch (color)
            {
                case 0:
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(str);
                        Console.ResetColor();
                        break;
                    }
                case 1:
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(str);
                        Console.ResetColor();
                        break;
                    }
                case 2:
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(str);
                        Console.ResetColor();
                        break;
                    }
                case 3:
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(str);
                        Console.ResetColor();
                        break;
                    }
            }
        }
    }
}
