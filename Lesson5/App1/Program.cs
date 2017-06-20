using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictoinary myDictiomary = new Dictoinary();
            Console.WriteLine(myDictiomary["table"]);
            Console.WriteLine(myDictiomary[2]);
            Console.WriteLine(myDictiomary["катушка"]);
            Console.WriteLine(myDictiomary[10]);
        }
    }
}
