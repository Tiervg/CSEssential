using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3
{
    class GoodPupil:Pupil
    {
        protected override void Study()
        {
            Console.WriteLine("Good Pupil study good");
        }

        protected override void Read()
        {
            Console.WriteLine("Good pupil has good reading skills");
        }

        protected override void Relax()
        {
            Console.WriteLine("Good pupil have little time for relax");
        }

        protected override void Write()
        {
            Console.WriteLine("Good pupil writes with a small mistakes");
        }

        public override void Show()
        {
            base.Show();
        }
    }
}
