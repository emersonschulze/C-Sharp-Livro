using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decks
{
    class Decks
    {
        private List<Card> cards;
        private Random random = new Random();

        public Decks()
        {
            cards = new List<Card>();
            for (int suit = 0; suit < cards.Count; suit++)
            {
                for(int value = 0; value < cards.Count; value++)
                {
                    cards.Add(new Card((Card.Suits)suit, (Card.Values)value));
                }
            }
        }

        public Decks(Card[] initialCard)
        {
            cards = new List<Card>(initialCard);
        }

        public int Count { get { return cards.Count; } }

        public void Add(Card cardToAdd)
        {
            cards.Add(cardToAdd);
        }

        public Card Deal(int index)
        {
            Card CardToDeal = cards[index];
            cards.RemoveAt(index);
            return CardToDeal;
        }

        public void Shuffle()
        {
            List<Card> NewCards = new List<Card>();
            while(cards.Count > 0)
            {
                int CardToMove = random.Next(cards.Count);
                NewCards.Add(cards[CardToMove]);
                cards.RemoveAt(CardToMove);
            }
            cards = NewCards;
        }

        public string[] GetCardNames()
        {
            string[] CardNames = new string[cards.Count];
            for(int i = 0; i < cards.Count; i++)
                CardNames[i] = cards[i].Name;
            return CardNames;
        }

        public void Sort()
        {
            cards.Sort(new CardCompare_BySuit());
        }
        
    }
}
