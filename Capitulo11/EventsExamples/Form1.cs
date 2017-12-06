using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventsExamples
{
    public partial class Form1 : Form
    {

        Ball ball = new Ball();
        Pitcher pitcher;
        Fan fan;


        public Form1()
        {
            InitializeComponent();
            //O lançador e o torcedor estão associados a bola no construtor
            pitcher = new Pitcher(ball);
            fan = new Fan(ball);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Aqui os argumentos do evento são inicializados
            BallEventArgs ballEventArgs = new BallEventArgs((int)Trajetoria.Value, (int)Distancia.Value);

            //Aqui o evento é chamado junto com os argumentos inseridos como parâmetros
            ball.OnBallInPlay(ballEventArgs);
        }
    }
}
