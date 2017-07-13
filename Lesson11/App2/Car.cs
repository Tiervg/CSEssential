using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    class Car
    {
        string name;
        string manufacture;
        DateTime productionDate;

        public string Name { get { return name; } }
        public DateTime ProductionDate { get { return productionDate; } }
        public string Manufacture { get { return manufacture; } }

        public Car(string name, string manufacture, DateTime prodDate)
        {
            this.name = name;
            this.manufacture = manufacture;
            this.productionDate = prodDate;
        }

        public override string ToString()
        {
            return string.Format("Name:\0" + name + "\nManufacture:\0" + manufacture + "\nProduction date:\0" + productionDate.ToShortDateString());
        }
    }
}
