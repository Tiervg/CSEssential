using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;

namespace App3
{
    class Time
    {
        int sec = 0, sec_dec = 0, min = 0, min_dec = 0, hour = 0, hour_dec = 0;

        public string Sec { get { return sec.ToString(); } }
        public string SecDec { get { return sec_dec.ToString(); } }
        public string Min { get { return min.ToString(); } }
        public string MinDec { get { return min_dec.ToString(); } }
        public string Hours { get { return hour.ToString(); } }
        public string HoursDec { get { return hour_dec.ToString(); } }

        public void StartTime()
        {
            Seconds();
        }

        int Seconds()
        {
            if (sec >= 0 || sec <= 9)
            {
                sec++;
            }
            else
            {
                sec = 0;
                SecondsDec();
            }
            return sec;
        }
        int SecondsDec()
        {
            if (sec_dec >= 0 || sec_dec <= 5)
            {
                sec_dec++;
            }
            else
            {
                sec_dec = 0;
                Minutes();

            }
            return sec_dec;
        }
        int Minutes()
        {

            if (min >= 0 || min <= 9)
            {
                min++;
            }
            else
            {
                min = 0;
                MinutesDec();
            }
            return min;
        }
        int MinutesDec()
        {
            if (min_dec >= 0 || min_dec <= 5)
            {
                min_dec++;
            }
            else
            {
                min = 0;
                Hour();
            }
            return min_dec;
        }
        int Hour()
        {
            if (hour >= 0 || hour <= 9)
            {
                hour++;
            }
            else
            {
                hour = 0;
                HourDec();
            }
            return hour;
        }
        int HourDec()
        {
            if (hour_dec >= 0 || hour_dec <= 2)
            {
                hour_dec++;
            }
            else
            {
                hour_dec = 0;
            }
            return hour_dec;
        }
    }
}
