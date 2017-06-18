using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3
{
    class Player:IRecordable,IPlayable
    {
        public void Pause()
        {
            Console.WriteLine("Pause...");
        }
        void IRecordable.Stop()
        {
            Console.WriteLine("Stop recording...");
        }
        void IPlayable.Stop()
        {
            Console.WriteLine("Stop playing...");
        }

        public void Record()
        {
            Console.WriteLine("Start recording...");
        }

        public void Play()
        {
            Console.WriteLine("Start playing...");
        } 
    }
}
