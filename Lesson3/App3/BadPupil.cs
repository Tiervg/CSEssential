using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3
{
    class BadPupil:Pupil
    {
        protected override void Read()
        {
            Console.WriteLine("Bad pupil has bad reading skills");
        }

        protected override void Study()
        {
            Console.WriteLine("Bad pupil study bad");
        }

        protected override void Write()
        {
            Console.WriteLine("Bad pupil write with a lot of mistakes");
        }

        protected override void Relax()
        {
            Console.WriteLine("Bad pupil have a lot of time for relax, but he(she) seek to be better");
        }

        public override void Show()
        {
            base.Show();
        }

    }
}
