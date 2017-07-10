using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    class MyList<T>
    {
        int lenth;
        T[] array;

        public MyList(int length)
        {
            array = new T[length];
            this.lenth = length;
        }

        public void Add(T arg)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == null)
                {
                    array[i] = arg;
                    break;
                }
            }
        }

        public T this[int index]
        {
            get
            {
                T res = default(T);
                for (int i = 0; i < array.Length; i++)
                {
                    if (i == index)
                    {
                        res = array[i];
                    }
                }
                return res;
            }
        }

        public int Count { get { return lenth; } }


    }
}
