using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3
{
    class Dictionary<Tkey, TValue>
    {
        int count = 4;
        Tkey[] keys;
        TValue[] values;

        public Dictionary()
        {
            keys = new Tkey[count];
            values = new TValue[count];
        }
        public void Add(Tkey key, TValue value)
        {
            bool flag = false;
            for (int i = 0; i < keys.Length; i++)
            {
                for (int j = i; j < values.Length; j++)
                {
                    if (keys[i] == null && values[j] == null)
                    {
                        keys[i] = key;
                        values[j] = value;
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

        public TValue this[Tkey index]
        {
            get
            {
                TValue temp = default(TValue);
                int tempindex = 0;
                for (int i = 0; i < keys.Length; i++)
                {
                    if (keys[i] != null && keys[i].Equals(index))
                    {
                        tempindex = i;
                        break;
                    }
                }
                for (int i = 0; i < values.Length; i++)
                {
                    if (tempindex == i)
                    {
                        temp = values[i];
                    }
                }
                return temp;
            }
        }

        public int Count
        {
            get
            {
                int temp = keys.Length;
                for (int i = 0; i < keys.Length; i++)
                {
                    if (keys[i]==null)
                    {
                        temp--;
                    }
                }
                return temp;
            }
        }
        
    }
}
