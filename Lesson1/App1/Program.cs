using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//x Создать класс с именем Address.
//x В теле класса требуется создать поля: index, country, city, street, house, apartment.Для каждого поля, создать свойство с двумя методами доступа.
//x Создать экземпляр класса Address.
//x В поля экземпляра записать информацию о почтовом адресе.  
//x Выведите на экран значения полей, описывающих адрес. 


namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            Adress myAdress = new Adress()
            {
                Index = 654321,
                Country = "Canada",
                City = "Torronto",
                Street = "St. Patrick",
                House = 34,
                Apartment = 26
            };

            Console.WriteLine(myAdress.Show());
        }
    }
}
