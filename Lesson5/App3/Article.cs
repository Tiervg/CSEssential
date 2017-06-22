using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3
{
    class Article
    {
        string productName;
        string shopName;
        double price;

        public string ProductName { get { return productName; } }
        public string ShopName { get { return shopName; } }
        public double Price { get { return price; } }

        public Article(string productName, string shopName, double price)
        {
            this.productName = productName;
            this.shopName = shopName;
            this.price = price;
        }
        
    }
}
