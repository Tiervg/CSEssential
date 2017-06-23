using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// todo Создать статический класс FindAndReplaceManager с методом void FindNext(string str) для поиска по книге
// todo Создать в классе Book, вложенный класс Notes, который позволит сохранять заметки читателя

namespace App2_App3
{
    class Program
    {
        static void Main(string[] args)
        {
            Book myBook = new Book("Jeffrey", "Richter", "CLR via C#")
            {
                Content = "Dig deep and master the intricacies of the common language runtime, C#, and .NET development. Led by programming expert Jeffrey Richter, a longtime consultant to the Microsoft .NET team - you’ll gain pragmatic insights for building robust, reliable, and responsive apps and components"
            };
            myBook.FindNext("Richter");
            Book.Notes note = new Book.Notes();
            Console.WriteLine(note.AddNote(myBook.AuthorName));
            Console.WriteLine(note.AddNote(myBook.AuthorLastname));
            string[] myNotes = note.ShowNotes();
            for (int i = 0; i < myNotes.Length; i++)
            {
                if (myNotes[i]!=null)
                {
                    Console.WriteLine("Note {0}: {1}", i, myNotes[i]);
                }
                if (string.IsNullOrEmpty(myNotes[i]))
                {
                    break;
                }
            }
        }
    }
}
