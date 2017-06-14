using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3
{
    class Title
    {
        string content;

        public string Content
        {
            private get { return content; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    Console.WriteLine("Please enter book title");
                else
                    content = value;
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
