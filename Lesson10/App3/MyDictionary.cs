using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3
{
    class MyDictionary<TKey, TValue>
    {
        int length;
        TKey[] keyArray;
        TValue[] valueArray;

        public MyDictionary(int length)
        {
            keyArray = new TKey[length];
            valueArray = new TValue[length];
            this.length = length; 
        }

        public void Add(TKey key, TValue value)
        {
            bool flag = false;
            for (int i = 0; i < keyArray.Length; i++)
            {
                for (int j = 0; j < valueArray.Length; j++)
                {

                    if (keyArray[i] == null && valueArray[j] == null)
                    {
                        keyArray[i] = key;
                        valueArray[j] = value;
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

        public TValue this[TKey index]
        {
            get
            {
                TValue temp = default(TValue);
                int z = 0;
                for (int i = 0; i < keyArray.Length; i++)
                {
                    if (index.Equals(keyArray[i]))
                    {
                        z = i;
                    }
                }
                for (int i = 0; i < valueArray.Length; i++)
                {
                    if (z == i)
                    {
                        temp = valueArray[i];
                    }
                }
                return temp;
            }
        }

        //public TKey this[TValue index]
        //{
        //    get
        //    {
        //        TKey temp = default(TKey);
        //        int z = 0;
        //        for (int i = 0; i < valueArray.Length; i++)
        //        {
        //            if (index.Equals(keyArray[i]))
        //            {
        //                z = i;
        //            }
        //        }

        //        for (int i = 0; i < keyArray.Length; i++)
        //        {
        //            if (z == i)
        //            {
        //                temp = keyArray[i];
        //            }
        //        }
        //        return temp;
        //    }
        //}

        public int Lenght { get { return length; } }


    }
}
