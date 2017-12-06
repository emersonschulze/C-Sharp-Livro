using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsExamples
{
    class Fan
    {
        public Fan(Ball ball)
        {
            ball.BallInPlay += Ball_BallInPlay;
        }

        private void Ball_BallInPlay(object sender, EventArgs e)
        {
            //Condição para ver se 'e'  também é referente a BallEventArgs
            if (e is BallEventArgs)
            {
                //Aqui acontece uma coerção em que 'e' é convertido em BallEventArgs
                BallEventArgs ballEventArgs = e as BallEventArgs;
                //Logo em seguida as atributos de ballEventArgs são acessados e utilizados
                if ((ballEventArgs.Distance < 400) && (ballEventArgs.Trajectory < 30))
                    HomeRun();
                else
                {
                    Scream();
                }

            }
        }

        public void Scream()
        {
            Console.WriteLine("Aeeeee! Isso mesmo!!!");
        }

        public void HomeRun()
        {
            Console.WriteLine("Home Run! Vou tentar pegar a primeira bola!!!");
        }
    }
}
