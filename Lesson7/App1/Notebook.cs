using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    struct Notebook
    {
        string model, manufacture;
        double price;

        public Notebook(string manufacture, string model, double price)
        {
            this.manufacture = manufacture;
            this.model = model;
            this.price = price;
        }

        public void Show()
        {
            Console.WriteLine("Notebook: {0} {1} cost: {2}\u0024", manufacture, model, price);
        }
    }
}
