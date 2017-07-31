using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


//TODO Используя Visual Studio, создайте проект по шаблону WPF Application.
//TODO Создайте калькулятор на четыре арифметических действия (сложение, вычитание, умножение и деление). Для реализации калькулятора используйте паттерн MVP.

namespace App4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);
        }

        public event EventHandler Addition;
        public event EventHandler Substraction;
        public event EventHandler Multiply;
        public event EventHandler Divide;
        public event EventHandler Result;

        private void addition_Click(object sender, RoutedEventArgs e)
        {
            Addition(sender, e);
        }

        private void substraction_Click(object sender, RoutedEventArgs e)
        {
            Substraction(sender, e);
        }

        private void multiply_Click(object sender, RoutedEventArgs e)
        {
            Multiply(sender, e);
        }

        private void devide_Click(object sender, RoutedEventArgs e)
        {
            Divide(sender, e);
        }

        private void result_Click(object sender, RoutedEventArgs e)
        {
            Result(sender, e);
        }
    }
}
