using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class User
    {
        string login, name, lastname;
        int age;
        readonly DateTime registarationDate;

        public User()
        {
            registarationDate = DateTime.Now;
        }

        public void RegisterNewUser(string login, string name, string lastname, int age)
        {
            this.login = login;
            this.name = name;
            this.lastname = lastname;
            this.age = age;
        }

        public string ShowUser()
        {
            return string.Format("User login:\0" + login + "\nUser name:\0" + name + "\nUser lastname:\0" + lastname + "\nUser age:\0" + age + "\nRegistration date:\0" + registarationDate.ToString("d.MM.yyyy HH:mm"));
        }

    }
}
