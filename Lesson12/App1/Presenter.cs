using System;

// Presenter

namespace MVP
{
    class Presenter
    {
        Model model = null;
        MainWindow mainWindow = null;

        event EventHandler myEvent
        {
            add { mainWindow.myEvent += value; }
            remove { mainWindow.myEvent -= value; }
        }

        public Presenter(MainWindow mainWindow)
        {
            this.model = new Model();
            this.mainWindow = mainWindow;
            myEvent += mainWindow_myEvent;
        }
        


        void mainWindow_myEvent(object sender, System.EventArgs e)
        {
            string variable = model.Logic(this.mainWindow.textBox1.Text);

            this.mainWindow.textBox1.Text = variable;
        }
    }
}
