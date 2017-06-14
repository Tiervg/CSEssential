using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    class Converter
    {
        bool flag = false;
        double uah, result;
        int currencyChoise;
        readonly double usd, eur, rub;

        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }

        #region Convert From UAH

        public double ConvertFromUAH()
        {
            Console.Write("Enter your Hryvna amount:\0");
            double.TryParse(Console.ReadLine(), out uah);
            Console.Write("What currency you want buy: 1 - USD, 2 - EUR, 3 - RUB :\0");
            currencyChoise = Convert.ToInt32(Console.ReadLine());
            switch (currencyChoise)
            {
                case 1:
                    result = uah / usd;
                    flag = true;
                    break;
                case 2:
                    result = uah / eur;
                    flag = true;
                    break;
                case 3:
                    result = uah / rub;
                    flag = true;
                    break;
            }
            if (flag != true || result == 0)
            {
                ConvertFromUAH();
            }
            return result;
        }

        #endregion

        #region Convert To UAH

        public double ConvertToUAH()
        {
            Console.Write("Choise your currency: 1 - USD, 2 - EUR, 3 - RUB :\0");
            int.TryParse(Console.ReadLine(), out currencyChoise);
            Console.Write("Enter your currency amount:\0");
            double currencyAmount = double.Parse(Console.ReadLine());
            switch (currencyChoise)
            {
                case 1:
                    result = currencyAmount * usd;
                    flag = true;
                    break;
                case 2:
                    result = currencyAmount * eur;
                    flag = true;
                    break;
                case 3:
                    result = currencyAmount * rub;
                    flag = true;
                    break;
            }
            while (flag != true || result == 0)
            {
                ConvertToUAH();
            }
            return result;

        }

        #endregion

        public void ShowCurrencyCourse()


        {
            Console.WriteLine("USD course:\0{0}", usd);
            Console.WriteLine("EUR course:\0{0}", eur);
            Console.WriteLine("RUB course:\0{0}", rub);
        }

        public string ToString(double result)
        {
            return string.Format("You recive: {0}", result);
        }
    }
}
