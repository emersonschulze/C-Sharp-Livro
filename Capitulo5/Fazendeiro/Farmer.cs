using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fazendeiro
{
    class Farmer
    {
        //A propriedade BagsOfFeed é pública somente para leitura, porém para 
        //alteração ela é privada
        public int BagsOfFeed { get; private set; }

        public int FeedMultiplier { get; private set; }
        private int numberOfCows;

        //Construtor
        public Farmer(int numberOfCows, int feedMultiplier)
        {
            FeedMultiplier = feedMultiplier;
            this.NumberOfCows = numberOfCows;   

        }


        public int NumberOfCows
        {
            get
            {
                return numberOfCows;
            }
            set
            {
                numberOfCows = value;
                BagsOfFeed = numberOfCows * FeedMultiplier;
            }
        }

    }
}
