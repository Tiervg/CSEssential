using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Dictoinary
    {
        string[] rus = { "стол", "стул", "окно", "дверь", "мышь" };
        string[] eng = { "table", "chair", "window", "door", "mice" };
        string[] ukr = { "стіл", "стілець", "вікно", "двері", "миша" };

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < rus.Length; i++)
                {
                    if (index == rus[i])
                    {
                        return rus[i] + "\0-\0" + eng[i] + "\0-\0" + ukr[i];
                    }
                    if (index == eng[i])
                    {
                        return eng[i] + "\0-\0" + ukr[i] + "\0-\0" + rus[i];
                    }
                    if (index == ukr[i])
                    {
                        return ukr[i] + "\0-\0" + eng[i] + "\0-\0" + rus[i];
                    }
                }
                return string.Format("There is no word in this dictionary");
            }
        }

        public string this[int index]
        {
            get
            {

                if (index >= 0 && index <= rus.Length)
                {
                    for (int i = 0; i < rus.Length; i++)
                    {
                        if (index == i)
                        {
                            return rus[i] + "\0-\0" + eng[i] + "\0-\0" + ukr[i];
                        }
                    }
                }
                return string.Format("Attempt to access array limits"); 
            }
        }
    }
}
