using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    class CarCollection<T> where T : Car
    {
        static int count = 4;
        T[] array = new T[count];

        public void Add(T newCar)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == null)
                {
                    array[i] = newCar;
                    break;
                }
            }
        }

        public string this[string index]
        {
            get
            {
                string temp = null;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] != null)
                    {
                        if (array[i].Name.ToUpper() == index.ToUpper() || array[i].Manufacture.ToUpper() == index.ToUpper())
                        {
                            temp = string.Format("Name:\0" + array[i].Name + "\nManufacture:\0" + array[i].Manufacture + "\nProduction Date:\0" + array[i].ProductionDate.ToShortDateString());
                            break;
                        }
                        else
                            temp = string.Format("Car not found");
                    }
                    else
                    {
                        break;
                    }

                }
                return temp;
            }
        }
        public string this[DateTime index]
        {
            get
            {
                string temp = null;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] != null)
                    {
                        if (array[i].ProductionDate == index)
                        {
                            temp = array[i].ToString();
                            break;
                        }
                        else
                            temp = string.Format("Car not found");
                    }
                    else
                        break;
                }
                return temp;
            }
        }

        public int Count { get { return count; } }

        public string Clear()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = null;
            }
            return "All cars deleted"; 
        }
    }
}
