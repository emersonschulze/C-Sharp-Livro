using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsExamples
{
    class Pitcher
    {
        public Pitcher(Ball ball)
        {
            ball.BallInPlay += new EventHandler(ball_BallInPlay);
        }

        private void ball_BallInPlay(object sender, EventArgs e)
        {
           //Condição para ver se 'e'  também é referente a BallEventArgs
           if(e is BallEventArgs)
            {
                //Aqui acontece uma coerção em que 'e' é convertido em BallEventArgs
                BallEventArgs ballEventArgs = e as BallEventArgs;
                //Logo em seguida as atributos de ballEventArgs são acessados e utilizados
                if ((ballEventArgs.Distance < 95) && (ballEventArgs.Trajectory < 60))
                    CatchBall();
                else
                {
                    CoverFirstBase();
                }

            }
        }

        public void CatchBall()
        {
            Console.WriteLine("Pitcher: Peguei a bola!");
        }

        public void CoverFirstBase()
        {
            Console.WriteLine("Pitcher: vou cobrir a primeira base");
        }
    }
}
