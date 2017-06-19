using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3
{
    class ClassRoom
    {
        Pupil[] pupil = new Pupil[4];
        Random rand = new Random();

        
        Pupil CreatePupil()
        {
            Pupil pupil = null;
            int value = rand.Next(1, 3);

            if (value==1)
            {
                pupil = new ExcelentPupil();
            }
            else if (value==2)
            {
                pupil = new GoodPupil();
            }
            else if (value==3)
            {
                pupil = new BadPupil();
            }
            return pupil;
        }

        public ClassRoom(Pupil one, Pupil two, Pupil three, Pupil four)
        {
            pupil[0] = one;
            pupil[1] = two;
            pupil[2] = three;
            pupil[3] = four;
        }

        public ClassRoom(Pupil one, Pupil two)
        {
            pupil[0] = one;
            pupil[1] = two;
            pupil[2] = CreatePupil();
            pupil[3] = CreatePupil();
        }

        public ClassRoom(Pupil one, Pupil two, Pupil three) : this(one, two)
        {
            pupil[2] = three;
        }

        public void Show()
        {
            for (int i = 0; i < pupil.Length; i++)
            {
                pupil[i].Show();
                Console.WriteLine(new string('-',50));
            }
        }
    }
}
