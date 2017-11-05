using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colmeia
{
    class Bee
    {
        public int ShiftLeft;
        private double Weight;

        public Bee(double weight)
        {
            this.Weight = weight;
        }

        public virtual int ShiftsLeft
        {
            get { return 0; }
        }    

        public virtual double GetHoneyConsumition()
        {
            double Consumition;
            if(ShiftLeft == 0)
            {
                Consumition = 7.5;
            }
            else
            {
                Consumition = 9 + ShiftLeft;
            }

            if(Weight > 150)
            {
                Consumition *= 1.35;
            }

            return Consumition;
        }


    }
}
