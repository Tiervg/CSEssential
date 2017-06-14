using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App4
{
    class Invoice
    {
        readonly int account;
        readonly string customer, provider;
        string[] article = { "videocard", "motherboard", "cpu" };
        int quantity, articlePrice, price;
        public int choiseProduct;

        public int Quantity { set { quantity = value; } get { return quantity; } }

        public string this[int index]
        {
            get { return article[index]; }
        }

        public void ShowArticles()
        {
            for (int i = 0; i < article.Length; i++)
            {
                Console.Write("{0} - {1}\0", i, article[i]);
            }
        }

        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }

        public int OrderedArticle(int choise)
        {
            int orderArticle = 0;
            if (choise == 0)
            {
                orderArticle = 0;
                articlePrice = 650;
            }
            else if (choise == 1)
            {
                orderArticle = 1;
                articlePrice = 350;
            }
            else if (choise ==2)
            {
                orderArticle = 2;
                articlePrice = 700;
            }
            return orderArticle;
        }

        public int Price(int articleQuantity, bool taxes)
        {
            switch (taxes)
            {
                case true:
                        price = Convert.ToInt32(articlePrice * articleQuantity * 0.2);
                        return price;

                case false:
                    price = articlePrice * articleQuantity;
                    return price;
                default: return price;
            }
        }

        public string ShowPrice()
        {
            return string.Format("You order:\0" + quantity + "\0" + article[OrderedArticle(choiseProduct)] + "\0Price:\0" + price);
        }
    }
}
