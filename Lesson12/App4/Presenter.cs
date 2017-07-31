using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App4
{
    class Presenter
    {
        Calculator calculator;
        MainWindow mainwindow;
        string result;

        public Presenter(MainWindow main)
        {
            calculator = new Calculator();
            mainwindow = main;
            mainwindow.Addition += Mainwindow_Addition;
            mainwindow.Substraction += Mainwindow_Substraction;
            mainwindow.Multiply += Mainwindow_Multiply;
            mainwindow.Divide += Mainwindow_Divide;
            mainwindow.Result += Mainwindow_Result;
        }

        private void Mainwindow_Result(object sender, EventArgs e)
        {
            mainwindow.resultValue.Content = result;
        }

        private void Mainwindow_Divide(object sender, EventArgs e)
        {
            mainwindow.sight.Content = '/';
            ValuesToCalculator();
            result = calculator.Divide();
        }

        private void Mainwindow_Multiply(object sender, EventArgs e)
        {
            mainwindow.sight.Content = '*';
            ValuesToCalculator();
            result = calculator.Multiply();
        }

        private void Mainwindow_Substraction(object sender, EventArgs e)
        {
            mainwindow.sight.Content = '-';
            ValuesToCalculator();
            result = calculator.Substraction();
        }

        private void Mainwindow_Addition(object sender, EventArgs e)
        {
            mainwindow.sight.Content = '+';
            ValuesToCalculator();
            result = calculator.Addition();
        }

        void ValuesToCalculator()
        {
            calculator.FirstValue = Convert.ToDouble(mainwindow.firstValue.Text);
            calculator.SecondValue = Convert.ToDouble(mainwindow.secondValue.Text);
        }


    }
}
