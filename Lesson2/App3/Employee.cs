using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3
{
    class Employee
    {
        string name, lastname, position;
        double salary;
        int expirience;

        public Employee(string name, string lastname)
        {
            this.name = name;
            this.lastname = lastname;
        }

        public int Expirience { set { expirience = value; } }
        public string Position { get { return position; } set { position = value; } }

        /// <summary>
        /// Calculate worker salary and tax
        /// </summary>
        /// <param name="choise"></param>
        /// <param name="tax"></param>
        /// <returns></returns>
        public double WorkerSalary(ref double tax)
        {
            switch (position)
            {
                case "programmer":
                    {
                        if (expirience < 1)
                        {
                            salary = 650;
                            tax = 0;
                        }
                        else if (expirience > 1 && expirience < 3)
                        {
                            tax = 1000*0.1;
                            salary = 1000 - tax;
                            
                        }
                        else
                        {
                            tax = 2500 *0.2;
                            salary = 2500 - tax;
                        }
                        break;
                    }
                case "PM":
                    {
                        if (expirience < 1)
                        {
                            salary = 800;
                            tax = 0;
                        }
                        else if (expirience > 1 && expirience < 5)
                        {
                            tax = 1400 * 0.17;
                            salary = 1400-tax;
                        }
                        else
                        {
                            tax = 3500 * 0.25;
                            salary = 3500 -tax;
                        }
                        break;
                    }
                case "QA":
                    {
                        if (expirience < 1)
                        {
                            salary = 350;
                            tax = 0;
                        }
                        else if (expirience > 1 && expirience < 3)
                        {
                            tax = 700*0.1;
                            salary = 700 - tax;
                        }
                        else
                        {
                            tax = 1400 * 0.15;
                            salary = 1400 -tax;
                        }
                        break;
                    }
            }
            return salary;
        }

        public string ShowInfo(double tax)
        {
            return string.Format("Name:\0" + name + "\nLastname:\0" + lastname + "\nPosition:\0" + position + "\nExpirience:\0" + expirience + "\nSalary:\0" + salary + "\nTax:\0"+tax);
        }
    }


}
