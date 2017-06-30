using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//x Создайте перечисление, в котором будут содержаться должности сотрудников как имена констант.
//x Присвойте каждой константе значение, задающее количество часов, которые должен отработать сотрудник за месяц.  
//x Создайте класс Accauntant с методом bool AskForBonus(Post worker, int hours), отражающее давать или нет сотруднику премию. Если сотрудник отработал больше положеных часов в месяц, то ему положена премия. 

namespace App3
{
    class Program
    {
        static void Main(string[] args)
        {
            Accountant acc = new Accountant();
            Console.Write("Enter the number of hours worked by the employee:\0");
            int hours = Convert.ToInt32(Console.ReadLine());
            Post sysAdm = Post.SystemAdmin;
            if (acc.AskForBonus(sysAdm, hours))
            {
                Console.WriteLine("You are entitled to a premium");
            }
            else
            {
                Console.WriteLine("You are not entitled to a prize");
            }
        }
    }
}
