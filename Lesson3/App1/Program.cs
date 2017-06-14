using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//x Создайте класс Printer.
//x В теле класса создайте метод void Print(string value), который выводит на экран значение аргумента.
//x Реализуйте возможность того, чтобы в случае наследования от данного класса других классов, и вызове соответствующего метода их экземпляра, строки, переданные в качестве аргументов методов, выводились разными цветами.
//Обязательно используйте приведение типов.  

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Create instances

            Printer instancePrinter = new Printer();
            instancePrinter.NonVirtualPrint("Non virtual method");
            instancePrinter.Print("Virtual method");

            Console.WriteLine();

            RedPrinter redPrinter = new RedPrinter();
            redPrinter.NonVirtualPrint("Non Virtual redPrinter method inherited from Printer");
            redPrinter.Print("Overrided virtual method inherited from Printer");

            Console.WriteLine();

            GreenPrinter greenPrinter = new GreenPrinter();
            greenPrinter.NonVirtualPrint("Non Virtual greenPrinter method inherited from RedPrinter");
            greenPrinter.Print("Overrided override method inherited from RedPrinter");
            #endregion

            Console.WriteLine(new string('-', 60));
            
            #region UpCast
            Printer upPrinter = redPrinter as Printer;
            upPrinter.NonVirtualPrint("RedPrinter UpCasted to Printer. Invoke NonVirtual Method");
            upPrinter.Print("RedPrinter UpCasted to Printer. Invoke overided method");

            Console.WriteLine();

            upPrinter = greenPrinter as Printer;
            upPrinter.NonVirtualPrint("GreenPrinter UpCasted to Printer. Invoke NonVirtual Method");
            upPrinter.Print("GreenPrinter UpCasted to Printer. Invoke overrided method");

            Console.WriteLine();

            RedPrinter upRedPrinter = greenPrinter as RedPrinter;
            upRedPrinter.NonVirtualPrint("GreenPrinter UpCasted to RedPrinter. Invoke NonVirtual method");
            upRedPrinter.Print("GreenPrinter UpCasted to redPrinter. Invoke overrided method");
            #endregion

            Console.WriteLine(new string('-', 60));

            GreenPrinter downGreenPrinter = (GreenPrinter)upPrinter;
            downGreenPrinter.NonVirtualPrint("Printer DownCasted to GreenPrinter. Invoke NonVirtual method");
            downGreenPrinter.Print("Printer DownCasted to GreenPrinter. Invoke overrided method");

            Console.WriteLine();

            downGreenPrinter = (GreenPrinter)upRedPrinter;
            downGreenPrinter.NonVirtualPrint("RedPrinter DownCasted to GreenPrinter. Invoke NonVirtual method");
            downGreenPrinter.Print("RedPrinter Downcasted to GreenPrinter. Invoke overrided method");
        }
    }
}
