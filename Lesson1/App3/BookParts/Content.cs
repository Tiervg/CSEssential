using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3
{
    class Content
    {
        string contents;

        public string Contents
        {
            private get { return contents; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    Console.WriteLine("Please enter book content");
                else
                    contents = value;
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Contents);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
