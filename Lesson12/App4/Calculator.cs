using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App4
{
    class Calculator
    {
        public double FirstValue { get; set; }
        public double SecondValue { get; set; }

        public string Addition()
        {
            return (FirstValue + SecondValue).ToString();
        }

        public string Substraction()
        {
            return (FirstValue - SecondValue).ToString();
        }

        public string Multiply()
        {
            return (FirstValue * SecondValue).ToString();
        }

        public string Divide()
        {
            double res = 0;
            if (SecondValue==0)
            {
                return "Attempt to divide by zero";
            }
            else
            {
                res = FirstValue / SecondValue;
            }
            return res.ToString();
        }
    }
}
