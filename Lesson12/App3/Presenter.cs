using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App3
{
    class Presenter
    {
        Form1 form;
        Count counter;

        public Presenter(Form1 form)
        {
            counter = new Count();
            this.form = form;
            this.form.sec.Text = counter.Sec;
            this.form.secDec.Text = counter.SecDec;
            this.form.min.Text = counter.Min;
            this.form.minDec.Text = counter.MinDec;
            this.form.hour.Text = counter.Hour;
            this.form.hourDec.Text = counter.HourDec;
            this.form.timer1.Tick += Timer1_Tick;
            this.form.Reset += Timer_Reset;
        }

        private void Timer_Reset(object sender, EventArgs e)
        {
            counter.ResetCounter();
            RefreshTimer();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            counter.SecCount();
            RefreshTimer();
        }

        void RefreshTimer()
        {
            form.sec.Text = counter.Sec;
            form.secDec.Text = counter.SecDec;
            form.min.Text = counter.Min;
            form.minDec.Text = counter.MinDec;
            form.hour.Text = counter.Hour;
            form.hourDec.Text = counter.HourDec;
        }
    }
}
