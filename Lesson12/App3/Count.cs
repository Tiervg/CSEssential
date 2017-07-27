using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3
{
    class Count
    {
        int sec = 8, secDec = 5, min = 9, minDec = 5, hour = 3, hourDec = 2;

        public string Sec { get { return sec.ToString(); } }
        public string SecDec { get { return secDec.ToString(); } }
        public string Min { get { return min.ToString(); } }
        public string MinDec { get { return minDec.ToString(); } }
        public string Hour { get { return hour.ToString(); } }
        public string HourDec { get { return hourDec.ToString(); } }

        public void SecCount()
        {
            if (sec >= 0 && sec < 9)
            {
                sec++;
            }
            else
            {
                sec = 0;
                SecDecCount();
            }
        }

        void SecDecCount()
        {
            if (secDec >= 0 && secDec < 5)
            {
                secDec++;
            }
            else
            {
                secDec = 0;
                MinCount();
            }
        }

        void MinCount()
        {
            if (min >= 0 && min < 9)
            {
                min++;
            }
            else
            {
                min = 0;
                MinDecCount();
            }
        }

        void MinDecCount()
        {
            if (minDec >= 0 && minDec < 5)
            {
                minDec++;
            }
            else { minDec = 0; HourCount(); }
        }

        void HourCount()
        {
            if (hour >= 0 && hour < 9)
            {
                hour++;
                if (CheckHours()==true)
                {
                    ResetCounter();
                }
            }
            else { hour = 0; HourDecCount(); }
        }

        void HourDecCount()
        {
            if (hourDec >= 0 && hourDec < 2)
            {
                hourDec++;
            }

            else
            {
                hourDec = 0;
            }
        }

        bool CheckHours()
        {
            bool flag = false;
            if (hourDec == 2 && hour == 4 && minDec == 0 && min == 0 && secDec == 0 && sec == 0)
            {
                flag = true;
            }
            else
            {
                SecCount();
            }
            return flag;
        }

        public void ResetCounter()
        {
            hourDec = 0;
            hour = 0;
            minDec = 0;
            min = 0;
            secDec = 0;
            sec = 0;
        }
    }
}
