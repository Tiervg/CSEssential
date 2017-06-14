using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3
{
    class Author
    {
        string content;

        public string Content
        {
            private get { return content; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    Console.WriteLine("Please enter book author");
                else
                    content = value;
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
