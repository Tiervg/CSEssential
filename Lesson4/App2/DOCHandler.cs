using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    class DOCHandler:AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("DOC file opened");
        }

        public override void Change()
        {
            Console.WriteLine("DOC file changed");
        }

        public override void Save()
        {
            Console.WriteLine("DOC file saved");
        }

        public override void Create()
        {
            Console.WriteLine("DOC file created");
        }
    }
}
