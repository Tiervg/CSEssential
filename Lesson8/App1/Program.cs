using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//x Реализуйте программу, которая будет принимать от пользователя дату его рождения и выводить количество дней до его следующего дня рождения

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your date of birth:\0");
            DateTime tempBithDate = DateTime.Parse(Console.ReadLine());
            int userBirthDay = tempBithDate.Day;
            int userBithMonth = tempBithDate.Month;
            int userBithYear = DateTime.Now.Year;

            // Form new user bithday date in this year
            DateTime newUserBithDate = new DateTime(userBithYear,userBithMonth,userBirthDay);

            DateTime now = DateTime.Now;
       
            // Check if the bithday already passed
            if (newUserBithDate<now)
            {
                newUserBithDate = newUserBithDate.AddYears(1);
            }
            
            
            TimeSpan left = newUserBithDate - now;
            Console.WriteLine("To your nearest birthday left {0} days",left.Days);
        }
    }
}
