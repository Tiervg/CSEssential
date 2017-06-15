using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3
{
    class ExcelentPupil:Pupil
    {
        protected override void Read()
        {
            Console.WriteLine("Excelent pupil has brilliant read skill");
        }

        protected override void Study()
        {
            Console.WriteLine("Excelent pupil well and quick learn");
        }

        protected override void Relax()
        {
            Console.WriteLine("Excelent pupil don't have time to relax");
        }

        protected override void Write()
        {
            Console.WriteLine("Exelent pupil ");
        }

        public override void Show()
        {
            base.Show();
        }
    }
}
