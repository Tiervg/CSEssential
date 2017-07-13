using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3
{
    class Dictionary<Tkey, TValue>
    {

        class Key<T> where T : Tkey,new()
        {
            static int count = 4;
            T[] array = new T[count];

            public void Add(T key)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i]==null)
                    {
                        array[i] = key;
                    }
                }
            }
            public T this[T index]
            {
                get
                {
                    T temp = new T();
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i]!= null)
                        {
                            temp = array[i];
                        }
                    }
                    return temp;
                }
            }

        }

        class Value<T> where T : TValue
        {
            static int count = 4;
            T[] array =new  T[count];


        }
    }
}
