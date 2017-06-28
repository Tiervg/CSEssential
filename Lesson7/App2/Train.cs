using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    struct Train
    {
        string destPoint;
        int number;
        DateTime departureTime;

        public string DestinatoinPoint { get { return destPoint; } set { destPoint = value; } }
        public int Number { get { return number; } set { number = value; } }
        public DateTime DepartureTime { get { return departureTime; }set { departureTime = value; } }

        public Train(string destination, int number, DateTime departureTime)
        {
            destPoint = destination;
            this.number = number;
            this.departureTime = departureTime;
        }

    }
}
