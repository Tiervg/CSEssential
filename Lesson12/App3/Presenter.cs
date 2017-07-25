using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3
{
    class Presenter
    {
        Time time;
        MainWindow mainWindow;

        public Presenter(MainWindow window)
        {
            time = new Time();
            mainWindow = window;
            mainWindow.TimerStart += MainWindow_TimerStart;
        }

        private void MainWindow_TimerStart(object sender, EventArgs e)
        {
            time.StartTime();
        }
    }
}
