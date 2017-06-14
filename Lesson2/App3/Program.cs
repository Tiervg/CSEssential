using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Создать класс Employee.
//В теле класса создать пользовательский конструктор, который принимает два строковых аргумента, и инициализирует поля, соответствующие фамилии и имени сотрудника.
//Создать метод рассчитывающий оклад сотрудника (в зависимости от должности и стажа) и налоговый сбор.
//Написать программу, которая выводит на экран информацию о сотруднике(фамилия, имя, должность), оклад и налоговый сбор.

namespace App3
{
    class Program
    {
        static void Main(string[] args)
        {
            double tax =0 ;
            Employee ivanov = new Employee("Ivan", "Ivanov");
            ivanov.Expirience = 7;
            ivanov.Position = "programmer";
            ivanov.WorkerSalary(ref tax);
            Console.WriteLine(ivanov.ShowInfo(tax));

            Employee petrov = new Employee("Petr", "Petrov");
            petrov.Expirience = 2;
            petrov.Position = "PM";
            petrov.WorkerSalary(ref tax);
            Console.WriteLine(petrov.ShowInfo(tax));
        }
    }
}
