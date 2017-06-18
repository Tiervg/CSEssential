using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    class TXTHandler:AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("TXT document opened");
        }

        public override void Change()
        {
            Console.WriteLine("TXT document changed");
        }

        public override void Create()
        {
            Console.WriteLine("TXT document created");
        }

        public override void Save()
        {
            Console.WriteLine("TXT document saved");
        }
    }
}
