using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            new Presenter(this);
        }

        public event EventHandler Reset = null;

        private void button_Start_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button_Stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            Reset(sender, e);
        }
    }
}
