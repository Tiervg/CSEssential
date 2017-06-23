using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2_App3
{
    class Book
    {
        BookAuthor author;
        BookTitle title;
        BookContent content;

        public Book(string authorName, string authorLastname, string title)
        {
            author = new BookAuthor(authorName, authorLastname);
            this.title = new BookTitle(title);
            content = new BookContent();
        }

        public string Content { get { return content.Content; } set { content.Content = value; } }
        public string AuthorName { get { return author.Name; } }
        public string AuthorLastname { get { return author.Lastname; } }
        public string Title { get { return title.Title; } }

        public void Show()
        {
            Console.WriteLine("Author: {0} {1}", author.Name, author.Lastname);
            Console.WriteLine("Title: {0}", title.Title);
            Console.WriteLine("Content: {0}", content.Content);
        }

        public class Notes
        {
            string[] notes = new string[5];

            public string AddNote(string noteText)
            {
                string result = null;
                for (int i = 0; i < notes.Length; i++)
                {
                    if (notes[i] == null)
                    {
                        notes[i] = noteText;
                        result = string.Format("Note saved");
                        break;
                    }
                    else
                        result = string.Format("Note not saved");
                }
                return result;
            }

            public string[] ShowNotes()
            {
                string[] result = new string[notes.Length];
                for (int i = 0; i < notes.Length; i++)
                {
                    if (notes[i]!=null)
                    {
                        result[i] = notes[i];
                    }
                    if (notes[i]==null)
                    {
                        break;
                    }
                }
                return result;
            }
        }
    }
}
