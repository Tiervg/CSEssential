using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3
{
    class Dictionary<Tkey, TValue>
    {
        class Key<T> where T : Tkey
        {
            public T Field { get; set; }
        }
        class Value<T> where T : TValue
        {
            public T Field { get; set; }
        }

        static int count = 4;
        Tkey[] arKey = new Tkey[count];
        TValue[] arValue = new TValue[count];

        public void Add(Tkey key, TValue value)
        {
            bool flag = false;
            for (int i = 0; i < arKey.Length; i++)
            {
                for (int j = i; j < arValue.Length; j++)
                {
                    if (arValue[j]==null&&arKey[i]==null)
                    {
                        arKey[i] = key;
                        arValue[j] = value;
                        flag = true;
                        break;
                    }
                }
                if (flag)
                {
                    break;
                }
            }
        }

        public Tkey this[Tkey index]
        {
            get
            {
                Tkey temp = default(Tkey);
                for (int i = 0; i < arKey.Length; i++)
                {
                    if (arKey[i]!=null)
                    {
                        if (tes==index)
                        {
                            temp = arKey[i];
                        }
                    }
                }
            }
        }
    }
}
