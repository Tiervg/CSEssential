using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//x Создать класс User, содержащий информацию о пользователе(логин, имя, фамилия, возраст, дата заполнения анкеты). 
//x Поле дата заполнения анкеты должно быть проинициализировано только один раз(при создании экземпляра данного класса) без возможности его дальнейшего изменения.
//x Реализуйте вывод на экран информации о пользователе.

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            User newUser = new User();
            newUser.RegisterNewUser("Thunder", "John", "Daw", 56);
            Console.WriteLine(newUser.ShowUser());
        }
    }
}
