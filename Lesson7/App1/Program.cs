using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//x Создайте структуру с именем - Notebook.
//x Поля структуры: модель, производитель, цена.
//x В структуре должен быть реализован конструктор для инициализации полей и метод для вывода содержимого полей на экран.

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook noteBook = new Notebook("Acer", "Aspire 5750g", 554.60);
            noteBook.Show();
        }
    }
}
