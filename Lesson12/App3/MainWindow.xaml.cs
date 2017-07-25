using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Timers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

//Создайте программу секундомер.
//Требуется выводить показания секундомера в окне.
//Окно имеет кнопки запуска, останова и сброса секундомера. 
//Для реализации секундомера используйте паттерн MVP. 


namespace App3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeTimer();
            new Presenter(this);
        }
        Timer timer;
        public event EventHandler TimerStart = null;
        public event EventHandler TimerStop = null;
        public event EventHandler TimerReset = null;

        private void Timer_Start_Click(object sender, RoutedEventArgs e)
        {
            TimerStart(sender, e);
        }

        private void Timer_Stop_Click(object sender, RoutedEventArgs e)
        {
            TimerStop(sender, e);
        }

        private void Timer_Reset_Click(object sender, RoutedEventArgs e)
        {
            TimerReset(sender, e);
        }

        void InitializeTimer()
        {
            timer = new Timer();
            {
                timer.Interval = 1000;
                timer.Enabled = true;
            }
        }


    }
}
