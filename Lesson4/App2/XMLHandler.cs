using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    class XMLHandler:AbstractHandler
    {

        public override void Open()
        {
            Console.WriteLine("XML document opened");
        }

        public override void Change()
        {
            Console.WriteLine("XML document changed");
        }

        public override void Create()
        {
            Console.WriteLine("XML document created");
        }

        public override void Save()
        {
            Console.WriteLine("XML document saved");
        }
    }
}
