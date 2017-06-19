using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//x Создайте класс AbstractHandler.
//x В теле класса создать методы void Open(), void Create(), void Chenge(), void Save(). 
//x Создать производные классы XMLHandler, TXTHandler, DOCHandler от базового класса AbstractHandler.
//x Написать программу, которая будет выполнять определение документа и для каждого формата должны быть методы открытия, создания, редактирования, сохранения определенного формата документа.

namespace App2
{
    class Program
    {
        static void Main(string[] args)
        {
            Document doc = new Document("doc");
            if (doc.Extention.ToUpper() == "DOC")
            {
                new DOCHandler().Create();
                new DOCHandler().Open();
                new DOCHandler().Change();
                new DOCHandler().Save();
            }
            else if (doc.Extention.ToUpper() == "XML")
            {
                new XMLHandler().Create();
                new XMLHandler().Open();
                new XMLHandler().Change();
                new XMLHandler().Save();
            }
            else if (doc.Extention.ToUpper() == "TXT")
            {
                new TXTHandler().Create();
                new TXTHandler().Open();
                new TXTHandler().Change();
                new TXTHandler().Save();
            }

            else Console.WriteLine("You wrote wrong extention");

        }
    }
}
