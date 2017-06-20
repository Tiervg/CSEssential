using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3
{
    class Store
    {
        Article[] articles = { new Article("Videocard AMD RX490", "Enter", 450.90), new Article("CPU Intel CoreI7 6700k", "Server", 345.5), new Article("Router", "D-Link", 25) };

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < articles.Length; i++)
                {
                    if (index == articles[i].ProductName)
                    {
                        return articles[i].ProductName + ",\0" + articles[i].ShopName + ",\0" + articles[i].Price;
                    }
                }
                return string.Format("There is no article found");
            }
        }

        public string this[int index]
        {
            get
            {
                if (index>=0&&index<=articles.Length)
                {
                    for (int i = 0; i < articles.Length; i++)
                    {
                        if (index == i)
                        {
                            return articles[i].ProductName + ",\0" + articles[i].ShopName + ",\0" + articles[i].Price;
                        }
                    }
                }
                return string.Format("Attempt to access array limits");
            }
        }
    }
}
