using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2_App3
{
    class BookAuthor
    {
        string name;
        string lastname;

        public string Name { get { return name; } }
        public string Lastname { get { return lastname; } }

        public BookAuthor(string name,string lastname)
        {
            this.name = name;
            this.lastname = lastname;
        } 
    }
}
