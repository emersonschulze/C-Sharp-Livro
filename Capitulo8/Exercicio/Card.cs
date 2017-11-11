using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo8
{
    class Card
    {
        public Suits Suit;
        public Values Value;
        private string name;

        public string Name
        {
            get
            {
                return name;
            }
        }

        public Card(Values values, Suits suits)
        {
            this.Suit = suits;
            this.Value = values;
            name = Value+" of "+Suit;

        }

        public enum Suits
        {
            Spades = 0,
            Clubs = 1,
            Diamonds = 2,
            Hearts = 3,
        }

        public enum Values
        {
            Ace = 1,
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5,
            Six = 6,
            Seven = 7,
            Eight = 8,
            Nine = 9,
            Ten = 10,
            Jack = 11,
            Queen = 12,
            King = 13,
        }

       

    }
}
