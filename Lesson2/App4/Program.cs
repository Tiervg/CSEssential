using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//x Создать класс Invoice.
//x В теле класса создать три поля int account, string customer, string provider которые должны быть проинициализированы один раз(при создании экземпляра данного класса) без возможности их дальнейшего изменения.
//x В теле класса создать два закрытых поля string article, int quantity
//x Создать метод расчета стоимости заказа с НДС и без НДС.
//x Написать программу, которая выводит на экран сумму оплаты заказанного товара с НДС или без НДС.


namespace App4
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice myInvoice = new Invoice(123, "Ivanov", "Server");
            Console.Write("Choose article you want to buy: ");
            myInvoice.ShowArticles();
            myInvoice.choiseProduct = myInvoice.OrderedArticle(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Please enter products quantity:\0");
            myInvoice.Quantity = int.Parse(Console.ReadLine());
            Console.Write("Do you need to pay tax (true) or (false):\0");
            bool tax = bool.Parse(Console.ReadLine());
            myInvoice.Price(myInvoice.Quantity, tax);
            Console.WriteLine(myInvoice.ShowPrice());
        }
    }
}
