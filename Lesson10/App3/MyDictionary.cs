using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] keyArray = new TKey[4];
        TValue[] valueArray = new TValue[4];

        public void Add(TKey key, TValue value)
        {
            for (int i = 0; i < keyArray.Length; i++)
            {
                for (int j = i; j < valueArray.Length; j++)
                {

                    if (keyArray[i]==null&&valueArray[i]==null)
                    {
                        keyArray[i] = key;
                        valueArray[j] = value;
                        break;
                    }
                }
            }
        }

        public T

    }
}
