using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsExamples
{
    class Bat
    {
        private BatCallback hitBallCalback;

        public Bat(BatCallback callbackDelegate)
        {
            this.hitBallCalback = new BatCallback(callbackDelegate);
        }

        public void HitTheBall(BallEventArgs e)
        {
            if(hitBallCalback != null)
            {
                //hitBallCalback(e);
            }
        }
    }
}
