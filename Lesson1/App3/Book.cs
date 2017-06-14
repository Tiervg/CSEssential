using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3
{
    class Book
    {
        Title title;
        Author author;
        Content content;

        public Book(string title)
        {
            InitializeParts();
            this.title.Content = title;
        }

        void InitializeParts()
        {
            this.title = new Title();
            this.author = new Author();
            this.content = new Content();
        }

        public string Author
        {
            set { author.Content = value; }
        }

        public string Content
        {
            set { content.Contents = value; }
        }

        public void Show()
        {
            title.Show();
            author.Show();
            content.Show();
        }
    }
}
