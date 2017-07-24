using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;

namespace App3
{
    class Timer
    {
        int sec = 0, sec_dec = 0, min = 0, min_dec = 0, hour = 0, hour_dec = 0;

        public string Seconds(ref int sec_dec)
        {
            if (sec == 0 && sec <= 9)
            {
                sec++;
            }
            else
            {
                sec = 0;
                sec_dec++;
            }

            return sec.ToString();
        }

        public string SecondsDec(ref int min)
        {
            if (sec_dec == 0 && sec_dec <= 5)
            {
                sec_dec++;
            }
            else
            {
                sec_dec = 0;
                min++;
            }
            return sec_dec.ToString();
        }

        public string Minutes(out int min_dec)
        {
            if (min == 0 && min <= 9)
            {
                min++;
            }
            else
            {
                min = 0;
            }

        }
    }
}
