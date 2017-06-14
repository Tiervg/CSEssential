using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//x Создать класс Book.
//x Создать классы  Title, Author и Content, каждый из которых должен содержать одно строковое поле и метод void Show().  
//x Реализуйте возможность добавления в книгу названия книги, имени автора и содержания.
//x Выведите на экран разными цветами при помощи метода Show() название книги, имя автора и содержание

namespace App3
{
    class Program
    {
        static void Main(string[] args)
        {
            Book myBook = new Book("CLR via C#")
            {
                Author = "Jeffrey M. Richter",
                Content = "Dig deep and master the intricacies of the common language runtime, C#, and .NET development. Led by programming expert Jeffrey Richter, a longtime consultant to the Microsoft .NET team - you’ll gain pragmatic insights for building robust, reliable, and responsive apps and components"
            };

            myBook.Show();
        }
    }

}
