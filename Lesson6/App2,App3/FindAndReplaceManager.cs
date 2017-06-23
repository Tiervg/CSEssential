using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2_App3
{
    static class FindAndReplaceManager
    {
        // Extention method 
        public static void FindNext(this Book book,string str)
        {
            Console.WriteLine("Search string: "+str);
            if (book.Content==str||book.AuthorName==str||book.AuthorLastname==str||book.Title==str)
            {
                Console.WriteLine("String {0} found",str);
            }
            else
            {
                Console.WriteLine("String not found");
            }
        }
    }
}
