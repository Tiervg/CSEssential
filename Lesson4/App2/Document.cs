using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    class Document
    {
        string extention;

        public Document(string extention)
        {
            this.extention = extention;
        }
        public string Extention { get { return extention; } }
    }
}
