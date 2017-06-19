using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3
{
    class Pupil
    {
        protected virtual void Study() { }
        protected virtual void Read() { }
        protected virtual void Write() { }
        protected virtual void Relax() { }

        public virtual void Show()
        {
            Study();
            Read();
            Write();
            Relax();
        }
    }
}
