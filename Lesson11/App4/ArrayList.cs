using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App4
{
    class ArrayList
    {
        object[] array;

        public ArrayList()
        {
            array = new object[4];
        }

        public void Add(object item)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]==null)
                {
                    array[i] = item;
                    break;
                }
            }
        }

        public object this[object index]
        {
            get
            {
                object temp = null;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i]!=null&&array[i].Equals(index))
                    {
                        temp = array[i];
                    }
                }
                return temp;
            }
        }
    }
}
