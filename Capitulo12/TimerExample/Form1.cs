using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Console.WriteLine(DateTime.Now.ToString());
        }

        private void btnAtivo_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Enabled = false;
            }
            else
            {
                timer1.Enabled = true;
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            timer1.Start();
            Console.WriteLine("Enabled = "+timer1.Enabled);
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Console.WriteLine("Enable = " + timer1.Enabled);

        }
    }
}
